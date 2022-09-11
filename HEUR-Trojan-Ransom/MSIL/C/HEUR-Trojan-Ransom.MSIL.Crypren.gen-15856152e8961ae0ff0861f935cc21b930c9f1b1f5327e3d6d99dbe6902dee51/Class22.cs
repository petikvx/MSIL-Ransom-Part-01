using System;

internal class Class22 : IDisposable
{
	private GClass16 gclass16_0;

	public Class22(GClass16 gclass16_1)
	{
		gclass16_0 = gclass16_1;
	}

	public void Dispose()
	{
		Class6 @class = Delegate61.smethod_0(Delegate51.smethod_0(gclass16_0));
		try
		{
			Delegate170.smethod_0(gclass16_0);
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}
}
