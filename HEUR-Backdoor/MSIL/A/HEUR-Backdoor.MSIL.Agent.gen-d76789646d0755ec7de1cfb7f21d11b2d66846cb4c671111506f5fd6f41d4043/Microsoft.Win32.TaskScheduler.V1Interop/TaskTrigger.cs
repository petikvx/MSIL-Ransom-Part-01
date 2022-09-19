using System;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

internal struct TaskTrigger
{
	public ushort TriggerSize;

	public ushort Reserved1;

	public ushort BeginYear;

	public ushort BeginMonth;

	public ushort BeginDay;

	public ushort EndYear;

	public ushort EndMonth;

	public ushort EndDay;

	public ushort StartHour;

	public ushort StartMinute;

	public uint MinutesDuration;

	public uint MinutesInterval;

	public TaskTriggerFlags Flags;

	public TaskTriggerType Type;

	public TriggerTypeData Data;

	public ushort Reserved2;

	public ushort RandomMinutesInterval;

	public DateTime BeginDate
	{
		get
		{
			return new DateTime(BeginYear, BeginMonth, BeginDay, StartHour, StartMinute, 0, DateTimeKind.Unspecified);
		}
		set
		{
			if (value != DateTime.MinValue)
			{
				DateTime dateTime = ((value.Kind == DateTimeKind.Utc) ? value.ToLocalTime() : value);
				BeginYear = (ushort)dateTime.Year;
				BeginMonth = (ushort)dateTime.Month;
				BeginDay = (ushort)dateTime.Day;
				StartHour = (ushort)dateTime.Hour;
				StartMinute = (ushort)dateTime.Minute;
			}
			else
			{
				StartMinute = 0;
				StartHour = 0;
				BeginDay = 0;
				BeginMonth = 0;
				BeginYear = 0;
			}
		}
	}

	public DateTime EndDate
	{
		get
		{
			if (EndYear != 0)
			{
				return new DateTime(EndYear, EndMonth, EndDay);
			}
			return DateTime.MaxValue;
		}
		set
		{
			if (value != DateTime.MaxValue)
			{
				EndYear = (ushort)value.Year;
				EndMonth = (ushort)value.Month;
				EndDay = (ushort)value.Day;
				Flags |= TaskTriggerFlags.HasEndDate;
			}
			else
			{
				EndDay = 0;
				EndMonth = 0;
				EndYear = 0;
				Flags &= ~TaskTriggerFlags.HasEndDate;
			}
		}
	}

	public override string ToString()
	{
		return string.Format("Trigger Type: {6};\n> Start: {0}; End: {1};\n> DurMin: {4}; DurItv: {5};\n>", BeginDate, (EndYear == 0) ? "null" : EndDate.ToString(), Data, Flags, MinutesDuration, MinutesInterval, Type);
	}
}
