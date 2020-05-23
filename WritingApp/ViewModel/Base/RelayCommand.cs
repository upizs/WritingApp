
using System;
using System.Windows.Input;

namespace FileManager
{
    /// <summary>
    /// A basic command that runs an Action
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private Members

        /// <summary>
        /// Action to run
        /// </summary>
        private Action mAction;

        #endregion

        #region Public Events



        /// <summary>
        /// The ecen thats fired when the <see cref="CanExecute(object)" value has changed/>
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => {};
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayCommand(Action action)
        {
            mAction = action;
        }

        #endregion

        #region Command Methods


        /// <summary>
        /// A relay command can alwats execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }
       
        /// <summary>
        /// Executes this commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction();
        }


        #endregion
    }
}
