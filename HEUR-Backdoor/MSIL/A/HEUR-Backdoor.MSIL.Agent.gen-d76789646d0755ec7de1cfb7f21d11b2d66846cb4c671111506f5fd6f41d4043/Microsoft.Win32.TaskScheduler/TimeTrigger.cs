using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class TimeTrigger : Trigger, ITriggerDelay
{
	[XmlIgnore]
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan RandomDelay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((ITimeTrigger)v2Trigger).RandomDelay);
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			if (!unboundValues.ContainsKey("RandomDelay"))
			{
				return TimeSpan.Zero;
			}
			return (TimeSpan)unboundValues["RandomDelay"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((ITimeTrigger)v2Trigger).RandomDelay = Task.TimeSpanToString(value);
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["RandomDelay"] = value;
		}
	}

	TimeSpan ITriggerDelay.Delay
	{
		get
		{
			return RandomDelay;
		}
		set
		{
			RandomDelay = value;
		}
	}

	public TimeTrigger()
		: base(TaskTriggerType.Time)
	{
	}

	public TimeTrigger(DateTime startBoundary)
		: base(TaskTriggerType.Time)
	{
		base.StartBoundary = startBoundary;
	}

	internal TimeTrigger(ITaskTrigger iTrigger)
		: base(iTrigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunOnce)
	{
	}

	internal TimeTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	protected override string V2GetTriggerString()
	{
		return string.Format(Resources.TriggerTime1, Trigger.AdjustToLocal(base.StartBoundary));
	}
}
