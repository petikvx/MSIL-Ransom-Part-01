namespace Gecko.WebIDL;

public class CameraManager : WebIDLBase
{
	public CameraManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object> GetCamera(string camera)
	{
		return CallMethod<Promise<object>>("getCamera", new object[1] { camera });
	}

	public Promise<object> GetCamera(string camera, object initialConfiguration)
	{
		return CallMethod<Promise<object>>("getCamera", new object[2] { camera, initialConfiguration });
	}

	public string[] GetListOfCameras()
	{
		return CallMethod<string[]>("getListOfCameras", new object[0]);
	}
}
