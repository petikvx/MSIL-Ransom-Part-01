using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using O.My;

namespace ns0;

[StandardModule]
[HideModuleName]
internal sealed class Class3
{
	private static bool bool_0;

	[HelpKeyword("My.Settings")]
	internal static object Object_0 => Class1.smethod_0();

	internal static Assembly smethod_0<T>(T gparam_0, char char_0, char char_1) where T : Type
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		int num = 0;
		Assembly result = (((char_0 ^ char_1) - 3) ^ 0) switch
		{
			0 => (Assembly)(_Assembly)gparam_0.Assembly, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_1(ref IntPtr intptr_0, char char_0, short short_0)
	{
		int num = 0;
		int result = (((short_0 ^ char_0) - 82) ^ 0) switch
		{
			0 => intptr_0.ToInt32(), 
			_ => 9, 
		};
		num++;
		return result;
	}

	internal static string smethod_2<T>(T gparam_0, int int_0, short short_0) where T : string
	{
		int num = 0;
		string result;
		int num2;
		do
		{
			result = (((int_0 ^ short_0) - 92) ^ num) switch
			{
				5 => (string)(IComparable<string>)Interaction.Environ((string)gparam_0), 
				4 => (string)(IComparable<string>)Strings.UCase((string)gparam_0), 
				3 => (string)(IComparable<string>)Path.GetFileNameWithoutExtension(gparam_0), 
				2 => (string)(IComparable<string>)File.ReadAllText(gparam_0), 
				1 => (string)(IComparable<string>)Strings.LCase((string)gparam_0), 
				0 => (string)(IComparable<string>)gparam_0.ToUpper(), 
				_ => null, 
			};
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}

	internal static void smethod_3<T>(T gparam_0, Point point_0, int int_0, char char_0) where T : Control
	{
		int num = 0;
		do
		{
			switch (((int_0 ^ char_0) - 67) ^ num)
			{
			case 0:
				((Control)gparam_0).set_Location(point_0);
				break;
			}
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
	}

	internal static void smethod_4<T, U>(T gparam_0, U gparam_1, bool bool_1, char char_0, char char_1) where T : string where U : string
	{
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ char_1) - 91) ^ num)
			{
			case 0:
				File.Copy(gparam_0, gparam_1, bool_1);
				break;
			}
			num++;
			num2 = char_1 * char_1;
			num2 = char_1 + num2;
		}
		while (num2 % 2 != 0);
	}

	internal static byte[] smethod_5<T, U>(U gparam_0, T gparam_1, int int_0, char char_0) where T : string where U : Encoding
	{
		int num = 0;
		byte[] result;
		do
		{
			result = (((int_0 ^ char_0) - 104) ^ num) switch
			{
				0 => gparam_0.GetBytes(gparam_1), 
				_ => null, 
			};
			num++;
		}
		while ((char_0 * char_0 + char_0) % 2 != 0);
		return result;
	}

	internal static string smethod_6<T>(T gparam_0, int int_0, int int_1, short short_0, short short_1) where T : string
	{
		int num = 0;
		string result = (((short_1 ^ short_0) - 98) ^ 0) switch
		{
			0 => (string)(IComparable)gparam_0.Substring(int_0, int_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_7(ref Size size_0, int int_0, int int_1)
	{
		int num = 0;
		int result = (((int_0 ^ int_1) - 106) ^ 0) switch
		{
			0 => size_0.Width, 
			_ => int_0, 
		};
		num++;
		return result;
	}

	internal static int smethod_8(ref Size size_0, int int_0, int int_1)
	{
		int num = 0;
		int result = (((int_1 ^ int_0) - 73) ^ 0) switch
		{
			0 => size_0.Height, 
			_ => 6, 
		};
		num++;
		return result;
	}

	internal static int smethod_9<T>(T gparam_0, short short_0, int int_0) where T : Image
	{
		int num = 0;
		int result = (((int_0 ^ short_0) - 65) ^ 0) switch
		{
			0 => ((Image)gparam_0).get_Height(), 
			_ => int_0, 
		};
		num++;
		return result;
	}

	internal static Encoding smethod_10(int int_0, char char_0)
	{
		int num = 0;
		Encoding result = (((char_0 ^ int_0) - 121) ^ 0) switch
		{
			0 => Encoding.Default, 
			1 => Encoding.UTF8, 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_11<T, U>(U gparam_0, T gparam_1, int int_0, short short_0) where T : string where U : string
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 123) ^ 0) switch
		{
			0 => Path.Combine(gparam_0, gparam_1), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static void smethod_12(int int_0, int int_1)
	{
		int num = 0;
		switch (((int_1 ^ int_0) - 27) ^ 0)
		{
		case 0:
			Clipboard.Clear();
			break;
		}
		num++;
	}

	internal static Process smethod_13(short short_0, int int_0)
	{
		int num = 0;
		Process result = (((short_0 ^ int_0) - 114) ^ 0) switch
		{
			0 => (Process)(Component)Process.GetCurrentProcess(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static int smethod_14<T>(T gparam_0, int int_0, int int_1, int int_2, int int_3) where T : Random
	{
		int num = 0;
		int result = (((int_3 ^ int_2) - 121) ^ 0) switch
		{
			0 => gparam_0.Next(int_0, int_1), 
			_ => 13, 
		};
		num++;
		return result;
	}

	internal static float smethod_15(char char_0, int int_0)
	{
		int num = 0;
		float result;
		int num2;
		do
		{
			result = (((int_0 ^ char_0) - 46) ^ num) switch
			{
				0 => VBMath.Rnd(), 
				_ => 0.5543878f, 
			};
			num++;
			num2 = char_0 * char_0;
			num2 = char_0 + num2;
		}
		while (num2 % 2 != 0);
		return result;
	}
}
