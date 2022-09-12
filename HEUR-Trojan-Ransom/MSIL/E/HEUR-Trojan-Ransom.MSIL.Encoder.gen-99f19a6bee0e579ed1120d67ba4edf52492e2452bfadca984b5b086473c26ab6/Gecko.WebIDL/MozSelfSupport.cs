namespace Gecko.WebIDL;

public class MozSelfSupport : WebIDLBase
{
	public bool HealthReportDataSubmissionEnabled
	{
		get
		{
			return GetProperty<bool>("healthReportDataSubmissionEnabled");
		}
		set
		{
			SetProperty("healthReportDataSubmissionEnabled", value);
		}
	}

	public MozSelfSupport(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object> GetHealthReportPayload()
	{
		return CallMethod<Promise<object>>("getHealthReportPayload", new object[0]);
	}

	public Promise<object[]> GetTelemetryPingList()
	{
		return CallMethod<Promise<object[]>>("getTelemetryPingList", new object[0]);
	}

	public Promise<object> GetTelemetryPing(string pingID)
	{
		return CallMethod<Promise<object>>("getTelemetryPing", new object[1] { pingID });
	}

	public Promise<object> GetCurrentTelemetryEnvironment()
	{
		return CallMethod<Promise<object>>("getCurrentTelemetryEnvironment", new object[0]);
	}

	public Promise<object> GetCurrentTelemetrySubsessionPing()
	{
		return CallMethod<Promise<object>>("getCurrentTelemetrySubsessionPing", new object[0]);
	}

	public void ResetPref(string name)
	{
		CallVoidMethod("resetPref", name);
	}

	public void ResetSearchEngines()
	{
		CallVoidMethod("resetSearchEngines");
	}
}
