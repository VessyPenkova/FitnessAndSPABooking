using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FitnessAndSPABooking.Infrastructure.Data.Models;

namespace FitnessAndSPABooking.Infrastructure.Data.Configurations
{
    internal class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> booking)
        {
            booking
                .HasOne(a => a.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(a => a.UserId);

            booking
                .HasOne(a => a.Fitness)
                .WithMany(s => s.Bookings)
                .HasForeignKey(a => a.FitnessId);

            booking
                .HasOne(a => a.Service)
                .WithMany(s => s.Bookings)
                .HasForeignKey(a => a.ServiceId);

            booking
                .HasOne(a => a.FitnessService)
                .WithMany(ss => ss.Bookings)
                .HasForeignKey(a => new { a.FitnessId, a.ServiceId });
        }
    }
}
