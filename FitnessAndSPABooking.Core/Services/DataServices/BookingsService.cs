using FitnessAndSPABooking.Core.Contracts;
using FitnessAndSPABooking.Core.Services.MapperSrvices;
using FitnessAndSPABooking.Infrastructure.Data.Common.ContractsRepositories;
using FitnessAndSPABooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Core.Services.DataServices
{
    public class BookingsService : IBookingsService
    {
        private readonly IDeletableEntityRepository<Booking> bookingsRepository;

        public BookingsService(IDeletableEntityRepository<Booking> _bookingsRepository)
        {
            bookingsRepository = _bookingsRepository;
        }

        public async Task<T> GetByIdAsync<T>(string id)
        {
            var booking =
                await bookingsRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return booking;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var appointments =
                await this.bookingsRepository
                .All()
                .OrderByDescending(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetAllByFitnessAsync<T>(string fitnessId)
        {
            var booking =
                await this.bookingsRepository
                .All()
                .Where(x => x.FitnessId == fitnessId)
                .OrderByDescending(x => x.DateTime)
                .To<T>().ToListAsync();
            return booking;
        }

        public async Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId)
        {
            var booking =
                await this.bookingsRepository
                .All()
                .Where(x => x.UserId == userId
                        && x.DateTime.Date > DateTime.UtcNow.Date)
                .OrderBy(x => x.DateTime)
                .To<T>().ToListAsync();
            return booking;
        }

        public async Task<IEnumerable<T>> GetPastByUserAsync<T>(string userId)
        {
            var booking =
                await this.bookingsRepository
                .All()
                .Where(x => x.UserId == userId
                        && x.DateTime.Date < DateTime.UtcNow.Date
                        && x.Confirmed == true)
                .OrderBy(x => x.DateTime)
                .To<T>().ToListAsync();
            return booking;
        }

        public async Task AddAsync(string userId, string fitnessId, int serviceId, DateTime dateTime)
        {
            await this.bookingsRepository.AddAsync(new Booking
            {
                Id = Guid.NewGuid().ToString(),
                DateTime = dateTime,
                UserId = userId,
                FitnessId = fitnessId,
                ServiceId = serviceId,
            });
            await this.bookingsRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var booking =
                await this.bookingsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.bookingsRepository.Delete(booking);
            await bookingsRepository.SaveChangesAsync();
        }

        public async Task ConfirmAsync(string id)
        {
            var booking =
                await bookingsRepository
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            booking.Confirmed = true;
            await bookingsRepository.SaveChangesAsync();
        }

        public async Task DeclineAsync(string id)
        {
            var booking =
                await bookingsRepository
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            booking.Confirmed = false;
            await bookingsRepository.SaveChangesAsync();
        }

        public async Task RateBookingAsync(string id)
        {
            var booking =
                await this.bookingsRepository
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            booking.IsFitnessRatedByTheUser = true;
            await this.bookingsRepository.SaveChangesAsync();
        }

       
    }
}
