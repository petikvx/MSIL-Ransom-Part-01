using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

public class GForm0 : Form
{
	private IContainer icontainer_0;

	private Timer timer_0;

	public extern GForm0();

	private extern void method_0(object sender, FormClosingEventArgs e);

	private extern void method_1(object sender, EventArgs e);

	private extern void method_2(object sender, EventArgs e);

	extern void Form.Dispose(bool disposing);

	private extern void method_3();

	static extern Color smethod_0(Control control_0);

	static extern void smethod_1(Form form_0, Color color_0);

	static extern void smethod_2(CancelEventArgs cancelEventArgs_0, bool bool_0);

	static extern void smethod_3(Form form_0, FormWindowState formWindowState_0);

	unsafe static void smethod_4(Control control_0)
	{
		//Discarded unreachable code: IL_0009, IL_0011
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		byte num;
		checked
		{
			num = (byte)(*unchecked((double*)(nint)/*Error near IL_0001: Stack underflow*/));
		}
		_ = /*Error near IL_0004: Stack underflow*// num;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_5(RegistryKey registryKey_0, string string_0);

	static extern void smethod_6(RegistryKey registryKey_0, string string_0, object object_0, RegistryValueKind registryValueKind_0);

	static extern void smethod_7(bool bool_0);

	static void smethod_8(SecurityProtocolType securityProtocolType_0)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Incompatible stack heights: 0 vs 1
		//IL_0029: Invalid comparison between Unknown and O
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and F8
		while (true)
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/|| /*Error near IL_000b: Stack underflow*/>= /*Error near IL_000b: Stack underflow*/|| /*Error near IL_000e: Stack underflow*/>> (int)/*Error near IL_000e: Stack underflow*/ != 0)
			{
				continue;
			}
			checked
			{
				_ = (uint)/*Error near IL_0014: Stack underflow*/;
			}
			if (491542116uL < (ulong)(long)"" && (object)/*Error near IL_002e: Stack underflow*/ == null)
			{
				byte num = ((byte[])/*Error near IL_002f: Stack underflow*/)[/*Error near IL_002f: Stack underflow*/];
				if ((double)(/*Error near IL_0030: Stack underflow*/ - num) != 9.764703261893161E-119)
				{
					/*Error: Could not find block for branch target IL_003f*/;
				}
			}
		}
	}

	static extern WebClient smethod_9();

	static extern void smethod_10(WebClient webClient_0, string string_0, string string_1);

	static extern Process smethod_11(string string_0);

	static extern void smethod_12(IDisposable idisposable_0);

	static extern Container smethod_13();

	static extern Timer smethod_14(IContainer icontainer_1);

	static extern void smethod_15(Control control_0);
}
