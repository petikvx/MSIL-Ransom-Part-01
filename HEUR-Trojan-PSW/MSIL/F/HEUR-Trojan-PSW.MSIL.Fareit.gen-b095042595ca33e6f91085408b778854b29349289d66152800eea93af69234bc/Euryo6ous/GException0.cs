using System;

namespace Euryo6ous;

public class GException0 : Exception
{
	public GException0(int hr)
	{
		base.HResult = hr;
	}
}
