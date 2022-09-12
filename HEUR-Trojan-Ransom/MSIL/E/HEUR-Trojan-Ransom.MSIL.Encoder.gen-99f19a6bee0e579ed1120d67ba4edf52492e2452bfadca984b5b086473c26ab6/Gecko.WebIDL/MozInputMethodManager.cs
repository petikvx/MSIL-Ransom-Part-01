namespace Gecko.WebIDL;

public class MozInputMethodManager : WebIDLBase
{
	public MozInputMethodManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void ShowAll()
	{
		CallVoidMethod("showAll");
	}

	public void Next()
	{
		CallVoidMethod("next");
	}

	public bool SupportsSwitching()
	{
		return CallMethod<bool>("supportsSwitching", new object[0]);
	}

	public void Hide()
	{
		CallVoidMethod("hide");
	}

	public void SetSupportsSwitchingTypes(MozInputMethodInputContextInputTypes[] types)
	{
		CallVoidMethod("setSupportsSwitchingTypes", types);
	}
}
