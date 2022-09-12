using System;
using System.Linq;

namespace InstagramApiSharp.Classes.Android.DeviceInfo;

[Serializable]
public class AndroidVersion
{
	private static Random Rnd = new Random();

	private static AndroidVersion LastAndriodVersion = AndroidVersionList.GetVersionList().AndroidVersions()[AndroidVersionList.GetVersionList().AndroidVersions().Count - 2];

	public string Codename { get; set; }

	public string VersionNumber { get; set; }

	public string APILevel { get; set; }

	internal AndroidVersion()
	{
	}

	public static AndroidVersion FromString(string versionString)
	{
		Version version = new Version(versionString);
		foreach (AndroidVersion item in AndroidVersionList.GetVersionList().AndroidVersions())
		{
			if (version.CompareTo(new Version(item.VersionNumber)) == 0 || (version.CompareTo(new Version(item.VersionNumber)) > 0 && item != AndroidVersionList.GetVersionList().AndroidVersions().Last() && version.CompareTo(new Version(AndroidVersionList.GetVersionList().AndroidVersions()[AndroidVersionList.GetVersionList().AndroidVersions().IndexOf(item) + 1].VersionNumber)) < 0))
			{
				return item;
			}
		}
		return null;
	}

	public static AndroidVersion GetRandomAndriodVersion()
	{
		AndroidVersion androidVersion;
		do
		{
			int index = Rnd.Next(0, AndroidVersionList.GetVersionList().AndroidVersions().Count);
			androidVersion = AndroidVersionList.GetVersionList().AndroidVersions().ElementAt(index);
		}
		while (LastAndriodVersion != null && androidVersion.APILevel == LastAndriodVersion.APILevel);
		LastAndriodVersion = androidVersion;
		return androidVersion;
	}

	public static AndroidVersion GetAndroidVersion(string apiLevel)
	{
		if (string.IsNullOrEmpty(apiLevel))
		{
			return null;
		}
		return AndroidVersionList.GetVersionList().AndroidVersions().FirstOrDefault((AndroidVersion api) => api.APILevel == apiLevel);
	}
}
