using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using ns0;

public sealed class GClass3 : GInterface1, GInterface2
{
	private sealed class Class2
	{
		internal Struct15 struct15_0 = default(Struct15);

		internal Struct15 struct15_1 = default(Struct15);

		internal Struct16[] struct16_0;

		internal Struct16[] struct16_1;

		internal Struct16 struct16_2;

		internal uint uint_0;

		public Class2()
		{
			Struct16[] o = (struct16_0 = new Struct16[16]);
			Struct16[] o2 = (struct16_1 = new Struct16[16]);
			Struct16 @struct = (struct16_2 = new Struct16(8));
			base._002Ector();
			try
			{
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, o, o2, @struct, this);
				throw;
			}
		}

		public void method_0(uint uint_1)
		{
			int num = default(int);
			int num2 = default(int);
			uint num3 = default(uint);
			uint num5 = default(uint);
			try
			{
				num = 4;
				num2 = 3;
				num = 12;
				while (true)
				{
					num = 7;
					while (true)
					{
						num3 = uint_0;
						num2 = 6;
						num = 12;
						while (true)
						{
							num = 5;
							int num4;
							if (num3 < uint_1)
							{
								num = 10;
								num4 = 1;
							}
							else
							{
								num = 8;
								num4 = 2;
							}
							num2 = num4;
							num = 12;
							switch (num2)
							{
							case 1:
							{
								num = 0;
								ref Struct16 reference = ref struct16_0[num3];
								reference = new Struct16(3);
								num2 = 8;
								num = 12;
								goto case 8;
							}
							case 5:
								num = 3;
								goto IL_0087;
							case 8:
							{
								num = 9;
								ref Struct16 reference2 = ref struct16_1[num3];
								reference2 = new Struct16(3);
								num2 = 4;
								num = 12;
								goto case 4;
							}
							case 4:
								num = 3;
								goto IL_0087;
							case 6:
								break;
							default:
								goto end_IL_009a;
							case 7:
								goto IL_00a9;
							case 3:
								goto end_IL_00ab;
							case 0:
								num = 1;
								goto IL_00c3;
							case 2:
								{
									num = 1;
									goto IL_00c3;
								}
								IL_00c3:
								num5 = (uint_0 = uint_1);
								return;
								IL_0087:
								num3++;
								num2 = 6;
								num = 12;
								break;
							}
							continue;
							end_IL_009a:
							break;
						}
						num = 7;
						continue;
						IL_00a9:
						num = 7;
						continue;
						end_IL_00ab:
						break;
					}
				}
			}
			catch (Exception exception)
			{
				int num6 = default(int);
				StackFrameHelper.CreateException7(exception, num3, num5, num2, num, num6, this, uint_1);
				throw;
			}
		}

		public void method_1()
		{
			int num = default(int);
			int num2 = default(int);
			uint num3 = default(uint);
			try
			{
				num = 12;
				num2 = 1;
				num = 2;
				while (true)
				{
					num = 7;
					while (true)
					{
						struct15_0.method_0();
						num3 = 0u;
						num2 = 2;
						num = 2;
						while (true)
						{
							num = 10;
							int num4;
							if (num3 < uint_0)
							{
								num = 3;
								num4 = 4;
							}
							else
							{
								num = 5;
								num4 = 0;
							}
							num2 = num4;
							num = 2;
							switch (num2)
							{
							case 4:
								num = 0;
								struct16_0[num3].method_0();
								struct16_1[num3].method_0();
								goto IL_0068;
							case 5:
								num = 4;
								goto IL_0068;
							case 7:
								num = 4;
								goto IL_0068;
							case 6:
								num = 1;
								num3++;
								num2 = 2;
								num = 2;
								break;
							case 2:
								break;
							default:
								goto end_IL_007d;
							case 3:
								goto IL_008f;
							case 1:
								goto end_IL_0091;
							case 0:
								{
									num = 6;
									struct15_1.method_0();
									struct16_2.method_0();
									return;
								}
								IL_0068:
								num2 = 6;
								num = 2;
								goto case 6;
							}
							continue;
							end_IL_007d:
							break;
						}
						num = 7;
						continue;
						IL_008f:
						num = 7;
						continue;
						end_IL_0091:
						break;
					}
				}
			}
			catch (Exception exception)
			{
				int num5 = default(int);
				StackFrameHelper.CreateException5(exception, num3, num2, num, num5, this);
				throw;
			}
		}

		public uint method_2(Class5 class5_0, uint uint_1)
		{
			int num = default(int);
			int num3 = default(int);
			uint num4 = default(uint);
			try
			{
				num = 5;
				while (true)
				{
					int num2;
					if (struct15_0.method_1(class5_0) != 0)
					{
						num = 9;
						num2 = 5;
					}
					else
					{
						num = 15;
						num2 = 8;
					}
					num3 = num2;
					num = 1;
					while (true)
					{
						int num5;
						switch (num3)
						{
						case 5:
							num = 3;
							num4 = 8u;
							if (struct15_1.method_1(class5_0) == 0)
							{
								num = 18;
								num5 = 3;
							}
							else
							{
								num = 2;
								num5 = 6;
							}
							goto IL_0028;
						default:
							num = 8;
							goto IL_005f;
						case 2:
							num = 8;
							goto IL_005f;
						case 0:
							goto end_IL_002b;
						case 1:
							num = 7;
							goto IL_00cb;
						case 3:
							num = 14;
							num4 += struct16_1[uint_1].method_1(class5_0);
							num = 13;
							num3 = 7;
							num = 1;
							break;
						case 4:
							num = 4;
							goto IL_00ad;
						case 6:
							num = 6;
							goto IL_00c5;
						case 8:
							num = 4;
							goto IL_00ad;
						case 9:
							num = 6;
							goto IL_00c5;
						case 7:
							break;
							IL_00c5:
							num4 += 8;
							num = 7;
							goto IL_00cb;
							IL_00ad:
							return struct16_0[uint_1].method_1(class5_0);
							IL_00cb:
							num4 += struct16_2.method_1(class5_0);
							num3 = 7;
							num = 1;
							break;
							IL_005f:
							num3 = 0;
							num = 1;
							goto end_IL_002b;
						}
						num = 12;
						return num4;
						IL_0028:
						num3 = num5;
						num = 1;
						continue;
						end_IL_002b:
						break;
					}
					num = 5;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, num4, num3, num, this, class5_0, uint_1);
				throw;
			}
		}

