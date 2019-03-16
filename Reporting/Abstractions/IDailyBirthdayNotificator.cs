namespace Reporting.Abstractions {
    public interface IDailyBirthdayNotificator {
        void Run();
        void Stop();
    }
}
