using System;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;

namespace ns1;

internal sealed class Class2
{
	public static string smethod_0()
	{
		RegistryKey registryKey = default(RegistryKey);
		string text = default(string);
		string text2 = default(string);
		try
		{
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class3.smethod_0());
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Class3.smethod_1());
				}
				if (registryKey == null)
				{
					text = null;
					return text;
				}
				text2 = (string)registryKey.GetValue("Path", null);
				registryKey.Close();
				text = text2;
				return text;
			}
			catch
			{
				text = null;
				return text;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, registryKey, text2, text);
			throw;
		}
	}
}
