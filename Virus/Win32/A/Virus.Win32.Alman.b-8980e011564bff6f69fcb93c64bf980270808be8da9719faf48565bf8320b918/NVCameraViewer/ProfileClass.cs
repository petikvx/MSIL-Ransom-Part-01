using System;

namespace NVCameraViewer;

[Serializable]
public class ProfileClass
{
	public enum enumSplitType
	{
		Auto,
		Split_1,
		Split_2x2,
		Split_3x3,
		Split_4x4,
		Split_5x5,
		Split_6x6
	}

	public enum enumCompressType
	{
		Level_0,
		Level_1,
		Level_2,
		Level_3,
		Level_4
	}

	public enum enumServerType
	{
		NVideoType,
		NVCCTypeForNVCCServer,
		NVCCTypeForNVideoServer
	}

	public string ProfileName;

	public ProfileKeyClass ProfileKey;

	public enumSplitType SplitType;

	public enumCompressType CompressType;

	public enumServerType ServerType;

	public string LoginAccount;

	public string LoginPassword;

	public ProfileCameraItemClass[] CameraList;

	public ProfileClass()
	{
		ProfileName = string.Empty;
		SplitType = enumSplitType.Auto;
		CompressType = enumCompressType.Level_4;
		ServerType = enumServerType.NVCCTypeForNVideoServer;
		LoginAccount = string.Empty;
		LoginPassword = string.Empty;
	}
}
