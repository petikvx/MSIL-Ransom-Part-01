using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace NChanges;

public class Settings : ApplicationSettingsBase
{
	private static readonly Settings _default = new Settings();

	private const int MaxRecentProjects = 10;

	public static Settings Default => _default;

	[UserScopedSetting]
	public List<string> RecentProjects
	{
		get
		{
			return (List<string>)((SettingsBase)this).get_Item("RecentProjects");
		}
		set
		{
			((SettingsBase)this).set_Item("RecentProjects", (object)value);
		}
	}

	public void AddRecentProject(string path)
	{
		List<string> list = RecentProjects ?? new List<string>();
		list.Remove(path);
		list.Insert(0, path);
		RecentProjects = list.Take(10).ToList();
		((SettingsBase)this).Save();
	}

	public void ClearRecentProjects()
	{
		RecentProjects = null;
		((SettingsBase)this).Save();
	}
}
