using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class31 : IDisposable
{
	public BinaryReader binaryReader_0;

	private Module module_0;

	private string[] string_0;

	private Class19[] class19_0;

	private Class12[] class12_0;

	private string[] string_1;

	static Class31()
	{
	}

	public Class31(Stream stream_0)
	{
		module_0 = typeof(Class31).Assembly.GetModules()[0];
		int num;
		while (true)
		{
			switch (Class41.smethod_0(92))
			{
			default:
				continue;
			case 0:
				binaryReader_0 = new BinaryReader(stream_0, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true));
				num = 1;
				break;
			case 1:
				break;
			case 2:
				return;
			}
			break;
		}
		method_9();
		num = 2;
	}

	~Class31()
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

	public Class18 method_1(int int_0)
	{
		long offset = int_0 ^ 0x497188;
		Class18 @class = default(Class18);
		int num3 = default(int);
		int num2 = default(int);
		Class33[] array = default(Class33[]);
		int num6 = default(int);
		while (true)
		{
			int num = Class41.smethod_0(81);
			while (true)
			{
				switch (num)
				{
				case 8:
					@class = new Class18(method_16(method_15()));
					num = 7;
					goto case 7;
				case 7:
					method_4(@class);
					num = 5;
					goto case 5;
				case 5:
					@class.int_0 = method_15();
					num = 2;
					goto case 2;
				case 2:
					@class.enum10_0 = (Enum10)binaryReader_0.ReadUInt16();
					num = 0;
					goto case 0;
				case 0:
					num3 = method_15();
					num = 1;
					goto case 1;
				case 1:
					@class.class19_4 = new Class19[num3];
					num = 3;
					goto IL_0069;
				case 3:
					goto IL_0069;
				case 4:
					binaryReader_0.BaseStream.Seek(offset, SeekOrigin.Begin);
					num = 8;
					goto case 8;
				case 6:
					if (num2 == 0)
					{
						goto IL_00e0;
					}
					num = 9;
					goto case 9;
				case 10:
					num2++;
					goto IL_00e0;
				case 9:
					{
						@class.class19_4[num2] = method_8();
						num = 10;
						goto case 10;
					}
					IL_00e0:
					if (num2 >= num3)
					{
						int num4 = method_15();
						while (true)
						{
							int num5 = Class41.smethod_0(81);
							while (true)
							{
								switch (num5)
								{
								case 4:
									array = new Class33[num4];
									num5 = 1;
									goto case 1;
								case 1:
									if (num4 > 0)
									{
										goto IL_0112;
									}
									goto IL_0175;
								case 2:
									num6 = 0;
									num5 = 0;
									goto case 0;
								case 0:
									if (num6 == 0)
									{
										goto IL_015a;
									}
									num5 = 3;
									goto case 3;
								case 5:
									num6++;
									goto IL_015a;
								case 3:
									{
										array[num6] = method_6(@class.Boolean_2);
										num5 = 5;
										goto case 5;
									}
									IL_0175:
									@class.class33_0 = array;
									while (true)
									{
										switch (Class41.smethod_0(79))
										{
										default:
											continue;
										case 1:
										{
											@class.long_0 = binaryReader_0.BaseStream.Position;
											int num7 = 0;
											goto case 0;
										}
										case 0:
										{
											@class.class31_0 = this;
											int num7 = 2;
											break;
										}
										case 2:
											break;
										}
										break;
									}
									return @class;
									IL_015a:
									if (num6 < num4)
									{
										goto case 3;
									}
									goto IL_0175;
								}
								break;
								IL_0112:
								num5 = Class41.smethod_0(82);
							}
						}
					}
					goto case 9;
				}
				break;
				IL_0069:
				num2 = 0;
				num = Class41.smethod_0(93);
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

	private Class17 method_3()
	{
		Class17 @class = new Class17(method_16(method_15()));
		method_4(@class);
		return @class;
	}

	private void method_4(Class17 class17_0)
	{
		class17_0.class19_0 = method_8();
		while (true)
		{
			int num = Class41.smethod_0(79);
			while (true)
			{
				switch (num)
				{
				case 3:
					class17_0.class19_1 = method_5();
					num = 2;
					goto case 2;
				case 2:
					if (class17_0.Boolean_1)
					{
						goto IL_0024;
					}
					if (true)
					{
						return;
					}
					goto case 4;
				case 1:
					class17_0.class19_3 = method_8();
					num = 0;
					goto case 0;
				case 0:
					class17_0.enum9_0 = (Enum9)binaryReader_0.ReadByte();
					num = 3;
					goto case 3;
				case 4:
					class17_0.class19_2 = method_5();
					return;
				}
				break;
				IL_0024:
				num = Class41.smethod_0(81);
			}
		}
	}

	private Class19[] method_5()
	{
		int num = method_15();
		Class19[] array = default(Class19[]);
		int num3 = default(int);
		while (true)
		{
			switch (Class41.smethod_0(82))
			{
			case 2:
			{
				array = new Class19[num];
				int num2 = 1;
				goto case 1;
			}
			case 1:
			{
				num3 = 0;
				int num2 = 0;
				goto case 0;
			}
			case 0:
			{
				if (num3 == 0)
				{
					goto IL_0046;
				}
				int num2 = 3;
				goto case 3;
			}
			case 4:
				num3++;
				goto IL_0046;
			case 3:
				{
					array[num3] = method_8();
					int num2 = 4;
					goto case 4;
				}
				IL_0046:
				if (num3 >= num)
				{
					return array;
				}
				goto case 3;
			}
		}
	}

	private Class33 method_6(bool bool_0)
	{
		return new Class33
		{
			enum12_0 = (Enum12)binaryReader_0.ReadByte(),
			int_2 = method_15(),
			int_3 = method_15(),
			int_0 = method_15(),
			int_1 = method_15(),
			int_4 = method_15(),
			class19_0 = method_8()
		};
	}

	private int[] method_7()
	{
		int num = method_15();
		int[] array = default(int[]);
		long num3 = default(long);
		while (true)
		{
			switch (Class41.smethod_0(92))
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

	private Class19 method_8()
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
		long long_3 = default(long);
		long long_2 = default(long);
		long long_4 = default(long);
		while (true)
		{
			int num = Class41.smethod_0(93);
			while (true)
			{
				switch (num)
				{
				case 6:
					long_3 = binaryReader_0.ReadInt32();
					num = 2;
					goto case 2;
				case 2:
					long_2 = binaryReader_0.ReadInt32();
					num = 4;
					goto case 4;
				case 4:
					long_4 = binaryReader_0.ReadInt32();
					num = 0;
					goto IL_008b;
				case 0:
					goto IL_008b;
				case 3:
					method_11(long_2);
					num = 1;
					goto case 1;
				case 1:
					method_12(long_3);
					num = 5;
					goto case 5;
				case 5:
					method_13(long_);
					num = 7;
					goto case 7;
				case 7:
					return true;
				}
				break;
				IL_008b:
				method_10(long_4);
				num = Class41.smethod_0(78);
			}
		}
	}

	private void method_10(long long_0)
	{
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (Class41.smethod_0(78))
			{
			case 3:
			{
				num = method_15();
				int num2 = 2;
				goto case 2;
			}
			case 2:
			{
				string_0 = new string[num];
				int num2 = 4;
				goto case 4;
			}
			case 4:
			{
				num3 = 0;
				int num2 = 0;
				goto case 0;
			}
			case 0:
			{
				if (num3 == 0)
				{
					goto IL_0064;
				}
				int num2 = 1;
				goto case 1;
			}
			case 5:
				num3++;
				goto IL_0064;
			case 1:
				{
					string_0[num3] = binaryReader_0.ReadString();
					int num2 = 5;
					goto case 5;
				}
				IL_0064:
				if (num3 >= num)
				{
					return;
				}
				goto case 1;
			}
		}
	}

	private void method_11(long long_0)
	{
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (Class41.smethod_0(79))
			{
			case 1:
			{
				num = method_15();
				int num2 = 0;
				goto case 0;
			}
			case 0:
			{
				class12_0 = new Class12[num];
				int num2 = 2;
				goto case 2;
			}
			case 2:
			{
				num3 = 0;
				int num2 = 4;
				goto case 4;
			}
			case 4:
			{
				if (num3 == 0)
				{
					goto IL_0064;
				}
				int num2 = 3;
				goto case 3;
			}
			case 5:
				num3++;
				goto IL_0064;
			case 3:
				{
					class12_0[num3] = new Class12(method_16(method_15()));
					int num2 = 5;
					goto case 5;
				}
				IL_0064:
				if (num3 >= num)
				{
					return;
				}
				goto case 3;
			}
		}
	}

	private void method_12(long long_0)
	{
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		int num3 = default(int);
		int num2 = default(int);
		Class19 @class = default(Class19);
		Enum13 enum13_ = default(Enum13);
		Dictionary<Class21, ArrayList> dictionary = default(Dictionary<Class21, ArrayList>);
		while (true)
		{
			int num = Class12.smethod_0(87);
			while (true)
			{
				switch (num)
				{
				case 8:
					num3 = method_15();
					num = 6;
					goto case 6;
				case 6:
					class19_0 = new Class19[num3 + 1];
					num = 1;
					goto IL_0030;
				case 1:
					goto IL_0030;
				case 0:
					num2 = 1;
					num = 3;
					goto case 3;
				case 3:
					if (num2 != 0)
					{
						goto IL_008a;
					}
					num = 5;
					goto case 5;
				case 9:
					num2++;
					goto IL_008a;
				case 2:
					@class = method_14(enum13_, num2, dictionary);
					num = 4;
					goto case 4;
				case 4:
					@class.int_0 = num2;
					num = 7;
					goto case 7;
				case 7:
					class19_0[num2] = @class;
					num = 9;
					goto case 9;
				case 5:
					{
						enum13_ = (Enum13)binaryReader_0.ReadByte();
						num = 2;
						goto case 2;
					}
					IL_008a:
					if (num2 > num3)
					{
						using (Dictionary<Class21, ArrayList>.Enumerator enumerator = dictionary.GetEnumerator())
						{
							while (enumerator.MoveNext() ? true : false)
							{
								KeyValuePair<Class21, ArrayList> current = enumerator.Current;
								IEnumerator enumerator2 = current.Value.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext() ? true : false)
									{
										KeyValuePair<int, int> keyValuePair = (KeyValuePair<int, int>)enumerator2.Current;
										current.Key.class19_2[keyValuePair.Key] = method_18(keyValuePair.Value);
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
					}
					goto case 5;
				}
				break;
				IL_0030:
				dictionary = new Dictionary<Class21, ArrayList>();
				num = Class41.smethod_0(92);
			}
		}
	}

	private void method_13(long long_0)
	{
		binaryReader_0.BaseStream.Seek(long_0, SeekOrigin.Begin);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			int num = Class41.smethod_0(82);
			while (true)
			{
				switch (num)
				{
				case 5:
					goto IL_0015;
				case 3:
					string_1 = new string[num3];
					num = 5;
					goto IL_0015;
				case 2:
					num3 = method_15();
					num = 1;
					goto case 1;
				case 1:
					if (num3 > 0)
					{
						num = 3;
						goto case 3;
					}
					return;
				case 0:
					if (num2 == 0)
					{
						goto IL_0079;
					}
					num = 4;
					goto case 4;
				case 6:
					num2++;
					goto IL_0079;
				case 4:
					{
						string_1[num2] = method_16(method_15());
						num = 6;
						goto case 6;
					}
					IL_0079:
					if (num2 >= num3)
					{
						return;
					}
					goto case 4;
				}
				break;
				IL_0015:
				num2 = 0;
				num = Class41.smethod_0(92);
			}
		}
	}

	private Class19 method_14(Enum13 enum13_0, int int_0, IDictionary<Class21, ArrayList> idictionary_0)
	{
		switch (enum13_0)
		{
		default:
			throw new InvalidOperationException(Class35.smethod_0("\ue8ba\ue8b9\ue8ba\ue8bd\ue8b4\ue8f8\ue8b5\ue8ed", 59608));
		case Enum13.const_0:
			return new Class19(method_16(method_15()))
			{
				Class12_0 = method_17(method_15()),
				class19_0 = method_18(method_15())
			};
		case Enum13.const_1:
		{
			Class21 @class = new Class21(method_18(method_15()));
			int num2 = default(int);
			Class19[] array = default(Class19[]);
			int num3 = default(int);
			int num4 = default(int);
			ArrayList arrayList = default(ArrayList);
			while (true)
			{
				int num = Class41.smethod_0(92);
				while (true)
				{
					switch (num)
					{
					case 3:
						goto IL_0079;
					case 0:
						num2 = method_15();
						num = 3;
						goto IL_0079;
					case 7:
						if (num2 > 0)
						{
							num = 6;
							goto case 6;
						}
						goto IL_017b;
					case 6:
						array = new Class19[num2];
						num = 1;
						goto case 1;
					case 1:
						num3 = 0;
						num = 2;
						goto case 2;
					case 2:
						if (num3 == 0)
						{
							goto IL_00f9;
						}
						num = 5;
						goto case 5;
					case 9:
						num3++;
						goto IL_00f9;
					case 4:
						if (num4 < int_0)
						{
							num = 8;
							goto case 8;
						}
						arrayList.Add(new KeyValuePair<int, int>(num3, num4));
						goto case 9;
					case 8:
						array[num3] = method_18(num4);
						num = 9;
						goto case 9;
					case 5:
						{
							num4 = method_15();
							num = 4;
							goto case 4;
						}
						IL_00f9:
						if (num3 < num2)
						{
							goto case 5;
						}
						while (true)
						{
							switch (Class41.smethod_0(79))
							{
							default:
								continue;
							case 1:
							{
								@class.class19_2 = array;
								int num5 = 0;
								goto case 0;
							}
							case 0:
							{
								if (arrayList.Count <= 0)
								{
									break;
								}
								int num5 = 2;
								goto case 2;
							}
							case 2:
								idictionary_0.Add(@class, arrayList);
								break;
							}
							break;
						}
						goto IL_017b;
						IL_017b:
						return @class;
					}
					break;
					IL_0079:
					arrayList = new ArrayList();
					num = Class12.smethod_0(83);
				}
			}
		}
		case Enum13.const_2:
			return new Class22(method_18(method_15()));
		case Enum13.const_3:
			return new Class24(method_18(method_15()), method_15());
		case Enum13.const_4:
			return new Class23(method_18(method_15()));
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

	private Class12 method_17(int int_0)
	{
		return class12_0[int_0];
	}

	private Class19 method_18(int int_0)
	{
		return class19_0[int_0];
	}

	internal void method_19(Class18 class18_0, BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		binaryReader_0.BaseStream.Seek(class18_0.long_0, SeekOrigin.Begin);
		int num2 = default(int);
		Enum11 @enum = default(Enum11);
		int tokenFor = default(int);
		int num6 = default(int);
		int[] array2 = default(int[]);
		int value = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = Class41.smethod_0(81);
			while (true)
			{
				switch (num)
				{
				case 4:
					goto IL_001a;
				case 5:
					num2 = 0;
					num = 3;
					goto case 3;
				case 3:
					if (num2 == 0)
					{
						goto IL_006e;
					}
					num = 2;
					goto case 2;
				case 0:
					@enum = (Enum11)binaryReader_0.ReadByte();
					num = 1;
					goto case 1;
				case 1:
					switch (@enum)
					{
					case Enum11.const_0:
						binaryWriter_0.Write(binaryReader_0.ReadInt32());
						goto case Enum11.const_5;
					case Enum11.const_1:
						method_23(binaryWriter_0, dynamicILInfo_0);
						goto case Enum11.const_5;
					case Enum11.const_2:
						binaryWriter_0.Write(binaryReader_0.ReadInt32());
						goto case Enum11.const_5;
					case Enum11.const_3:
						binaryWriter_0.Write(binaryReader_0.ReadInt64());
						goto case Enum11.const_5;
					case Enum11.const_4:
						method_21(method_3(), binaryWriter_0, dynamicILInfo_0);
						goto case Enum11.const_5;
					case Enum11.const_6:
						binaryWriter_0.Write(binaryReader_0.ReadDouble());
						goto case Enum11.const_5;
					case Enum11.const_7:
						method_22(binaryWriter_0, dynamicILInfo_0);
						goto case Enum11.const_5;
					case Enum11.const_8:
					{
						string literal = method_16(method_15());
						while (true)
						{
							switch (Class41.smethod_0(79))
							{
							default:
								continue;
							case 1:
							{
								tokenFor = dynamicILInfo_0.GetTokenFor(literal);
								int num7 = 0;
								goto case 0;
							}
							case 0:
							{
								binaryWriter_0.Write(tokenFor);
								int num7 = 2;
								break;
							}
							case 2:
								break;
							}
							break;
						}
						goto case Enum11.const_5;
					}
					case Enum11.const_9:
					{
						int[] array = method_7();
						while (true)
						{
							int num5 = Class41.smethod_0(82);
							while (true)
							{
								switch (num5)
								{
								case 4:
									num6 = 0;
									num5 = Class41.smethod_0(94);
									continue;
								case 2:
									binaryWriter_0.Write((uint)array.Length);
									num5 = 1;
									goto case 1;
								case 1:
									array2 = array;
									num5 = 4;
									goto case 4;
								case 5:
									if (num6 == 0)
									{
										goto IL_020f;
									}
									num5 = 0;
									goto case 0;
								case 6:
									num6++;
									goto IL_020f;
								case 3:
									binaryWriter_0.Write(value);
									num5 = 6;
									goto case 6;
								case 0:
									{
										value = array2[num6];
										num5 = 3;
										goto case 3;
									}
									IL_020f:
									if (num6 >= array2.Length)
									{
										goto end_IL_01f5;
									}
									goto case 0;
								}
								break;
							}
							continue;
							end_IL_01f5:
							break;
						}
						goto case Enum11.const_5;
					}
					case Enum11.const_10:
						method_20(binaryWriter_0, dynamicILInfo_0);
						goto case Enum11.const_5;
					case Enum11.const_11:
					{
						Type type = Class34.smethod_0(method_8());
						binaryWriter_0.Write(dynamicILInfo_0.GetTokenFor(type.TypeHandle));
						goto case Enum11.const_5;
					}
					case Enum11.const_12:
						binaryWriter_0.Write(binaryReader_0.ReadInt16());
						goto case Enum11.const_5;
					case Enum11.const_13:
						binaryWriter_0.Write(binaryReader_0.ReadByte());
						goto case Enum11.const_5;
					case Enum11.const_14:
					{
						sbyte b = binaryReader_0.ReadSByte();
						while (true)
						{
							switch (Class41.smethod_0(79))
							{
							default:
								continue;
							case 1:
								if (b < 0)
								{
									int num4 = 0;
									goto case 0;
								}
								binaryWriter_0.Write((byte)b);
								break;
							case 0:
							{
								binaryWriter_0.Write((byte)(256 + b));
								int num4 = 2;
								break;
							}
							case 2:
								break;
							}
							break;
						}
						goto case Enum11.const_5;
					}
					case Enum11.const_15:
						binaryWriter_0.Write(binaryReader_0.ReadSingle());
						goto case Enum11.const_5;
					case Enum11.const_16:
						binaryWriter_0.Write(binaryReader_0.ReadByte());
						goto case Enum11.const_5;
					case Enum11.const_5:
						num2++;
						goto IL_006e;
					}
					num = 6;
					goto case 6;
				case 2:
					kwBUTWDKLVgB(method_15(), binaryWriter_0);
					num = 0;
					goto case 0;
				case 6:
					{
						throw new InvalidOperationException(Class35.smethod_0("\uecc7\uecc4\uecc7\uecc0\uecc9\uec85\uecc8\uec93", 60581));
					}
					IL_006e:
					if (num2 >= num3)
					{
						return;
					}
					goto case 2;
				}
				break;
				IL_001a:
				num3 = method_15() ^ 0x35;
				num = Class41.smethod_0(94);
			}
		}
	}

	private void method_20(BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		switch (binaryReader_0.ReadByte())
		{
		default:
			throw new NotSupportedException(Class35.smethod_0("\ue5dd\ue5de\ue5dd\ue5da\ue5d3\ue59f\ue5d2\ue588", 58815));
		case 0:
		{
			Type type = Class34.smethod_0(method_8());
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

	private void method_21(Class17 class17_0, BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		Type[] types = Class34.smethod_1(class17_0.class19_1);
		BindingFlags bindingAttr = ((class17_0.Boolean_0 ? true : false) ? BindingFlags.Instance : BindingFlags.Static) | BindingFlags.NonPublic | BindingFlags.Public;
		if (!(class17_0.String_0 == Class35.smethod_0("\uf681\uf6cc\uf6db\uf6c0\uf6dd", 63151)) && 0 == 0 && ((!(class17_0.String_0 == Class35.smethod_0("\uf76f\uf722\uf722\uf735\uf72e\uf733", 63297))) ? true : false))
		{
			Class19 @class = class17_0.class19_0;
			Type type_ = default(Type);
			MethodInfo methodInfo = default(MethodInfo);
			Type[] array = default(Type[]);
			while (true)
			{
				int num = Class41.smethod_0(92);
				while (true)
				{
					switch (num)
					{
					case 1:
						goto IL_0079;
					case 0:
						type_ = Class34.smethod_0(class17_0.class19_3);
						num = 1;
						goto IL_0079;
					case 2:
						if (@class.String_0 == Class35.smethod_0("\uf33b\uf34a\uf368\uf363\uf372\uf36b\uf362\uf339", 62215))
						{
							num = 3;
						}
						else if (true)
						{
							Type type = Class34.smethod_0(@class);
							if (class17_0.Boolean_1 || 1 == 0)
							{
								while (true)
								{
									int num2 = Class41.smethod_0(79);
									while (true)
									{
										switch (num2)
										{
										case 2:
											methodInfo = type.GetMethod(class17_0.String_0, bindingAttr, new Class32(type_, array), types, null);
											num2 = Class41.smethod_0(92);
											continue;
										case 1:
											array = Class34.smethod_1(class17_0.class19_2);
											num2 = 2;
											goto case 2;
										case 0:
											if (methodInfo.IsGenericMethodDefinition)
											{
												num2 = 3;
											}
											else if (true)
											{
												goto end_IL_01a1;
											}
											goto case 3;
										case 3:
											methodInfo = methodInfo.MakeGenericMethod(array);
											goto end_IL_01a1;
										}
										break;
									}
									continue;
									end_IL_01a1:
									break;
								}
							}
							else
							{
								methodInfo = type.GetMethod(class17_0.String_0, bindingAttr, new Class32(type_), types, null);
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
							switch (Class41.smethod_0(92))
							{
							default:
								continue;
							case 0:
								methodInfo = module_0.GetMethod(class17_0.String_0, bindingAttr, new Class32(type_), CallingConventions.Standard, types, null);
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
					IL_0079:
					methodInfo = null;
					num = Class41.smethod_0(82);
				}
			}
		}
		Class19 class2 = class17_0.class19_0;
		Type type2 = Class34.smethod_0(class2);
		ConstructorInfo constructor = type2.GetConstructor(bindingAttr, null, types, null);
		int value2 = ((class2.Boolean_2 ? true : false) ? dynamicILInfo_0.GetTokenFor(constructor.MethodHandle, type2.TypeHandle) : dynamicILInfo_0.GetTokenFor(constructor.MethodHandle));
		binaryWriter_0.Write(value2);
	}

	private void method_22(BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		Class19[] array = method_5();
		Class19 @class = method_8();
		Type[] array2 = Class34.smethod_1(array);
		SignatureHelper signatureHelper = SignatureHelper.GetMethodSigHelper(returnType: Class34.smethod_0(@class), unmanagedCallingConvention: (CallingConvention)binaryReader_0.ReadByte());
		Type[] array3 = array2;
		int num = default(int);
		Type clsArgument = default(Type);
		while (true)
		{
			switch (Class41.smethod_0(78))
			{
			case 3:
			{
				num = 0;
				int num2 = 0;
				goto case 0;
			}
			case 0:
			{
				if (num == 0)
				{
					goto IL_006a;
				}
				int num2 = 1;
				goto case 1;
			}
			case 4:
				num++;
				goto IL_006a;
			case 2:
			{
				signatureHelper.AddArgument(clsArgument);
				int num2 = 4;
				goto case 4;
			}
			case 1:
				{
					clsArgument = array3[num];
					int num2 = 2;
					goto case 2;
				}
				IL_006a:
				if (num >= array3.Length)
				{
					binaryWriter_0.Write(dynamicILInfo_0.GetTokenFor(signatureHelper.GetSignature()));
					return;
				}
				goto case 1;
			}
		}
	}

	private void method_23(BinaryWriter binaryWriter_0, DynamicILInfo dynamicILInfo_0)
	{
		int int_ = method_15();
		BindingFlags bindingAttr = default(BindingFlags);
		Class16 @class = default(Class16);
		while (true)
		{
			int num = Class41.smethod_0(78);
			while (true)
			{
				FieldInfo fieldInfo;
				int tokenFor;
				switch (num)
				{
				case 4:
					fieldInfo = null;
					num = 1;
					goto case 1;
				case 1:
					bindingAttr = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
					num = 2;
					goto case 2;
				case 2:
					if (@class.class19_0.String_0 == Class35.smethod_0("\ue88c\ue8fd\ue8df\ue8d4\ue8c5\ue8dc\ue8d5\ue88e", 59568))
					{
						goto IL_0035;
					}
					if (1 == 0)
					{
						goto case 5;
					}
					fieldInfo = Class34.smethod_0(@class.class19_0).GetField(@class.String_0, bindingAttr);
					goto IL_00be;
				case 3:
					@class = new Class16(method_16(int_));
					num = 0;
					goto case 0;
				case 0:
					@class.class19_0 = method_8();
					num = 4;
					goto case 4;
				case 5:
					{
						fieldInfo = module_0.GetField(@class.String_0, bindingAttr);
						goto IL_00be;
					}
					IL_00be:
					tokenFor = dynamicILInfo_0.GetTokenFor(fieldInfo.FieldHandle);
					binaryWriter_0.Write(tokenFor);
					return;
				}
				break;
				IL_0035:
				num = Class41.smethod_0(94);
			}
		}
	}

	internal static void kwBUTWDKLVgB(int value, BinaryWriter writer)
	{
		switch (value)
		{
		case 0:
			writer.Write((byte)31);
			break;
		case 1:
			writer.Write((byte)114);
			break;
		case 2:
			writer.Write((byte)40);
			break;
		case 3:
			writer.Write((byte)19);
			break;
		case 4:
			writer.Write((byte)43);
			break;
		case 5:
			writer.Write((byte)56);
			break;
		case 6:
			writer.Write((byte)111);
			break;
		case 7:
			writer.Write((byte)11);
			break;
		case 8:
			writer.Write((byte)37);
			break;
		case 9:
			writer.Write((byte)17);
			break;
		case 10:
			writer.Write((byte)42);
			break;
		case 11:
			writer.Write((byte)22);
			break;
		case 12:
			writer.Write((byte)23);
			break;
		case 13:
			writer.Write((byte)2);
			break;
		case 14:
			writer.Write((byte)221);
			break;
		case 15:
			writer.Write((byte)0);
			break;
		case 16:
			writer.Write((byte)32);
			break;
		case 17:
			writer.Write((byte)38);
			break;
		case 18:
			writer.Write((byte)44);
			break;
		case 19:
			writer.Write((byte)12);
			break;
		case 20:
			writer.Write((byte)10);
			break;
		case 21:
			writer.Write((byte)222);
			break;
		case 22:
			writer.Write((byte)97);
			break;
		case 23:
			writer.Write((byte)208);
			break;
		case 24:
			writer.Write((byte)69);
			break;
		case 25:
			writer.Write((byte)13);
			break;
		case 26:
			writer.Write((byte)45);
			break;
		case 27:
			writer.Write((byte)7);
			break;
		case 28:
			writer.Write((byte)6);
			break;
		case 29:
			writer.Write((byte)126);
			break;
		case 30:
			writer.Write((byte)8);
			break;
		case 31:
			writer.Write((byte)3);
			break;
		case 32:
			writer.Write((byte)123);
			break;
		case 33:
			writer.Write((byte)88);
			break;
		case 34:
			writer.Write((byte)9);
			break;
		case 35:
			writer.Write((byte)89);
			break;
		case 36:
			writer.Write((byte)24);
			break;
		case 37:
			writer.Write((byte)125);
			break;
		case 38:
			writer.Write((byte)106);
			break;
		case 39:
			writer.Write((byte)115);
			break;
		case 40:
			writer.Write((byte)116);
			break;
		case 41:
			writer.Write((byte)25);
			break;
		case 42:
			writer.Write((byte)162);
			break;
		case 43:
			writer.Write((byte)28);
			break;
		case 44:
			writer.Write((byte)26);
			break;
		case 45:
			writer.Write((byte)18);
			break;
		case 46:
			writer.Write((byte)35);
			break;
		case 47:
			writer.Write((byte)27);
			break;
		case 48:
			writer.Write((byte)140);
			break;
		case 49:
			writer.Write((byte)58);
			break;
		case 50:
			writer.Write((byte)29);
			break;
		case 51:
			writer.Write((byte)30);
			break;
		case 52:
			writer.Write((byte)220);
			break;
		case 53:
			writer.Write((byte)141);
			break;
		case 54:
			writer.Write((byte)21);
			break;
		case 55:
			writer.Write((byte)128);
			break;
		case 56:
			writer.Write((byte)20);
			break;
		case 57:
			writer.Write((byte)154);
			break;
		case 58:
			writer.Write((byte)254);
			writer.Write((byte)1);
			break;
		case 59:
			writer.Write((byte)49);
			break;
		case 60:
			writer.Write((byte)254);
			writer.Write((byte)19);
			break;
		case 61:
			writer.Write((byte)145);
			break;
		case 62:
			writer.Write((byte)57);
			break;
		case 63:
			writer.Write((byte)142);
			break;
		case 64:
			writer.Write((byte)105);
			break;
		case 65:
			writer.Write((byte)156);
			break;
		case 66:
			writer.Write((byte)46);
			break;
		case 67:
			writer.Write((byte)4);
			break;
		case 68:
			writer.Write((byte)254);
			writer.Write((byte)11);
			break;
		case 69:
			writer.Write((byte)254);
			writer.Write((byte)6);
			break;
		case 70:
			writer.Write((byte)34);
			break;
		case 71:
			writer.Write((byte)218);
			break;
		case 72:
			writer.Write((byte)51);
			break;
		case 73:
			writer.Write((byte)214);
			break;
		case 74:
			writer.Write((byte)62);
			break;
		case 75:
			writer.Write((byte)122);
			break;
		case 76:
			writer.Write((byte)47);
			break;
		case 77:
			writer.Write((byte)5);
			break;
		case 78:
			writer.Write((byte)254);
			writer.Write((byte)3);
			break;
		case 79:
			writer.Write((byte)93);
			break;
		case 80:
			writer.Write((byte)254);
			writer.Write((byte)4);
			break;
		case 81:
			writer.Write((byte)64);
			break;
		case 82:
			writer.Write((byte)63);
			break;
		case 83:
			writer.Write((byte)50);
			break;
		case 84:
			writer.Write((byte)95);
			break;
		case 85:
			writer.Write((byte)124);
			break;
		case 86:
			writer.Write((byte)59);
			break;
		case 87:
			writer.Write((byte)254);
			writer.Write((byte)21);
			break;
		case 88:
			writer.Write((byte)117);
			break;
		case 89:
			writer.Write((byte)254);
			writer.Write((byte)26);
			break;
		}
	}
}
