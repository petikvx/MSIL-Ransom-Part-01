using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

internal sealed class Class38
{
	private Module module_0;

	private Type type_0;

	private Type[] type_1;

	public Type Type_0 => type_0;

	public Type[] Type_1 => type_1;

	public Class38(Module module_1)
	{
		module_0 = module_1;
	}

	internal DynamicMethod method_0(Class41 class41_0)
	{
		Type type = Class57.smethod_0(class41_0.class42_0);
		Type[] array = default(Type[]);
		SignatureHelper localVarSigHelper = default(SignatureHelper);
		int num3 = default(int);
		Type clsArgument = default(Type);
		DynamicILInfo dynamicILInfo = default(DynamicILInfo);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] exceptions = default(byte[]);
		while (true)
		{
			int num = Class64.smethod_0(92);
			while (true)
			{
				switch (num)
				{
				case 3:
					goto IL_000e;
				case 0:
					type_0 = Class57.smethod_0(class41_0.class42_3);
					num = 3;
					goto IL_000e;
				case 1:
					type_1 = array;
					num = 2;
					goto case 2;
				case 2:
					if (class41_0.Boolean_4)
					{
						num = 4;
					}
					else if (0 == 0)
					{
						array = new Type[type_1.Length + 1];
						array[0] = type;
						if (type_1.Length != 0 || 1 == 0)
						{
							Array.Copy(type_1, 0, array, 1, type_1.Length);
						}
					}
					goto case 4;
				case 4:
				{
					DynamicMethod dynamicMethod = method_1(class41_0.String_0, type_0, array, type);
					while (true)
					{
						int num2 = Class64.smethod_0(81);
						while (true)
						{
							switch (num2)
							{
							case 4:
								dynamicMethod.InitLocals = class41_0.Boolean_3;
								num2 = 2;
								goto IL_00dd;
							case 2:
								goto IL_00dd;
							case 1:
								localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
								num2 = 3;
								goto case 3;
							case 3:
								num3 = 0;
								num2 = 0;
								goto case 0;
							case 0:
								if (num3 == 0)
								{
									goto IL_013e;
								}
								num2 = 6;
								goto case 6;
							case 7:
								num3++;
								goto IL_013e;
							case 5:
								localVarSigHelper.AddArgument(clsArgument);
								num2 = 7;
								goto case 7;
							case 6:
								{
									clsArgument = Class57.smethod_0(class41_0.class42_4[num3]);
									num2 = 5;
									goto case 5;
								}
								IL_013e:
								if (num3 >= class41_0.class42_4.Length)
								{
									byte[] signature = localVarSigHelper.GetSignature();
									while (true)
									{
										switch (Class64.smethod_0(92))
										{
										default:
											continue;
										case 0:
										{
											dynamicILInfo.SetLocalSignature(signature);
											int num4 = 1;
											goto case 1;
										}
										case 1:
										{
											memoryStream = new MemoryStream();
											int num4 = 2;
											break;
										}
										case 2:
											break;
										}
										break;
									}
									BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
									try
									{
										class41_0.class54_0.method_19(class41_0, binaryWriter, dynamicILInfo);
										if (class41_0.class56_0.Length != 0 || 1 == 0)
										{
											memoryStream.Position += 3L;
											while (true)
											{
												switch (Class64.smethod_0(92))
												{
												default:
													continue;
												case 0:
												{
													memoryStream.Position &= -4L;
													int num5 = 1;
													goto case 1;
												}
												case 1:
												{
													exceptions = smethod_0(dynamicILInfo, class41_0.class56_0, class41_0.Boolean_2);
													int num5 = 2;
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
										dynamicILInfo.SetCode(code, class41_0.int_0);
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
								goto case 6;
							}
							break;
							IL_00dd:
							dynamicILInfo = dynamicMethod.GetDynamicILInfo();
							num2 = Class64.smethod_0(79);
						}
					}
				}
				}
				break;
				IL_000e:
				array = Class57.smethod_1(class41_0.class42_1);
				num = Class64.smethod_0(79);
			}
		}
	}

	private static byte[] smethod_0(DynamicILInfo dynamicILInfo_0, Class56[] class56_0, bool bool_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		try
		{
			Class56[] array = default(Class56[]);
			int num2 = default(int);
			if (class56_0.Length < 21 && (!bool_0 || 1 == 0))
			{
				binaryWriter.Write((byte)1);
				Class56 class56_ = default(Class56);
				while (true)
				{
					int num = Class64.smethod_0(94);
					while (true)
					{
						switch (num)
						{
						case 5:
							binaryWriter.Write((byte)(class56_0.Length * 12 + 2));
							num = 3;
							goto case 3;
						case 3:
							binaryWriter.Write(new byte[2]);
							num = 0;
							goto case 0;
						case 0:
							array = class56_0;
							num = Class64.smethod_0(81);
							continue;
						case 4:
							num2 = 0;
							num = 2;
							goto case 2;
						case 2:
							if (num2 == 0)
							{
								goto IL_009b;
							}
							num = 1;
							goto case 1;
						case 7:
							num2++;
							goto IL_009b;
						case 6:
							smethod_1(dynamicILInfo_0, binaryWriter, class56_);
							num = 7;
							goto case 7;
						case 1:
							{
								class56_ = array[num2];
								num = 6;
								goto case 6;
							}
							IL_009b:
							if (num2 >= array.Length)
							{
								goto end_IL_007f;
							}
							goto case 1;
						}
						break;
					}
					continue;
					end_IL_007f:
					break;
				}
			}
			else
			{
				binaryWriter.Write((byte)65);
				int num4 = default(int);
				Class56 class56_2 = default(Class56);
				while (true)
				{
					int num3 = Class64.smethod_0(78);
					while (true)
					{
						switch (num3)
						{
						case 3:
							num4 = class56_0.Length * 24 + 4;
							num3 = 0;
							goto case 0;
						case 0:
							binaryWriter.Write((byte)((uint)num4 & 0xFFu));
							num3 = Class64.smethod_0(79);
							continue;
						case 1:
							binaryWriter.Write((byte)((uint)(num4 >> 8) & 0xFFu));
							num3 = 4;
							goto case 4;
						case 4:
							binaryWriter.Write((byte)((uint)(num4 >> 16) & 0xFFu));
							num3 = 5;
							goto case 5;
						case 5:
							array = class56_0;
							num3 = 6;
							goto case 6;
						case 6:
							num2 = 0;
							num3 = 2;
							goto case 2;
						case 2:
							if (num2 == 0)
							{
								goto IL_0166;
							}
							num3 = 7;
							goto case 7;
						case 9:
							num2++;
							goto IL_0166;
						case 8:
							smethod_2(dynamicILInfo_0, binaryWriter, class56_2);
							num3 = 9;
							goto case 9;
						case 7:
							{
								class56_2 = array[num2];
								num3 = 8;
								goto case 8;
							}
							IL_0166:
							if (num2 >= array.Length)
							{
								goto end_IL_011c;
							}
							goto case 7;
						}
						break;
					}
					continue;
					end_IL_011c:
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

	private static void smethod_1(DynamicILInfo dynamicILInfo_0, BinaryWriter binaryWriter_0, Class56 class56_0)
	{
		binaryWriter_0.Write((ushort)class56_0.enum15_0);
		while (true)
		{
			int num = Class64.smethod_0(79);
			while (true)
			{
				switch (num)
				{
				case 2:
					goto IL_000f;
				case 1:
					binaryWriter_0.Write((ushort)class56_0.int_0);
					num = 2;
					goto IL_000f;
				case 3:
					binaryWriter_0.Write((ushort)class56_0.int_2);
					num = 0;
					goto case 0;
				case 0:
					binaryWriter_0.Write((byte)class56_0.int_3);
					num = 4;
					goto case 4;
				case 4:
					smethod_3(dynamicILInfo_0, binaryWriter_0, class56_0);
					num = 5;
					return;
				case 5:
					return;
				}
				break;
				IL_000f:
				binaryWriter_0.Write((byte)class56_0.int_1);
				num = Class64.smethod_0(78);
			}
		}
	}

	private static void smethod_2(DynamicILInfo dynamicILInfo_0, BinaryWriter binaryWriter_0, Class56 class56_0)
	{
		binaryWriter_0.Write((uint)class56_0.enum15_0);
		while (true)
		{
			int num = Class64.smethod_0(79);
			while (true)
			{
				switch (num)
				{
				case 3:
					goto IL_000e;
				case 1:
					binaryWriter_0.Write((uint)class56_0.int_0);
					num = 3;
					goto IL_000e;
				case 4:
					binaryWriter_0.Write((uint)class56_0.int_2);
					num = 0;
					goto case 0;
				case 0:
					binaryWriter_0.Write((uint)class56_0.int_3);
					num = 2;
					goto case 2;
				case 2:
					smethod_3(dynamicILInfo_0, binaryWriter_0, class56_0);
					num = 5;
					return;
				case 5:
					return;
				}
				break;
				IL_000e:
				binaryWriter_0.Write((uint)class56_0.int_1);
				num = Class64.smethod_0(81);
			}
		}
	}

	private static void smethod_3(DynamicILInfo dynamicILInfo_0, BinaryWriter binaryWriter_0, Class56 class56_0)
	{
		Enum15 enum15_ = class56_0.enum15_0;
		if (enum15_ != 0 || 1 == 0)
		{
			if (enum15_ != Enum15.const_1)
			{
				binaryWriter_0.Write(0);
			}
			else
			{
				binaryWriter_0.Write((uint)class56_0.int_4);
			}
		}
		else
		{
			uint tokenFor = (uint)dynamicILInfo_0.GetTokenFor(Class57.smethod_0(class56_0.class42_0).TypeHandle);
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
}
