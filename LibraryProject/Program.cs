using System;
using LibraryProject.Interfaces;
using LibraryProject.Classes;
namespace LibraryProject;

public class LibraryProjet
{
    static void Main(string[] args)
    {
        ILibraryItem[] items = new ILibraryItem[]
        {
            new Book("Book 1"),
            new Book("Book 2"),
            new Book("Book 3")
        };
        LibraryIndexer indexer = new LibraryIndexer(items);

        List<ISubModule> subModules = new List<ISubModule>()
        {
            new BorrowModule(indexer),
            new ListItemsModule(indexer)
        };

        LibraryApp app = new LibraryApp(subModules);

        app.Run();
    }
}