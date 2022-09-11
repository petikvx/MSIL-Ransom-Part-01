using System;
using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Class5
{
	private class Class6
	{
		static Class6()
		{
			int num = 4;
			if (!tnrW6U7iGwv0jShgok())
			{
				goto IL_0025;
			}
			goto IL_0055;
			IL_0055:
			Assembly executingAssembly = default(Assembly);
			bool bool_ = default(bool);
			switch (num)
			{
			case 5:
				executingAssembly = Assembly.GetExecutingAssembly();
				goto case 2;
			case 2:
			case 3:
				if (Class17.StrongNameSignatureVerificationEx_5(executingAssembly.Location, bool_0: true, out bool_))
				{
					break;
				}
				goto IL_0078;
			case 0:
			case 4:
				goto IL_0047;
			case 6:
				return;
			}
			goto IL_0025;
			IL_0047:
			bool_ = false;
			num = 5;
			if (!xP8Gv35OAlLrSyLlVj())
			{
			}
			goto IL_0055;
			IL_0078:
			throw new SecurityException("Assembly has been tampered");
			IL_0025:
			if (bool_ && executingAssembly.FullName!.EndsWith("34256fcd934ca661"))
			{
				num = 6;
				if (!tnrW6U7iGwv0jShgok())
				{
					goto IL_0047;
				}
				goto IL_0055;
			}
			goto IL_0078;
		}

		internal static bool tnrW6U7iGwv0jShgok()
		{
			return true;
		}

		internal static bool xP8Gv35OAlLrSyLlVj()
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
			bool bool_ = default(bool);
			Assembly executingAssembly = default(Assembly);
			if (BpYHjOogPJZ9mKOGIw())
			{
				switch (1)
				{
				case 1:
					bool_ = false;
					goto case 5;
				case 5:
					executingAssembly = Assembly.GetExecutingAssembly();
					break;
				case 0:
				case 2:
					break;
				default:
					goto IL_004a;
				case 6:
					return;
				}
			}
			if (Class17.StrongNameSignatureVerificationEx_7(executingAssembly.Location, bool_0: true, out bool_))
			{
				goto IL_004a;
			}
			goto IL_005f;
			IL_004a:
			if (bool_ && executingAssembly.FullName!.EndsWith("34256fcd934ca661"))
			{
				return;
			}
			goto IL_005f;
			IL_005f:
			throw new SecurityException("Assembly has been tampered");
		}

		internal static bool BpYHjOogPJZ9mKOGIw()
		{
			return true;
		}

		internal static bool DJCHc2m1yc9GQcN6KZ()
		{
			return false;
		}
	}

	public class Class9
	{
		[STAThread]
		public static void Main()
		{
			if (Class17.smethod_126())
			{
				Class11 class10_ = new Class11();
				Class17.smethod_89((Class10)class10_);
			}
		}

		internal static bool NhVDicau4V8wcrIiCl()
		{
			return true;
		}

		internal static bool aeDhXIMGvof1eWRXDm()
		{
			return false;
		}
	}

	public class Class11 : Class10
	{
		internal static bool KN0R1CQIBuEIPoIjWJ()
		{
			return true;
		}

		internal static bool hHYDv1jlVLIf8i3RxP()
		{
			return false;
		}
	}

	public class Class10
	{
		static Class10()
		{
			while (true)
			{
				bool bool_ = false;
				while (true)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					while (true)
					{
						IL_004a:
						if (Class17.StrongNameSignatureVerificationEx(executingAssembly.Location, bool_0: true, out bool_) && bool_)
						{
							while (executingAssembly.FullName!.EndsWith("34256fcd934ca661"))
							{
								if (WhnmXo86kjFjUBV6gP())
								{
									switch (6)
									{
									case 2:
										goto IL_004a;
									case 4:
										goto end_IL_004a;
									case 0:
									case 5:
										goto end_IL_005c;
									case 6:
										return;
									}
									continue;
								}
								goto IL_004a;
							}
						}
						throw new SecurityException("Assembly has been tampered");
						continue;
						end_IL_004a:
						break;
					}
					continue;
					end_IL_005c:
					break;
				}
			}
		}

		internal static bool WhnmXo86kjFjUBV6gP()
		{
			return true;
		}

		internal static bool Eoe2kvR6uxWXudcL3C()
		{
			return false;
		}
	}

	internal static bool WSI7OJflWDiAtTu37v()
	{
		return true;
	}

	internal static bool SG3oK5XJcM2hoOndNA()
	{
		return false;
	}
}
