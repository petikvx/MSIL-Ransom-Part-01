using System;
using System.Collections.Generic;
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
public sealed class MonthlyTrigger : Trigger, IXmlSerializable, ICalendarTrigger, ITriggerDelay
{
	public int[] DaysOfMonth
	{
		get
		{
			if (v2Trigger != null)
			{
				return MaskToIndices(((IMonthlyTrigger)v2Trigger).DaysOfMonth);
			}
			return MaskToIndices((int)v1TriggerData.Data.monthlyDate.Days);
		}
		set
		{
			int num = IndicesToMask(value);
			if (v2Trigger != null)
			{
				((IMonthlyTrigger)v2Trigger).DaysOfMonth = num;
				return;
			}
			v1TriggerData.Data.monthlyDate.Days = (uint)num;
			if (v1Trigger != null)
			{
				SetV1TriggerData();
			}
			else
			{
				unboundValues["DaysOfMonth"] = num;
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
				return (MonthsOfTheYear)((IMonthlyTrigger)v2Trigger).MonthsOfYear;
			}
			return v1TriggerData.Data.monthlyDOW.Months;
		}
		set
		{
			if (v2Trigger != null)
			{
				((IMonthlyTrigger)v2Trigger).MonthsOfYear = (short)value;
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

	[XmlIgnore]
	[DefaultValue(typeof(TimeSpan), "00:00:00")]
	public TimeSpan RandomDelay
	{
		get
		{
			if (v2Trigger != null)
			{
				return Task.StringToTimeSpan(((IMonthlyTrigger)v2Trigger).RandomDelay);
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
				((IMonthlyTrigger)v2Trigger).RandomDelay = Task.TimeSpanToString(value);
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["RandomDelay"] = value;
		}
	}

	[DefaultValue(false)]
	[XmlIgnore]
	public bool RunOnLastDayOfMonth
	{
		get
		{
			if (v2Trigger != null)
			{
				return ((IMonthlyTrigger)v2Trigger).RunOnLastDayOfMonth;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			if (!unboundValues.ContainsKey("RunOnLastDayOfMonth"))
			{
				return false;
			}
			return (bool)unboundValues["RunOnLastDayOfMonth"];
		}
		set
		{
			if (v2Trigger != null)
			{
				((IMonthlyTrigger)v2Trigger).RunOnLastDayOfMonth = value;
				return;
			}
			if (v1Trigger != null)
			{
				throw new NotV1SupportedException();
			}
			unboundValues["RunOnLastDayOfMonth"] = value;
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

	public MonthlyTrigger(int dayOfMonth = 1, MonthsOfTheYear monthsOfYear = MonthsOfTheYear.AllMonths)
		: base(TaskTriggerType.Monthly)
	{
		DaysOfMonth = new int[1] { dayOfMonth };
		MonthsOfYear = monthsOfYear;
	}

	internal MonthlyTrigger(ITaskTrigger iTrigger)
		: base(iTrigger, Microsoft.Win32.TaskScheduler.V1Interop.TaskTriggerType.RunMonthly)
	{
		if (v1TriggerData.Data.monthlyDate.Months == (MonthsOfTheYear)0)
		{
			v1TriggerData.Data.monthlyDate.Months = MonthsOfTheYear.AllMonths;
		}
		if (v1TriggerData.Data.monthlyDate.Days == 0)
		{
			v1TriggerData.Data.monthlyDate.Days = 1u;
		}
	}

	internal MonthlyTrigger(ITrigger iTrigger)
		: base(iTrigger)
	{
	}

	public override void CopyProperties(Trigger sourceTrigger)
	{
		base.CopyProperties(sourceTrigger);
		if ((object)sourceTrigger.GetType() == GetType())
		{
			DaysOfMonth = ((MonthlyTrigger)sourceTrigger).DaysOfMonth;
			MonthsOfYear = ((MonthlyTrigger)sourceTrigger).MonthsOfYear;
			try
			{
				RunOnLastDayOfMonth = ((MonthlyTrigger)sourceTrigger).RunOnLastDayOfMonth;
			}
			catch
			{
			}
		}
	}

	internal static int IndicesToMask(int[] indices)
	{
		int num = 0;
		foreach (int num2 in indices)
		{
			if (num2 >= 1 && num2 <= 31)
			{
				num |= 1 << num2 - 1;
				continue;
			}
			throw new ArgumentException("Days must be in the range 1..31");
		}
		return num;
	}

	internal static int[] MaskToIndices(int mask)
	{
		int num = 0;
		for (int i = 0; mask >> i > 0; i++)
		{
			num += 1 & (mask >> i);
		}
		int[] array = new int[num];
		num = 0;
		for (int j = 0; mask >> j > 0; j++)
		{
			if ((1 & (mask >> j)) == 1)
			{
				array[num++] = j + 1;
			}
		}
		return array;
	}

	private void ReadMyXml(XmlReader reader)
	{
		reader.ReadStartElement("ScheduleByMonth");
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
			case "DaysOfMonth":
			{
				reader.Read();
				List<int> list = new List<int>();
				while (reader.MoveToContent() == XmlNodeType.Element)
				{
					if (!(reader.LocalName == "Day"))
					{
						continue;
					}
					string text = reader.ReadElementContentAsString();
					if (!text.Equals("Last", StringComparison.InvariantCultureIgnoreCase))
					{
						int num = int.Parse(text);
						if (num >= 1 && num <= 31)
						{
							list.Add(num);
						}
					}
				}
				DaysOfMonth = list.ToArray();
				reader.ReadEndElement();
				break;
			}
			default:
				reader.Skip();
				break;
			}
		}
		reader.ReadEndElement();
	}

	protected override string V2GetTriggerString()
	{
		string arg = string.Join(Resources.ListSeparator, Array.ConvertAll(DaysOfMonth, (int i) => i.ToString()));
		string @string = TaskEnumGlobalizer.GetString(MonthsOfYear);
		return string.Format(Resources.TriggerMonthly1, Trigger.AdjustToLocal(base.StartBoundary), arg, @string);
	}

	private void WriteMyXml(XmlWriter writer)
	{
		writer.WriteStartElement("ScheduleByMonth");
		writer.WriteStartElement("DaysOfMonth");
		int[] daysOfMonth = DaysOfMonth;
		foreach (int num in daysOfMonth)
		{
			writer.WriteElementString("Day", num.ToString());
		}
		writer.WriteEndElement();
		writer.WriteStartElement("Months");
		foreach (MonthsOfTheYear value in Enum.GetValues(typeof(MonthsOfTheYear)))
		{
			if (value != MonthsOfTheYear.AllMonths && (MonthsOfYear & value) == value)
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
