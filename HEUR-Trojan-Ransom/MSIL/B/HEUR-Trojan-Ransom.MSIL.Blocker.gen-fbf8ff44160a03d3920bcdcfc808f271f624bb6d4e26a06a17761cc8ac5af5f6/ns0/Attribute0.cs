using System;

namespace ns0;

internal class Attribute0 : Attribute
{
	public unsafe Attribute0(string string_0)
	{
		//IL_0004: Expected F4, but got I4
		ushort num;
		checked
		{
			num = (ushort)unchecked((uint)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/));
		}
		*(float*)(nint)/*Error near IL_0004: Stack underflow*/ = (int)num;
		/*Error: Unexpected end of block*/;
	}
}
