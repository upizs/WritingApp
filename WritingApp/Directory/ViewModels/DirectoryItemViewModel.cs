using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;

namespace WritingApp
{
    public class DirectoryItemViewModel : BaseViewModel
    {
        #region Public Properties

        
        /// <summary>
        /// The type of this item
        /// </summary>
        public DirectoryItemType Type { get; set; }

        /// <summary>
        /// From a file type sets a Image name
        /// </summary>
        public string ImageName => Type == DirectoryItemType.File ? "file" : "folder";

        /// <summary>
        /// The full path to the item
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// The name of this directory item
        /// </summary>
        public string Name { get { return DirectoryStructure.GetFileFolderName(this.FullPath); } }

        /// <summary>
        /// A list of all children contained inside this item
        /// </summary>
        public ObservableCollection<DirectoryItemViewModel> Children { get; set; }

        /// <summary>
        /// Indicates if the curremt item is expanded or not
        /// </summary>
        public bool CanExpand { get { return this.Type != DirectoryItemType.File; } }

        public bool IsExpanded
        {
            get
            {
                return this.Children?.Count(f => f != null) > 0;
            }
            set
            {
                //If the UI tells us to expand...
                if (value == true)
                    //Find all children
                    Expand();
                //if the UI tells us to close
                else
                    this.ClearChildren();
            }
        }


        #endregion

        #region Public Commands

        public ICommand ExpandCommand { get; set; }

        #endregion

        #region Constructor

        public DirectoryItemViewModel(string fullPath, DirectoryItemType type)
        {
            //Create commands
            this.ExpandCommand = new RelayCommand(Expand);

            // Set path and type
            this.FullPath = fullPath;
            this.Type = type;

            // Setup the children as needed
            this.ClearChildren();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Removes all children from the list, adding a dummy item to show the expand icon if requared
        /// </summary>
        private void ClearChildren()
        {
            //Clear items
            this.Children = new ObservableCollection<DirectoryItemViewModel>();

            //Show the expand arrow if we are not a file
            if (this.Type != DirectoryItemType.File)
                this.Children.Add(null);
        }

        /// <summary>
        /// Expands this directory and finds all children
        /// </summary>
        private void Expand()
        {
            //IF fail dont expand
            if (this.Type == DirectoryItemType.File)
                return;

            //Find all children 
            var children = DirectoryStructure.GetDirectoryContents(this.FullPath);
            this.Children = new ObservableCollection<DirectoryItemViewModel>(
                children.Select(content => new DirectoryItemViewModel(content.FullPath, content.Type)));
        }

        #endregion


    }
}
