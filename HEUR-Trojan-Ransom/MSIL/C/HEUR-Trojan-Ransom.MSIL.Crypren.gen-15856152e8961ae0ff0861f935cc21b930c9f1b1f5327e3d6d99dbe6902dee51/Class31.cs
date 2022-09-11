using System;

internal class Class31 : IDisposable
{
	private readonly GClass16 gclass16_0;

	private readonly GClass10 gclass10_0;

	public Class31(GClass16 gclass16_1, GClass10 gclass10_1)
	{
		gclass16_0 = gclass16_1;
		gclass10_0 = gclass10_1;
	}

	public void Dispose()
	{
		Delegate306.smethod_0(gclass16_0, gclass10_0);
	}
}
