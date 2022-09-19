using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Microsoft.Win32.TaskScheduler;

internal static class CalendarTrigger
{
	internal delegate void CalendarXmlReader(XmlReader reader);

	internal delegate void CalendarXmlWriter(XmlWriter writer);

	internal static Trigger GetTriggerFromXml(XmlReader reader)
	{
		Trigger trigger = null;
		string text = reader.ReadOuterXml();
		Match match = Regex.Match(text, "\\<(?<T>ScheduleBy.+)\\>");
		if (match.Success && match.Groups.Count == 2)
		{
			switch (match.Groups[1].Value)
			{
			case "ScheduleByMonthDayOfWeek":
				trigger = new MonthlyDOWTrigger();
				break;
			case "ScheduleByMonth":
				trigger = new MonthlyTrigger();
				break;
			case "ScheduleByWeek":
				trigger = new WeeklyTrigger(DaysOfTheWeek.Sunday, 1);
				break;
			case "ScheduleByDay":
				trigger = new DailyTrigger(1);
				break;
			}
			if (trigger != null)
			{
				using (StringReader input = new StringReader(text))
				{
					using XmlReader reader2 = XmlReader.Create(input);
					((IXmlSerializable)trigger).ReadXml(reader2);
					return trigger;
				}
			}
		}
		return trigger;
	}

	internal static void ReadXml(XmlReader reader, Trigger t, CalendarXmlReader calReaderProc)
	{
		reader.ReadStartElement("CalendarTrigger", "http://schemas.microsoft.com/windows/2004/02/mit/task");
		while (reader.MoveToContent() == XmlNodeType.Element)
		{
			switch (reader.LocalName)
			{
			case "Enabled":
				t.Enabled = reader.ReadElementContentAsBoolean();
				break;
			case "EndBoundary":
				t.EndBoundary = reader.ReadElementContentAsDateTime();
				break;
			case "RandomDelay":
				((ITriggerDelay)t).Delay = Task.StringToTimeSpan(reader.ReadElementContentAsString());
				break;
			case "StartBoundary":
				t.StartBoundary = reader.ReadElementContentAsDateTime();
				break;
			case "Repetition":
				XmlSerializationHelper.ReadObject(reader, t.Repetition);
				break;
			case "ScheduleByDay":
			case "ScheduleByWeek":
			case "ScheduleByMonth":
			case "ScheduleByMonthDayOfWeek":
				calReaderProc(reader);
				break;
			default:
				reader.Skip();
				break;
			}
		}
		reader.ReadEndElement();
	}

	public static void WriteXml(XmlWriter writer, Trigger t, CalendarXmlWriter calWriterProc)
	{
		if (!t.Enabled)
		{
			writer.WriteElementString("Enabled", XmlConvert.ToString(t.Enabled));
		}
		if (t.EndBoundary != DateTime.MaxValue)
		{
			writer.WriteElementString("EndBoundary", XmlConvert.ToString(t.EndBoundary, XmlDateTimeSerializationMode.RoundtripKind));
		}
		XmlSerializationHelper.WriteObject(writer, t.Repetition);
		writer.WriteElementString("StartBoundary", XmlConvert.ToString(t.StartBoundary, XmlDateTimeSerializationMode.RoundtripKind));
		calWriterProc(writer);
	}
}
