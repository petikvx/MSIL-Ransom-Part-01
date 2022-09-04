using System;
using System.Security.Principal;
using System.Threading;

internal sealed class Class29
{
	private static Mutex mutex_0;

	public static void smethod_0()
	{
		try
		{
			mutex_0 = Mutex.OpenExisting(Class11.string_7);
			Environment.Exit(0);
		}
		catch
		{
			mutex_0 = new Mutex(initiallyOwned: true, Class11.string_7);
		}
	}

	public static int smethod_1(int int_0, int int_1)
	{
		Random random = new Random();
		return random.Next(int_0, int_1);
	}

	public static string smethod_2(int int_0)
	{
		Random random = new Random();
		string text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			text2 += text.Substring(random.Next(0, text.Length), 1);
		}
		return text2;
	}

	public static bool smethod_3()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}
}
