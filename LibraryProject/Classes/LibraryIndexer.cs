using System;
using LibraryProject.Interfaces;
namespace LibraryProject.Classes
{
    public class LibraryIndexer
    {
        private ILibraryItem[] _availableItems;
        private ILibraryItem[] _unavailableItems = new ILibraryItem[] {};

        public LibraryIndexer(ILibraryItem[] items)
        {
            this._availableItems = items;
        }

        public ILibraryItem[] GetAvailableItems()
        {
            return this._availableItems;
        }

        public ILibraryItem[] GetUnavailableItems()
        {
            return this._unavailableItems;
        }

        public bool FindItem(string itemTitle)
        {
            return Array.Exists(this._availableItems, x => x.title == itemTitle);
        }
    }
}

