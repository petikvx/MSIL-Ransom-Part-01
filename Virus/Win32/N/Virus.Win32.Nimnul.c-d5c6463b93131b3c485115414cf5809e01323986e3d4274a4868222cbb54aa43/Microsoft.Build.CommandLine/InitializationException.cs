using System;
using Microsoft.Build.Shared;

namespace Microsoft.Build.CommandLine;

internal sealed class InitializationException : Exception
{
	private string invalidSwitch;

	public override string Message
	{
		get
		{
			if (invalidSwitch == null)
			{
				return base.Message;
			}
			return base.Message + Environment.NewLine + ResourceUtilities.FormatResourceString("InvalidSwitchIndicator", invalidSwitch);
		}
	}

	private InitializationException()
	{
	}

	private InitializationException(string message)
		: base(message)
	{
	}

	private InitializationException(string message, string invalidSwitch)
		: this(message)
	{
		this.invalidSwitch = invalidSwitch;
	}

	internal static void VerifyThrow(bool condition, string messageResourceName)
	{
		VerifyThrow(condition, messageResourceName, null);
	}

	internal static void VerifyThrow(bool condition, string messageResourceName, string invalidSwitch)
	{
		if (!condition)
		{
			Throw(messageResourceName, invalidSwitch, null, showStackTrace: false);
		}
	}

	internal static void Throw(string messageResourceName, string invalidSwitch, Exception e, bool showStackTrace)
	{
		string @string = AssemblyResources.GetString(messageResourceName);
		ErrorUtilities.VerifyThrow(@string != null, "The resource string must exist.");
		@string = ((!showStackTrace) ? ResourceUtilities.FormatString(@string, (e == null) ? string.Empty : e.Message) : (@string + Environment.NewLine + e.ToString()));
		Throw(@string, invalidSwitch);
	}

	internal static void Throw(string message, string invalidSwitch)
	{
		ErrorUtilities.VerifyThrow(message != null, "The string must exist.");
		throw new InitializationException(message, invalidSwitch);
	}
}