		static Class2()
		{
			try
			{
				Exception1.smethod_3();
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}
	}

	private sealed class Class3
	{
		private struct Struct12
		{
			internal Struct15[] struct15_0;

			public void method_0()
			{
				Struct15[] o = default(Struct15[]);
				try
				{
					o = (struct15_0 = new Struct15[768]);
				}
				catch (Exception exception)
				{
					int num = default(int);
					StackFrameHelper.CreateException3(exception, o, num, this);
					throw;
				}
			}

			public void method_1()
			{
				int num = default(int);
				int num2 = default(int);
				int num3 = default(int);
				try
				{
					num = 5;
					num2 = 4;
					num = 3;
					while (true)
					{
						num = 0;
						while (true)
						{
							num3 = 0;
							num = 9;
							while (true)
							{
								num2 = 2;
								num = 3;
								while (true)
								{
									num = 2;
									int num4;
									if (num3 < 768)
									{
										num = 11;
										num4 = 5;
									}
									else
									{
										num = 7;
										num4 = 0;
									}
									num2 = num4;
									num = 3;
									switch (num2)
									{
									case 1:
										num = 8;
										goto IL_004b;
									case 5:
										num = 12;
										struct15_0[num3].method_0();
										goto IL_004b;
									case 2:
										break;
									case 3:
										goto end_IL_005a;
									default:
										goto end_IL_0069;
									case 6:
										goto IL_0073;
									case 4:
										goto end_IL_0075;
									case 0:
										{
											num = 4;
											return;
										}
										IL_004b:
										num3++;
										num2 = 2;
										num = 3;
										break;
									}
									continue;
									end_IL_005a:
									break;
								}
								num = 9;
								continue;
								end_IL_0069:
								break;
							}
							num = 0;
							continue;
							IL_0073:
							num = 0;
							continue;
							end_IL_0075:
							break;
						}
					}
				}
				catch (Exception exception)
				{
					int num5 = default(int);
					StackFrameHelper.CreateException5(exception, num3, num2, num, num5, this);
					throw;
				}
			}

			public byte method_2(Class5 class5_0)
			{
				int num = default(int);
				uint num2 = default(uint);
				int num3 = default(int);
				try
				{
					num = 0;
					while (true)
					{
						num2 = 1u;
						num3 = 1;
						num = 3;
						while (true)
						{
							num = 5;
							num2 = (num2 << 1) | struct15_0[num2].method_1(class5_0);
							num = 12;
							while (true)
							{
								num3 = 6;
								num = 3;
								while (true)
								{
									num = 10;
									int num4;
									if (num2 < 256)
									{
										num = 2;
										num4 = 1;
									}
									else
									{
										num = 4;
										num4 = 3;
									}
									num3 = num4;
									num = 3;
									switch (num3)
									{
									case 6:
										continue;
									case 4:
										goto end_IL_0037;
									case 1:
										break;
									default:
										num = 7;
										goto IL_0076;
									case 0:
										num = 7;
										goto IL_0076;
									case 2:
										num = 7;
										goto IL_0076;
									case 7:
										goto end_IL_004d;
									case 3:
										num = 9;
										goto IL_008c;
									case 5:
										{
											num = 9;
											goto IL_008c;
										}
										IL_008c:
										return (byte)num2;
										IL_0076:
										num3 = 7;
										num = 3;
										goto end_IL_004d;
									}
									goto end_IL_0047;
									continue;
									end_IL_0037:
									break;
								}
								num = 12;
								continue;
								end_IL_0047:
								break;
							}
							continue;
							end_IL_004d:
							break;
						}
						num = 0;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, num2, num3, num, this, class5_0);
					throw;
				}
			}

			public byte method_3(Class5 class5_0, byte byte_0)
			{
				int num = default(int);
				uint num2 = default(uint);
				int num3 = default(int);
				uint num4 = default(uint);
				uint num5 = default(uint);
				try
				{
					num = 10;
					while (true)
					{
						num2 = 1u;
						num3 = 4;
						num = 12;
						while (true)
						{
							num = 1;
							num4 = (uint)(byte_0 >> 7) & 1u;
							byte_0 = (byte)(byte_0 << 1);
							num = 17;
							num3 = 0;
							num = 12;
							while (true)
							{
								num = 25;
								num5 = struct15_0[(1 + num4 << 8) + num2].method_1(class5_0);
								num = 8;
								num3 = 5;
								num = 12;
								while (true)
								{
									num = 0;
									num2 = (num2 << 1) | num5;
									int num6;
									if (num4 == num5)
									{
										num = 5;
										num6 = 13;
									}
									else
									{
										num = 19;
										num6 = 12;
									}
									num3 = num6;
									num = 12;
									while (true)
									{
										switch (num3)
										{
										case 13:
										{
											num = 9;
											int num8;
											if (num2 >= 256)
											{
												num = 24;
												num8 = 11;
											}
											else
											{
												num = 16;
												num8 = 4;
											}
											num3 = num8;
											num = 12;
											continue;
										}
										case 12:
											num = 23;
											goto IL_0031;
										case 7:
										{
											num = 21;
											int num7;
											if (num2 >= 256)
											{
												num = 3;
												num7 = 8;
											}
											else
											{
												num = 22;
												num7 = 10;
											}
											num3 = num7;
											num = 12;
											continue;
										}
										case 10:
											num = 2;
											num2 = (num2 << 1) | struct15_0[num2].method_1(class5_0);
											num = 11;
											num3 = 7;
											num = 12;
											goto case 7;
										case 6:
											num = 23;
											goto IL_0031;
										case 2:
											num = 23;
											goto IL_0031;
										case 1:
											num = 23;
											goto IL_0031;
										case 5:
											break;
										case 0:
											goto end_IL_00ce;
										case 4:
											goto end_IL_00e1;
										default:
											num = 7;
											goto IL_0128;
										case 3:
											num = 7;
											goto IL_0128;
										case 9:
											num = 10;
											goto end_IL_0108;
										case 8:
											num = 15;
											num3 = 11;
											num = 12;
											goto case 11;
										case 11:
											{
												num = 20;
												return (byte)num2;
											}
											IL_0128:
											num3 = 9;
											num = 12;
											goto case 9;
											IL_0031:
											num3 = 7;
											num = 12;
											goto case 7;
										}
										break;
									}
									continue;
									end_IL_00ce:
									break;
								}
								continue;
								end_IL_00e1:
								break;
							}
							continue;
							end_IL_0108:
							break;
						}
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException8(exception, num2, num4, num5, num3, num, this, class5_0, byte_0);
					throw;
				}
			}

			static Struct12()
			{
				try
				{
					Exception1.smethod_3();
				}
				catch (Exception exception)
				{
					int num = default(int);
					StackFrameHelper.CreateException1(exception, num);
					throw;
				}
			}
		}

