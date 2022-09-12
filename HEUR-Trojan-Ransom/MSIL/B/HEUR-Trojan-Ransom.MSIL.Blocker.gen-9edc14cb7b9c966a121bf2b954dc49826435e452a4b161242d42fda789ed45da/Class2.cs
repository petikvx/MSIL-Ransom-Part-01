using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

internal class Class2 : IDisposable
{
	private string string_0 = Class3.smethod_0(32264);

	private BlockingCollection<Class1> blockingCollection_0 = new BlockingCollection<Class1>();

	internal Class2(int int_0, string[] string_1)
	{
		int i = default(int);
		while (true)
		{
			int num = Class5.smethod_0(26);
			int num2 = -30;
			while (true)
			{
				IL_00b4:
				num2 ^= 0xD;
				int num3;
				while (true)
				{
					num3 = Class12.smethod_2(35);
					switch (num3 ^ 0x16)
					{
					case -12:
						goto end_IL_0026;
					case -13:
						goto IL_006b;
					case -11:
						goto IL_00b4;
					}
					continue;
					end_IL_0026:
					break;
				}
				switch (num2)
				{
				case -19:
					goto IL_007d;
				case -17:
					goto IL_009f;
				case -18:
					goto end_IL_00b4;
				}
				num3 = -27;
				num3 = -13;
				goto IL_006b;
				IL_009f:
				num ^= 0x17;
				num2 = Class12.smethod_2(23);
				num3 = -29;
				num3 = -11;
				continue;
				IL_006b:
				num2 = Class12.smethod_2(23);
				num3 = -29;
				num3 = -11;
				continue;
				IL_007d:
				switch (num)
				{
				default:
					num2 = -29;
					continue;
				case 20:
					i = 0;
					num = 1;
					break;
				case 21:
					num = 3;
					break;
				case 22:
					for (; i < int_0; i++)
					{
						if (1 == 0)
						{
							break;
						}
						Task.Factory.StartNew(method_3, string_1[i], TaskCreationOptions.LongRunning);
					}
					return;
				}
				goto IL_009f;
				continue;
				end_IL_00b4:
				break;
			}
		}
	}

	internal void method_0()
	{
		blockingCollection_0.CompleteAdding();
	}

	internal Task method_1(object object_0)
	{
		Task result = default(Task);
		while (true)
		{
			int num = Class12.smethod_2(28);
			int num2 = 8;
			while (true)
			{
				IL_00a3:
				num2 ^= 0x2D;
				int num3;
				while (true)
				{
					num3 = Class9.smethod_0(45);
					switch (num3 ^ 0x27)
					{
					case 40:
						goto end_IL_0007;
					case 41:
						goto IL_0093;
					case 42:
						goto IL_00a3;
					}
					continue;
					end_IL_0007:
					break;
				}
				switch (num2)
				{
				case 36:
					goto IL_004e;
				case 37:
					goto IL_007c;
				case 35:
					goto end_IL_00a3;
				}
				num3 = 14;
				num3 = 41;
				goto IL_0093;
				IL_0093:
				num2 = Class12.smethod_2(43);
				num3 = 13;
				num3 = 42;
				continue;
				IL_007c:
				num ^= 0x20;
				num2 = Class12.smethod_2(43);
				num3 = 13;
				num3 = 42;
				continue;
				IL_004e:
				switch (num)
				{
				default:
					num2 = 14;
					continue;
				case -26:
					break;
				case -27:
				case -25:
					return result;
				}
				result = method_2(null, object_0);
				num = -59;
				goto IL_007c;
				continue;
				end_IL_00a3:
				break;
			}
		}
	}

	internal Task method_2(CancellationToken? nullable_0, object object_0)
	{
		TaskCompletionSource<object> taskCompletionSource = default(TaskCompletionSource<object>);
		Task task = default(Task);
		while (true)
		{
			int num = Class9.smethod_0(44);
			int num2 = -28;
			while (true)
			{
				IL_00cc:
				num2 ^= 0x2B;
				int num3;
				while (true)
				{
					num3 = Class12.smethod_2(23);
					switch (num3 ^ 0x2E)
					{
					case -50:
						goto end_IL_0007;
					case -49:
						goto IL_00bc;
					case -48:
						goto IL_00cc;
					}
					continue;
					end_IL_0007:
					break;
				}
				switch (num2)
				{
				case -51:
					goto IL_004e;
				case -49:
					goto IL_00a5;
				case -50:
					goto end_IL_00cc;
				}
				num3 = -31;
				num3 = -49;
				goto IL_00bc;
				IL_00a5:
				num ^= 0x23;
				num2 = Class9.smethod_0(54);
				num3 = -2;
				num3 = -48;
				continue;
				IL_00bc:
				num2 = Class9.smethod_0(54);
				num3 = -2;
				num3 = -48;
				continue;
				IL_004e:
				switch (num)
				{
				default:
					num2 = -27;
					continue;
				case -40:
					taskCompletionSource = new TaskCompletionSource<object>();
					num = -6;
					break;
				case -39:
					blockingCollection_0.Add(new Class1(taskCompletionSource, nullable_0, object_0));
					num = -7;
					break;
				case -38:
					num = -8;
					break;
				case -37:
					task = taskCompletionSource.Task;
					num = -1;
					break;
				case -36:
				case -35:
					return task;
				}
				goto IL_00a5;
				continue;
				end_IL_00cc:
				break;
			}
		}
	}

