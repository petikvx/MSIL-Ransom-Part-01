using System;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace ns0;

internal static class Class0
{
	internal sealed class Class1
	{
		internal static int smethod_0(object object_0, object object_1, int int_0, int int_1, int int_2, int int_3)
		{
			ftqdcCvjsxnOidQe0u();
			if (VDLdspK86MQi0Hj1eP())
			{
			}
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 45:
					return mvO8kdfIRnIxbwpvHY(object_0, object_1, int_0, int_1);
				}
			}
		}

		internal static Assembly smethod_1(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				default:
					while (true)
					{
						IL_0073:
						int num = 2;
						while (true)
						{
							num = 5;
							while (true)
							{
								switch (num)
								{
								case 3:
									num = 5;
									continue;
								case 2:
									goto end_IL_0046;
								case 5:
									goto end_IL_006e;
								case 1:
								case 4:
								case 6:
								case 7:
									goto end_IL_007d;
								}
								while (true)
								{
									num = 5;
									_ = 1;
									if (!ftqdcCvjsxnOidQe0u())
									{
										break;
									}
									if (VDLdspK86MQi0Hj1eP())
									{
										switch (0)
										{
										case 6:
										case 7:
											break;
										case 2:
										case 3:
										case 5:
										case 8:
											goto end_IL_0007;
										default:
											goto IL_0073;
										case 1:
											goto end_IL_006e;
										}
										continue;
									}
									goto IL_0073;
									continue;
									end_IL_0007:
									break;
								}
								continue;
								end_IL_0046:
								break;
							}
							continue;
							end_IL_006e:
							break;
						}
						break;
					}
					continue;
				case 36:
					{
						int num = 7;
						break;
					}
					end_IL_007d:
					break;
				}
				break;
			}
			return (Assembly)XaT08kyL7KfWcoGXsj(object_0);
		}

		internal static Assembly smethod_2(Type type_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					return type_0.Assembly;
				}
			}
		}

		internal static Stream smethod_3(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 22:
					return (Stream)qLm9BFqxUlHRgh4NEl(object_0, object_1);
				}
			}
		}

		internal static object smethod_4(object object_0, object object_1, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 41:
					return Gx0lk3PoA9SWu3HP4W(object_0, object_1);
				}
			}
		}

		internal static void smethod_5(object object_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					RIR9iOAyFqFwSpnSK2(object_0, runtimeFieldHandle_0);
					return;
				}
			}
		}

		internal static int smethod_6(object object_0, object object_1, int int_0, int int_1, int int_2, int int_3)
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 79:
					return mvO8kdfIRnIxbwpvHY(object_0, object_1, int_0, int_1);
				}
			}
		}

		internal static byte[] smethod_7(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 6:
					return (byte[])VDtbACtLpSg6T7JiXp(object_0);
				}
			}
		}

		internal static Evidence smethod_8(object object_0, int int_0, int int_1)
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 91:
					return (Evidence)BZ6ZAD3SF8DyccWh4C(object_0);
				}
			}
		}

		internal static int mvO8kdfIRnIxbwpvHY(object object_0, object object_1, int int_0, int int_1)
		{
			return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
		}

		internal static bool VDLdspK86MQi0Hj1eP()
		{
			return true;
		}

		internal static bool ftqdcCvjsxnOidQe0u()
		{
			return false;
		}

		internal static object XaT08kyL7KfWcoGXsj(object object_0)
		{
			return Assembly.Load((byte[])object_0);
		}

		internal static object qLm9BFqxUlHRgh4NEl(object object_0, object object_1)
		{
			return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
		}

		internal static object Gx0lk3PoA9SWu3HP4W(object object_0, object object_1)
		{
			return ((AppDomain)object_0).GetData((string)object_1);
		}

		internal static void RIR9iOAyFqFwSpnSK2(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static object VDtbACtLpSg6T7JiXp(object object_0)
		{
			return ((MemoryStream)object_0).ToArray();
		}

		internal static object BZ6ZAD3SF8DyccWh4C(object object_0)
		{
			return ((Assembly)object_0).get_Evidence();
		}
	}

	private static Assembly smethod_0(object object_0, object object_1)
	{
		int num = 7;
		if (!STgGY7rmrQa02pAZXL())
		{
			goto IL_0086;
		}
		goto IL_0118;
		IL_0118:
		int num3 = default(int);
		Uri object_2 = default(Uri);
		int num2 = default(int);
		while (true)
		{
			IL_0118_2:
			switch (num)
			{
			case 0:
				goto IL_005e;
			case 3:
				goto IL_006f;
			case 9:
				goto IL_0086;
			case 2:
			case 5:
				goto IL_008f;
			case 1:
			case 4:
				goto IL_009d;
			case 8:
				while (true)
				{
					switch (num3)
					{
					case 2:
					case 3:
					case 4:
						break;
					default:
						goto IL_00be;
					case 0:
					case 1:
						goto IL_00e4;
					}
					break;
					IL_00be:
					num = 9;
					if (!STgGY7rmrQa02pAZXL())
					{
						continue;
					}
					goto IL_0118_2;
				}
				goto IL_0086;
			case 7:
				goto IL_00e4;
			case 6:
				switch (num2)
				{
				case 2:
				case 3:
					goto IL_0157;
				case 1:
				case 4:
					goto IL_016e;
				}
				goto IL_005e;
			case 11:
				{
					num2 = 3;
					goto IL_0157;
				}
				IL_0157:
				throw new ArgumentException((string?)uuDTLiltpdntIxZ3dn(Y3kOKS5HnPYnmQ4R3d(230078334, 5), object_1));
				IL_00e4:
				object_2 = new Uri((string)object_1, UriKind.Relative);
				goto IL_009d;
			}
			break;
		}
		goto IL_000e;
		IL_000e:
		byte[] array = default(byte[]);
		Stream stream = default(Stream);
		try
		{
			array = new byte[(int)h0RDWYwiCo2BMxJrpK(stream, 207, 201)];
			C27SsiUG9WG9Gfmg52();
			if (STgGY7rmrQa02pAZXL())
			{
				UvXm89dZ6lvCXNhqKQ(stream, array, 0, array.Length, 226, 207);
			}
		}
		finally
		{
			if (stream != null)
			{
				VRLOs59xD5y5y0uCdu(stream);
			}
		}
		num2 = 5;
		goto IL_005e;
		IL_005e:
		Assembly assembly = (Assembly)Ug2JD9CZHql2bZgFTR(array, 352, 324);
		goto IL_006f;
		IL_016e:
		return assembly;
		IL_0086:
		_ = 0;
		if (STgGY7rmrQa02pAZXL())
		{
			goto IL_008f;
		}
		goto IL_009d;
		IL_008f:
		num3 = 1;
		num = 8;
		if (!STgGY7rmrQa02pAZXL())
		{
			goto IL_009d;
		}
		goto IL_0118;
		IL_009d:
		stream = (Stream)Ax1r7QjfAdnn60BDKs(qZVGE0kwo54Nj3nhL2(object_0, object_2, 621, 602), 64, 41);
		goto IL_000e;
		IL_006f:
		if ((object)assembly == null)
		{
			num = 11;
			if (C27SsiUG9WG9Gfmg52())
			{
			}
			goto IL_0118;
		}
		num2 = 4;
		goto IL_016e;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		Class2.smethod_3();
		try
		{
			using Stream object_ = Class1.smethod_3(Class1.smethod_2(Class2.Class4.smethod_2(typeof(Class0).TypeHandle, 840, 782), 117, 59), Class2.smethod_2(230078310, 1), 33, 55);
			Package val = smethod_1(object_, FileMode.Open, FileAccess.Read, 975, 963);
			try
			{
				Assembly object_2 = smethod_0(val, Class2.smethod_2(230078296, 7));
				Class2.Class3.smethod_1(smethod_2(object_2, 266, 264), null, new object[1] { args }, 25, 122);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
	}

	internal static Package smethod_1(object object_0, FileMode fileMode_0, FileAccess fileAccess_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			default:
				while (true)
				{
					IL_0075:
					int num = 4;
					while (true)
					{
						num = 5;
						while (true)
						{
							switch (num)
							{
							case 6:
								num = 5;
								continue;
							case 2:
							case 4:
							case 7:
								goto end_IL_0049;
							case 1:
							case 5:
								goto end_IL_0071;
							case 0:
								goto end_IL_0080;
							}
							while (true)
							{
								IL_0007:
								_ = 1;
								if (C27SsiUG9WG9Gfmg52())
								{
									break;
								}
								while (true)
								{
									num = 5;
									if (!C27SsiUG9WG9Gfmg52())
									{
										switch (4)
										{
										case 7:
											break;
										case 0:
										case 2:
											continue;
										case 4:
										case 5:
										case 6:
										case 8:
											goto end_IL_0010;
										default:
											goto IL_0075;
										case 1:
											goto end_IL_0071;
										}
										goto IL_0007;
									}
									break;
									continue;
									end_IL_0010:
									break;
								}
								break;
							}
							continue;
							end_IL_0049:
							break;
						}
						continue;
						end_IL_0071:
						break;
					}
					break;
				}
				continue;
			case 12:
				{
					int num = 0;
					break;
				}
				end_IL_0080:
				break;
			}
			break;
		}
		return (Package)aowY3b2H3GvJ6taMAc(object_0, fileMode_0, fileAccess_0);
	}

	internal static MethodInfo smethod_2(object object_0, int int_0, int int_1)
	{
		STgGY7rmrQa02pAZXL();
		if (!C27SsiUG9WG9Gfmg52())
		{
			if (C27SsiUG9WG9Gfmg52())
			{
			}
			switch (7)
			{
			case 0:
			case 7:
				break;
			default:
				goto IL_0055;
			case 4:
			case 5:
			case 8:
				goto IL_005b;
			case 1:
			case 2:
			case 3:
				goto IL_0081;
			}
			goto IL_0047;
		}
		goto IL_0081;
		IL_0085:
		int num = 2;
		goto IL_0087;
		IL_0087:
		return (MethodInfo)qVgKEFFTsUvQx4b8lU(object_0);
		IL_0081:
		num = 4;
		goto IL_005b;
		IL_005b:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 4:
				goto IL_0047;
			case 0:
				num = 4;
				continue;
			default:
				goto IL_0081;
			case 1:
			case 2:
			case 3:
			case 5:
				goto IL_0087;
			}
			break;
		}
		goto IL_0043;
		IL_0047:
		switch (int_1 ^ int_0)
		{
		case 2:
			goto IL_0085;
		}
		goto IL_0055;
		IL_0055:
		num = 6;
		goto IL_0043;
		IL_0043:
		num = 4;
		goto IL_005b;
	}

	internal static Assembly smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 41:
				return (Assembly)evah61GKFX5dvteWaZ();
			}
		}
	}

	internal static void smethod_4(object object_0, object object_1, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 112:
				lgZqQxg9tQFZOCR1W0(object_0, object_1, int_0, int_1);
				return;
			}
		}
	}

	internal static Assembly smethod_5(object object_0, object object_1, object object_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 42:
				return (Assembly)QrOlWTWc885CllJF75(object_0, object_1, object_2);
			}
		}
	}

	internal static string[] smethod_6(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return (string[])ChIlLwocPkwk8klEO7(object_0);
			}
		}
	}

	internal static object qZVGE0kwo54Nj3nhL2(object object_0, object object_1, int int_0, int int_1)
	{
		return Class2.Class3.smethod_0(object_0, object_1, int_0, int_1);
	}

	internal static object Ax1r7QjfAdnn60BDKs(object object_0, int int_0, int int_1)
	{
		return Class2.Class4.smethod_0(object_0, int_0, int_1);
	}

	internal static long h0RDWYwiCo2BMxJrpK(object object_0, int int_0, int int_1)
	{
		return Class2.Class4.smethod_1(object_0, int_0, int_1);
	}

	internal static int UvXm89dZ6lvCXNhqKQ(object object_0, object object_1, int int_0, int int_1, int int_2, int int_3)
	{
		return Class1.smethod_0(object_0, object_1, int_0, int_1, int_2, int_3);
	}

	internal static void VRLOs59xD5y5y0uCdu(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object Ug2JD9CZHql2bZgFTR(object object_0, int int_0, int int_1)
	{
		return Class1.smethod_1(object_0, int_0, int_1);
	}

	internal static object Y3kOKS5HnPYnmQ4R3d(int int_0, int int_1)
	{
		return Class2.smethod_2(int_0, int_1);
	}

	internal static object uuDTLiltpdntIxZ3dn(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool STgGY7rmrQa02pAZXL()
	{
		return true;
	}

	internal static bool C27SsiUG9WG9Gfmg52()
	{
		return false;
	}

	internal static object aowY3b2H3GvJ6taMAc(object object_0, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return Package.Open((Stream)object_0, fileMode_0, fileAccess_0);
	}

	internal static object qVgKEFFTsUvQx4b8lU(object object_0)
	{
		return ((Assembly)object_0).EntryPoint;
	}

	internal static object evah61GKFX5dvteWaZ()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static void lgZqQxg9tQFZOCR1W0(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static object QrOlWTWc885CllJF75(object object_0, object object_1, object object_2)
	{
		return Assembly.Load((byte[])object_0, (byte[])object_1, (Evidence)object_2);
	}

	internal static object ChIlLwocPkwk8klEO7(object object_0)
	{
		return ((Assembly)object_0).GetManifestResourceNames();
	}
}
