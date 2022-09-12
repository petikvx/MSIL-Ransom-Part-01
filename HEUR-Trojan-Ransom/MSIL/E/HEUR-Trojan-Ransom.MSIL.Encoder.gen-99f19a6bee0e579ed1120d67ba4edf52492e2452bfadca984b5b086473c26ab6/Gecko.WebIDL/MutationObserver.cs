namespace Gecko.WebIDL;

public class MutationObserver : WebIDLBase
{
	public bool MergeAttributeRecords
	{
		get
		{
			return GetProperty<bool>("mergeAttributeRecords");
		}
		set
		{
			SetProperty("mergeAttributeRecords", value);
		}
	}

	public MutationObserver(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Observe(nsIDOMNode target)
	{
		CallVoidMethod("observe", target);
	}

	public void Observe(nsIDOMNode target, object options)
	{
		CallVoidMethod("observe", target, options);
	}

	public void Disconnect()
	{
		CallVoidMethod("disconnect");
	}

	public nsISupports[] TakeRecords()
	{
		return CallMethod<nsISupports[]>("takeRecords", new object[0]);
	}

	public object[] GetObservingInfo()
	{
		return CallMethod<object[]>("getObservingInfo", new object[0]);
	}
}
