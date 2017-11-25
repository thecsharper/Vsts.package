namespace Vsts.package
{
    using System.Threading.Tasks;

    public interface IDemoPackage
    {
        string GetNames();

        Task<string> GetNamesAsync();
    }
}