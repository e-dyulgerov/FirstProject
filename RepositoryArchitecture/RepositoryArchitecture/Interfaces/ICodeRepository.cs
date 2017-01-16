namespace RepositoryArchitecture.Interfaces
{
    using RepositoryArchitecture.Repositories;
    using System.Collections.Generic;
    public interface ICodeRepository
    {
        string RepositoryURL
        {
            get;
        }
        //void ?
        void ValidateUrl(string url);
        void Init(string username, string password);
        IList<Branch> GetBranches();
        void Clone(string localPath);
        void Clone(string localPath, string remotePath);
        void Update(string branchName);
        void SwitchBranch(string remoteBranchName);
        void SwitchBranch(string remoteBranchName, string localBranchName);
        void DeleteBranch(string branchName);
        void MergeBranches(string mergingBranch, string mergedIntoBranch);
        void Remove(string url);
    }
}
