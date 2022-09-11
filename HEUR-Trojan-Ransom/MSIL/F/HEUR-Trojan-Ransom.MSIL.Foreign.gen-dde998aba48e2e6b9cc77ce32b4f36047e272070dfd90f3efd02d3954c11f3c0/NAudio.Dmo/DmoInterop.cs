using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

internal static class DmoInterop
{
	[NonSerialized]
	internal static GetString _009B;

	[DllImport("msdmo.dll")]
	public static extern int DMOEnum([In] ref Guid guidCategory, DmoEnumFlags flags, int inTypes, [In] DmoPartialMediaType[] inTypesArray, int outTypes, [In] DmoPartialMediaType[] outTypesArray, out IEnumDmo enumDmo);

	[DllImport("msdmo.dll")]
	public static extern int MoFreeMediaType([In] ref DmoMediaType mediaType);

	[DllImport("msdmo.dll")]
	public static extern int MoInitMediaType([In][Out] ref DmoMediaType mediaType, int formatBlockBytes);

	[DllImport("msdmo.dll")]
	public static extern int DMOGetName([In] ref Guid clsidDMO, [Out] StringBuilder name);

	static DmoInterop()
	{
		Strings.CreateGetStringDelegate(typeof(DmoInterop));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009B(107397530), _009B(107397493)), _009B(107397488), _009B(107397483)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009B(107397510)))
		{
			return;
		}
		throw new SecurityException(_009B(107397453));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
