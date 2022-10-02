using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class29 : IDisposable
{
	public BinaryReader binaryReader_0;

	private Module module_0;

	private string[] string_0;

	private Class17[] class17_0;

	private Class10[] class10_0;

	private string[] string_1;

	static Class29()
	{
	}

	public Class29(Stream stream_0)
	{
		module_0 = typeof(Class29).Assembly.GetModules()[0];
		int num;
		while (true)
		{
			switch (Class13.smethod_4(38))
			{
			default:
				continue;
			case 1:
				binaryReader_0 = new BinaryReader(stream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true));
				num = 0;
				break;
			case 0:
				break;
			case 2:
				return;
			}
			break;
		}
		method_9();
		num = 2;
	}

	~Class29()
	{
		method_0(bool_0: false);
	}

	private void method_0(bool bool_0)
	{
		if (bool_0)
		{
			binaryReader_0.Close();
		}
	}

	public void Dispose()
	{
		method_0(bool_0: true);
		GC.SuppressFinalize(this);
	}

	public Class16 method_1(int int_0)
	{
		long offset = int_0 ^ 0x3E8B40;
		Class16 @class = default(Class16);
		int num2 = default(int);
		int num3 = default(int);
		Class31[] array = default(Class31[]);
		int num6 = default(int);
		while (true)
		{
			int num = Class13.smethod_4(34);
			while (true)
			{
				switch (num)
				{
				case 6:
					goto IL_000b;
				case 0:
					@class = new Class16(method_16(method_15()));
					num = 4;
					goto case 4;
				case 4:
					method_4(@class);
					num = 9;
					goto case 9;
				case 9:
					@class.int_0 = method_15();
					num = 7;
					goto case 7;
				case 7:
					@class.enum2_0 = (Enum2)binaryReader_0.ReadUInt16();
					num = 8;
					goto case 8;
				case 8:
					num2 = method_15();
					num = 3;
					goto case 3;
				case 3:
					@class.class17_4 = new Class17[num2];
					num = 2;
					goto case 2;
				case 2:
					num3 = 0;
					num = 1;
					goto case 1;
				case 1:
					if (num3 == 0)
					{
						goto IL_00d6;
					}
					num = 5;
					goto case 5;
				case 10:
					num3++;
					goto IL_00d6;
				case 5:
					{
						@class.class17_4[num3] = method_8();
						num = 10;
						goto case 10;
					}
					IL_00d6:
					if (num3 >= num2)
					{
						int num4 = method_15();
						while (true)
						{
							int num5 = Class13.smethod_4(38);
							while (true)
							{
								switch (num5)
								{
								case 4:
									goto IL_00f9;
								case 3:
									if (num4 > 0)
									{
										num5 = 4;
										goto IL_00f9;
									}
									goto IL_0171;
								case 1:
									array = new Class31[num4];
									num5 = 3;
									goto case 3;
								case 2:
									if (num6 == 0)
									{
										goto IL_0156;
									}
									num5 = 0;
									goto case 0;
								case 5:
									num6++;
									goto IL_0156;
								case 0:
									{
										array[num6] = method_6(@class.Boolean_2);
										num5 = 5;
										goto case 5;
									}
									IL_0171:
									@class.class31_0 = array;
									while (true)
									{
										switch (Class13.smethod_4(37))
										{
										default:
											continue;
										case 0:
										{
											@class.long_0 = binaryReader_0.BaseStream.Position;
											int num7 = 1;
											goto case 1;
										}
										case 1:
										{
											@class.class29_0 = this;
											int num7 = 2;
											break;
										}
										case 2:
											break;
										}
										break;
									}
									return @class;
									IL_0156:
									if (num6 < num4)
									{
										goto case 0;
									}
									goto IL_0171;
								}
								break;
								IL_00f9:
								num6 = 0;
								num5 = Class13.smethod_4(39);
							}
						}
					}
					goto case 5;
				}
				break;
				IL_000b:
				binaryReader_0.BaseStream.Seek(offset, SeekOrigin.Begin);
				num = Class13.smethod_4(37);
			}
		}
	}

	public string method_2(int int_0)
	{
		if (string_1 == null)
		{
			return string.Empty;
		}
		return string_1[int_0 - 1];
	}

	private Class15 method_3()
	{
		Class15 @class = new Class15(method_16(method_15()));
		method_4(@class);
		return @class;
	}

	private void method_4(Class15 class15_0)
	{
		class15_0.class17_0 = method_8();
		while (true)
		{
			int num = Class13.smethod_4(40);
			while (true)
			{
				switch (num)
				{
				case 3:
					class15_0.class17_3 = method_8();
					num = 1;
					goto IL_001c;
				case 1:
					goto IL_001c;
				case 0:
					class15_0.class17_1 = method_5();
					num = 2;
					goto case 2;
				case 2:
					if (class15_0.Boolean_1)
					{
						num = 4;
					}
					else if (true)
					{
						return;
					}
					goto case 4;
				case 4:
					class15_0.class17_2 = method_5();
					return;
				}
				break;
				IL_001c:
				class15_0.enum1_0 = (Enum1)binaryReader_0.ReadByte();
				num = Class13.smethod_4(37);
			}
		}
	}

	private Class17[] method_5()
	{
		int num = method_15();
		int num3 = default(int);
		Class17[] array = default(Class17[]);
		while (true)
		{
			int num2 = Class13.smethod_4(40);
			while (true)
			{
				switch (num2)
				{
				case 4:
					num3++;
					goto IL_000d;
				case 0:
					goto IL_0011;
				case 3:
					array = new Class17[num];
					num2 = 1;
					goto case 1;
				case 1:
					num3 = 0;
					num2 = 2;
					goto case 2;
				case 2:
					{
						if (num3 != 0)
						{
							num2 = 0;
							goto IL_0011;
						}
						goto IL_000d;
					}
					IL_000d:
					if (num3 < num)
					{
						goto IL_0011;
					}
					return array;
				}
				break;
				IL_0011:
				array[num3] = method_8();
				num2 = Class13.smethod_4(43);
			}
		}
	}

	private Class31 method_6(bool bool_0)
	{
		return new Class31
		{
			enum4_0 = (Enum4)binaryReader_0.ReadByte(),
			int_2 = method_15(),
			int_3 = method_15(),
			int_0 = method_15(),
			int_1 = method_15(),
			int_4 = method_15(),
			class17_0 = method_8()
		};
	}

	private int[] method_7()
	{
		int num = method_15();
		int[] array = default(int[]);
		long num3 = default(long);
		while (true)
		{
			switch (Class13.smethod_4(37))
			{
			default:
				continue;
			case 0:
			{
				array = new int[num];
				int num2 = 1;
				goto case 1;
			}
			case 1:
			{
				num3 = 0L;
				int num2 = 2;
				break;
			}
			case 2:
				break;
			}
			break;
		}
		for (; num3 < num; num3++)
		{
			array[num3] = binaryReader_0.ReadInt32();
		}
		return array;
	}

	private Class17 method_8()
	{
		return method_18(method_15());
	}

	private bool method_9()
	{
		if (binaryReader_0.BaseStream.Length < 20L)
		{
			return false;
		}
		binaryReader_0.BaseStream.Seek(-20L, SeekOrigin.End);
		if (binaryReader_0.ReadUInt32() != 16826042)
		{
			return false;
		}
		long long_ = binaryReader_0.ReadInt32();
		long long_2 = default(long);
		long long_3 = default(long);
		long long_4 = default(long);
		while (true)
		{
			int num = Class13.smethod_4(39);
			while (true)
			{
				switch (num)
				{
				case 2:
					goto IL_005b;
				case 6:
					long_2 = binaryReader_0.ReadInt32();
					num = 5;
					goto case 5;
				case 5:
					long_3 = binaryReader_0.ReadInt32();
					num = 3;
					goto case 3;
				case 3:
					method_10(long_3);
					num = 1;
					goto case 1;
				case 1:
					method_11(long_2);
					num = 4;
					goto case 4;
				case 4:
					method_12(long_4);
					num = 0;
					goto case 0;
				case 0:
					method_13(long_);
					num = 7;
					goto case 7;
				case 7:
					return true;
				}
				break;
				IL_005b:
				long_4 = binaryReader_0.ReadInt32();
				num = Class13.smethod_4(34);
			}
		}
	}

	private void method_10(long long_0)
	{
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			int num = Class13.smethod_4(39);
			while (true)
			{
				switch (num)
				{
				case 4:
					goto IL_0015;
				case 2:
					num3 = method_15();
					num = 4;
					goto IL_0015;
				case 3:
					num2 = 0;
					num = 0;
					goto case 0;
				case 0:
					if (num2 == 0)
					{
						goto IL_006d;
					}
					num = 1;
					goto case 1;
				case 5:
					num2++;
					goto IL_006d;
				case 1:
					{
						string_0[num2] = binaryReader_0.ReadString();
						num = 5;
						goto case 5;
					}
					IL_006d:
					if (num2 >= num3)
					{
						return;
					}
					goto case 1;
				}
				break;
				IL_0015:
				string_0 = new string[num3];
				num = Class13.smethod_4(40);
			}
		}
	}

	private void method_11(long long_0)
	{
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			int num = Class13.smethod_4(40);
			while (true)
			{
				switch (num)
				{
				case 3:
					num3 = method_15();
					num = 0;
					goto IL_001e;
				case 0:
					goto IL_001e;
				case 4:
					num2 = 0;
					num = 2;
					goto case 2;
				case 2:
					if (num2 == 0)
					{
						goto IL_0069;
					}
					num = 1;
					goto case 1;
				case 5:
					num2++;
					goto IL_0069;
				case 1:
					{
						class10_0[num2] = new Class10(method_16(method_15()));
						num = 5;
						goto case 5;
					}
					IL_0069:
					if (num2 >= num3)
					{
						return;
					}
					goto case 1;
				}
				break;
				IL_001e:
				class10_0 = new Class10[num3];
				num = Class13.smethod_4(43);
			}
		}
	}

	private void method_12(long long_0)
	{
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		int num2 = default(int);
		Enum5 enum5_ = default(Enum5);
		Class17 @class = default(Class17);
		Dictionary<Class19, ArrayList> dictionary = default(Dictionary<Class19, ArrayList>);
		int num3 = default(int);
		while (true)
		{
			int num = Class11.smethod_1(35);
			while (true)
			{
				switch (num)
				{
				case 9:
					num2++;
					goto IL_001c;
				case 3:
					enum5_ = (Enum5)binaryReader_0.ReadByte();
					num = 1;
					goto case 1;
				case 1:
					@class = method_14(enum5_, num2, dictionary);
					num = 6;
					goto IL_0040;
				case 6:
					goto IL_0040;
				case 8:
					dictionary = new Dictionary<Class19, ArrayList>();
					num = 7;
					goto case 7;
				case 7:
					num2 = 1;
					num = 0;
					goto case 0;
				case 0:
					if (num2 != 0)
					{
						goto IL_001c;
					}
					num = 3;
					goto case 3;
				case 5:
					num3 = method_15();
					num = 2;
					goto case 2;
				case 2:
					class17_0 = new Class17[num3 + 1];
					num = 8;
					goto case 8;
				case 4:
					{
						class17_0[num2] = @class;
						num = 9;
						goto case 9;
					}
					IL_001c:
					if (num2 > num3)
					{
						using Dictionary<Class19, ArrayList>.Enumerator enumerator = dictionary.GetEnumerator();
						while (enumerator.MoveNext() ? true : false)
						{
							KeyValuePair<Class19, ArrayList> current = enumerator.Current;
							IEnumerator enumerator2 = current.Value.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext() ? true : false)
								{
									KeyValuePair<int, int> keyValuePair = (KeyValuePair<int, int>)enumerator2.Current;
									current.Key.class17_2[keyValuePair.Key] = method_18(keyValuePair.Value);
								}
							}
							finally
							{
								IDisposable disposable = enumerator2 as IDisposable;
								if (disposable != null || 1 == 0)
								{
									disposable.Dispose();
								}
							}
						}
						return;
					}
					goto case 3;
				}
				break;
				IL_0040:
				@class.int_0 = num2;
				num = Class13.smethod_4(43);
			}
		}
	}

	private void method_13(long long_0)
	{
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (Class13.smethod_4(38))
			{
			case 1:
			{
				num = method_15();
				int num2 = 0;
				goto case 0;
			}
			case 0:
				if (num > 0)
				{
					int num2 = 5;
					goto case 5;
				}
				return;
			case 5:
			{
				string_1 = new string[num];
				int num2 = 3;
				goto case 3;
			}
			case 3:
			{
				num3 = 0;
				int num2 = 4;
				goto case 4;
			}
			case 4:
			{
				if (num3 == 0)
				{
					goto IL_006e;
				}
				int num2 = 2;
				goto case 2;
			}
			case 6:
				num3++;
				goto IL_006e;
			case 2:
				{
					string_1[num3] = method_16(method_15());
					int num2 = 6;
					goto case 6;
				}
				IL_006e:
				if (num3 >= num)
				{
					return;
				}
				goto case 2;
			}
		}
	}

	private Class17 method_14(Enum5 enum5_0, int int_0, IDictionary<Class19, ArrayList> idictionary_0)
	{
		switch (enum5_0)
		{
		default:
			throw new InvalidOperationException(Class33.smethod_0("\uf020\uf023\uf020\uf027\uf02e\uf062\uf02f\uf077", 61506));
		case Enum5.const_0:
			return new Class17(method_16(method_15()))
			{
				Class10_0 = method_17(method_15()),
				class17_0 = method_18(method_15())
			};
		case Enum5.const_1:
		{
			Class19 @class = new Class19(method_18(method_15()));
			Class17[] array = default(Class17[]);
			int num2 = default(int);
			int num3 = default(int);
			ArrayList arrayList = default(ArrayList);
			int num5 = default(int);
			while (true)
			{
				int num = Class13.smethod_4(39);
				while (true)
				{
					switch (num)
					{
					case 8:
						array = new Class17[num2];
						num = 4;
						goto case 4;
					case 4:
						num3 = 0;
						num = 5;
						goto case 5;
					case 5:
						if (num3 != 0)
						{
							goto IL_008d;
						}
						goto IL_00f3;
					case 3:
						if (num2 > 0)
						{
							num = 8;
							goto case 8;
						}
						goto IL_0179;
					case 2:
						num2 = method_15();
						num = 1;
						goto case 1;
					case 1:
						arrayList = new ArrayList();
						num = 3;
						goto case 3;
					case 0:
						num5 = method_15();
						num = 6;
						goto case 6;
					case 6:
						if (num5 < int_0)
						{
							num = 7;
							goto case 7;
						}
						arrayList.Add(new KeyValuePair<int, int>(num3, num5));
						goto case 9;
					case 7:
						array[num3] = method_18(num5);
						num = 9;
						goto case 9;
					case 9:
						{
							num3++;
							goto IL_00f3;
						}
						IL_0179:
						return @class;
						IL_00f3:
						if (num3 < num2)
						{
							goto case 0;
						}
						@class.class17_2 = array;
						while (true)
						{
							switch (Class13.smethod_4(38))
							{
							default:
								continue;
							case 1:
							{
								if (arrayList.Count <= 0)
								{
									break;
								}
								int num4 = 0;
								goto case 0;
							}
							case 0:
							{
								idictionary_0.Add(@class, arrayList);
								int num4 = 2;
								break;
							}
							case 2:
								break;
							}
							break;
						}
						goto IL_0179;
					}
					break;
					IL_008d:
					num = Class13.smethod_4(37);
				}
			}
		}
		case Enum5.const_2:
			return new Class20(method_18(method_15()));
		case Enum5.const_3:
			return new Class22(method_18(method_15()), method_15());
		case Enum5.const_4:
			return new Class21(method_18(method_15()));
		}
	}

	private int method_15()
	{
		byte b = binaryReader_0.ReadByte();
		if ((b & 0x80) == 0 && 0 == 0)
		{
			return b;
		}
		if ((b & 0x40) == 0 && 0 == 0)
		{
			return ((b & 0x3F) << 8) + binaryReader_0.ReadByte();
		}
		return ((b & 0x3F) << 24) + (binaryReader_0.ReadByte() << 16) + (binaryReader_0.ReadByte() << 8) + binaryReader_0.ReadByte();
	}

	private string method_16(int int_0)
	{
		return string_0[int_0];
	}

	private Class10 method_17(int int_0)
	{
		return class10_0[int_0];
	}

	private Class17 method_18(int int_0)
	{
		return class17_0[int_0];
	}

	internal void method_19(Class16 class16_0, BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		binaryReader_0.BaseStream.Seek(class16_0.long_0, SeekOrigin.Begin);
		int num3 = default(int);
		int num2 = default(int);
		Enum3 @enum = default(Enum3);
		int num6 = default(int);
		int value = default(int);
		int[] array2 = default(int[]);
		int tokenFor = default(int);
		while (true)
		{
			int num = Class13.smethod_4(39);
			while (true)
			{
				switch (num)
				{
				case 2:
					num3 = method_15() ^ 0x10;
					num = 0;
					goto IL_002a;
				case 0:
					goto IL_002a;
				case 4:
					if (num2 == 0)
					{
						goto IL_00d2;
					}
					num = 3;
					goto case 3;
				case 5:
					switch (@enum)
					{
					case Enum3.const_16:
						binaryWriter_0.Write(binaryReader_0.ReadByte());
						goto case Enum3.const_5;
					case Enum3.const_5:
						num2++;
						goto IL_00d2;
					case Enum3.const_15:
						binaryWriter_0.Write(binaryReader_0.ReadSingle());
						goto case Enum3.const_5;
					case Enum3.const_14:
					{
						sbyte b = binaryReader_0.ReadSByte();
						while (true)
						{
							switch (Class13.smethod_4(37))
							{
							case 2:
								break;
							default:
								continue;
							case 0:
								if (b < 0)
								{
									int num7 = 1;
									goto case 1;
								}
								binaryWriter_0.Write((byte)b);
								break;
							case 1:
							{
								binaryWriter_0.Write((byte)(256 + b));
								int num7 = 2;
								break;
							}
							}
							break;
						}
						goto case Enum3.const_5;
					}
					case Enum3.const_13:
						binaryWriter_0.Write(binaryReader_0.ReadByte());
						goto case Enum3.const_5;
					case Enum3.const_12:
						binaryWriter_0.Write(binaryReader_0.ReadInt16());
						goto case Enum3.const_5;
					case Enum3.const_11:
					{
						Type type = Class32.smethod_0(method_8());
						binaryWriter_0.Write(dynamicILInfo_0.GetTokenFor(type.TypeHandle));
						goto case Enum3.const_5;
					}
					case Enum3.const_10:
						method_20(binaryWriter_0, dynamicILInfo_0);
						goto case Enum3.const_5;
					case Enum3.const_9:
					{
						int[] array = method_7();
						while (true)
						{
							int num5 = Class11.smethod_1(35);
							while (true)
							{
								switch (num5)
								{
								case 6:
									num6++;
									goto IL_01ca;
								case 0:
									value = array2[num6];
									num5 = Class13.smethod_4(40);
									continue;
								case 5:
									binaryWriter_0.Write((uint)array.Length);
									num5 = 2;
									goto case 2;
								case 2:
									array2 = array;
									num5 = 4;
									goto case 4;
								case 4:
									num6 = 0;
									num5 = 1;
									goto case 1;
								case 1:
									if (num6 == 0)
									{
										goto IL_01ca;
									}
									num5 = 0;
									goto case 0;
								case 3:
									{
										binaryWriter_0.Write(value);
										num5 = 6;
										goto case 6;
									}
									IL_01ca:
									if (num6 >= array2.Length)
									{
										goto end_IL_023a;
									}
									goto case 0;
								}
								break;
							}
							continue;
							end_IL_023a:
							break;
						}
						goto case Enum3.const_5;
					}
					case Enum3.const_8:
					{
						string literal = method_16(method_15());
						while (true)
						{
							switch (Class13.smethod_4(37))
							{
							case 2:
								break;
							default:
								continue;
							case 0:
							{
								tokenFor = dynamicILInfo_0.GetTokenFor(literal);
								int num4 = 1;
								goto case 1;
							}
							case 1:
							{
								binaryWriter_0.Write(tokenFor);
								int num4 = 2;
								break;
							}
							}
							break;
						}
						goto case Enum3.const_5;
					}
					case Enum3.const_7:
						method_22(binaryWriter_0, dynamicILInfo_0);
						goto case Enum3.const_5;
					case Enum3.const_6:
						binaryWriter_0.Write(binaryReader_0.ReadDouble());
						goto case Enum3.const_5;
					case Enum3.const_4:
						method_21(method_3(), binaryWriter_0, dynamicILInfo_0);
						goto case Enum3.const_5;
					case Enum3.const_3:
						binaryWriter_0.Write(binaryReader_0.ReadInt64());
						goto case Enum3.const_5;
					case Enum3.const_2:
						binaryWriter_0.Write(binaryReader_0.ReadInt32());
						goto case Enum3.const_5;
					case Enum3.const_1:
						method_23(binaryWriter_0, dynamicILInfo_0);
						goto case Enum3.const_5;
					case Enum3.const_0:
						binaryWriter_0.Write(binaryReader_0.ReadInt32());
						goto case Enum3.const_5;
					}
					num = 6;
					goto case 6;
				case 1:
					@enum = (Enum3)binaryReader_0.ReadByte();
					num = 5;
					goto case 5;
				case 3:
					UNnlsNIflINU(method_15(), binaryWriter_0);
					num = 1;
					goto case 1;
				case 6:
					{
						throw new InvalidOperationException(Class33.smethod_0("\ue8db\ue8d8\ue8db\ue8dc\ue8d5\ue899\ue8d4\ue88f", 59577));
					}
					IL_00d2:
					if (num2 >= num3)
					{
						return;
					}
					goto case 3;
				}
				break;
				IL_002a:
				num2 = 0;
				num = Class13.smethod_4(43);
			}
		}
	}

	private void method_20(BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		switch (binaryReader_0.ReadByte())
		{
		default:
			throw new NotSupportedException(Class33.smethod_0("\ueb3c\ueb3f\ueb3c\ueb3b\ueb32\ueb7e\ueb33\ueb69", 60254));
		case 0:
		{
			Type type = Class32.smethod_0(method_8());
			binaryWriter_0.Write(dynamicILInfo_0.GetTokenFor(type.TypeHandle));
			break;
		}
		case 1:
			method_23(binaryWriter_0, dynamicILInfo_0);
			break;
		case 2:
			method_21(method_3(), binaryWriter_0, dynamicILInfo_0);
			break;
		}
	}

	private void method_21(Class15 class15_0, BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		Type[] types = Class32.smethod_1(class15_0.class17_1);
		BindingFlags bindingAttr = ((class15_0.Boolean_0 ? true : false) ? BindingFlags.Instance : BindingFlags.Static) | BindingFlags.NonPublic | BindingFlags.Public;
		if (!(class15_0.String_0 == Class33.smethod_0("\ue6c7\ue68a\ue69d\ue686\ue69b", 59113)) && 0 == 0 && ((!(class15_0.String_0 == Class33.smethod_0("\uf2bc\uf2f1\uf2f1\uf2e6\uf2fd\uf2e0", 62098))) ? true : false))
		{
			Class17 @class = class15_0.class17_0;
			Type type_ = default(Type);
			MethodInfo methodInfo = default(MethodInfo);
			Type[] array = default(Type[]);
			while (true)
			{
				int num = Class13.smethod_4(39);
				while (true)
				{
					switch (num)
					{
					case 2:
						type_ = Class32.smethod_0(class15_0.class17_3);
						num = 1;
						goto case 1;
					case 1:
						methodInfo = null;
						num = 0;
						goto case 0;
					case 0:
						if (@class.String_0 == Class33.smethod_0("\uf191\uf1e0\uf1c2\uf1c9\uf1d8\uf1c1\uf1c8\uf193", 61869))
						{
							goto IL_00ac;
						}
						if (true)
						{
							Type type = Class32.smethod_0(@class);
							if (class15_0.Boolean_1 || 1 == 0)
							{
								while (true)
								{
									int num2 = Class13.smethod_4(39);
									while (true)
									{
										switch (num2)
										{
										case 2:
											array = Class32.smethod_1(class15_0.class17_2);
											num2 = 1;
											goto case 1;
										case 1:
											methodInfo = type.GetMethod(class15_0.String_0, bindingAttr, new Class30(type_, array), types, null);
											num2 = Class13.smethod_4(37);
											continue;
										case 0:
											if (methodInfo.IsGenericMethodDefinition)
											{
												num2 = 3;
											}
											else if (true)
											{
												goto end_IL_0197;
											}
											goto case 3;
										case 3:
											methodInfo = methodInfo.MakeGenericMethod(array);
											goto end_IL_0197;
										}
										break;
									}
									continue;
									end_IL_0197:
									break;
								}
							}
							else
							{
								methodInfo = type.GetMethod(class15_0.String_0, bindingAttr, new Class30(type_), types, null);
							}
							int value = ((@class.Boolean_2 ? true : false) ? dynamicILInfo_0.GetTokenFor(methodInfo.MethodHandle, type.TypeHandle) : dynamicILInfo_0.GetTokenFor(methodInfo.MethodHandle));
							binaryWriter_0.Write(value);
							return;
						}
						goto case 3;
					case 3:
					{
						int num3;
						while (true)
						{
							switch (Class13.smethod_4(37))
							{
							default:
								continue;
							case 0:
								methodInfo = module_0.GetMethod(class15_0.String_0, bindingAttr, new Class30(type_), CallingConventions.Standard, types, null);
								num3 = 1;
								break;
							case 1:
								break;
							case 2:
								return;
							}
							break;
						}
						binaryWriter_0.Write(dynamicILInfo_0.GetTokenFor(methodInfo.MethodHandle));
						num3 = 2;
						return;
					}
					}
					break;
					IL_00ac:
					num = Class13.smethod_4(40);
				}
			}
		}
		Class17 class2 = class15_0.class17_0;
		Type type2 = Class32.smethod_0(class2);
		ConstructorInfo constructor = type2.GetConstructor(bindingAttr, null, types, null);
		int value2 = ((class2.Boolean_2 ? true : false) ? dynamicILInfo_0.GetTokenFor(constructor.MethodHandle, type2.TypeHandle) : dynamicILInfo_0.GetTokenFor(constructor.MethodHandle));
		binaryWriter_0.Write(value2);
	}

	private void method_22(BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		Class17[] array = method_5();
		Class17 @class = method_8();
		Type[] array2 = Class32.smethod_1(array);
		SignatureHelper signatureHelper = SignatureHelper.GetMethodSigHelper(returnType: Class32.smethod_0(@class), unmanagedCallingConvention: (CallingConvention)binaryReader_0.ReadByte());
		Type[] array3 = array2;
		int num2 = default(int);
		Type clsArgument = default(Type);
		while (true)
		{
			int num = Class13.smethod_4(37);
			while (true)
			{
				switch (num)
				{
				case 0:
					goto IL_002e;
				case 3:
					if (num2 == 0)
					{
						goto IL_006f;
					}
					num = 2;
					goto case 2;
				case 4:
					num2++;
					goto IL_006f;
				case 1:
					signatureHelper.AddArgument(clsArgument);
					num = 4;
					goto case 4;
				case 2:
					{
						clsArgument = array3[num2];
						num = 1;
						goto case 1;
					}
					IL_006f:
					if (num2 >= array3.Length)
					{
						binaryWriter_0.Write(dynamicILInfo_0.GetTokenFor(signatureHelper.GetSignature()));
						return;
					}
					goto case 2;
				}
				break;
				IL_002e:
				num2 = 0;
				num = Class13.smethod_4(40);
			}
		}
	}

	private void method_23(BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		int int_ = method_15();
		Class14 @class = default(Class14);
		BindingFlags bindingAttr = default(BindingFlags);
		while (true)
		{
			int num = Class13.smethod_4(40);
			while (true)
			{
				FieldInfo fieldInfo;
				int tokenFor;
				switch (num)
				{
				case 3:
					goto IL_0009;
				case 0:
					@class.class17_0 = method_8();
					num = 4;
					goto case 4;
				case 4:
					fieldInfo = null;
					num = 2;
					goto case 2;
				case 2:
					bindingAttr = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
					num = 1;
					goto case 1;
				case 1:
					if (@class.class17_0.String_0 == Class33.smethod_0("\uf191\uf1e0\uf1c2\uf1c9\uf1d8\uf1c1\uf1c8\uf193", 61869))
					{
						num = 5;
					}
					else if (true)
					{
						fieldInfo = Class32.smethod_0(@class.class17_0).GetField(@class.String_0, bindingAttr);
						goto IL_00bc;
					}
					goto case 5;
				case 5:
					{
						fieldInfo = module_0.GetField(@class.String_0, bindingAttr);
						goto IL_00bc;
					}
					IL_00bc:
					tokenFor = dynamicILInfo_0.GetTokenFor(fieldInfo.FieldHandle);
					binaryWriter_0.Write(tokenFor);
					return;
				}
				break;
				IL_0009:
				@class = new Class14(method_16(int_));
				num = Class13.smethod_4(37);
			}
		}
	}

	internal static void UNnlsNIflINU(int value, BinaryWriter writer)
	{
		switch (value)
		{
		case 0:
			writer.Write((byte)40);
			break;
		case 1:
			writer.Write((byte)19);
			break;
		case 2:
			writer.Write((byte)31);
			break;
		case 3:
			writer.Write((byte)43);
			break;
		case 4:
			writer.Write((byte)56);
			break;
		case 5:
			writer.Write((byte)0);
			break;
		case 6:
			writer.Write((byte)17);
			break;
		case 7:
			writer.Write((byte)23);
			break;
		case 8:
			writer.Write((byte)22);
			break;
		case 9:
			writer.Write((byte)38);
			break;
		case 10:
			writer.Write((byte)97);
			break;
		case 11:
			writer.Write((byte)111);
			break;
		case 12:
			writer.Write((byte)208);
			break;
		case 13:
			writer.Write((byte)11);
			break;
		case 14:
			writer.Write((byte)69);
			break;
		case 15:
			writer.Write((byte)7);
			break;
		case 16:
			writer.Write((byte)106);
			break;
		case 17:
			writer.Write((byte)89);
			break;
		case 18:
			writer.Write((byte)6);
			break;
		case 19:
			writer.Write((byte)37);
			break;
		case 20:
			writer.Write((byte)2);
			break;
		case 21:
			writer.Write((byte)9);
			break;
		case 22:
			writer.Write((byte)10);
			break;
		case 23:
			writer.Write((byte)42);
			break;
		case 24:
			writer.Write((byte)88);
			break;
		case 25:
			writer.Write((byte)154);
			break;
		case 26:
			writer.Write((byte)24);
			break;
		case 27:
			writer.Write((byte)13);
			break;
		case 28:
			writer.Write((byte)18);
			break;
		case 29:
			writer.Write((byte)222);
			break;
		case 30:
			writer.Write((byte)162);
			break;
		case 31:
			writer.Write((byte)218);
			break;
		case 32:
			writer.Write((byte)25);
			break;
		case 33:
			writer.Write((byte)3);
			break;
		case 34:
			writer.Write((byte)214);
			break;
		case 35:
			writer.Write((byte)12);
			break;
		case 36:
			writer.Write((byte)115);
			break;
		case 37:
			writer.Write((byte)21);
			break;
		case 38:
			writer.Write((byte)126);
			break;
		case 39:
			writer.Write((byte)140);
			break;
		case 40:
			writer.Write((byte)142);
			break;
		case 41:
			writer.Write((byte)105);
			break;
		case 42:
			writer.Write((byte)49);
			break;
		case 43:
			writer.Write((byte)114);
			break;
		case 44:
			writer.Write((byte)141);
			break;
		case 45:
			writer.Write((byte)145);
			break;
		case 46:
			writer.Write((byte)8);
			break;
		case 47:
			writer.Write((byte)58);
			break;
		case 48:
			writer.Write((byte)57);
			break;
		case 49:
			writer.Write((byte)29);
			break;
		case 50:
			writer.Write((byte)28);
			break;
		case 51:
			writer.Write((byte)254);
			writer.Write((byte)1);
			break;
		case 52:
			writer.Write((byte)44);
			break;
		case 53:
			writer.Write((byte)45);
			break;
		case 54:
			writer.Write((byte)26);
			break;
		case 55:
			writer.Write((byte)221);
			break;
		case 56:
			writer.Write((byte)93);
			break;
		case 57:
			writer.Write((byte)156);
			break;
		case 58:
			writer.Write((byte)96);
			break;
		case 59:
			writer.Write((byte)254);
			writer.Write((byte)6);
			break;
		case 60:
			writer.Write((byte)128);
			break;
		case 61:
			writer.Write((byte)27);
			break;
		case 62:
			writer.Write((byte)20);
			break;
		case 63:
			writer.Write((byte)4);
			break;
		case 64:
			writer.Write((byte)30);
			break;
		}
	}
}
