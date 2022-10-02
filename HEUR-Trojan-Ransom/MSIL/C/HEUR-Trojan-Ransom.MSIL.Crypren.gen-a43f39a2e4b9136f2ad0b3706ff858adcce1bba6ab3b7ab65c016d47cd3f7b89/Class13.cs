using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

internal sealed class Class13
{
	private Module module_0;

	private Type type_0;

	private Type[] type_1;

	public Type Type_0 => type_0;

	public Type[] Type_1 => type_1;

	public Class13(Module module_1)
	{
		module_0 = module_1;
	}

	internal DynamicMethod method_0(Class16 class16_0)
	{
		Type type = Class32.smethod_0(class16_0.class17_0);
		type_0 = Class32.smethod_0(class16_0.class17_3);
		Type[] array = (type_1 = Class32.smethod_1(class16_0.class17_1));
		if (!class16_0.Boolean_4 && 0 == 0)
		{
			while (true)
			{
				int num = smethod_4(38);
				while (true)
				{
					switch (num)
					{
					case 1:
						array = new Type[type_1.Length + 1];
						num = smethod_4(37);
						continue;
					case 0:
						array[0] = type;
						num = 2;
						goto case 2;
					case 2:
						if (type_1.Length != 0)
						{
							num = 3;
						}
						else if (true)
						{
							goto end_IL_0070;
						}
						goto case 3;
					case 3:
						Array.Copy(type_1, 0, array, 1, type_1.Length);
						goto end_IL_0070;
					}
					break;
				}
				continue;
				end_IL_0070:
				break;
			}
		}
		DynamicMethod dynamicMethod = method_1(class16_0.String_0, type_0, array, type);
		DynamicILInfo dynamicILInfo = default(DynamicILInfo);
		SignatureHelper localVarSigHelper = default(SignatureHelper);
		int num3 = default(int);
		Type clsArgument = default(Type);
		byte[] exceptions = default(byte[]);
		while (true)
		{
			switch (smethod_4(34))
			{
			case 6:
			{
				dynamicMethod.InitLocals = class16_0.Boolean_3;
				int num2 = 3;
				goto case 3;
			}
			case 3:
			{
				dynamicILInfo = dynamicMethod.GetDynamicILInfo();
				int num2 = 5;
				goto case 5;
			}
			case 5:
			{
				localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
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
					goto IL_012b;
				}
				int num2 = 2;
				goto case 2;
			}
			case 7:
				num3++;
				goto IL_012b;
			case 1:
			{
				localVarSigHelper.AddArgument(clsArgument);
				int num2 = 7;
				goto case 7;
			}
			case 2:
				{
					clsArgument = Class32.smethod_0(class16_0.class17_4[num3]);
					int num2 = 1;
					goto case 1;
				}
				IL_012b:
				if (num3 >= class16_0.class17_4.Length)
				{
					byte[] signature = localVarSigHelper.GetSignature();
					dynamicILInfo.SetLocalSignature(signature);
					MemoryStream memoryStream = new MemoryStream();
					BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
					try
					{
						class16_0.class29_0.method_19(class16_0, binaryWriter, dynamicILInfo);
						if (class16_0.class31_0.Length != 0 || 1 == 0)
						{
							memoryStream.Position += 3L;
							while (true)
							{
								switch (smethod_4(38))
								{
								default:
									continue;
								case 1:
								{
									memoryStream.Position &= -4L;
									int num4 = 0;
									goto case 0;
								}
								case 0:
								{
									exceptions = smethod_0(dynamicILInfo, class16_0.class31_0, class16_0.Boolean_2);
									int num4 = 2;
									break;
								}
								case 2:
									break;
								}
								break;
							}
							dynamicILInfo.SetExceptions(exceptions);
						}
						byte[] code = memoryStream.ToArray();
						dynamicILInfo.SetCode(code, class16_0.int_0);
						return dynamicMethod;
					}
					finally
					{
						if (binaryWriter != null || 1 == 0)
						{
							((IDisposable)binaryWriter).Dispose();
						}
					}
				}
				goto case 2;
			}
		}
	}

	private static byte[] smethod_0(DynamicILInfo dynamicILInfo_0, Class31[] class31_0, bool bool_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		try
		{
			Class31[] array = default(Class31[]);
			int num2 = default(int);
			if (class31_0.Length < 21 && (!bool_0 || 1 == 0))
			{
				binaryWriter.Write((byte)1);
				Class31 class31_ = default(Class31);
				while (true)
				{
					int num = smethod_4(39);
					while (true)
					{
						switch (num)
						{
						case 6:
							binaryWriter.Write(new byte[2]);
							num = 0;
							goto case 0;
						case 0:
							array = class31_0;
							num = smethod_4(38);
							continue;
						case 2:
							binaryWriter.Write((byte)(class31_0.Length * 12 + 2));
							num = 6;
							goto case 6;
						case 1:
							num2 = 0;
							num = 5;
							goto case 5;
						case 5:
							if (num2 == 0)
							{
								goto IL_009f;
							}
							num = 3;
							goto case 3;
						case 7:
							num2++;
							goto IL_009f;
						case 4:
							smethod_1(dynamicILInfo_0, binaryWriter, class31_);
							num = 7;
							goto case 7;
						case 3:
							{
								class31_ = array[num2];
								num = 4;
								goto case 4;
							}
							IL_009f:
							if (num2 >= array.Length)
							{
								goto end_IL_0083;
							}
							goto case 3;
						}
						break;
					}
					continue;
					end_IL_0083:
					break;
				}
			}
			else
			{
				binaryWriter.Write((byte)65);
				int num4 = default(int);
				Class31 class31_2 = default(Class31);
				while (true)
				{
					int num3 = smethod_4(36);
					while (true)
					{
						switch (num3)
						{
						case 8:
							num4 = class31_0.Length * 24 + 4;
							num3 = 5;
							goto case 5;
						case 5:
							binaryWriter.Write((byte)((uint)num4 & 0xFFu));
							num3 = 0;
							goto case 0;
						case 0:
							binaryWriter.Write((byte)((uint)(num4 >> 8) & 0xFFu));
							num3 = smethod_4(38);
							continue;
						case 1:
							binaryWriter.Write((byte)((uint)(num4 >> 16) & 0xFFu));
							num3 = 3;
							goto case 3;
						case 3:
							array = class31_0;
							num3 = 7;
							goto case 7;
						case 7:
							num2 = 0;
							num3 = 4;
							goto case 4;
						case 4:
							if (num2 == 0)
							{
								goto IL_016a;
							}
							num3 = 6;
							goto case 6;
						case 9:
							num2++;
							goto IL_016a;
						case 2:
							smethod_2(dynamicILInfo_0, binaryWriter, class31_2);
							num3 = 9;
							goto case 9;
						case 6:
							{
								class31_2 = array[num2];
								num3 = 2;
								goto case 2;
							}
							IL_016a:
							if (num2 >= array.Length)
							{
								goto end_IL_0134;
							}
							goto case 6;
						}
						break;
					}
					continue;
					end_IL_0134:
					break;
				}
			}
			return memoryStream.ToArray();
		}
		finally
		{
			if (binaryWriter != null || 1 == 0)
			{
				((IDisposable)binaryWriter).Dispose();
			}
		}
	}

	private static void smethod_1(DynamicILInfo dynamicILInfo_0, BinaryWriter binaryWriter_0, Class31 class31_0)
	{
		binaryWriter_0.Write((ushort)class31_0.enum4_0);
		while (true)
		{
			int num = smethod_4(43);
			while (true)
			{
				switch (num)
				{
				case 4:
					binaryWriter_0.Write((ushort)class31_0.int_0);
					num = 1;
					goto IL_001e;
				case 1:
					goto IL_001e;
				case 3:
					binaryWriter_0.Write((ushort)class31_0.int_2);
					num = 0;
					goto case 0;
				case 0:
					binaryWriter_0.Write((byte)class31_0.int_3);
					num = 2;
					goto case 2;
				case 2:
					smethod_3(dynamicILInfo_0, binaryWriter_0, class31_0);
					num = 5;
					return;
				case 5:
					return;
				}
				break;
				IL_001e:
				binaryWriter_0.Write((byte)class31_0.int_1);
				num = smethod_4(40);
			}
		}
	}

	private static void smethod_2(DynamicILInfo dynamicILInfo_0, BinaryWriter binaryWriter_0, Class31 class31_0)
	{
		binaryWriter_0.Write((uint)class31_0.enum4_0);
		int num;
		while (true)
		{
			switch (smethod_4(40))
			{
			default:
				continue;
			case 3:
				binaryWriter_0.Write((uint)class31_0.int_0);
				num = 2;
				goto case 2;
			case 2:
				binaryWriter_0.Write((uint)class31_0.int_1);
				num = 1;
				goto case 1;
			case 1:
				binaryWriter_0.Write((uint)class31_0.int_2);
				num = 4;
				goto case 4;
			case 4:
				binaryWriter_0.Write((uint)class31_0.int_3);
				num = 0;
				break;
			case 0:
				break;
			case 5:
				return;
			}
			break;
		}
		smethod_3(dynamicILInfo_0, binaryWriter_0, class31_0);
		num = 5;
	}

	private static void smethod_3(DynamicILInfo dynamicILInfo_0, BinaryWriter binaryWriter_0, Class31 class31_0)
	{
		Enum4 enum4_ = class31_0.enum4_0;
		if (enum4_ != 0 || 1 == 0)
		{
			if (enum4_ != Enum4.const_1)
			{
				binaryWriter_0.Write(0);
			}
			else
			{
				binaryWriter_0.Write((uint)class31_0.int_4);
			}
		}
		else
		{
			uint tokenFor = (uint)dynamicILInfo_0.GetTokenFor(Class32.smethod_0(class31_0.class17_0).TypeHandle);
			binaryWriter_0.Write(tokenFor);
		}
	}

	private DynamicMethod method_1(string string_0, Type type_2, Type[] type_3, Type type_4)
	{
		if ((object)type_4 == null && 0 == 0)
		{
			return new DynamicMethod(string_0, type_2, type_3, module_0, skipVisibility: true);
		}
		return new DynamicMethod(string_0, MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard, type_2, type_3, type_4, skipVisibility: false);
	}

	internal static int smethod_4(int int_0)
	{
		return int_0 switch
		{
			33 => 10, 
			34 => 6, 
			36 => 8, 
			37 => 0, 
			38 => 1, 
			39 => 2, 
			40 => 3, 
			42 => 13, 
			43 => 4, 
			_ => -1, 
		};
	}
}
