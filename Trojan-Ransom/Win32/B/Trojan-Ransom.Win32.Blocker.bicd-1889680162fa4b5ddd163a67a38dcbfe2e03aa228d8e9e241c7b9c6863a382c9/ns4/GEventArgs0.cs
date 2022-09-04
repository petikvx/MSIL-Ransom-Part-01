using System;

namespace ns4;

public class GEventArgs0 : EventArgs
{
	internal Exception exception_0;

	public Exception FatalException => exception_0;

	internal GEventArgs0(Exception exception_1)
	{
		Exception ex = (exception_0 = exception_1);
	}

	static GEventArgs0()
	{
		GClass11.smethod_0();
	}
}
