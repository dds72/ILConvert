using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ILConvert
{
  static class InterceptKeys
  {
    private delegate IntPtr LowLevelKeyboardProc(
      int nCode,
      IntPtr wParam,
      IntPtr lParam);

    public delegate void KeyPressedHandler();

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(
      int idHook,
      LowLevelKeyboardProc lpfn,
      IntPtr hMod,
      uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(
      IntPtr hhk,
      int nCode,
      IntPtr wParam,
      IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int GetKeyState(int nVirtKey);

    public static event KeyPressedHandler onKeyPressed;

    private const int WH_KEYBOARD_LL = 13;

    private const int WM_KEYDOWN = 0x0100;

    private const int VK_SHIFT = 0x10;
    private const int VK_CONTROL = 0x11;
    private const int Z = 0x5A;

    private static LowLevelKeyboardProc proc = HookCallback;

    private static IntPtr hookID = IntPtr.Zero;

    public static void Start()
    {
      hookID = SetHook(proc);
      Application.Run();
      UnhookWindowsHookEx(hookID);
    }

    private static IntPtr SetHook(LowLevelKeyboardProc proc)
    {
      using (Process curProcess = Process.GetCurrentProcess())
      using (ProcessModule curModule = curProcess.MainModule)
      {
        return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
          GetModuleHandle(curModule.ModuleName), 0);
      }
    }

    private static IntPtr HookCallback(
      int nCode, IntPtr wParam, IntPtr lParam)
    {
      if (wParam == (IntPtr)WM_KEYDOWN)
      {
        int shiftKeyState = GetKeyState(VK_SHIFT);
        int controlKeyState = GetKeyState(VK_CONTROL);
        int zKeyState = GetKeyState(Z);
        if (shiftKeyState == 0x01 && controlKeyState == 0x01 && zKeyState == 0x01)
        {
          int vkCode = Marshal.ReadInt32(lParam);
          onKeyPressed?.Invoke();
        }
      }
      return CallNextHookEx(hookID, nCode, wParam, lParam);
    }
  }
}
