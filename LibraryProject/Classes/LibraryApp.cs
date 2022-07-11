using System;
using LibraryProject.Classes;
namespace LibraryProject
{
    public class LibraryApp
    {
        private string _startInfo = "Welcome to LibraryApp!\nWhat do you want to do?";
        private List<ISubModule> _modules;


        public LibraryApp(List<ISubModule> modules)
        {
            this._modules = modules;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine(this._startInfo);
                WriteInfo();
                string choice = Console.ReadLine();

                ISubModule module = this._modules.Find(x => x.name == choice);
                if (module is null)
                {
                    Console.WriteLine("Unrecognisable choice.");
                }else
                {
                    module.RunModule();
                }
            }
        }

        private void WriteInfo()
        {
            foreach (ISubModule mod in this._modules)
            {
                Console.WriteLine("\t- {0}", mod.GetInfo());
            }
        }
    }
}

