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
public sealed class WeeklyTrigger : Trigger, IXmlSerializable, ICalendarTrigger, ITriggerDelay
{
	[DefaultValue(0)]
	public DaysOfTheWeek DaysOfWeek
	{
		get
		{
			if (v2Trigger != null)
			{
				return (DaysOfTheWeek)((IWeeklyTrigger)v2Trigger).DaysOfWeek;
			}
			return v1TriggerData.Data.weekly.DaysOfTheWeek;
		}
		set
		{
			if (v2Trigger != null)
			{
				((IWeeklyTrigger)v2Trigger).DaysOfWeek = (short)value;
				return;
			}
			v1TriggerData.Data.weekly.DaysOfTheWeek = value;
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["DaysOfWeek"] = (short)value;
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
				return Task.StringToTimeSpan(((IWeeklyTrigger)v2Trigger).RandomDelay);
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
				((IWeeklyTrigger)v2Trigger).RandomDelay = Task.TimeSpanToString(value);
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["RandomDelay"] = value;
		}
	}

	[DefaultValue(1)]
	public short WeeksInterval
	{
		get
		{
			if (v2Trigger != null)
			{
				return ((IWeeklyTrigger)v2Trigger).WeeksInterval;
			}
			return (short)v1TriggerData.Data.weekly.WeeksInterval;
		}
		set
		{
			if (v2Trigger != null)
			{
				((IWeeklyTrigger)v2Trigger).WeeksInterval = value;
				return;
			}
			v1TriggerData.Data.weekly.WeeksInterval = (ushort)value;
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["WeeksInterval"] = value;
			}
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

	public WeeklyTrigger(DaysOfTheWeek daysOfWeek = DaysOfTheWeek.Sunday, short weeksInterval = 1)
		: base(TaskTriggerType.Weekly)
	{
		DaysOfWeek = daysOfWeek;
		WeeksInterval = weeksInterval;
	}

	internal WeeklyTrigger(ITaskTrigger iTrigger)
		: base(iTrigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunWeekly)
	{
		if (v1TriggerData.Data.weekly.DaysOfTheWeek == (DaysOfTheWeek)0)
		{
			v1TriggerData.Data.weekly.DaysOfTheWeek = DaysOfTheWeek.Sunday;
		}
		if (v1TriggerData.Data.weekly.WeeksInterval == 0)
		{
			v1TriggerData.Data.weekly.WeeksInterval = 1;
		}
	}

	internal WeeklyTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	public override void CopyProperties(Trigger sourceTrigger)
	{
		base.CopyProperties(sourceTrigger);
		if ((object)sourceTrigger.GetType() == GetType())
		{
			DaysOfWeek = ((WeeklyTrigger)sourceTrigger).DaysOfWeek;
			WeeksInterval = ((WeeklyTrigger)sourceTrigger).WeeksInterval;
		}
	}

	private void ReadMyXml(XmlReader reader)
	{
		reader.ReadStartElement("ScheduleByWeek");
		while (reader.MoveToContent() == XmlNodeType.Element)
		{
			switch (reader.LocalName)
			{
			case "DaysOfWeek":
				reader.Read();
				DaysOfWeek = (DaysOfTheWeek)0;
				while (reader.MoveToContent() == XmlNodeType.Element)
				{
					try
					{
						DaysOfWeek |= (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), reader.LocalName);
					}
					catch
					{
						throw new XmlException("Invalid days of the week element.");
					}
					reader.Read();
				}
				reader.ReadEndElement();
				break;
			case "WeeksInterval":
				WeeksInterval = (short)reader.ReadElementContentAsInt();
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.ReadEndElement();
	}

	protected override string V2GetTriggerString()
	{
		string @string = TaskEnumGlobalizer.GetString(DaysOfWeek);
		return string.Format((WeeksInterval == 1) ? Resources.TriggerWeekly1Week : Resources.TriggerWeeklyMultWeeks, Trigger.AdjustToLocal(base.StartBoundary), @string, WeeksInterval);
	}

	private void WriteMyXml(XmlWriter writer)
	{
		writer.WriteStartElement("ScheduleByWeek");
		if (WeeksInterval != 1)
		{
			writer.WriteElementString("WeeksInterval", WeeksInterval.ToString());
		}
		writer.WriteStartElement("DaysOfWeek");
		foreach (DaysOfTheWeek value in Enum.GetValues(typeof(DaysOfTheWeek)))
		{
			if (value != DaysOfTheWeek.AllDays && (DaysOfWeek & value) == value)
			{
				writer.WriteElementString(value.ToString(), null);
			}
		}
		writer.WriteEndElement();
		writer.WriteEndElement();
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		throw new NotImplementedException();
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		CalendarTrigger.ReadXml(reader, this, ReadMyXml);
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		CalendarTrigger.WriteXml(writer, this, WriteMyXml);
	}
}
