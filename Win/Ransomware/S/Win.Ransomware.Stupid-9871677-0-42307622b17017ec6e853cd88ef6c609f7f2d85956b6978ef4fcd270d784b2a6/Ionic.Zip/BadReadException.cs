using System;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
public class BadReadException : ZipException
{
	public BadReadException()
	{
		//Discarded unreachable code: IL_0006
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected native int or pointer, but got O
		//IL_0010: Expected native int or pointer, but got O
		_ = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public extern BadReadException(string message);

	public BadReadException(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_0001, IL_0008, IL_000d
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xF9*/;
	}

	protected extern BadReadException(SerializationInfo info, StreamingContext context);
}
