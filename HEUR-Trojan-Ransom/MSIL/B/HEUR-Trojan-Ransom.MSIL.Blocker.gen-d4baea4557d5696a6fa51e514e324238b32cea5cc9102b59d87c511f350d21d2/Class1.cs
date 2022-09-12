using System;

internal class Class1
{
	[STAThread]
	private static extern void Main();

	public Class1()
	{
		switch (/*Error near IL_0005: Stack underflow*/)
		{
		default:
			;
			break;
		}
		checked
		{
			_ = (int)/*Error near IL_0006: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}
}
