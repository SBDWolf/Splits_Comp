using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splits_Computation
{
    internal class PythonUtility
    {
        // for... some reason, executing a python script directly would return an empty string, and i couldn't find a solution with that method
        // instead we are going to execute a .bat file that executes the python script, and capture the output of the .bat
        // for... some reason, this works
        // this is such a hacky solution and hate it and love it at the same time
        public static string ExecuteBatch(string args)
        {
            var p = new Process();

            p.StartInfo.Arguments = args;
            p.StartInfo.FileName = ".\\execute.bat";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.EnableRaisingEvents = true;

            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }

    }
}
