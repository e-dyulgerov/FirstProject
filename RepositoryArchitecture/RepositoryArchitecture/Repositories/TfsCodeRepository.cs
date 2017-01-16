namespace RepositoryArchitecture.Repositories
{
    using RepositoryArchitecture.Interfaces;
    using System;
    using System.Collections.Generic;
    public class TfsCodeRepository : ICodeRepository
    {
        private readonly string _repositoryUrl;
        private string _username;
        private string _password;

        public TfsCodeRepository(string url)
        {
            _repositoryUrl = url;
        }

        public string RepositoryURL => throw new NotImplementedException();

        public void ValidateUrl(string url)
        {
            throw new NotImplementedException();
        }

        public void Init(string username, string password)
        {
            throw new NotImplementedException();
        }

        public IList<Branch> GetBranches()
        {
            throw new NotImplementedException();
        }

        public void Clone(string localPath)
        {
            throw new NotImplementedException();
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

        public void Init(string url)
        {
            throw new NotImplementedException();
        }
    }
}
