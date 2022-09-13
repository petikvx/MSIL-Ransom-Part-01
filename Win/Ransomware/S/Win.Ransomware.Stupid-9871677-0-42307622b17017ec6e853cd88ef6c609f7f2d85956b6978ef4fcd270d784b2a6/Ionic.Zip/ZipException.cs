using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00006")]
public class ZipException : Exception
{
	public ZipException()
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0013, IL_001b, IL_0021, IL_002e
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected F8, but got I8
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		_ = ((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public extern ZipException(string message);

	public extern ZipException(string message, Exception innerException);

	protected extern ZipException(SerializationInfo info, StreamingContext context);
}
