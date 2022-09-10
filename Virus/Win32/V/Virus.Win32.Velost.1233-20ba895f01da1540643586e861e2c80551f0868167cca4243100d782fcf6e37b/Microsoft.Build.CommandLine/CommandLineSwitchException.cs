using System;
using Microsoft.Build.Shared;

namespace Microsoft.Build.CommandLine;

internal sealed class CommandLineSwitchException : Exception
{
	private string commandLineArg;

	public override string Message
	{
		get
		{
			if (commandLineArg == null)
			{
				return base.Message;
			}
			return base.Message + Environment.NewLine + ResourceUtilities.FormatResourceString("InvalidSwitchIndicator", commandLineArg);
		}
	}

	internal string CommandLineArg => commandLineArg;

	private CommandLineSwitchException()
	{
	}

	private CommandLineSwitchException(string message)
		: base(message)
	{
	}

	private CommandLineSwitchException(string message, string commandLineArg)
		: this(message)
	{
		this.commandLineArg = commandLineArg;
	}

	internal static void VerifyThrow(bool condition, string messageResourceName, string commandLineArg)
	{
		if (!condition)
		{
			Throw(messageResourceName, commandLineArg);
		}
	}

	internal static void Throw(string messageResourceName, string commandLineArg)
	{
		string @string = AssemblyResources.GetString(messageResourceName);
		ErrorUtilities.VerifyThrow(@string != null, "The resource string must exist.");
		throw new CommandLineSwitchException(@string, commandLineArg);
	}
}