		internal Struct12[] struct12_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		public Class3()
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

		public void method_0(int int_2, int int_3)
		{
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			uint num4 = default(uint);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			uint num8 = default(uint);
			Struct12[] array = default(Struct12[]);
			uint num9 = default(uint);
			try
			{
				num = 11;
				num2 = 6;
				num = 9;
				if (struct12_0 != null)
				{
					num = 2;
					num2 = 5;
					num = 9;
					if (int_0 == int_3)
					{
						num = 8;
						num2 = 0;
						num = 9;
						if (int_1 == int_2)
						{
							num = 0;
							num2 = 4;
							num = 9;
							return;
						}
					}
				}
				while (true)
				{
					num3 = (int_1 = int_2);
					num4 = (uint_0 = (uint)((1 << int_2) - 1));
					num5 = 20;
					num6 = 3;
					num5 = 11;
					while (true)
					{
						num5 = 16;
						num7 = (int_0 = int_3);
						num5 = 3;
						while (true)
						{
							num8 = (uint)(1 << int_0 + int_1);
							num5 = 18;
							num6 = 8;
							num5 = 11;
							while (true)
							{
								num5 = 9;
								array = (struct12_0 = new Struct12[num8]);
								num9 = 0u;
								num5 = 17;
								num6 = 6;
								num5 = 11;
								while (true)
								{
									num5 = 6;
									int num10;
									if (num9 < num8)
									{
										num5 = 4;
										num10 = 7;
									}
									else
									{
										num5 = 13;
										num10 = 0;
									}
									num6 = num10;
									num5 = 11;
									switch (num6)
									{
									case 7:
										num5 = 7;
										struct12_0[num9].method_0();
										num9++;
										num5 = 19;
										num6 = 6;
										num5 = 11;
										break;
									case 6:
										break;
									case 8:
										goto end_IL_00ad;
									case 9:
										goto end_IL_00b6;
									case 3:
										goto end_IL_00da;
									case 5:
										goto end_IL_00f8;
									default:
										num5 = 5;
										goto IL_014c;
									case 0:
										num5 = 15;
										return;
									case 1:
										num5 = 15;
										return;
									case 2:
										num5 = 10;
										return;
									case 4:
										{
											num5 = 5;
											goto IL_014c;
										}
										IL_014c:
										num5 = 10;
										return;
									}
									continue;
									end_IL_00ad:
									break;
								}
								continue;
								end_IL_00b6:
								break;
							}
							num5 = 3;
							continue;
							end_IL_00da:
							break;
						}
						continue;
						end_IL_00f8:
						break;
					}
					num5 = 8;
				}
			}
			catch (Exception caughtException)
			{
				StackFrameHelper.CreateExceptionN(caughtException, new object[13]
				{
					num8, num9, num3, num4, num7, array, num2, num6, num, num5,
					this, int_2, int_3
				});
				throw;
			}
		}

		public void method_1()
		{
			int num = default(int);
			int num2 = default(int);
			uint num3 = default(uint);
			uint num4 = default(uint);
			try
			{
				num = 6;
				num2 = 0;
				num = 4;
				while (true)
				{
					num = 7;
					while (true)
					{
						num3 = (uint)(1 << int_0 + int_1);
						num = 1;
						while (true)
						{
							num2 = 1;
							num = 4;
							while (true)
							{
								num = 3;
								num4 = 0u;
								num2 = 3;
								num = 4;
								while (true)
								{
									num = 8;
									int num5;
									if (num4 < num3)
									{
										num = 11;
										num5 = 5;
									}
									else
									{
										num = 12;
										num5 = 4;
									}
									num2 = num5;
									num = 4;
									switch (num2)
									{
									case 5:
										num = 13;
										struct12_0[num4].method_1();
										goto IL_0054;
									case 7:
										num = 10;
										goto IL_0054;
									case 3:
										break;
									case 1:
										goto end_IL_0064;
									case 6:
										goto end_IL_006c;
									default:
										goto end_IL_0078;
									case 2:
										goto IL_0082;
									case 0:
										goto end_IL_0084;
									case 4:
										{
											num = 5;
											return;
										}
										IL_0054:
										num4++;
										num2 = 3;
										num = 4;
										break;
									}
									continue;
									end_IL_0064:
									break;
								}
								continue;
								end_IL_006c:
								break;
							}
							num = 1;
							continue;
							end_IL_0078:
							break;
						}
						num = 7;
						continue;
						IL_0082:
						num = 7;
						continue;
						end_IL_0084:
						break;
					}
				}
			}
			catch (Exception exception)
			{
				int num6 = default(int);
				StackFrameHelper.CreateException6(exception, num3, num4, num2, num, num6, this);
				throw;
			}
		}

