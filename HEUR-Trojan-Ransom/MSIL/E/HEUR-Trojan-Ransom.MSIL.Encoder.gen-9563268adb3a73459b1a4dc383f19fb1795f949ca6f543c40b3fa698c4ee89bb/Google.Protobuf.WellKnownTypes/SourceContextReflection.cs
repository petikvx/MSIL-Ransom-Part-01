using System;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes;

public static class SourceContextReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SourceContextReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRnb29nbGUvcHJvdG9idWYvc291cmNlX2NvbnRleHQucHJvdG8SD2dvb2ds" + "ZS5wcm90b2J1ZiIiCg1Tb3VyY2VDb250ZXh0EhEKCWZpbGVfbmFtZRgBIAEo" + "CUKVAQoTY29tLmdvb2dsZS5wcm90b2J1ZkISU291cmNlQ29udGV4dFByb3Rv" + "UAFaQWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL3Byb3RvYnVmL3NvdXJj" + "ZV9jb250ZXh0O3NvdXJjZV9jb250ZXh0ogIDR1BCqgIeR29vZ2xlLlByb3Rv" + "YnVmLldlbGxLbm93blR5cGVzYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SourceContext), SourceContext.Parser, new string[1] { "FileName" }, null, null, null)
		}));
	}
}
