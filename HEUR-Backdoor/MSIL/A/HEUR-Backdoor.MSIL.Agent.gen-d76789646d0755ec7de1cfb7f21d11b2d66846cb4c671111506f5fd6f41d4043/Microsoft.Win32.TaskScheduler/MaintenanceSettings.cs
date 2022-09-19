using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[XmlType(IncludeInSchema = false)]
[ComVisible(false)]
public sealed class MaintenanceSettings : IDisposable
{
	private IMaintenanceSettings v2Settings;

	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan Deadline
	{
		get
		{
			if (v2Settings != null)
			{
				return Task.StringToTimeSpan(v2Settings.Deadline);
			}
			return TimeSpan.Zero;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotSupportedPriorToException(TaskCompatibility.V2_2);
			}
			v2Settings.Deadline = Task.TimeSpanToString(value);
		}
	}

	[DefaultValue(false)]
	public bool Exclusive
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.Exclusive;
			}
			return false;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotSupportedPriorToException(TaskCompatibility.V2_2);
			}
			v2Settings.Exclusive = value;
		}
	}

	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan Period
	{
		get
		{
			if (v2Settings != null)
			{
				return Task.StringToTimeSpan(v2Settings.Period);
			}
			return TimeSpan.Zero;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotSupportedPriorToException(TaskCompatibility.V2_2);
			}
			v2Settings.Period = Task.TimeSpanToString(value);
		}
	}

	internal MaintenanceSettings(ITaskSettings3 iSettings)
	{
		if (iSettings != null)
		{
			v2Settings = iSettings.MaintenanceSettings;
			if (v2Settings == null)
			{
				v2Settings = iSettings.CreateMaintenanceSettings();
			}
		}
	}

	public void Dispose()
	{
		if (v2Settings != null)
		{
			Marshal.ReleaseComObject(v2Settings);
		}
	}

	internal bool IsSet()
	{
		if (v2Settings != null)
		{
			if (v2Settings.Period == null && v2Settings.Deadline == null)
			{
				return v2Settings.Exclusive;
			}
			return true;
		}
		return false;
	}
}
