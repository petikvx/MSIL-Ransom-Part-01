using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using My;
using SmartAssembly.Attributes;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.Zip;

public class SimpleZip
{
	internal sealed class Class6
	{
		private static readonly int[] int_0;

		private static readonly int[] int_1;

		private static readonly int[] int_2;

		private static readonly int[] int_3;

		private Class7 class7_0;

		private Class8 class8_0;

		private Class10 class10_0;

		private Class9 class9_0;

		private Class9 class9_1;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal bool bool_0;

		public Class6(byte[] byte_0)
		{
			int num = default(int);
			try
			{
				try
				{
					class7_0 = new Class7();
					class8_0 = new Class8();
					num = 2;
					int_4 = 2;
					class7_0.method_7(byte_0, 0, byte_0.Length);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, byte_0);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, num, this, byte_0);
				throw;
			}
		}

		private bool method_0()
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			bool flag = default(bool);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			int num16 = default(int);
			int num17 = default(int);
			int num18 = default(int);
			try
			{
				try
				{
					num = 7;
					num2 = class8_0.method_4();
					num = 33;
					while (true)
					{
						if (num2 >= 258)
						{
							num = 12;
							num3 = int_4;
							switch (num3)
							{
							default:
								num = 11;
								num = 33;
								continue;
							case 7:
								num = 4;
								while (true)
								{
									if (((num4 = class9_0.method_1(class7_0)) & -256) == 0)
									{
										num = 2;
										class8_0.method_0(num4);
										if (--num2 >= 258)
										{
											num = 4;
											continue;
										}
										num = 16;
										flag = true;
										goto end_IL_0028;
									}
									num = 6;
									if (num4 >= 257)
									{
										num = 20;
										num5 = (int_6 = int_0[num4 - 257]);
										num = 24;
										num6 = (int_5 = int_1[num4 - 257]);
										num = 0;
										break;
									}
									num = 5;
									if (num4 < 0)
									{
										num = 22;
										flag = false;
										goto end_IL_0028;
									}
									num = 14;
									class9_1 = null;
									class9_0 = null;
									num7 = 2;
									int_4 = 2;
									num = 32;
									flag = true;
									goto end_IL_0028;
								}
								goto IL_00d7;
							case 8:
								num = 0;
								goto IL_00d7;
							case 9:
								num = 1;
								goto IL_0150;
							case 10:
								{
									num = 30;
									goto IL_0199;
								}
								IL_0199:
								if (int_5 > 0)
								{
									num = 31;
									num8 = 10;
									int_4 = 10;
									num9 = class7_0.method_0(int_5);
									num = 13;
									if (num9 < 0)
									{
										num = 15;
										flag = false;
										break;
									}
									num = 17;
									class7_0.method_1(int_5);
									num10 = (int_7 += num9);
									num = 26;
								}
								else
								{
									num = 26;
								}
								class8_0.method_2(int_6, int_7);
								num = 27;
								num2 -= int_6;
								num11 = 7;
								int_4 = 7;
								num = 33;
								continue;
								IL_00d7:
								if (int_5 > 0)
								{
									num = 34;
									num12 = 8;
									int_4 = 8;
									num13 = class7_0.method_0(int_5);
									num = 18;
									if (num13 < 0)
									{
										num = 28;
										flag = false;
										break;
									}
									num = 9;
									class7_0.method_1(int_5);
									num14 = (int_6 += num13);
									num = 19;
								}
								else
								{
									num = 19;
								}
								num15 = 9;
								int_4 = 9;
								num = 1;
								goto IL_0150;
								IL_0150:
								num4 = class9_1.method_1(class7_0);
								if (num4 >= 0)
								{
									num = 10;
									num16 = (int_7 = int_2[num4]);
									num17 = (int_5 = int_3[num4]);
									num = 30;
									goto IL_0199;
								}
								num = 21;
								flag = false;
								break;
								end_IL_0028:
								break;
							}
						}
						else
						{
							num = 3;
							flag = true;
						}
						break;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException6(exception, num2, num4, num13, num9, num3, this);
					throw;
				}
				num18 = 1;
				return flag;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[20]
				{
					num2, num4, num13, num9, num3, flag, num7, num5, num6, num12,
					num14, num15, num16, num17, num8, num10, num11, num, num18, this
				});
				throw;
			}
		}

		private bool method_1()
		{
			int num = default(int);
			int num2 = default(int);
			int num4 = default(int);
			bool flag = default(bool);
			int num5 = default(int);
			bool flag2 = default(bool);
			int num8 = default(int);
			int num7 = default(int);
			int num6 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num3 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			int num16 = default(int);
			try
			{
				try
				{
					num = 24;
					num2 = int_4;
					switch (num2)
					{
					default:
						num = 31;
						num = 22;
						goto IL_02c2;
					case 2:
						num = 21;
						if (bool_0)
						{
							num = 7;
							num4 = 12;
							int_4 = 12;
							flag = false;
							break;
						}
						num = 13;
						num5 = class7_0.method_0(3);
						if (num5 < 0)
						{
							num = 36;
							flag = false;
							break;
						}
						num = 5;
						class7_0.method_1(3);
						if (((uint)num5 & (true ? 1u : 0u)) != 0)
						{
							num = 35;
							flag2 = true;
							bool_0 = true;
							num = 25;
						}
						else
						{
							num = 25;
						}
						num2 = num5 >> 1;
						switch (num2)
						{
						default:
							num = 6;
							num = 15;
							break;
						case 0:
							num = 14;
							class7_0.method_4();
							num8 = 3;
							int_4 = 3;
							num = 15;
							break;
						case 1:
							num = 28;
							class9_0 = Class9.class9_0;
							class9_1 = Class9.class9_1;
							num7 = 7;
							int_4 = 7;
							num = 15;
							break;
						case 2:
							num = 20;
							class10_0 = new Class10();
							num6 = 6;
							int_4 = 6;
							num = 15;
							break;
						}
						flag = true;
						break;
					case 3:
						num = 2;
						num9 = (int_8 = (num2 = class7_0.method_0(16)));
						num = 26;
						if (num2 < 0)
						{
							num = 17;
							flag = false;
							break;
						}
						num = 9;
						class7_0.method_1(16);
						num10 = 4;
						int_4 = 4;
						num = 12;
						goto IL_019e;
					case 4:
						num = 12;
						goto IL_019e;
					case 5:
						num = 3;
						goto IL_01df;
					case 6:
						num = 32;
						if (!class10_0.method_0(class7_0))
						{
							num = 30;
							flag = false;
							break;
						}
						num = 4;
						class9_0 = class10_0.method_1();
						class9_1 = class10_0.method_2();
						num = 0;
						num3 = 7;
						int_4 = 7;
						num = 1;
						goto IL_02b4;
					case 7:
						num = 1;
						goto IL_02b4;
					case 8:
						num = 1;
						goto IL_02b4;
					case 9:
						num = 1;
						goto IL_02b4;
					case 10:
						num = 1;
						goto IL_02b4;
					case 11:
						num = 22;
						goto IL_02c2;
					case 12:
						{
							num = 11;
							flag = false;
							break;
						}
						IL_02b4:
						flag = method_0();
						break;
						IL_01df:
						num11 = class8_0.method_3(class7_0, int_8);
						num = 19;
						num12 = (int_8 -= num11);
						num = 33;
						if (int_8 == 0)
						{
							num = 34;
							num13 = 2;
							int_4 = 2;
							flag = true;
						}
						else
						{
							num = 29;
							flag = !class7_0.method_5();
						}
						break;
						IL_02c2:
						flag = false;
						break;
						IL_019e:
						num14 = class7_0.method_0(16);
						if (num14 < 0)
						{
							num = 10;
							flag = false;
							break;
						}
						num = 23;
						class7_0.method_1(16);
						num15 = 5;
						int_4 = 5;
						num = 3;
						goto IL_01df;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num5, num14, num11, num2, this);
					throw;
				}
				num16 = 1;
				return flag;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[19]
				{
					num5, num14, num11, num2, flag, num4, flag2, num8, num7, num6,
					num9, num10, num15, num12, num13, num3, num, num16, this
				});
				throw;
			}
		}

		public int method_2(byte[] byte_0, int int_9, int int_10)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			try
			{
				try
				{
					num = 5;
					num2 = 0;
					num = 1;
					while (true)
					{
						if (int_4 == 11)
						{
							num = 10;
						}
						else
						{
							num = 11;
							num3 = class8_0.method_6(byte_0, int_9, int_10);
							int_9 += num3;
							num = 7;
							num2 += num3;
							int_10 -= num3;
							if (int_10 == 0)
							{
								num = 12;
								num4 = num2;
								break;
							}
							num = 10;
						}
						if (!method_1())
						{
							num = 6;
							if (class8_0.method_5() > 0)
							{
								num = 2;
								if (int_4 != 11)
								{
									num = 1;
									continue;
								}
								num = 4;
							}
							else
							{
								num = 4;
							}
							num4 = num2;
							break;
						}
						num = 1;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException6(exception, num2, num3, this, byte_0, int_9, int_10);
					throw;
				}
				num5 = 2;
				return num4;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException9(exception2, num2, num3, num4, num, num5, this, byte_0, int_9, int_10);
				throw;
			}
		}

		static Class6()
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
				try
				{
					num = 0;
					int[] array_ = new int[29];
					UsageReportSender.smethod_10(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 367, 334);
					int_0 = array_;
					int[] array_2 = new int[29];
					UsageReportSender.smethod_10(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 459, 490);
					int_1 = array_2;
					num = 3;
					int[] array_3 = new int[30];
					UsageReportSender.smethod_10(array_3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 257, 288);
					int_2 = array_3;
					int_3 = new int[30]
					{
						0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
						4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
						9, 9, 10, 10, 11, 11, 12, 12, 13, 13
					};
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException0(exception);
					throw;
				}
				num2 = 3;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, num2);
				throw;
			}
		}
	}

	internal sealed class Class7
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public int method_0(int int_3)
		{
			int num = default(int);
			int num4 = default(int);
			int num3 = default(int);
			int num6 = default(int);
			uint num7 = default(uint);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			try
			{
				try
				{
					num = 9;
					if (int_2 >= int_3)
					{
						num = 4;
						goto IL_00aa;
					}
					num = 6;
					if (int_0 != int_1)
					{
						num = 1;
						uint num2 = uint_0;
						byte[] array = byte_0;
						num4 = (int_0 = (num3 = int_0) + 1);
						int num5 = array[num3] & 0xFF;
						byte[] array2 = byte_0;
						num6 = (int_0 = (num3 = int_0) + 1);
						num7 = (uint_0 = num2 | (uint)((num5 | ((array2[num3] & 0xFF) << 8)) << int_2));
						num = 0;
						num8 = (int_2 += 16);
						num = 4;
						goto IL_00aa;
					}
					num = 7;
					num9 = -1;
					goto end_IL_0000;
					IL_00aa:
					num9 = (int)(uint_0 & ((1 << int_3) - 1));
					end_IL_0000:;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num3, this, int_3);
					throw;
				}
				num10 = 0;
				return num9;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException10(exception2, num3, num9, num4, num6, num7, num8, num, num10, this, int_3);
				throw;
			}
		}

		public void method_1(int int_3)
		{
			int num = default(int);
			uint num2 = default(uint);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				try
				{
					num = 4;
					num2 = (uint_0 >>= int_3);
					num = 2;
					num3 = (int_2 -= int_3);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, int_3);
					throw;
				}
				num4 = 3;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException6(exception2, num2, num3, num, num4, this, int_3);
				throw;
			}
		}

		[SpecialName]
		public int method_2()
		{
			int num = default(int);
			try
			{
				try
				{
					num = int_2;
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		[SpecialName]
		public int method_3()
		{
			int num = default(int);
			try
			{
				try
				{
					num = int_1 - int_0 + (int_2 >> 3);
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		public void method_4()
		{
			int num = default(int);
			uint num2 = default(uint);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				try
				{
					num = 3;
					num2 = (uint_0 >>= int_2 & 7);
					num = 1;
					num3 = (int_2 &= -8);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
				num4 = 4;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException5(exception2, num2, num3, num, num4, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_5()
		{
			bool flag = default(bool);
			try
			{
				try
				{
					flag = int_0 == int_1;
					return flag;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, flag, this);
				throw;
			}
		}

		public int method_6(byte[] byte_1, int int_3, int int_4)
		{
			int num = default(int);
			int num2 = default(int);
			uint num3 = default(uint);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num9 = default(int);
			int num8 = default(int);
			uint num10 = default(uint);
			int num11 = default(int);
			int num12 = default(int);
			try
			{
				try
				{
					num = 18;
					num2 = 0;
					num = 14;
					while (true)
					{
						if (int_2 > 0)
						{
							num = 13;
							if (int_4 > 0)
							{
								num = 8;
								byte_1[int_3++] = (byte)uint_0;
								num = 4;
								num3 = (uint_0 >>= 8);
								num = 7;
								num4 = (int_2 -= 8);
								num = 0;
								int_4--;
								num2++;
								num = 14;
								continue;
							}
							num = 15;
							break;
						}
						num = 15;
						break;
					}
					if (int_4 == 0)
					{
						num = 11;
						num5 = num2;
					}
					else
					{
						num = 9;
						num6 = int_1 - int_0;
						num = 6;
						if (int_4 > num6)
						{
							num = 3;
							int_4 = num6;
							num = 1;
						}
						else
						{
							num = 1;
						}
						AppPathFinder.smethod_0(byte_0, int_0, byte_1, int_3, int_4, 719, 725);
						num = 5;
						num7 = (int_0 += int_4);
						num = 21;
						if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
						{
							num = 10;
							byte[] array = byte_0;
							num9 = (int_0 = (num8 = int_0) + 1);
							num10 = (uint_0 = array[num8] & 0xFFu);
							num = 16;
							num11 = 8;
							int_2 = 8;
							num = 12;
						}
						else
						{
							num = 12;
						}
						num5 = num2 + int_4;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException7(exception, num2, num6, num8, this, byte_1, int_3, int_4);
					throw;
				}
				num12 = 1;
				return num5;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[16]
				{
					num2, num6, num8, num5, num3, num4, num7, num9, num10, num11,
					num, num12, this, byte_1, int_3, int_4
				});
				throw;
			}
		}

		public Class7()
		{
			int num = 0;
			int_0 = 0;
			int num2 = 0;
			int_1 = 0;
			uint num3 = 0u;
			uint_0 = 0u;
			int num4 = 0;
			int_2 = 0;
			base._002Ector();
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, num2, num3, num4, this);
				throw;
			}
		}

		public void method_7(byte[] byte_1, int int_3, int int_4)
		{
			int num = default(int);
			int num2 = default(int);
			uint num3 = default(uint);
			int num4 = default(int);
			byte[] array = default(byte[]);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			try
			{
				try
				{
					num = 13;
					if (int_0 < int_1)
					{
						num = 5;
						throw new InvalidOperationException();
					}
					num = 10;
					num2 = int_3 + int_4;
					if (0 > int_3)
					{
						num = 6;
						goto IL_0097;
					}
					num = 1;
					if (int_3 > num2)
					{
						num = 6;
						goto IL_0097;
					}
					num = 8;
					if (num2 > byte_1.Length)
					{
						num = 6;
						goto IL_0097;
					}
					num = 3;
					if (((uint)int_4 & (true ? 1u : 0u)) != 0)
					{
						num = 9;
						num3 = (uint_0 |= (uint)((byte_1[int_3++] & 0xFF) << int_2));
						num = 12;
						num4 = (int_2 += 8);
						num = 14;
					}
					else
					{
						num = 14;
					}
					array = (byte_0 = byte_1);
					num5 = (int_0 = int_3);
					num = 2;
					num6 = (int_1 = num2);
					goto end_IL_0000;
					IL_0097:
					throw new ArgumentOutOfRangeException();
					end_IL_0000:;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num2, this, byte_1, int_3, int_4);
					throw;
				}
				num7 = 2;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[12]
				{
					num2, num3, num4, array, num5, num6, num, num7, this, byte_1,
					int_3, int_4
				});
				throw;
			}
		}

		static Class7()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}

		internal static Assembly smethod_0(int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_4 ^ int_3)
					{
					case 71:
						return Assembly.GetCallingAssembly();
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, int_3, int_4);
				throw;
			}
		}

		internal static string smethod_1(ref long long_0, string string_0, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_4 ^ int_3)
					{
					case 28:
						return long_0.ToString(string_0);
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, long_0, string_0, int_3, int_4);
				throw;
			}
		}

		internal static int smethod_2(ref Rectangle rectangle_0, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_4 ^ int_3)
					{
					case 56:
						return rectangle_0.Left;
					}
					num = 4;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, rectangle_0, int_3, int_4);
				throw;
			}
		}

		internal static int smethod_3(ref Size size_0, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_4 ^ int_3)
					{
					case 6:
						return size_0.Width;
					}
					num = 3;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, size_0, int_3, int_4);
				throw;
			}
		}
	}

	internal sealed class Class8
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		public void method_0(int int_2)
		{
			int num = default(int);
			int num3 = default(int);
			int num2 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			try
			{
				try
				{
					num = 7;
					num3 = (int_1 = (num2 = int_1) + 1);
					num = 3;
					if (num2 == 32768)
					{
						throw new InvalidOperationException();
					}
					byte[] array = byte_0;
					num4 = (int_0 = (num2 = int_0) + 1);
					array[num2] = (byte)int_2;
					num = 8;
					num5 = (int_0 &= 32767);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num2, this, int_2);
					throw;
				}
				num6 = 0;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException8(exception2, num2, num3, num4, num5, num, num6, this, int_2);
				throw;
			}
		}

		private void method_1(int int_2, int int_3, int int_4)
		{
			int num = default(int);
			int num3 = default(int);
			int num2 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			try
			{
				try
				{
					num = 1;
					num = 3;
					while (int_3-- > 0)
					{
						byte[] array = byte_0;
						num3 = (int_0 = (num2 = int_0) + 1);
						array[num2] = byte_0[int_2++];
						num = 9;
						num4 = (int_0 &= 32767);
						num = 2;
						int_2 &= 0x7FFF;
						num = 3;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num2, this, int_2, int_3, int_4);
					throw;
				}
				num5 = 2;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException9(exception2, num2, num3, num4, num, num5, this, int_2, int_3, int_4);
				throw;
			}
		}

		public void method_2(int int_2, int int_3)
		{
			int num = default(int);
			int num3 = default(int);
			int num2 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			try
			{
				try
				{
					num = 2;
					num3 = (num2 = (int_1 += int_2));
					num = 16;
					if (num2 > 32768)
					{
						num = 10;
						throw new InvalidOperationException();
					}
					num = 3;
					num4 = (int_0 - int_3) & 0x7FFF;
					num5 = 32768 - int_2;
					num = 9;
					if (num4 > num5)
					{
						num = 11;
						goto IL_00ec;
					}
					num = 12;
					if (int_0 >= num5)
					{
						num = 11;
						goto IL_00ec;
					}
					num = 8;
					if (int_2 <= int_3)
					{
						num = 0;
						AppPathFinder.smethod_0(byte_0, num4, byte_0, int_0, int_2, 110, 116);
						num = 6;
						num6 = (int_0 += int_2);
					}
					else
					{
						num = 15;
						while (int_2-- > 0)
						{
							num = 7;
							byte[] array = byte_0;
							num7 = (int_0 = (num2 = int_0) + 1);
							array[num2] = byte_0[num4++];
							num = 15;
						}
						num = 13;
					}
					goto end_IL_0000;
					IL_00ec:
					method_1(num4, int_2, int_3);
					end_IL_0000:;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException6(exception, num4, num5, num2, this, int_2, int_3);
					throw;
				}
				num8 = 0;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[11]
				{
					num4, num5, num2, num3, num6, num7, num, num8, this, int_2,
					int_3
				});
				throw;
			}
		}

		public int method_3(Class7 class7_0, int int_2)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			try
			{
				try
				{
					num = 0;
					int_2 = Class3.smethod_4(Class3.smethod_4(int_2, 32768 - int_1, 605, 552), class7_0.method_3(), 317, 328);
					num = 3;
					num2 = 32768 - int_0;
					if (int_2 > num2)
					{
						num = 8;
						num3 = class7_0.method_6(byte_0, int_0, num2);
						num = 7;
						if (num3 == num2)
						{
							num = 6;
							num3 += class7_0.method_6(byte_0, 0, int_2 - num2);
							num = 10;
						}
						else
						{
							num = 10;
						}
					}
					else
					{
						num = 1;
						num3 = class7_0.method_6(byte_0, int_0, int_2);
						num = 10;
					}
					num4 = (int_0 = (int_0 + num3) & 0x7FFF);
					num = 12;
					num5 = (int_1 += num3);
					num = 4;
					num6 = num3;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num3, num2, this, class7_0, int_2);
					throw;
				}
				num7 = 0;
				return num6;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException10(exception2, num3, num2, num6, num4, num5, num, num7, this, class7_0, int_2);
				throw;
			}
		}

		public int method_4()
		{
			int num = default(int);
			try
			{
				try
				{
					num = 32768 - int_1;
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		public int method_5()
		{
			int num = default(int);
			try
			{
				try
				{
					num = int_1;
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		public int method_6(byte[] byte_1, int int_2, int int_3)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			try
			{
				try
				{
					num = 5;
					num2 = int_0;
					if (int_3 > int_1)
					{
						num = 13;
						int_3 = int_1;
						num = 14;
					}
					else
					{
						num = 3;
						num2 = (int_0 - int_1 + int_3) & 0x7FFF;
						num = 14;
					}
					num3 = int_3;
					num4 = int_3 - num2;
					if (num4 > 0)
					{
						num = 11;
						AppPathFinder.smethod_0(byte_0, 32768 - num4, byte_1, int_2, num4, 540, 518);
						num = 8;
						int_2 += num4;
						int_3 = num2;
						num = 4;
					}
					else
					{
						num = 4;
					}
					AppPathFinder.smethod_0(byte_0, num2 - int_3, byte_1, int_2, int_3, 453, 479);
					num = 1;
					num5 = (int_1 -= num3);
					num = 2;
					if (int_1 < 0)
					{
						num = 9;
						throw new InvalidOperationException();
					}
					num = 7;
					num6 = num3;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException7(exception, num2, num3, num4, this, byte_1, int_2, int_3);
					throw;
				}
				num7 = 0;
				return num6;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[11]
				{
					num2, num3, num4, num6, num5, num, num7, this, byte_1, int_2,
					int_3
				});
				throw;
			}
		}

		public Class8()
		{
			byte[] o = (byte_0 = new byte[32768]);
			int num = 0;
			int_0 = 0;
			int num2 = 0;
			int_1 = 0;
			base._002Ector();
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, o, num, num2, this);
				throw;
			}
		}

		static Class8()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}

		internal static string smethod_0(ref uint uint_0, string string_0, int int_2, int int_3)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 101:
						return uint_0.ToString(string_0);
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, uint_0, string_0, int_2, int_3);
				throw;
			}
		}

		internal static string smethod_1(string string_0, char char_0, char char_1, int int_2, int int_3)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 113:
						return string_0.Replace(char_0, char_1);
					}
					num = 2;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num, string_0, char_0, char_1, int_2, int_3);
				throw;
			}
		}
	}

	internal sealed class Class9
	{
		public static readonly Class9 class9_0;

		public static readonly Class9 class9_1;

		internal short[] short_0;

		static Class9()
		{
			int num = default(int);
			byte[] array = default(byte[]);
			int num2 = default(int);
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
				try
				{
					num = 13;
					array = new byte[288];
					num2 = 0;
					num = 9;
					while (num2 < 144)
					{
						num = 4;
						array[num2++] = 8;
						num = 9;
					}
					num = 8;
					num = 2;
					while (num2 < 256)
					{
						num = 11;
						array[num2++] = 9;
						num = 2;
					}
					num = 10;
					num = 18;
					while (num2 < 280)
					{
						num = 14;
						array[num2++] = 7;
						num = 18;
					}
					num = 1;
					num = 17;
					while (num2 < 288)
					{
						num = 0;
						array[num2++] = 8;
						num = 17;
					}
					num = 3;
					class9_0 = new Class9(array);
					array = new byte[32];
					num2 = 0;
					num = 15;
					while (num2 < 32)
					{
						num = 5;
						array[num2++] = 5;
						num = 15;
					}
					num = 12;
					class9_1 = new Class9(array);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, array, num2);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, array, num2, num);
				throw;
			}
		}

		public Class9(byte[] byte_0)
		{
			try
			{
				try
				{
					method_0(byte_0);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, byte_0);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, this, byte_0);
				throw;
			}
		}

		private void method_0(byte[] byte_0)
		{
			int num = default(int);
			int[] array = default(int[]);
			int[] array2 = default(int[]);
			int num2 = default(int);
			int num3 = default(int);
			int[] array3 = default(int[]);
			nint num5 = default(nint);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			short[] array5 = default(short[]);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			int num16 = default(int);
			int num17 = default(int);
			int num18 = default(int);
			int num19 = default(int);
			int num20 = default(int);
			object[] array6 = default(object[]);
			int num21 = default(int);
			try
			{
				try
				{
					num = 7;
					array = new int[16];
					array2 = new int[16];
					num2 = 0;
					num = 23;
					while (num2 < byte_0.Length)
					{
						num = 34;
						num3 = byte_0[num2];
						if (num3 > 0)
						{
							num = 9;
							int[] array4 = (array3 = array);
							int num4 = num3;
							num5 = num4;
							array4[num4] = array3[num5] + 1;
							num = 32;
						}
						else
						{
							num = 32;
						}
						num2++;
						num = 23;
					}
					num = 6;
					num6 = 0;
					num7 = 512;
					num8 = 1;
					num = 4;
					while (num8 <= 15)
					{
						num = 22;
						array2[num8] = num6;
						num6 += array[num8] << 16 - num8;
						num = 35;
						if (num8 >= 10)
						{
							num = 19;
							num9 = array2[num8] & 0x1FF80;
							num10 = num6 & 0x1FF80;
							num = 30;
							num7 += num10 - num9 >> 16 - num8;
							num = 10;
						}
						else
						{
							num = 10;
						}
						num8++;
						num = 4;
					}
					num = 17;
					array5 = (short_0 = new short[num7]);
					num11 = 512;
					num = 18;
					num12 = 15;
					num = 2;
					while (num12 >= 10)
					{
						num = 36;
						num13 = num6 & 0x1FF80;
						num6 -= array[num12] << 16 - num12;
						num = 13;
						num14 = num6 & 0x1FF80;
						num15 = num14;
						num = 39;
						while (num15 < num13)
						{
							num = 15;
							short_0[Class12.smethod_0(num15)] = (short)((-num11 << 4) | num12);
							num = 33;
							num11 += 1 << num12 - 9;
							num = 28;
							num15 += 128;
							num = 39;
						}
						num = 8;
						num12--;
						num = 2;
					}
					num = 1;
					num16 = 0;
					num = 12;
					while (num16 < byte_0.Length)
					{
						num = 20;
						num17 = byte_0[num16];
						if (num17 != 0)
						{
							num = 24;
							num6 = array2[num17];
							num18 = Class12.smethod_0(num6);
							if (num17 <= 9)
							{
								num = 26;
								while (true)
								{
									short_0[num18] = (short)((num16 << 4) | num17);
									num = 11;
									num18 += 1 << num17;
									if (num18 >= 512)
									{
										break;
									}
									num = 26;
								}
								num = 37;
								num = 29;
							}
							else
							{
								num = 27;
								num19 = short_0[num18 & 0x1FF];
								num20 = 1 << (num19 & 0xF);
								num = 3;
								num19 = -(num19 >> 4);
								num = 16;
								while (true)
								{
									short_0[num19 | (num18 >> 9)] = (short)((num16 << 4) | num17);
									num = 38;
									num18 += 1 << num17;
									if (num18 >= num20)
									{
										break;
									}
									num = 16;
								}
								num = 29;
							}
							array2[num17] = num6 + (1 << 16 - num17);
							num = 0;
						}
						else
						{
							num = 0;
						}
						num16++;
						num = 12;
					}
					num = 5;
				}
				catch (Exception caughtException)
				{
					array6 = new object[23]
					{
						array, array2, num2, num3, num6, num7, num8, num9, num10, num11,
						num12, num13, num14, num15, num16, num17, num18, num19, num20, array3,
						num5, this, byte_0
					};
					StackFrameHelper.CreateExceptionN(caughtException, array6);
					throw;
				}
				num21 = 1;
			}
			catch (Exception caughtException2)
			{
				StackFrameHelper.CreateExceptionN(caughtException2, new object[27]
				{
					array, array2, num2, num3, num6, num7, num8, num9, num10, num11,
					num12, num13, num14, num15, num16, num17, num18, num19, num20, array3,
					num5, array6, array5, num, num21, this, byte_0
				});
				throw;
			}
		}

		public int method_1(Class7 class7_0)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			try
			{
				try
				{
					num = 15;
					if ((num2 = class7_0.method_0(9)) >= 0)
					{
						num = 0;
						if ((num3 = short_0[num2]) >= 0)
						{
							num = 3;
							class7_0.method_1(num3 & 0xF);
							num4 = num3 >> 4;
						}
						else
						{
							num = 12;
							num5 = -(num3 >> 4);
							num6 = num3 & 0xF;
							if ((num2 = class7_0.method_0(num6)) >= 0)
							{
								num = 8;
								num3 = short_0[num5 | (num2 >> 9)];
								num = 11;
								class7_0.method_1(num3 & 0xF);
								num4 = num3 >> 4;
							}
							else
							{
								num = 13;
								num7 = class7_0.method_2();
								num2 = class7_0.method_0(num7);
								num3 = short_0[num5 | (num2 >> 9)];
								num = 9;
								if ((num3 & 0xF) <= num7)
								{
									num = 17;
									class7_0.method_1(num3 & 0xF);
									num4 = num3 >> 4;
								}
								else
								{
									num = 2;
									num4 = -1;
								}
							}
						}
					}
					else
					{
						num = 14;
						num8 = class7_0.method_2();
						num2 = class7_0.method_0(num8);
						num3 = short_0[num2];
						num = 18;
						if (num3 < 0)
						{
							num = 5;
							goto IL_011e;
						}
						num = 10;
						if ((num3 & 0xF) > num8)
						{
							num = 5;
							goto IL_011e;
						}
						num = 6;
						class7_0.method_1(num3 & 0xF);
						num4 = num3 >> 4;
					}
					goto end_IL_0000;
					IL_011e:
					num4 = -1;
					end_IL_0000:;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, num2, num3, num5, num6, num7, num8, this, class7_0);
					throw;
				}
				num9 = 1;
				return num4;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[11]
				{
					num2, num3, num5, num6, num7, num8, num4, num, num9, this,
					class7_0
				});
				throw;
			}
		}
	}

	internal sealed class Class10
	{
		private static readonly int[] int_0;

		private static readonly int[] int_1;

		private Class9 class9_0;

		private static readonly int[] int_2;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal byte byte_2;

		internal int int_9;

		public Class10()
		{
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public bool method_0(Class7 class7_0)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			bool flag = default(bool);
			int num6 = default(int);
			int num7 = default(int);
			byte[] array = default(byte[]);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			byte[] array2 = default(byte[]);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			byte b2 = default(byte);
			byte b = default(byte);
			byte b3 = default(byte);
			int num17 = default(int);
			int num18 = default(int);
			int num19 = default(int);
			int num20 = default(int);
			byte[] array4 = default(byte[]);
			int num21 = default(int);
			int num22 = default(int);
			int num23 = default(int);
			int num24 = default(int);
			int num25 = default(int);
			int num26 = default(int);
			int num27 = default(int);
			try
			{
				try
				{
					while (true)
					{
						num = 4;
						num2 = int_3;
						switch (num2)
						{
						case 5:
							num = 41;
							goto IL_0033;
						case 4:
							num = 12;
							goto IL_0123;
						case 3:
							num = 22;
							goto IL_01d6;
						case 2:
							num = 5;
							goto IL_0227;
						case 1:
							num = 39;
							goto IL_029b;
						case 0:
							num = 16;
							num3 = (int_4 = class7_0.method_0(5));
							if (int_4 >= 0)
							{
								num = 8;
								num4 = (int_4 += 257);
								num = 19;
								class7_0.method_1(5);
								num5 = 1;
								int_3 = 1;
								num = 39;
								goto IL_029b;
							}
							num = 15;
							flag = false;
							goto end_IL_0000;
						default:
							{
								num = 43;
								break;
							}
							IL_01d6:
							while (true)
							{
								if (int_9 < int_6)
								{
									num = 23;
									num6 = class7_0.method_0(3);
									if (num6 >= 0)
									{
										num = 33;
										class7_0.method_1(3);
										byte_0[int_2[int_9]] = (byte)num6;
										num = 44;
										num7 = ++int_9;
										num = 22;
										continue;
									}
									num = 1;
									flag = false;
									goto end_IL_0000;
								}
								num = 2;
								class9_0 = new Class9(byte_0);
								array = (byte_0 = null);
								num = 26;
								num8 = 0;
								int_9 = 0;
								num9 = 4;
								int_3 = 4;
								num = 12;
								break;
							}
							goto IL_0123;
							IL_029b:
							num10 = (int_5 = class7_0.method_0(5));
							if (int_5 >= 0)
							{
								num = 11;
								num11 = ++int_5;
								num = 40;
								class7_0.method_1(5);
								num12 = (int_7 = int_4 + int_5);
								num = 25;
								array2 = (byte_1 = new byte[int_7]);
								num = 28;
								num13 = 2;
								int_3 = 2;
								num = 5;
								goto IL_0227;
							}
							num = 32;
							flag = false;
							goto end_IL_0000;
							IL_0123:
							while (true)
							{
								if (((num14 = class9_0.method_1(class7_0)) & -16) == 0)
								{
									num = 34;
									byte[] array3 = byte_1;
									num15 = (int_9 = (num2 = int_9) + 1);
									int num16 = num2;
									b2 = (byte_2 = (b = (byte)num14));
									array3[num16] = b;
									num = 13;
									if (int_9 != int_7)
									{
										num = 12;
										continue;
									}
									num = 10;
									flag = true;
									goto end_IL_0000;
								}
								num = 37;
								if (num14 >= 0)
								{
									num = 9;
									if (num14 >= 17)
									{
										num = 18;
										b3 = 0;
										byte_2 = 0;
										num = 38;
									}
									else
									{
										num = 38;
									}
									num17 = (int_8 = num14 - 16);
									num18 = 5;
									int_3 = 5;
									num = 41;
									break;
								}
								num = 6;
								flag = false;
								goto end_IL_0000;
							}
							goto IL_0033;
							IL_0227:
							num19 = (int_6 = class7_0.method_0(4));
							if (int_6 >= 0)
							{
								num = 42;
								num20 = (int_6 += 4);
								num = 29;
								class7_0.method_1(4);
								array4 = (byte_0 = new byte[19]);
								num = 36;
								num21 = 0;
								int_9 = 0;
								num22 = 3;
								int_3 = 3;
								num = 22;
								goto IL_01d6;
							}
							num = 21;
							flag = false;
							goto end_IL_0000;
							IL_0033:
							num23 = int_1[int_8];
							num24 = class7_0.method_0(num23);
							num = 14;
							if (num24 >= 0)
							{
								num = 0;
								class7_0.method_1(num23);
								num24 += int_0[int_8];
								num = 20;
								while (num24-- > 0)
								{
									num = 7;
									byte[] array5 = byte_1;
									num25 = (int_9 = (num2 = int_9) + 1);
									array5[num2] = byte_2;
									num = 20;
								}
								num = 27;
								if (int_9 != int_7)
								{
									num = 24;
									num26 = 4;
									int_3 = 4;
									break;
								}
								num = 17;
								flag = true;
							}
							else
							{
								num = 35;
								flag = false;
							}
							goto end_IL_0000;
						}
						continue;
						end_IL_0000:
						break;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, num6, num14, num23, num24, num2, b, this, class7_0);
					throw;
				}
				num27 = 2;
				return flag;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[35]
				{
					num6, num14, num23, num24, num2, b, flag, num3, num4, num5,
					num10, num11, num12, array2, num13, num19, num20, array4, num21, num22,
					num7, array, num8, num9, num15, b2, b3, num17, num18, num25,
					num26, num, num27, this, class7_0
				});
				throw;
			}
		}

		public Class9 method_1()
		{
			int num = default(int);
			byte[] array = default(byte[]);
			Class9 @class = default(Class9);
			int num2 = default(int);
			try
			{
				try
				{
					num = 3;
					array = new byte[int_4];
					AppPathFinder.smethod_0(byte_1, 0, array, 0, int_4, 341, 335);
					num = 5;
					@class = new Class9(array);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, array, this);
					throw;
				}
				num2 = 3;
				return @class;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException5(exception2, array, @class, num, num2, this);
				throw;
			}
		}

		public Class9 method_2()
		{
			int num = default(int);
			byte[] array = default(byte[]);
			Class9 @class = default(Class9);
			int num2 = default(int);
			try
			{
				try
				{
					num = 0;
					array = new byte[int_5];
					AppPathFinder.smethod_0(byte_1, int_4, array, 0, int_5, 780, 790);
					num = 1;
					@class = new Class9(array);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, array, this);
					throw;
				}
				num2 = 1;
				return @class;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException5(exception2, array, @class, num, num2, this);
				throw;
			}
		}

		static Class10()
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
				try
				{
					num = 1;
					int[] array_ = new int[3];
					UsageReportSender.smethod_10(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 166, 135);
					int_0 = array_;
					int[] array_2 = new int[3];
					UsageReportSender.smethod_10(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 249, 216);
					int_1 = array_2;
					num = 0;
					int_2 = new int[19]
					{
						16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
						11, 4, 12, 3, 13, 2, 14, 1, 15
					};
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException0(exception);
					throw;
				}
				num2 = 4;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, num2);
				throw;
			}
		}
	}

	internal sealed class Class11
	{
		private Class15 class15_0;

		private Class14 class14_0;

		internal int int_0;

		internal long long_0;

		public Class11()
		{
			int num = 16;
			int_0 = 16;
			long num2 = 0L;
			long_0 = 0L;
			base._002Ector();
			try
			{
				try
				{
					class15_0 = new Class15();
					class14_0 = new Class14(class15_0);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, num, num2, this);
				throw;
			}
		}

		[SpecialName]
		public long method_0()
		{
			long num = default(long);
			try
			{
				try
				{
					num = long_0;
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		public void method_1()
		{
			int num = default(int);
			try
			{
				try
				{
					num = (int_0 |= 12);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_2()
		{
			int num = default(int);
			bool flag = default(bool);
			try
			{
				try
				{
					num = 5;
					if (int_0 == 30)
					{
						flag = class15_0.method_5();
						return flag;
					}
					flag = false;
					return flag;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, flag, num, this);
				throw;
			}
		}

		[SpecialName]
		public bool method_3()
		{
			bool flag = default(bool);
			try
			{
				try
				{
					flag = class14_0.method_8();
					return flag;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, flag, this);
				throw;
			}
		}

		public void method_4(byte[] byte_0)
		{
			try
			{
				try
				{
					class14_0.method_7(byte_0);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, byte_0);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, this, byte_0);
				throw;
			}
		}

		public int method_5(byte[] byte_0)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			long num6 = default(long);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			try
			{
				try
				{
					num = 14;
					num2 = 0;
					num3 = byte_0.Length;
					num4 = num3;
					num = 3;
					while (true)
					{
						num5 = class15_0.method_6(byte_0, num2, num3);
						num2 += num5;
						num = 0;
						num6 = (long_0 += num5);
						num = 5;
						num3 -= num5;
						if (num3 != 0)
						{
							num = 6;
							if (int_0 != 30)
							{
								num = 15;
								if (!class14_0.method_6((int_0 & 4) != 0, (int_0 & 8) != 0))
								{
									num = 19;
									if (int_0 == 16)
									{
										num = 2;
										num7 = num4 - num3;
										break;
									}
									num = 17;
									if (int_0 == 20)
									{
										num = 11;
										num8 = 8 + (-class15_0.method_2() & 7);
										num = 18;
										while (num8 > 0)
										{
											num = 1;
											class15_0.method_4(2, 10);
											num8 -= 10;
											num = 18;
										}
										num = 13;
										num9 = 16;
										int_0 = 16;
										num = 3;
									}
									else
									{
										num = 4;
										if (int_0 == 28)
										{
											num = 10;
											class15_0.method_3();
											num10 = 30;
											int_0 = 30;
											num = 3;
										}
										else
										{
											num = 3;
										}
									}
								}
								else
								{
									num = 3;
								}
								continue;
							}
							num = 8;
						}
						else
						{
							num = 8;
						}
						num7 = num4 - num3;
						break;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException7(exception, num2, num3, num4, num5, num8, this, byte_0);
					throw;
				}
				num11 = 4;
				return num7;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[13]
				{
					num2, num3, num4, num5, num8, num7, num6, num9, num10, num,
					num11, this, byte_0
				});
				throw;
			}
		}

		static Class11()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}

		internal static Color smethod_0(int int_1, int int_2, int int_3)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_3 ^ int_2)
					{
					case 118:
						return Color.FromArgb(int_1);
					}
					num = 7;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, int_1, int_2, int_3);
				throw;
			}
		}

		internal static string smethod_1(int int_1, int int_2)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_2 ^ int_1)
					{
					case 107:
						return Environment.SystemDirectory;
					}
					num = 2;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, int_1, int_2);
				throw;
			}
		}

		internal static Version smethod_2(int int_1, int int_2)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_2 ^ int_1)
					{
					case 74:
						return Environment.Version;
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num, int_1, int_2);
				throw;
			}
		}

		internal static void smethod_3(AppDomain appDomain_0, string string_0, object object_0, int int_1, int int_2)
		{
			try
			{
				while (true)
				{
					switch (int_2 ^ int_1)
					{
					case 84:
						appDomain_0.SetData(string_0, object_0);
						return;
					}
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, appDomain_0, string_0, object_0, int_1, int_2);
				throw;
			}
		}
	}

	internal sealed class Class12
	{
		public sealed class Class13
		{
			public short[] short_0;

			public byte[] byte_0;

			public int int_0;

			public int int_1;

			private Class12 class12_0;

			internal short[] short_1;

			internal int[] int_2;

			internal int int_3;

			public Class13(Class12 class12_1, int int_4, int int_5, int int_6)
			{
				int num = default(int);
				int[] o = default(int[]);
				try
				{
					try
					{
						class12_0 = class12_1;
						int_0 = int_5;
						num = (int_3 = int_6);
						short_0 = new short[int_4];
						o = (int_2 = new int[int_6]);
					}
					catch (Exception exception)
					{
						StackFrameHelper.CreateException5(exception, this, class12_1, int_4, int_5, int_6);
						throw;
					}
				}
				catch (Exception exception2)
				{
					StackFrameHelper.CreateException7(exception2, num, o, this, class12_1, int_4, int_5, int_6);
					throw;
				}
			}

			public void method_0(int int_4)
			{
				try
				{
					try
					{
						class12_0.class15_0.method_4(short_1[int_4] & 0xFFFF, byte_0[int_4]);
					}
					catch (Exception exception)
					{
						StackFrameHelper.CreateException2(exception, this, int_4);
						throw;
					}
				}
				catch (Exception exception2)
				{
					StackFrameHelper.CreateException2(exception2, this, int_4);
					throw;
				}
			}

			public void method_1(short[] short_2, byte[] byte_1)
			{
				short[] o = default(short[]);
				try
				{
					try
					{
						o = (short_1 = short_2);
						byte_0 = byte_1;
					}
					catch (Exception exception)
					{
						StackFrameHelper.CreateException3(exception, this, short_2, byte_1);
						throw;
					}
				}
				catch (Exception exception2)
				{
					StackFrameHelper.CreateException4(exception2, o, this, short_2, byte_1);
					throw;
				}
			}

			public void method_2()
			{
				int num = default(int);
				int[] array = default(int[]);
				int num2 = default(int);
				short[] array2 = default(short[]);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int[] array3 = default(int[]);
				nint num7 = default(nint);
				int num8 = default(int);
				try
				{
					try
					{
						num = 9;
						array = new int[int_3];
						num = 13;
						num2 = 0;
						array2 = (short_1 = new short[short_0.Length]);
						num = 8;
						num3 = 0;
						num = 15;
						while (num3 < int_3)
						{
							num = 12;
							array[num3] = num2;
							num2 += int_2[num3] << 15 - num3;
							num = 14;
							num3++;
							num = 15;
						}
						num = 0;
						num4 = 0;
						num = 7;
						while (num4 < int_1)
						{
							num = 5;
							num5 = byte_0[num4];
							if (num5 > 0)
							{
								num = 10;
								short_1[num4] = smethod_0(array[num5 - 1]);
								num = 11;
								int[] array4 = (array3 = array);
								int num6 = num5 - 1;
								num7 = num6;
								array4[num6] = array3[num7] + (1 << 16 - num5);
								num = 4;
							}
							else
							{
								num = 4;
							}
							num4++;
							num = 7;
						}
						num = 6;
					}
					catch (Exception exception)
					{
						StackFrameHelper.CreateException8(exception, array, num2, num3, num4, num5, array3, num7, this);
						throw;
					}
					num8 = 4;
				}
				catch (Exception caughtException)
				{
					StackFrameHelper.CreateExceptionN(caughtException, new object[11]
					{
						array, num2, num3, num4, num5, array3, num7, array2, num, num8,
						this
					});
					throw;
				}
			}

			private void method_3(int[] int_4)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int[] array = default(int[]);
				int num6 = default(int);
				int num7 = default(int);
				int num8 = default(int);
				int num9 = default(int);
				int[] array2 = default(int[]);
				nint num11 = default(nint);
				int num12 = default(int);
				int num17 = default(int);
				int num18 = default(int);
				int num19 = default(int);
				int num20 = default(int);
				object[] array8 = default(object[]);
				int num21 = default(int);
				try
				{
					try
					{
						num = 15;
						byte_0 = new byte[short_0.Length];
						num2 = int_4.Length / 2;
						num = 13;
						num3 = (num2 + 1) / 2;
						num4 = 0;
						num5 = 0;
						num = 6;
						while (num5 < int_3)
						{
							num = 33;
							int_2[num5] = 0;
							num5++;
							num = 6;
						}
						num = 22;
						array = new int[num2];
						array[num2 - 1] = 0;
						num6 = num2 - 1;
						num = 11;
						while (num6 >= 0)
						{
							num = 19;
							if (int_4[2 * num6 + 1] != -1)
							{
								num = 21;
								num7 = array[num6] + 1;
								if (num7 > int_3)
								{
									num = 28;
									num7 = int_3;
									num4++;
									num = 32;
								}
								else
								{
									num = 32;
								}
								num8 = (array[int_4[2 * num6]] = (array[int_4[2 * num6 + 1]] = num7));
								num = 4;
							}
							else
							{
								num = 0;
								num9 = array[num6];
								int[] array3 = (array2 = int_2);
								int num10 = num9 - 1;
								num11 = num10;
								array3[num10] = array2[num11] + 1;
								num = 7;
								byte_0[int_4[2 * num6]] = (byte)array[num6];
								num = 4;
							}
							num6--;
							num = 11;
						}
						num = 14;
						if (num4 == 0)
						{
							num = 35;
						}
						else
						{
							num = 8;
							num12 = int_3 - 1;
							num = 17;
							while (true)
							{
								if (int_2[--num12] == 0)
								{
									num = 17;
									continue;
								}
								num = 1;
								while (true)
								{
									int[] array4 = (array2 = int_2);
									int num13 = num12;
									num11 = num13;
									array4[num13] = array2[num11] - 1;
									num = 27;
									int[] array5 = (array2 = int_2);
									int num14 = ++num12;
									num11 = num14;
									array5[num14] = array2[num11] + 1;
									num = 5;
									num4 -= 1 << int_3 - 1 - num12;
									num = 10;
									if (num4 > 0)
									{
										num = 31;
										if (num12 < int_3 - 1)
										{
											num = 1;
											continue;
										}
										num = 25;
										break;
									}
									num = 25;
									break;
								}
								if (num4 <= 0)
								{
									break;
								}
								num = 17;
							}
							num = 36;
							int[] array6 = (array2 = int_2);
							int num15 = int_3 - 1;
							num11 = num15;
							array6[num15] = array2[num11] + num4;
							num = 30;
							int[] array7 = (array2 = int_2);
							int num16 = int_3 - 2;
							num11 = num16;
							array7[num16] = array2[num11] - num4;
							num = 18;
							num17 = 2 * num3;
							num18 = int_3;
							num = 23;
							while (num18 != 0)
							{
								num = 3;
								num19 = int_2[num18 - 1];
								num = 20;
								while (num19 > 0)
								{
									num = 2;
									num20 = 2 * int_4[num17++];
									num = 24;
									if (int_4[num20 + 1] == -1)
									{
										num = 26;
										byte_0[int_4[num20]] = (byte)num18;
										num19--;
										num = 20;
									}
									else
									{
										num = 20;
									}
								}
								num = 16;
								num18--;
								num = 23;
							}
							num = 9;
						}
					}
					catch (Exception caughtException)
					{
						array8 = new object[18]
						{
							num2, num3, num4, num5, array, num6, num7, num9, num12, num17,
							num18, num19, num20, num8, array2, num11, this, int_4
						};
						StackFrameHelper.CreateExceptionN(caughtException, array8);
						throw;
					}
					num21 = 2;
				}
				catch (Exception caughtException2)
				{
					StackFrameHelper.CreateExceptionN(caughtException2, new object[21]
					{
						num2, num3, num4, num5, array, num6, num7, num9, num12, num17,
						num18, num19, num20, num8, array2, num11, array8, num, num21, this,
						int_4
					});
					throw;
				}
			}

			public void method_4()
			{
				int num = default(int);
				int num2 = default(int);
				int[] array = default(int[]);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				int num8 = default(int);
				int num10 = default(int);
				int num11 = default(int);
				int[] array2 = default(int[]);
				int[] array3 = default(int[]);
				int num12 = default(int);
				int num13 = default(int);
				int num14 = default(int);
				int num15 = default(int);
				int num16 = default(int);
				int num17 = default(int);
				int num18 = default(int);
				int num19 = default(int);
				int num20 = default(int);
				int num21 = default(int);
				object[] array4 = default(object[]);
				int num22 = default(int);
				try
				{
					try
					{
						num = 23;
						num2 = short_0.Length;
						array = new int[num2];
						num3 = 0;
						num = 19;
						num4 = 0;
						num5 = 0;
						num = 24;
						while (num5 < num2)
						{
							num = 5;
							num6 = short_0[num5];
							if (num6 != 0)
							{
								num = 32;
								num7 = num3++;
								num = 31;
								while (true)
								{
									if (num7 > 0)
									{
										num = 28;
										if (short_0[array[num8 = (num7 - 1) / 2]] > num6)
										{
											num = 42;
											array[num7] = array[num8];
											num7 = num8;
											num = 31;
											continue;
										}
										num = 10;
										break;
									}
									num = 10;
									break;
								}
								array[num7] = num5;
								num4 = num5;
								num = 7;
							}
							else
							{
								num = 7;
							}
							num5++;
							num = 24;
						}
						num = 12;
						num = 39;
						while (num3 < 2)
						{
							num = 47;
							int num9;
							if (num4 >= 2)
							{
								num = 36;
								num9 = 0;
							}
							else
							{
								num = 33;
								num9 = ++num4;
							}
							num10 = num9;
							array[num3++] = num10;
							num = 39;
						}
						num = 16;
						int_1 = Class40.smethod_1(num4 + 1, int_0, 980, 908);
						num = 38;
						num11 = num3;
						array2 = new int[4 * num3 - 2];
						array3 = new int[2 * num3 - 1];
						num = 4;
						num12 = num11;
						num13 = 0;
						num = 40;
						while (num13 < num3)
						{
							num = 1;
							num14 = (array2[2 * num13] = array[num13]);
							num = 26;
							array2[2 * num13 + 1] = -1;
							array3[num13] = short_0[num14] << 8;
							num = 45;
							array[num13] = num13;
							num13++;
							num = 40;
						}
						num = 35;
						while (true)
						{
							num15 = array[0];
							num16 = array[--num3];
							num = 52;
							num17 = 0;
							num18 = 1;
							num = 29;
							while (num18 < num3)
							{
								num = 43;
								if (num18 + 1 < num3)
								{
									num = 25;
									if (array3[array[num18]] > array3[array[num18 + 1]])
									{
										num = 21;
										num18++;
										num = 14;
									}
									else
									{
										num = 14;
									}
								}
								else
								{
									num = 14;
								}
								array[num17] = array[num18];
								num17 = num18;
								num18 = num18 * 2 + 1;
								num = 29;
							}
							num = 46;
							num19 = array3[num16];
							num = 9;
							while (true)
							{
								if ((num18 = num17) > 0)
								{
									num = 49;
									if (array3[array[num17 = (num18 - 1) / 2]] > num19)
									{
										num = 37;
										array[num18] = array[num17];
										num = 9;
										continue;
									}
									num = 30;
									break;
								}
								num = 30;
								break;
							}
							array[num18] = num16;
							num20 = array[0];
							num16 = num12++;
							num = 50;
							array2[2 * num16] = num15;
							array2[2 * num16 + 1] = num20;
							num = 17;
							num21 = Class3.smethod_4(array3[num15] & 0xFF, array3[num20] & 0xFF, 461, 440);
							num = 48;
							num19 = (array3[num16] = array3[num15] + array3[num20] - num21 + 1);
							num = 6;
							num17 = 0;
							num18 = 1;
							num = 15;
							while (num18 < num3)
							{
								num = 13;
								if (num18 + 1 < num3)
								{
									num = 44;
									if (array3[array[num18]] > array3[array[num18 + 1]])
									{
										num = 51;
										num18++;
										num = 11;
									}
									else
									{
										num = 11;
									}
								}
								else
								{
									num = 11;
								}
								array[num17] = array[num18];
								num17 = num18;
								num18 = num17 * 2 + 1;
								num = 15;
							}
							num = 41;
							num = 8;
							while (true)
							{
								if ((num18 = num17) > 0)
								{
									num = 34;
									if (array3[array[num17 = (num18 - 1) / 2]] > num19)
									{
										num = 3;
										array[num18] = array[num17];
										num = 8;
										continue;
									}
									num = 27;
									break;
								}
								num = 27;
								break;
							}
							array[num18] = num16;
							if (num3 <= 1)
							{
								break;
							}
							num = 35;
						}
						num = 20;
						method_3(array2);
					}
					catch (Exception caughtException)
					{
						array4 = new object[23]
						{
							num2, array, num3, num4, num5, num6, num7, num8, num10, num11,
							array2, array3, num12, num13, num14, num15, num16, num17, num18, num19,
							num20, num21, this
						};
						StackFrameHelper.CreateExceptionN(caughtException, array4);
						throw;
					}
					num22 = 1;
				}
				catch (Exception caughtException2)
				{
					StackFrameHelper.CreateExceptionN(caughtException2, new object[26]
					{
						num2, array, num3, num4, num5, num6, num7, num8, num10, num11,
						array2, array3, num12, num13, num14, num15, num16, num17, num18, num19,
						num20, num21, array4, num, num22, this
					});
					throw;
				}
			}

			public int method_5()
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				try
				{
					try
					{
						num = 3;
						num2 = 0;
						num3 = 0;
						num = 7;
						while (num3 < short_0.Length)
						{
							num2 += short_0[num3] * byte_0[num3];
							num = 1;
							num3++;
							num = 7;
						}
						num4 = num2;
					}
					catch (Exception exception)
					{
						StackFrameHelper.CreateException3(exception, num2, num3, this);
						throw;
					}
					num5 = 2;
					return num4;
				}
				catch (Exception exception2)
				{
					StackFrameHelper.CreateException6(exception2, num2, num3, num4, num, num5, this);
					throw;
				}
			}

			public void method_6(Class13 class13_0)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				short[] array = default(short[]);
				nint num9 = default(nint);
				int num11 = default(int);
				try
				{
					try
					{
						num = 18;
						num2 = -1;
						num3 = 0;
						num = 12;
						while (num3 < int_1)
						{
							num = 22;
							num4 = 1;
							num5 = byte_0[num3];
							if (num5 == 0)
							{
								num = 1;
								num6 = 138;
								num7 = 3;
								num = 8;
							}
							else
							{
								num = 4;
								num6 = 6;
								num7 = 3;
								if (num2 != num5)
								{
									num = 14;
									short[] array2 = (array = class13_0.short_0);
									int num8 = num5;
									num9 = num8;
									array2[num8] = (short)(array[num9] + 1);
									num = 0;
									num4 = 0;
									num = 8;
								}
								else
								{
									num = 8;
								}
							}
							num2 = num5;
							num3++;
							num = 17;
							while (true)
							{
								if (num3 < int_1)
								{
									num = 10;
									if (num2 == byte_0[num3])
									{
										num = 21;
										num3++;
										if (++num4 < num6)
										{
											num = 17;
											continue;
										}
										num = 20;
										break;
									}
									num = 20;
									break;
								}
								num = 20;
								break;
							}
							if (num4 < num7)
							{
								num = 5;
								short[] array3 = (array = class13_0.short_0);
								int num10 = num2;
								num9 = num10;
								array3[num10] = (short)(array[num9] + (short)num4);
								num = 12;
								continue;
							}
							num = 6;
							if (num2 != 0)
							{
								num = 3;
								(array = class13_0.short_0)[16] = (short)(array[16] + 1);
								num = 12;
								continue;
							}
							num = 19;
							if (num4 <= 10)
							{
								num = 7;
								(array = class13_0.short_0)[17] = (short)(array[17] + 1);
								num = 12;
							}
							else
							{
								num = 2;
								(array = class13_0.short_0)[18] = (short)(array[18] + 1);
								num = 12;
							}
						}
						num = 13;
					}
					catch (Exception exception)
					{
						StackFrameHelper.CreateException10(exception, num6, num7, num4, num2, num3, num5, array, num9, this, class13_0);
						throw;
					}
					num11 = 3;
				}
				catch (Exception caughtException)
				{
					StackFrameHelper.CreateExceptionN(caughtException, new object[12]
					{
						num6, num7, num4, num2, num3, num5, array, num9, num, num11,
						this, class13_0
					});
					throw;
				}
			}

			public void method_7(Class13 class13_0)
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				int num4 = default(int);
				int num5 = default(int);
				int num6 = default(int);
				int num7 = default(int);
				try
				{
					try
					{
						num = 19;
						num2 = -1;
						num3 = 0;
						num = 5;
						while (num3 < int_1)
						{
							num = 12;
							num4 = 1;
							num5 = byte_0[num3];
							if (num5 == 0)
							{
								num = 4;
								num6 = 138;
								num7 = 3;
								num = 0;
							}
							else
							{
								num = 6;
								num6 = 6;
								num7 = 3;
								if (num2 != num5)
								{
									num = 17;
									class13_0.method_0(num5);
									num4 = 0;
									num = 0;
								}
								else
								{
									num = 0;
								}
							}
							num2 = num5;
							num3++;
							num = 14;
							while (true)
							{
								if (num3 < int_1)
								{
									num = 8;
									if (num2 == byte_0[num3])
									{
										num = 11;
										num3++;
										if (++num4 < num6)
										{
											num = 14;
											continue;
										}
										num = 9;
										break;
									}
									num = 9;
									break;
								}
								num = 9;
								break;
							}
							if (num4 < num7)
							{
								num = 2;
								num = 23;
								while (num4-- > 0)
								{
									num = 15;
									class13_0.method_0(num2);
								}
								num = 20;
								num = 5;
								continue;
							}
							num = 21;
							if (num2 != 0)
							{
								num = 7;
								class13_0.method_0(16);
								class12_0.class15_0.method_4(num4 - 3, 2);
								num = 5;
								continue;
							}
							num = 13;
							if (num4 <= 10)
							{
								num = 18;
								class13_0.method_0(17);
								class12_0.class15_0.method_4(num4 - 3, 3);
								num = 5;
							}
							else
							{
								num = 16;
								class13_0.method_0(18);
								class12_0.class15_0.method_4(num4 - 11, 7);
							}
						}
						num = 10;
					}
					catch (Exception exception)
					{
						StackFrameHelper.CreateException8(exception, num6, num7, num4, num2, num3, num5, this, class13_0);
						throw;
					}
				}
				catch (Exception exception2)
				{
					StackFrameHelper.CreateException9(exception2, num6, num7, num4, num2, num3, num5, num, this, class13_0);
					throw;
				}
			}

			static Class13()
			{
				try
				{
					SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException0(exception);
					throw;
				}
			}
		}

		private static readonly int[] int_0;

		private static readonly byte[] byte_0;

		private Class15 class15_0;

		private Class13 class13_0;

		private Class13 class13_1;

		private Class13 class13_2;

		private static readonly short[] short_0;

		private static readonly byte[] byte_1;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		internal short[] short_2;

		internal byte[] byte_3;

		internal int int_1;

		internal int int_2;

		public static short smethod_0(int int_3)
		{
			short num = default(short);
			try
			{
				try
				{
					num = (short)((byte_0[int_3 & 0xF] << 12) | (byte_0[(int_3 >> 4) & 0xF] << 8) | (byte_0[(int_3 >> 8) & 0xF] << 4) | byte_0[int_3 >> 12]);
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, int_3);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, int_3);
				throw;
			}
		}

		static Class12()
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
				try
				{
					num = 16;
					int[] array_ = new int[19];
					UsageReportSender.smethod_10(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 392, 425);
					int_0 = array_;
					byte[] array_2 = new byte[16];
					UsageReportSender.smethod_10(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 892, 861);
					byte_0 = array_2;
					num = 7;
					short_0 = new short[286];
					byte_1 = new byte[286];
					num2 = 0;
					num = 6;
					while (num2 < 144)
					{
						num = 8;
						short_0[num2] = smethod_0(48 + num2 << 8);
						byte_1[num2++] = 8;
						num = 6;
					}
					num = 2;
					num = 3;
					while (num2 < 256)
					{
						num = 0;
						short_0[num2] = smethod_0(256 + num2 << 7);
						byte_1[num2++] = 9;
						num = 3;
					}
					num = 15;
					num = 21;
					while (num2 < 280)
					{
						num = 9;
						short_0[num2] = smethod_0(-256 + num2 << 9);
						byte_1[num2++] = 7;
						num = 21;
					}
					num = 4;
					num = 20;
					while (num2 < 286)
					{
						num = 18;
						short_0[num2] = smethod_0(-88 + num2 << 8);
						byte_1[num2++] = 8;
						num = 20;
					}
					num = 11;
					short_1 = new short[30];
					byte_2 = new byte[30];
					num2 = 0;
					num = 17;
					while (num2 < 30)
					{
						num = 5;
						short_1[num2] = smethod_0(num2 << 11);
						byte_2[num2] = 5;
						num = 10;
						num2++;
						num = 17;
					}
					num = 1;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, num2);
					throw;
				}
				num3 = 1;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, num2, num, num3);
				throw;
			}
		}

		public Class12(Class15 class15_1)
		{
			short[] o = default(short[]);
			byte[] o2 = default(byte[]);
			try
			{
				try
				{
					class15_0 = class15_1;
					class13_0 = new Class13(this, 286, 257, 15);
					class13_1 = new Class13(this, 30, 1, 15);
					class13_2 = new Class13(this, 19, 4, 7);
					o = (short_2 = new short[16384]);
					o2 = (byte_3 = new byte[16384]);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, class15_1);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException4(exception2, o, o2, this, class15_1);
				throw;
			}
		}

		public void method_0()
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				try
				{
					num = 0;
					int_1 = 0;
					num2 = 0;
					int_2 = 0;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, num, num2, this);
				throw;
			}
		}

		private int method_1(int int_3)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				try
				{
					num = 3;
					if (int_3 == 255)
					{
						num = 1;
						num2 = 285;
						return num2;
					}
					num = 8;
					num3 = 257;
					num = 2;
					while (int_3 >= 8)
					{
						num = 6;
						num3 += 4;
						int_3 >>= 1;
						num = 2;
					}
					num = 5;
					num2 = num3 + int_3;
					return num2;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num3, this, int_3);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException5(exception2, num3, num2, num, this, int_3);
				throw;
			}
		}

		private int method_2(int int_3)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				try
				{
					num = 2;
					num2 = 0;
					num = 3;
					while (int_3 >= 4)
					{
						num2 += 2;
						int_3 >>= 1;
						num = 3;
					}
					num3 = num2 + int_3;
					return num3;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num2, this, int_3);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException5(exception2, num2, num3, num, this, int_3);
				throw;
			}
		}

		public void method_3(int int_3)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				try
				{
					num = 6;
					class13_2.method_2();
					class13_0.method_2();
					class13_1.method_2();
					class15_0.method_4(class13_0.int_1 - 257, 5);
					num = 9;
					class15_0.method_4(class13_1.int_1 - 1, 5);
					class15_0.method_4(int_3 - 4, 4);
					num = 0;
					num2 = 0;
					num = 3;
					while (num2 < int_3)
					{
						class15_0.method_4(class13_2.byte_0[int_0[num2]], 3);
						num = 1;
						num2++;
						num = 3;
					}
					class13_0.method_7(class13_2);
					class13_1.method_7(class13_2);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num2, this, int_3);
					throw;
				}
				num3 = 4;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException5(exception2, num2, num, num3, this, int_3);
				throw;
			}
		}

		public void method_4()
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			try
			{
				try
				{
					num = 11;
					num2 = 0;
					num = 3;
					while (num2 < int_1)
					{
						num = 9;
						num3 = byte_3[num2] & 0xFF;
						num4 = short_2[num2];
						num = 12;
						if (num4-- != 0)
						{
							num = 1;
							num5 = method_1(num3);
							class13_0.method_0(num5);
							num6 = (num5 - 261) / 4;
							num = 15;
							if (num6 > 0)
							{
								num = 13;
								if (num6 <= 5)
								{
									num = 2;
									class15_0.method_4(num3 & ((1 << num6) - 1), num6);
								}
								else
								{
									num = 8;
								}
							}
							else
							{
								num = 8;
							}
							num7 = method_2(num4);
							class13_1.method_0(num7);
							num6 = num7 / 2 - 1;
							num = 17;
							if (num6 > 0)
							{
								num = 14;
								class15_0.method_4(num4 & ((1 << num6) - 1), num6);
								num = 5;
							}
							else
							{
								num = 5;
							}
						}
						else
						{
							num = 4;
							class13_0.method_0(num3);
						}
						num2++;
						num = 3;
					}
					num = 7;
					class13_0.method_0(256);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException7(exception, num2, num3, num4, num5, num6, num7, this);
					throw;
				}
				num8 = 2;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException9(exception2, num2, num3, num4, num5, num6, num7, num, num8, this);
				throw;
			}
		}

		public void method_5(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			int num = default(int);
			int num2 = default(int);
			try
			{
				try
				{
					num = 4;
					class15_0.method_4(bool_0 ? 1 : 0, 3);
					class15_0.method_3();
					class15_0.method_0(int_4);
					class15_0.method_0(~int_4);
					num = 2;
					class15_0.method_1(byte_4, int_3, int_4);
					method_0();
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, this, byte_4, int_3, int_4, bool_0);
					throw;
				}
				num2 = 2;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, num, num2, this, byte_4, int_3, int_4, bool_0);
				throw;
			}
		}

		public void method_6(byte[] byte_4, int int_3, int int_4, bool bool_0)
		{
			int num = default(int);
			short[] array = default(short[]);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			object[] array2 = default(object[]);
			int num8 = default(int);
			try
			{
				try
				{
					num = 4;
					(array = class13_0.short_0)[256] = (short)(array[256] + 1);
					num = 10;
					class13_0.method_4();
					class13_1.method_4();
					class13_0.method_6(class13_2);
					num = 18;
					class13_1.method_6(class13_2);
					class13_2.method_4();
					num2 = 4;
					num = 25;
					num3 = 18;
					num = 7;
					while (num3 > num2)
					{
						num = 13;
						if (class13_2.byte_0[int_0[num3]] > 0)
						{
							num = 12;
							num2 = num3 + 1;
							num = 23;
						}
						else
						{
							num = 23;
						}
						num3--;
						num = 7;
					}
					num = 3;
					num4 = 14 + num2 * 3 + class13_2.method_5() + class13_0.method_5() + class13_1.method_5() + int_2;
					num = 20;
					num5 = int_2;
					num6 = 0;
					num = 6;
					while (num6 < 286)
					{
						num = 14;
						num5 += class13_0.short_0[num6] * byte_1[num6];
						num = 9;
						num6++;
						num = 6;
					}
					num = 5;
					num7 = 0;
					num = 21;
					while (num7 < 30)
					{
						num = 1;
						num5 += class13_1.short_0[num7] * byte_2[num7];
						num = 8;
						num7++;
						num = 21;
					}
					num = 2;
					if (num4 >= num5)
					{
						num = 17;
						num4 = num5;
						num = 19;
					}
					else
					{
						num = 19;
					}
					if (int_3 < 0)
					{
						num = 26;
						goto IL_01af;
					}
					num = 27;
					if (int_4 + 4 >= num4 >> 3)
					{
						num = 26;
						goto IL_01af;
					}
					num = 11;
					method_5(byte_4, int_3, int_4, bool_0);
					goto end_IL_0000;
					IL_01af:
					if (num4 == num5)
					{
						num = 15;
						class15_0.method_4(2 + (bool_0 ? 1 : 0), 3);
						class13_0.method_1(short_0, byte_1);
						class13_1.method_1(short_1, byte_2);
						num = 29;
						method_4();
						method_0();
					}
					else
					{
						num = 16;
						class15_0.method_4(4 + (bool_0 ? 1 : 0), 3);
						method_3(num2);
						method_4();
						method_0();
					}
					end_IL_0000:;
				}
				catch (Exception caughtException)
				{
					array2 = new object[12]
					{
						num2, num3, num4, num5, num6, num7, array, this, byte_4, int_3,
						int_4, bool_0
					};
					StackFrameHelper.CreateExceptionN(caughtException, array2);
					throw;
				}
				num8 = 2;
			}
			catch (Exception caughtException2)
			{
				StackFrameHelper.CreateExceptionN(caughtException2, new object[15]
				{
					num2, num3, num4, num5, num6, num7, array, array2, num, num8,
					this, byte_4, int_3, int_4, bool_0
				});
				throw;
			}
		}

		public bool method_7()
		{
			bool flag = default(bool);
			try
			{
				try
				{
					flag = int_1 >= 16384;
					return flag;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, flag, this);
				throw;
			}
		}

		public bool method_8(int int_3)
		{
			int num = default(int);
			int num3 = default(int);
			int num2 = default(int);
			short[] array2 = default(short[]);
			nint num4 = default(nint);
			bool flag = default(bool);
			int num5 = default(int);
			try
			{
				try
				{
					num = 7;
					short_2[int_1] = 0;
					num = 1;
					byte[] array = byte_3;
					num3 = (int_1 = (num2 = int_1) + 1);
					array[num2] = (byte)int_3;
					num = 0;
					short[] array3 = (array2 = class13_0.short_0);
					num4 = int_3;
					array3[int_3] = (short)(array2[num4] + 1);
					num = 6;
					flag = method_7();
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num2, array2, num4, this, int_3);
					throw;
				}
				num5 = 0;
				return flag;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException9(exception2, num2, array2, num4, flag, num3, num, num5, this, int_3);
				throw;
			}
		}

		public bool method_9(int int_3, int int_4)
		{
			int num = default(int);
			int num3 = default(int);
			int num2 = default(int);
			int num4 = default(int);
			short[] array2 = default(short[]);
			nint num6 = default(nint);
			int num7 = default(int);
			int num8 = default(int);
			int num10 = default(int);
			bool flag = default(bool);
			int num11 = default(int);
			try
			{
				try
				{
					num = 11;
					short_2[int_1] = (short)int_3;
					num = 10;
					byte[] array = byte_3;
					num3 = (int_1 = (num2 = int_1) + 1);
					array[num2] = (byte)(int_4 - 3);
					num = 3;
					num4 = method_1(int_4 - 3);
					short[] array3 = (array2 = class13_0.short_0);
					int num5 = num4;
					num6 = num5;
					array3[num5] = (short)(array2[num6] + 1);
					num = 9;
					if (num4 >= 265)
					{
						num = 13;
						if (num4 < 285)
						{
							num = 8;
							num7 = (int_2 += (num4 - 261) / 4);
							num = 7;
						}
						else
						{
							num = 7;
						}
					}
					else
					{
						num = 7;
					}
					num8 = method_2(int_3 - 1);
					short[] array4 = (array2 = class13_1.short_0);
					int num9 = num8;
					num6 = num9;
					array4[num9] = (short)(array2[num6] + 1);
					num = 0;
					if (num8 >= 4)
					{
						num = 12;
						num10 = (int_2 += num8 / 2 - 1);
						num = 5;
					}
					else
					{
						num = 5;
					}
					flag = method_7();
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, num4, num8, num2, array2, num6, this, int_3, int_4);
					throw;
				}
				num11 = 3;
				return flag;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[14]
				{
					num4, num8, num2, array2, num6, flag, num3, num7, num10, num,
					num11, this, int_3, int_4
				});
				throw;
			}
		}
	}

	internal sealed class Class14
	{
		private Class15 class15_0;

		private Class12 class12_0;

		internal int int_0;

		internal short[] short_0;

		internal short[] short_1;

		internal int int_1;

		internal int int_2;

		internal bool bool_0;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		public Class14(Class15 class15_1)
		{
			byte[] o = default(byte[]);
			short[] o2 = default(short[]);
			short[] o3 = default(short[]);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				try
				{
					class15_0 = class15_1;
					class12_0 = new Class12(class15_1);
					o = (byte_0 = new byte[65536]);
					o2 = (short_0 = new short[32768]);
					o3 = (short_1 = new short[32768]);
					num = 1;
					num2 = 1;
					int_4 = 1;
					num3 = 1;
					int_3 = 1;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num, this, class15_1);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException8(exception2, num, o, o2, o3, num2, num3, this, class15_1);
				throw;
			}
		}

		private void method_0()
		{
			int num = default(int);
			try
			{
				try
				{
					num = (int_0 = (byte_0[int_4] << 5) ^ byte_0[int_4 + 1]);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		private int method_1()
		{
			int num = default(int);
			int num2 = default(int);
			short num3 = default(short);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			try
			{
				try
				{
					num = 4;
					num2 = ((int_0 << 5) ^ byte_0[int_4 + 2]) & 0x7FFF;
					num = 6;
					num3 = (short_1[int_4 & 0x7FFF] = short_0[num2]);
					num = 1;
					short_0[num2] = (short)int_4;
					num = 3;
					num4 = (int_0 = num2);
					num5 = num3 & 0xFFFF;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num3, num2, this);
					throw;
				}
				num6 = 1;
				return num5;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, num3, num2, num5, num4, num, num6, this);
				throw;
			}
		}

		private void method_2()
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			try
			{
				try
				{
					num = 6;
					AppPathFinder.smethod_0(byte_0, 32768, byte_0, 0, 32768, 811, 817);
					num = 13;
					num2 = (int_1 -= 32768);
					num = 0;
					num3 = (int_4 -= 32768);
					num = 5;
					num4 = (int_3 -= 32768);
					num = 8;
					num5 = 0;
					num = 1;
					while (num5 < 32768)
					{
						num = 3;
						num6 = short_0[num5] & 0xFFFF;
						short_0[num5] = (short)((num6 >= 32768) ? (num6 - 32768) : 0);
						num5++;
						num = 1;
					}
					num = 9;
					num7 = 0;
					num = 11;
					while (num7 < 32768)
					{
						num = 12;
						num8 = short_1[num7] & 0xFFFF;
						short_1[num7] = (short)((num8 >= 32768) ? (num8 - 32768) : 0);
						num7++;
						num = 11;
					}
					num = 14;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num5, num6, num7, num8, this);
					throw;
				}
				num9 = 0;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException10(exception2, num5, num6, num7, num8, num2, num3, num4, num, num9, this);
				throw;
			}
		}

		public void method_3()
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			try
			{
				try
				{
					num = 8;
					if (int_4 >= 65274)
					{
						num = 2;
						method_2();
						num = 3;
					}
					else
					{
						num = 3;
					}
					while (true)
					{
						if (int_5 < 262)
						{
							num = 14;
							if (int_7 < int_8)
							{
								num = 9;
								num2 = 65536 - int_5 - int_4;
								num = 13;
								if (num2 > int_8 - int_7)
								{
									num = 6;
									num2 = int_8 - int_7;
									num = 4;
								}
								else
								{
									num = 4;
								}
								AppPathFinder.smethod_0(byte_1, int_7, byte_0, int_4 + int_5, num2, 666, 640);
								num = 17;
								num3 = (int_7 += num2);
								num = 5;
								num4 = (int_6 += num2);
								num = 7;
								num5 = (int_5 += num2);
								num = 3;
								continue;
							}
							num = 11;
							break;
						}
						num = 11;
						break;
					}
					if (int_5 >= 3)
					{
						num = 0;
						method_0();
					}
					else
					{
						num = 16;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, num2, this);
					throw;
				}
				num6 = 0;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, num2, num3, num4, num5, num, num6, this);
				throw;
			}
		}

		private bool method_4(int int_9)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			short[] array = default(short[]);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			byte b = default(byte);
			byte b2 = default(byte);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			bool flag = default(bool);
			object[] array2 = default(object[]);
			int num12 = default(int);
			try
			{
				try
				{
					num = 13;
					num2 = 128;
					num3 = 128;
					array = short_1;
					num4 = int_4;
					num = 22;
					num5 = int_4 + int_2;
					num = 5;
					num6 = Class40.smethod_1(int_2, 2, 141, 213);
					num = 28;
					num7 = Class40.smethod_1(int_4 - 32506, 0, 659, 715);
					num = 8;
					num8 = int_4 + 258 - 1;
					b = byte_0[num5 - 1];
					num = 10;
					b2 = byte_0[num5];
					if (num6 >= 8)
					{
						num = 16;
						num2 >>= 2;
						num = 15;
					}
					else
					{
						num = 15;
					}
					if (num3 > int_5)
					{
						num = 17;
						num3 = int_5;
						num = 33;
					}
					else
					{
						num = 33;
					}
					while (true)
					{
						if (byte_0[int_9 + num6] != b2)
						{
							num = 29;
						}
						else
						{
							num = 21;
							if (byte_0[int_9 + num6 - 1] == b)
							{
								num = 18;
								if (byte_0[int_9] == byte_0[num4])
								{
									num = 35;
									if (byte_0[int_9 + 1] == byte_0[num4 + 1])
									{
										num = 0;
										num9 = int_9 + 2;
										num4 += 2;
										num = 27;
										while (true)
										{
											if (byte_0[++num4] == byte_0[++num9])
											{
												num = 12;
												if (byte_0[++num4] == byte_0[++num9])
												{
													num = 9;
													if (byte_0[++num4] == byte_0[++num9])
													{
														num = 34;
														if (byte_0[++num4] == byte_0[++num9])
														{
															num = 26;
															if (byte_0[++num4] == byte_0[++num9])
															{
																num = 19;
																if (byte_0[++num4] == byte_0[++num9])
																{
																	num = 32;
																	if (byte_0[++num4] == byte_0[++num9])
																	{
																		num = 11;
																		if (byte_0[++num4] == byte_0[++num9])
																		{
																			num = 24;
																			if (num4 < num8)
																			{
																				num = 27;
																				continue;
																			}
																			num = 6;
																			break;
																		}
																		num = 6;
																		break;
																	}
																	num = 6;
																	break;
																}
																num = 6;
																break;
															}
															num = 6;
															break;
														}
														num = 6;
														break;
													}
													num = 6;
													break;
												}
												num = 6;
												break;
											}
											num = 6;
											break;
										}
										if (num4 > num5)
										{
											num = 31;
											num10 = (int_1 = int_9);
											num5 = num4;
											num6 = num4 - int_4;
											num = 20;
											if (num6 >= num3)
											{
												num = 4;
												break;
											}
											num = 25;
											b = byte_0[num5 - 1];
											b2 = byte_0[num5];
											num = 1;
										}
										else
										{
											num = 1;
										}
										num4 = int_4;
										num = 29;
									}
									else
									{
										num = 29;
									}
								}
								else
								{
									num = 29;
								}
							}
							else
							{
								num = 29;
							}
						}
						if ((int_9 = array[int_9 & 0x7FFF] & 0xFFFF) > num7)
						{
							num = 23;
							if (--num2 != 0)
							{
								num = 33;
								continue;
							}
							num = 4;
							break;
						}
						num = 4;
						break;
					}
					num11 = (int_2 = Class3.smethod_4(num6, int_5, 21, 96));
					num = 14;
					flag = int_2 >= 3;
				}
				catch (Exception caughtException)
				{
					array2 = new object[13]
					{
						num2, num3, array, num4, num9, num5, num6, num7, num8, b,
						b2, this, int_9
					};
					StackFrameHelper.CreateExceptionN(caughtException, array2);
					throw;
				}
				num12 = 2;
				return flag;
			}
			catch (Exception caughtException2)
			{
				StackFrameHelper.CreateExceptionN(caughtException2, new object[19]
				{
					num2, num3, array, num4, num9, num5, num6, num7, num8, b,
					b2, array2, flag, num10, num11, num, num12, this, int_9
				});
				throw;
			}
		}

		private bool method_5(bool bool_1, bool bool_2)
		{
			int num = default(int);
			bool flag = default(bool);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			bool flag2 = default(bool);
			int num10 = default(int);
			bool flag3 = default(bool);
			int num11 = default(int);
			int num12 = default(int);
			bool flag4 = default(bool);
			int num13 = default(int);
			int num14 = default(int);
			bool flag5 = default(bool);
			int num16 = default(int);
			int num17 = default(int);
			try
			{
				try
				{
					num = 47;
					if (int_5 >= 262)
					{
						num = 28;
						goto IL_029e;
					}
					num = 13;
					if (bool_1)
					{
						num = 28;
						goto IL_029e;
					}
					num = 0;
					flag = false;
					goto end_IL_0000;
					IL_029e:
					while (true)
					{
						if (int_5 >= 262)
						{
							num = 38;
						}
						else
						{
							num = 33;
							if (!bool_1)
							{
								num = 2;
								flag = true;
								break;
							}
							num = 38;
						}
						if (int_5 != 0)
						{
							num = 12;
							if (int_4 >= 65274)
							{
								num = 39;
								method_2();
							}
							else
							{
								num = 35;
							}
							num2 = int_1;
							num3 = int_2;
							num = 5;
							if (int_5 >= 3)
							{
								num = 44;
								num4 = method_1();
								if (num4 != 0)
								{
									num = 40;
									if (int_4 - num4 <= 32506)
									{
										num = 37;
										if (method_4(num4))
										{
											num = 46;
											if (int_2 <= 5)
											{
												num = 26;
												if (int_2 == 3)
												{
													num = 14;
													if (int_4 - int_1 > 4096)
													{
														num = 49;
														num5 = 2;
														int_2 = 2;
														num = 31;
													}
													else
													{
														num = 31;
													}
												}
												else
												{
													num = 31;
												}
											}
											else
											{
												num = 31;
											}
										}
										else
										{
											num = 31;
										}
									}
									else
									{
										num = 31;
									}
								}
								else
								{
									num = 31;
								}
							}
							else
							{
								num = 31;
							}
							if (num3 >= 3)
							{
								num = 1;
								if (int_2 <= num3)
								{
									num = 27;
									class12_0.method_9(int_4 - 1 - num2, num3);
									num = 20;
									num3 -= 2;
									num = 24;
									while (true)
									{
										num6 = ++int_4;
										num = 43;
										num7 = --int_5;
										num = 29;
										if (int_5 < 3)
										{
											num = 41;
										}
										else
										{
											num = 52;
											method_1();
											num = 41;
										}
										if (--num3 <= 0)
										{
											break;
										}
										num = 24;
									}
									num = 34;
									num8 = ++int_4;
									num = 19;
									num9 = --int_5;
									num = 25;
									flag2 = false;
									bool_0 = false;
									num10 = 2;
									int_2 = 2;
									num = 51;
									goto IL_0278;
								}
								num = 50;
							}
							else
							{
								num = 50;
							}
							if (bool_0)
							{
								num = 17;
								class12_0.method_8(byte_0[int_4 - 1] & 0xFF);
								num = 6;
							}
							else
							{
								num = 6;
							}
							flag3 = true;
							bool_0 = true;
							num11 = ++int_4;
							num = 4;
							num12 = --int_5;
							num = 51;
							goto IL_0278;
						}
						num = 7;
						if (bool_0)
						{
							num = 36;
							class12_0.method_8(byte_0[int_4 - 1] & 0xFF);
							num = 8;
						}
						else
						{
							num = 8;
						}
						flag4 = false;
						bool_0 = false;
						class12_0.method_6(byte_0, int_3, int_4 - int_3, bool_2);
						num = 23;
						num13 = (int_3 = int_4);
						num = 42;
						flag = false;
						break;
						IL_0278:
						if (!class12_0.method_7())
						{
							num = 28;
							continue;
						}
						num = 3;
						num14 = int_4 - int_3;
						num = 9;
						if (bool_0)
						{
							num = 21;
							num14--;
							num = 11;
						}
						else
						{
							num = 11;
						}
						int num15;
						if (bool_2)
						{
							num = 18;
							if (int_5 == 0)
							{
								num = 16;
								num15 = ((!bool_0) ? 1 : 0);
								goto IL_039a;
							}
							num = 32;
						}
						else
						{
							num = 32;
						}
						num15 = 0;
						goto IL_039a;
						IL_039a:
						flag5 = (byte)num15 != 0;
						class12_0.method_6(byte_0, int_3, num14, flag5);
						num = 15;
						num16 = (int_3 += num14);
						num = 22;
						flag = !flag5;
						break;
					}
					end_IL_0000:;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, num2, num3, num4, num14, flag5, this, bool_1, bool_2);
					throw;
				}
				num17 = 2;
				return flag;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[24]
				{
					num2, num3, num4, num14, flag5, flag, flag4, num13, num5, num6,
					num7, num8, num9, flag2, num10, flag3, num11, num12, num16, num,
					num17, this, bool_1, bool_2
				});
				throw;
			}
		}

		public bool method_6(bool bool_1, bool bool_2)
		{
			int num = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			try
			{
				try
				{
					while (true)
					{
						num = 3;
						method_3();
						int num2;
						if (!bool_1)
						{
							num = 1;
							num2 = 0;
						}
						else
						{
							num = 0;
							num2 = ((int_7 == int_8) ? 1 : 0);
						}
						flag = (byte)num2 != 0;
						flag2 = method_5(flag, bool_2);
						if (class15_0.method_5())
						{
							num = 5;
							if (!flag2)
							{
								num = 7;
								break;
							}
							continue;
						}
						num = 7;
						break;
					}
					flag3 = flag2;
					return flag3;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, flag2, flag, this, bool_1, bool_2);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, flag2, flag, flag3, num, this, bool_1, bool_2);
				throw;
			}
		}

		public void method_7(byte[] byte_2)
		{
			int num = default(int);
			byte[] o = default(byte[]);
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			try
			{
				try
				{
					num = 1;
					o = (byte_1 = byte_2);
					num2 = 0;
					int_7 = 0;
					num = 4;
					num3 = (int_8 = byte_2.Length);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, byte_2);
					throw;
				}
				num4 = 2;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, o, num2, num3, num, num4, this, byte_2);
				throw;
			}
		}

		public bool method_8()
		{
			bool flag = default(bool);
			try
			{
				try
				{
					flag = int_8 == int_7;
					return flag;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, flag, this);
				throw;
			}
		}

		static Class14()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}

		internal static int smethod_0(Control control_0, int int_9, int int_10)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_10 ^ int_9)
					{
					case 85:
						return control_0.get_Height();
					case 86:
						return control_0.get_Top();
					}
					num = 3;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, control_0, int_9, int_10);
				throw;
			}
		}

		internal static void smethod_1(ButtonBase buttonBase_0, Image image_0, int int_9, int int_10)
		{
			int num = default(int);
			try
			{
				num = 1;
				while (true)
				{
					switch (int_10 ^ int_9)
					{
					case 16:
						buttonBase_0.set_Image(image_0);
						return;
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException6(exception, num, num2, buttonBase_0, image_0, int_9, int_10);
				throw;
			}
		}

		internal static void smethod_2(ButtonBase buttonBase_0, FlatStyle flatStyle_0, int int_9, int int_10)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			int num = default(int);
			try
			{
				num = 2;
				while (true)
				{
					switch (int_10 ^ int_9)
					{
					case 35:
						buttonBase_0.set_FlatStyle(flatStyle_0);
						return;
					}
					num = 2;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException6(exception, num, num2, buttonBase_0, flatStyle_0, int_9, int_10);
				throw;
			}
		}

		internal static void smethod_3(int int_9, int int_10)
		{
			int num = default(int);
			try
			{
				num = 4;
				while (true)
				{
					switch (int_10 ^ int_9)
					{
					case 7:
						Application.Exit();
						return;
					}
					num = 4;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException4(exception, num, num2, int_9, int_10);
				throw;
			}
		}
	}

	internal sealed class Class15
	{
		protected byte[] byte_0 = new byte[65536];

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;

		public void method_0(int int_3)
		{
			int num = default(int);
			int num3 = default(int);
			int num2 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			try
			{
				try
				{
					num = 5;
					byte[] array = byte_0;
					num3 = (int_1 = (num2 = int_1) + 1);
					array[num2] = (byte)int_3;
					num = 4;
					byte[] array2 = byte_0;
					num4 = (int_1 = (num2 = int_1) + 1);
					array2[num2] = (byte)(int_3 >> 8);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException3(exception, num2, this, int_3);
					throw;
				}
				num5 = 1;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, num2, num3, num4, num, num5, this, int_3);
				throw;
			}
		}

		public void method_1(byte[] byte_1, int int_3, int int_4)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				try
				{
					num = 3;
					AppPathFinder.smethod_0(byte_1, int_3, byte_0, int_1, int_4, 408, 386);
					num = 5;
					num2 = (int_1 += int_4);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException4(exception, this, byte_1, int_3, int_4);
					throw;
				}
				num3 = 3;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, num2, num, num3, this, byte_1, int_3, int_4);
				throw;
			}
		}

		[SpecialName]
		public int method_2()
		{
			int num = default(int);
			try
			{
				try
				{
					num = int_2;
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		public void method_3()
		{
			int num = default(int);
			int num3 = default(int);
			int num2 = default(int);
			int num4 = default(int);
			uint num5 = default(uint);
			int num6 = default(int);
			int num7 = default(int);
			try
			{
				try
				{
					num = 0;
					if (int_2 > 0)
					{
						num = 5;
						byte[] array = byte_0;
						num3 = (int_1 = (num2 = int_1) + 1);
						array[num2] = (byte)uint_0;
						num = 4;
						if (int_2 > 8)
						{
							num = 1;
							byte[] array2 = byte_0;
							num4 = (int_1 = (num2 = int_1) + 1);
							array2[num2] = (byte)(uint_0 >> 8);
							num = 7;
						}
						else
						{
							num = 7;
						}
					}
					else
					{
						num = 7;
					}
					num5 = 0u;
					uint_0 = 0u;
					num6 = 0;
					int_2 = 0;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, num2, this);
					throw;
				}
				num7 = 2;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException8(exception2, num2, num3, num4, num5, num6, num, num7, this);
				throw;
			}
		}

		public void method_4(int int_3, int int_4)
		{
			int num = default(int);
			uint num2 = default(uint);
			int num3 = default(int);
			int num5 = default(int);
			int num4 = default(int);
			int num6 = default(int);
			uint num7 = default(uint);
			int num8 = default(int);
			int num9 = default(int);
			try
			{
				try
				{
					num = 0;
					num2 = (uint_0 |= (uint)(int_3 << int_2));
					num = 2;
					num3 = (int_2 += int_4);
					num = 11;
					if (int_2 >= 16)
					{
						byte[] array = byte_0;
						num5 = (int_1 = (num4 = int_1) + 1);
						array[num4] = (byte)uint_0;
						num = 3;
						byte[] array2 = byte_0;
						num6 = (int_1 = (num4 = int_1) + 1);
						array2[num4] = (byte)(uint_0 >> 8);
						num = 8;
						num7 = (uint_0 >>= 16);
						num = 10;
						num8 = (int_2 -= 16);
						num = 7;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException4(exception, num4, this, int_3, int_4);
					throw;
				}
				num9 = 1;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[12]
				{
					num4, num2, num3, num5, num6, num7, num8, num, num9, this,
					int_3, int_4
				});
				throw;
			}
		}

		[SpecialName]
		public bool method_5()
		{
			bool flag = default(bool);
			try
			{
				try
				{
					flag = int_1 == 0;
					return flag;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, flag, this);
				throw;
			}
		}

		public int method_6(byte[] byte_1, int int_3, int int_4)
		{
			int num = default(int);
			int num3 = default(int);
			int num2 = default(int);
			uint num4 = default(uint);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			try
			{
				try
				{
					num = 10;
					if (int_2 >= 8)
					{
						num = 4;
						byte[] array = byte_0;
						num3 = (int_1 = (num2 = int_1) + 1);
						array[num2] = (byte)uint_0;
						num = 5;
						num4 = (uint_0 >>= 8);
						num = 9;
						num5 = (int_2 -= 8);
						num = 11;
					}
					else
					{
						num = 11;
					}
					if (int_4 > int_1 - int_0)
					{
						num = 1;
						int_4 = int_1 - int_0;
						num = 7;
						AppPathFinder.smethod_0(byte_0, int_0, byte_1, int_3, int_4, 266, 272);
						num = 6;
						num6 = 0;
						int_0 = 0;
						num7 = 0;
						int_1 = 0;
						num = 12;
					}
					else
					{
						num = 14;
						AppPathFinder.smethod_0(byte_0, int_0, byte_1, int_3, int_4, 506, 480);
						num = 3;
						num8 = (int_0 += int_4);
						num = 12;
					}
					num9 = int_4;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num2, this, byte_1, int_3, int_4);
					throw;
				}
				num10 = 1;
				return num9;
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[14]
				{
					num2, num9, num3, num4, num5, num6, num7, num8, num, num10,
					this, byte_1, int_3, int_4
				});
				throw;
			}
		}

		public Class15()
		{
			int num = 0;
			int_0 = 0;
			int num2 = 0;
			int_1 = 0;
			uint num3 = 0u;
			uint_0 = 0u;
			int num4 = 0;
			int_2 = 0;
			base._002Ector();
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, num2, num3, num4, this);
				throw;
			}
		}

		static Class15()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}

		internal static void smethod_0(Exception exception_0, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				num = 0;
				while (true)
				{
					switch (int_4 ^ int_3)
					{
					case 102:
						ProjectData.SetProjectError(exception_0);
						return;
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException5(exception, num, num2, exception_0, int_3, int_4);
				throw;
			}
		}

		internal static bool smethod_1(DateTime dateTime_0, DateTime dateTime_1, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_4 ^ int_3)
					{
					case 7:
						return dateTime_0 > dateTime_1;
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, dateTime_0, dateTime_1, int_3, int_4);
				throw;
			}
		}

		internal static object smethod_2(ResourceManager resourceManager_0, string string_0, int int_3, int int_4)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_4 ^ int_3)
					{
					case 126:
						return resourceManager_0.GetObject(string_0);
					}
					num = 4;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, num, resourceManager_0, string_0, int_3, int_4);
				throw;
			}
		}
	}

	internal sealed class Stream0 : MemoryStream
	{
		public void method_0(int int_0)
		{
			try
			{
				try
				{
					FatalExceptionEventArgs.smethod_1(this, (byte)((uint)int_0 & 0xFFu), 354, 343);
					FatalExceptionEventArgs.smethod_1(this, (byte)((uint)(int_0 >> 8) & 0xFFu), 748, 729);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, int_0);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, this, int_0);
				throw;
			}
		}

		public void method_1(int int_0)
		{
			try
			{
				try
				{
					method_0(int_0);
					method_0(int_0 >> 16);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, int_0);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, this, int_0);
				throw;
			}
		}

		public int method_2()
		{
			int num = default(int);
			try
			{
				try
				{
					num = Class3.smethod_5(this, 430, 496) | (Class3.smethod_5(this, 304, 366) << 8);
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		public int method_3()
		{
			int num = default(int);
			try
			{
				try
				{
					num = method_2() | (method_2() << 16);
					return num;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, num, this);
				throw;
			}
		}

		public Stream0()
		{
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		public Stream0(byte[] byte_0)
			: base(byte_0, writable: false)
		{
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, byte_0);
				throw;
			}
		}

		static Stream0()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}

		internal static Type smethod_0(object object_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 13:
						return object_0.GetType();
					}
					num = 5;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, object_0, int_0, int_1);
				throw;
			}
		}

		internal static void smethod_1(XmlWriter xmlWriter_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				num = 1;
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 92:
						xmlWriter_0.WriteStartDocument();
						return;
					case 93:
						xmlWriter_0.WriteEndDocument();
						return;
					}
					num = 1;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException5(exception, num, num2, xmlWriter_0, int_0, int_1);
				throw;
			}
		}

		internal static Size smethod_2(Control control_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 107:
						return control_0.get_ClientSize();
					}
					num = 7;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
				throw;
			}
		}

		internal static bool smethod_3(FieldInfo fieldInfo_0, int int_0, int int_1)
		{
			int num = default(int);
			try
			{
				while (true)
				{
					switch (int_1 ^ int_0)
					{
					case 81:
						return fieldInfo_0.IsInitOnly;
					}
					num = 0;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, num, fieldInfo_0, int_0, int_1);
				throw;
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1754)]
	private struct Struct2
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct3
	{
	}

	public static string ExceptionMessage;

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly char[] char_2;

	private static readonly char[] char_3;

	private static readonly string[] string_1;

	internal static byte byte_1/* Not supported: data(00) */;

	private static bool smethod_0(Assembly assembly_0, Assembly assembly_1)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		bool flag = default(bool);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			try
			{
				num = 1;
				array = DoNotObfuscateTypeAttribute.smethod_1(WaitSendingReportControl.smethod_2(assembly_0, 862, 891), 888, 813);
				num = 14;
				array2 = DoNotObfuscateTypeAttribute.smethod_1(WaitSendingReportControl.smethod_2(assembly_1, 504, 477), 829, 872);
				num = 3;
				if (array2 == null != (array == null))
				{
					num = 7;
					flag = false;
				}
				else
				{
					num = 2;
					if (array2 != null)
					{
						num = 10;
						num2 = 0;
						num = 0;
						while (true)
						{
							if (num2 >= array2.Length)
							{
								num = 12;
								break;
							}
							num = 11;
							if (array2[num2] == array[num2])
							{
								num = 8;
								num2++;
								num = 0;
								continue;
							}
							num = 5;
							flag = false;
							goto end_IL_0000;
						}
					}
					else
					{
						num = 12;
					}
					flag = true;
				}
				end_IL_0000:;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, array, array2, num2, assembly_0, assembly_1);
				throw;
			}
			num3 = 1;
			return flag;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException8(exception2, array, array2, num2, flag, num, num3, assembly_0, assembly_1);
			throw;
		}
	}

	public static byte[] Unzip(byte[] buffer)
	{
		int num = default(int);
		Assembly assembly = default(Assembly);
		Assembly assembly2 = default(Assembly);
		byte[] array = default(byte[]);
		Stream0 stream = default(Stream0);
		byte[] array2 = default(byte[]);
		int num2 = default(int);
		short num3 = default(short);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		Class6 @class = default(Class6);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		int num13 = default(int);
		byte[] array6 = default(byte[]);
		Class6 class2 = default(Class6);
		byte[] array8 = default(byte[]);
		byte[] array10 = default(byte[]);
		DESCryptoIndirector dESCryptoIndirector = default(DESCryptoIndirector);
		int num14 = default(int);
		ICryptoTransform dESCryptoTransform = default(ICryptoTransform);
		int num15 = default(int);
		byte[] array11 = default(byte[]);
		int num16 = default(int);
		int num17 = default(int);
		int num18 = default(int);
		int num19 = default(int);
		byte[] array13 = default(byte[]);
		byte[] array15 = default(byte[]);
		AESCryptoIndirector aESCryptoIndirector = default(AESCryptoIndirector);
		int num20 = default(int);
		ICryptoTransform aESCryptoTransform = default(ICryptoTransform);
		int num21 = default(int);
		byte[] array16 = default(byte[]);
		int num22 = default(int);
		int num23 = default(int);
		int num24 = default(int);
		int num25 = default(int);
		object[] array17 = default(object[]);
		int num26 = default(int);
		try
		{
			try
			{
				num = 11;
				assembly = Class7.smethod_0(182, 241);
				assembly2 = SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_1(787, 891);
				num = 24;
				if ((object)assembly == assembly2)
				{
					num = 7;
					goto IL_004d;
				}
				num = 16;
				if (smethod_0(assembly2, assembly))
				{
					num = 7;
					goto IL_004d;
				}
				num = 26;
				array = null;
				goto end_IL_0000;
				IL_03f4:
				Class22.smethod_4(stream, 355, 325);
				stream = null;
				array = array2;
				goto end_IL_0000;
				IL_004d:
				stream = new Stream0(buffer);
				array2 = new byte[0];
				num2 = stream.method_3();
				if (num2 == 67324752)
				{
					num = 9;
					num3 = (short)stream.method_2();
					num4 = stream.method_2();
					num5 = stream.method_2();
					num = 23;
					if (num2 == 67324752)
					{
						num = 15;
						if (num3 == 20)
						{
							num = 8;
							if (num4 == 0)
							{
								num = 27;
								if (num5 == 8)
								{
									num = 13;
									stream.method_3();
									stream.method_3();
									stream.method_3();
									num6 = stream.method_3();
									num = 25;
									num7 = stream.method_2();
									num8 = stream.method_2();
									if (num7 > 0)
									{
										num = 1;
										array3 = new byte[num7];
										SecurityExceptionEventArgs.smethod_2(stream, array3, 0, num7, 136, 221);
										num = 32;
									}
									else
									{
										num = 32;
									}
									if (num8 > 0)
									{
										num = 18;
										array4 = new byte[num8];
										SecurityExceptionEventArgs.smethod_2(stream, array4, 0, num8, 710, 659);
										num = 21;
									}
									else
									{
										num = 21;
									}
									array5 = new byte[Class5.smethod_2(stream, 507, 466) - Class5.smethod_2(stream, 737, 715)];
									num = 5;
									SecurityExceptionEventArgs.smethod_2(stream, array5, 0, array5.Length, 186, 239);
									num = 2;
									@class = new Class6(array5);
									array2 = new byte[num6];
									@class.method_2(array2, 0, array2.Length);
									num = 14;
									array5 = null;
									goto IL_03f4;
								}
								num = 4;
							}
							else
							{
								num = 4;
							}
						}
						else
						{
							num = 4;
						}
					}
					else
					{
						num = 4;
					}
					throw new FormatException("Wrong Header Signature");
				}
				num = 31;
				num9 = num2 >> 24;
				num2 -= num9 << 24;
				num = 29;
				if (num2 == 8223355)
				{
					num = 6;
					if (num9 == 1)
					{
						num = 0;
						num10 = stream.method_3();
						array2 = new byte[num10];
						num11 = 0;
						num = 3;
						while (num11 < num10)
						{
							num = 22;
							num12 = stream.method_3();
							num13 = stream.method_3();
							array6 = new byte[num12];
							SecurityExceptionEventArgs.smethod_2(stream, array6, 0, array6.Length, 906, 991);
							num = 28;
							class2 = new Class6(array6);
							class2.method_2(array2, num11, num13);
							num11 += num13;
							num = 3;
						}
						num = 20;
					}
					else
					{
						num = 20;
					}
					if (num9 == 2)
					{
						num = 17;
						byte[] array7 = new byte[8];
						UsageReportSender.smethod_10(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 966, 999);
						array8 = array7;
						byte[] array9 = new byte[8];
						UsageReportSender.smethod_10(array9, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 897, 928);
						array10 = array9;
						num = 33;
						dESCryptoIndirector = new DESCryptoIndirector();
						try
						{
							num14 = 4;
							dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(array8, array10, decrypt: true);
							try
							{
								num15 = 3;
								array11 = dESCryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
								num15 = 5;
								array2 = Unzip(array11);
							}
							finally
							{
								num16 = 4;
								dESCryptoTransform?.Dispose();
							}
							num17 = 2;
						}
						finally
						{
							num18 = 2;
							((IDisposable)dESCryptoIndirector)?.Dispose();
						}
					}
					num19 = 5;
					if (num9 == 3)
					{
						num19 = 3;
						byte[] array12 = new byte[16];
						UsageReportSender.smethod_10(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 638, 607);
						array13 = array12;
						byte[] array14 = new byte[16];
						UsageReportSender.smethod_10(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 803, 770);
						array15 = array14;
						num19 = 2;
						aESCryptoIndirector = new AESCryptoIndirector();
						try
						{
							num20 = 4;
							aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(array13, array15, decrypt: true);
							try
							{
								num21 = 2;
								array16 = aESCryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
								num21 = 1;
								array2 = Unzip(array16);
							}
							finally
							{
								num22 = 1;
								aESCryptoTransform?.Dispose();
							}
							num23 = 4;
						}
						finally
						{
							num24 = 6;
							((IDisposable)aESCryptoIndirector)?.Dispose();
						}
					}
					goto IL_03f4;
				}
				num25 = 0;
				throw new FormatException("Unknown Header");
				end_IL_0000:;
			}
			catch (Exception caughtException)
			{
				array17 = new object[33]
				{
					assembly, assembly2, stream, array2, num2, num3, num4, num5, num6, num7,
					num8, array3, array4, array5, @class, num9, num10, num11, num12, num13,
					class2, array6, array8, array10, dESCryptoIndirector, dESCryptoTransform, array11, array13, array15, aESCryptoIndirector,
					aESCryptoTransform, array16, buffer
				};
				StackFrameHelper.CreateExceptionN(caughtException, array17);
				throw;
			}
			num26 = 1;
			return array;
		}
		catch (Exception caughtException2)
		{
			StackFrameHelper.CreateExceptionN(caughtException2, new object[49]
			{
				assembly, assembly2, stream, array2, num2, num3, num4, num5, num6, num7,
				num8, array3, array4, array5, @class, num9, num10, num11, num12, num13,
				class2, array6, array8, array10, dESCryptoIndirector, dESCryptoTransform, array11, array13, array15, aESCryptoIndirector,
				aESCryptoTransform, array16, array17, array, num, num14, num15, num16, num17, num18,
				num19, num20, num21, num22, num23, num24, num25, num26, buffer
			});
			throw;
		}
	}

	public static byte[] Zip(byte[] buffer)
	{
		byte[] array = default(byte[]);
		try
		{
			try
			{
				array = smethod_1(buffer, 1, null, null);
				return array;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, buffer);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, array, buffer);
			throw;
		}
	}

	public static byte[] ZipAndEncrypt(byte[] buffer, byte[] key, byte[] iv)
	{
		byte[] array = default(byte[]);
		try
		{
			try
			{
				array = smethod_1(buffer, 2, key, iv);
				return array;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, buffer, key, iv);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, array, buffer, key, iv);
			throw;
		}
	}

	public static byte[] ZipAndAES(byte[] buffer, byte[] key, byte[] iv)
	{
		byte[] array = default(byte[]);
		try
		{
			try
			{
				array = smethod_1(buffer, 3, key, iv);
				return array;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, buffer, key, iv);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, array, buffer, key, iv);
			throw;
		}
	}

	private static byte[] smethod_1(byte[] byte_2, int int_0, byte[] byte_3, byte[] byte_4)
	{
		int num = default(int);
		Stream0 stream = default(Stream0);
		Class11 @class = default(Class11);
		DateTime dateTime_ = default(DateTime);
		long num2 = default(long);
		uint[] array2 = default(uint[]);
		uint num3 = default(uint);
		uint num4 = default(uint);
		int num5 = default(int);
		int num6 = default(int);
		long num7 = default(long);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num8 = default(int);
		byte[] array5 = default(byte[]);
		int num9 = default(int);
		long num10 = default(long);
		int num11 = default(int);
		byte[] array6 = default(byte[]);
		long num12 = default(long);
		Class11 class2 = default(Class11);
		byte[] array7 = default(byte[]);
		int num13 = default(int);
		byte[] array8 = default(byte[]);
		int num14 = default(int);
		long num15 = default(long);
		byte[] array9 = default(byte[]);
		DESCryptoIndirector dESCryptoIndirector = default(DESCryptoIndirector);
		int num16 = default(int);
		ICryptoTransform dESCryptoTransform = default(ICryptoTransform);
		int num17 = default(int);
		byte[] array10 = default(byte[]);
		int num18 = default(int);
		int num19 = default(int);
		int num20 = default(int);
		int num21 = default(int);
		byte[] array11 = default(byte[]);
		AESCryptoIndirector aESCryptoIndirector = default(AESCryptoIndirector);
		int num22 = default(int);
		ICryptoTransform aESCryptoTransform = default(ICryptoTransform);
		int num23 = default(int);
		byte[] array12 = default(byte[]);
		int num24 = default(int);
		int num25 = default(int);
		int num26 = default(int);
		int num27 = default(int);
		byte[] array13 = default(byte[]);
		Exception ex2 = default(Exception);
		int num28 = default(int);
		byte[] array14 = default(byte[]);
		object[] array15 = default(object[]);
		int num29 = default(int);
		try
		{
			try
			{
				try
				{
					num = 9;
					stream = new Stream0();
					if (int_0 == 0)
					{
						num = 7;
						@class = new Class11();
						dateTime_ = UsageReportSender.smethod_9(208, 194);
						num2 = (uint)((((Class4.smethod_2(ref dateTime_, 776, 871) - 1980) & 0x7F) << 25) | (Class40.smethod_2(ref dateTime_, 781, 835) << 21) | (PoweredByAttribute1.smethod_0(ref dateTime_, 993, 918) << 16) | (PoweredByAttribute1.smethod_0(ref dateTime_, 778, 882) << 11) | (Class24.smethod_0(ref dateTime_, 113, 15) << 5) | (int)((uint)Class4.smethod_2(ref dateTime_, 339, 291) >> 1));
						num = 28;
						uint[] array = new uint[256];
						UsageReportSender.smethod_10(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 819, 786);
						array2 = array;
						num3 = uint.MaxValue;
						num = 33;
						num4 = uint.MaxValue;
						num5 = 0;
						num6 = byte_2.Length;
						num = 52;
						while (--num6 >= 0)
						{
							num = 22;
							num4 = array2[(num4 ^ byte_2[num5++]) & 0xFF] ^ (num4 >> 8);
							num = 52;
						}
						num = 49;
						num4 ^= num3;
						stream.method_1(67324752);
						stream.method_0(20);
						num = 1;
						stream.method_0(0);
						stream.method_0(8);
						stream.method_1((int)num2);
						num = 39;
						stream.method_1((int)num4);
						num7 = Class5.smethod_2(stream, 399, 421);
						stream.method_1(0);
						num = 12;
						stream.method_1(byte_2.Length);
						array3 = Class28.smethod_3(Class33.smethod_0(596, 521), "{data}", 631, 513);
						num = 13;
						stream.method_0(array3.Length);
						stream.method_0(0);
						ReportSender1.smethod_1(stream, array3, 0, array3.Length, 26, 100);
						num = 24;
						@class.method_4(byte_2);
						num = 25;
						while (true)
						{
							if (!@class.method_3())
							{
								num = 31;
								array4 = new byte[512];
								num8 = @class.method_5(array4);
								if (num8 > 0)
								{
									num = 27;
									ReportSender1.smethod_1(stream, array4, 0, num8, 897, 1023);
									continue;
								}
								num = 30;
								break;
							}
							num = 30;
							break;
						}
						@class.method_1();
						num = 32;
						while (true)
						{
							if (!@class.method_2())
							{
								num = 47;
								array5 = new byte[512];
								num9 = @class.method_5(array5);
								if (num9 > 0)
								{
									num = 35;
									ReportSender1.smethod_1(stream, array5, 0, num9, 432, 462);
									continue;
								}
								num = 6;
								break;
							}
							num = 6;
							break;
						}
						num10 = @class.method_0();
						stream.method_1(33639248);
						stream.method_0(20);
						stream.method_0(20);
						num = 26;
						stream.method_0(0);
						stream.method_0(8);
						stream.method_1((int)num2);
						num = 50;
						stream.method_1((int)num4);
						stream.method_1((int)num10);
						stream.method_1(byte_2.Length);
						num = 19;
						stream.method_0(array3.Length);
						stream.method_0(0);
						stream.method_0(0);
						num = 21;
						stream.method_0(0);
						stream.method_0(0);
						stream.method_1(0);
						stream.method_1(0);
						num = 44;
						ReportSender1.smethod_1(stream, array3, 0, array3.Length, 794, 868);
						num = 37;
						stream.method_1(101010256);
						stream.method_0(0);
						stream.method_0(0);
						stream.method_0(1);
						num = 36;
						stream.method_0(1);
						stream.method_1(46 + array3.Length);
						num = 46;
						stream.method_1((int)(30 + array3.Length + num10));
						num = 4;
						stream.method_0(0);
						Class22.smethod_5(stream, num7, SeekOrigin.Begin, 958, 927);
						num = 42;
						stream.method_1((int)num10);
					}
					else
					{
						num = 53;
						if (int_0 == 1)
						{
							num = 8;
							stream.method_1(25000571);
							stream.method_1(byte_2.Length);
							num11 = 0;
							num = 38;
							while (num11 < byte_2.Length)
							{
								num = 17;
								array6 = new byte[Class3.smethod_4(2097151, byte_2.Length - num11, 269, 376)];
								num = 10;
								AppPathFinder.smethod_0(byte_2, num11, array6, 0, array6.Length, 727, 716);
								num = 11;
								num12 = Class5.smethod_2(stream, 750, 708);
								stream.method_1(0);
								stream.method_1(array6.Length);
								num = 2;
								class2 = new Class11();
								class2.method_4(array6);
								num = 40;
								while (true)
								{
									if (!class2.method_3())
									{
										num = 23;
										array7 = new byte[512];
										num13 = class2.method_5(array7);
										if (num13 > 0)
										{
											num = 41;
											ReportSender1.smethod_1(stream, array7, 0, num13, 1012, 906);
											continue;
										}
										num = 3;
										break;
									}
									num = 3;
									break;
								}
								class2.method_1();
								num = 18;
								while (true)
								{
									if (!class2.method_2())
									{
										num = 14;
										array8 = new byte[512];
										num14 = class2.method_5(array8);
										if (num14 > 0)
										{
											num = 16;
											ReportSender1.smethod_1(stream, array8, 0, num14, 635, 517);
											continue;
										}
										num = 43;
										break;
									}
									num = 43;
									break;
								}
								num15 = Class5.smethod_2(stream, 258, 296);
								ReportExceptionEventArgs.smethod_0(stream, num12, 789, 795);
								num = 29;
								stream.method_1((int)class2.method_0());
								ReportExceptionEventArgs.smethod_0(stream, num15, 106, 100);
								num = 5;
								num11 += array6.Length;
								num = 38;
							}
							num = 15;
						}
						else
						{
							num = 51;
							if (int_0 == 2)
							{
								num = 34;
								stream.method_1(41777787);
								array9 = smethod_1(byte_2, 1, null, null);
								dESCryptoIndirector = new DESCryptoIndirector();
								try
								{
									num16 = 0;
									dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(byte_3, byte_4, decrypt: false);
									try
									{
										num17 = 3;
										array10 = dESCryptoTransform.TransformFinalBlock(array9, 0, array9.Length);
										ReportSender1.smethod_1(stream, array10, 0, array10.Length, 297, 343);
									}
									finally
									{
										num18 = 0;
										dESCryptoTransform?.Dispose();
									}
									num19 = 2;
								}
								finally
								{
									num20 = 5;
									((IDisposable)dESCryptoIndirector)?.Dispose();
								}
							}
							else
							{
								num21 = 5;
								if (int_0 == 3)
								{
									num21 = 0;
									stream.method_1(58555003);
									array11 = smethod_1(byte_2, 1, null, null);
									aESCryptoIndirector = new AESCryptoIndirector();
									try
									{
										num22 = 4;
										aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(byte_3, byte_4, decrypt: false);
										try
										{
											num23 = 1;
											array12 = aESCryptoTransform.TransformFinalBlock(array11, 0, array11.Length);
											ReportSender1.smethod_1(stream, array12, 0, array12.Length, 431, 465);
										}
										finally
										{
											num24 = 4;
											aESCryptoTransform?.Dispose();
										}
										num25 = 0;
									}
									finally
									{
										num26 = 4;
										((IDisposable)aESCryptoIndirector)?.Dispose();
									}
								}
							}
						}
					}
					num27 = 2;
					MyApplication.smethod_0(stream, 389, 438);
					Class22.smethod_4(stream, 562, 532);
					num27 = 3;
					array13 = ConfirmFeatureUsageReportingForm_1.smethod_0(stream, 383, 361);
				}
				catch (Exception ex)
				{
					ex2 = ex;
					ExceptionMessage = Form0.smethod_1("ERR 2003: ", UsageReportSender.smethod_12(ex2, 75, 119), 54, 4);
					throw;
				}
				num28 = 0;
				array14 = array13;
			}
			catch (Exception caughtException)
			{
				array15 = new object[39]
				{
					stream, @class, dateTime_, num2, array2, num3, num4, num5, num6, num7,
					array3, array4, num8, array5, num9, num10, num11, array6, num12, class2,
					array7, num13, array8, num14, num15, array9, dESCryptoIndirector, dESCryptoTransform, array10, array11,
					aESCryptoIndirector, aESCryptoTransform, array12, ex2, array13, byte_2, int_0, byte_3, byte_4
				};
				StackFrameHelper.CreateExceptionN(caughtException, array15);
				throw;
			}
			num29 = 0;
			return array14;
		}
		catch (Exception caughtException2)
		{
			StackFrameHelper.CreateExceptionN(caughtException2, new object[56]
			{
				stream, @class, dateTime_, num2, array2, num3, num4, num5, num6, num7,
				array3, array4, num8, array5, num9, num10, num11, array6, num12, class2,
				array7, num13, array8, num14, num15, array9, dESCryptoIndirector, dESCryptoTransform, array10, array11,
				aESCryptoIndirector, aESCryptoTransform, array12, ex2, array13, array15, array14, num, num16, num17,
				num18, num19, num20, num21, num22, num23, num24, num25, num26, num27,
				num28, num29, byte_2, int_0, byte_3, byte_4
			});
			throw;
		}
	}

	public SimpleZip()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static SimpleZip()
	{
		char[] array = default(char[]);
		int num = default(int);
		char[] array2 = default(char[]);
		try
		{
			char_3 = new char[8];
			array = new char[8];
			array[0] = '\u2e55';
			array[3] = '\u1756';
			array[4] = '㭏';
			array[6] = '㕞';
			array[1] = 'ⴤ';
			array[2] = '⇅';
			array[5] = '⩱';
			array[7] = 'ᅪ';
			string_1 = new string[1];
			char_2 = array;
			num = 6;
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			char_1 = new char[877];
			array2 = new char[8];
			num = 2;
			array2[5] = 'ԣ';
			array2[3] = '㍘';
			array2[1] = '㳂';
			num = 0;
			array2[0] = 'ሀ';
			array2[7] = 'ᓘ';
			array2[4] = 'ም';
			num = 5;
			array2[2] = 'ዯ';
			array2[6] = '\u0654';
			string_0 = new string[32];
			num = 4;
			char_0 = array2;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, array2, num, array);
			throw;
		}
	}

	internal static bool smethod_2(string string_2, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 44:
					return File.Exists(string_2);
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_2, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_3(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 89:
					return type_0.IsPrimitive;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_4(Array array_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 127:
					return array_0.GetLength(int_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, array_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static StringBuilder smethod_5(StringBuilder stringBuilder_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 15:
					return stringBuilder_0.Append(int_0);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, stringBuilder_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static int smethod_6(string string_2, char char_4, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return string_2.IndexOf(char_4);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_2, char_4, int_0, int_1);
			throw;
		}
	}
}
