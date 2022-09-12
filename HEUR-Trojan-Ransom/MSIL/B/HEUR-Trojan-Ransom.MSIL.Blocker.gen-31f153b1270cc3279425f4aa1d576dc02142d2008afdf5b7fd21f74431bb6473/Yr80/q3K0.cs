using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Reflection;
using Lo1j;
using Lw3q;
using Microsoft.VisualBasic.CompilerServices;
using w1R;
using y5B1;

namespace Yr80;

[StandardModule]
internal sealed class q3K0
{
	public static void Wx36()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Kj81.ds.Tables["taikhoan"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from taikhoan");
		Kj81.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Kj81.da).Fill(Kj81.ds.Tables["taikhoan"]);
	}

	public static string Jg73(string Md38)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select pss from taikhoan where uid='" + Md38 + "'", Kj81.con);
		return Conversions.ToString(val.ExecuteScalar());
	}

	public static string Ss7z(string Ed39)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select uqes from taikhoan where uid='" + Ed39 + "'", Kj81.con);
		return Conversions.ToString(val.ExecuteScalar());
	}

	public static string j6CN(string Cf49)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select pss2 from taikhoan where uid='" + Cf49 + "'", Kj81.con);
		return Conversions.ToString(val.ExecuteScalar());
	}

	public static string p7HD(string Rt95)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select uans from taikhoan where uid='" + Rt95 + "'", Kj81.con);
		return Conversions.ToString(val.ExecuteScalar());
	}

	public static void Gk04(string Ep4o, string r2Q0)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["taikhoan"]!.Select("uid = '" + Ep4o + "'")[0];
		dataRow.BeginEdit();
		dataRow["pss"] = r2Q0;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("Update taikhoan Set pss=@pss Where uid=@uid");
		val.get_Parameters().Add("@pss", (OleDbType)200).set_Value((object)r2Q0);
		val.get_Parameters().Add("@uid", (OleDbType)200).set_Value((object)Ep4o);
		Kj81.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["taikhoan"]);
	}

	internal static byte[] r2LH(int x1CW)
	{
		string[] array = new string[2] { "hdt", "yfyf" };
		if (array == null)
		{
			return null;
		}
		return p4QH.x6ZM(q5C4.n9W3(), x1CW);
	}

	public static void t3W5(string k3H8, string At03, string Ad1a, string r5DT, string Zs6y)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["taikhoan"]!.NewRow();
		dataRow["uid"] = k3H8;
		dataRow["pss"] = At03;
		dataRow["pss2"] = Ad1a;
		dataRow["uqes"] = r5DT;
		dataRow["uans"] = Zs6y;
		dataRow["utype"] = 0;
		Kj81.ds.Tables["taikhoan"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("Insert into taikhoan values (@uid,@pss,@pss2,@uqes,@uans,@utype)");
		val.get_Parameters().Add("@uid", (OleDbType)200).set_Value((object)k3H8);
		val.get_Parameters().Add("@pss", (OleDbType)200).set_Value((object)At03);
		val.get_Parameters().Add("@pss2", (OleDbType)200).set_Value((object)Ad1a);
		val.get_Parameters().Add("@uqes", (OleDbType)200).set_Value((object)r5DT);
		val.get_Parameters().Add("@uans", (OleDbType)200).set_Value((object)Zs6y);
		val.get_Parameters().Add("@utype", (OleDbType)11).set_Value((object)0);
		Kj81.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["taikhoan"]);
	}

	public static string Zk02(string b4AK)
	{
		Type type = (Type)n5L.mDic[n5L.T];
		return Conversions.ToString(type.InvokeMember(b4AK, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}
}
