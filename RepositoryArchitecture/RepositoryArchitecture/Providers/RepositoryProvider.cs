namespace RepositoryArchitecture.Providers
{
    using RepositoryArchitecture.Exceptions;
    using RepositoryArchitecture.Interfaces;
    using RepositoryArchitecture.Repositories;
    using System.Collections.Generic;
    using System.Linq;
    public class RepositoryProvider: IRepositoryProvider
    {
        private readonly RepositoryType _type;
        private IList<ICodeRepository> repositories;
        public RepositoryProvider(RepositoryType type)
        {
            repositories = new List<ICodeRepository>();
            _type = type;
        }

        public ICodeRepository RegisterRepository(string url)
        {
            ICodeRepository repository;
            switch (_type)
            {
                case RepositoryType.GIT:
                    repository = new GitCodeRepository(url);
                    break;
                case RepositoryType.SVN:
                    repository = new SvnCodeRepository(url);
                    break;
                case RepositoryType.TFS:
                    repository = new TfsCodeRepository(url);
                    break;
                default:
                    repository = null;
                    throw new RepositoryException("The given repository type is not supported");
            }

            repositories.Add(repository);
            return repository;
        }

        public IList<ICodeRepository> GetRepositories()
        {
            return repositories;
        }

        public ICodeRepository GetRepository(string url)
        {
            return repositories.Where(x => x.RepositoryURL.Equals(url)).FirstOrDefault();
        }

        public void RemoveRepository(string url)
        {
            var repository = repositories.Where(x => x.RepositoryURL.Equals(url)).FirstOrDefault();
            repository.Remove(repository.RepositoryURL);
            repositories.Remove(repository);
        }
    }
}
