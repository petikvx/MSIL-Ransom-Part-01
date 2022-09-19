using System;
using System.Collections.Generic;

public sealed class GClass5 : List<GClass4>
{
	private delegate void Delegate2(GEventArgs0 kex);

	private Delegate2 delegate2_0;

	public void method_0(GClass4 hks)
	{
		delegate2_0 = (Delegate2)Delegate.Combine(delegate2_0, new Delegate2(hks.method_6));
		Add(hks);
	}

	public void method_1(GClass4 hks)
	{
		delegate2_0 = (Delegate2)Delegate.Remove(delegate2_0, new Delegate2(hks.method_6));
		Remove(hks);
	}

	internal void method_2(GEventArgs0 e)
	{
		if (delegate2_0 != null)
		{
			delegate2_0(e);
		}
	}
}
