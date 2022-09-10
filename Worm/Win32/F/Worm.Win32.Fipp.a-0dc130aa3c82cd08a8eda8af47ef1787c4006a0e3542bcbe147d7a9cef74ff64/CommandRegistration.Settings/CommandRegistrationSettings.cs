using System.IO;
using HSPS.eServices.DigitalHighway.Model;
using HSPS.eServices.DigitalHighway.Settings;
using HSPS.eServices.DigitalHighway.Utilities;

namespace CommandRegistration.Settings;

public class CommandRegistrationSettings : SettingsBase
{
	public string DeveloperLicenseKey
	{
		get
		{
			((SettingsBase)this).LoadSettings();
			string empty = string.Empty;
			try
			{
				return Security.Decrypt(base.settingsList.GetValue("DeveloperLicenseKey"), base.encryptionKey);
			}
			catch
			{
				return base.settingsList.GetValue("DeveloperLicenseKey");
			}
		}
		set
		{
			string text = Security.Encrypt(value, base.encryptionKey);
			base.settingsList.SetValue("DeveloperLicenseKey", text);
			((SettingsBase)this).SaveSettings();
		}
	}

	public CommandList CommandType
	{
		get
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			((SettingsBase)this).LoadSettings();
			string empty = string.Empty;
			try
			{
				empty = Security.Decrypt(base.settingsList.GetValue("CommandType"), base.encryptionKey);
			}
			catch
			{
				empty = base.settingsList.GetValue("CommandType");
			}
			CommandList val = new CommandList();
			val.DeserializeFromXML(empty);
			return val;
		}
		set
		{
			string text = Security.Encrypt(value.SerializeToXML(), base.encryptionKey);
			base.settingsList.SetValue("CommandType", text);
			((SettingsBase)this).SaveSettings();
		}
	}

	public string SettingsValue
	{
		get
		{
			((SettingsBase)this).LoadSettings();
			string empty = string.Empty;
			try
			{
				return Security.Decrypt(base.settingsList.GetValue("SettingsValue"), base.encryptionKey);
			}
			catch
			{
				return base.settingsList.GetValue("SettingsValue");
			}
		}
		set
		{
			string text = Security.Encrypt(value, base.encryptionKey);
			base.settingsList.SetValue("SettingsValue", text);
			((SettingsBase)this).SaveSettings();
		}
	}

	public string SettingsKey
	{
		get
		{
			((SettingsBase)this).LoadSettings();
			string empty = string.Empty;
			try
			{
				return Security.Decrypt(base.settingsList.GetValue("SettingsKey"), base.encryptionKey);
			}
			catch
			{
				return base.settingsList.GetValue("SettingsKey");
			}
		}
		set
		{
			string text = Security.Encrypt(value, base.encryptionKey);
			base.settingsList.SetValue("SettingsKey", text);
			((SettingsBase)this).SaveSettings();
		}
	}

	public CommandRegistrationSettings(string filePath, StorageType storageType)
		: base(filePath, storageType)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(filePath))
		{
			((SettingsBase)this).SaveSettings();
		}
	}
}
