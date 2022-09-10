using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WinRAR;

internal class bd4Jfu4ywLA
{
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

	public void bk96p9yokJI8JvoRysCt4n05()
	{
		new decimal(553L);
		new decimal(57895869L);
		new decimal(424929L);
	}
}
