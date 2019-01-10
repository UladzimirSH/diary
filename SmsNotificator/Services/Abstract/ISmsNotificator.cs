using System;
namespace SmsNotificator
{
    public interface ISmsNotificator
    {
        void NotifyByPhoneNumber(string phoneNumber, string message);
    }
}
