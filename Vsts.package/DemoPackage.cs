namespace Vsts.package
{
    using System.Threading.Tasks;
    using RandomNameGeneratorLibrary;

    public class DemoPackage : IDemoPackage
    {
        public string GetNames()
        {
            var personGenerator = new PersonNameGenerator();
            return personGenerator.GenerateRandomFirstAndLastName();
        }

        public Task<string> GetNamesAsync()
        {
            var personGenerator = new PersonNameGenerator();
            return Task.Run(() => personGenerator.GenerateRandomFirstAndLastName());
        }
    }
}
