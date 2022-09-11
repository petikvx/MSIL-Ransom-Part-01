using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns12;
using ns2;
using ns21;
using ns4;

namespace ns18;

internal static class Class183
{
	private static List<Class184> list_0;

	private static object object_0;

	[CompilerGenerated]
	private static IList<Class184> ilist_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal static IList<Class184> Groups
	{
		[CompilerGenerated]
		get
		{
			return ilist_0;
		}
		[CompilerGenerated]
		private set
		{
			ilist_0 = value;
		}
	}

	static Class183()
	{
		Strings.CreateGetStringDelegate(typeof(Class183));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399492), getString_0(107399487)).Replace(getString_0(107399450), getString_0(107399445)));
		if (StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) && bool_ && executingAssembly.FullName!.EndsWith(getString_0(107399440)))
		{
			list_0 = new List<Class184>();
			object_0 = new object();
			Groups = list_0;
			if (MySqlConfiguration.Settings == null)
			{
				return;
			}
			using IEnumerator<ReplicationServerGroupConfigurationElement> enumerator = MySqlConfiguration.Settings.Replication.ServerGroups.System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator();
			while (enumerator.MoveNext())
			{
				ReplicationServerGroupConfigurationElement current = enumerator.Current;
				Class184 @class = smethod_1(current.Name, current.GroupType, current.RetryTime);
				using IEnumerator<ReplicationServerConfigurationElement> enumerator2 = current.Servers.System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator();
				while (enumerator2.MoveNext())
				{
					ReplicationServerConfigurationElement current2 = enumerator2.Current;
					@class.method_0(current2.Name, current2.IsMaster, current2.ConnectionString);
				}
			}
			return;
		}
		throw new SecurityException(getString_0(107399415));
	}

	internal static Class184 smethod_0(string string_0, int int_0)
	{
		return smethod_1(string_0, null, int_0);
	}

	internal static Class184 smethod_1(string string_0, string string_1, int int_0)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			string_1 = getString_0(107371541);
		}
		Class184 @class = (Class184)Activator.CreateInstance(Type.GetType(string_1), string_0, int_0);
		list_0.Add(@class);
		return @class;
	}

	internal static Class188 smethod_2(string string_0, bool bool_0)
	{
		return smethod_3(string_0).vmethod_0(bool_0);
	}

	internal static Class184 smethod_3(string string_0)
	{
		Class184 @class = null;
		foreach (Class184 item in list_0)
		{
			if (string.Compare(item.Name, string_0, StringComparison.OrdinalIgnoreCase) == 0)
			{
				@class = item;
				break;
			}
		}
		if (@class == null)
		{
			throw new MySqlException(string.Format(Class121.ReplicationGroupNotFound, string_0));
		}
		return @class;
	}

	internal static bool smethod_4(string string_0)
	{
		foreach (Class184 item in list_0)
		{
			if (string.Compare(item.Name, string_0, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		return false;
	}

	internal static void smethod_5(string string_0, bool bool_0, Class139 class139_0)
	{
		while (true)
		{
			lock (object_0)
			{
				if (!smethod_4(string_0))
				{
					break;
				}
				Class184 @class = smethod_3(string_0);
				Class188 class2 = @class.vmethod_1(bool_0, class139_0.Settings);
				if (class2 == null)
				{
					throw new MySqlException(Class121.Replication_NoAvailableServer);
				}
				try
				{
					bool flag = false;
					if (class139_0.class143_0 != null && class139_0.class143_0.IsOpen)
					{
						if (!new MySqlConnectionStringBuilder(class2.ConnectionString).Equals(class139_0.class143_0.Settings))
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						Class143 class3 = (class139_0.class143_0 = Class143.smethod_0(new MySqlConnectionStringBuilder(class2.ConnectionString)));
					}
					break;
				}
				catch (MySqlException ex)
				{
					class139_0.class143_0 = null;
					class2.IsAvailable = false;
					MySqlTrace.smethod_4(ex.Number, ex.ToString());
					if (ex.Number != 1042)
					{
						throw;
					}
					@class.vmethod_3(class2, ex);
				}
				continue;
			}
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
