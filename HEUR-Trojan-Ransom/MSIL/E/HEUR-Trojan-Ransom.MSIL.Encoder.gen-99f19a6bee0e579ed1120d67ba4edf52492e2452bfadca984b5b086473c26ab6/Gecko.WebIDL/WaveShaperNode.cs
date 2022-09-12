using System;

namespace Gecko.WebIDL;

public class WaveShaperNode : WebIDLBase
{
	public IntPtr Curve
	{
		get
		{
			return GetProperty<IntPtr>("curve");
		}
		set
		{
			SetProperty("curve", value);
		}
	}

	public OverSampleType Oversample
	{
		get
		{
			return GetProperty<OverSampleType>("oversample");
		}
		set
		{
			SetProperty("oversample", value);
		}
	}

	public WaveShaperNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
