namespace Gecko.WebIDL;

public class PluginCrashedEvent : WebIDLBase
{
	public uint PluginID => GetProperty<uint>("pluginID");

	public string PluginDumpID => GetProperty<string>("pluginDumpID");

	public string PluginName => GetProperty<string>("pluginName");

	public string BrowserDumpID => GetProperty<string>("browserDumpID");

	public string PluginFilename => GetProperty<string>("pluginFilename");

	public bool SubmittedCrashReport => GetProperty<bool>("submittedCrashReport");

	public bool GmpPlugin => GetProperty<bool>("gmpPlugin");

	public PluginCrashedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
