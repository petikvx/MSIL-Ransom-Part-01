namespace Gecko.WebIDL;

public class Console : WebIDLBase
{
	public Console(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Log(object data)
	{
		CallVoidMethod("log", data);
	}

	public void Info(object data)
	{
		CallVoidMethod("info", data);
	}

	public void Warn(object data)
	{
		CallVoidMethod("warn", data);
	}

	public void Error(object data)
	{
		CallVoidMethod("error", data);
	}

	public void _exception(object data)
	{
		CallVoidMethod("_exception", data);
	}

	public void Debug(object data)
	{
		CallVoidMethod("debug", data);
	}

	public void Table(object data)
	{
		CallVoidMethod("table", data);
	}

	public void Trace()
	{
		CallVoidMethod("trace");
	}

	public void Dir(object data)
	{
		CallVoidMethod("dir", data);
	}

	public void Dirxml(object data)
	{
		CallVoidMethod("dirxml", data);
	}

	public void Group(object data)
	{
		CallVoidMethod("group", data);
	}

	public void GroupCollapsed(object data)
	{
		CallVoidMethod("groupCollapsed", data);
	}

	public void GroupEnd(object data)
	{
		CallVoidMethod("groupEnd", data);
	}

	public void Time()
	{
		CallVoidMethod("time");
	}

	public void Time(object time)
	{
		CallVoidMethod("time", time);
	}

	public void TimeEnd()
	{
		CallVoidMethod("timeEnd");
	}

	public void TimeEnd(object time)
	{
		CallVoidMethod("timeEnd", time);
	}

	public void TimeStamp()
	{
		CallVoidMethod("timeStamp");
	}

	public void TimeStamp(object data)
	{
		CallVoidMethod("timeStamp", data);
	}

	public void Profile(object data)
	{
		CallVoidMethod("profile", data);
	}

	public void ProfileEnd(object data)
	{
		CallVoidMethod("profileEnd", data);
	}

	public void Assert(bool condition, object data)
	{
		CallVoidMethod("assert", condition, data);
	}

	public void Count(object data)
	{
		CallVoidMethod("count", data);
	}

	public void Clear()
	{
		CallVoidMethod("clear");
	}

	public void MarkTimeline()
	{
		CallVoidMethod("markTimeline");
	}

	public void Timeline()
	{
		CallVoidMethod("timeline");
	}

	public void TimelineEnd()
	{
		CallVoidMethod("timelineEnd");
	}
}
