namespace RepositoryArchitecture.Repositories
{
    using LibGit2Sharp;
    using RepositoryArchitecture.Exceptions;
    using RepositoryArchitecture.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class GitCodeRepository : ICodeRepository
    {
        private readonly string _repositoryUrl;
        private string _username;
        private string _password;
        private static Regex _gitUrlRegex = new Regex(@"((git|rsync|ssh|http(s)?)|(git@[\w\.]+))(:(//)?)([\w\.@\:/\-~]+)(\.git)(/)?", RegexOptions.IgnoreCase);

        public string RepositoryURL
        {
            get { return _repositoryUrl; }
        }

        public GitCodeRepository(string url)
        {
            //ValidateUrl(url);
            _repositoryUrl = url;
        }

        public void ValidateUrl(string url)
        {
            if (!_gitUrlRegex.Match(url).Success)
                throw new RepositoryException($"{url} is not a valid git repository URL");
        }

        public void Init(string username, string password)
        {
            //ValidateUrl(_repositoryUrl);
            _username = username;
            _password = password;
        }

        public IList<Branch> GetBranches()
        {
            throw new NotImplementedException();
        }

        public void Clone(string localPath)
        {
            var co = new CloneOptions()
            {
                CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials { Username = _username, Password = _password }
            };
            Repository.Clone(_repositoryUrl, localPath, co);
        }

        public void Clone(string localPath, string remotePath)
        {
            throw new NotImplementedException();
        }

        public void Update(string branchName)
        {
            throw new NotImplementedException();
        }

        public void SwitchBranch(string remoteBranchName)
        {
            throw new NotImplementedException();
        }

        public void SwitchBranch(string remoteBranchName, string localBranchName)
        {
            throw new NotImplementedException();
        }

        public void DeleteBranch(string branchName)
        {
            throw new NotImplementedException();
        }

        public void MergeBranches(string mergingBranch, string mergedIntoBranch)
        {
            throw new NotImplementedException();
        }

        public void Remove(string url)
        {
            throw new NotImplementedException();
        }

    }
}
