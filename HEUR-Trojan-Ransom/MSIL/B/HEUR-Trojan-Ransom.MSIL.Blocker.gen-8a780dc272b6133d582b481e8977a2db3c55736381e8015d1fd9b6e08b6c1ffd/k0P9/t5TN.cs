using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Yj2;
using n6EF;
using s8C;

namespace k0P9;

[StandardModule]
internal sealed class t5TN
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 9552)]
	private struct s9E1
	{
	}

	private static readonly Array b;

	private static readonly object W;

	private static readonly Array n;

	internal static byte A/* Not supported: data(00) */;

	public static void Ft29()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Nn6.ds.Tables["phong"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from phong");
		Nn6.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds.Tables["phong"]);
	}

	internal static string[] Nm4w()
	{
		k7N3.j6JL();
		object obj = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Ct6.mDic.Add("Ass", RuntimeHelpers.GetObjectValue(obj));
		return k7W0();
	}

	public static void m3AK(string Wt5b, string Yb93, bool x0ES)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["phong"]!.NewRow();
		dataRow["maktx"] = Yb93;
		dataRow["maphong"] = Wt5b;
		dataRow["loaiphong"] = x0ES;
		Nn6.ds.Tables["phong"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("insert into phong values(@maktx,@maphong,@loaiphong)");
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)Yb93);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)Wt5b);
		val.get_Parameters().Add("@loaiphong", (OleDbType)11).set_Value((object)x0ES);
		Nn6.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["phong"]);
	}

	public static void d2C1(string r0S6, string n8LE, bool Ha9b)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["phong"]!.Select("maktx='" + n8LE + "' and maphong='" + r0S6 + "'")[0];
		dataRow.BeginEdit();
		dataRow["loaiphong"] = Ha9b;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" update phong set loaiphong=@loaiphong where maktx=@maktx and maphong=@maphong");
		val.get_Parameters().Add("@loaiphong", (OleDbType)11).set_Value((object)Ha9b);
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)n8LE);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)r0S6);
		Nn6.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["phong"]);
	}

	public static void r2P6(string x8GK, string q1CZ)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["phong"]!.Select("maktx='" + q1CZ + "' and maphong='" + x8GK + "'")[0];
		dataRow.BeginEdit();
		dataRow.Delete();
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" delete from phong where maktx=@maktx and maphong=@maphong");
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)q1CZ);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)x8GK);
		Nn6.da.set_DeleteCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["phong"]);
	}

	internal static string[] k7W0()
	{
		List<string> list = new List<string>();
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)NewLateBinding.LateGet(Ct6.mDic["Ass"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null)).GetEnumerator();
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

	public static int q6PB(string Ae57, string Sm1z)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select count(*) from phong where maktx='" + Sm1z + "' and maphong='" + Ae57 + "'", Nn6.con);
		val.get_Parameters().Add("@maktx", (OleDbType)200).set_Value((object)Sm1z);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)Ae57);
		return Conversions.ToInteger(val.ExecuteScalar());
	}

	static t5TN()
	{
		W = new char[4776];
		char[] array = new char[8];
		array[7] = '༼';
		array[5] = '◿';
		array[2] = '\u0093';
		array[0] = 'ⶲ';
		array[6] = '⌍';
		array[4] = 'គ';
		array[3] = 'ᝯ';
		array[1] = 'ඵ';
		n = new string[279];
		b = array;
	}
}
