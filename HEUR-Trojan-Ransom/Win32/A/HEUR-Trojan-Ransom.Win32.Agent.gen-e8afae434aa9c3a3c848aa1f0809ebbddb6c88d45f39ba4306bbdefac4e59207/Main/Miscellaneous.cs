using System;
using System.IO;
using System.Text.RegularExpressions;
using ns1;

namespace Main;

internal sealed class Miscellaneous
{
	public unsafe static bool smethod_0(string string_0)
	{
		void* ptr = stackalloc byte[5];
		try
		{
			Class4.Class5.smethod_67(Regex.Replace(Class4.Class5.smethod_66(), "%1", Class4.Class5.smethod_30()));
			Class4.Class5.smethod_67(Regex.Replace(Class4.Class5.smethod_66(), "%2", Class4.Class5.smethod_32()));
			Class4.Class5.smethod_67(Regex.Replace(Class4.Class5.smethod_66(), "%3", Class6.Class7.smethod_0()));
			string input = Class4.Class5.smethod_66();
			*(float*)ptr = Class4.Class5.smethod_34();
			Class4.Class5.smethod_67(Regex.Replace(input, "%4", ((float*)ptr)->ToString()));
			Class4.Class5.smethod_67(Regex.Replace(Class4.Class5.smethod_66(), "%5", Class4.Class5.smethod_36()));
			string_0 = $"{string_0}\\{Class4.Class5.smethod_62()}.{Class4.Class5.smethod_64()}";
			using (TextWriter textWriter = File.CreateText(string_0))
			{
				textWriter.Write(Class4.Class5.smethod_66());
				textWriter.Close();
			}
			File.SetAttributes(string_0, FileAttributes.ReadOnly);
			((byte*)ptr)[4] = 1;
		}
		catch (Exception)
		{
			((byte*)ptr)[4] = 0;
		}
		return ((byte*)ptr)[4] != 0;
	}
}
