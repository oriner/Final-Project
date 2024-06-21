using BloodBankingSystem.Models;
using BloodBankingSystem.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace BloodBankingSystem.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public async Task AddUserAsync_ShouldAddUser()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "test_database")
                .Options;

            using (var context = new ApplicationDbContext(options))
            {
                var userStoreMock = new Mock<IUserStore<ApplicationUser>>();
                var userManagerMock = new Mock<UserManager<ApplicationUser>>(
                     userStoreMock.Object,
                    new Mock<IOptions<IdentityOptions>>().Object,
                    new Mock<IPasswordHasher<ApplicationUser>>().Object,
                    new IUserValidator<ApplicationUser>[0],
                    new IPasswordValidator<ApplicationUser>[0],
                    new Mock<ILookupNormalizer>().Object,
                    new Mock<IdentityErrorDescriber>().Object,
                    new Mock<IServiceProvider>().Object,
                    new Mock<ILogger<UserManager<ApplicationUser>>>().Object
                );

                var userService = new UserService(userManagerMock.Object);

                // Create a mock user object
                var user = new ApplicationUser
                {
                    UserName = "test_user",
                    Email = "test@example.com",
                    FirstName = "Test",
                    LastName = "User",
                    PhoneNumber = "1234567890",
                    BloodType = "A+",
                    Address = "123 Main St"
                };

                // Act
                var result = await userService.AddUserAsync(user, "Password123");

                // Assert
                Assert.True(result.Succeeded);
                Assert.NotNull(await context.Users.FirstOrDefaultAsync(u => u.Email == "test@example.com"));
            }
        }
    }
}