		private uint method_2(uint uint_1, byte byte_0)
		{
			int num = default(int);
			try
			{
				num = 7;
				return ((uint_1 & uint_0) << int_0) + (uint)(byte_0 >> 8 - int_0);
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException5(exception, num2, num, this, uint_1, byte_0);
				throw;
			}
		}

		public byte method_3(Class5 class5_0, uint uint_1, byte byte_0)
		{
			int num = default(int);
			try
			{
				num = 6;
				return struct12_0[method_2(uint_1, byte_0)].method_2(class5_0);
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException6(exception, num2, num, this, class5_0, uint_1, byte_0);
				throw;
			}
		}

		public byte method_4(Class5 class5_0, uint uint_1, byte byte_0, byte byte_1)
		{
			int num = default(int);
			try
			{
				num = 1;
				return struct12_0[method_2(uint_1, byte_0)].method_3(class5_0, byte_1);
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException7(exception, num2, num, this, class5_0, uint_1, byte_0, byte_1);
				throw;
			}
		}

		static Class3()
		{
			try
			{
				Exception1.smethod_3();
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}
	}

	private Class2 class2_0;

	private Class2 class2_1;

	private Class3 class3_0;

	internal GClass2 gclass2_0;

	internal Class5 class5_0;

	internal Struct15[] struct15_0;

	internal Struct15[] struct15_1;

	internal Struct15[] struct15_2;

	internal Struct15[] struct15_3;

	internal Struct15[] struct15_4;

	internal Struct15[] struct15_5;

	internal Struct16[] struct16_0;

	internal Struct15[] struct15_6;

	internal Struct16 struct16_1;

	internal uint uint_0;

	internal uint uint_1;

	internal uint uint_2;

	public GClass3()
	{
		GClass2 gClass = (gclass2_0 = new GClass2());
		Class5 @class = (class5_0 = new Class5());
		Struct15[] array = (struct15_0 = new Struct15[192]);
		Struct15[] array2 = (struct15_1 = new Struct15[12]);
		Struct15[] array3 = (struct15_2 = new Struct15[12]);
		Struct15[] array4 = (struct15_3 = new Struct15[12]);
		Struct15[] array5 = (struct15_4 = new Struct15[12]);
		Struct15[] array6 = (struct15_5 = new Struct15[192]);
		Struct16[] array7 = (struct16_0 = new Struct16[4]);
		Struct15[] array8 = (struct15_6 = new Struct15[114]);
		Struct16 @struct = (struct16_1 = new Struct16(4));
		class2_0 = new Class2();
		class2_1 = new Class2();
		class3_0 = new Class3();
		base._002Ector();
		uint num = default(uint);
		int i = default(int);
		try
		{
			num = uint.MaxValue;
			uint_0 = uint.MaxValue;
			for (i = 0; i < 4L; i++)
			{
				ref Struct16 reference = ref struct16_0[i];
				reference = new Struct16(6);
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[14]
			{
				i, gClass, @class, array, array2, array3, array4, array5, array6, array7,
				array8, @struct, num, this
			});
			throw;
		}
	}

