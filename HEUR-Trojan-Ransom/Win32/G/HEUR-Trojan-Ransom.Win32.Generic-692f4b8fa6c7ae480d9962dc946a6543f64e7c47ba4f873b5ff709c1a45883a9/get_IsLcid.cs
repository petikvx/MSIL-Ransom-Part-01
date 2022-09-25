using System;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal class get_IsLcid
{
	private static ToOACurrency TKIND_ALIAS;

	public static bool DT_CHR(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		char[] array = new char[2] { '\u0001', '\u0019' };
		int[] array2 = new int[2] { 147651, 404 };
		HttpClient val = new HttpClient();
		try
		{
			string string_ = string.Concat("邌邐邐" + char.ToString('邔') + "邗郞郋郋邀邍邗邇邋邖邀郊邇邋邉郋", "邅邔邍郋邒郜郋邁邊邐邍邐邈邁邉邁邊邐邗郋邃邍邂邐郉邇邋邀邁邗郋邟郔邙郛邓邍邐邌邻邅" + "邔邔邈邍邇邅邐邍邋邊郙邐邖邑邁郂邓邍邐邌邻邗邑邆邗邇邖邍邔邐邍邋邊邻邔邈邅邊郙邐邖邑邁");
			object[] obj = new object[4]
			{
				char.ToString('ݍ') + "ȖĠ",
				null,
				null,
				null
			};
			char c = (char)((Array)(object)"\u0304").Length;
			obj[(uint)c] = string.Concat("ᠺǦ", char.ToString('p') + char.ToString('=') + "\u0006&£");
			obj[2] = 27031;
			obj[147654 - array2[0]] = 302;
			_003CModule_003E.TryFormatDecimal(ref string_, obj);
			string text = string.Format(string_, string_0);
			TKIND_ALIAS.Keys(text);
			Task<HttpResponseMessage> async = val.GetAsync(text);
			HttpStatusCode statusCode = async.Result.get_StatusCode();
			int num = array2[1];
			if (((statusCode == (HttpStatusCode)num) ? 1 : 0) == 9042901 >> (int)array[1])
			{
				return (byte)array[0] != 0;
			}
			return false;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	static get_IsLcid()
	{
		char[] array = new char[3] { '\u0006', '\u0002', '误' };
		string string_ = string.Concat(char.ToString(array[2]), char.ToString((char)Convert.ToInt32("8bee", 16)), char.ToString('诩') + "课诬");
		object[] array2 = new object[(uint)array[0]];
		array2[0] = 6050;
		array2[1] = Convert.ToInt32("11111111111111111111000100101010", 2) * -2;
		char c = array[1];
		array2[(int)c] = char.ToString('æ') + char.ToString('\u0963') + "\u008dĤ";
		array2[Marshal.SizeOf(typeof(DisallowNullAttribute))] = 8478;
		array2[_003CModule_003E.Deny[36] + Convert.ToInt32("1101110100101101110", 2)] = false;
		array2[5] = string.Concat(char.ToString('✎'), char.ToString('p') + "Ŷ:\u0017");
		_003CModule_003E.TryFormatDecimal(ref string_, array2);
		TKIND_ALIAS = new ToOACurrency(string_, 0);
	}
}
