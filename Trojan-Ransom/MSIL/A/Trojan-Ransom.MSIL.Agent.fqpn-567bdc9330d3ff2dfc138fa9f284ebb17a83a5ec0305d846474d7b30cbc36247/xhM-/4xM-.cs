using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace xhM_003D;

public class _4xM_003D
{
	public enum _9RM_003D
	{
		_9hM_003D,
		_9xM_003D,
		_002FBM_003D
	}

	public static readonly uint _5BM_003D;

	public static readonly uint _5RM_003D;

	public static readonly uint _5hM_003D;

	[DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int _5xM_003D(uint action, uint uParam, string vParam, uint winIni);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool _6BM_003D(string filePath, _9RM_003D style)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool _6BM_003D(Image image, _9RM_003D style)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _4xM_003D()
	{
	}

	static _4xM_003D()
	{
		_003CAgileDotNetRT_003E.Initialize();
		_003CAgileDotNetRT_003E.PostInitialize();
		_5BM_003D = 20u;
		_5RM_003D = 1u;
		_5hM_003D = 2u;
	}
}
