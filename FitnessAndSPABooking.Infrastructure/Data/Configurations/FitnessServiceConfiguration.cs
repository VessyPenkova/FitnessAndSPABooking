using FitnessAndSPABooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FitnessAndSPABooking.Infrastructure.Data.Configurations
{
    public  class FitnessServiceConfiguration : IEntityTypeConfiguration<FitnessService>
    {
        public void Configure(EntityTypeBuilder<FitnessService> fitnessService)
        {
            fitnessService.HasKey(ss => new { ss.FitnessId, ss.ServiceId });
        }
    }
}
