using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlType(IncludeInSchema = false)]
public sealed class RegistrationTrigger : Trigger, ITriggerDelay
{
	[XmlIgnore]
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan Delay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((IRegistrationTrigger)v2Trigger).Delay);
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
				((IRegistrationTrigger)v2Trigger).Delay = Task.TimeSpanToString(value);
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["Delay"] = value;
		}
	}

	public RegistrationTrigger()
		: base(TaskTriggerType.Registration)
	{
	}

	internal RegistrationTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	protected override string V2GetTriggerString()
	{
		return Resources.TriggerRegistration1;
	}
}
