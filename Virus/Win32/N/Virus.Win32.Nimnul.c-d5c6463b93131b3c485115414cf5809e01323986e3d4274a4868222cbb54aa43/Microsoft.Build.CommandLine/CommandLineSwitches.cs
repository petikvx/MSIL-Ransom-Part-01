using System;
using System.Collections;
using Microsoft.Build.Shared;

namespace Microsoft.Build.CommandLine;

internal sealed class CommandLineSwitches
{
	internal enum ParameterlessSwitch
	{
		Invalid = -1,
		Help,
		Version,
		NoLogo,
		NoAutoResponse,
		NoConsoleLogger,
		NumberOfParameterlessSwitches
	}

	internal enum ParameterizedSwitch
	{
		Invalid = -1,
		Project,
		Target,
		Property,
		Logger,
		Verbosity,
		Validate,
		ConsoleLoggerParameters,
		NumberOfParameterizedSwitches
	}

	private struct ParameterlessSwitchInfo
	{
		internal string[] switchNames;

		internal string duplicateSwitchErrorMessage;

		internal ParameterlessSwitch parameterlessSwitch;

		internal ParameterlessSwitchInfo(string[] switchNames, ParameterlessSwitch parameterlessSwitch, string duplicateSwitchErrorMessage)
		{
			this.switchNames = switchNames;
			this.duplicateSwitchErrorMessage = duplicateSwitchErrorMessage;
			this.parameterlessSwitch = parameterlessSwitch;
		}
	}

	private struct ParameterizedSwitchInfo
	{
		internal string[] switchNames;

		internal string duplicateSwitchErrorMessage;

		internal bool multipleParametersAllowed;

		internal string missingParametersErrorMessage;

		internal bool unquoteParameters;

		internal ParameterizedSwitch parameterizedSwitch;

		internal ParameterizedSwitchInfo(string[] switchNames, ParameterizedSwitch parameterizedSwitch, string duplicateSwitchErrorMessage, bool multipleParametersAllowed, string missingParametersErrorMessage, bool unquoteParameters)
		{
			this.switchNames = switchNames;
			this.duplicateSwitchErrorMessage = duplicateSwitchErrorMessage;
			this.multipleParametersAllowed = multipleParametersAllowed;
			this.missingParametersErrorMessage = missingParametersErrorMessage;
			this.unquoteParameters = unquoteParameters;
			this.parameterizedSwitch = parameterizedSwitch;
		}
	}

	private struct DetectedParameterlessSwitch
	{
		internal string commandLineArg;
	}

	private struct DetectedParameterizedSwitch
	{
		internal string commandLineArg;

		internal ArrayList parameters;
	}

	private static readonly ParameterlessSwitchInfo[] parameterlessSwitchesMap = new ParameterlessSwitchInfo[5]
	{
		new ParameterlessSwitchInfo(new string[3] { "help", "h", "?" }, ParameterlessSwitch.Help, null),
		new ParameterlessSwitchInfo(new string[2] { "version", "ver" }, ParameterlessSwitch.Version, null),
		new ParameterlessSwitchInfo(new string[1] { "nologo" }, ParameterlessSwitch.NoLogo, null),
		new ParameterlessSwitchInfo(new string[2] { "noautoresponse", "noautorsp" }, ParameterlessSwitch.NoAutoResponse, null),
		new ParameterlessSwitchInfo(new string[2] { "noconsolelogger", "noconlog" }, ParameterlessSwitch.NoConsoleLogger, null)
	};

	private static readonly ParameterizedSwitchInfo[] parameterizedSwitchesMap;

	private DetectedParameterlessSwitch[] parameterlessSwitches;

	private DetectedParameterizedSwitch[] parameterizedSwitches;

	private static readonly char[] parameterSeparators;

	private static readonly string[] noParameters;

	private string errorMessage;

	private string badCommandLineArg;

	private Exception innerException;

	private bool isParameterError;

	internal bool this[ParameterlessSwitch parameterlessSwitch] => parameterlessSwitches[(int)parameterlessSwitch].commandLineArg != null;

