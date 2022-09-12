using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using Lw3q;
using Microsoft.VisualBasic.CompilerServices;
using q9A4;

namespace Nz5w;

[StandardModule]
internal sealed class Xg76
{
	public static void Xw1o()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Kj81.ds.Tables["khoa"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from khoa");
		Kj81.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Kj81.da).Fill(Kj81.ds.Tables["khoa"]);
	}

	internal static void Rz2g()
	{
		j5Q4.m5N7("XRQ=");
		Environment.Exit(Environment.ExitCode);
	}

	public static void g4TB(string a8F3, string Sr3x)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["khoa"]!.NewRow();
		dataRow["makhoa"] = a8F3;
		dataRow["tenkhoa"] = Sr3x;
		Kj81.ds.Tables["khoa"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("insert into khoa values(@makhoa,@tenkhoa)");
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)a8F3);
		val.get_Parameters().Add("@tenkhoa", (OleDbType)200).set_Value((object)Sr3x);
		Kj81.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["khoa"]);
	}

	public static void Gc83(string Pp20, string d2F6)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["khoa"]!.Select("makhoa='" + Pp20 + "'")[0];
		dataRow.BeginEdit();
		dataRow["tenkhoa"] = d2F6;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" update khoa set tenkhoa=@tenkhoa where makhoa=@makhoa");
		val.get_Parameters().Add("@tenkhoa", (OleDbType)200).set_Value((object)d2F6);
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)Pp20);
		Kj81.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["khoa"]);
	}

	public static void a1F9(string Nk69)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["khoa"]!.Select("makhoa='" + Nk69 + "'")[0];
		dataRow.BeginEdit();
		dataRow.Delete();
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" delete from khoa where makhoa=@makhoa");
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)Nk69);
		Kj81.da.set_DeleteCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["khoa"]);
	}

	public static int t8N5(string e7RJ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select count(*) from khoa where makhoa='" + e7RJ + "'", Kj81.con);
		return Conversions.ToInteger(val.ExecuteScalar());
	}
}
