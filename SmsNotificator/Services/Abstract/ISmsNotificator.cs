namespace SmsNotificator.Services.Abstract {
    public interface ISmsNotificator {
        void NotifyByPhoneNumber(string phoneNumber, string message);
    }
}
