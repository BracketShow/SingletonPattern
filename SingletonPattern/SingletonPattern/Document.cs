namespace SingletonPattern
{
    public class Document
    {
        public Document(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}