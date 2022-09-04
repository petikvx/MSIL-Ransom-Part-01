using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class5 : Computer
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Class5()
	{
	}

	internal static SettingsBase smethod_0<T>(T gparam_0, int int_0, char char_0) where T : SettingsBase
	{
		int num = 0;
		SettingsBase result = (SettingsBase)((((int_0 ^ char_0) - 31) ^ 0) switch
		{
			0 => SettingsBase.Synchronized((SettingsBase)(object)gparam_0), 
			_ => null, 
		});
		num++;
		return result;
	}

	internal static void smethod_1<T, U>(T gparam_0, U gparam_1, char char_0, int int_0) where T : RichTextBox where U : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ int_0) - 6) ^ num)
			{
			case 0:
				((RichTextBox)gparam_0).set_Text((string)gparam_1);
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static void smethod_2<T, U>(T gparam_0, U gparam_1, int int_0, short short_0) where T : Control where U : KeyPressEventHandler
	{
		int num = 0;
		switch (((short_0 ^ int_0) - 120) ^ 0)
		{
		case 0:
			((Control)gparam_0).remove_KeyPress((KeyPressEventHandler)(object)gparam_1);
			break;
		}
		num++;
	}

	internal static string smethod_3<T>(T gparam_0, int int_0, int int_1) where T : Process
	{
		int num = 0;
		string result = (((int_0 ^ int_1) - 5) ^ 0) switch
		{
			0 => gparam_0.MainWindowTitle, 
			1 => gparam_0.ProcessName, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_4(char char_0, short short_0)
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ short_0) - 117) ^ num)
			{
			case 1:
				ProjectData.EndApp();
				break;
			case 0:
				ProjectData.ClearProjectError();
				break;
			}
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static int smethod_5<T>(T gparam_0, char char_0, short short_0) where T : CreateParams
	{
		int num = 0;
		int result;
		do
		{
			result = (((char_0 ^ short_0) - 32) ^ num) switch
			{
				0 => ((CreateParams)gparam_0).get_ClassStyle(), 
				_ => 3, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static Keyboard smethod_6<T>(T gparam_0, char char_0, int int_0) where T : Computer
	{
		int num = 0;
		Keyboard result;
		int num2;
		do
		{
			result = (Keyboard)((((int_0 ^ char_0) - 21) ^ num) switch
			{
				0 => ((Computer)gparam_0).get_Keyboard(), 
				_ => null, 
			});
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static Color smethod_7(short short_0, short short_1)
	{
		int num = 0;
		Color result;
		int num2;
		do
		{
			result = (((short_0 ^ short_1) - 31) ^ num) switch
			{
				0 => Color.LimeGreen, 
				_ => default(Color), 
			};
			num++;
			num2 = short_1 * short_1;
			num2 = short_1 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_8<T, U, V, W, X>(W gparam_0, X gparam_1, V gparam_2, T gparam_3, U gparam_4, char char_0, short short_0) where V : string where W : Collection
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ short_0) - 47) ^ num)
			{
			case 0:
				((Collection)gparam_0).Add((object)gparam_1, (string)gparam_2, (object)gparam_3, (object)gparam_4);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static void smethod_9<T>(T gparam_0, bool bool_0, char char_0, short short_0) where T : TextBox
	{
		int num = 0;
		do
		{
			switch (((char_0 ^ short_0) - 2) ^ num)
			{
			case 0:
				((TextBox)gparam_0).set_AcceptsReturn(bool_0);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static string smethod_10<T>(T gparam_0, int int_0, short short_0) where T : OperatingSystem
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 44) ^ num) switch
			{
				0 => (string)(IConvertible)gparam_0.ServicePack, 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static string smethod_11<T>(T gparam_0, short short_0, int int_0)
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((short_0 ^ int_0) - 7) ^ num) switch
			{
				0 => (string)(ICloneable)gparam_0.ToString(), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static double smethod_12<T>(T gparam_0, short short_0, int int_0)
	{
		int num = 0;
		double result = (((int_0 ^ short_0) - 41) ^ 0) switch
		{
			0 => Conversion.Val((object)gparam_0), 
			_ => 0.04324361338823724, 
		};
		num++;
		return result;
	}

	internal static int smethod_13<T>(T gparam_0, int int_0, int int_1) where T : Image
	{
		int num = 0;
		int result = (((int_1 ^ int_0) - 124) ^ 0) switch
		{
			0 => ((Image)gparam_0).get_Width(), 
			_ => 9, 
		};
		num++;
		return result;
	}

	internal static int smethod_14<T>(T gparam_0, char char_0, char char_1, int int_0) where T : string
	{
		int num = 0;
		int result = (((char_1 ^ int_0) - 83) ^ 0) switch
		{
			0 => gparam_0.IndexOf(char_0), 
			_ => 11, 
		};
		num++;
		return result;
	}

	internal static void smethod_15<T, U>(T gparam_0, U gparam_1, byte[] byte_0, bool bool_0, char char_0, short short_0) where T : FileSystemProxy where U : string
	{
		int num = 0;
		switch (((short_0 ^ char_0) - 108) ^ 0)
		{
		case 0:
			((FileSystemProxy)gparam_0).WriteAllBytes((string)gparam_1, byte_0, bool_0);
			break;
		}
		num++;
	}
}
