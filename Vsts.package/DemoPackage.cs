namespace Vsts.package
{
    using RandomNameGeneratorLibrary;

    public class DemoPackage
    {
        public string GetNames()
        {
            var personGenerator = new PersonNameGenerator();
            return personGenerator.GenerateRandomFirstAndLastName();
        }
    }
}
