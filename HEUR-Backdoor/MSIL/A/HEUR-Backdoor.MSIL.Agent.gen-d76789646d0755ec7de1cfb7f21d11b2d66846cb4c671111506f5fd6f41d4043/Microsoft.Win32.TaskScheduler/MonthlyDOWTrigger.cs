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

[XmlRoot("CalendarTrigger", Namespace = "http://schemas.microsoft.com/windows/2004/02/mit/task", IsNullable = false)]
[ComVisible(false)]
public sealed class MonthlyDOWTrigger : Trigger, IXmlSerializable, ICalendarTrigger, ITriggerDelay
{
	[DefaultValue(0)]
	public DaysOfTheWeek DaysOfWeek
	{
		get
		{
			if (v2Trigger != null)
			{
				return (DaysOfTheWeek)((IMonthlyDOWTrigger)v2Trigger).DaysOfWeek;
			}
			return v1TriggerData.Data.monthlyDOW.DaysOfTheWeek;
		}
		set
		{
			if (v2Trigger != null)
			{
				((IMonthlyDOWTrigger)v2Trigger).DaysOfWeek = (short)value;
				return;
			}
			v1TriggerData.Data.monthlyDOW.DaysOfTheWeek = value;
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

	[DefaultValue(0)]
	public MonthsOfTheYear MonthsOfYear
	{
		get
		{
			if (v2Trigger != null)
			{
				return (MonthsOfTheYear)((IMonthlyDOWTrigger)v2Trigger).MonthsOfYear;
			}
			return v1TriggerData.Data.monthlyDOW.Months;
		}
		set
		{
			if (v2Trigger != null)
			{
				((IMonthlyDOWTrigger)v2Trigger).MonthsOfYear = (short)value;
				return;
			}
			v1TriggerData.Data.monthlyDOW.Months = value;
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["MonthsOfYear"] = (short)value;
			}
		}
	}

	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	[XmlIgnore]
	public TimeSpan RandomDelay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((IMonthlyDOWTrigger)v2Trigger).RandomDelay);
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
				((IMonthlyDOWTrigger)v2Trigger).RandomDelay = Task.TimeSpanToString(value);
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["RandomDelay"] = value;
		}
	}

	[XmlIgnore]
	[DefaultValue(false)]
	public bool RunOnLastWeekOfMonth
	{
		get
		{
			if (v2Trigger != null)
			{
				return ((IMonthlyDOWTrigger)v2Trigger).RunOnLastWeekOfMonth;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			if (!unboundValues.ContainsKey("RunOnLastWeekOfMonth"))
			{
				return false;
			}
			return (bool)unboundValues["RunOnLastWeekOfMonth"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((IMonthlyDOWTrigger)v2Trigger).RunOnLastWeekOfMonth = value;
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["RunOnLastWeekOfMonth"] = value;
		}
	}

	[DefaultValue(0)]
	public WhichWeek WeeksOfMonth
	{
		get
		{
			if (v2Trigger != null)
			{
				WhichWeek whichWeek = (WhichWeek)((IMonthlyDOWTrigger)v2Trigger).WeeksOfMonth;
				if (((IMonthlyDOWTrigger)v2Trigger).RunOnLastWeekOfMonth)
				{
					whichWeek |= WhichWeek.LastWeek;
				}
				return whichWeek;
			}
			if (v1Trigger != null)
			{
				return v1TriggerData.Data.monthlyDOW.V2WhichWeek;
			}
			if (!unboundValues.ContainsKey("WeeksOfMonth"))
			{
				return WhichWeek.FirstWeek;
			}
			return (WhichWeek)unboundValues["WeeksOfMonth"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((IMonthlyDOWTrigger)v2Trigger).WeeksOfMonth = (short)value;
				return;
			}
			try
			{
				v1TriggerData.Data.monthlyDOW.V2WhichWeek = value;
			}
			catch (NotV1SupportedException)
			{
				if (v1Trigger != null)
				{
					throw;
				}
			}
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["WeeksOfMonth"] = (short)value;
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

	public MonthlyDOWTrigger(DaysOfTheWeek daysOfWeek = DaysOfTheWeek.Sunday, MonthsOfTheYear monthsOfYear = MonthsOfTheYear.AllMonths, WhichWeek weeksOfMonth = WhichWeek.FirstWeek)
		: base(TaskTriggerType.MonthlyDOW)
	{
		DaysOfWeek = daysOfWeek;
		MonthsOfYear = monthsOfYear;
		WeeksOfMonth = weeksOfMonth;
	}

	internal MonthlyDOWTrigger(ITaskTrigger iTrigger)
		: base(iTrigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunMonthlyDOW)
	{
		if (v1TriggerData.Data.monthlyDOW.Months == (MonthsOfTheYear)0)
		{
			v1TriggerData.Data.monthlyDOW.Months = MonthsOfTheYear.AllMonths;
		}
		if (v1TriggerData.Data.monthlyDOW.DaysOfTheWeek == (DaysOfTheWeek)0)
		{
			v1TriggerData.Data.monthlyDOW.DaysOfTheWeek = DaysOfTheWeek.Sunday;
		}
	}

	internal MonthlyDOWTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	public override void CopyProperties(Trigger sourceTrigger)
	{
		base.CopyProperties(sourceTrigger);
		if ((object)sourceTrigger.GetType() == GetType())
		{
			DaysOfWeek = ((MonthlyDOWTrigger)sourceTrigger).DaysOfWeek;
			MonthsOfYear = ((MonthlyDOWTrigger)sourceTrigger).MonthsOfYear;
			try
			{
				RunOnLastWeekOfMonth = ((MonthlyDOWTrigger)sourceTrigger).RunOnLastWeekOfMonth;
			}
			catch
			{
			}
			WeeksOfMonth = ((MonthlyDOWTrigger)sourceTrigger).WeeksOfMonth;
		}
	}

	private void ReadMyXml(XmlReader reader)
	{
		reader.ReadStartElement("ScheduleByMonthDayOfWeek");
		while (reader.MoveToContent() == XmlNodeType.Element)
		{
			switch (reader.LocalName)
			{
			case "Months":
				reader.Read();
				MonthsOfYear = (MonthsOfTheYear)0;
				while (reader.MoveToContent() == XmlNodeType.Element)
				{
					try
					{
						MonthsOfYear |= (MonthsOfTheYear)Enum.Parse(typeof(MonthsOfTheYear), reader.LocalName);
					}
					catch
					{
						throw new XmlException("Invalid months of the year element.");
					}
					reader.Read();
				}
				reader.ReadEndElement();
				break;
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
			case "Weeks":
				reader.Read();
				while (reader.MoveToContent() == XmlNodeType.Element)
				{
					if (!(reader.LocalName == "Week"))
					{
						continue;
					}
					string text = reader.ReadElementContentAsString();
					if (text == "Last")
					{
						WeeksOfMonth = WhichWeek.LastWeek;
						continue;
					}
					switch (int.Parse(text))
					{
					case 1:
						WeeksOfMonth = WhichWeek.FirstWeek;
						break;
					case 2:
						WeeksOfMonth = WhichWeek.SecondWeek;
						break;
					case 3:
						WeeksOfMonth = WhichWeek.ThirdWeek;
						break;
					case 4:
						WeeksOfMonth = WhichWeek.FourthWeek;
						break;
					default:
						throw new XmlException("Week element must contain a 1-4 or Last as content.");
					}
				}
				reader.ReadEndElement();
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
		string @string = TaskEnumGlobalizer.GetString(WeeksOfMonth);
		string string2 = TaskEnumGlobalizer.GetString(DaysOfWeek);
		string string3 = TaskEnumGlobalizer.GetString(MonthsOfYear);
		return string.Format(Resources.TriggerMonthlyDOW1, Trigger.AdjustToLocal(base.StartBoundary), @string, string2, string3);
	}

	private void WriteMyXml(XmlWriter writer)
	{
		writer.WriteStartElement("ScheduleByMonthDayOfWeek");
		writer.WriteStartElement("Weeks");
		if ((WeeksOfMonth & WhichWeek.FirstWeek) == WhichWeek.FirstWeek)
		{
			writer.WriteElementString("Week", "1");
		}
		if ((WeeksOfMonth & WhichWeek.SecondWeek) == WhichWeek.SecondWeek)
		{
			writer.WriteElementString("Week", "2");
		}
		if ((WeeksOfMonth & WhichWeek.ThirdWeek) == WhichWeek.ThirdWeek)
		{
			writer.WriteElementString("Week", "3");
		}
		if ((WeeksOfMonth & WhichWeek.FourthWeek) == WhichWeek.FourthWeek)
		{
			writer.WriteElementString("Week", "4");
		}
		if ((WeeksOfMonth & WhichWeek.LastWeek) == WhichWeek.LastWeek)
		{
			writer.WriteElementString("Week", "Last");
		}
		writer.WriteEndElement();
		writer.WriteStartElement("DaysOfWeek");
		foreach (DaysOfTheWeek value in Enum.GetValues(typeof(DaysOfTheWeek)))
		{
			if (value != DaysOfTheWeek.AllDays && (DaysOfWeek & value) == value)
			{
				writer.WriteElementString(value.ToString(), null);
			}
		}
		writer.WriteEndElement();
		writer.WriteStartElement("Months");
		foreach (MonthsOfTheYear value2 in Enum.GetValues(typeof(MonthsOfTheYear)))
		{
			if (value2 != MonthsOfTheYear.AllMonths && (MonthsOfYear & value2) == value2)
			{
				writer.WriteElementString(value2.ToString(), null);
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