	private void method_3(object object_0)
	{
		IEnumerator<Class1> enumerator = blockingCollection_0.GetConsumingEnumerable().GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class1 current = enumerator.Current;
				if (((current.nullable_0.HasValue || 1 == 0) && current.nullable_0.Value.IsCancellationRequested) || 1 == 0)
				{
					current.taskCompletionSource_0.SetCanceled();
					continue;
				}
				try
				{
					method_4(current.object_0);
					int num = smethod_0(66);
					int num2 = -1;
					num2 = -54;
					while (true)
					{
						IL_0114:
						num ^= 0x40;
						while (true)
						{
							num2 = smethod_0(62);
							switch (num2 ^ 0x35)
							{
							default:
								continue;
							case -56:
								switch (num)
								{
								default:
									num2 = -4;
									num2 = -55;
									break;
								case 60:
									num = 125;
									goto end_IL_009c;
								case 61:
									num = 0;
									goto end_IL_009c;
								case 62:
									current.taskCompletionSource_0.SetResult(current.object_0);
									num = 124;
									goto end_IL_009c;
								case 63:
									num = smethod_0(59);
									goto end_IL_009c;
								case 64:
									goto end_IL_0087;
								}
								goto case -55;
							case -55:
								num = smethod_0(66);
								num2 = -1;
								num2 = -54;
								break;
							case -54:
								break;
								end_IL_009c:
								break;
							}
							goto IL_0114;
							continue;
							end_IL_0087:
							break;
						}
						break;
					}
				}
				catch (Exception exception)
				{
					while (true)
					{
						IL_0124:
						int num3 = smethod_0(64);
						while (true)
						{
							switch (num3 ^ 0x3D)
							{
							case 61:
								goto IL_0150;
							case 60:
								num3 = 6;
								num3 = 59;
								goto case 59;
							case 59:
								num3 = 3;
								num3 = 62;
								goto end_IL_012d;
							case 62:
								goto end_IL_012d;
							}
							goto IL_0124;
							IL_0150:
							current.taskCompletionSource_0.SetException(exception);
							num3 = smethod_0(61);
							continue;
							end_IL_012d:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (enumerator != null || 1 == 0)
			{
				enumerator.Dispose();
			}
		}
	}

	void IDisposable.Dispose()
	{
		((IDisposable)blockingCollection_0).Dispose();
	}

	private void method_4(object object_0)
	{
		string text = default(string);
		while (true)
		{
			int num = Class12.smethod_2(19);
			int num2 = 120;
			while (true)
			{
				IL_00c6:
				num2 ^= 0x3B;
				int num3;
				while (true)
				{
					num3 = Class5.smethod_1(69);
					switch (num3 ^ 0x47)
					{
					case -63:
						goto end_IL_0007;
					case -64:
						goto IL_004c;
					case -62:
						goto IL_00c6;
					}
					continue;
					end_IL_0007:
					break;
				}
				switch (num2)
				{
				case 65:
					goto IL_005e;
				case 67:
					goto IL_00b1;
				case 66:
					goto end_IL_00c6;
				}
				num3 = -121;
				num3 = -64;
				goto IL_004c;
				IL_00b1:
				num ^= 0x37;
				num2 = Class5.smethod_1(73);
				num3 = -123;
				num3 = -62;
				continue;
				IL_004c:
				num2 = Class5.smethod_1(73);
				num3 = -123;
				num3 = -62;
				continue;
				IL_005e:
				switch (num)
				{
				default:
					num2 = 121;
					continue;
				case -60:
					num = smethod_0(57);
					break;
				case -59:
					text = (string)object_0;
					num = -16;
					break;
				case -58:
					Console.WriteLine(text);
					num = -13;
					break;
				case -57:
					string.Format(string_0, text);
					num = -15;
					break;
				case -56:
					return;
				}
				goto IL_00b1;
				continue;
				end_IL_00c6:
				break;
			}
		}
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			57 => -1, 
			59 => 126, 
			60 => -11, 
			61 => 1, 
			62 => -3, 
			63 => -9, 
			64 => 0, 
			65 => -12, 
			66 => 127, 
			_ => -1, 
		};
	}
}
