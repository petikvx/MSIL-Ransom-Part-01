using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace oWLXhSmh;

internal class D6GpGQoV
{
	internal static string smethod_0(string string_0, string string_1, string string_2, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0xAC80) switch
		{
			_ => Interaction.InputBox(string_0, string_1, string_2, int_0, int_1), 
		};
	}

	internal static void LenX9Auz(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		switch (int_0 ^ 0xFE3)
		{
		}
		dataGridViewRowCollection_0.Clear();
	}

	internal static int VCnCAiyD(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return (int_0 ^ 0xF37A) switch
		{
			_ => dataGridViewRowCollection_0.Add(), 
		};
	}

	internal static int iIPH1Gig(DataGridView dataGridView_0, int int_0)
	{
		return (int_0 ^ 0x8D60) switch
		{
			_ => dataGridView_0.get_ColumnCount(), 
		};
	}

	internal static Type kTVQhja9(Exception exception_0, int int_0)
	{
		return (int_0 ^ 0x707F) switch
		{
			_ => exception_0.GetType(), 
		};
	}

	internal static void IR7LEMmx(Control control_0, Size size_0, int int_0)
	{
		switch (int_0 ^ 0x42A7)
		{
		}
		control_0.set_Size(size_0);
	}

	internal static void USKUaaiM(Control control_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x87FC)
		{
		default:
			control_0.set_Name(string_0);
			break;
		case 1:
			control_0.set_Text(string_0);
			break;
		}
	}

	internal static void SZittZl4(ButtonBase buttonBase_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xFC2F)
		{
		}
		buttonBase_0.set_Text(string_0);
	}

	internal static void V6DgFEiC(Control control_0, Point point_0, int int_0)
	{
		switch (int_0 ^ 0x222B)
		{
		}
		control_0.set_Location(point_0);
	}

	internal static Color seTIbNZw(int int_0)
	{
		return (int_0 ^ 0x1ACC) switch
		{
			1 => SystemColors.ControlText, 
			2 => SystemColors.InfoText, 
			3 => SystemColors.Info, 
			_ => SystemColors.Control, 
		};
	}

	internal static void mhM8Vn5a(ButtonBase buttonBase_0, Color color_0, int int_0)
	{
		switch (int_0 ^ 0xE146)
		{
		}
		buttonBase_0.set_BackColor(color_0);
	}

	internal static void A8Yi0HGI(Control control_0, Color color_0, int int_0)
	{
		switch (int_0 ^ 0xE29B)
		{
		default:
			control_0.set_ForeColor(color_0);
			break;
		case 1:
			control_0.set_BackColor(color_0);
			break;
		}
	}

	internal static void w2Px95Sg(ControlCollection controlCollection_0, Control control_0, int int_0)
	{
		switch (int_0 ^ 0x65A5)
		{
		}
		controlCollection_0.Add(control_0);
	}

	internal static void A8sWgzB5(ButtonBase buttonBase_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x3998)
		{
		default:
			buttonBase_0.set_UseVisualStyleBackColor(bool_0);
			break;
		case 1:
			buttonBase_0.set_AutoSize(bool_0);
			break;
		}
	}

	internal static void ZM6bdc8x(Button button_0, DialogResult dialogResult_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0x8B69)
		{
		}
		button_0.set_DialogResult(dialogResult_0);
	}

	internal static void smethod_1(Form form_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x9516)
		{
		}
		form_0.set_Text(string_0);
	}

	internal static void xbc8Xrng(Control control_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x9F64)
		{
		default:
			control_0.set_TabIndex(int_0);
			break;
		case 1:
			control_0.set_Left(int_0);
			break;
		case 2:
			control_0.set_Top(int_0);
			break;
		}
	}

	internal static void pvyNV9T1(Label label_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xBAAA)
		{
		}
		label_0.set_Text(string_0);
	}

	internal static void xSidAuvj(Control control_0, EventHandler eventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xAFA4)
		{
		default:
			control_0.remove_Click(eventHandler_0);
			break;
		case 1:
			control_0.add_Click(eventHandler_0);
			break;
		case 2:
			control_0.remove_TextChanged(eventHandler_0);
			break;
		case 3:
			control_0.add_TextChanged(eventHandler_0);
			break;
		case 4:
			control_0.add_DoubleClick(eventHandler_0);
			break;
		case 5:
			control_0.remove_DoubleClick(eventHandler_0);
			break;
		}
	}

	internal static void UhxGqlAA(Control control_0, KeyPressEventHandler keyPressEventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xADAE)
		{
		default:
			control_0.remove_KeyPress(keyPressEventHandler_0);
			break;
		case 1:
			control_0.add_KeyPress(keyPressEventHandler_0);
			break;
		}
	}
}
