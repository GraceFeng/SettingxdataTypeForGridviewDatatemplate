using SettingxdataTypeForGridviewDatatemplate.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SettingxdataTypeForGridviewDatatemplate.Command
{
    public class PlayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var run = parameter as MainPageViewModel;

            //if (run == null)
            //{
            //    return true;
            //}
            //else
            //{
            //    if (run.SoundEffects.Count > 10)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            return true;
        }

        public void Execute(object parameter)
        {
            var run = new MainPageViewModel();
            run.PlayButton();
            CanExecuteChanged(this, EventArgs.Empty);
        }
    }
}