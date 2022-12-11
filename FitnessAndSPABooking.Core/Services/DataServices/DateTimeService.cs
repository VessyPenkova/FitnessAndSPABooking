using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Core.Contracts;
using System;

using System.Globalization;


namespace FitnessAndSPABooking.Core.Services.DataServices
{
    public  class DateTimeService : IDateTimeService
    {
        public DateTime ConvertStrings(string date, string time)
        {
            string dateString = date + " " + time;
            string format = GlobalConstants.DateTimeFormats.DateTimeFormat;

            DateTime dateTime = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

            return dateTime;
        }
    }
}
