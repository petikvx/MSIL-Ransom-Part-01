using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns3;

internal class cZsR87iS
{
	internal static string wHp5ns8y(TextBox textBox_0, int int_0)
	{
		return (int_0 ^ 0x2504) switch
		{
			_ => textBox_0.get_Text(), 
		};
	}

	internal static void pPLHEkCR(Control control_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x648A)
		{
		default:
			control_0.set_Enabled(bool_0);
			break;
		case 1:
			control_0.ResumeLayout(bool_0);
			break;
		case 2:
			control_0.set_Visible(bool_0);
			break;
		}
	}

	internal static bool zEYNGoa2(Control control_0, int int_0)
	{
		return (int_0 ^ 0x2B97) switch
		{
			1 => control_0.get_IsDisposed(), 
			_ => control_0.Focus(), 
		};
	}

	internal static void FSeFUGQ4(TextBox textBox_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x1DC5)
		{
		}
		textBox_0.set_Text(string_0);
	}

	internal static char VXheJNE5(KeyPressEventArgs keyPressEventArgs_0, int int_0)
	{
		return (int_0 ^ 0xF01F) switch
		{
			_ => keyPressEventArgs_0.get_KeyChar(), 
		};
	}

	internal static int KKOKJOFz(string string_0, char char_0, int int_0)
	{
		return (int_0 ^ 0xE62B) switch
		{
			_ => string_0.IndexOf(char_0), 
		};
	}

	internal static void FF6LnMT8(KeyPressEventArgs keyPressEventArgs_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x4874)
		{
		}
		keyPressEventArgs_0.set_Handled(bool_0);
	}

	internal static void xmpuesDI(GroupBox groupBox_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xAB67)
		{
		}
		groupBox_0.set_Text(string_0);
	}

	internal static void ZHLG3o7L(Label label_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x446)
		{
		}
		label_0.set_AutoSize(bool_0);
	}

	internal static ControlCollection smethod_0(Control control_0, int int_0)
	{
		return (ControlCollection)((int_0 ^ 0x11F7) switch
		{
			_ => control_0.get_Controls(), 
		});
	}

	internal static Color cEZfA4G8(int int_0)
	{
		return (int_0 ^ 0x6588) switch
		{
			1 => Color.Magenta, 
			2 => Color.Transparent, 
			3 => Color.White, 
			4 => Color.Red, 
			5 => Color.Pink, 
			6 => Color.Green, 
			7 => Color.Brown, 
			_ => Color.Black, 
		};
	}

	internal static void smethod_1(ListControl listControl_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x45B)
		{
		}
		listControl_0.set_FormattingEnabled(bool_0);
	}

	internal static void smethod_2(Control control_0, Font font_0, int int_0)
	{
		switch (int_0 ^ 0xA4A9)
		{
		}
		control_0.set_Font(font_0);
	}

	internal static void xkLtJXy7(ISupportInitialize isupportInitialize_0, int int_0)
	{
		switch (int_0 ^ 0xD69B)
		{
		default:
			isupportInitialize_0.BeginInit();
			break;
		case 1:
			isupportInitialize_0.EndInit();
			break;
		}
	}

	internal static void smethod_3(GroupBox groupBox_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x13CB)
		{
		}
		groupBox_0.set_TabStop(bool_0);
	}

	internal static void smethod_4(Control control_0, int int_0)
	{
		switch (int_0 ^ 0x745A)
		{
		default:
			control_0.SuspendLayout();
			break;
		case 1:
			control_0.PerformLayout();
			break;
		case 2:
			control_0.Show();
			break;
		case 3:
			control_0.Refresh();
			break;
		}
	}

	internal static void smethod_5(ErrorProvider errorProvider_0, ErrorBlinkStyle errorBlinkStyle_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0xCF7F)
		{
		}
		errorProvider_0.set_BlinkStyle(errorBlinkStyle_0);
	}

	internal static void smethod_6(ErrorProvider errorProvider_0, ContainerControl containerControl_0, int int_0)
	{
		switch (int_0 ^ 0x9ADC)
		{
		}
		errorProvider_0.set_ContainerControl(containerControl_0);
	}

	internal static void AzkOQhNI(ComboBox comboBox_0, ComboBoxStyle comboBoxStyle_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0x7816)
		{
		}
		comboBox_0.set_DropDownStyle(comboBoxStyle_0);
	}

	internal static void XQ1plBAM(ComboBox comboBox_0, EventHandler eventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xA90A)
		{
		default:
			comboBox_0.add_SelectedIndexChanged(eventHandler_0);
			break;
		case 1:
			comboBox_0.remove_SelectedIndexChanged(eventHandler_0);
			break;
		}
	}
}
