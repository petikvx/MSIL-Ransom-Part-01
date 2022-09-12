using System.Data;
using System.Data.OleDb;
using Microsoft.VisualBasic.CompilerServices;
using f6HE;

namespace Lw3q;

[StandardModule]
internal sealed class Kj81
{
	public static OleDbConnection con;

	public static OleDbDataAdapter da = new OleDbDataAdapter();

	public static DataSet ds = new DataSet();

	public static void Mn31()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		string text = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\qlkytucxa.mdb;";
		con = new OleDbConnection(text);
		con.Open();
	}

	internal static byte[] m3B2(int n0N8, int Bd7k)
	{
		if (n0N8 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Bd7k + 1];
			for (int i = 0; i <= Bd7k; i++)
			{
				int num = n0N8 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Ry40.o7RM(array, Bd7k);
		}
	}
}
