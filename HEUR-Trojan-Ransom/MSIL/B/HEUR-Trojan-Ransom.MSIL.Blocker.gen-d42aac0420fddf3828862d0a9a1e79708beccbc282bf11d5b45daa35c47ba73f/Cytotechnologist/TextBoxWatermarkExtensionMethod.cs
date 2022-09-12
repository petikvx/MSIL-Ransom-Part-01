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
		while (true)
		{
			int num = -2104364137;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF7FD5782u) % 3u)
				{
				case 2u:
					goto IL_0003;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0003:
				SendMessage(TextBoxWatermarkExtensionMethod.smethod_0((Control)(object)textBox), 5377u, 0u, watermarkText);
				num = (int)((num2 * 1543142625) ^ 0x1CCBC714);
			}
		}
	}

	static IntPtr smethod_0(Control control_0)
	{
		return control_0.get_Handle();
	}
}
