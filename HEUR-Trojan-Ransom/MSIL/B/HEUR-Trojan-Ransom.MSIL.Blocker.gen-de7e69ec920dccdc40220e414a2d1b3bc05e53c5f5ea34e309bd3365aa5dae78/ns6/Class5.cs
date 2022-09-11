using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using ns3;
using ns4;
using ns8;

namespace ns6;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Class5
{
	internal sealed class Class6
	{
		[SecuritySafeCritical]
		internal static bool smethod_0<T, U>(T gparam_0, U gparam_1, int int_0, char char_0) where T : MethodInfo where U : MethodInfo
		{
			byte[] byte_ = GClass1.byte_0;
			int num3 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 4;
				while (true)
				{
					IL_0091:
					bool result;
					switch (((char_0 ^ int_0) - 38) ^ num)
					{
					case 0:
						num2 = 5;
						while (true)
						{
							result = (MethodInfo?)gparam_0 != (MethodInfo?)gparam_1;
							switch (byte_[128])
							{
							case 51:
							case 56:
								break;
							case 53:
								num2 = 4;
								goto IL_0091;
							case 61:
								goto end_IL_000f;
							case 54:
								goto IL_0071;
							case 62:
								goto IL_007d;
							case 52:
							case 60:
								goto IL_0081;
							case 55:
								goto IL_0091;
							default:
								num2 = 8;
								goto end_IL_0099;
							case 59:
								goto end_IL_0099;
							case 58:
								goto IL_00b1;
							}
							continue;
							end_IL_000f:
							break;
						}
						goto IL_006c;
					default:
						{
							num2 = 10;
							goto IL_006c;
						}
						IL_00b1:
						return result;
						IL_006c:
						result = true;
						num2 = 3;
						goto IL_0071;
						IL_0071:
						num++;
						num3 = char_0 * char_0;
						num3 = char_0 + num3;
						goto IL_007d;
						IL_007d:
						num2 = 9;
						goto IL_0081;
						IL_0081:
						if (num3 % 2 != 0)
						{
							num2 = 4;
							continue;
						}
						num2 = 7;
						goto IL_00b1;
						end_IL_0099:
						break;
					}
					break;
				}
			}
		}

