using CarRandomManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRandomManagement.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<CarRandomManagementUser>
    {
        public void Configure(EntityTypeBuilder<CarRandomManagementUser> builder)
        {

        }
    }
}
