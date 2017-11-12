namespace Vsts.package.Tests
{
    using Xunit;

    public class DemoPackageTests
    {
        [Fact]
        public void DemoPackage_returns_names()
        {
            // Arrange
            var demoPackage = new DemoPackage();
            // Act
            var result = demoPackage.GetNames();
            
            // Assert
            Assert.NotEmpty(result);
        }
    }
}
