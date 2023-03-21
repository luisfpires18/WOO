namespace WOO.Infrastructure.Bootstrap
{
    using AutoFixture;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using WOO.Data.Contexts;

    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            var fixture = new Fixture();

            try
            {
                WooDBContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetService<WooDBContext>();

                //if (!context.Roles.Any())
                //{
                //    context.Roles.AddAsync(new IdentityRole
                //    {
                //        Name = UserRoles.ADMIN,
                //        NormalizedName = UserRoles.ADMIN,
                //    });
                //    context.Roles.AddAsync(new IdentityRole
                //    {
                //        Name = UserRoles.MEMBER,
                //        NormalizedName = UserRoles.MEMBER,
                //    });
                //}

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                throw;
            }
        }
    }
}