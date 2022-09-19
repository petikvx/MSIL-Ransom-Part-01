using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public abstract class Trigger : IDisposable, ICloneable
{
	internal const string V2BoundaryDateFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'FFFK";

	internal static readonly CultureInfo DefaultDateCulture = CultureInfo.CreateSpecificCulture("en-US");

	internal TaskTriggerType ttype;

	internal ITaskTrigger v1Trigger;

	internal TaskTrigger v1TriggerData;

	internal ITrigger v2Trigger;

	protected Dictionary<string, object> unboundValues;

	private RepetitionPattern repititionPattern;

	private static Type timeSpan2Type = null;

	private static bool? foundTimeSpan2 = null;

	public bool Enabled
	{
		get
		{
			if (v2Trigger != null)
			{
				return v2Trigger.Enabled;
			}
			return (v1TriggerData.Flags & TaskTriggerFlags.Disabled) != TaskTriggerFlags.Disabled;
		}
		set
		{
			if (v2Trigger != null)
			{
				v2Trigger.Enabled = value;
				return;
			}
			if (!value)
			{
				v1TriggerData.Flags |= TaskTriggerFlags.Disabled;
			}
			else
			{
				v1TriggerData.Flags &= ~TaskTriggerFlags.Disabled;
			}
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["Enabled"] = value;
			}
		}
	}

	[DefaultValue(typeof(DateTime), "9999-12-31T23:59:59.9999999")]
	public DateTime EndBoundary
	{
		get
		{
			if (v2Trigger != null)
			{
				if (!string.IsNullOrEmpty(v2Trigger.EndBoundary))
				{
					return DateTime.Parse(v2Trigger.EndBoundary, DefaultDateCulture);
				}
				return DateTime.MaxValue;
			}
			if (unboundValues != null && unboundValues.ContainsKey("EndBoundary"))
			{
				return (DateTime)unboundValues["EndBoundary"];
			}
			return v1TriggerData.EndDate;
		}
		set
		{
			if (v2Trigger != null)
			{
				v2Trigger.EndBoundary = ((value == DateTime.MaxValue) ? null : value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'FFFK", DefaultDateCulture));
				return;
			}
			v1TriggerData.EndDate = value;
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["EndBoundary"] = value;
			}
		}
	}

	[XmlIgnore]
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan ExecutionTimeLimit
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(v2Trigger.ExecutionTimeLimit);
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			if (unboundValues != null && unboundValues.ContainsKey("ExecutionTimeLimit"))
			{
				return (TimeSpan)unboundValues["ExecutionTimeLimit"];
			}
			return TimeSpan.Zero;
		}
		set
		{
			if (v2Trigger != null)
			{
				v2Trigger.ExecutionTimeLimit = Task.TimeSpanToString(value);
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["ExecutionTimeLimit"] = value;
		}
	}

	[XmlIgnore]
	[DefaultValue(null)]
	public string Id
	{
		get
		{
			if (v2Trigger != null)
			{
				return v2Trigger.Id;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			if (!unboundValues.ContainsKey("Id"))
			{
				return null;
			}
			return (string)unboundValues["Id"];
		}
		set
		{
			if (v2Trigger != null)
			{
				v2Trigger.Id = value;
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["Id"] = value;
		}
	}

	public RepetitionPattern Repetition
	{
		get
		{
			if (repititionPattern == null)
			{
				repititionPattern = new RepetitionPattern(this);
			}
			return repititionPattern;
		}
	}

	public DateTime StartBoundary
	{
		get
		{
			if (v2Trigger != null)
			{
				if (string.IsNullOrEmpty(v2Trigger.StartBoundary))
				{
					return DateTime.MinValue;
				}
				DateTime result = DateTime.Parse(v2Trigger.StartBoundary, DefaultDateCulture);
				if (v2Trigger.StartBoundary.EndsWith("Z"))
				{
					result = result.ToUniversalTime();
				}
				return result;
			}
			if (unboundValues != null && unboundValues.ContainsKey("StartBoundary"))
			{
				return (DateTime)unboundValues["StartBoundary"];
			}
			return v1TriggerData.BeginDate;
		}
		set
		{
			if (v2Trigger != null)
			{
				v2Trigger.StartBoundary = ((value == DateTime.MinValue) ? null : value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'FFFK", DefaultDateCulture));
				return;
			}
			v1TriggerData.BeginDate = value;
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["StartBoundary"] = value;
			}
		}
	}

	[XmlIgnore]
	public TaskTriggerType TriggerType => ttype;

	internal virtual bool Bound
	{
		get
		{
			if (v1Trigger != null)
			{
				return v1Trigger.GetTrigger().Equals(v1TriggerData);
			}
			return v2Trigger != null;
		}
	}

	internal Trigger(ITaskTrigger trigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType type)
	{
		v1Trigger = trigger;
		v1TriggerData = trigger.GetTrigger();
		v1TriggerData.Type = type;
		ttype = ConvertFromV1TriggerType(type);
	}

	internal Trigger(ITaskTrigger trigger, TaskTrigger data)
	{
		v1Trigger = trigger;
		v1TriggerData = data;
		ttype = ConvertFromV1TriggerType(data.Type);
	}

	internal Trigger(ITrigger iTrigger)
	{
		v2Trigger = iTrigger;
		ttype = iTrigger.Type;
		if (string.IsNullOrEmpty(v2Trigger.StartBoundary))
		{
			StartBoundary = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Unspecified);
		}
	}

	internal Trigger(TaskTriggerType triggerType)
	{
		ttype = triggerType;
		unboundValues = new Dictionary<string, object>();
		v1TriggerData.TriggerSize = (ushort)Marshal.SizeOf(typeof(TaskTrigger));
		try
		{
			v1TriggerData.Type = ConvertToV1TriggerType(ttype);
		}
		catch
		{
		}
		StartBoundary = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Unspecified);
	}

	public object Clone()
	{
		Trigger trigger = CreateTrigger(TriggerType);
		trigger.CopyProperties(this);
		return trigger;
	}

	public virtual void CopyProperties(Trigger sourceTrigger)
	{
		Enabled = sourceTrigger.Enabled;
		EndBoundary = sourceTrigger.EndBoundary;
		try
		{
			ExecutionTimeLimit = sourceTrigger.ExecutionTimeLimit;
		}
		catch
		{
		}
		Repetition.Duration = sourceTrigger.Repetition.Duration;
		Repetition.Interval = sourceTrigger.Repetition.Interval;
		Repetition.StopAtDurationEnd = sourceTrigger.Repetition.StopAtDurationEnd;
		StartBoundary = sourceTrigger.StartBoundary;
		if (sourceTrigger is ITriggerDelay && this is ITriggerDelay)
		{
			try
			{
				((ITriggerDelay)this).Delay = ((ITriggerDelay)sourceTrigger).Delay;
			}
			catch
			{
			}
		}
		if (sourceTrigger is ITriggerUserId && this is ITriggerUserId)
		{
			try
			{
				((ITriggerUserId)this).UserId = ((ITriggerUserId)sourceTrigger).UserId;
			}
			catch
			{
			}
		}
	}

	public virtual void Dispose()
	{
		if (v2Trigger != null)
		{
			Marshal.ReleaseComObject(v2Trigger);
		}
		if (v1Trigger != null)
		{
			Marshal.ReleaseComObject(v1Trigger);
		}
	}

	public override string ToString()
	{
		if (v1Trigger != null)
		{
			return v1Trigger.GetTriggerString();
		}
		return V2GetTriggerString() + V2BaseTriggerString();
	}

	public virtual string ToString(CultureInfo culture)
	{
		using (new CultureSwitcher(culture))
		{
			return ToString();
		}
	}

	internal static TaskTriggerType ConvertFromV1TriggerType(Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType v1Type)
	{
		int num = (int)(v1Type + 1);
		if (num > 6)
		{
			num++;
		}
		return (TaskTriggerType)num;
	}

	internal static Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType ConvertToV1TriggerType(TaskTriggerType type)
	{
		if (type != TaskTriggerType.Registration && type != 0 && type != TaskTriggerType.SessionStateChange)
		{
			int num = (int)(type - 1);
			if (num >= 7)
			{
				num--;
			}
			return (Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType)num;
		}
		throw new NotV1SupportedException();
	}

	internal static Trigger CreateTrigger(ITaskTrigger trigger)
	{
		return CreateTrigger(trigger, trigger.GetTrigger().Type);
	}

	internal static Trigger CreateTrigger(ITaskTrigger trigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType triggerType)
	{
		Trigger result = null;
		switch (triggerType)
		{
		case Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunOnce:
			result = new TimeTrigger(trigger);
			break;
		case Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunDaily:
			result = new DailyTrigger(trigger);
			break;
		case Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunWeekly:
			result = new WeeklyTrigger(trigger);
			break;
		case Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunMonthly:
			result = new MonthlyTrigger(trigger);
			break;
		case Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunMonthlyDOW:
			result = new MonthlyDOWTrigger(trigger);
			break;
		case Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.OnIdle:
			result = new IdleTrigger(trigger);
			break;
		case Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.OnSystemStart:
			result = new BootTrigger(trigger);
			break;
		case Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.OnLogon:
			result = new LogonTrigger(trigger);
			break;
		}
		return result;
	}

	internal static Trigger CreateTrigger(ITrigger iTrigger)
	{
		return iTrigger.Type switch
		{
			TaskTriggerType.Event => new EventTrigger((IEventTrigger)iTrigger), 
			TaskTriggerType.Time => new TimeTrigger((ITimeTrigger)iTrigger), 
			TaskTriggerType.Daily => new DailyTrigger((IDailyTrigger)iTrigger), 
			TaskTriggerType.Weekly => new WeeklyTrigger((IWeeklyTrigger)iTrigger), 
			TaskTriggerType.Monthly => new MonthlyTrigger((IMonthlyTrigger)iTrigger), 
			TaskTriggerType.MonthlyDOW => new MonthlyDOWTrigger((IMonthlyDOWTrigger)iTrigger), 
			TaskTriggerType.Idle => new IdleTrigger((IIdleTrigger)iTrigger), 
			TaskTriggerType.Registration => new RegistrationTrigger((IRegistrationTrigger)iTrigger), 
			TaskTriggerType.Boot => new BootTrigger((IBootTrigger)iTrigger), 
			TaskTriggerType.Logon => new LogonTrigger((ILogonTrigger)iTrigger), 
			TaskTriggerType.SessionStateChange => new SessionStateChangeTrigger((ISessionStateChangeTrigger)iTrigger), 
			_ => null, 
		};
	}

	public static Trigger CreateTrigger(TaskTriggerType triggerType)
	{
		return triggerType switch
		{
			TaskTriggerType.Event => new EventTrigger(), 
			TaskTriggerType.Time => new TimeTrigger(), 
			TaskTriggerType.Daily => new DailyTrigger(1), 
			TaskTriggerType.Weekly => new WeeklyTrigger(DaysOfTheWeek.Sunday, 1), 
			TaskTriggerType.Monthly => new MonthlyTrigger(), 
			TaskTriggerType.MonthlyDOW => new MonthlyDOWTrigger(), 
			TaskTriggerType.Idle => new IdleTrigger(), 
			TaskTriggerType.Registration => new RegistrationTrigger(), 
			TaskTriggerType.Boot => new BootTrigger(), 
			TaskTriggerType.Logon => new LogonTrigger(), 
			TaskTriggerType.SessionStateChange => new SessionStateChangeTrigger(), 
			_ => null, 
		};
	}

	internal virtual void Bind(ITask iTask)
	{
		if (v1Trigger == null)
		{
			v1Trigger = iTask.CreateTrigger(out var _);
		}
		SetV1TriggerData();
	}

	internal virtual void Bind(ITaskDefinition iTaskDef)
	{
		ITriggerCollection triggers = iTaskDef.Triggers;
		v2Trigger = triggers.Create(ttype);
		Marshal.ReleaseComObject(triggers);
		foreach (string key in unboundValues.Keys)
		{
			try
			{
				object o = unboundValues[key];
				CheckBindValue(key, ref o);
				v2Trigger.GetType().InvokeMember(key, BindingFlags.SetProperty, null, v2Trigger, new object[1] { o });
			}
			catch (TargetInvocationException ex)
			{
				throw ex.InnerException;
			}
			catch
			{
			}
		}
		unboundValues.Clear();
		unboundValues = null;
		repititionPattern = new RepetitionPattern(this);
		repititionPattern.Bind();
	}

	internal virtual void CheckBindValue(string key, ref object o)
	{
		if (o is TimeSpan)
		{
			o = Task.TimeSpanToString((TimeSpan)o);
		}
		if (o is DateTime)
		{
			if ((key == "EndBoundary" && (DateTime)o == DateTime.MaxValue) || (key == "StartBoundary" && (DateTime)o == DateTime.MinValue))
			{
				o = null;
			}
			else
			{
				o = ((DateTime)o).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'FFFK", DefaultDateCulture);
			}
		}
	}

	internal void SetV1TriggerData()
	{
		if (v1TriggerData.MinutesInterval != 0 && v1TriggerData.MinutesInterval >= v1TriggerData.MinutesDuration)
		{
			throw new ArgumentException("Trigger.Repetition.Interval must be less than Trigger.Repetition.Duration under Task Scheduler 1.0.");
		}
		if (v1Trigger != null)
		{
			v1Trigger.SetTrigger(ref v1TriggerData);
		}
	}

	protected virtual string V2GetTriggerString()
	{
		return string.Empty;
	}

	internal static DateTime AdjustToLocal(DateTime dt)
	{
		if (dt.Kind != DateTimeKind.Utc)
		{
			return dt;
		}
		return dt.ToLocalTime();
	}

	private string V2BaseTriggerString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Repetition.Interval != TimeSpan.Zero)
		{
			string empty = string.Empty;
			stringBuilder.AppendFormat(arg1: (!(Repetition.Duration == TimeSpan.Zero)) ? string.Format(Resources.TriggerDurationNot0, GetBestTimeSpanString(Repetition.Duration)) : Resources.TriggerDuration0, format: Resources.TriggerRepetition, arg0: GetBestTimeSpanString(Repetition.Interval));
		}
		if (EndBoundary != DateTime.MaxValue)
		{
			stringBuilder.AppendFormat(Resources.TriggerEndBoundary, AdjustToLocal(EndBoundary));
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder.Insert(0, Resources.HyphenSeparator);
		}
		return stringBuilder.ToString();
	}

	private static string GetBestTimeSpanString(TimeSpan span)
	{
		if (!foundTimeSpan2.HasValue)
		{
			try
			{
				foundTimeSpan2 = false;
				Assembly assembly = Assembly.LoadFrom("TimeSpan2.dll");
				if ((object)assembly != null)
				{
					timeSpan2Type = assembly.GetType("System.TimeSpan2", throwOnError: false, ignoreCase: false);
					if ((object)timeSpan2Type != null)
					{
						foundTimeSpan2 = true;
					}
				}
			}
			catch
			{
			}
		}
		bool? flag = foundTimeSpan2;
		if (flag.GetValueOrDefault() && flag.HasValue && (object)timeSpan2Type != null)
		{
			try
			{
				object obj2 = Activator.CreateInstance(timeSpan2Type, span);
				if (obj2 != null)
				{
					MethodInfo method = timeSpan2Type.GetMethod("ToString", new Type[1] { typeof(string) });
					if ((object)method != null)
					{
						object obj3 = method.Invoke(obj2, new object[1] { "f" });
						if (obj3 != null)
						{
							return obj3.ToString();
						}
					}
				}
			}
			catch
			{
			}
		}
		return span.ToString();
	}
}
