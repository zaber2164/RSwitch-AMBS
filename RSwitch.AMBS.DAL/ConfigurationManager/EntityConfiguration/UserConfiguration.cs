using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RSwitch.AMBS.Model.User;

namespace RSwitch.AMBS.DAL.ConfigurationManager.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<LoginUser>
    {
        public void Configure(EntityTypeBuilder<LoginUser> builder)
        {
            builder.ToTable("User");
        }
    }
}
