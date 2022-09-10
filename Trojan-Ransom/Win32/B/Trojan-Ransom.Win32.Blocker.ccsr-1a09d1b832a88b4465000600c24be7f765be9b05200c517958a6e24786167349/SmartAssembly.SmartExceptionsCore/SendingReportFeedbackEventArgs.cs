using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs : EventArgs
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1912)]
	private struct Struct21
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct22
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly char[] char_2;

	private static readonly char[] char_3 = new char[8];

	private static readonly string[] string_1;

	internal static byte byte_1/* Not supported: data(00) */;

	internal SendingReportStep sendingReportStep_0;

	internal bool bool_0;

	internal string string_2 = string.Empty;

	internal string string_3 = string.Empty;

	public SendingReportStep Step => sendingReportStep_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_2;

	public string ReportID => string_3;

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_4)
		: this(sendingReportStep_1, string_4, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_4, string string_5)
	{
		SendingReportStep sendingReportStep = (sendingReportStep_0 = sendingReportStep_1);
		bool flag = (bool_0 = string_4 != null && PoweredBy.smethod_0(string_4, 914, 962) > 0);
		string text = (string_2 = string_4);
		string text2 = (string_3 = string_5);
	}

	static SendingReportFeedbackEventArgs()
	{
		char[] array = new char[8];
		array[3] = '\u00a0';
		array[6] = '㵴';
		array[2] = '\u1de0';
		array[5] = '\u2e70';
		array[7] = '᧾';
		array[4] = 'ᚢ';
		array[0] = 'ȅ';
		array[1] = '₦';
		string_1 = new string[1];
		char_2 = array;
		DESCryptoIndirector.smethod_0();
		char_1 = new char[956];
		char[] array2 = new char[8];
		array2[6] = 'ໞ';
		array2[3] = '\u082d';
		array2[2] = '⛱';
		array2[5] = 'ᡑ';
		array2[0] = '㤖';
		array2[4] = '\u0952';
		array2[7] = '૦';
		array2[1] = 'ᮞ';
		string_0 = new string[56];
		char_0 = array2;
	}

	internal static void smethod_0(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
	{
		while (true)
		{
			switch (int_4 ^ int_3)
			{
			case 41:
				Array.Copy(array_0, int_0, array_1, int_1, int_2);
				return;
			}
		}
	}

	internal static void smethod_1(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				stream_0.Close();
				return;
			}
		}
	}

	internal static void smethod_2(Stream stream_0, byte[] byte_2, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 41:
				stream_0.Write(byte_2, int_0, int_1);
				return;
			}
		}
	}

	internal static ParameterInfo[] smethod_3(MethodBase methodBase_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 117:
				return methodBase_0.GetParameters();
			}
		}
	}

	internal static string smethod_4(char char_4, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 116:
				return Conversions.ToString(char_4);
			}
		}
	}
}
