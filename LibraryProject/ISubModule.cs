using System;
namespace LibraryProject
{
    public interface ISubModule
    {
        public string name { get; }
        public string GetInfo();
        public void RunModule();
    }
}

