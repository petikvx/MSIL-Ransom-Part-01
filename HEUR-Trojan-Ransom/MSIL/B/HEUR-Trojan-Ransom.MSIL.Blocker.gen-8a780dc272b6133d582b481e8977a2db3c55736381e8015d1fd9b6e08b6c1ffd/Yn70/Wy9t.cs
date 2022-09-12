using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using Se4n;
using Yj2;
using k0P9;
using s8C;

namespace Yn70;

[StandardModule]
internal sealed class Wy9t
{
	public static void Se8o()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Nn6.ds.Tables["taikhoan"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from taikhoan");
		Nn6.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds.Tables["taikhoan"]);
	}

	public static string w5J2(string Qa39)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select pss from taikhoan where uid='" + Qa39 + "'", Nn6.con);
		return Conversions.ToString(val.ExecuteScalar());
	}

	public static string Bo05(string n6X8)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select uqes from taikhoan where uid='" + n6X8 + "'", Nn6.con);
		return Conversions.ToString(val.ExecuteScalar());
	}

	public static string r2QX(string z2AQ)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select pss2 from taikhoan where uid='" + z2AQ + "'", Nn6.con);
		return Conversions.ToString(val.ExecuteScalar());
	}

	public static string Hb82(string k3QN)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select uans from taikhoan where uid='" + k3QN + "'", Nn6.con);
		return Conversions.ToString(val.ExecuteScalar());
	}

	public static void f7H4(string Ef67, string Zf2p)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["taikhoan"]!.Select("uid = '" + Ef67 + "'")[0];
		dataRow.BeginEdit();
		dataRow["pss"] = Zf2p;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("Update taikhoan Set pss=@pss Where uid=@uid");
		val.get_Parameters().Add("@pss", (OleDbType)200).set_Value((object)Zf2p);
		val.get_Parameters().Add("@uid", (OleDbType)200).set_Value((object)Ef67);
		Nn6.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["taikhoan"]);
	}

	internal static byte[] Yi04(int t6TS)
	{
		string[] array = new string[2] { "hdt", "yfyf" };
		if (array == null)
		{
			return null;
		}
		return x8B9.Kw25(t5TN.Nm4w(), t6TS);
	}

	public static void n3C2(string Mw83, string Qd57, string Az7y, string j1K6, string k7H8)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["taikhoan"]!.NewRow();
		dataRow["uid"] = Mw83;
		dataRow["pss"] = Qd57;
		dataRow["pss2"] = Az7y;
		dataRow["uqes"] = j1K6;
		dataRow["uans"] = k7H8;
		dataRow["utype"] = 0;
		Nn6.ds.Tables["taikhoan"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("Insert into taikhoan values (@uid,@pss,@pss2,@uqes,@uans,@utype)");
		val.get_Parameters().Add("@uid", (OleDbType)200).set_Value((object)Mw83);
		val.get_Parameters().Add("@pss", (OleDbType)200).set_Value((object)Qd57);
		val.get_Parameters().Add("@pss2", (OleDbType)200).set_Value((object)Az7y);
		val.get_Parameters().Add("@uqes", (OleDbType)200).set_Value((object)j1K6);
		val.get_Parameters().Add("@uans", (OleDbType)200).set_Value((object)k7H8);
		val.get_Parameters().Add("@utype", (OleDbType)11).set_Value((object)0);
		Nn6.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["taikhoan"]);
	}

	public static string q9R1(string Sc2q)
	{
		Type type = (Type)Ct6.mDic[Ct6.T];
		return Conversions.ToString(type.InvokeMember(Sc2q, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}
}
