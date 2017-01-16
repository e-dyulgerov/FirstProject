namespace RepositoryArchitecture.Exceptions
{
    using System;
    public class RepositoryException : Exception
    {
        public RepositoryException(string message) : base(message)
        {
        }
    }
}
