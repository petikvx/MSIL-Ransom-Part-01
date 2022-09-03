using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Windows;

public class Gv4C4B4Oh2X2rjgC8v
{
	public object QnAIkg59IjBU6()
	{
		while (true)
		{
			int num = 29;
			do
			{
				num++;
			}
			while (num <= 9840460);
		}
	}

	private void z8NURpZPO5vST9()
	{
	}

	public static string R_(string Input, string pass)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = Input.Length - 1;
		int num2 = default(int);
		for (int i = 0; i <= num; i += 2)
		{
			string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(i, 2)) ^ Strings.Asc(pass[num2]))));
			stringBuilder.Append(value);
			num2 = ((num2 != pass.Length - 1) ? (num2 + 1) : 0);
		}
		return stringBuilder.ToString();
	}
}
