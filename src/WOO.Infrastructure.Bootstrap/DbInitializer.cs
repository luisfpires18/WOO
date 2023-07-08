namespace WOO.Infrastructure.Bootstrap
{
    using AutoFixture;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using WOO.Data.Repository.Contexts;
    using WOO.Data.Repository.Model;

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

                if (!context.Players.Any())
                {
                    var player = fixture
                        .Build<Player>()
                        .Without(player => player.PlayerId)
                        .With(player => player.Username, "luisfpires")
                        .Create();

                    var players = new List<Player>
                    {
                        player,
                    };

                    context.Players.AddRange(players);
                }

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