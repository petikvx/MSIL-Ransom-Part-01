using System;
using System.Globalization;

namespace Microsoft.Tools.ServiceModel.SvcUtil;

internal static class CommandParser
{
	internal static ArgumentDictionary ParseCommand(string[] cmd, CommandSwitch[] switches)
	{
		ArgumentDictionary argumentDictionary = new ArgumentDictionary(cmd.Length);
		foreach (string text in cmd)
		{
			string text2 = text;
			bool flag = true;
			if (text2[0] != '/' && text2[0] != '-')
			{
				argumentDictionary.Add(string.Empty, text2);
				continue;
			}
			if (text2.Length != 1)
			{
				text2 = text2.Substring(1);
				int num = text2.IndexOfAny(new char[2] { ':', '=' });
				if (num != 0)
				{
					string value;
					if (num == -1)
					{
						value = string.Empty;
					}
					else
					{
						value = text2.Substring(num + 1);
						text2 = text2.Substring(0, num);
						flag = false;
					}
					CommandSwitch commandSwitch = CommandSwitch.FindSwitch(text2.ToLower(CultureInfo.InvariantCulture), switches);
					if (commandSwitch != null)
					{
						if (commandSwitch.SwitchType == SwitchType.Flag)
						{
							if (!flag)
							{
								throw new ArgumentException(SR.GetString("ErrUnexpectedValue", text2.ToLower(CultureInfo.InvariantCulture)));
							}
						}
						else if (flag)
						{
							throw new ArgumentException(SR.GetString("ErrExpectedValue", text2.ToLower(CultureInfo.InvariantCulture)));
						}
						if (commandSwitch.SwitchType == SwitchType.ValueList || !argumentDictionary.ContainsArgument(commandSwitch.Name))
						{
							argumentDictionary.Add(commandSwitch.Name, value);
							continue;
						}
						throw new ArgumentException(SR.GetString("ErrSingleUseSwitch", text2.ToLower(CultureInfo.InvariantCulture)));
					}
					throw new ArgumentException(SR.GetString("ErrUnknownSwitch", text2.ToLower(CultureInfo.InvariantCulture)));
				}
				throw new ArgumentException(SR.GetString("ErrUnexpectedDelimiter"));
			}
			throw new ArgumentException(SR.GetString("ErrSwitchMissing", text2));
		}
		return argumentDictionary;
	}
}
