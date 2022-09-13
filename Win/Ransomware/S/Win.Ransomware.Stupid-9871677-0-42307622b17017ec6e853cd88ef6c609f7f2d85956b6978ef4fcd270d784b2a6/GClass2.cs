public class GClass2
{
	private uint uint_0;

	public unsafe GClass2()
	{
		ushort num = *(ushort*)(nint)/*Error near IL_0002: Stack underflow*/;
		*(int*)(nint)/*Error near IL_0003: Stack underflow*/ = num;
		((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (object)/*Error near IL_0004: Stack underflow*/;
		switch (/*Error near IL_0009: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	public extern uint method_0(uint uint_1);
}
