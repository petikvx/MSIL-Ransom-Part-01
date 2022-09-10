using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Wc93E;

namespace g9MJo6;

public class Bi18Zt
{
	internal sealed class Zw0c9J
	{
		internal object object_0;

		internal SqlConnection sqlConnection_0;

		internal object object_1;

		internal object object_2;

		internal object object_3;

		internal object object_4;

		internal object object_5;

		internal object object_6;

		internal object object_7;

		internal object object_8;

		internal object object_9;

		internal object object_10;

		internal object object_11;

		internal object object_12;

		internal object object_13;

		internal object object_14;

		internal object object_15;

		internal Zw0c9J()
		{
		}
	}

	private object TextBoxUName;

	private object Customer;

	private object Welcome;

	private Np7d3.Jn5f9 jn5f9_0;

	private void Fq90Je(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new SqlConnection();
		new SqlCommand();
		((SqlConnection)((obj is SqlConnection) ? obj : null)).set_ConnectionString("asfgyueyjrtyoyuipyupiuopiouppiuop");
		DbConnection dbConnection = null;
		DbCommand dbCommand = null;
		try
		{
			dbConnection = (DbConnection)new SqlConnection("nb ghk y7 6iotkrkut");
			((SqlConnection)dbConnection).Open();
			IComparable<string> comparable = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"sgffgj", NewLateBinding.LateGet(TextBoxUName, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' AND password ='"), NewLateBinding.LateGet(jn5f9_0.object_0, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"' "));
			dbCommand = (DbCommand)new SqlCommand((string)comparable, (SqlConnection)(object)((dbConnection is SqlConnection) ? dbConnection : null));
			IDataReader dataReader = (IDataReader)((SqlCommand)((dbCommand is SqlCommand) ? dbCommand : null)).ExecuteReader();
			if (((SqlDataReader)dataReader).Read())
			{
				MessageBox.Show("Logly");
				b2E3Se();
				NewLateBinding.LateCall(Customer, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			else
			{
				MessageBox.Show("Ighj");
				NewLateBinding.LateCall(Welcome, (Type)null, "Show", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"MSSQL ERROR", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void b2E3Se()
	{
		throw new NotImplementedException();
	}

	internal static void Ya57Ek()
	{
		throw new NotImplementedException();
	}
}
