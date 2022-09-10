using System.Globalization;

namespace Microsoft.Tools.ServiceModel.SvcUtil;

internal class CommandSwitch
{
	private readonly string name;

	private readonly string abbreviation;

	private readonly SwitchType switchType;

	internal string Name => name;

	internal SwitchType SwitchType => switchType;

	internal CommandSwitch(string name, string abbreviation, SwitchType switchType)
	{
		if (name[0] != '/' && name[0] != '-')
		{
			this.name = name.ToLower(CultureInfo.InvariantCulture);
		}
		else
		{
			this.name = name.Substring(1).ToLower(CultureInfo.InvariantCulture);
		}
		if (abbreviation[0] != '/' && abbreviation[0] != '-')
		{
			this.abbreviation = abbreviation.ToLower(CultureInfo.InvariantCulture);
		}
		else
		{
			this.abbreviation = abbreviation.Substring(1).ToLower(CultureInfo.InvariantCulture);
		}
		this.switchType = switchType;
	}

	internal bool Equals(string other)
	{
		string value = ((other[0] == '/' || other[0] == '-') ? other.Substring(1).ToLower(CultureInfo.InvariantCulture) : other.ToLower(CultureInfo.InvariantCulture));
		if (name.Equals(value))
		{
			return true;
		}
		return abbreviation.Equals(value);
	}

	internal static CommandSwitch FindSwitch(string name, CommandSwitch[] switches)
	{
		int num = 0;
		CommandSwitch commandSwitch;
		while (true)
		{
			if (num < switches.Length)
			{
				commandSwitch = switches[num];
				if (commandSwitch.Equals(name))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return commandSwitch;
	}
}
