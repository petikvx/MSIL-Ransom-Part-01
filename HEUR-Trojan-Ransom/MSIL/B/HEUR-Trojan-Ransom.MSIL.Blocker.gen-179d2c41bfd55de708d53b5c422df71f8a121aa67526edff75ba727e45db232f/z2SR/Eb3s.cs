using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ew6i;
using Microsoft.VisualBasic.CompilerServices;

namespace z2SR;

[StandardModule]
internal sealed class Eb3s
{
	public static SqlConnection con;

	public static object g4R6()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con = new SqlConnection(b6Q8.Settings.libraryConnectionString);
			con.Open();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("Error in Database Connection \\n Error code: " + ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
		}
		return null;
	}
}
