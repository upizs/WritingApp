namespace WritingApp
{
    public class DirectoryItem
    {
        public DirectoryItemType Type { get; set; }

        public string FullPath { get; set; }

        public string Name { get { return DirectoryStructure.GetFileFolderName(this.FullPath); } }
    }
}
