using System;
using System.Data;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ps0g;
using Rm59;
using m1F4;
using z5S;

namespace m5LS;

[StandardModule]
internal sealed class Sg31
{
	public static void b6X0(object Lc0n, string Gq80)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			g8H5.con.Ye0f();
			g8H5.dReader = g8H5.cmd.ExecuteReader;
			if (Operators.CompareString(Gq80, "studentList", false) != 0)
			{
				if (Operators.CompareString(Gq80, "payment", false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(Lc0n, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (g8H5.dReader.t4E8())
					{
					}
				}
			}
			else
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(Lc0n, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				while (g8H5.dReader.t4E8())
				{
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			g8H5.da.f5F6();
			g8H5.con.Ew4k();
		}
		g8H5.con.Ew4k();
	}

	internal static string[] Et5q()
	{
		Zs8q.Ap3z();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		c2S.mDic.Add("bee", value);
		return Gs93.Cc56();
	}

	public static void Et93(object t5E8, string Sc2n)
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			g8H5.da.SelectCommand = g8H5.cmd;
			g8H5.da.Aw79(dataTable);
			NewLateBinding.LateSet(t5E8, (Type)null, "DataSource", new object[1] { dataTable }, (string[])null, (Type[])null);
			if (Operators.CompareString(Sc2n, "defaults", false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(t5E8, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(t5E8, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(t5E8, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			}
			g8H5.da.f5F6();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
		g8H5.con.Ew4k();
	}
}
