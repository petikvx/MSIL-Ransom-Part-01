using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
public class BadPasswordException : ZipException
{
	public extern BadPasswordException();

	public extern BadPasswordException(string message);

	public extern BadPasswordException(string message, Exception innerException);

	protected unsafe BadPasswordException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_0010, IL_001c, IL_0023
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected native int or pointer, but got O
		//IL_001a: Expected native int or pointer, but got O
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		nuint num = (nuint)2u;
		nuint num2;
		checked
		{
			num2 = (nuint)(long)(((byte[])/*Error near IL_0003: Stack underflow*/)[num] << unchecked((int)/*Error near IL_0003: ldloc 2 (out-of-bounds)*/));
		}
		int num3 = *(int*)(nint)checked(/*Error near IL_0009: Stack underflow*/ + num2);
		_ = /*Error near IL_000b: Stack underflow*/& num3;
		/*Error near IL_000b: Invalid metadata token*/;
	}
}
