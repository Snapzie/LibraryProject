using System;
namespace LibraryProject
{
    public class LibraryApp
    {
        private string startInfo = "Welcome to LibraryApp!\nWhat do you want to do?";
        private List<ISubModule> modules;


        public LibraryApp(List<ISubModule> modules)
        {
            this.modules = modules;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine(this.startInfo);
                WriteInfo();
                string choice = Console.ReadLine();

                ISubModule module = this.modules.Find(x => x.name == choice);
                if (module is null)
                {
                    Console.WriteLine("Unrecognisable choice.");
                }else
                {
                    module.RunModule();
                }

                //foreach (ISubModule mod in this.modules)
                //{
                //    if (choice == mod.name)
                //    {
                //        mod.RunModule();
                //        break;
                //    }
                //}
            }
        }

        private void WriteInfo()
        {
            foreach (ISubModule mod in this.modules)
            {
                Console.WriteLine("\t- {0}", mod.GetInfo());
            }
        }
    }
}

