using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using Ey8t;
using Microsoft.VisualBasic.CompilerServices;
using s8C;

namespace Gp7;

[StandardModule]
internal sealed class Kn5
{
	public static void m9L()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Nn6.ds.Tables["khoa"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from khoa");
		Nn6.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds.Tables["khoa"]);
	}

	internal static void Ft4()
	{
		d0N.Kz27("XRQ=");
		Environment.Exit(Environment.ExitCode);
	}

	public static void z5J(string Ka7, string f8A)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["khoa"]!.NewRow();
		dataRow["makhoa"] = Ka7;
		dataRow["tenkhoa"] = f8A;
		Nn6.ds.Tables["khoa"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("insert into khoa values(@makhoa,@tenkhoa)");
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)Ka7);
		val.get_Parameters().Add("@tenkhoa", (OleDbType)200).set_Value((object)f8A);
		Nn6.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["khoa"]);
	}

	public static void x1S(string Af7, string g0Q)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["khoa"]!.Select("makhoa='" + Af7 + "'")[0];
		dataRow.BeginEdit();
		dataRow["tenkhoa"] = g0Q;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" update khoa set tenkhoa=@tenkhoa where makhoa=@makhoa");
		val.get_Parameters().Add("@tenkhoa", (OleDbType)200).set_Value((object)g0Q);
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)Af7);
		Nn6.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["khoa"]);
	}

	public static void r1D(string p5T)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["khoa"]!.Select("makhoa='" + p5T + "'")[0];
		dataRow.BeginEdit();
		dataRow.Delete();
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" delete from khoa where makhoa=@makhoa");
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)p5T);
		Nn6.da.set_DeleteCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["khoa"]);
	}

	public static int Ws7(string r5P)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select count(*) from khoa where makhoa='" + r5P + "'", Nn6.con);
		return Conversions.ToInteger(val.ExecuteScalar());
	}
}
