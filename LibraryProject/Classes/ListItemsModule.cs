using System;
using LibraryProject.Interfaces;
namespace LibraryProject.Classes
{
    public class ListItemsModule : ISubModule
    {
        private string _name = "List items";
        private LibraryIndexer _indexer;
        public ListItemsModule(LibraryIndexer indexer)
        {
            this._indexer = indexer;
        }

        public string name => _name;

        public string GetInfo()
        {
            return "Type \'List items\' to see all items.";
        }

        public void RunModule()
        {
            ILibraryItem[] availableItems = this._indexer.GetAvailableItems();
            ILibraryItem[] unavailableItems = this._indexer.GetUnavailableItems();

            Console.WriteLine("Available items:");
            foreach (ILibraryItem item in availableItems)
            {
                Console.WriteLine("\t- {0}", item.title);
            }

            Console.WriteLine("Unavailable items:");
            foreach (ILibraryItem item in unavailableItems)
            {
                Console.WriteLine("\t- {0}", item.title);
            }
        }
    }
}

