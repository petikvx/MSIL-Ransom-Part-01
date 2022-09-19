using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.Properties;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlRoot("CalendarTrigger", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = false)]
public sealed class DailyTrigger : Trigger, IXmlSerializable, ICalendarTrigger, ITriggerDelay
{
	[DefaultValue(1)]
	public short DaysInterval
	{
		get
		{
			if (v2Trigger != null)
			{
				return ((IDailyTrigger)v2Trigger).DaysInterval;
			}
			return (short)v1TriggerData.Data.daily.DaysInterval;
		}
		set
		{
			if (v2Trigger != null)
			{
				((IDailyTrigger)v2Trigger).DaysInterval = value;
				return;
			}
			v1TriggerData.Data.daily.DaysInterval = (ushort)value;
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["DaysInterval"] = value;
			}
		}
	}

	[XmlIgnore]
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan RandomDelay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((IDailyTrigger)v2Trigger).RandomDelay);
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
				((IDailyTrigger)v2Trigger).RandomDelay = Task.TimeSpanToString(value);
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

	public DailyTrigger(short daysInterval = 1)
		: base(TaskTriggerType.Daily)
	{
		DaysInterval = daysInterval;
	}

	internal DailyTrigger(ITaskTrigger iTrigger)
		: base(iTrigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunDaily)
	{
		if (v1TriggerData.Data.daily.DaysInterval == 0)
		{
			v1TriggerData.Data.daily.DaysInterval = 1;
		}
	}

	internal DailyTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	public override void CopyProperties(Trigger sourceTrigger)
	{
		base.CopyProperties(sourceTrigger);
		if ((object)sourceTrigger.GetType() == GetType())
		{
			DaysInterval = ((DailyTrigger)sourceTrigger).DaysInterval;
		}
	}

	protected override string V2GetTriggerString()
	{
		if (DaysInterval == 1)
		{
			return string.Format(Resources.TriggerDaily1, Trigger.AdjustToLocal(base.StartBoundary));
		}
		return string.Format(Resources.TriggerDaily2, Trigger.AdjustToLocal(base.StartBoundary), DaysInterval);
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	private void ReadMyXml(XmlReader reader)
	{
		reader.ReadStartElement("ScheduleByDay");
		if (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "DaysInterval")
		{
			DaysInterval = (short)reader.ReadElementContentAs(typeof(short), null);
		}
		reader.Read();
		reader.ReadEndElement();
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		CalendarTrigger.ReadXml(reader, this, ReadMyXml);
	}

	private void WriteMyXml(XmlWriter writer)
	{
		if (DaysInterval != 1)
		{
			writer.WriteStartElement("ScheduleByDay");
			writer.WriteElementString("DaysInterval", DaysInterval.ToString());
			writer.WriteEndElement();
		}
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		CalendarTrigger.WriteXml(writer, this, WriteMyXml);
	}
}
