using System;

namespace NVCameraViewer;

[Serializable]
public class ProfileCameraItemClass
{
	public string CameraName;

	public string CameraIP;

	public int CameraPort;

	public int CameraID;

	public ProfileCameraItemClass()
	{
		CameraPort = 20900;
	}
}
