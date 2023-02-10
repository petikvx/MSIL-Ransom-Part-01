using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rm59;
using s3L2;
using z5S;

namespace Ps0g;

[StandardModule]
internal sealed class Zs8q
{
	public static bool r3Z8(string Wr46)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			g8H5.con.Ye0f();
			g6DS cmd = g8H5.cmd;
			cmd.Connection = g8H5.con;
			cmd.CommandText = Wr46;
			g8H5.result = g8H5.cmd.ExecuteNonQuery;
			if (g8H5.result == 0)
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
			g8H5.con.Ew4k();
		}
		return false;
	}

	public static bool x4M6(string Nn7g)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			g8H5.con.Ye0f();
			g6DS cmd = g8H5.cmd;
			cmd.Connection = g8H5.con;
			cmd.CommandText = Nn7g;
			g8H5.result = g8H5.cmd.ExecuteNonQuery;
			if (g8H5.result == 0)
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
			g8H5.con.Ew4k();
		}
		return false;
	}

	internal static void Ap3z()
	{
		string[] ym = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = c2S.i5K(ym, 0, 3);
		string value2 = c2S.i5K(ym, 4, 7);
		c2S.mDic.Add(c2S.tName, value);
		c2S.mDic.Add(c2S.mName, value2);
	}

	public static bool Hd09(string e0L2)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			g8H5.con.Ye0f();
			g6DS cmd = g8H5.cmd;
			cmd.Connection = g8H5.con;
			cmd.CommandText = e0L2;
			g8H5.result = g8H5.cmd.ExecuteNonQuery;
			if (g8H5.result == 0)
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
			g8H5.con.Ew4k();
		}
		return false;
	}
}
