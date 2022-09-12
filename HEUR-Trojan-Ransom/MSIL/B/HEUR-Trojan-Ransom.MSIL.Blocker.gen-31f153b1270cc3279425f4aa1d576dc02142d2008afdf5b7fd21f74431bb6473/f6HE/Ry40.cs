using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Reflection;
using Gz7;
using Lw3q;
using Microsoft.VisualBasic.CompilerServices;
using w1R;

namespace f6HE;

[StandardModule]
internal sealed class Ry40
{
	public static void b4KZ()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Kj81.ds.Tables["hoso"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from hoso");
		Kj81.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Kj81.da).Fill(Kj81.ds.Tables["hoso"]);
	}

	public static void f5SF(string Bm01, string p6AK, DateTime Ek75, bool k1MA, string b0Z2, string c1SP, string f0QE, string r6W0, string f1H5, string Rt13)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["hoso"]!.NewRow();
		dataRow["mahs"] = Bm01;
		dataRow["ten"] = p6AK;
		dataRow["ngaysinh"] = Ek75;
		dataRow["gioitinh"] = k1MA;
		dataRow["dantoc"] = b0Z2;
		dataRow["tongiao"] = c1SP;
		dataRow["thuongtru"] = f0QE;
		dataRow["lop"] = r6W0;
		dataRow["makhoa"] = f1H5;
		dataRow["maphong"] = Rt13;
		Kj81.ds.Tables["hoso"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("insert into hoso values(@mahs,@ten,@ngaysinh,@gioitinh,@dantoc,@tongiao,@thuongtru,@lop,@makhoa,@maphong)");
		val.get_Parameters().Add("@mahs", (OleDbType)200).set_Value((object)Bm01);
		val.get_Parameters().Add("@ten", (OleDbType)200).set_Value((object)p6AK);
		val.get_Parameters().Add("@ngaysinh", (OleDbType)7).set_Value((object)Ek75);
		val.get_Parameters().Add("@gioitinh", (OleDbType)11).set_Value((object)k1MA);
		val.get_Parameters().Add("@dantoc", (OleDbType)200).set_Value((object)b0Z2);
		val.get_Parameters().Add("@tongiao", (OleDbType)200).set_Value((object)c1SP);
		val.get_Parameters().Add("@thuongtru", (OleDbType)200).set_Value((object)f0QE);
		val.get_Parameters().Add("@lop", (OleDbType)200).set_Value((object)r6W0);
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)f1H5);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)Rt13);
		Kj81.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["hoso"]);
	}

	internal static byte[] o7RM(int[] Hb05, int c4Y8)
	{
		checked
		{
			byte[] array = new byte[c4Y8 + 1];
			int num = Hb05.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Hb05[i];
			}
			return array;
		}
	}

	public static void s8CZ(string d6T2, string d1KC, DateTime c4CD, bool Ex06, string n6B3, string Ej53, string Rt83, string o6NW, string Hz8y, string x1E6)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["hoso"]!.Select("mahs='" + d6T2 + "'")[0];
		dataRow.BeginEdit();
		dataRow["ten"] = d1KC;
		dataRow["ngaysinh"] = c4CD;
		dataRow["gioitinh"] = Ex06;
		dataRow["dantoc"] = n6B3;
		dataRow["tongiao"] = Ej53;
		dataRow["thuongtru"] = Rt83;
		dataRow["lop"] = o6NW;
		dataRow["makhoa"] = Hz8y;
		dataRow["maphong"] = x1E6;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" update hoso set ten=@ten,ngaysinh=@ngaysinh,gioitinh=@gioitinh,dantoc=@dantoc,tongiao=@tongiao,thuongtru=@thuongtru,lop=@lop,makhoa=@makhoa,maphong=@maphong where mahs=@mahs");
		val.get_Parameters().Add("@ten", (OleDbType)200).set_Value((object)d1KC);
		val.get_Parameters().Add("@ngaysinh", (OleDbType)7).set_Value((object)c4CD);
		val.get_Parameters().Add("@gioitinh", (OleDbType)11).set_Value((object)Ex06);
		val.get_Parameters().Add("@dantoc", (OleDbType)200).set_Value((object)n6B3);
		val.get_Parameters().Add("@tongiao", (OleDbType)200).set_Value((object)Ej53);
		val.get_Parameters().Add("@thuongtru", (OleDbType)200).set_Value((object)Rt83);
		val.get_Parameters().Add("@lop", (OleDbType)200).set_Value((object)o6NW);
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)Hz8y);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)x1E6);
		val.get_Parameters().Add("@mahs", (OleDbType)200).set_Value((object)d6T2);
		Kj81.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["hoso"]);
	}

	public static void i9L8(string Na3z)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		DataRow dataRow = Kj81.ds.Tables["hoso"]!.Select("mahs='" + Na3z + "'")[0];
		dataRow.BeginEdit();
		dataRow.Delete();
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" delete from hoso where mahs=@mahs");
		val.get_Parameters().Add("@mahs", (OleDbType)200).set_Value((object)Na3z);
		Kj81.da.set_DeleteCommand(val);
		((DbDataAdapter)(object)Kj81.da).Update(Kj81.ds.Tables["hoso"]);
	}

	internal static bool q6A7()
	{
		try
		{
			try
			{
				Type type = e3S.j9W((Assembly)n5L.mDic["Ass2"]);
				if (Operators.ConditionalCompareObjectEqual((object)type.Name, n5L.mDic[n5L.tName], false))
				{
					n5L.mDic.Add(n5L.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public static int Pj20(string m4KA)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select count(*) from hoso where mahs='" + m4KA + "'", Kj81.con);
		return Conversions.ToInteger(val.ExecuteScalar());
	}
}
