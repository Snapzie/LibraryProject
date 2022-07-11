using System;
using LibraryProject.Enums;
namespace LibraryProject.Interfaces
{
    public interface ILibraryItem
    {
        public string title { get; }
        public ItemType itemType { get; }
        public Availability availability { get; }
        public void ChangeAvailabilityStatus(Availability availabilityStatus);
    }
}

