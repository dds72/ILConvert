using System.Linq;
using System.Windows.Forms;

namespace ILConvert
{
  static class ILCodeMatcher
  {
    public static void Show()
    {
      if (!Clipboard.ContainsText())
      {
        //Console.WriteLine("Empty clipboard.");
        return;
      }
      string Instruction = Clipboard.GetText().Trim();
      var Instructions =
        ILCodesTable.codesTable.Where(x => x.InstructionHash == Instruction);
      ILCode ilCode;
      if (Instructions.Count() == 1)
      {
        ilCode = Instructions.First();
        MessageBox.Show(
          new Form() { TopMost = true },
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
