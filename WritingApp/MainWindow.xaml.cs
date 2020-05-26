using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace WritingApp
{
    //TODO: Create a new file or folder button
    //TODO: Read the file in the paperbox and edit it and save it
    //TODO: Toggle button for the directory panel
    //TODO: Do all the other toppanel buttons from left to right
    //TODO: Do the formating panel
    //TODO: Right mouse click and options
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Default Constructor

        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new WindowViewModel(this);
        }
        
        #endregion

//        #region On loaded

        
//        private void Window_Loaded(object sender, RoutedEventArgs e)
//        {

//            LoadTreeView();
           
//        }

        

//        #endregion

//        #region Helpers

//        /// <summary>
//        /// Gets full path and return the file/folder name 
//        /// </summary>
//        /// <param name="path"></param>
//        /// <returns></returns>
//        public static string GetFileFolderName(string path)
//        {
//            //if there is no path, return empthy
//            if (string.IsNullOrEmpty(path))
//                return string.Empty;

//            //Make all slashes backslashes
//            var normalizePath = path.Replace('/', '\\');

//            //find the last backslash
//            int index = normalizePath.LastIndexOf('\\');

//            //if backslash is not found return the path
//            if (index <= 0)
//                return path;

//            return normalizePath.Substring(index + 1);
//        }


//        /// <summary>
//        /// Loads the first folders and files from the main directory
//        /// For when the app has just started
//        /// </summary>
//        private void LoadTreeView()
//        {
//            #region get folders

//            //save the path to the local main directory
//            var fullPath = @"D:\Projects\WritingApp\WritingApp\Docs";

//            //create a blank list for paths
//            var directories = new List<string>();

//            //try to get folders from the path
//            //doesnt do anything in case of error (bad habit) will fix when I will know how.
//            try
//            {
//                //get all the folder paths
//                var dirs = Directory.GetDirectories(fullPath);
//                //if there are paths add them to the list
//                if (dirs.Length > 0)
//                    directories.AddRange(dirs);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }


//            directories.ForEach(directoryPath =>
//            {
//                //create a new instance of an item
//                var item = new TreeViewItem()
//                {
//                    //get the folder name from the path
//                    Header = GetFileFolderName(directoryPath),

//                    //add the full path to the tag
//                    Tag = directoryPath
//                };

//                //add dummy item so that the expanding button is there
//                item.Items.Add(null);

//                ////Listen for item being expanded
//                item.Expanded += Folder_Expanded;

//                FolderView.Items.Add(item);
//            });

//            #endregion

//            #region get files

//            var files = new List<string>();

//            try
//            {
//                var fs = Directory.GetFiles(fullPath);
//                if (fs.Length > 0)
//                    files.AddRange(fs);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//            files.ForEach(filePath =>
//            {
//                var item = new TreeViewItem()
//                {
//                    Header = GetFileFolderName(filePath),

//                    Tag = filePath
//                };

//                //add file to the treeview
//                FolderView.Items.Add(item);
//            });

//            #endregion
//        }


//        //Something is wrong at the end of the branch it is going through every opened folder on that branch. something with listening
//        private void Folder_Expanded(object sender, RoutedEventArgs e)
//        {
//            var item = (TreeViewItem)sender;

//            //if the item doesnt contains dummy data return nothing
//            //meaning it is already open and doesnt need to go through this.
//            //(int)item.Items.Count != 1 && 
//            if (item.Items[0] != null)
//                return;

//            //clear dummy data
//            item.Items.Clear();

//            //Get folder path
//            var fullPath = (string)item.Tag;

//            #region get subFolder
//            //create a blank list for paths
//            var directories = new List<string>();

//            //try to get folders from the path
//            //doesnt do anything in case of error (bad habit) will fix when I will know how.
//            try
//            {
//                //get all the folder paths
//                var dirs = Directory.GetDirectories(fullPath);
//                //if there are paths add them to the list
//                if (dirs.Length > 0)
//                    directories.AddRange(dirs);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }


            
//            directories.ForEach(directoryPath =>
//                {
//            //create a new instance of an item
//            var subItem = new TreeViewItem()
//                    {
//                //get the folder name from the path
//                Header = GetFileFolderName(directoryPath),

//                //add the full path to the tag
//                Tag = directoryPath
//                    };

//            //add dummy item so that the expanding button is there
//            subItem.Items.Add(null);

//            ////Handle expanding
//            subItem.Expanded += Folder_Expanded;

//            //Add to the Treeview
//            item.Items.Add(subItem);
//                }); 
            

//            #endregion

//            #region get subFiles

//            var files = new List<string>();

//            try
//            {
//                var fs = Directory.GetFiles(fullPath);
//                if (fs.Length > 0)
//                    files.AddRange(fs);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//            files.ForEach(filePath =>
//            {
//                var subItem = new TreeViewItem()
//                {
//                    Header = GetFileFolderName(filePath),

//                    Tag = filePath
//                };

//                //add file to the treeview
//                item.Items.Add(subItem);
//            });

//            #endregion


//        }

//#endregion
   }
}
