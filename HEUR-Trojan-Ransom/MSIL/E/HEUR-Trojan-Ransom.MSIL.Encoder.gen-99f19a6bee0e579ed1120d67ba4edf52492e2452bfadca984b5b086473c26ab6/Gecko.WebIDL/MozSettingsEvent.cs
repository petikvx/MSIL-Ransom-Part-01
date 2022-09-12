namespace Gecko.WebIDL;

public class MozSettingsEvent : WebIDLBase
{
	public string SettingName => GetProperty<string>("settingName");

	public object SettingValue => GetProperty<object>("settingValue");

	public MozSettingsEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
