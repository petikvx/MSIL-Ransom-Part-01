using System.Data;
using System.Data.OleDb;
using Microsoft.VisualBasic.CompilerServices;
using Nj0;

namespace s8C;

[StandardModule]
internal sealed class Nn6
{
	public static OleDbConnection con;

	public static OleDbDataAdapter da = new OleDbDataAdapter();

	public static DataSet ds = new DataSet();

	public static void p5P()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		string text = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\qlkytucxa.mdb;";
		con = new OleDbConnection(text);
		con.Open();
	}

	internal static byte[] Et9(int Jm4, int m6D)
	{
		if (Jm4 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[m6D + 1];
			for (int i = 0; i <= m6D; i++)
			{
				int num = Jm4 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return z6A.f2W(array, m6D);
		}
	}
}
