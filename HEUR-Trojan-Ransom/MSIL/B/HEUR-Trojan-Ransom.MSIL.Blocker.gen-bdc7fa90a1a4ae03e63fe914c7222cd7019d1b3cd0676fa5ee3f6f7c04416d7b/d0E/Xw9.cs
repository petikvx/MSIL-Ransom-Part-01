using System.Text;
using System.Threading.Tasks;
using Qq2;
using b5R;
using y4S;

namespace d0E;

public class Xw9
{
	internal static void Sp3(int y2P)
	{
		Task.Delay(y2P).Wait();
	}

	internal static string[] Hy4()
	{
		return new string[11]
		{
			"aa", "dd", "gg", "jj", "ll", "qq", "ee", "tt", "uu", "ii",
			"pp"
		};
	}

	internal static string Gw1(string[] g6Z, int r5N, int Yt7)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = r5N; i <= Yt7; i = checked(i + 1))
		{
			stringBuilder.Append(g6Z[i]);
		}
		return stringBuilder.ToString();
	}

	internal static byte[] Qi5(int Cn1)
	{
		return t8Y.a9N(Cn1, checked(Cn1 + 1 - 6));
	}

	internal static byte[] c7T(int m9C)
	{
		string[] array = Hy4();
		if (array == null)
		{
			return null;
		}
		return t5R.Se1(t8Y.Lb2(), m9C);
	}

	internal static void f0L()
	{
		string[] g6Z = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Gw1(g6Z, 0, 3);
		string value2 = Gw1(g6Z, 4, 7);
		Cj0.mDic.Add(Cj0.tName, value);
		Cj0.mDic.Add(Cj0.mName, value2);
	}
}
