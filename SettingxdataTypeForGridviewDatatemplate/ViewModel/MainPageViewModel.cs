using SettingxdataTypeForGridviewDatatemplate.Command;
using SettingxdataTypeForGridviewDatatemplate.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace SettingxdataTypeForGridviewDatatemplate.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<SoundEffectButton> SoundEffects;

        public MainPageViewModel()
        {
            SoundEffects = new ObservableCollection<SoundEffectButton>();
            SoundEffects.Add(new SoundEffectButton { Name = "Button01", FileName = "Button01", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button02", FileName = "Button02", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button03", FileName = "Button03", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button04", FileName = "Button04", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button05", FileName = "Button05", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button06", FileName = "Button06", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button07", FileName = "Button07", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button08", FileName = "Button08", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button09", FileName = "Button09", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button10", FileName = "Button10", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button11", FileName = "Button11", Play = new PlayCommand() });
            SoundEffects.Add(new SoundEffectButton { Name = "Button12", FileName = "Button12", Play = new PlayCommand() });
        }

        public void PlayButton()
        {
            //TODO:
        }
    }
}