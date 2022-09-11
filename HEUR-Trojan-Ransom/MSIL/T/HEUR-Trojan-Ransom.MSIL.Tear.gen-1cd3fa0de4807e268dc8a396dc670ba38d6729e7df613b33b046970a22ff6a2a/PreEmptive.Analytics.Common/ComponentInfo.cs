using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common;

public struct ComponentInfo
{
	public string Name;

	public string Version;

	public string FullName;

	public ComponentInfo(string name, [Optional] string version, [Optional] string fullname)
	{
		Name = name;
		Version = version;
		FullName = fullname;
	}
}
