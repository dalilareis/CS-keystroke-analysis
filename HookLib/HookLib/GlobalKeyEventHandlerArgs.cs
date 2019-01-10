using System;
using System.Windows.Forms;

namespace HookLib
{
    public class GlobalKeyEventHandlerArgs : HandleableEventArgs
    {

        public int VirtualKeyCode { get; private set; }
        public int ScanCode { get; private set; }
        public int Flags { get; private set; }
        public int Time { get; private set; }
        public int ExtraInfo { get; private set; }
        public string Character { get; private set; }

        public GlobalKeyEventHandlerArgs(int virtualKeyCode, int scanCode, int flags, int time, int extraInfo, char? character)
        {
            VirtualKeyCode = virtualKeyCode;
            ScanCode = scanCode;
            Flags = flags;
            Time = time;
            ExtraInfo = extraInfo;

            // CONVERT VirtualKeyCode to String
            // Tip: use KeysConverter class!!
            KeysConverter kc = new KeysConverter();
            Character = kc.ConvertToString(virtualKeyCode);

        }
    }
}