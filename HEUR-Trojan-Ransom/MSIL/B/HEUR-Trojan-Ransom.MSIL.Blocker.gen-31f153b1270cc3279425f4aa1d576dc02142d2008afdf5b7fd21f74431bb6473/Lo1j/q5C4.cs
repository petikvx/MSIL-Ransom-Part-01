using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Reflection;
using System.Runtime.CompilerServices;
using Dc16;
using Lw3q;
using Microsoft.VisualBasic.CompilerServices;
using w1R;

namespace Lo1j;

[StandardModule]
internal sealed class q5C4
{
	public static void w0TP()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Kj81.ds.Tables["phong"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from phong");
		Kj81.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Kj81.da).Fill(Kj81.ds.Tables["phong"]);
	}

	internal static string[] n9W3()
	{
		Tw3o.Tx40();
		object obj = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		n5L.mDic.Add("Ass", RuntimeHelpers.GetObjectValue(obj));
		return w3K0();
	}

	public static void w7A8(string Ct7q, string y4YN, bool Wc09)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["phong"]!.NewRow();
		dataRow["maktx"] = y4YN;
		dataRow["maphong"] = Ct7q;
		dataRow["loaiphong"] = Wc09;
		Kj81.ds.Tables["phong"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("insert into phong values(@maktx,@maphong,@loaiphong)");
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)y4YN);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)Ct7q);
		val.get_Parameters().Add("@loaiphong", (OleDbType)11).set_Value((object)Wc09);
		Kj81.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["phong"]);
	}

	public static void m4X9(string Sf52, string Jf67, bool d7B9)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["phong"]!.Select("maktx='" + Jf67 + "' and maphong='" + Sf52 + "'")[0];
		dataRow.BeginEdit();
		dataRow["loaiphong"] = d7B9;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" update phong set loaiphong=@loaiphong where maktx=@maktx and maphong=@maphong");
		val.get_Parameters().Add("@loaiphong", (OleDbType)11).set_Value((object)d7B9);
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)Jf67);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)Sf52);
		Kj81.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["phong"]);
	}

	public static void Em1k(string j4A5, string s0TJ)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["phong"]!.Select("maktx='" + s0TJ + "' and maphong='" + j4A5 + "'")[0];
		dataRow.BeginEdit();
		dataRow.Delete();
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" delete from phong where maktx=@maktx and maphong=@maphong");
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)s0TJ);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)j4A5);
		Kj81.da.set_DeleteCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["phong"]);
	}

	internal static string[] w3K0()
	{
		List<string> list = new List<string>();
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(n5L.mDic["Ass"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				string item = Conversions.ToString(enumerator.Current);
				list.Add(item);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	public static int i4W3(string Jq27, string f7MY)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select count(*) from phong where maktx='" + f7MY + "' and maphong='" + Jq27 + "'", Kj81.con);
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)f7MY);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)Jq27);
		return Conversions.ToInteger(val.ExecuteScalar());
	}
}
