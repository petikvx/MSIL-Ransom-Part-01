using System;
using System.IO;
using System.Text;

internal class Class44
{
	private enum Enum14
	{
		const_0,
		const_1
	}

	private int int_0;

	internal Class46 class46_0;

	private Class39 class39_0;

	internal Class46 class46_1;

	private int int_1;

	private int int_2;

	private int int_3;

	private Enum14 enum14_0;

	private Encoding encoding_0;

	internal string string_0;

	internal Class46 class46_2;

	public string string_1 = Class86.smethod_0("\uf77a\uf761", 63233);

	public string string_2 = Class86.smethod_0("\ue163\ue17a", 57681);

	public string string_3 = Class86.smethod_0("\uf0bc", 61628);

	public string string_4 = Class86.smethod_0("\ue6c5\ue6f2\ue6e4\ue6e7\ue6f8\ue6f9\ue6e4\ue6f2\ue6b9\ue6c0\ue6e5\ue6fe\ue6e3\ue6f2\ue6b7", 59029);

	private string string_5 = Class86.smethod_0("\ueeef\ueede\ueec3\ueecf\ueef9\ueed7\ueed4\ueed8\ueed0\uee93\ueec0\uee8b\ueec6\uee92", 61096);

	public string String_0
	{
		get
		{
			string text = "";
			int num = Class84.smethod_0(0);
			Class46.Class47 @class = Delegate508.smethod_0(class46_1);
			try
			{
				Enum9 enum9_ = default(Enum9);
				while (Delegate511.smethod_0(@class) ? true : false)
				{
					Class39 class2 = Delegate509.smethod_0(@class);
					while (true)
					{
						int num2 = Class84.smethod_0(42);
						int num3 = Class89.smethod_1(61);
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(410))
							{
							case -109:
								break;
							default:
								goto IL_0040;
							case -110:
								goto IL_004b;
							case -111:
								num3 = -8;
								continue;
							case -112:
								goto end_IL_009a;
							}
							goto IL_0031;
							IL_004b:
							switch (num2)
							{
							case 103:
								goto IL_006b;
							case 104:
								goto IL_007d;
							case 105:
								goto IL_0082;
							case 106:
								goto end_IL_00c8;
							}
							num3 = -7;
							continue;
							IL_0082:
							switch (enum9_)
							{
							case Enum9.const_0:
								goto IL_00dc;
							case Enum9.const_1:
								goto IL_00ff;
							}
							num2 = 0;
							goto IL_0031;
							IL_00ff:
							text = text + string_4 + string.Format(string_5, num) + Class86.smethod_0("\ue0b1", 57386);
							num += Class84.smethod_0(1);
							goto end_IL_00c8;
							IL_00dc:
							text = text + Delegate510.smethod_0((Class41)class2) + Class86.smethod_0("\ue0b1", 57386);
							goto end_IL_00c8;
							IL_0040:
							num3 = Class89.smethod_1(60);
							continue;
							IL_007d:
							num2 = 2;
							goto IL_0031;
							IL_006b:
							enum9_ = class2.enum9_0;
							num2 = Class84.smethod_0(7);
							goto IL_0031;
							IL_0031:
							num2 ^= Class84.smethod_0(409);
							goto IL_0040;
							continue;
							end_IL_009a:
							break;
						}
						continue;
						end_IL_00c8:
						break;
					}
				}
				return text;
			}
			finally
			{
				IDisposable disposable = @class as IDisposable;
				if (disposable != null || 1 == 0)
				{
					disposable.Dispose();
				}
			}
		}
	}

	public Class46 Class46_0 => class46_0;

	public Class46 Class46_1 => class46_1;

	public Encoding Encoding_0 => encoding_0;

	public Class46 Class46_2 => class46_2;

	public Class44()
	{
		class46_0 = Delegate507.smethod_0(this);
		while (true)
		{
			int num = Class84.smethod_0(0);
			while (true)
			{
				switch (num ^ Class84.smethod_0(48))
				{
				case 101:
					class46_2 = Delegate507.smethod_0(this);
					num = Class84.smethod_0(1);
					continue;
				case 100:
					class46_1 = Delegate507.smethod_0(this);
					num = 3;
					continue;
				case 99:
					num = 6;
					continue;
				case 102:
					return;
				}
				break;
			}
		}
	}

	public Class41 method_0()
	{
		return (Class41)Delegate512.smethod_0(this, (Enum9)Class84.smethod_0(0));
	}

	public Class40 method_1()
	{
		return (Class40)Delegate512.smethod_0(this, (Enum9)Class84.smethod_0(1));
	}

	public void method_2(Stream stream_0)
	{
		Delegate513.smethod_0(this, new StreamReader(stream_0));
	}

	public void method_3(Stream stream_0, bool bool_0)
	{
		Delegate513.smethod_0(this, new StreamReader(stream_0, bool_0));
	}

	public void method_4(Stream stream_0, Encoding encoding_1)
	{
		Delegate513.smethod_0(this, new StreamReader(stream_0, encoding_1));
	}

	public void method_5(Stream stream_0, Encoding encoding_1, bool bool_0)
	{
		Delegate513.smethod_0(this, new StreamReader(stream_0, encoding_1, bool_0));
	}

	public void method_6(Stream stream_0, Encoding encoding_1, bool bool_0, int int_4)
	{
		Delegate513.smethod_0(this, new StreamReader(stream_0, encoding_1, bool_0, int_4));
	}

	public void method_7(string string_6)
	{
		Delegate513.smethod_0(this, new StreamReader(string_6));
	}

	public void method_8(string string_6, bool bool_0)
	{
		Delegate513.smethod_0(this, new StreamReader(string_6, bool_0));
	}

	public void method_9(string string_6, Encoding encoding_1)
	{
		Delegate513.smethod_0(this, new StreamReader(string_6, encoding_1));
	}

	public void method_10(string string_6, Encoding encoding_1, bool bool_0)
	{
		Delegate513.smethod_0(this, new StreamReader(string_6, encoding_1, bool_0));
	}

	public void method_11(string string_6, Encoding encoding_1, bool bool_0, int int_4)
	{
		Delegate513.smethod_0(this, new StreamReader(string_6, encoding_1, bool_0, int_4));
	}

	public void method_12(TextReader textReader_0)
	{
		Delegate514.smethod_0(class46_0);
		StreamReader streamReader = default(StreamReader);
		while (true)
		{
			int num = Class84.smethod_0(9);
			while (true)
			{
				switch (num ^ Class84.smethod_0(67))
				{
				case 111:
					streamReader = textReader_0 as StreamReader;
					num = 6;
					continue;
				case 110:
					if (streamReader != null)
					{
						num = 24;
						continue;
					}
					if (1 == 0)
					{
						goto case 112;
					}
					goto IL_0079;
				case 109:
					Delegate514.smethod_0(class46_2);
					num = 7;
					continue;
				case 108:
					num = Class84.smethod_0(8);
					continue;
				case 112:
					{
						encoding_0 = streamReader.CurrentEncoding;
						goto IL_0079;
					}
					IL_0079:
					string_0 = textReader_0.ReadToEnd();
					textReader_0.Close();
					Delegate515.smethod_0(this);
					return;
				}
				break;
			}
		}
	}

	public void method_13(string string_6)
	{
		Delegate513.smethod_0(this, new StringReader(string_6));
	}

	public void method_14(Stream stream_0)
	{
		StreamWriter streamWriter_ = new StreamWriter(stream_0, Delegate516.smethod_0(this));
		Delegate517.smethod_0(this, streamWriter_);
	}

	public void method_15(Stream stream_0, Encoding encoding_1)
	{
		StreamWriter streamWriter_ = new StreamWriter(stream_0, encoding_1);
		Delegate517.smethod_0(this, streamWriter_);
	}

	public void method_16(string string_6)
	{
		StreamWriter streamWriter_ = new StreamWriter(string_6, (byte)Class84.smethod_0(0) != 0, Delegate516.smethod_0(this));
		Delegate517.smethod_0(this, streamWriter_);
	}

	public void method_17(string string_6, Encoding encoding_1)
	{
		StreamWriter streamWriter_ = new StreamWriter(string_6, (byte)Class84.smethod_0(0) != 0, encoding_1);
		Delegate517.smethod_0(this, streamWriter_);
	}

	public void method_18(StreamWriter streamWriter_0)
	{
		Delegate518.smethod_0(this, streamWriter_0);
	}

	public void method_19(TextWriter textWriter_0)
	{
		textWriter_0.Flush();
	}

	internal Class39 method_20(Enum9 enum9_0)
	{
		return enum9_0 switch
		{
			Enum9.const_0 => Delegate520.smethod_0(this), 
			Enum9.const_1 => Delegate519.smethod_0(this), 
			_ => throw new NotSupportedException(), 
		};
	}

	internal Encoding method_21()
	{
		if (encoding_0 != null || 1 == 0)
		{
			return encoding_0;
		}
		return Encoding.Default;
	}

	private void method_22()
	{
		int_1 += Class84.smethod_0(1);
		while (true)
		{
			int num = Class49.smethod_0(83);
			while (true)
			{
				switch (num ^ Class84.smethod_0(410))
				{
				case -103:
					num = -16;
					continue;
				case -104:
					int_3 = Class84.smethod_0(1);
					num = -1;
					continue;
				case -105:
					if (int_0 == Class84.smethod_0(80))
					{
						num = -15;
						continue;
					}
					int_3 += Class84.smethod_0(1);
					return;
				case -106:
					int_2 += Class84.smethod_0(1);
					num = Class89.smethod_1(63);
					continue;
				case -102:
					return;
				}
				break;
			}
		}
	}

	private void method_23()
	{
		enum14_0 = (Enum14)Class84.smethod_0(0);
		int_1 = Class84.smethod_0(0);
		class39_0 = Delegate512.smethod_0(this, (Enum9)Class84.smethod_0(1));
		Enum14 @enum = default(Enum14);
		while (int_1 < string_0.Length)
		{
			int_0 = string_0[int_1];
			while (true)
			{
				int num = Class89.smethod_1(64);
				while (true)
				{
					switch (num ^ Class84.smethod_0(405))
					{
					case -110:
						Delegate521.smethod_0(this);
						num = -20;
						continue;
					case -111:
						num = -14;
						continue;
					case -112:
						break;
					case -113:
						@enum = enum14_0;
						num = -13;
						continue;
					default:
						goto end_IL_0075;
					case -109:
						goto end_IL_009f;
					}
					switch (@enum)
					{
					default:
						num = -16;
						continue;
					case Enum14.const_0:
						if (int_1 + string_2.Length >= string_0.Length || ((!(string_0.Substring(int_1 - Class84.smethod_0(1), string_2.Length) == string_2)) ? true : false))
						{
							break;
						}
						enum14_0 = (Enum14)Class84.smethod_0(1);
						while (true)
						{
							int num3 = Class89.smethod_1(60);
							while (true)
							{
								switch (num3 ^ Class84.smethod_0(48))
								{
								case -96:
									class39_0 = Delegate512.smethod_0(this, (Enum9)Class84.smethod_0(0));
									num3 = -6;
									continue;
								case -97:
									Delegate522.smethod_0(this);
									num3 = -60;
									continue;
								case -98:
									class39_0.int_1 = int_1 - Class84.smethod_0(1) - class39_0.int_0;
									num3 = Class76.smethod_0(103);
									continue;
								case -99:
									num3 = -8;
									continue;
								case -95:
									goto end_IL_0059;
								}
								break;
							}
						}
					case Enum14.const_1:
						{
							if (int_1 + string_1.Length >= string_0.Length || ((!(string_0.Substring(int_1 - Class84.smethod_0(1), string_1.Length) == string_1)) ? true : false))
							{
								break;
							}
							enum14_0 = (Enum14)Class84.smethod_0(0);
							while (true)
							{
								int num2 = Class84.smethod_0(9);
								while (true)
								{
									switch (num2 ^ Class84.smethod_0(407))
									{
									case 110:
										int_3 += string_1.Length;
										num2 = Class84.smethod_0(6);
										continue;
									case 109:
										num2 = 3;
										continue;
									case 108:
										class39_0 = Delegate512.smethod_0(this, (Enum9)Class84.smethod_0(1));
										num2 = 1;
										continue;
									case 107:
										class39_0.int_1 = int_1 + string_1.Length - class39_0.int_0;
										num2 = 4;
										continue;
									case 106:
										int_1 += string_1.Length;
										num2 = 0;
										continue;
									case 111:
										goto end_IL_02b2;
									}
									break;
								}
								continue;
								end_IL_02b2:
								break;
							}
							Delegate522.smethod_0(this);
							break;
						}
						end_IL_0059:
						break;
					}
					goto end_IL_009f;
					continue;
					end_IL_0075:
					break;
				}
				continue;
				end_IL_009f:
				break;
			}
		}
		class39_0.int_1 = int_1 - class39_0.int_0;
	}

	private void method_24()
	{
		Delegate523.smethod_0(class39_0, int_2);
		while (true)
		{
			int num = Class49.smethod_0(84);
			while (true)
			{
				switch (num ^ Class84.smethod_0(408))
				{
				case -107:
					class39_0.int_3 = int_3;
					num = -30;
					continue;
				case -108:
					class39_0.int_1 = Class84.smethod_0(0);
					num = Class49.smethod_0(94);
					continue;
				case -109:
					num = -29;
					continue;
				case -110:
					class39_0.int_0 = int_1 - Class84.smethod_0(1);
					num = -28;
					continue;
				case -106:
					return;
				}
				break;
			}
		}
	}
}
