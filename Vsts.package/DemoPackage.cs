namespace Vsts.package
{
    using RandomNameGeneratorLibrary;

    public class DemoPackage : IDemoPackage
    {
        public string GetNames()
        {
            var personGenerator = new PersonNameGenerator();
            return personGenerator.GenerateRandomFirstAndLastName();
        }
    }
}
