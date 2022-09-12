using System;
using System.Windows.Forms;

public class GForm0 : Form
{
	extern void Form.OnLoad(EventArgs e);

	public extern GForm0();

	static extern void smethod_0(Form form_0, FormBorderStyle formBorderStyle_0);

	unsafe static void smethod_1(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0009: Invalid comparison between Unknown and I4
		while (true)
		{
			int num = *(int*)(nint)/*Error near IL_0002: Stack underflow*/;
			if ((int)/*Error near IL_0007: Stack underflow*/ < num)
			{
				ushort num2 = (ushort)/*Error near IL_0009: Stack underflow*/;
				if ((int)/*Error near IL_000e: Stack underflow*/ < (int)num2)
				{
					break;
				}
			}
		}
		_ = 1.1665321370507155E-38;
		/*Error: Unexpected end of block*/;
	}

	static void smethod_2(Form form_0, bool bool_0)
	{
		//Discarded unreachable code: IL_0008, IL_000e, IL_001b
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got F4
		_ = ref form_0;
		/*Error near IL_0003: Invalid metadata token*/;
	}
}
