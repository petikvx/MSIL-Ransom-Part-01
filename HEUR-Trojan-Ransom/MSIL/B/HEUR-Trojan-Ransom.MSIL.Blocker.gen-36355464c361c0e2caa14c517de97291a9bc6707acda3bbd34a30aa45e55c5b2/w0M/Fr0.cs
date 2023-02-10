using System;
using System.Data;
using System.Reflection;
using Hr60;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yk7;
using Yw6;
using q3G;

namespace w0M;

[StandardModule]
internal sealed class Fr0
{
	public static void t0C(object d5W, string f7S)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Xe9.con.k4F();
			Xe9.dReader = Xe9.cmd.ExecuteReader;
			if (Operators.CompareString(f7S, "studentList", false) != 0)
			{
				if (Operators.CompareString(f7S, "payment", false) == 0)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(d5W, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					while (Xe9.dReader.Kb8())
					{
					}
				}
			}
			else
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(d5W, (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				while (Xe9.dReader.Kb8())
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
			Xe9.da.Ns5();
			Xe9.con.Xb4();
		}
		Xe9.con.Xb4();
	}

	internal static string[] Am2()
	{
		y8T.Hk9();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		t0S8.mDic.Add("bee", value);
		return Yd3.x9B();
	}

	public static void z8F(object z3A, string e3N)
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		try
		{
			Xe9.da.SelectCommand = Xe9.cmd;
			Xe9.da.w3B(dataTable);
			NewLateBinding.LateSet(z3A, (Type)null, "DataSource", new object[1] { dataTable }, (string[])null, (Type[])null);
			if (Operators.CompareString(e3N, "defaults", false) == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(z3A, (Type)null, "Columns", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(z3A, (Type)null, "Columns", new object[1] { 1 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(z3A, (Type)null, "Columns", new object[1] { 2 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Visible", new object[1] { false }, (string[])null, (Type[])null, false, true);
			}
			Xe9.da.Ns5();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
		Xe9.con.Xb4();
	}
}
