using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns2;
using ns21;
using ns25;
using ns6;

namespace ns26;

internal sealed class Class158 : Class157
{
	private bool bool_0;

	private readonly List<Class156> list_0 = new List<Class156>();

	[NonSerialized]
	internal static GetString getString_1;

	public Class158(Class139 class139_1)
	{
		class139_0 = class139_1;
		method_0(class139_1.Settings.CommandInterceptors);
	}

	public bool method_1(string string_0, ref object object_0)
	{
		if (bool_0)
		{
			return false;
		}
		bool_0 = true;
		bool flag = false;
		foreach (Class156 item in list_0)
		{
			flag |= item.vmethod_0(string_0, ref object_0);
		}
		bool_0 = false;
		return flag;
	}

	public bool method_2(string string_0, ref int int_0)
	{
		if (bool_0)
		{
			return false;
		}
		bool_0 = true;
		bool flag = false;
		foreach (Class156 item in list_0)
		{
			flag |= item.vmethod_1(string_0, ref int_0);
		}
		bool_0 = false;
		return flag;
	}

	public bool method_3(string string_0, CommandBehavior commandBehavior_0, ref Class142 class142_0)
	{
		if (bool_0)
		{
			return false;
		}
		bool_0 = true;
		bool flag = false;
		foreach (Class156 item in list_0)
		{
			flag |= item.vmethod_2(string_0, commandBehavior_0, ref class142_0);
		}
		bool_0 = false;
		return flag;
	}

	protected override void vmethod_0(object object_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentException(getString_1(107350971));
		}
		if (!(object_0 is Class156))
		{
			throw new InvalidOperationException(string.Format(Class121.TypeIsNotCommandInterceptor, object_0.GetType()));
		}
		((Class156)object_0).vmethod_3(class139_0);
		list_0.Insert(0, (Class156)object_0);
	}

	protected override string vmethod_1(string string_0)
	{
		if (MySqlConfiguration.Settings != null && MySqlConfiguration.Settings.CommandInterceptors != null)
		{
			using (IEnumerator<InterceptorConfigurationElement> enumerator = MySqlConfiguration.Settings.CommandInterceptors.System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					InterceptorConfigurationElement current = enumerator.Current;
					if (string.Compare(current.Name, string_0, ignoreCase: true) == 0)
					{
						return current.Type;
					}
				}
			}
			return base.vmethod_1(string_0);
		}
		return base.vmethod_1(string_0);
	}

	static Class158()
	{
		Strings.CreateGetStringDelegate(typeof(Class158));
	}
}
