using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlType(IncludeInSchema = false)]
public sealed class SessionStateChangeTrigger : Trigger, ITriggerDelay, ITriggerUserId
{
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan Delay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((ISessionStateChangeTrigger)v2Trigger).Delay);
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
				((ISessionStateChangeTrigger)v2Trigger).Delay = Task.TimeSpanToString(value);
			}
			else
			{
				unboundValues["Delay"] = value;
			}
		}
	}

	[DefaultValue(1)]
	public TaskSessionStateChangeType StateChange
	{
		get
		{
			if (v2Trigger != null)
			{
				return ((ISessionStateChangeTrigger)v2Trigger).StateChange;
			}
			if (!unboundValues.ContainsKey("StateChange"))
			{
				return TaskSessionStateChangeType.ConsoleConnect;
			}
			return (TaskSessionStateChangeType)unboundValues["StateChange"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((ISessionStateChangeTrigger)v2Trigger).StateChange = value;
			}
			else
			{
				unboundValues["StateChange"] = value;
			}
		}
	}

	[DefaultValue(null)]
	public string UserId
	{
		get
		{
			if (v2Trigger != null)
			{
				return ((ISessionStateChangeTrigger)v2Trigger).UserId;
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
				((ISessionStateChangeTrigger)v2Trigger).UserId = value;
			}
			else
			{
				unboundValues["UserId"] = value;
			}
		}
	}

	public SessionStateChangeTrigger()
		: base(TaskTriggerType.SessionStateChange)
	{
	}

	public SessionStateChangeTrigger(TaskSessionStateChangeType stateChange)
		: this()
	{
		StateChange = stateChange;
	}

	internal SessionStateChangeTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	public override void CopyProperties(Trigger sourceTrigger)
	{
		base.CopyProperties(sourceTrigger);
		if ((object)sourceTrigger.GetType() == GetType() && !StateChangeIsSet())
		{
			StateChange = ((SessionStateChangeTrigger)sourceTrigger).StateChange;
		}
	}

	protected override string V2GetTriggerString()
	{
		string @string = Resources.ResourceManager.GetString("TriggerSession" + StateChange);
		string arg = (string.IsNullOrEmpty(UserId) ? Resources.TriggerAnyUser : UserId);
		if (StateChange != TaskSessionStateChangeType.SessionLock && StateChange != TaskSessionStateChangeType.SessionUnlock)
		{
			arg = string.Format(Resources.TriggerSessionUserSession, arg);
		}
		return string.Format(@string, arg);
	}

	internal bool StateChangeIsSet()
	{
		if (v2Trigger == null)
		{
			return unboundValues.ContainsKey("StateChange");
		}
		return true;
	}
}
