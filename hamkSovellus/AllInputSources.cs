using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace hamkSovellus
{
    public class AllInputSources
    {
        [DllImport("User32.dll")]  //Tietoa ei ole saatavilla .netissä joten haetaan manuaalisesti
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        public DateTime GetLastInputTime() // GetLastInputTime hakee ajan viimeisestä syötteestä joka on annettu
        {
            var lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo); // Metodin määrittelyä

            GetLastInputInfo(ref lastInputInfo);

            return DateTime.Now.AddMilliseconds(-(Environment.TickCount - lastInputInfo.dwTime)); // return palauttaa arvoja
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct LASTINPUTINFO
        {
            public uint cbSize;  //uint: 0 to 4294967295 kun taas int on –2147483648 to 2147483647. 
            //cbSize = The size of the structure, in bytes. This member must be set to sizeof(LASTINPUTINFO).
            public uint dwTime;
            // dwTime = The tick count when the last input event was received.
        }
    }
}
