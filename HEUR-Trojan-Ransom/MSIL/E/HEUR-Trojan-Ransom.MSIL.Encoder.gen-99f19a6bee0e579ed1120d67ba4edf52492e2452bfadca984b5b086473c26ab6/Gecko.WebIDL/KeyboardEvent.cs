namespace Gecko.WebIDL;

public class KeyboardEvent : WebIDLBase
{
	public uint CharCode => GetProperty<uint>("charCode");

	public uint KeyCode => GetProperty<uint>("keyCode");

	public bool AltKey => GetProperty<bool>("altKey");

	public bool CtrlKey => GetProperty<bool>("ctrlKey");

	public bool ShiftKey => GetProperty<bool>("shiftKey");

	public bool MetaKey => GetProperty<bool>("metaKey");

	public uint Location => GetProperty<uint>("location");

	public bool Repeat => GetProperty<bool>("repeat");

	public bool IsComposing => GetProperty<bool>("isComposing");

	public string Key => GetProperty<string>("key");

	public string Code => GetProperty<string>("code");

	public KeyboardEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool GetModifierState(string key)
	{
		return CallMethod<bool>("getModifierState", new object[1] { key });
	}
}
