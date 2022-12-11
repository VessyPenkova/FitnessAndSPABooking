

namespace FitnessAndSPABooking.Core.Contracts
{
    public interface IDateTimeService
    {
        DateTime ConvertStrings(string date, string time);
    }
}
