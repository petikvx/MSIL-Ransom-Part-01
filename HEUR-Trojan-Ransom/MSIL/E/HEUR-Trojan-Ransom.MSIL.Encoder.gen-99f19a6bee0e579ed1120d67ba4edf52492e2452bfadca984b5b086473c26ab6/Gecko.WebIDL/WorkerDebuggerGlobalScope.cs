namespace Gecko.WebIDL;

public class WorkerDebuggerGlobalScope : WebIDLBase
{
	public object Global => GetProperty<object>("global");

	public WorkerDebuggerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object CreateSandbox(string name, object prototype)
	{
		return CallMethod<object>("createSandbox", new object[2] { name, prototype });
	}

	public void LoadSubScript(string url)
	{
		CallVoidMethod("loadSubScript", url);
	}

	public void LoadSubScript(string url, object sandbox)
	{
		CallVoidMethod("loadSubScript", url, sandbox);
	}

	public void EnterEventLoop()
	{
		CallVoidMethod("enterEventLoop");
	}

	public void LeaveEventLoop()
	{
		CallVoidMethod("leaveEventLoop");
	}

	public void PostMessage(string message)
	{
		CallVoidMethod("postMessage", message);
	}

	public void ReportError(string message)
	{
		CallVoidMethod("reportError", message);
	}

	public void Dump()
	{
		CallVoidMethod("dump");
	}

	public void Dump(string @string)
	{
		CallVoidMethod("dump", @string);
	}
}
