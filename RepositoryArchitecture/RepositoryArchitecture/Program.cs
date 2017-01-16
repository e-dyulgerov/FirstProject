using RepositoryArchitecture.Providers;
using RepositoryArchitecture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Git Repository Provider initialization
            RepositoryProvider provider = new RepositoryProvider(RepositoryType.GIT);
            
            //Registering a new repository of type GIT
            var repository = provider.RegisterRepository("https://edyulgerov.visualstudio.com/e-dyulgerov/DefaultCollection/_git/MyFirstProject");

            //Initialize a secure Git Repository - the url is already kept during the registration
            repository.Init("edyulgerov", "Evg3n!1234");

            //Cloning a remote repository
            repository.Clone(@"C:\Users\evgeni.dyulgerov\Desktop\Test Repository");

            //
        }
    }
}
