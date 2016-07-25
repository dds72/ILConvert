using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ILConvert
{
  public partial class Configuration : Form
  {
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    enum KeyModifier
    {
      None = 0,
      Alt = 1,
      Control = 2,
      Shift = 4,
      WinKey = 8
    }

    public Configuration()
    {
      InitializeComponent();

      int id = 0;
      RegisterHotKey(this.Handle, id, (int)KeyModifier.Shift | (int)KeyModifier.Control, Keys.Z.GetHashCode()); 
    }

    protected override void WndProc(ref Message m)
    {
      base.WndProc(ref m);

      if (m.Msg == 0x0312)
      {
        Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
        KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);
        int id = m.WParam.ToInt32();

        ILCodeMatcher.Show();
      }
    }

    private void ExampleForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      UnregisterHotKey(this.Handle, 0);
    }
  }
}