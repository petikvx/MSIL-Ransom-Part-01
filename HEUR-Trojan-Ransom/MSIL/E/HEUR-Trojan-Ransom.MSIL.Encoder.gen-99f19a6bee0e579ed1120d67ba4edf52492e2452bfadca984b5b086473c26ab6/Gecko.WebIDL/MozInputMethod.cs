namespace Gecko.WebIDL;

public class MozInputMethod : WebIDLBase
{
	public nsISupports Mgmt => GetProperty<nsISupports>("mgmt");

	public nsISupports Inputcontext => GetProperty<nsISupports>("inputcontext");

	public MozInputMethod(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetActive(bool isActive)
	{
		CallVoidMethod("setActive", isActive);
	}

	public Promise AddInput(string inputId, object inputManifest)
	{
		return CallMethod<Promise>("addInput", new object[2] { inputId, inputManifest });
	}

	public Promise RemoveInput(string id)
	{
		return CallMethod<Promise>("removeInput", new object[1] { id });
	}

	public void RemoveFocus()
	{
		CallVoidMethod("removeFocus");
	}

	public void SetValue(string value)
	{
		CallVoidMethod("setValue", value);
	}

	public void SetSelectedOption(int index)
	{
		CallVoidMethod("setSelectedOption", index);
	}

	public void SetSelectedOptions(int[] indexes)
	{
		CallVoidMethod("setSelectedOptions", indexes);
	}
}
