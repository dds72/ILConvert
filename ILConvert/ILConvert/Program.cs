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
      string Instruction = String.Empty;
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
        Instruction = args[0];
      }
      else
      {
        if (Clipboard.ContainsText())
        {
          Instruction = Clipboard.GetText();
        }
      }
      if (Instruction == String.Empty)
      {
        return;
      }
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
