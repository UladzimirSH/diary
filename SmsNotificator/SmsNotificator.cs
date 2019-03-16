using SmsNotificator.Services.Abstract;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SmsNotificator {
    public class SmsNotificator : ISmsNotificator {
        private const string AccountSid = "AC55269893b1b6c4d4fec700692d289b88";
        private const string AuthToken = "423931745ee768837f39eec6c8d8a83a";

        public SmsNotificator() {
            TwilioClient.Init(AccountSid, AuthToken);
        }

        public void NotifyByPhoneNumber(string phoneNumber, string message) {
            var to = new PhoneNumber(phoneNumber);
            MessageResource.Create(
                to,
                from: new PhoneNumber("+18628032061"),
                body: message);
        }
    }
}
