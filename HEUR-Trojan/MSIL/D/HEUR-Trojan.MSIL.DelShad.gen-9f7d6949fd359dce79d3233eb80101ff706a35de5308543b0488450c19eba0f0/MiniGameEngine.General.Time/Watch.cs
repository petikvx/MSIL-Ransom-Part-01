using System;
using Microsoft.VisualBasic;

namespace MiniGameEngine.General.Time;

public class Watch
{
	private DateTime dateTime_0;

	private DateTime dateTime_1;

	public double Milliseconds => (double)Math.Abs(checked(dateTime_0.Ticks - dateTime_1.Ticks)) / 10000.0;

	public double Seconds => Milliseconds / 1000.0;

	public double Minutes => Seconds / 60.0;

	public double Hours => Minutes / 60.0;

	public Watch(DateTime dateOne, DateTime dateTwo)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		dateTime_0 = dateOne;
		dateTime_1 = dateTwo;
	}

	public static DateTime getNow()
	{
		DateTime result = new DateTime(DateAndTime.get_Now().Ticks);
		return result;
	}

	public static long getLiveTicks()
	{
		return DateAndTime.get_Now().Ticks;
	}

	public static long getLiveMilliseconds()
	{
		return checked((long)Math.Round((double)DateAndTime.get_Now().Ticks / 10000.0));
	}
}
