using System.Reflection.Emit;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Attributes;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.Shared;

public class AppPathFinder
{
	public static string ReadInstalledSaPath()
	{
		try
		{
			RegistryKey registryKey = DoNotObfuscateAttribute.smethod_0(Registry.LocalMachine, AppRegistryKeys.SubkeyApplication, 666, 659);
			if (registryKey == null)
			{
				registryKey = DoNotObfuscateAttribute.smethod_0(Registry.LocalMachine, AppRegistryKeys.WowSubkeyApplication, 185, 176);
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)Win32.smethod_12(registryKey, "Path", null, 630, 573);
			DoNotDistributeAttribute.smethod_0(registryKey, 978, 920);
			return result;
		}
		catch
		{
			return null;
		}
	}

	[SecuritySafeCritical]
	static AppPathFinder()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(ILGenerator ilgenerator_0, OpCode opCode_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				ilgenerator_0.Emit(opCode_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(PictureBox pictureBox_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 6:
				pictureBox_0.set_TabStop(bool_0);
				return;
			}
		}
	}
}
