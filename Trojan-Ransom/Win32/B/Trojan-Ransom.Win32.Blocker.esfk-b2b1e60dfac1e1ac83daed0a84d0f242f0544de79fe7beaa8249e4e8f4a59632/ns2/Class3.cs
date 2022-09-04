using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;
using ns1;
using ns3;

namespace ns2;

internal sealed class Class3
{
	private static object object_0;

	private static string string_0;

	private static string string_1 = Class0.smethod_1(521209601, 8);

	private static RegistryKey registryKey_0 = Form0.smethod_8(Registry.LocalMachine, Class0.smethod_1(521209644, 3), bool_0: false, 705, 683);

	private static object object_1 = Class5.smethod_8(Class6.smethod_3(registryKey_0, Class0.smethod_1(521209688, 4), 226, 139), 811, 882);

	private static string string_2 = Class0.smethod_1(521209710, 6);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static bool smethod_0()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					Class2.smethod_5(686, 645);
					*(int*)ptr = 2;
					if (Class5.smethod_9(Class0.smethod_1(521208970, 8), 198, 182).Length >= 1)
					{
						((byte*)ptr)[12] = 1;
					}
					else
					{
						((byte*)ptr)[12] = 0;
					}
					goto end_IL_0006;
				case 77:
					*(int*)((byte*)ptr + 4) = -1;
					switch (*(int*)ptr)
					{
					case 2:
						Class2.smethod_5(399, 421);
						goto end_IL_0006;
					}
					break;
				}
				goto IL_00a6;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				Class5.smethod_4((Exception)obj, 190, 217);
				try0006_dispatch = 77;
				continue;
			}
			break;
			IL_00a6:
			*(int*)((byte*)ptr + 8) = 1;
			switch (*(int*)((byte*)ptr + 8))
			{
			default:
				throw ProjectData.CreateProjectError(-2146828237);
			case 0:
			case 2:
			case 3:
				break;
			}
			break;
		}
		byte result = ((byte*)ptr)[12];
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result != 0;
	}

	public static void smethod_1()
	{
		Process[] array = Form0.smethod_9(558, 581);
		Process[] array2 = array;
		foreach (Process process_ in array2)
		{
			string text = Class0.smethod_11(process_, 666, 755);
			if (Form0.smethod_10(text, Class0.smethod_1(521208971, 3), 799, 875))
			{
				Class0.smethod_12(process_, 945, 959);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static bool smethod_2()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					Class2.smethod_5(420, 399);
					*(int*)ptr = 2;
					if (Class5.smethod_9(Class0.smethod_1(521209005, 6), 49, 65).Length >= 1)
					{
						((byte*)ptr)[12] = 1;
					}
					else
					{
						((byte*)ptr)[12] = 0;
					}
					goto end_IL_0006;
				case 71:
					*(int*)((byte*)ptr + 4) = -1;
					switch (*(int*)ptr)
					{
					case 2:
						Class2.smethod_5(335, 357);
						goto end_IL_0006;
					}
					break;
				}
				goto IL_00a0;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				Class5.smethod_4((Exception)obj, 994, 901);
				try0006_dispatch = 71;
				continue;
			}
			break;
			IL_00a0:
			*(int*)((byte*)ptr + 8) = 1;
			switch (*(int*)((byte*)ptr + 8))
			{
			default:
				throw ProjectData.CreateProjectError(-2146828237);
			case 2:
			case 3:
			case 4:
				break;
			}
			break;
		}
		byte result = ((byte*)ptr)[12];
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result != 0;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static bool smethod_3()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
				{
					Class2.smethod_5(250, 209);
					*(int*)ptr = 2;
					string text = Class5.smethod_10(66, 16);
					string text2 = Class5.smethod_5(text, Class0.smethod_1(521209021, 8), 189, 130);
					if (Form0.smethod_11(Class5.smethod_10(84, 7), text2, bool_0: false, 44, 30) == 0)
					{
						((byte*)ptr)[12] = 1;
					}
					else
					{
						((byte*)ptr)[12] = 0;
					}
					goto end_IL_0006;
				}
				case 103:
					*(int*)((byte*)ptr + 4) = -1;
					switch (*(int*)ptr)
					{
					case 2:
						Class2.smethod_5(103, 77);
						goto end_IL_0006;
					}
					break;
				}
				goto IL_00b0;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 103;
				continue;
			}
			break;
			IL_00b0:
			*(int*)((byte*)ptr + 8) = 5;
			switch (*(int*)((byte*)ptr + 8))
			{
			default:
				throw ProjectData.CreateProjectError(-2146828237);
			case 1:
			case 4:
				break;
			}
			break;
		}
		byte result = ((byte*)ptr)[12];
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result != 0;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static bool smethod_4()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					Class2.smethod_5(607, 628);
					*(int*)ptr = 2;
					if (Class2.smethod_10(object_1, string_2, bool_0: false, 294, 383))
					{
						((byte*)ptr)[12] = 1;
					}
					else
					{
						((byte*)ptr)[12] = 0;
					}
					goto end_IL_0006;
				case 74:
					*(int*)((byte*)ptr + 4) = -1;
					switch (*(int*)ptr)
					{
					case 2:
						Class2.smethod_5(832, 874);
						goto end_IL_0006;
					}
					break;
				}
				goto IL_00a3;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				Class5.smethod_4((Exception)obj, 958, 985);
				try0006_dispatch = 74;
				continue;
			}
			break;
			IL_00a3:
			*(int*)((byte*)ptr + 8) = 0;
			switch (*(int*)((byte*)ptr + 8))
			{
			default:
				throw ProjectData.CreateProjectError(-2146828237);
			case 3:
			case 4:
				break;
			}
			break;
		}
		byte result = ((byte*)ptr)[12];
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result != 0;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static bool smethod_5()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
				{
					Class2.smethod_5(98, 73);
					*(int*)ptr = 2;
					smethod_8();
					string text = string_0;
					if (Form0.smethod_11(text, Class0.smethod_1(521209026, 1), bool_0: false, 181, 135) == 0)
					{
						((byte*)ptr)[12] = 1;
					}
					else
					{
						((byte*)ptr)[12] = 0;
					}
					goto end_IL_0006;
				}
				case 82:
					*(int*)((byte*)ptr + 4) = -1;
					switch (*(int*)ptr)
					{
					case 2:
						Class2.smethod_5(760, 722);
						goto end_IL_0006;
					}
					break;
				}
				goto IL_00a5;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				Class5.smethod_4((Exception)obj, 62, 89);
				try0006_dispatch = 82;
				continue;
			}
			break;
			IL_00a5:
			*(int*)((byte*)ptr + 8) = 1;
			switch (*(int*)((byte*)ptr + 8))
			{
			default:
				throw ProjectData.CreateProjectError(-2146828237);
			case 0:
			case 2:
				break;
			}
			break;
		}
		byte result = ((byte*)ptr)[12];
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result != 0;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static bool smethod_6()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
				{
					Class2.smethod_5(929, 906);
					*(int*)ptr = 2;
					smethod_8();
					string text = string_0;
					if (Form0.smethod_11(text, Class0.smethod_1(521209059, 2), bool_0: false, 942, 924) == 0)
					{
						((byte*)ptr)[12] = 1;
					}
					else
					{
						((byte*)ptr)[12] = 0;
					}
					goto end_IL_0006;
				}
				case 88:
					*(int*)((byte*)ptr + 4) = -1;
					switch (*(int*)ptr)
					{
					case 2:
						Class2.smethod_5(552, 514);
						goto end_IL_0006;
					}
					break;
				}
				goto IL_00b1;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				Class5.smethod_4((Exception)obj, 242, 149);
				try0006_dispatch = 88;
				continue;
			}
			break;
			IL_00b1:
			*(int*)((byte*)ptr + 8) = 2;
			switch (*(int*)((byte*)ptr + 8))
			{
			default:
				throw ProjectData.CreateProjectError(-2146828237);
			case 0:
			case 1:
			case 4:
				break;
			}
			break;
		}
		byte result = ((byte*)ptr)[12];
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result != 0;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public unsafe static bool smethod_7()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
				{
					Class2.smethod_5(572, 535);
					*(int*)ptr = 2;
					smethod_8();
					string text = string_0;
					if (Form0.smethod_11(text, Class0.smethod_1(521209074, 2), bool_0: false, 116, 70) == 0)
					{
						((byte*)ptr)[12] = 1;
					}
					else
					{
						((byte*)ptr)[12] = 0;
					}
					goto end_IL_0006;
				}
				case 82:
					*(int*)((byte*)ptr + 4) = -1;
					switch (*(int*)ptr)
					{
					case 2:
						Class2.smethod_5(267, 289);
						goto end_IL_0006;
					}
					break;
				}
				goto IL_00ab;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				Class5.smethod_4((Exception)obj, 849, 822);
				try0006_dispatch = 82;
				continue;
			}
			break;
			IL_00ab:
			*(int*)((byte*)ptr + 8) = 1;
			switch (*(int*)((byte*)ptr + 8))
			{
			default:
				throw ProjectData.CreateProjectError(-2146828237);
			case 0:
			case 3:
			case 4:
				break;
			}
			break;
		}
		byte result = ((byte*)ptr)[12];
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result != 0;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private unsafe static void smethod_8()
	{
		void* ptr = stackalloc byte[8];
		int try0005_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0005_dispatch)
				{
				default:
				{
					Class2.smethod_5(886, 861);
					*(int*)ptr = 2;
					object obj = Class6.smethod_4(Class0.smethod_1(521208840, 4), null, 822, 783);
					string text = Class0.smethod_1(521208863, 7);
					object[] array = new object[1] { string_1 };
					bool[] array2 = new bool[1] { true };
					object obj2 = Class2.smethod_11(obj, null, text, array, null, null, array2, 105, 49);
					if (array2[0])
					{
						string_1 = (string)Class1.smethod_6(Class5.smethod_8(array[0], 756, 685), Class1.smethod_1(typeof(string).TypeHandle, 733, 698), 695, 729);
					}
					object_0 = Class5.smethod_8(obj2, 674, 763);
					IEnumerator enumerator = ((IEnumerable)object_0).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object obj3 = Class5.smethod_8(enumerator.Current, 484, 445);
						string_0 = Class0.smethod_6(Class2.smethod_11(obj3, null, Class0.smethod_1(521208867, 7), new object[0], null, null, null, 655, 727), 230, 214);
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0005;
				}
				case 324:
					*(int*)((byte*)ptr + 4) = -1;
					switch (*(int*)ptr)
					{
					case 2:
						ProjectData.EndApp();
						goto end_IL_0005;
					}
					break;
				}
				goto IL_0189;
				end_IL_0005:;
			}
			catch (object obj4) when ((obj4 is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0005_dispatch = 324;
				continue;
			}
			break;
			IL_0189:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
