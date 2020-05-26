using System.Collections.ObjectModel;
using System.Linq;


namespace WritingApp
{
    public class DirectoryStructureViewModel : BaseViewModel
    {
        #region Public Properties

        public string mainFolder = @"D:\Projects\WritingApp\WritingApp\Docs";

        /// <summary>
        /// A list of all directories in the main folder
        /// </summary>
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }

        #endregion

        #region ConStructor

        public DirectoryStructureViewModel()
        {
            //Get the content from the main folder
            var children = DirectoryStructure.GetDirectoryContents(mainFolder);

            //Create the view models from the main folder
            this.Items = new ObservableCollection<DirectoryItemViewModel>(
                children.Select(content => new DirectoryItemViewModel(content.FullPath, content.Type)));
        }

        #endregion
    }
}