		[SecuritySafeCritical]
		internal static ProcessModule smethod_1<T>(T gparam_0, int int_0, short short_0) where T : Process
		{
			int num = 0;
			Component component;
			int num2;
			do
			{
				component = (((int_0 ^ short_0) - 31) ^ num) switch
				{
					0 => gparam_0.MainModule, 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return (ProcessModule)component;
		}

		[SecuritySafeCritical]
		internal static IntPtr smethod_2<T>(T gparam_0, char char_0, char char_1) where T : ProcessModule
		{
			int num = 0;
			IntPtr result;
			int num2;
			do
			{
				result = (((char_1 ^ char_0) - 38) ^ num) switch
				{
					0 => gparam_0.BaseAddress, 
					_ => default(IntPtr), 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static int smethod_3(IntPtr intptr_0, char char_0, int int_0)
		{
			int num = 0;
			int result;
			int num2;
			do
			{
				result = (((int_0 ^ char_0) - 8) ^ num) switch
				{
					0 => Marshal.ReadInt32(intptr_0), 
					_ => 8, 
				};
				num++;
				num2 = char_0 * char_0;
				num2 = char_0 + num2;
			}
			while (num2 % 2 != 0);
			return result;
		}

		[SecuritySafeCritical]
		internal static short smethod_4(IntPtr intptr_0, int int_0, char char_0)
		{
			byte[] byte_ = Class9.byte_0;
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 3;
				while (true)
				{
					IL_0087:
					int num3 = int_0 ^ char_0;
					GClass1.byte_0[178] = Class9.byte_0[319];
					short result;
					switch ((num3 - 122) ^ num)
					{
					case 0:
						num2 = 4;
						goto IL_000f;
					default:
						{
							num2 = 1;
							while (true)
							{
								IL_0080:
								result = 2;
								while (true)
								{
									switch (byte_[513])
									{
									case 36:
									case 38:
										break;
									case 37:
										goto IL_0019;
									case 42:
										goto IL_0025;
									case 40:
										goto IL_0028;
									case 41:
										continue;
									case 33:
										goto IL_0080;
									case 39:
										num2 = 3;
										goto IL_0087;
									case 35:
										goto IL_0087;
									default:
										num2 = 11;
										goto end_IL_00a5;
									case 43:
										goto end_IL_00a5;
									case 34:
										goto IL_00be;
									}
									break;
								}
								break;
							}
							goto IL_000f;
						}
						IL_00be:
						return result;
						IL_000f:
						result = Marshal.ReadInt16(intptr_0);
						num2 = 5;
						goto IL_0019;
						IL_0019:
						num++;
						num4 = char_0 * char_0;
						num4 = char_0 + num4;
						goto IL_0025;
						IL_0025:
						num2 = 8;
						goto IL_0028;
						IL_0028:
						if (num4 % 2 != 0)
						{
							num2 = 3;
							continue;
						}
						num2 = 2;
						goto IL_00be;
						end_IL_00a5:
						break;
					}
					break;
				}
			}
		}
	}

	internal sealed class Class7
	{
		[SecuritySafeCritical]
		internal static Delegate smethod_0<T, U, V>(U gparam_0, T gparam_1, V gparam_2, short short_0, char char_0) where T : Type where U : Type where V : string
		{
			int num = 0;
			object obj;
			int num2;
			do
			{
				obj = (((short_0 ^ char_0) - 84) ^ num) switch
				{
					0 => Delegate.CreateDelegate(gparam_0, gparam_1, gparam_2), 
					_ => null, 
				};
				num++;
				num2 = short_0 * short_0;
				num2 = short_0 + num2;
			}
			while (num2 % 2 != 0);
			return (Delegate)obj;
		}
	}

	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			byte[] byte_ = Class9.byte_0;
			int num = 4;
			while (true)
			{
				int num2 = 0;
				num = 12;
				while (true)
				{
					num = 0;
					while (true)
					{
						IL_00c5:
						if (num2 != 1)
						{
							num = 1;
							goto IL_00b6;
						}
						num = 2;
						goto IL_00a1;
						IL_00f5:
						return resourceMan;
						IL_00ab:
						num2 = 2;
						num = 1;
						goto IL_00b6;
						IL_00b6:
						while (true)
						{
							IL_00b6_2:
							if (num2 != 2)
							{
								num = 6;
								goto IL_0096;
							}
							num = 13;
							goto IL_006a;
							IL_0096:
							while (true)
							{
								if (num2 == 0)
								{
									switch (byte_[148])
									{
									case 164:
									case 174:
										break;
									case 167:
										continue;
									case 163:
										goto end_IL_00b6;
									case 172:
										goto IL_00ab;
									case 162:
										goto IL_00b6_2;
									case 161:
										goto IL_00c5;
									case 175:
										num2 = 1;
										num = 7;
										goto IL_00d8;
									case 168:
									case 169:
										goto IL_00d8;
									case 173:
										goto end_IL_00c5;
									default:
										goto end_IL_00e1;
									case 170:
										goto IL_00f3;
									case 166:
										goto IL_00f5;
									}
									break;
								}
								num = 7;
								goto IL_00d8;
								IL_00d8:
								if (num2 != 3)
								{
									num = 12;
									goto end_IL_00c5;
								}
								num = 9;
								goto IL_00f3;
								IL_00f3:
								num = 5;
								goto IL_00f5;
							}
							goto IL_006a;
							IL_006a:
							resourceMan = new ResourceManager("BufferCopy.Properties.Resources", Class1.smethod_1(typeof(Class5), 853, 825));
							num2 = 3;
							num = 6;
							goto IL_0096;
							continue;
							end_IL_00b6:
							break;
						}
						goto IL_00a1;
						IL_00a1:
						if (resourceMan == null)
						{
							num = 11;
							goto IL_00ab;
						}
						num = 5;
						goto IL_00f5;
						continue;
						end_IL_00c5:
						break;
					}
					continue;
					end_IL_00e1:
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return resourceCulture;
		}
		set
		{
			int num = 0;
			bool num2;
			do
			{
				if (num == 1)
				{
					resourceCulture = value;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				num2 = num == 2;
				GClass1.byte_0[294] = (byte)((GClass1.byte_0[294] - GClass1.byte_0[365]) & 0xA8);
			}
			while (!num2);
		}
	}

	internal Class5()
	{
	}

	[SecuritySafeCritical]
	internal static IntPtr smethod_0(int int_0, char char_0, short short_0)
	{
		int num = 0;
		IntPtr result;
		do
		{
			result = (((short_0 ^ char_0) - 50) ^ num) switch
			{
				0 => (IntPtr)int_0, 
				_ => default(IntPtr), 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	[SecuritySafeCritical]
	internal static bool smethod_1<T, U>(U gparam_0, T gparam_1, char char_0, char char_1) where T : Assembly where U : Assembly
	{
		int num = 0;
		bool result = (((char_1 ^ char_0) - 5) ^ 0) switch
		{
			0 => (Assembly?)gparam_0 != (Assembly?)gparam_1, 
			_ => false, 
		};
		num++;
		return result;
	}
}
