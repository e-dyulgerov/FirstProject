namespace RepositoryArchitecture.Interfaces
{
    using System.Collections.Generic;
    public interface IRepositoryProvider
    {
        ICodeRepository RegisterRepository(string url);
        void RemoveRepository(string url);
        IList<ICodeRepository> GetRepositories();
        ICodeRepository GetRepository(string url);
    }
}
