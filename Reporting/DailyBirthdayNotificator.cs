using System;
using System.Linq;
using System.Timers;
using Domain.Services.Services.Abstract;
using Reporting.Abstractions;
using SmsNotificator.Services.Abstract;

namespace Reporting {
    public class DailyBirthdayNotificator : IDailyBirthdayNotificator {
        private Timer _timer;
        private readonly ISmsNotificator _smsNotificator;
        private readonly IFriendService _friendService;
        private const string MyPhoneNumber = "+375292526409";

        public DailyBirthdayNotificator(ISmsNotificator smsNotificator, IFriendService friendService) {
            _smsNotificator = smsNotificator;
            _friendService = friendService;

            InitializeTimer();
        }

        private void InitializeTimer() {
            _timer = new Timer { Interval = new TimeSpan(1, 0, 0).TotalMilliseconds, AutoReset = true };
            _timer.Elapsed += TrySendNotification;
        }

        public void Run() => _timer.Start();

        public void Stop() => _timer.Stop();

        private void TrySendNotification(object sender, ElapsedEventArgs e) {
            DateTime currentMinskTime = DateTime.UtcNow.AddHours(3);

            if (IsTimeToSendNotification(currentMinskTime)) {
                _timer.Stop();
                var tomorrowBirthdayFriends = _friendService.GetFriendsByDayOfBirth(currentMinskTime.AddDays(-1));
                if (tomorrowBirthdayFriends.Any()) {
                    string message = "Tomorrow's birthday is at: ";
                    foreach (var friendModel in tomorrowBirthdayFriends) {
                        message = message + friendModel.Name;
                    }
                    _smsNotificator.NotifyByPhoneNumber(MyPhoneNumber, message);
                }

                var todayBirthdayFriends = _friendService.GetFriendsByDayOfBirth(currentMinskTime);

                if (todayBirthdayFriends.Any()) {
                    string message = "Todays's birthday is at: ";
                    foreach (var friendModel in todayBirthdayFriends) {
                        message = message + " " +  friendModel.Name;
                    }
                    _smsNotificator.NotifyByPhoneNumber(MyPhoneNumber, message);
                }
            }
        }

        //private bool IsTimeToSendNotification(DateTime dateTime) => true;
        private bool IsTimeToSendNotification(DateTime dateTime) => dateTime.Hour == 9;
    }
}
