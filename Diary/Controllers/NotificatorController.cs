using Microsoft.AspNetCore.Mvc;
using Reporting.Abstractions;

namespace Diary.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class NotificatorController : ControllerBase {
        private readonly IDailyBirthdayNotificator _birthdayNotificator;

        public NotificatorController(IDailyBirthdayNotificator dailyBirthdayNotificator) {
            _birthdayNotificator = dailyBirthdayNotificator;
        }

        [HttpPost("RunBirthday")]
        public void RunBirthdayNotifications() {
            _birthdayNotificator.Run();
        }

        [HttpPost("StopBirthday")]
        public void StopBirthdayNotifications() {
            _birthdayNotificator.Stop();
        }
    }
}
