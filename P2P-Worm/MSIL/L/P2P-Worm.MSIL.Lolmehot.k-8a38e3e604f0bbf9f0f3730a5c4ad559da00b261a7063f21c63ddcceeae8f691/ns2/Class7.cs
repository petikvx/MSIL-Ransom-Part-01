using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace ns2;

internal sealed class Class7
{
	public static string string_0 = "" + Class2.smethod_2().method_0().vmethod_3()
		.get_Text();

	public static string smethod_0(string string_1)
	{
		int num = Strings.Len(string_1);
		int num2 = 1;
		checked
		{
			string text = default(string);
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Strings.Asc(Strings.Mid(string_1, num2, 1)) < 128)
				{
					text = Conversions.ToString(Strings.Asc(Strings.Mid(string_1, num2, 1)) + 128);
				}
				else if (Strings.Asc(Strings.Mid(string_1, num2, 1)) > 128)
				{
					text = Conversions.ToString(Strings.Asc(Strings.Mid(string_1, num2, 1)) - 128);
				}
				StringType.MidStmtStr(ref string_1, num2, 1, Conversions.ToString(Strings.Chr(Conversions.ToInteger(text))));
				num2++;
			}
			return string_1;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void Sleep(long long_0);

	public static ArrayList smethod_1(string string_1)
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			StreamReader streamReader = new StreamReader(string_1);
			while (streamReader.Peek() != -1)
			{
				arrayList.Add(streamReader.ReadLine());
			}
			streamReader.Close();
			streamReader.Dispose();
		}
		catch (IOException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			IOException ex2 = ex;
			arrayList.Add(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		return arrayList;
	}
}
