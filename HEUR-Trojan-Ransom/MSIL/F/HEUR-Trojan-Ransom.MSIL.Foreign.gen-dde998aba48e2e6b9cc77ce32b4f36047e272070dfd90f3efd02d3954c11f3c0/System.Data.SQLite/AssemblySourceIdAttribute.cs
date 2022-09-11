using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblySourceIdAttribute : Attribute
{
	private string sourceId;

	[NonSerialized]
	internal static GetString _0017;

	public string SourceId => sourceId;

	public AssemblySourceIdAttribute(string value)
	{
		sourceId = value;
	}

	static AssemblySourceIdAttribute()
	{
		Strings.CreateGetStringDelegate(typeof(AssemblySourceIdAttribute));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0017(107400542), _0017(107400505)), _0017(107400500), _0017(107400495)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0017(107400522)))
		{
			return;
		}
		throw new SecurityException(_0017(107400465));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
