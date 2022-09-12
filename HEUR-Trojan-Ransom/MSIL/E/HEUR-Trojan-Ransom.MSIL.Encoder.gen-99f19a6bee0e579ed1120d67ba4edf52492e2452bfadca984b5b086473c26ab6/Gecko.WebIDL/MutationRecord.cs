namespace Gecko.WebIDL;

public class MutationRecord : WebIDLBase
{
	public string Type => GetProperty<string>("type");

	public nsIDOMNode Target => GetProperty<nsIDOMNode>("target");

	public nsISupports AddedNodes => GetProperty<nsISupports>("addedNodes");

	public nsISupports RemovedNodes => GetProperty<nsISupports>("removedNodes");

	public nsIDOMNode PreviousSibling => GetProperty<nsIDOMNode>("previousSibling");

	public nsIDOMNode NextSibling => GetProperty<nsIDOMNode>("nextSibling");

	public string AttributeName => GetProperty<string>("attributeName");

	public string AttributeNamespace => GetProperty<string>("attributeNamespace");

	public string OldValue => GetProperty<string>("oldValue");

	public nsISupports[] AddedAnimations => GetProperty<nsISupports[]>("addedAnimations");

	public nsISupports[] ChangedAnimations => GetProperty<nsISupports[]>("changedAnimations");

	public nsISupports[] RemovedAnimations => GetProperty<nsISupports[]>("removedAnimations");

	public MutationRecord(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
