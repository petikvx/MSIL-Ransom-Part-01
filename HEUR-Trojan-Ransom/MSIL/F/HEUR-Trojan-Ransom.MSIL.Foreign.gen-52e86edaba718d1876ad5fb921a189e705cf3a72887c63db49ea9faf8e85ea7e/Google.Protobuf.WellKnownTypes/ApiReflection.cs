using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public static class ApiReflection
{
	private static FileDescriptor descriptor;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => descriptor;

	static ApiReflection()
	{
		Strings.CreateGetStringDelegate(typeof(ApiReflection));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399867), getString_0(107399862)).Replace(getString_0(107399825), getString_0(107399820)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399815)))
		{
			throw new SecurityException(getString_0(107399790));
		}
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107461803) + getString_0(107461754) + getString_0(107461641) + getString_0(107462104) + getString_0(107461991) + getString_0(107461942) + getString_0(107461349) + getString_0(107461236) + getString_0(107461187) + getString_0(107461586) + getString_0(107461537) + getString_0(107461424) + getString_0(107460863) + getString_0(107460750) + getString_0(107460701) + getString_0(107461100) + getString_0(107461051)), new FileDescriptor[2]
		{
			SourceContextReflection.Descriptor,
			TypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[3]
		{
			new GeneratedClrTypeInfo(typeof(Api), Api.Parser, new string[7]
			{
				getString_0(107392878),
				getString_0(107460994),
				getString_0(107460949),
				getString_0(107460936),
				getString_0(107460955),
				getString_0(107460902),
				getString_0(107460925)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Method), Method.Parser, new string[7]
			{
				getString_0(107392878),
				getString_0(107460884),
				getString_0(107460895),
				getString_0(107460326),
				getString_0(107460305),
				getString_0(107460949),
				getString_0(107460925)
			}, null, null, null),
			new GeneratedClrTypeInfo(typeof(Mixin), Mixin.Parser, new string[2]
			{
				getString_0(107392878),
				getString_0(107460312)
			}, null, null, null)
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
