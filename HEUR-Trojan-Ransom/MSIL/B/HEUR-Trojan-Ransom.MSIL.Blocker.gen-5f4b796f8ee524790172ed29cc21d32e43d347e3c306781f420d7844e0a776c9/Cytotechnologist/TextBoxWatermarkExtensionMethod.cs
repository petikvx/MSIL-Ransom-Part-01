using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cytotechnologist;

public static class TextBoxWatermarkExtensionMethod
{
	private const uint ECM_FIRST = 5376u;

	private const uint EM_SETCUEBANNER = 5377u;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

	public static void SetWatermark(TextBox textBox, string watermarkText)
	{
		SendMessage(TextBoxWatermarkExtensionMethod.smethod_0((Control)(object)textBox), 5377u, 0u, watermarkText);
	}

	static IntPtr smethod_0(Control control_0)
	{
		return control_0.get_Handle();
	}
}
