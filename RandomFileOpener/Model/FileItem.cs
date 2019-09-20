using System.ComponentModel;

namespace RandomFileOpener.Model
{
    public class FileItem
    {
        private static int _counter = 0;
        public FileItem() => this.Id = _counter++;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Extention { get; set; }
        public string GetFullName() => this.Name + this.Extention;
    }
}
