using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class LogonTrigger : Trigger, ITriggerDelay, ITriggerUserId
{
	[XmlIgnore]
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan Delay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((ILogonTrigger)v2Trigger).Delay);
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
				((ILogonTrigger)v2Trigger).Delay = Task.TimeSpanToString(value);
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["Delay"] = value;
		}
	}

	[DefaultValue(null)]
	[XmlIgnore]
	public string UserId
	{
		get
		{
			if (v2Trigger != null)
			{
				return ((ILogonTrigger)v2Trigger).UserId;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			if (!unboundValues.ContainsKey("UserId"))
			{
				return null;
			}
			return (string)unboundValues["UserId"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((ILogonTrigger)v2Trigger).UserId = value;
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["UserId"] = value;
		}
	}

	public LogonTrigger()
		: base(TaskTriggerType.Logon)
	{
	}

	internal LogonTrigger(ITaskTrigger iTrigger)
		: base(iTrigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.OnLogon)
	{
	}

	internal LogonTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	protected override string V2GetTriggerString()
	{
		string arg = (string.IsNullOrEmpty(UserId) ? Resources.TriggerAnyUser : UserId);
		return string.Format(Resources.TriggerLogon1, arg);
	}
}
