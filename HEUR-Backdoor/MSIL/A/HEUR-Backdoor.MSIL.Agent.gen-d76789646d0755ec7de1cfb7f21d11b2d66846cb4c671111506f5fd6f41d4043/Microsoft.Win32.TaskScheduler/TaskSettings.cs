using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[XmlRoot("Settings", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = true)]
[ComVisible(false)]
public sealed class TaskSettings : IDisposable, IXmlSerializable
{
	private IdleSettings idleSettings;

	private MaintenanceSettings maintenanceSettings;

	private NetworkSettings networkSettings;

	private ITask v1Task;

	private ITaskSettings v2Settings;

	private ITaskSettings2 v2Settings2;

	private ITaskSettings3 v2Settings3;

	[DefaultValue(true)]
	[XmlIgnore]
	[XmlElement("AllowStartOnDemand")]
	public bool AllowDemandStart
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.AllowDemandStart;
			}
			return true;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.AllowDemandStart = value;
		}
	}

	[XmlIgnore]
	[DefaultValue(true)]
	public bool AllowHardTerminate
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.AllowHardTerminate;
			}
			return true;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.AllowHardTerminate = value;
		}
	}

	[XmlIgnore]
	public TaskCompatibility Compatibility
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.Compatibility;
			}
			return TaskCompatibility.V1;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.Compatibility = value;
		}
	}

	[DefaultValue(typeof(TimeSpan), "12:00:00")]
	public TimeSpan DeleteExpiredTaskAfter
	{
		get
		{
			if (v2Settings != null)
			{
				return Task.StringToTimeSpan(v2Settings.DeleteExpiredTaskAfter);
			}
			if ((v1Task.GetFlags() & TaskFlags.DeleteWhenDone) != TaskFlags.DeleteWhenDone)
			{
				return TimeSpan.Zero;
			}
			return TimeSpan.FromSeconds(1.0);
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.DeleteExpiredTaskAfter = Task.TimeSpanToString(value);
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value >= TimeSpan.FromSeconds(1.0))
			{
				v1Task.SetFlags(flags |= TaskFlags.DeleteWhenDone);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.DeleteWhenDone);
			}
		}
	}

	[DefaultValue(true)]
	public bool DisallowStartIfOnBatteries
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.DisallowStartIfOnBatteries;
			}
			return (v1Task.GetFlags() & TaskFlags.DontStartIfOnBatteries) == TaskFlags.DontStartIfOnBatteries;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.DisallowStartIfOnBatteries = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value)
			{
				v1Task.SetFlags(flags |= TaskFlags.DontStartIfOnBatteries);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.DontStartIfOnBatteries);
			}
		}
	}

	[DefaultValue(false)]
	[XmlIgnore]
	public bool DisallowStartOnRemoteAppSession
	{
		get
		{
			if (v2Settings2 != null)
			{
				return v2Settings2.DisallowStartOnRemoteAppSession;
			}
			if (v2Settings3 != null)
			{
				return v2Settings3.DisallowStartOnRemoteAppSession;
			}
			return false;
		}
		set
		{
			if (v2Settings2 != null)
			{
				v2Settings2.DisallowStartOnRemoteAppSession = value;
				return;
			}
			if (v2Settings3 == null)
			{
				throw new NotSupportedPriorToException(TaskCompatibility.V2_1);
			}
			v2Settings3.DisallowStartOnRemoteAppSession = value;
		}
	}

	[DefaultValue(true)]
	public bool Enabled
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.Enabled;
			}
			return (v1Task.GetFlags() & TaskFlags.Disabled) != TaskFlags.Disabled;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.Enabled = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (!value)
			{
				v1Task.SetFlags(flags |= TaskFlags.Disabled);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.Disabled);
			}
		}
	}

	[DefaultValue(typeof(TimeSpan), "72:00:00")]
	public TimeSpan ExecutionTimeLimit
	{
		get
		{
			if (v2Settings != null)
			{
				return Task.StringToTimeSpan(v2Settings.ExecutionTimeLimit);
			}
			return TimeSpan.FromMilliseconds(v1Task.GetMaxRunTime());
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.ExecutionTimeLimit = ((value == TimeSpan.Zero) ? "PT0S" : Task.TimeSpanToString(value));
			}
			else
			{
				v1Task.SetMaxRunTime(Convert.ToUInt32(value.TotalMilliseconds));
			}
		}
	}

	[DefaultValue(false)]
	public bool Hidden
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.Hidden;
			}
			return (v1Task.GetFlags() & TaskFlags.Hidden) == TaskFlags.Hidden;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.Hidden = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value)
			{
				v1Task.SetFlags(flags |= TaskFlags.Hidden);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.Hidden);
			}
		}
	}

	public IdleSettings IdleSettings
	{
		get
		{
			if (idleSettings == null)
			{
				if (v2Settings != null)
				{
					idleSettings = new IdleSettings(v2Settings.IdleSettings);
				}
				else
				{
					idleSettings = new IdleSettings(v1Task);
				}
			}
			return idleSettings;
		}
	}

	[XmlIgnore]
	public MaintenanceSettings MaintenanceSettings
	{
		get
		{
			if (maintenanceSettings == null)
			{
				maintenanceSettings = new MaintenanceSettings(v2Settings3);
			}
			return maintenanceSettings;
		}
	}

	[XmlIgnore]
	[DefaultValue(typeof(TaskInstancesPolicy), "IgnoreNew")]
	public TaskInstancesPolicy MultipleInstances
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.MultipleInstances;
			}
			return TaskInstancesPolicy.IgnoreNew;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.MultipleInstances = value;
		}
	}

	[XmlIgnore]
	public NetworkSettings NetworkSettings
	{
		get
		{
			if (networkSettings == null)
			{
				networkSettings = new NetworkSettings((v2Settings == null) ? null : v2Settings.NetworkSettings);
			}
			return networkSettings;
		}
	}

	[DefaultValue(typeof(ProcessPriorityClass), "Normal")]
	public ProcessPriorityClass Priority
	{
		get
		{
			if (v2Settings != null)
			{
				return GetPriorityFromInt(v2Settings.Priority);
			}
			return (ProcessPriorityClass)v1Task.GetPriority();
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.Priority = GetPriorityAsInt(value);
				return;
			}
			if (value == ProcessPriorityClass.AboveNormal || value == ProcessPriorityClass.BelowNormal)
			{
				throw new NotV1SupportedException("Unsupported priority level on Task Scheduler 1.0.");
			}
			v1Task.SetPriority((uint)value);
		}
	}

	[XmlIgnore]
	[DefaultValue(0)]
	public int RestartCount
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.RestartCount;
			}
			return 0;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.RestartCount = value;
		}
	}

	[XmlIgnore]
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan RestartInterval
	{
		get
		{
			if (v2Settings != null)
			{
				return Task.StringToTimeSpan(v2Settings.RestartInterval);
			}
			return TimeSpan.Zero;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.RestartInterval = Task.TimeSpanToString(value);
		}
	}

	[DefaultValue(false)]
	public bool RunOnlyIfIdle
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.RunOnlyIfIdle;
			}
			return (v1Task.GetFlags() & TaskFlags.StartOnlyIfIdle) == TaskFlags.StartOnlyIfIdle;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.RunOnlyIfIdle = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value)
			{
				v1Task.SetFlags(flags |= TaskFlags.StartOnlyIfIdle);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.StartOnlyIfIdle);
			}
		}
	}

	[XmlIgnore]
	public bool RunOnlyIfLoggedOn
	{
		get
		{
			if (v2Settings != null)
			{
				return true;
			}
			return (v1Task.GetFlags() & TaskFlags.RunOnlyIfLoggedOn) == TaskFlags.RunOnlyIfLoggedOn;
		}
		set
		{
			if (v1Task != null)
			{
				TaskFlags flags = v1Task.GetFlags();
				if (value)
				{
					v1Task.SetFlags(flags |= TaskFlags.RunOnlyIfLoggedOn);
				}
				else
				{
					v1Task.SetFlags(flags &= ~TaskFlags.RunOnlyIfLoggedOn);
				}
			}
			else if (v2Settings != null)
			{
				throw new NotV2SupportedException("Task Scheduler 2.0 (1.2) does not support setting this property. You must use an InteractiveToken in order to have the task run in the current user session.");
			}
		}
	}

	[DefaultValue(false)]
	public bool RunOnlyIfNetworkAvailable
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.RunOnlyIfNetworkAvailable;
			}
			return (v1Task.GetFlags() & TaskFlags.RunIfConnectedToInternet) == TaskFlags.RunIfConnectedToInternet;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.RunOnlyIfNetworkAvailable = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value)
			{
				v1Task.SetFlags(flags |= TaskFlags.RunIfConnectedToInternet);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.RunIfConnectedToInternet);
			}
		}
	}

	[XmlIgnore]
	[DefaultValue(false)]
	public bool StartWhenAvailable
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.StartWhenAvailable;
			}
			return false;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.StartWhenAvailable = value;
		}
	}

	[DefaultValue(true)]
	public bool StopIfGoingOnBatteries
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.StopIfGoingOnBatteries;
			}
			return (v1Task.GetFlags() & TaskFlags.KillIfGoingOnBatteries) == TaskFlags.KillIfGoingOnBatteries;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.StopIfGoingOnBatteries = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value)
			{
				v1Task.SetFlags(flags |= TaskFlags.KillIfGoingOnBatteries);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.KillIfGoingOnBatteries);
			}
		}
	}

	[XmlIgnore]
	[DefaultValue(false)]
	public bool UseUnifiedSchedulingEngine
	{
		get
		{
			if (v2Settings2 != null)
			{
				return v2Settings2.UseUnifiedSchedulingEngine;
			}
			if (v2Settings3 != null)
			{
				return v2Settings3.UseUnifiedSchedulingEngine;
			}
			return false;
		}
		set
		{
			if (v2Settings2 != null)
			{
				v2Settings2.UseUnifiedSchedulingEngine = value;
				return;
			}
			if (v2Settings3 == null)
			{
				throw new NotSupportedPriorToException(TaskCompatibility.V2_1);
			}
			v2Settings3.UseUnifiedSchedulingEngine = value;
		}
	}

	[DefaultValue(false)]
	[XmlIgnore]
	public bool Volatile
	{
		get
		{
			if (v2Settings3 != null)
			{
				return v2Settings3.Volatile;
			}
			return false;
		}
		set
		{
			if (v2Settings3 == null)
			{
				throw new NotSupportedPriorToException(TaskCompatibility.V2_2);
			}
			v2Settings3.Volatile = value;
		}
	}

	[DefaultValue(false)]
	public bool WakeToRun
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.WakeToRun;
			}
			return (v1Task.GetFlags() & TaskFlags.SystemRequired) == TaskFlags.SystemRequired;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.WakeToRun = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value)
			{
				v1Task.SetFlags(flags |= TaskFlags.SystemRequired);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.SystemRequired);
			}
		}
	}

	[XmlIgnore]
	public string XmlText
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.XmlText;
			}
			return XmlSerializationHelper.WriteObjectToXmlText(this);
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.XmlText = value;
			}
			else
			{
				XmlSerializationHelper.ReadObjectFromXmlText(value, this);
			}
		}
	}

	internal TaskSettings(ITaskSettings iSettings)
	{
		v2Settings = iSettings;
		try
		{
			v2Settings2 = (ITaskSettings2)v2Settings;
		}
		catch
		{
		}
		try
		{
			v2Settings3 = (ITaskSettings3)v2Settings;
		}
		catch
		{
		}
	}

	internal TaskSettings(ITask iTask)
	{
		v1Task = iTask;
	}

	private ProcessPriorityClass GetPriorityFromInt(int value)
	{
		switch (value)
		{
		case 0:
			return ProcessPriorityClass.RealTime;
		case 1:
			return ProcessPriorityClass.High;
		case 2:
		case 3:
			return ProcessPriorityClass.AboveNormal;
		case 4:
		case 5:
		case 6:
			return ProcessPriorityClass.Normal;
		default:
			return ProcessPriorityClass.BelowNormal;
		case 9:
		case 10:
			return ProcessPriorityClass.Idle;
		}
	}

	private int GetPriorityAsInt(ProcessPriorityClass value)
	{
		int result = 7;
		switch (value)
		{
		case ProcessPriorityClass.High:
			result = 1;
			break;
		case ProcessPriorityClass.Idle:
			result = 10;
			break;
		case ProcessPriorityClass.Normal:
			result = 5;
			break;
		case ProcessPriorityClass.AboveNormal:
			result = 3;
			break;
		case ProcessPriorityClass.RealTime:
			result = 0;
			break;
		}
		return result;
	}

	public void Dispose()
	{
		if (v2Settings != null)
		{
			Marshal.ReleaseComObject(v2Settings);
		}
		idleSettings = null;
		networkSettings = null;
		v1Task = null;
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		if (!reader.IsEmptyElement)
		{
			reader.ReadStartElement("Settings", "http://schemas.microsoft.com/windows/2004/02/mit/task");
			XmlSerializationHelper.ReadObjectProperties(reader, this, ConvertXmlProperty);
			reader.ReadEndElement();
		}
		else
		{
			reader.Skip();
		}
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		XmlSerializationHelper.WriteObjectProperties(writer, this, ConvertXmlProperty);
	}

	private bool ConvertXmlProperty(PropertyInfo pi, object obj, ref object value)
	{
		if (pi.Name == "Priority")
		{
			if ((object)value.GetType() != typeof(int) && (object)value.GetType() != typeof(ProcessPriorityClass))
			{
				value = GetPriorityAsInt((ProcessPriorityClass)value);
			}
			else
			{
				value = GetPriorityFromInt((int)value);
			}
			return true;
		}
		return false;
	}
}
