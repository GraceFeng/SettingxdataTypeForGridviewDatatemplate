using SettingxdataTypeForGridviewDatatemplate.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingxdataTypeForGridviewDatatemplate.Model
{
    public class SoundEffectButton
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public PlayCommand Play { get; set; }
    }
}