using System;

namespace NVCameraViewer;

[Serializable]
public class SettingClass
{
	public enum enumDisplayType
	{
		GDI = 0,
		Overlay = 2
	}

	public enumDisplayType DisplayType;

	public ProfileClass[] Profiles;

	public int ProfileSelected;

	public string CapturePath;

	public string RecordPath;

	public SettingClass()
	{
		DisplayType = enumDisplayType.Overlay;
		ProfileSelected = 0;
		CapturePath = string.Empty;
		RecordPath = string.Empty;
	}
}
