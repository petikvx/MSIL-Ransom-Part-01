using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Resources;
using System.Windows.Forms;
using Microsoft.Win32;

public class GForm0 : Form
{
	private IContainer icontainer_0;

	private Timer timer_0;

	private ImageList imageList_0;

	public extern GForm0();

	private extern void method_0(object sender, EventArgs e);

	private extern void method_1(object sender, EventArgs e);

	extern void Form.Dispose(bool disposing);

	private extern void method_2();

	static Color smethod_0(Control control_0)
	{
		//Discarded unreachable code: IL_0007, IL_0011, IL_001a, IL_002a
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0031: Expected F8, but got O
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error: ldarg 1 (out-of-bounds)*/;
		checked
		{
			_ = /*Error near IL_0002: Stack underflow*/- val;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static extern void smethod_1(Form form_0, Color color_0);

	static extern void smethod_2(Form form_0, bool bool_0);

	static extern Process smethod_3();

	static void smethod_4(Process process_0, ProcessPriorityClass processPriorityClass_0)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0019
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/^ /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_5(IDisposable idisposable_0);

	static extern DialogResult smethod_6(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern void smethod_7();

	static extern void smethod_8(Form form_0);

	static extern void smethod_9(Form form_0, FormWindowState formWindowState_0);

	unsafe static void smethod_10(Control control_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I4, but got I8
		byte num = checked((byte)/*Error near IL_0001: Stack underflow*/);
		ushort num2 = ((ushort[])/*Error near IL_0003: Stack underflow*/)[num];
		_003F val = /*Error near IL_0005: Stack underflow*/>> (int)num2;
		long num3;
		checked
		{
			_003F val2 = /*Error near IL_0006: Stack underflow*/- val;
			_003F val3 = /*Error near IL_0008: Stack underflow*/+ val2;
			num3 = ((long[])/*Error near IL_0009: Stack underflow*/)[val3];
		}
		*(int*)(nint)/*Error near IL_000a: Stack underflow*/ = (int)num3;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static Process[] smethod_11(string string_0)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0013, IL_001a
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_12(Process process_0);

	static RegistryKey smethod_13(RegistryKey registryKey_0, string string_0)
	{
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_001b: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
			{
				continue;
			}
			uint num = ((uint[])(ushort)/*Error near IL_0007: Stack underflow*/)[(object)registryKey_0];
			if ((int)/*Error near IL_000f: Stack underflow*/ < (int)num && (int)/*Error near IL_0016: Stack underflow*/ > 5)
			{
				_003F val = /*Error near IL_0016: ldarg 3 (out-of-bounds)*/;
				uint num2 = ((uint[])/*Error near IL_0018: Stack underflow*/)[val];
				float num3 = ((float[])/*Error near IL_0019: Stack underflow*/)[num2];
				sbyte num4 = ((sbyte[])/*Error near IL_001b: Stack underflow*/)[num3];
				if ((int)/*Error near IL_0020: Stack underflow*/ > (int)num4)
				{
					/*Error: Could not find block for branch target IL_0020*/;
				}
			}
		}
	}

	static extern void smethod_14(RegistryKey registryKey_0, string string_0, object object_0, RegistryValueKind registryValueKind_0);

	static extern RegistryKey smethod_15(RegistryKey registryKey_0, string string_0, bool bool_0);

	static extern string smethod_16();

	static extern string smethod_17(object object_0);

	static extern void smethod_18(RegistryKey registryKey_0, string string_0, object object_0);

	static extern void smethod_19(bool bool_0);

	static extern void smethod_20(SecurityProtocolType securityProtocolType_0);

	static extern WebClient smethod_21();

	static extern void smethod_22(WebClient webClient_0, string string_0, string string_1);

	static extern SoundPlayer smethod_23(string string_0);

	static extern void smethod_24(SoundPlayer soundPlayer_0);

	static extern Process smethod_25(string string_0);

	static FileAttributes smethod_26(string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_000f, IL_0018, IL_001e, IL_0028
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0005: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_27(string string_0, FileAttributes fileAttributes_0);

	static extern void smethod_28(string string_0);

	static void smethod_29(Timer timer_1, bool bool_0)
	{
		//Discarded unreachable code: IL_0008, IL_0013
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		_ = (uint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static void smethod_30(Timer timer_1)
	{
		//Discarded unreachable code: IL_0009, IL_000f, IL_0015
		//IL_0005: Expected O, but got I8
		checked
		{
			_ = (ulong)unchecked((sbyte)/*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static Container smethod_31()
	{
		throw checked((ulong)/*Error near IL_0001: Stack underflow*/);
	}

	static Type smethod_32(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_0006, IL_000a, IL_000c, IL_0013
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		_ = 8;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern ComponentResourceManager smethod_33(Type type_0);

	static Timer smethod_34(IContainer icontainer_1)
	{
		//Discarded unreachable code: IL_0005
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern ImageList smethod_35(IContainer icontainer_1);

	static extern void smethod_36(Control control_0);

	static extern object smethod_37(ResourceManager resourceManager_0, string string_0);

	static void smethod_38(ImageList imageList_1, ImageListStreamer imageListStreamer_0)
	{
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_000a: Stack underflow*/ < 3)
		{
		}
		_ = /*Error near IL_000b: Stack underflow*/% /*Error near IL_000b: Stack underflow*/;
		_ = -254193622428.86728;
		/*Error: Unexpected end of block*/;
	}

	static void smethod_39(ImageList imageList_1, Color color_0)
	{
	}

	static extern ImageCollection smethod_40(ImageList imageList_1);

	static extern void smethod_41(ImageCollection imageCollection_0, int int_0, string string_0);
}
