using System;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public static class EmptyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EmptyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8SD2dvb2dsZS5wcm90b2J1" + "ZiIHCgVFbXB0eUJ2ChNjb20uZ29vZ2xlLnByb3RvYnVmQgpFbXB0eVByb3Rv" + "UAFaJ2dpdGh1Yi5jb20vZ29sYW5nL3Byb3RvYnVmL3B0eXBlcy9lbXB0efgB" + "AaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Empty), Empty.Parser, null, null, null, null)
		}));
	}
}
