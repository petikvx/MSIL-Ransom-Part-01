using System;

namespace Gecko.WebIDL;

public class SourceBuffer : WebIDLBase
{
	public SourceBufferAppendMode Mode
	{
		get
		{
			return GetProperty<SourceBufferAppendMode>("mode");
		}
		set
		{
			SetProperty("mode", value);
		}
	}

	public bool Updating => GetProperty<bool>("updating");

	public nsISupports Buffered => GetProperty<nsISupports>("buffered");

	public double TimestampOffset
	{
		get
		{
			return GetProperty<double>("timestampOffset");
		}
		set
		{
			SetProperty("timestampOffset", value);
		}
	}

	public double AppendWindowStart
	{
		get
		{
			return GetProperty<double>("appendWindowStart");
		}
		set
		{
			SetProperty("appendWindowStart", value);
		}
	}

	public double AppendWindowEnd
	{
		get
		{
			return GetProperty<double>("appendWindowEnd");
		}
		set
		{
			SetProperty("appendWindowEnd", value);
		}
	}

	public SourceBuffer(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void AppendBuffer(IntPtr data)
	{
		CallVoidMethod("appendBuffer", data);
	}

	public void Abort()
	{
		CallVoidMethod("abort");
	}

	public void Remove(double start, double end)
	{
		CallVoidMethod("remove", start, end);
	}
}