	internal string[] this[ParameterizedSwitch parameterizedSwitch]
	{
		get
		{
			if (parameterizedSwitches[(int)parameterizedSwitch].commandLineArg == null)
			{
				return noParameters;
			}
			return (string[])parameterizedSwitches[(int)parameterizedSwitch].parameters.ToArray(typeof(string));
		}
	}

	internal static bool IsParameterlessSwitch(string switchName, out ParameterlessSwitch parameterlessSwitch, out string duplicateSwitchErrorMessage)
	{
		parameterlessSwitch = ParameterlessSwitch.Invalid;
		duplicateSwitchErrorMessage = null;
		ParameterlessSwitchInfo[] array = parameterlessSwitchesMap;
		for (int i = 0; i < array.Length; i++)
		{
			ParameterlessSwitchInfo parameterlessSwitchInfo = array[i];
			string[] switchNames = parameterlessSwitchInfo.switchNames;
			foreach (string strB in switchNames)
			{
				if (string.Compare(switchName, strB, StringComparison.OrdinalIgnoreCase) == 0)
				{
					parameterlessSwitch = parameterlessSwitchInfo.parameterlessSwitch;
					duplicateSwitchErrorMessage = parameterlessSwitchInfo.duplicateSwitchErrorMessage;
					break;
				}
			}
		}
		return parameterlessSwitch != ParameterlessSwitch.Invalid;
	}

	internal static bool IsParameterizedSwitch(string switchName, out ParameterizedSwitch parameterizedSwitch, out string duplicateSwitchErrorMessage, out bool multipleParametersAllowed, out string missingParametersErrorMessage, out bool unquoteParameters)
	{
		parameterizedSwitch = ParameterizedSwitch.Invalid;
		duplicateSwitchErrorMessage = null;
		multipleParametersAllowed = false;
		missingParametersErrorMessage = null;
		unquoteParameters = false;
		ParameterizedSwitchInfo[] array = parameterizedSwitchesMap;
		for (int i = 0; i < array.Length; i++)
		{
			ParameterizedSwitchInfo parameterizedSwitchInfo = array[i];
			string[] switchNames = parameterizedSwitchInfo.switchNames;
			foreach (string strB in switchNames)
			{
				if (string.Compare(switchName, strB, StringComparison.OrdinalIgnoreCase) == 0)
				{
					parameterizedSwitch = parameterizedSwitchInfo.parameterizedSwitch;
					duplicateSwitchErrorMessage = parameterizedSwitchInfo.duplicateSwitchErrorMessage;
					multipleParametersAllowed = parameterizedSwitchInfo.multipleParametersAllowed;
					missingParametersErrorMessage = parameterizedSwitchInfo.missingParametersErrorMessage;
					unquoteParameters = parameterizedSwitchInfo.unquoteParameters;
					break;
				}
			}
		}
		return parameterizedSwitch != ParameterizedSwitch.Invalid;
	}

	internal CommandLineSwitches()
	{
		parameterlessSwitches = new DetectedParameterlessSwitch[5];
		parameterizedSwitches = new DetectedParameterizedSwitch[7];
	}

	internal void SetParameterlessSwitch(ParameterlessSwitch parameterlessSwitch, string commandLineArg)
	{
		parameterlessSwitches[(int)parameterlessSwitch].commandLineArg = commandLineArg;
	}

	internal bool SetParameterizedSwitch(ParameterizedSwitch parameterizedSwitch, string commandLineArg, string switchParameters, bool multipleParametersAllowed, bool unquoteParameters)
	{
		bool result = false;
		if (parameterizedSwitches[(int)parameterizedSwitch].commandLineArg == null)
		{
			parameterizedSwitches[(int)parameterizedSwitch].parameters = new ArrayList();
		}
		parameterizedSwitches[(int)parameterizedSwitch].commandLineArg = commandLineArg;
		if (multipleParametersAllowed)
		{
			parameterizedSwitches[(int)parameterizedSwitch].parameters.AddRange(QuotingUtilities.SplitUnquoted(switchParameters, int.MaxValue, keepEmptySplits: false, unquoteParameters, out var emptySplits, parameterSeparators));
			result = emptySplits == 0;
		}
		else
		{
			if (unquoteParameters)
			{
				switchParameters = QuotingUtilities.Unquote(switchParameters);
			}
			if (switchParameters.Length > 0)
			{
				parameterizedSwitches[(int)parameterizedSwitch].parameters.Add(switchParameters);
				result = true;
			}
		}
		return result;
	}

