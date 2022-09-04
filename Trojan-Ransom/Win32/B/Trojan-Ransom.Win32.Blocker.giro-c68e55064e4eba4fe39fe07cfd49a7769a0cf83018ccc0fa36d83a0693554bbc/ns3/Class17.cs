using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using a;

namespace ns3;

internal class Class17
{
	internal static void smethod_0(a a_0, int int_0)
	{
		switch (int_0 ^ 0xD073)
		{
		}
		a_0.b();
	}

	internal static uint smethod_1(uint uint_0, uint uint_1, int int_0)
	{
		return (int_0 ^ 0x9C2A) switch
		{
			_ => Math.Max(uint_0, uint_1), 
		};
	}

	internal static void smethod_2(int int_0)
	{
		switch (int_0 ^ 0xA81E)
		{
		}
		Application.EnableVisualStyles();
	}

	internal static void smethod_3(bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xBA54)
		{
		}
		Application.SetCompatibleTextRenderingDefault(bool_0);
	}

	internal static bool smethod_4(CheckBox checkBox_0, int int_0)
	{
		return (int_0 ^ 0xAFB7) switch
		{
			_ => checkBox_0.get_Checked(), 
		};
	}

	internal static void smethod_5(TextBox textBox_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xC5F8)
		{
		}
		textBox_0.set_UseSystemPasswordChar(bool_0);
	}

	internal static string smethod_6(Control control_0, int int_0)
	{
		return (int_0 ^ 0x80E2) switch
		{
			_ => control_0.get_Text(), 
		};
	}

	internal static void smethod_7(IDisposable idisposable_0, int int_0)
	{
		switch (int_0 ^ 0x3D65)
		{
		}
		idisposable_0.Dispose();
	}

	internal static void smethod_8(Control control_0, Point point_0, int int_0)
	{
		switch (int_0 ^ 0x9F8F)
		{
		}
		control_0.set_Location(point_0);
	}

	internal static void smethod_9(Control control_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x271B)
		{
		default:
			control_0.set_Name(string_0);
			break;
		case 1:
			control_0.set_Text(string_0);
			break;
		}
	}

	internal static void smethod_10(Control control_0, Size size_0, int int_0)
	{
		switch (int_0 ^ 0x218E)
		{
		}
		control_0.set_Size(size_0);
	}

	internal static void smethod_11(Control control_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0xE2A5)
		{
		}
		control_0.set_TabIndex(int_0);
	}

	internal static void smethod_12(Control control_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x5CC9)
		{
		}
		control_0.set_AutoSize(bool_0);
	}

	internal static void smethod_13(ButtonBase buttonBase_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xE86E)
		{
		}
		buttonBase_0.set_UseVisualStyleBackColor(bool_0);
	}

	internal static void smethod_14(Control control_0, EventHandler eventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xD3B9)
		{
		}
		control_0.add_Click(eventHandler_0);
	}

	internal static void smethod_15(CheckBox checkBox_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x504C)
		{
		}
		checkBox_0.set_Checked(bool_0);
	}

	internal static void smethod_16(CheckBox checkBox_0, CheckState checkState_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0x5019)
		{
		}
		checkBox_0.set_CheckState(checkState_0);
	}

	internal static void smethod_17(CheckBox checkBox_0, EventHandler eventHandler_0, int int_0)
	{
		switch (int_0 ^ 0x4D65)
		{
		}
		checkBox_0.add_CheckedChanged(eventHandler_0);
	}

	internal static void smethod_18(ControlCollection controlCollection_0, Control control_0, int int_0)
	{
		switch (int_0 ^ 0x57F5)
		{
		}
		controlCollection_0.Add(control_0);
	}

	internal static int smethod_19(Stream stream_0, int int_0)
	{
		return (int_0 ^ 0x9B09) switch
		{
			_ => stream_0.ReadByte(), 
		};
	}
}
