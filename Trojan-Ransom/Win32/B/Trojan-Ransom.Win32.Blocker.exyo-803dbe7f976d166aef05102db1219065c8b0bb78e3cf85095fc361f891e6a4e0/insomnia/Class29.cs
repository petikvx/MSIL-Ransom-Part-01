using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace insomnia;

internal class Class29
{
	private static IPAddress Field2 = Class18.Method3(A_0: true);

	private static Interface22 Field1 = null;

	private static Interface22 Method9(Interface19 A_0)
	{
		IEnumerator enumerator = A_0.Property37.Method1();
		try
		{
			while (enumerator.MoveNext())
			{
				Interface22 @interface = (Interface22)enumerator.Current;
				if (!Method7(@interface))
				{
					if (A_0.Property51)
					{
						return Method8(A_0.Property50);
					}
					continue;
				}
				return @interface;
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		return null;
	}

	private static Interface22 Method8(Interface21 A_0)
	{
		IEnumerator enumerator = A_0.Method1();
		try
		{
			while (enumerator.MoveNext())
			{
				Interface19 a_ = (Interface19)enumerator.Current;
				Interface22 @interface = Method9(a_);
				if (@interface != null)
				{
					return @interface;
				}
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		return null;
	}

	private static bool Method7(Interface22 A_0)
	{
		return A_0.Property34 == "urn:schemas-upnp-org:service:WANIPConnection:1";
	}

	public static bool Method6(int A_0, string A_1)
	{
		if (Field1 == null)
		{
			return false;
		}
		object[] a_ = new object[3] { "", A_0, A_1 };
		object A_2 = new object();
		try
		{
			Field1.Method2("DeletePortMapping", a_, ref A_2);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool Method5()
	{
		Field1 = null;
		Interface20 @interface = (Interface20)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("E2085F28-FEB7-404A-B8E7-E659BDEAAA02")));
		Field1 = Method8(@interface.Method5("urn:schemas-upnp-org:device:InternetGatewayDevice:1", 0u));
		return Field1 != null;
	}

	public static string Method4()
	{
		if (Field1 == null)
		{
			return "";
		}
		object a_ = new object();
		object A_ = new object();
		Field1.Method2("GetExternalIPAddress", a_, ref A_);
		object[] array = (object[])A_;
		return (string)array[0];
	}

	public static List<Struct4> Method3()
	{
		if (Field1 == null)
		{
			return null;
		}
		List<Struct4> list = new List<Struct4>();
		bool flag = false;
		int num = 0;
		while (!flag)
		{
			object[] a_ = new object[1] { num };
			object A_ = new object();
			try
			{
				Field1.Method2("GetGenericPortMappingEntry", a_, ref A_);
				object[] array = (object[])A_;
				num++;
				Struct4 item = default(Struct4);
				item.Field4 = (ushort)array[1];
				item.Field3 = (ushort)array[3];
				item.Field2 = (string)array[2];
				item.Field1 = (string)array[6];
				list.Add(item);
			}
			catch
			{
				flag = true;
			}
		}
		return list;
	}

	public static bool Method2(int A_0, string A_1)
	{
		if (Field1 == null)
		{
			return false;
		}
		object[] a_ = new object[3] { "", A_0, A_1 };
		object A_2 = new object();
		try
		{
			Field1.Method2("GetSpecificPortMappingEntry", a_, ref A_2);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool Method1(int A_0, int A_1, string A_2, string A_3, int A_4 = 0)
	{
		if (Field1 != null && !Method2(A_0, A_2))
		{
			object[] a_ = new object[8]
			{
				"",
				A_0,
				A_2,
				A_1,
				Field2.ToString(),
				true,
				A_3,
				A_4
			};
			object A_5 = new object();
			try
			{
				Field1.Method2("AddPortMapping", a_, ref A_5);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}
}
