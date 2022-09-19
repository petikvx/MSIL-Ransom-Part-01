using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class BootTrigger : Trigger, ITriggerDelay
{
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	[XmlIgnore]
	public TimeSpan Delay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((IBootTrigger)v2Trigger).Delay);
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			if (!unboundValues.ContainsKey("Delay"))
			{
				return TimeSpan.Zero;
			}
			return (TimeSpan)unboundValues["Delay"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((IBootTrigger)v2Trigger).Delay = Task.TimeSpanToString(value);
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["Delay"] = value;
		}
	}

	public BootTrigger()
		: base(TaskTriggerType.Boot)
	{
	}

	internal BootTrigger(ITaskTrigger iTrigger)
		: base(iTrigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.OnSystemStart)
	{
	}

	internal BootTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	protected override string V2GetTriggerString()
	{
		return Resources.TriggerBoot1;
	}
}
