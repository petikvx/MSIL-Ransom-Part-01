using System;
using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace ns1;

[StandardModule]
internal sealed class Class5
{
	private class Class6
	{
		static Class6()
		{
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (!Class12.StrongNameSignatureVerificationEx_5(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
			{
				throw new SecurityException(Class32.smethod_0(255));
			}
		}

		internal static bool GHwKiiLUb1Lu733XHY()
		{
			return true;
		}

		internal static bool JymBLBBvXJC2EBGsGh()
		{
			return false;
		}
	}

	private class Class7
	{
	}

	private class Class8
	{
		static Class8()
		{
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (!Class12.StrongNameSignatureVerificationEx_9(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
			{
				throw new SecurityException(Class32.smethod_0(255));
			}
		}

		internal static bool AuVnJGgrPetMfS20lU()
		{
			return true;
		}

		internal static bool BTqL9qPdgyyBTtN7Dq()
		{
			return false;
		}
	}

	public class Class9
	{
		[STAThread]
		public static void Main()
		{
			if (Class57.smethod_0())
			{
				Class11 class10_ = new Class11();
				Class12.smethod_120((Class10)class10_);
			}
		}

		static Class9()
		{
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (!Class12.StrongNameSignatureVerificationEx(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
			{
				throw new SecurityException(Class32.smethod_0(255));
			}
		}

		internal static bool je7hMwHv2TdsPoxbQW()
		{
			return true;
		}

		internal static bool B1MIJtN4rb0029eFTh()
		{
			return false;
		}
	}

	public class Class11 : Class10
	{
		static Class11()
		{
			while (true)
			{
				bool bool_ = false;
				while (true)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					int num;
					if (Class12.StrongNameSignatureVerificationEx_11(executingAssembly.Location, bool_0: true, out bool_))
					{
						num = 2;
						if (SQxDerE67OxARtjkYP())
						{
							goto IL_0010;
						}
						goto IL_003a;
					}
					goto IL_007a;
					IL_007a:
					throw new SecurityException(Class32.smethod_0(255));
					IL_003a:
					switch (num)
					{
					case 2:
						goto IL_0035;
					case 1:
					case 3:
						continue;
					case 0:
					case 5:
						goto end_IL_005d;
					case 6:
						return;
					}
					goto IL_0010;
					IL_0035:
					if (bool_)
					{
						goto IL_0010;
					}
					goto IL_007a;
					IL_0010:
					if (executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
					{
						num = 6;
						if (!h9IkNB8BYVHMyJpWPG())
						{
							break;
						}
						goto IL_003a;
					}
					goto IL_007a;
					continue;
					end_IL_005d:
					break;
				}
			}
		}

		internal static bool h9IkNB8BYVHMyJpWPG()
		{
			return true;
		}

		internal static bool SQxDerE67OxARtjkYP()
		{
			return false;
		}
	}

	public class Class10
	{
		static Class10()
		{
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (!Class12.StrongNameSignatureVerificationEx_10(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
			{
				throw new SecurityException(Class32.smethod_0(255));
			}
		}

		internal static bool SAxQHWukRKhoajiIDt()
		{
			return true;
		}

		internal static bool cQW22NXONLkHPrrOHM()
		{
			return false;
		}
	}

	static Class5()
	{
		bool bool_ = default(bool);
		Assembly executingAssembly = default(Assembly);
		if (IMbO4NYnunlCW6vUmn())
		{
			switch (5)
			{
			case 0:
			case 5:
				bool_ = false;
				goto case 1;
			case 1:
			case 2:
				executingAssembly = Assembly.GetExecutingAssembly();
				if (Class12.StrongNameSignatureVerificationEx_3(executingAssembly.Location, bool_0: true, out bool_))
				{
					break;
				}
				goto IL_0064;
			case 3:
				break;
			default:
				goto IL_004d;
			case 6:
				return;
			}
		}
		if (bool_)
		{
			goto IL_004d;
		}
		goto IL_0064;
		IL_004d:
		if (executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
		{
			return;
		}
		goto IL_0064;
		IL_0064:
		throw new SecurityException(Class32.smethod_0(255));
	}

	internal static bool IMbO4NYnunlCW6vUmn()
	{
		return true;
	}

	internal static bool mpEmtyxuVErSsUIDSB()
	{
		return false;
	}
}