	internal bool IsParameterlessSwitchSet(ParameterlessSwitch parameterlessSwitch)
	{
		return parameterlessSwitches[(int)parameterlessSwitch].commandLineArg != null;
	}

	internal string GetParameterlessSwitchCommandLineArg(ParameterlessSwitch parameterlessSwitch)
	{
		return parameterlessSwitches[(int)parameterlessSwitch].commandLineArg;
	}

	internal bool IsParameterizedSwitchSet(ParameterizedSwitch parameterizedSwitch)
	{
		return parameterizedSwitches[(int)parameterizedSwitch].commandLineArg != null;
	}

	internal string GetParameterizedSwitchCommandLineArg(ParameterizedSwitch parameterizedSwitch)
	{
		return parameterizedSwitches[(int)parameterizedSwitch].commandLineArg;
	}

	internal bool HaveAnySwitchesBeenSet()
	{
		int num = 0;
		while (true)
		{
			if (num < 5)
			{
				if (IsParameterlessSwitchSet((ParameterlessSwitch)num))
				{
					break;
				}
				num++;
				continue;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < 7)
				{
					if (IsParameterizedSwitchSet((ParameterizedSwitch)num2))
					{
						break;
					}
					num2++;
					continue;
				}
				return false;
			}
			return true;
		}
		return true;
	}

	internal void SetUnknownSwitchError(string badCommandLineArgValue)
	{
		SetSwitchError("UnknownSwitchError", badCommandLineArgValue);
	}

	internal void SetUnexpectedParametersError(string badCommandLineArgValue)
	{
		SetSwitchError("UnexpectedParametersError", badCommandLineArgValue);
	}

	internal void SetSwitchError(string messageResourceNameValue, string badCommandLineArgValue)
	{
		SetError(messageResourceNameValue, badCommandLineArgValue, null, isParameterErrorValue: false);
	}

	internal void SetParameterError(string messageResourceNameValue, string badCommandLineArgValue)
	{
		SetParameterError(messageResourceNameValue, badCommandLineArgValue, null);
	}

	internal void SetParameterError(string messageResourceNameValue, string badCommandLineArgValue, Exception innerExceptionValue)
	{
		SetError(messageResourceNameValue, badCommandLineArgValue, innerExceptionValue, isParameterErrorValue: true);
	}

	private void SetError(string messageResourceNameValue, string badCommandLineArgValue, Exception innerExceptionValue, bool isParameterErrorValue)
	{
		if (!HaveErrors())
		{
			errorMessage = messageResourceNameValue;
			badCommandLineArg = badCommandLineArgValue;
			innerException = innerExceptionValue;
			isParameterError = isParameterErrorValue;
		}
	}

	internal bool HaveErrors()
	{
		return errorMessage != null;
	}

	internal void ThrowErrors()
	{
		if (HaveErrors())
		{
			if (isParameterError)
			{
				InitializationException.Throw(errorMessage, badCommandLineArg, innerException, showStackTrace: false);
			}
			else
			{
				CommandLineSwitchException.Throw(errorMessage, badCommandLineArg);
			}
		}
	}

	internal void Append(CommandLineSwitches switchesToAppend)
	{
		if (!HaveErrors() && switchesToAppend.HaveErrors())
		{
			errorMessage = switchesToAppend.errorMessage;
			badCommandLineArg = switchesToAppend.badCommandLineArg;
			innerException = switchesToAppend.innerException;
			isParameterError = switchesToAppend.isParameterError;
		}
		for (int i = 0; i < 5; i++)
		{
			if (switchesToAppend.IsParameterlessSwitchSet((ParameterlessSwitch)i))
			{
				if (IsParameterlessSwitchSet((ParameterlessSwitch)i) && parameterlessSwitchesMap[i].duplicateSwitchErrorMessage != null)
				{
					SetSwitchError(parameterlessSwitchesMap[i].duplicateSwitchErrorMessage, switchesToAppend.GetParameterlessSwitchCommandLineArg((ParameterlessSwitch)i));
				}
				else
				{
					parameterlessSwitches[i].commandLineArg = switchesToAppend.parameterlessSwitches[i].commandLineArg;
				}
			}
		}
		for (int j = 0; j < 7; j++)
		{
			if (!switchesToAppend.IsParameterizedSwitchSet((ParameterizedSwitch)j))
			{
				continue;
			}
			if (IsParameterizedSwitchSet((ParameterizedSwitch)j) && parameterizedSwitchesMap[j].duplicateSwitchErrorMessage != null)
			{
				SetSwitchError(parameterizedSwitchesMap[j].duplicateSwitchErrorMessage, switchesToAppend.GetParameterizedSwitchCommandLineArg((ParameterizedSwitch)j));
				continue;
			}
			if (parameterizedSwitches[j].commandLineArg == null)
			{
				parameterizedSwitches[j].parameters = new ArrayList();
			}
			parameterizedSwitches[j].commandLineArg = switchesToAppend.parameterizedSwitches[j].commandLineArg;
			parameterizedSwitches[j].parameters.AddRange(switchesToAppend.parameterizedSwitches[j].parameters);
		}
	}

	static CommandLineSwitches()
	{
		ParameterizedSwitchInfo[] array = new ParameterizedSwitchInfo[7];
		ref ParameterizedSwitchInfo reference = ref array[0];
		string[] switchNames = new string[1];
		reference = new ParameterizedSwitchInfo(switchNames, ParameterizedSwitch.Project, "DuplicateProjectSwitchError", multipleParametersAllowed: false, null, unquoteParameters: true);
		ref ParameterizedSwitchInfo reference2 = ref array[1];
		reference2 = new ParameterizedSwitchInfo(new string[2] { "target", "t" }, ParameterizedSwitch.Target, null, multipleParametersAllowed: true, "MissingTargetError", unquoteParameters: true);
		ref ParameterizedSwitchInfo reference3 = ref array[2];
		reference3 = new ParameterizedSwitchInfo(new string[2] { "property", "p" }, ParameterizedSwitch.Property, null, multipleParametersAllowed: true, "MissingPropertyError", unquoteParameters: true);
		ref ParameterizedSwitchInfo reference4 = ref array[3];
		reference4 = new ParameterizedSwitchInfo(new string[2] { "logger", "l" }, ParameterizedSwitch.Logger, null, multipleParametersAllowed: false, "MissingLoggerError", unquoteParameters: false);
		ref ParameterizedSwitchInfo reference5 = ref array[4];
		reference5 = new ParameterizedSwitchInfo(new string[2] { "verbosity", "v" }, ParameterizedSwitch.Verbosity, null, multipleParametersAllowed: false, "MissingVerbosityError", unquoteParameters: true);
		ref ParameterizedSwitchInfo reference6 = ref array[5];
		reference6 = new ParameterizedSwitchInfo(new string[2] { "validate", "val" }, ParameterizedSwitch.Validate, null, multipleParametersAllowed: false, null, unquoteParameters: true);
		ref ParameterizedSwitchInfo reference7 = ref array[6];
		reference7 = new ParameterizedSwitchInfo(new string[2] { "consoleloggerparameters", "clp" }, ParameterizedSwitch.ConsoleLoggerParameters, null, multipleParametersAllowed: false, null, unquoteParameters: true);
		parameterizedSwitchesMap = array;
		parameterSeparators = new char[2] { ',', ';' };
		noParameters = new string[0];
	}
}
