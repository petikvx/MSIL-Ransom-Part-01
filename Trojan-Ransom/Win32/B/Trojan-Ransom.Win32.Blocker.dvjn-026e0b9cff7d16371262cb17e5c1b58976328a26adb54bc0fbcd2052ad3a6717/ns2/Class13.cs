using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2;

[StandardModule]
internal sealed class Class13
{
	[CompilerGenerated]
	internal class Class14
	{
		[CompilerGenerated]
		internal class Class15
		{
			public int int_0;

			public int int_1;

			public Class14 class14_0;

			[SpecialName]
			[CompilerGenerated]
			public void method_0()
			{
				Thread.CurrentThread.IsBackground = true;
				string string_ = "fsdfsd";
				Class17.DhcpDeRegisterParamChange(15L, ref string_);
				string_ = "fsdfsdgsdgsdgsd";
				string string_2 = "GSDGSDGSDGSD";
				Class12 class12_ = default(Class12);
				Class17.ldap_modrdn(ref class12_, ref string_, ref string_2);
				Class16.Struct0 struct0_ = class14_0.struct0_0;
				uint uint_ = checked((uint)int_0);
				int num = int_1;
				Class17.smethod_97(uint_, num, struct0_);
				bool bool_ = true;
				Class17.GetObjectA(15324234L, 21452142152132L, ref bool_);
				string_2 = "fsdgsdgsdgsdg";
				string_ = "fsdgsdgsdg";
				Class17.OemToCharBuffA(ref string_2, ref string_, 43243434343L);
			}

			internal static bool oVD6dovCvf7ToawLlO()
			{
				return true;
			}

			internal static bool tS2XUDxFphG6gLyXXC()
			{
				return false;
			}
		}

		public Class16.Struct0 struct0_0;
	}

	internal static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Class17.GetProcAddress(Class17.LoadLibraryA(ref string_0), string_1), typeof(T));
	}

	static Class13()
	{
		while (true)
		{
			bool bool_ = false;
			while (true)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				int num = 2;
				if (YVBIgoPYH5cxBm4xXI())
				{
					while (true)
					{
						switch (num)
						{
						default:
							num = 4;
							if (!s3C8M31fVQlL9OR0Vt())
							{
							}
							continue;
						case 1:
						case 3:
							break;
						case 0:
						case 5:
							goto end_IL_0032;
						case 2:
							goto IL_004b;
						case 4:
							goto IL_005b;
						case 6:
							return;
						}
						break;
					}
					continue;
				}
				goto IL_004b;
				IL_0070:
				throw new SecurityException("Assembly has been tampered");
				IL_004b:
				if (Class17.StrongNameSignatureVerificationEx_1(executingAssembly.Location, bool_0: true, out bool_))
				{
					goto IL_005b;
				}
				goto IL_0070;
				IL_005b:
				if (bool_ && executingAssembly.FullName!.EndsWith("34256fcd934ca661"))
				{
					return;
				}
				goto IL_0070;
				continue;
				end_IL_0032:
				break;
			}
		}
	}

	internal static bool YVBIgoPYH5cxBm4xXI()
	{
		return true;
	}

	internal static bool s3C8M31fVQlL9OR0Vt()
	{
		return false;
	}
}
