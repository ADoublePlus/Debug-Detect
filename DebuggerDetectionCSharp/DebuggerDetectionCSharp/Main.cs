using System.Diagnostics;
using System.Net;
using System.Collections.Generic;

namespace debug_detect
{
    public class Main
    {
        public static void Start(string urlForHashCheck, bool AntiDump, bool AntiDebug, bool AntiEmulation,
            List<string> AntiNetBlacklist)
        {
            WebRequest.DefaultWebProxy = new WebProxy();

            if (AntiDebug)
            {
                debug_detect.AntiDebug.Initialize();
            }
        }

        internal static void CmdWindow(string A_0)
        {
            Process.Start(new ProcessStartInfo("cmd.exe", "/c " + A_0)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            });
        }
    }
}