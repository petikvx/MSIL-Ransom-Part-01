using HSPS.eServices.DigitalHighway.Model;

namespace CommandRegistration.Model;

public class CommandRegistrationInformation
{
	private string settingsKey;

	private string developerLicenseKey;

	private CommandList commandType;

	private string settingsValue;

	public string DeveloperLicenseKey
	{
		get
		{
			return developerLicenseKey;
		}
		set
		{
			developerLicenseKey = value;
		}
	}

	public string SettingsKey
	{
		get
		{
			return settingsKey;
		}
		set
		{
			settingsKey = value;
		}
	}

	public CommandList CommandType
	{
		get
		{
			return commandType;
		}
		set
		{
			commandType = value;
		}
	}

	public string SettingsValue
	{
		get
		{
			return settingsValue;
		}
		set
		{
			settingsValue = value;
		}
	}
}
