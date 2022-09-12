using System.Windows;
using ns2;
using ns6;
using ns8;

namespace ns5;

internal sealed class Class4 : Application
{
	private static readonly Class6 U = new Class6();

	private static void smethod_0(byte[] byte_0, string[] string_0 = null)
	{
		string text = null;
		int[] array = new int[10];
		array[1] = 1;
		array[0] = 1;
		for (int i = 2; i < array.Length; i++)
		{
			array[i] = array[i - 1] + array[i - 2];
		}
		array[^1] = 55;
		text = "^(([a-zA-Z]\\:)|(\\\\))(\\\\{1}|((\\\\{1})[^\\\\]([^/:*?<>\"|]*))+)$";
		double[,] array2 = new double[2, 2]
		{
			{ 1.0, 2.0 },
			{ 0.0, 0.0 }
		};
		double num = 3.0;
		array2[1, 1] = 3.0;
		array2[1, 0] = num;
		_ = array2[0, 0];
		_ = array2[1, 1];
		_ = array2[1, 0];
		_ = array2[0, 1];
		U.method_0(Control0.smethod_1(byte_0, text));
	}

	public static void Main()
	{
		smethod_0(Class1.smethod_0());
	}
}
