namespace Laboratorium_3._00.Models
{
    public interface IDateTimeProvider
    {
        DateTime GetCurrentDateTime();
    }

    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }

}
