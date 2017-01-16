namespace RepositoryArchitecture.Repositories
{
    public class Branch
    {
        public string Name { get; }
        public string LastCommitId { get; }

        public Branch(string name, string lastCommitId)
        {
            this.Name = name;
            this.LastCommitId = lastCommitId;
        }
    }
}
