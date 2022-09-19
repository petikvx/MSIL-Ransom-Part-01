using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlRoot("Repetition", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = true)]
public sealed class RepetitionPattern : IDisposable, IXmlSerializable
{
	private Trigger pTrigger;

	private IRepetitionPattern v2Pattern;

	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan Duration
	{
		get
		{
			if (v2Pattern != null)
			{
				return Task.StringToTimeSpan(v2Pattern.Duration);
			}
			if (pTrigger != null)
			{
				return TimeSpan.FromMinutes(pTrigger.v1TriggerData.MinutesDuration);
			}
			return TimeSpan.Zero;
		}
		set
		{
			if (v2Pattern != null)
			{
				v2Pattern.Duration = Task.TimeSpanToString(value);
			}
			else if (pTrigger != null)
			{
				pTrigger.v1TriggerData.MinutesDuration = (uint)value.TotalMinutes;
				Bind();
			}
		}
	}

	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan Interval
	{
		get
		{
			if (v2Pattern != null)
			{
				return Task.StringToTimeSpan(v2Pattern.Interval);
			}
			if (pTrigger != null)
			{
				return TimeSpan.FromMinutes(pTrigger.v1TriggerData.MinutesInterval);
			}
			return TimeSpan.Zero;
		}
		set
		{
			if (v2Pattern != null)
			{
				v2Pattern.Interval = Task.TimeSpanToString(value);
			}
			else if (pTrigger != null)
			{
				pTrigger.v1TriggerData.MinutesInterval = (uint)value.TotalMinutes;
				Bind();
			}
		}
	}

	public bool StopAtDurationEnd
	{
		get
		{
			if (v2Pattern != null)
			{
				return v2Pattern.StopAtDurationEnd;
			}
			if (pTrigger != null)
			{
				return (pTrigger.v1TriggerData.Flags & TaskTriggerFlags.KillAtDurationEnd) == TaskTriggerFlags.KillAtDurationEnd;
			}
			return false;
		}
		set
		{
			if (v2Pattern != null)
			{
				v2Pattern.StopAtDurationEnd = value;
			}
			else if (pTrigger != null)
			{
				if (value)
				{
					pTrigger.v1TriggerData.Flags |= TaskTriggerFlags.KillAtDurationEnd;
				}
				else
				{
					pTrigger.v1TriggerData.Flags &= ~TaskTriggerFlags.KillAtDurationEnd;
				}
				Bind();
			}
		}
	}

	internal RepetitionPattern(Trigger parent)
	{
		pTrigger = parent;
		if (pTrigger != null && pTrigger.v2Trigger != null)
		{
			v2Pattern = pTrigger.v2Trigger.Repetition;
		}
	}

	public void Dispose()
	{
		if (v2Pattern != null)
		{
			Marshal.ReleaseComObject(v2Pattern);
		}
	}

	public bool IsSet()
	{
		if (v2Pattern != null)
		{
			if (!v2Pattern.StopAtDurationEnd && string.IsNullOrEmpty(v2Pattern.Duration))
			{
				return !string.IsNullOrEmpty(v2Pattern.Interval);
			}
			return true;
		}
		if (pTrigger != null)
		{
			if ((pTrigger.v1TriggerData.Flags & TaskTriggerFlags.KillAtDurationEnd) != TaskTriggerFlags.KillAtDurationEnd && pTrigger.v1TriggerData.MinutesDuration == 0)
			{
				return pTrigger.v1TriggerData.MinutesInterval != 0;
			}
			return true;
		}
		return false;
	}

	internal void Bind()
	{
		if (pTrigger.v1Trigger != null)
		{
			pTrigger.SetV1TriggerData();
		}
		else if (pTrigger.v2Trigger != null)
		{
			if (pTrigger.v1TriggerData.MinutesInterval != 0)
			{
				v2Pattern.Interval = $"PT{pTrigger.v1TriggerData.MinutesInterval}M";
			}
			if (pTrigger.v1TriggerData.MinutesDuration != 0)
			{
				v2Pattern.Duration = $"PT{pTrigger.v1TriggerData.MinutesDuration}M";
			}
			v2Pattern.StopAtDurationEnd = (pTrigger.v1TriggerData.Flags & TaskTriggerFlags.KillAtDurationEnd) == TaskTriggerFlags.KillAtDurationEnd;
		}
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	private bool ReadXmlConverter(PropertyInfo pi, object obj, ref object value)
	{
		if (pi.Name == "Interval" && value is TimeSpan && !((TimeSpan)value).Equals(TimeSpan.Zero) && Duration <= (TimeSpan)value)
		{
			Duration = ((TimeSpan)value).Add(TimeSpan.FromMinutes(1.0));
		}
		return false;
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		if (!reader.IsEmptyElement)
		{
			reader.ReadStartElement("Repetition", "http://schemas.microsoft.com/windows/2004/02/mit/task");
			XmlSerializationHelper.ReadObjectProperties(reader, this, ReadXmlConverter);
			reader.ReadEndElement();
		}
		else
		{
			reader.Skip();
		}
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		XmlSerializationHelper.WriteObjectProperties(writer, this);
	}
}
