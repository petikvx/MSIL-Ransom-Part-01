using System;
using System.Windows.Forms;
using Microsoft.Win32;

internal class AijYXqULkuWsMMxfOwtOaaGqGjIGA
{
	public static void afblDJvHlcEMYUUJEFPWeHavdzfN()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers");
			using RegistryKey registryKey2 = registryKey.CreateSubKey("CurrentVersion");
			using RegistryKey registryKey3 = registryKey2.CreateSubKey("AppCompatFlags");
			using RegistryKey registryKey4 = registryKey3.CreateSubKey("Layers");
			registryKey.SetValue(Application.get_StartupPath() + "\\lin.bin", "~RUNASADMIN 640X480 16BITCOLOR WINXPSP2");
			registryKey4.SetValue(Application.get_StartupPath() + "\\lin.bin", "~RUNASADMIN 640X480 16BITCOLOR WINXPSP2");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static void ITPiqLltiLIuWawMFwtgxjqCGrJbA()
	{
		try
		{
			if (Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", writable: true) != null)
			{
				Registry.CurrentUser.DeleteSubKeyTree("Layers");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static void VSjheIcONfHVVIIpjagbUlrXknnC()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(Application.get_StartupPath() + "\\lin.exe", "~ DWM8And16BitMitigation RUNASADMIN 16BITCOLOR WINXPSP2", RegistryValueKind.String);
			registryKey.SetValue(Application.get_StartupPath() + "\\lin.bin", "~ DWM8And16BitMitigation RUNASADMIN 16BITCOLOR WINXPSP2", RegistryValueKind.String);
			Console.WriteLine("레지스트리 정보를 등록 하였습니다.");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message, "레지스트리 등록 실패");
		}
	}
}
