using System;
using _0023ab;

namespace _0023w;

internal sealed class _0023v
{
	private static Version _0001 = new Version(_00239._00237(107395595));

	private static string _0002 = null;

	public static Version Version => _0001;

	public static string AppName => _00239._00237(107395666) + _00239._00237(107395645) + MajorVersion;

	public static string TitleVersion => _0002 ?? (_0002 = string.Format(_00239._00237(107395640), _0001.Major, _0001.Minor));

	public static int MajorVersion => _0001.Major;

	public static string AppNameMinusVersion => _00239._00237(107395666);

	private _0023v()
	{
	}
}
