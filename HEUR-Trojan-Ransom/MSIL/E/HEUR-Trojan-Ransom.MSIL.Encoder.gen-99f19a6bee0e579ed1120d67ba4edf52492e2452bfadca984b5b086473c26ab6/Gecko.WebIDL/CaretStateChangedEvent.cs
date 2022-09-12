namespace Gecko.WebIDL;

public class CaretStateChangedEvent : WebIDLBase
{
	public bool Collapsed => GetProperty<bool>("collapsed");

	public nsISupports BoundingClientRect => GetProperty<nsISupports>("boundingClientRect");

	public CaretChangedReason Reason => GetProperty<CaretChangedReason>("reason");

	public bool CaretVisible => GetProperty<bool>("caretVisible");

	public bool CaretVisuallyVisible => GetProperty<bool>("caretVisuallyVisible");

	public bool SelectionVisible => GetProperty<bool>("selectionVisible");

	public bool SelectionEditable => GetProperty<bool>("selectionEditable");

	public string SelectedTextContent => GetProperty<string>("selectedTextContent");

	public CaretStateChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
