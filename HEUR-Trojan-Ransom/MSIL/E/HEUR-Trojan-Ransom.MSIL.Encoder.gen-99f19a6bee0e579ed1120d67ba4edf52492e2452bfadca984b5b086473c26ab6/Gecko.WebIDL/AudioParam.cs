using System;

namespace Gecko.WebIDL;

public class AudioParam : WebIDLBase
{
	public float Value
	{
		get
		{
			return GetProperty<float>("value");
		}
		set
		{
			SetProperty("value", value);
		}
	}

	public float DefaultValue => GetProperty<float>("defaultValue");

	public uint ParentNodeId => GetProperty<uint>("parentNodeId");

	public string Name => GetProperty<string>("name");

	public AudioParam(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetValueAtTime(float value, double startTime)
	{
		CallVoidMethod("setValueAtTime", value, startTime);
	}

	public void LinearRampToValueAtTime(float value, double endTime)
	{
		CallVoidMethod("linearRampToValueAtTime", value, endTime);
	}

	public void ExponentialRampToValueAtTime(float value, double endTime)
	{
		CallVoidMethod("exponentialRampToValueAtTime", value, endTime);
	}

	public void SetTargetAtTime(float target, double startTime, double timeConstant)
	{
		CallVoidMethod("setTargetAtTime", target, startTime, timeConstant);
	}

	public void SetValueCurveAtTime(IntPtr values, double startTime, double duration)
	{
		CallVoidMethod("setValueCurveAtTime", values, startTime, duration);
	}

	public void CancelScheduledValues(double startTime)
	{
		CallVoidMethod("cancelScheduledValues", startTime);
	}
}
