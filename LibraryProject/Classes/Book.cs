using System;
using LibraryProject.Enums;
using LibraryProject.Interfaces;
namespace LibraryProject.Classes
{
    public class Book : ILibraryItem
    {
        private string _title;
        private ItemType _itemType = ItemType.Book;
        private Availability _availability = Availability.Available;

        public Book(string title)
        {
            this._title = title;
        }

        public string title => this._title;
        public ItemType itemType => this._itemType;
        public Availability availability => this._availability;

        public void ChangeAvailabilityStatus(Availability availabilityStatus)
        {
            this._availability = availabilityStatus;
        }
    }
}

