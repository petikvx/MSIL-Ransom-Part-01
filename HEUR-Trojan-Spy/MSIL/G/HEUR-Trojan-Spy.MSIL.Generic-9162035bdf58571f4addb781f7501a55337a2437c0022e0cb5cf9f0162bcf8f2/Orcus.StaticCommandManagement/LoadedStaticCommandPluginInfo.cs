namespace Orcus.StaticCommandManagement;

public class LoadedStaticCommandPluginInfo
{
	public byte[] Hash { get; }

	public string Filename { get; }

	public LoadedStaticCommandPluginInfo(string filename, byte[] hash)
	{
		Filename = filename;
		Hash = hash;
	}
}
