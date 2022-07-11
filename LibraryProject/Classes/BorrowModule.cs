using System;
namespace LibraryProject
{
    public class BorrowModule : ISubModule
    {
        private string _name = "Borrow";
        public string name
        {
            get
            {
                return _name;
            }
        }

        public string GetInfo()
        {
            return "Type \'Borrow\' to borrow an item.";
        }

        public void RunModule()
        {
            Console.WriteLine("Ran BorrowModule");
        }
    }
}

