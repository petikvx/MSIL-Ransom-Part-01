using System;
using Hr60;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Yw6;
using d1C;

namespace Yk7;

[StandardModule]
internal sealed class y8T
{
	public static bool f3E(string i5K)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Xe9.con.k4F();
			Eo3 cmd = Xe9.cmd;
			cmd.Connection = Xe9.con;
			cmd.CommandText = i5K;
			Xe9.result = Xe9.cmd.ExecuteNonQuery;
			if (Xe9.result == 0)
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Xe9.con.Xb4();
		}
		return false;
	}

	public static bool Ad2(string Tg5)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Xe9.con.k4F();
			Eo3 cmd = Xe9.cmd;
			cmd.Connection = Xe9.con;
			cmd.CommandText = Tg5;
			Xe9.result = Xe9.cmd.ExecuteNonQuery;
			if (Xe9.result == 0)
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Xe9.con.Xb4();
		}
		return false;
	}

	internal static void Hk9()
	{
		string[] xj8w = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = t0S8.Zm2f(xj8w, 0, 3);
		string value2 = t0S8.Zm2f(xj8w, 4, 7);
		t0S8.mDic.Add(t0S8.tName, value);
		t0S8.mDic.Add(t0S8.mName, value2);
	}

	public static bool i2A(string Yg4)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Xe9.con.k4F();
			Eo3 cmd = Xe9.cmd;
			cmd.Connection = Xe9.con;
			cmd.CommandText = Yg4;
			Xe9.result = Xe9.cmd.ExecuteNonQuery;
			if (Xe9.result == 0)
			{
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Xe9.con.Xb4();
		}
		return false;
	}
}
