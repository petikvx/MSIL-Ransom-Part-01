using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

public class GForm0 : Form
{
	private IContainer icontainer_0;

	private Timer timer_0;

	private Button button_0;

	private PictureBox pictureBox_0;

	private PictureBox pictureBox_1;

	private ImageList imageList_0;

	public extern GForm0();

	private extern void method_0(object sender, EventArgs e);

	public static extern Cursor smethod_0(Bitmap bitmap_0, Size size_0);

	private unsafe void method_1(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_000f, IL_0014, IL_0017, IL_001d, IL_0022, IL_0027, IL_002f, IL_003b
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		//IL_0006: Expected native int or pointer, but got F8
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0015: Incompatible stack heights: 0 vs 1
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected native int or pointer, but got F4
		object obj = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_003F val = /*Error near IL_0003: Stack underflow*/<< (int)obj;
		*(sbyte*)(nint)/*Error near IL_0005: Stack underflow*/ = (sbyte)(int)val;
		int num = *(int*)(nint)((double[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
		if ((int)/*Error near IL_0009: Stack underflow*/ == num)
		{
			/*Error near IL_000a: Invalid metadata token*/;
		}
		/*Error near IL_0016: Unknown opcode: 0xF8*/;
	}

	private void method_2(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_001c, IL_0025, IL_002b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
			if ((nint)/*Error near IL_0007: Stack underflow*/ >= (nint)(nuint)val && (int)/*Error near IL_000c: Stack underflow*/ == 0)
			{
				ulong num = checked((ulong)/*Error near IL_000d: Stack underflow*/);
				_003F val2 = /*Error near IL_000e: Stack underflow*/<< (int)num;
				if (/*Error near IL_0014: Stack underflow*/ <= val2)
				{
					break;
				}
			}
		}
		/*Error near IL_0017: Invalid metadata token*/;
	}

	extern void Form.Dispose(bool disposing);

	private extern void method_3();

	static extern Color smethod_1(Control control_0);

	static void smethod_2(Form form_0, Color color_0)
	{
		//Discarded unreachable code: IL_0012
		//IL_0007: Expected F8, but got I
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			nint num = (nint)/*Error near IL_0004: Stack underflow*/;
			((double[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = -num;
		}
		while ((int)/*Error near IL_000c: Stack underflow*/ != 0);
		_ = null;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static extern void smethod_3(Form form_0, bool bool_0);

	static extern Process smethod_4();

	static void smethod_5(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		//Discarded unreachable code: IL_0006, IL_0018, IL_001d, IL_002c
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_002f: Invalid comparison between Unknown and O
		while (true)
		{
		}
	}

	static extern void smethod_6(IDisposable idisposable_0);

	static extern DialogResult smethod_7(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern void smethod_8();

	static extern void smethod_9(Form form_0);

	unsafe static void smethod_10(Form form_0, FormWindowState formWindowState_0)
	{
		//Discarded unreachable code: IL_000d, IL_0014
		//IL_0008: Expected O, but got I4
		while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
		{
		}
		byte num = *(byte*)(nint)/*Error near IL_0006: Stack underflow*/;
		((object[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = num;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern void smethod_11(Control control_0);

	static extern Process[] smethod_12(string string_0);

	static extern void smethod_13(Process process_0);

	static extern Bitmap smethod_14(Image image_0, Size size_0);

	static extern IntPtr smethod_15(Bitmap bitmap_0);

	static extern Cursor smethod_16(IntPtr intptr_0);

	static extern void smethod_17(Form form_0, bool bool_0);

	static extern void smethod_18(Form form_0, FormBorderStyle formBorderStyle_0);

	static extern void smethod_19(PictureBox pictureBox_2, PictureBoxSizeMode pictureBoxSizeMode_0);

	static extern RegistryKey smethod_20(RegistryKey registryKey_0, string string_0);

	static extern void smethod_21(RegistryKey registryKey_0, string string_0, object object_0, RegistryValueKind registryValueKind_0);

	static extern RegistryKey smethod_22(RegistryKey registryKey_0, string string_0, bool bool_0);

	unsafe static string smethod_23()
	{
		//Discarded unreachable code: IL_001b, IL_0020, IL_0025
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ != 0)
			{
				int num = *(int*)checked((sbyte)/*Error near IL_0006: Stack underflow*/);
				if ((uint)((short[])/*Error near IL_000d: Stack underflow*/)[(byte)num] > 31u)
				{
					break;
				}
			}
		}
		/*Error near IL_0016: Invalid metadata token*/;
	}

	static extern string smethod_24(object object_0);

	static extern void smethod_25(RegistryKey registryKey_0, string string_0, object object_0);

	static extern void smethod_26(bool bool_0);

	static void smethod_27(SecurityProtocolType securityProtocolType_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		switch (checked((ushort)(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/)) ^ -82)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern WebClient smethod_28();

	static extern void smethod_29(WebClient webClient_0, string string_0, string string_1);

	static extern SoundPlayer smethod_30(string string_0);

	static extern void smethod_31(SoundPlayer soundPlayer_0);

	static Process smethod_32(string string_0)
	{
		//Discarded unreachable code: IL_000f, IL_0014
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
				_ = (double)/*Error near IL_0007: Stack underflow*/;
				/*Error near IL_0007: stloc 3 (out-of-bounds)*/;
			}
		}
	}

	static extern FileAttributes smethod_33(string string_0);

	static extern void smethod_34(string string_0, FileAttributes fileAttributes_0);

	static void smethod_35(string string_0)
	{
	}

	static extern void smethod_36(Timer timer_1, bool bool_0);

	static void smethod_37(Timer timer_1)
	{
		//Discarded unreachable code: IL_0005, IL_0008, IL_000f, IL_0019, IL_0021, IL_0022, IL_0027, IL_0028, IL_002d
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	static extern Random smethod_38();

	static extern int smethod_39(Random random_0, int int_0, int int_1);

	static extern Screen smethod_40();

	static extern Rectangle smethod_41(Screen screen_0);

	static extern Container smethod_42();

	unsafe static Type smethod_43(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		uint num2;
		checked
		{
			short num = (short)/*Error near IL_0001: Stack underflow*/;
			_ = (long)((sbyte[])/*Error near IL_0002: Stack underflow*/)[num];
			/*Error near IL_0003: stloc 3 (out-of-bounds)*/;
			num2 = ((uint[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/];
		}
		((sbyte[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (sbyte)num2;
		sbyte num3 = *(sbyte*)((sbyte[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
		((sbyte[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = num3;
		_ = 7;
		/*Error: Unexpected end of block*/;
	}

	static extern ComponentResourceManager smethod_44(Type type_0);

	static extern Timer smethod_45(IContainer icontainer_1);

	static Button smethod_46()
	{
		//Discarded unreachable code: IL_0005, IL_0006, IL_000b, IL_0012, IL_001d
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static PictureBox smethod_47()
	{
		//Discarded unreachable code: IL_0006, IL_000d
		checked
		{
			_ = (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static ImageList smethod_48(IContainer icontainer_1)
	{
		//Discarded unreachable code: IL_0007
		//IL_0003: Expected O, but got I8
		checked
		{
			_ = (ulong)unchecked((int)checked((byte)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static void smethod_49(ISupportInitialize isupportInitialize_0)
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_001e, IL_0024, IL_0033, IL_0038, IL_003e
		//IL_0009: Incompatible stack heights: 0 vs 1
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
			{
				_ = ((int[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
				/*Error near IL_0007: ldloc 0 (out-of-bounds)*/;
				/*Error near IL_0008: stloc 0 (out-of-bounds)*/;
			}
		}
	}

	static void smethod_50(Control control_0)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_001c
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			ushort num = (ushort)/*Error near IL_0001: Stack underflow*/;
			_ = /*Error near IL_0002: Stack underflow*/- num;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static extern void smethod_51(Timer timer_1, EventHandler eventHandler_0);
}
