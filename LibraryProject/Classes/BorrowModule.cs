using System;
using LibraryProject.Classes;
namespace LibraryProject
{
    public class BorrowModule : ISubModule
    {
        private string _name = "Borrow";
        private LibraryIndexer _indexer;

        public BorrowModule(LibraryIndexer indexer)
        {
            this._indexer = indexer;
        }

        public string name => _name;

        public string GetInfo()
        {
            return "Type \'Borrow\' to borrow an item.";
        }

        public void RunModule()
        {
            Console.WriteLine("Name title to borrow:");
            string item = Console.ReadLine();
            bool foundItem = this._indexer.FindItem(item);
            Console.WriteLine(foundItem);
        }
    }
}

