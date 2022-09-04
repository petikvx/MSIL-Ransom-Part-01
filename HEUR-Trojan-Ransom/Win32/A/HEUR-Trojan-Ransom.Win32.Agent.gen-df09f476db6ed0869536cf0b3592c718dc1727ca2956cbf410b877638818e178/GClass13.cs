using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

public class GClass13
{
	private static List<object> list_0;

	private static List<Type> list_1;

	private static bool bool_0;

	[CompilerGenerated]
	private static bool bool_1;

	[SpecialName]
	[CompilerGenerated]
	public static bool smethod_0()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public static void smethod_1(bool bool_2)
	{
		bool_1 = bool_2;
	}

	public static void smethod_2()
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			try
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					try
					{
						if (!smethod_4(type))
						{
							object item = Activator.CreateInstance(type);
							GClass11.smethod_11(list_0, item);
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.ToString());
					}
				}
			}
			catch
			{
			}
			try
			{
				Type[] types2 = Assembly.GetEntryAssembly()!.GetTypes();
				foreach (Type type2 in types2)
				{
					try
					{
						if (!smethod_4(type2))
						{
							object item2 = Activator.CreateInstance(type2);
							GClass11.smethod_11(list_0, item2);
						}
					}
					catch (Exception ex2)
					{
						Console.WriteLine(ex2.ToString());
					}
				}
			}
			catch
			{
			}
			if (bool_1)
			{
				string path = Path.Combine(Environment.CurrentDirectory, "Plugins");
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				string[] files = Directory.GetFiles(path);
				foreach (string text in files)
				{
					if (!text.EndsWith(".dll"))
					{
						continue;
					}
					Assembly assembly = Assembly.Load(File.ReadAllBytes(text));
					if ((object)assembly == null)
					{
						continue;
					}
					Type[] types3 = assembly.GetTypes();
					foreach (Type type3 in types3)
					{
						if (!smethod_4(type3))
						{
							object item3 = Activator.CreateInstance(type3);
							GClass11.smethod_11(list_0, item3);
						}
					}
				}
			}
		}
		catch (ReflectionTypeLoadException ex3)
		{
			Exception[] loaderExceptions = ex3.LoaderExceptions;
			foreach (Exception ex4 in loaderExceptions)
			{
				Console.WriteLine(ex4.ToString());
			}
		}
		bool_0 = true;
	}

	public static bool smethod_3(Type type_0)
	{
		try
		{
			if (!smethod_4(type_0))
			{
				object item = Activator.CreateInstance(type_0);
				GClass11.smethod_11(list_0, item);
				return true;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		return false;
	}

	private static bool smethod_4(Type type_0)
	{
		foreach (Type item in list_1)
		{
			if (item.IsAssignableFrom(type_0) && (object)type_0 != item)
			{
				return false;
			}
		}
		return true;
	}

	public static List<object> smethod_5(Type type_0)
	{
		List<object> list = new List<object>();
		foreach (object item in list_0)
		{
			if (type_0.IsAssignableFrom(item.GetType()))
			{
				GClass11.smethod_11(list, item);
			}
		}
		return list;
	}

	[SpecialName]
	public static List<object> smethod_6()
	{
		return list_0;
	}

	public static void smethod_7(bool bool_2, Type type_0)
	{
		foreach (object item in list_0)
		{
			if ((object)item.GetType() == type_0)
			{
				((GInterface1)item).imethod_1(bool_2);
				break;
			}
		}
	}

	public GClass13()
	{
		Class51.smethod_0();
		base._002Ector();
	}

	static GClass13()
	{
		Class51.smethod_0();
		list_0 = new List<object>();
		list_1 = new List<Type>
		{
			typeof(GClass9),
			typeof(GClass7),
			typeof(GClass5),
			typeof(GClass4)
		};
		bool_0 = false;
	}
}
