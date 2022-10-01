using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Artemis.Core;
using Artemis.Core.Modules;
using Artemis.Core.Services;

namespace Artemis.Plugins.Misc.DataModelExpansion.DataModels
{
    public class MiscDataModel : DataModel
    {
        [DllImport("user32.dll")] static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")] static extern uint GetWindowThreadProcessId(IntPtr hwnd, IntPtr proccess);
        [DllImport("user32.dll")] static extern IntPtr GetKeyboardLayout(uint thread);

        public string CurrentKeyboardLayout { get
            {
                try
                {
                    IntPtr foregroundWindow = GetForegroundWindow();
                    uint foregroundProcess = GetWindowThreadProcessId(foregroundWindow, IntPtr.Zero);
                    int keyboardLayout = GetKeyboardLayout(foregroundProcess).ToInt32() & 0xFFFF;
                    return new CultureInfo(keyboardLayout).ToString();
                }
                catch (Exception _)
                {
                    return new CultureInfo(1033).ToString(); // Return English if something went wrong.
                }
            } 
        }
    }
}
