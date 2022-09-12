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
			int num = 1774100630;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4A1C00D0u) % 3u)
				{
				case 1u:
					goto IL_0003;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0003:
				SendMessage(TextBoxWatermarkExtensionMethod.smethod_0((Control)(object)textBox), 5377u, 0u, watermarkText);
				num = (int)((num2 * 1100997847) ^ 0x4D346E5F);
			}
		}
	}

	static IntPtr smethod_0(Control control_0)
	{
		return control_0.get_Handle();
	}
}
