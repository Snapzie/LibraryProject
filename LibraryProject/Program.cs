using System;
namespace LibraryProject;

public class LibraryProjet
{
    static void Main(string[] args)
    {
        ISubModule borrowModule = new BorrowModule();
        LibraryApp app = new LibraryApp(new List<ISubModule>() {borrowModule});

        app.Run();
    }
}