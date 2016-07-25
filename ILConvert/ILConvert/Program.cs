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
          Console.WriteLine("Usage:");
          Console.WriteLine("  ILConvert.exe \"[opcode]\"");
          Console.WriteLine("Example:");
          Console.WriteLine("  ILConvert.exe \"neg\"");
          return;
        }
        else if (args[0] == "hook")
        {
          InterceptKeys.onKeyPressed += KeyPressed;
          InterceptKeys.Start();
        }
      }
    }

    static void KeyPressed()
    {
      if (!Clipboard.ContainsText())
      {
        Console.WriteLine("Empty clipboard.");
        return;
      }
      string Instruction = Clipboard.GetText();
      var Instructions =
        ILCodesTable.codesTable.Where(x => x.InstructionHash == Instruction);
      ILCode ilCode;
      if (Instructions.Count() == 1)
      {
        ilCode = Instructions.First();
        MessageBox.Show(
        "Instruction:\r\n" +
        ilCode.Instruction +
        "\r\n\r\nDescription:\r\n" +
        ilCode.Description +
        "\r\n\r\nType:\r\n" +
        ilCode.Type);
        return;
      }
      else
      {
        MessageBox.Show("Not found!");
      }
    }
  }
}
