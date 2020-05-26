
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WritingApp
{
    public static class DirectoryStructure
    {
        /// <summary>
        /// Gets the directories and files from a folder
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static List<DirectoryItem> GetDirectoryContents(string fullPath)
        {
            //create empthy list
            var items = new List<DirectoryItem>();

            #region Get Folders
            //Try and get directories from the local folder
            //Ignoring all the isues
            try
            {
                var dirs = Directory.GetDirectories(fullPath);

                if (dirs.Length > 0)
                    items.AddRange(dirs.Select(dir => new DirectoryItem { FullPath = dir, Type = DirectoryItemType.Folder }));


            }
            catch { }

            #endregion

            #region GetFiles

            //Try ang get all the files from the local folder
            try
            {
                var fs = Directory.GetFiles(fullPath);

                if (fs.Length > 0)
                    items.AddRange(fs.Select(file => new DirectoryItem { FullPath = file, Type = DirectoryItemType.File }));


            }
            catch { }

            #endregion

            return items;
        }


        #region Helpers

        public static string GetFileFolderName(string path)
        {
            //if there is no path, return empthy
            if (string.IsNullOrEmpty(path))
                return string.Empty;

            //Make all slashes backslashes
            var normalizePath = path.Replace('/', '\\');

            //find the last backslash
            int index = normalizePath.LastIndexOf('\\');

            //if backslash is not found return the path
            if (index <= 0)
                return path;

            return normalizePath.Substring(index + 1);
        }

        #endregion
    }
}
