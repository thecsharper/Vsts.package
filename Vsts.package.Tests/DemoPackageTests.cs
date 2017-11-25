namespace Vsts.package.Tests
{
    using System.Threading.Tasks;
    using Xunit;

    public class DemoPackageTests
    {
        [Fact]
        public void GetNames_returns_name()
        {
            // Arrange
            var demoPackage = new DemoPackage();
            // Act
            var result = demoPackage.GetNames();
            
            // Assert
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetNamesAsync_returns_name()
        {
            // Arrange
            var demoPackage = new DemoPackage();
            // Act
            var result = await demoPackage.GetNamesAsync();

            // Assert
            Assert.NotEmpty(result);
        }
    }
}
