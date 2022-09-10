using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using EkIJjm7vjs8xMISmTn;

namespace ivPFWBLjP3D0KTGBB8g;

internal sealed class uDc1MtLJPKip5Eik5Ld
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bitmap uQtktiS5hZ(object _0020)
	{
		//Discarded unreachable code: IL_003e
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47751) + (string?)_0020 + teuVAA2ghHDQmtOkUp.dYB2ebULO8(47812));
			int num = 2;
			int num2 = num;
			object result;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					if (manifestResourceStream != null)
					{
						goto case 1;
					}
					result = null;
					break;
				default:
					num2 = 3;
					if (!NKfvCegPPbAfubqVE5c())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					result = (object)new Bitmap(manifestResourceStream);
					break;
				}
				break;
			}
			return (Bitmap)result;
		}
		catch
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Icon n9SkXRBSSD(object _0020)
	{
		//Discarded unreachable code: IL_003a
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47751) + (string?)_0020 + teuVAA2ghHDQmtOkUp.dYB2ebULO8(47821));
			int num = 2;
			object result;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					if (manifestResourceStream != null)
					{
						goto case 1;
					}
					result = null;
					break;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					result = (object)new Icon(manifestResourceStream);
					break;
				}
				break;
			}
			return (Icon)result;
		}
		catch
		{
			return null;
		}
	}

	internal static bool fLENEbgBpYAtRdrgdjM()
	{
		return true;
	}

	internal static bool NKfvCegPPbAfubqVE5c()
	{
		return false;
	}
}
