using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Main
{
    public partial class MainWindow : Window
    {
        // Hooking for keyboard
        private static IntPtr _hookID = IntPtr.Zero;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _hookID = SetHook(HookCallback); // Set up the hook to disable hotkeys
        }

        // P/Invoke for Windows API
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int VK_TAB = 0x09;
        private const int VK_ESCAPE = 0x1B;
        private const int VK_LWIN = 0x5B;
        private const int VK_RWIN = 0x5C;
        private const int VK_F4 = 0x73;

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                // Disable Alt+Tab, Ctrl+Esc, Windows Key, and Alt+F4
                if ((vkCode == VK_TAB && (Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt) ||
                    (vkCode == VK_ESCAPE && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control) ||
                    vkCode == VK_LWIN || vkCode == VK_RWIN ||
                    (vkCode == VK_F4 && (Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt))
                {
                    return (IntPtr)1; // Block the key press
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (var curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        // Unhook on window close
        protected override void OnClosed(EventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
            base.OnClosed(e);
        }

        // Existing event handlers for buttons remain the same
        private void GoToQRCodePage_Click(object sender, RoutedEventArgs e)
        {
            Qrcode qrPage = new Qrcode();
            MainContent.Content = qrPage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Flashdrive flashdrivePage = new Flashdrive();
            MainContent.Content = flashdrivePage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uniquecode uniquecodePage = new Uniquecode();
            MainContent.Content = uniquecodePage;
        }
    }
}
 //hello