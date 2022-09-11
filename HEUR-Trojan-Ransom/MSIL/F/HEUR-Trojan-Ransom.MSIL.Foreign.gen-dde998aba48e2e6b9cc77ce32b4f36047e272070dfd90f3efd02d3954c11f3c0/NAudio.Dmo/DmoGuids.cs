using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

internal static class DmoGuids
{
	public static readonly Guid DMOCATEGORY_AUDIO_DECODER;

	public static readonly Guid DMOCATEGORY_AUDIO_ENCODER;

	public static readonly Guid DMOCATEGORY_VIDEO_DECODER;

	public static readonly Guid DMOCATEGORY_VIDEO_ENCODER;

	public static readonly Guid DMOCATEGORY_AUDIO_EFFECT;

	public static readonly Guid DMOCATEGORY_VIDEO_EFFECT;

	public static readonly Guid DMOCATEGORY_AUDIO_CAPTURE_EFFECT;

	[NonSerialized]
	internal static GetString _008B;

	static DmoGuids()
	{
		Strings.CreateGetStringDelegate(typeof(DmoGuids));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_008B(107397513), _008B(107397476)).Replace(_008B(107397471), _008B(107397466)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_008B(107397493)))
		{
			throw new SecurityException(_008B(107397436));
		}
		DMOCATEGORY_AUDIO_DECODER = new Guid(_008B(107392747));
		DMOCATEGORY_AUDIO_ENCODER = new Guid(_008B(107392666));
		DMOCATEGORY_VIDEO_DECODER = new Guid(_008B(107392649));
		DMOCATEGORY_VIDEO_ENCODER = new Guid(_008B(107392568));
		DMOCATEGORY_AUDIO_EFFECT = new Guid(_008B(107392007));
		DMOCATEGORY_VIDEO_EFFECT = new Guid(_008B(107391990));
		DMOCATEGORY_AUDIO_CAPTURE_EFFECT = new Guid(_008B(107391909));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
