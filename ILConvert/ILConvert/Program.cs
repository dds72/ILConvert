using System;
using System.Linq;
using System.Windows.Forms;

namespace ILConvert
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        if (args[0] == "help")
        {
          //Console.WriteLine("Usage:");
          //Console.WriteLine("  ILConvert.exe \"[opcode]\"");
          //Console.WriteLine("Example:");
          //Console.WriteLine("  ILConvert.exe \"neg\"");
          return;
        }
        else if (args[0] == "hook")
        {
          Application.Run(new ApplicationContext());
        }
      }
    }
  }
}
