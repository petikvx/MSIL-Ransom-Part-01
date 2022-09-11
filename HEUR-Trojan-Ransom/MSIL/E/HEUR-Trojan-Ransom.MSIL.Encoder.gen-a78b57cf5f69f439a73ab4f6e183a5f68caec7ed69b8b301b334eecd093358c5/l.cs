using System.Configuration;

internal sealed class l : ApplicationSettingsBase
{
	private static l m_a = (l)(object)SettingsBase.Synchronized((SettingsBase)(object)new l());

	public static l a => l.m_a;
}
