using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.WellKnownTypes;

public static class StructReflection
{
	private static FileDescriptor descriptor;

	[NonSerialized]
	internal static GetString getString_0;

	public static FileDescriptor Descriptor => descriptor;

	static StructReflection()
	{
		Strings.CreateGetStringDelegate(typeof(StructReflection));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399956), getString_0(107399951)).Replace(getString_0(107399914), getString_0(107399909)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399904)))
		{
			throw new SecurityException(getString_0(107399879));
		}
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(getString_0(107458952) + getString_0(107458391) + getString_0(107458278) + getString_0(107458229) + getString_0(107458628) + getString_0(107458579) + getString_0(107458466) + getString_0(107458417) + getString_0(107457792) + getString_0(107457743) + getString_0(107457662) + getString_0(107458061) + getString_0(107458012) + getString_0(107457899) + getString_0(107457338)), new FileDescriptor[0], new GeneratedClrTypeInfo(new System.Type[1] { typeof(NullValue) }, new GeneratedClrTypeInfo[3]
		{
			new GeneratedClrTypeInfo(typeof(Struct), Struct.Parser, new string[1] { getString_0(107457281) }, null, null, new GeneratedClrTypeInfo[1]),
			new GeneratedClrTypeInfo(typeof(Value), Value.Parser, new string[6]
			{
				getString_0(107457304),
				getString_0(107457259),
				getString_0(107457274),
				getString_0(107457225),
				getString_0(107457244),
				getString_0(107457195)
			}, new string[1] { getString_0(107457214) }, null, null),
			new GeneratedClrTypeInfo(typeof(ListValue), ListValue.Parser, new string[1] { getString_0(107457205) }, null, null, null)
		}));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