	private void method_0(uint uint_3)
	{
		int num = default(int);
		int num2 = default(int);
		uint num4 = default(uint);
		uint num5 = default(uint);
		uint num6 = default(uint);
		try
		{
			num = 2;
			num2 = 5;
			num = 12;
			while (true)
			{
				num = 0;
				while (true)
				{
					int num3;
					if (uint_0 == uint_3)
					{
						num = 9;
						num3 = 6;
					}
					else
					{
						num = 7;
						num3 = 7;
					}
					num2 = num3;
					num = 12;
					switch (num2)
					{
					default:
						num = 0;
						continue;
					case 3:
						num = 0;
						continue;
					case 5:
						break;
					case 2:
						num = 10;
						goto IL_00b9;
					case 4:
						num = 11;
						goto IL_0096;
					case 6:
						num = 8;
						return;
					case 7:
						num = 5;
						num4 = (uint_0 = uint_3);
						num5 = (uint_1 = Exception0.smethod_6(uint_0, 1u, 817, 884));
						num = 4;
						num2 = 1;
						num = 12;
						goto case 1;
					case 1:
						num = 11;
						goto IL_0096;
					case 0:
						{
							num = 10;
							goto IL_00b9;
						}
						IL_0096:
						num6 = Exception0.smethod_6(uint_1, 4096u, 453, 384);
						num2 = 0;
						num = 12;
						goto case 0;
						IL_00b9:
						gclass2_0.method_0(num6);
						return;
					}
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num7 = default(int);
			StackFrameHelper.CreateException8(exception, num6, num4, num5, num2, num, num7, this, uint_3);
			throw;
		}
	}

	private void method_1(int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 5;
			num2 = 2;
			num = 11;
			while (true)
			{
				num = 7;
				while (true)
				{
					int num3;
					if (int_0 <= 8)
					{
						num = 6;
						num3 = 1;
					}
					else
					{
						num = 3;
						num3 = 7;
					}
					num2 = num3;
					num = 11;
					while (true)
					{
						int num4;
						switch (num2)
						{
						case 5:
							num = 13;
							goto IL_0015;
						case 3:
							num = 13;
							goto IL_0015;
						case 1:
							num = 13;
							goto IL_0015;
						default:
							goto end_IL_0032;
						case 2:
							break;
						case 0:
							num = 4;
							class3_0.method_0(int_0, int_1);
							return;
						case 4:
							num = 8;
							throw new Exception1();
						case 6:
							num = 0;
							return;
						case 7:
							{
								num = 14;
								throw new Exception1();
							}
							IL_0015:
							if (int_1 > 8)
							{
								num = 10;
								num4 = 4;
							}
							else
							{
								num = 1;
								num4 = 0;
							}
							goto IL_0022;
						}
						goto end_IL_0061;
						IL_0022:
						num2 = num4;
						num = 11;
						continue;
						end_IL_0032:
						break;
					}
					num = 7;
					continue;
					end_IL_0061:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num5 = default(int);
			StackFrameHelper.CreateException6(exception, num2, num, num5, this, int_0, int_1);
			throw;
		}
	}

	private void method_2(int int_0)
	{
		int num = default(int);
		int num2 = default(int);
		uint num4 = default(uint);
		uint num5 = default(uint);
		try
		{
			num = 7;
			num2 = 6;
			num = 2;
			while (true)
			{
				num = 6;
				while (true)
				{
					int num3;
					if (int_0 <= 4)
					{
						num = 0;
						num3 = 1;
					}
					else
					{
						num = 5;
						num3 = 2;
					}
					num2 = num3;
					num = 2;
					switch (num2)
					{
					default:
						goto IL_0030;
					case 6:
						break;
					case 1:
						num = 9;
						num4 = (uint)(1 << int_0);
						num = 12;
						goto IL_0059;
					case 2:
						num = 8;
						goto IL_007b;
					case 3:
						num = 12;
						goto IL_0059;
					case 0:
						num = 1;
						class2_1.method_0(num4);
						goto IL_0084;
					case 4:
						num = 8;
						goto IL_007b;
					case 5:
						{
							num = 11;
							goto IL_0084;
						}
						IL_007b:
						throw new Exception1();
						IL_0059:
						class2_0.method_0(num4);
						num2 = 0;
						num = 2;
						goto case 0;
						IL_0084:
						num5 = (uint_2 = num4 - 1);
						return;
					}
					break;
					IL_0030:
					num = 6;
				}
			}
		}
		catch (Exception exception)
		{
			int num6 = default(int);
			StackFrameHelper.CreateException7(exception, num4, num5, num2, num, num6, this, int_0);
			throw;
		}
	}

	private void method_3(Stream stream_0, Stream stream_1)
	{
		int num = default(int);
		int num2 = default(int);
		uint num3 = default(uint);
		uint num9 = default(uint);
		uint num5 = default(uint);
		try
		{
			num = 31;
			num2 = 7;
			num = 4;
			while (true)
			{
				num = 37;
				while (true)
				{
					class5_0.method_0(stream_0);
					gclass2_0.method_2(stream_1);
					num = 3;
					num2 = 12;
					num = 4;
					while (true)
					{
						num = 15;
						num3 = 0u;
						num2 = 8;
						num = 4;
						while (true)
						{
							num = 36;
							int num4;
							if (num3 < 12)
							{
								num = 23;
								num4 = 6;
							}
							else
							{
								num = 38;
								num4 = 14;
							}
							num2 = num4;
							num = 4;
							while (true)
							{
								switch (num2)
								{
								case 19:
									num = 19;
									struct16_0[num3].method_0();
									num3++;
									num = 21;
									num2 = 3;
									num = 4;
									goto case 3;
								case 3:
								{
									num = 16;
									int num7;
									if (num3 >= 4)
									{
										num = 20;
										num7 = 2;
									}
									else
									{
										num = 27;
										num7 = 19;
									}
									num2 = num7;
									num = 4;
									continue;
								}
								case 18:
									num = 22;
									num9 = (num3 << 4) + num5;
									struct15_0[num9].method_0();
									num = 13;
									num2 = 16;
									num = 4;
									goto case 16;
								case 16:
									num = 0;
									struct15_5[num9].method_0();
									num5++;
									num = 11;
									num2 = 17;
									num = 4;
									goto case 17;
								case 17:
								{
									num = 18;
									int num8;
									if (num5 > uint_2)
									{
										num = 30;
										num8 = 15;
									}
									else
									{
										num = 9;
										num8 = 18;
									}
									num2 = num8;
									num = 4;
									continue;
								}
								case 14:
									num = 29;
									class3_0.method_1();
									goto IL_00c3;
								case 11:
									num = 28;
									struct15_6[num3].method_0();
									num3++;
									num = 26;
									num2 = 0;
									num = 4;
									goto case 0;
								case 0:
								{
									num = 32;
									int num6;
									if (num3 >= 114)
									{
										num = 34;
										num6 = 9;
									}
									else
									{
										num = 1;
										num6 = 11;
									}
									num2 = num6;
									num = 4;
									continue;
								}
								case 10:
									num = 7;
									goto IL_00c3;
								case 6:
									num = 14;
									num5 = 0u;
									num2 = 17;
									num = 4;
									goto case 17;
								case 2:
									num = 6;
									num3 = 0u;
									num = 12;
									goto IL_011d;
								case 1:
									num = 12;
									goto IL_011d;
								case 15:
									num = 24;
									struct15_1[num3].method_0();
									struct15_2[num3].method_0();
									num = 33;
									num2 = 13;
									num = 4;
									goto case 13;
								case 13:
									num = 5;
									struct15_3[num3].method_0();
									struct15_4[num3].method_0();
									num = 17;
									num2 = 5;
									num = 4;
									goto case 5;
								case 5:
									num = 8;
									num3++;
									num2 = 8;
									num = 4;
									break;
								case 8:
									break;
								case 12:
									goto end_IL_01f5;
								default:
									goto end_IL_0202;
								case 4:
									goto IL_0212;
								case 7:
									goto end_IL_0215;
								case 9:
									{
										num = 25;
										class2_0.method_1();
										class2_1.method_1();
										struct16_1.method_0();
										return;
									}
									IL_011d:
									num2 = 0;
									num = 4;
									goto case 0;
									IL_00c3:
									num3 = 0u;
									num2 = 3;
									num = 4;
									goto case 3;
								}
								break;
							}
							continue;
							end_IL_01f5:
							break;
						}
						continue;
						end_IL_0202:
						break;
					}
					num = 37;
					continue;
					IL_0212:
					num = 37;
					continue;
					end_IL_0215:
					break;
				}
			}
		}
		catch (Exception exception)
		{
			int num10 = default(int);
			StackFrameHelper.CreateException9(exception, num3, num5, num9, num2, num, num10, this, stream_0, stream_1);
			throw;
		}
	}

	public void imethod_0(Stream stream_0, Stream stream_1, long long_0, long long_1, GInterface3 ginterface3_0)
	{
		int num = default(int);
		int num2 = default(int);
		Class0.Struct8 @struct = default(Class0.Struct8);
		uint num3 = default(uint);
		uint num4 = default(uint);
		uint num5 = default(uint);
		uint num6 = default(uint);
		ulong num7 = default(ulong);
		ulong num8 = default(ulong);
		byte b2 = default(byte);
		byte b = default(byte);
		uint num13 = default(uint);
		uint num25 = default(uint);
		uint num11 = default(uint);
		uint num10 = default(uint);
		int num17 = default(int);
		byte b3 = default(byte);
		try
		{
			num = 66;
			num2 = 41;
			num = 20;
			while (true)
			{
				num = 62;
				while (true)
				{
					method_3(stream_0, stream_1);
					@struct = default(Class0.Struct8);
					@struct.method_0();
					num3 = 0u;
					num = 85;
					num2 = 14;
					num = 20;
					while (true)
					{
						num = 58;
						while (true)
						{
							num4 = 0u;
							num5 = 0u;
							num6 = 0u;
							num7 = 0uL;
							num8 = (ulong)long_1;
							num = 89;
							num2 = 7;
							num = 20;
							while (true)
							{
								num = 46;
								int num9;
								if (num7 >= num8)
								{
									num = 26;
									num9 = 39;
								}
								else
								{
									num = 51;
									num9 = 17;
								}
								num2 = num9;
								num = 20;
								while (true)
								{
									switch (num2)
									{
									case 45:
									{
										num = 18;
										int num20;
										if (struct15_3[@struct.uint_0].method_1(class5_0) == 0)
										{
											num = 11;
											num20 = 32;
										}
										else
										{
											num = 74;
											num20 = 16;
										}
										num2 = num20;
										num = 20;
										continue;
									}
									case 44:
										num = 37;
										b2 = class3_0.method_4(class5_0, (uint)num7, b, gclass2_0.method_7(num3));
										num = 39;
										num2 = 13;
										num = 20;
										goto case 13;
									case 13:
										num = 53;
										gclass2_0.method_6(b2);
										@struct.method_1();
										num7++;
										num = 16;
										num2 = 39;
										num = 20;
										goto case 39;
									case 39:
									{
										num = 93;
										int num22;
										if (num7 >= num8)
										{
											num = 25;
											num22 = 12;
										}
										else
										{
											num = 69;
											num22 = 22;
										}
										num2 = num22;
										num = 20;
										continue;
									}
									case 43:
									{
										num = 35;
										int num23;
										if (num3 < num7)
										{
											num = 45;
											num23 = 30;
										}
										else
										{
											num = 88;
											num23 = 4;
										}
										num2 = num23;
										num = 20;
										continue;
									}
									case 42:
										num = 14;
										num7++;
										num2 = 39;
										num = 20;
										goto case 39;
									case 40:
									{
										num = 76;
										int num14;
										if (num13 < 14)
										{
											num = 90;
											num14 = 36;
										}
										else
										{
											num = 24;
											num14 = 19;
										}
										num2 = num14;
										num = 20;
										continue;
									}
									case 38:
										num = 63;
										num25 = num6;
										num = 48;
										goto IL_012f;
									case 5:
										num = 40;
										num5 = num4;
										num2 = 35;
										num = 20;
										goto case 35;
									case 35:
										num = 94;
										num4 = num3;
										num3 = num25;
										num2 = 25;
										num = 20;
										goto case 25;
									case 25:
										num = 6;
										num11 = class2_1.method_2(class5_0, num10) + 2;
										num = 4;
										num2 = 34;
										num = 20;
										goto case 34;
									case 34:
										num = 50;
										@struct.method_3();
										num2 = 43;
										num = 20;
										goto case 43;
									case 37:
										num = 0;
										b2 = class3_0.method_3(class5_0, (uint)num7, b);
										num = 80;
										num2 = 13;
										num = 20;
										goto case 13;
									case 36:
										num = 65;
										num3 += Struct16.smethod_0(struct15_6, num3 - num13 - 1, class5_0, num17);
										num = 3;
										num2 = 43;
										num = 20;
										goto case 43;
									case 33:
										num = 48;
										goto IL_012f;
									case 32:
										num = 13;
										num25 = num4;
										num2 = 35;
										num = 20;
										goto case 35;
									case 31:
										num = 27;
										num3 = num13;
										num2 = 43;
										num = 20;
										goto case 43;
									case 30:
									{
										num = 72;
										int num19;
										if (num3 >= uint_1)
										{
											num = 55;
											num19 = 4;
										}
										else
										{
											num = 44;
											num19 = 20;
										}
										num2 = num19;
										num = 20;
										continue;
									}
									case 28:
										num = 21;
										@struct.method_2();
										num13 = struct16_0[Class0.smethod_0(num11)].method_1(class5_0);
										num = 32;
										num2 = 1;
										num = 20;
										goto case 1;
									case 1:
									{
										num = 47;
										int num16;
										if (num13 >= 4)
										{
											num = 70;
											num16 = 15;
										}
										else
										{
											num = 75;
											num16 = 31;
										}
										num2 = num16;
										num = 20;
										continue;
									}
									case 26:
									{
										num = 8;
										b = gclass2_0.method_7(0u);
										int num28;
										if (!@struct.method_5())
										{
											num = 15;
											num28 = 44;
										}
										else
										{
											num = 86;
											num28 = 37;
										}
										num2 = num28;
										num = 20;
										continue;
									}
									case 24:
									{
										num = 84;
										int num27;
										if (struct15_2[@struct.uint_0].method_1(class5_0) == 0)
										{
											num = 31;
											num27 = 21;
										}
										else
										{
											num = 28;
											num27 = 45;
										}
										num2 = num27;
										num = 20;
										continue;
									}
									case 23:
										num = 2;
										num25 = num5;
										num2 = 5;
										num = 20;
										goto case 5;
									case 22:
									{
										num = 82;
										num10 = (uint)(int)num7 & uint_2;
										int num26;
										if (struct15_0[(@struct.uint_0 << 4) + num10].method_1(class5_0) == 0)
										{
											num = 1;
											num26 = 26;
										}
										else
										{
											num = 5;
											num26 = 2;
										}
										num2 = num26;
										num = 20;
										continue;
									}
									case 21:
									{
										num = 42;
										int num24;
										if (struct15_5[(@struct.uint_0 << 4) + num10].method_1(class5_0) == 0)
										{
											num = 30;
											num24 = 10;
										}
										else
										{
											num = 54;
											num24 = 25;
										}
										num2 = num24;
										num = 20;
										continue;
									}
									case 20:
										num = 59;
										gclass2_0.method_5(num3, num11);
										num7 += num11;
										num = 52;
										num2 = 39;
										num = 20;
										goto case 39;
									case 19:
										num = 17;
										num3 += class5_0.method_2(num17 - 4) << 4;
										num = 29;
										goto IL_03b8;
									case 6:
										num = 83;
										num3 += struct16_1.method_2(class5_0);
										num = 38;
										num2 = 43;
										num = 20;
										goto case 43;
									case 17:
									{
										num = 34;
										int num21;
										if (struct15_0[@struct.uint_0 << 4].method_1(class5_0) != 0)
										{
											num = 64;
											num21 = 9;
										}
										else
										{
											num = 56;
											num21 = 11;
										}
										num2 = num21;
										num = 20;
										continue;
									}
									case 16:
									{
										num = 12;
										int num18;
										if (struct15_4[@struct.uint_0].method_1(class5_0) == 0)
										{
											num = 61;
											num18 = 23;
										}
										else
										{
											num = 57;
											num18 = 38;
										}
										num2 = num18;
										num = 20;
										continue;
									}
									case 15:
										num = 71;
										num17 = (int)((num13 >> 1) - 1);
										num3 = (2 | (num13 & 1)) << num17;
										num = 81;
										num2 = 40;
										num = 20;
										goto case 40;
									case 11:
										num = 60;
										@struct.method_1();
										b3 = class3_0.method_3(class5_0, 0u, 0);
										num = 77;
										num2 = 3;
										num = 20;
										goto case 3;
									case 3:
										num = 36;
										gclass2_0.method_6(b3);
										num7++;
										num = 73;
										num2 = 39;
										num = 20;
										goto case 39;
									case 10:
										num = 22;
										@struct.method_4();
										gclass2_0.method_6(gclass2_0.method_7(num3));
										num = 91;
										num2 = 42;
										num = 20;
										goto case 42;
									case 8:
										num = 29;
										goto IL_03b8;
									case 4:
									{
										num = 23;
										int num15;
										if (num3 != uint.MaxValue)
										{
											num = 43;
											num15 = 29;
										}
										else
										{
											num = 10;
											num15 = 12;
										}
										num2 = num15;
										num = 20;
										continue;
									}
									case 2:
									{
										num = 19;
										int num12;
										if (struct15_1[@struct.uint_0].method_1(class5_0) == 1)
										{
											num = 78;
											num12 = 24;
										}
										else
										{
											num = 92;
											num12 = 0;
										}
										num2 = num12;
										num = 20;
										continue;
									}
									case 0:
										num = 79;
										num6 = num5;
										num5 = num4;
										num4 = num3;
										num11 = 2 + class2_0.method_2(class5_0, num10);
										num = 41;
										num2 = 28;
										num = 20;
										goto case 28;
									case 7:
										break;
									case 18:
										goto end_IL_0652;
									case 14:
										goto end_IL_0663;
									default:
										goto end_IL_0683;
									case 41:
										goto end_IL_068b;
									case 9:
										num = 87;
										throw new Exception0();
									case 12:
										num = 33;
										gclass2_0.method_4();
										gclass2_0.method_3();
										num2 = 27;
										num = 20;
										goto case 27;
									case 29:
										num = 9;
										throw new Exception0();
									case 27:
										{
											num = 7;
											class5_0.method_1();
											return;
										}
										IL_03b8:
										num2 = 6;
										num = 20;
										goto case 6;
										IL_012f:
										num6 = num5;
										num2 = 5;
										num = 20;
										goto case 5;
									}
									break;
								}
								continue;
								end_IL_0652:
								break;
							}
							num = 58;
							continue;
							end_IL_0663:
							break;
						}
						continue;
						end_IL_0683:
						break;
					}
					num = 62;
					continue;
					end_IL_068b:
					break;
				}
			}
		}
		catch (Exception caughtException)
		{
			int num29 = default(int);
			StackFrameHelper.CreateExceptionN(caughtException, new object[24]
			{
				@struct, num3, num4, num5, num6, num7, num8, b3, num10, b2,
				b, num11, num25, num13, num17, num2, num, num29, this, stream_0,
				stream_1, long_0, long_1, ginterface3_0
			});
			throw;
		}
	}

	public void imethod_1(byte[] byte_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num8 = default(int);
		int num5 = default(int);
		int num9 = default(int);
		uint num4 = default(uint);
		int num6 = default(int);
		int num7 = default(int);
		try
		{
			num = 19;
			num2 = 5;
			num = 8;
			while (true)
			{
				num = 9;
				while (true)
				{
					int num3;
					if (byte_0.Length >= 5)
					{
						num = 23;
						num3 = 6;
					}
					else
					{
						num = 6;
						num3 = 3;
					}
					num2 = num3;
					num = 8;
					while (true)
					{
						int num10;
						switch (num2)
						{
						case 12:
							num = 12;
							num8++;
							num2 = 9;
							num = 8;
							goto case 9;
						case 9:
						{
							num = 0;
							int num11;
							if (num8 >= 4)
							{
								num = 16;
								num11 = 11;
							}
							else
							{
								num = 7;
								num11 = 0;
							}
							num2 = num11;
							num = 8;
							continue;
						}
						case 7:
							num = 13;
							num5 = num9 % 5;
							num = 3;
							goto IL_0046;
						case 6:
							num = 5;
							goto IL_0060;
						case 4:
							num = 3;
							goto IL_0046;
						case 2:
							num = 2;
							num4 = 0u;
							num8 = 0;
							num2 = 9;
							num = 8;
							goto case 9;
						case 1:
							num = 5;
							goto IL_0060;
						case 0:
							num = 17;
							num4 += (uint)(byte_0[1 + num8] << num8 * 8);
							num = 11;
							num2 = 12;
							num = 8;
							goto case 12;
						case 8:
							goto IL_00f1;
						case 5:
							goto end_IL_00fe;
						case 3:
							num = 20;
							throw new Exception1();
						case 10:
							num = 14;
							throw new Exception1();
						case 11:
							{
								num = 21;
								method_0(num4);
								method_1(num5, num6);
								method_2(num7);
								return;
							}
							IL_0060:
							num6 = (int)byte_0[0] % 9;
							num9 = (int)byte_0[0] / 9;
							num = 22;
							num2 = 7;
							num = 8;
							goto case 7;
							IL_0046:
							num7 = num9 / 5;
							if (num7 > 4)
							{
								num = 18;
								num10 = 10;
							}
							else
							{
								num = 15;
								num10 = 2;
							}
							num2 = num10;
							num = 8;
							continue;
						}
						break;
					}
					num = 9;
					continue;
					IL_00f1:
					num = 9;
					continue;
					end_IL_00fe:
					break;
				}
			}
		}
		catch (Exception caughtException)
		{
			int num12 = default(int);
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				num6, num9, num5, num7, num4, num8, num2, num, num12, this,
				byte_0
			});
			throw;
		}
	}

	static GClass3()
	{
		try
		{
			Exception1.smethod_3();
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException1(exception, num);
			throw;
		}
	}

	internal static DialogResult smethod_0(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, int int_0, int int_1)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 4;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 51:
					num = 3;
					num2 = 6;
					break;
				default:
					num = 1;
					num2 = 3;
					break;
				}
				num3 = num2;
				num = 7;
				switch (num3)
				{
				default:
					num = 6;
					goto IL_003a;
				case 0:
					num = 4;
					break;
				case 1:
					num = 6;
					goto IL_003a;
				case 3:
					num = 5;
					num3 = 2;
					num = 7;
					goto case 2;
				case 4:
					num = 4;
					break;
				case 5:
					num = 0;
					goto IL_0052;
				case 7:
					num = 0;
					goto IL_0052;
				case 2:
					num = 4;
					break;
				case 6:
					{
						num = 8;
						return Class7.smethod_5(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, 741, 705);
					}
					IL_0052:
					num3 = 2;
					num = 7;
					goto case 2;
					IL_003a:
					num3 = 2;
					num = 7;
					goto case 2;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, num3, num, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, int_0, int_1);
			throw;
		}
	}

