namespace Gecko.WebIDL;

public class SelectionStateChangedEvent : WebIDLBase
{
	public bool Visible => GetProperty<bool>("visible");

	public string SelectedText => GetProperty<string>("selectedText");

	public nsISupports BoundingClientRect => GetProperty<nsISupports>("boundingClientRect");

	public SelectionState[] States => GetProperty<SelectionState[]>("states");

	public SelectionStateChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
