namespace Gecko.WebIDL;

public class HMDVRDevice : WebIDLBase
{
	public HMDVRDevice(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetEyeParameters(VREye whichEye)
	{
		return CallMethod<nsISupports>("getEyeParameters", new object[1] { whichEye });
	}

	public void SetFieldOfView()
	{
		CallVoidMethod("setFieldOfView");
	}

	public void SetFieldOfView(object leftFOV)
	{
		CallVoidMethod("setFieldOfView", leftFOV);
	}

	public void SetFieldOfView(object leftFOV, object rightFOV)
	{
		CallVoidMethod("setFieldOfView", leftFOV, rightFOV);
	}

	public void SetFieldOfView(object leftFOV, object rightFOV, double zNear)
	{
		CallVoidMethod("setFieldOfView", leftFOV, rightFOV, zNear);
	}

	public void SetFieldOfView(object leftFOV, object rightFOV, double zNear, double zFar)
	{
		CallVoidMethod("setFieldOfView", leftFOV, rightFOV, zNear, zFar);
	}
}