	internal static string[] smethod_1(string string_0, char[] char_0, int int_0, int int_1)
	{
		int num = default(int);
		int num3 = default(int);
		try
		{
			num = 7;
			while (true)
			{
				int num2;
				switch (int_1 ^ int_0)
				{
				case 52:
					num = 0;
					num2 = 6;
					break;
				default:
					num = 5;
					num2 = 5;
					break;
				}
				num3 = num2;
				num = 1;
				switch (num3)
				{
				default:
					num = 4;
					goto IL_0036;
				case 0:
					num = 4;
					goto IL_0036;
				case 2:
					num = 8;
					goto IL_004e;
				case 3:
					num = 6;
					goto IL_0046;
				case 5:
					num = 6;
					goto IL_0046;
				case 7:
					num = 8;
					goto IL_004e;
				case 4:
					goto IL_0052;
				case 1:
					num = 12;
					break;
				case 6:
					{
						num = 12;
						break;
					}
					IL_0046:
					num3 = 4;
					num = 1;
					goto IL_0052;
					IL_004e:
					num3 = 4;
					num = 1;
					goto IL_0052;
					IL_0036:
					num3 = 4;
					num = 1;
					goto IL_0052;
				}
				break;
				IL_0052:
				num = 7;
			}
			return Class10.smethod_7(string_0, char_0, 344, 364);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num3, num, string_0, char_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Thread thread_0, int int_0, int int_1)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 0;
			num2 = 2;
			num = 2;
			while (true)
			{
				num = 8;
				while (true)
				{
					int num3;
					switch (int_1 ^ int_0)
					{
					case 26:
						num = 6;
						num3 = 0;
						break;
					default:
						num = 7;
						num3 = 5;
						break;
					}
					num2 = num3;
					num = 2;
					switch (num2)
					{
					default:
						goto IL_002c;
					case 1:
						num = 1;
						goto IL_004c;
					case 5:
						num = 1;
						goto IL_004c;
					case 2:
						break;
					case 0:
						num = 9;
						goto IL_005c;
					case 3:
						num = 9;
						goto IL_005c;
					case 4:
						{
							num = 10;
							return;
						}
						IL_005c:
						Class10.Class11.smethod_11(thread_0, 105, 127);
						return;
						IL_004c:
						num2 = 2;
						num = 2;
						break;
					}
					break;
					IL_002c:
					num = 8;
				}
			}
		}
		catch (Exception exception)
		{
			int num4 = default(int);
			int num5 = default(int);
			StackFrameHelper.CreateException7(exception, num2, num4, num, num5, thread_0, int_0, int_1);
			throw;
		}
	}
}
