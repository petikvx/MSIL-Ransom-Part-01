using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3;

internal class Class6
{
	public static string smethod_0(string string_0, string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = string_0.Length - 1;
		int num2 = default(int);
		for (int i = 0; i <= num; i += 2)
		{
			string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + string_0.Substring(i, 2)) ^ Strings.Asc(string_1[num2]))));
			stringBuilder.Append(value);
			num2 = ((num2 != string_1.Length - 1) ? (num2 + 1) : 0);
		}
		return stringBuilder.ToString();
	}
}
