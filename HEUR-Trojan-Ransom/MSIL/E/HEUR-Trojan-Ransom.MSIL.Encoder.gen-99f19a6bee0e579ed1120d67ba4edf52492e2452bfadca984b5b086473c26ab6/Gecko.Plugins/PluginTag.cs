namespace Gecko.Plugins;

public sealed class PluginTag
{
	internal nsIPluginTag _pluginTag;

	public bool Blocklisted => _pluginTag.GetBlocklistedAttribute();

	public string Description => nsString.Get(_pluginTag.GetDescriptionAttribute);

	public bool Disabled => _pluginTag.GetDisabledAttribute();

	public string FileName => nsString.Get(_pluginTag.GetFilenameAttribute);

	public string Fullpath => nsString.Get(_pluginTag.GetFullpathAttribute);

	public string Name => nsString.Get(_pluginTag.GetNameAttribute);

	public string Version => nsString.Get(_pluginTag.GetVersionAttribute);

	internal PluginTag(nsIPluginTag pluginTag)
	{
		_pluginTag = pluginTag;
	}
}
