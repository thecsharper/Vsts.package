namespace Vsts.package.Tests
{
    using Xunit;

    public class DemoPackageTests
    {
        [Fact]
        public void Test1()
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
