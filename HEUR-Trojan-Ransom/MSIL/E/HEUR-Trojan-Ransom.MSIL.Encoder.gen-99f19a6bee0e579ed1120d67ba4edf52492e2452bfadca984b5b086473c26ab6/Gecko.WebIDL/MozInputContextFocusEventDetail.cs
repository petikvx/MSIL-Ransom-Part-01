namespace Gecko.WebIDL;

public class MozInputContextFocusEventDetail : WebIDLBase
{
	public MozInputMethodInputContextTypes Type => GetProperty<MozInputMethodInputContextTypes>("type");

	public MozInputMethodInputContextInputTypes InputType => GetProperty<MozInputMethodInputContextInputTypes>("inputType");

	public string Value => GetProperty<string>("value");

	public object Choices => GetProperty<object>("choices");

	public string Min => GetProperty<string>("min");

	public string Max => GetProperty<string>("max");

	public MozInputContextFocusEventDetail(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
