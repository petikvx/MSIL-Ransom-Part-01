using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading;
using Microsoft.Build.BuildEngine;
using Microsoft.Build.Framework;
using Microsoft.Build.Shared;

namespace Microsoft.Build.CommandLine;

public static class MSBuildApp
{
	public enum ExitType
	{
		Success,
		SwitchError,
		InitializationError,
		BuildError,
		LoggerAbort,
		LoggerFailure
	}

	private const string autoResponseFileName = "MSBuild.rsp";

	private static readonly string binPath = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().EscapedCodeBase).LocalPath);

	private static ArrayList includedResponseFiles;

	internal static bool usingSwitchesFromAutoResponseFile = false;

	private static readonly char[] propertyValueSeparator = new char[1] { '=' };

	private static readonly TypeFilter loggerClassFilter = IsLoggerClass;

	[STAThread]
	public static int Main()
	{
		if (Execute(Environment.CommandLine) != 0)
		{
			return 1;
		}
		return 0;
	}

	public static ExitType Execute(string commandLine)
	{
		//IL_009b: Expected O, but got Unknown
		//IL_0119: Expected O, but got Unknown
		ErrorUtilities.VerifyThrowArgumentLength(commandLine, "commandLine");
		ExitType result = ExitType.Success;
		try
		{
			VerifyThrowSupportedOS();
			SetConsoleUI();
			ResetBuildState();
			string projectFile = null;
			string[] targets = new string[0];
			BuildPropertyGroup propertyBag = null;
			ILogger[] loggers = (ILogger[])(object)new ILogger[0];
			bool needToValidateProject = false;
			string schemaFile = null;
			if (ProcessCommandLineSwitches(GatherAllSwitches(commandLine), ref projectFile, ref targets, ref propertyBag, ref loggers, ref needToValidateProject, ref schemaFile))
			{
				if (!BuildProject(projectFile, targets, propertyBag, loggers, needToValidateProject, schemaFile))
				{
					return ExitType.BuildError;
				}
				return result;
			}
			return result;
		}
		catch (CommandLineSwitchException ex)
		{
			Console.WriteLine(ex.Message);
			Console.WriteLine();
			ShowHelpPrompt();
			return ExitType.SwitchError;
		}
		catch (InitializationException ex2)
		{
			Console.WriteLine(ex2.Message);
			return ExitType.InitializationError;
		}
		catch (LoggerException val)
		{
			LoggerException val2 = val;
			if (val2.get_ErrorCode() != null)
			{
				Console.WriteLine(ResourceUtilities.FormatResourceString("LoggerFailurePrefixNoErrorCode", val2.get_ErrorCode(), ((Exception)(object)val2).Message));
			}
			else
			{
				Console.WriteLine(ResourceUtilities.FormatResourceString("LoggerFailurePrefixWithErrorCode", ((Exception)(object)val2).Message));
			}
			if (((Exception)(object)val2).InnerException != null)
			{
				Console.WriteLine(((Exception)(object)val2).InnerException!.Message);
			}
			return ExitType.LoggerAbort;
		}
		catch (InternalLoggerException val3)
		{
			InternalLoggerException val4 = val3;
			Console.WriteLine("MSBUILD : error " + val4.get_ErrorCode() + ": " + ((Exception)(object)val4).Message);
			Console.WriteLine(((Exception)(object)val4).InnerException!.ToString());
			return ExitType.LoggerFailure;
		}
		catch
		{
			Console.WriteLine(AssemblyResources.GetString("FatalError"));
			throw;
		}
	}

	private static void ResetBuildState()
	{
		includedResponseFiles = new ArrayList();
		usingSwitchesFromAutoResponseFile = false;
	}

	private static bool BuildProject(string projectFile, string[] targets, BuildPropertyGroup propertyBag, ILogger[] loggers, bool needToValidateProject, string schemaFile)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		bool result = false;
		Engine val = new Engine(binPath);
		val.set_GlobalProperties(propertyBag);
		try
		{
			foreach (ILogger val2 in loggers)
			{
				val.RegisterLogger(val2);
			}
			Project val3 = val.CreateNewProject();
			val3.set_IsValidated(needToValidateProject);
			val3.set_SchemaFile(schemaFile);
			val3.Load(projectFile);
			result = val.BuildProject(val3, targets);
			return result;
		}
		catch (InvalidProjectFileException)
		{
			return result;
		}
		finally
		{
			val.UnregisterAllLoggers();
		}
	}

	private static void VerifyThrowSupportedOS()
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32S || Environment.OSVersion.Platform == PlatformID.Win32Windows || Environment.OSVersion.Platform == PlatformID.WinCE || (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major <= 4))
		{
			InitializationException.VerifyThrow(condition: false, "UnsupportedOS");
		}
	}

	internal static void SetConsoleUI()
	{
		Thread currentThread = Thread.CurrentThread;
		currentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		int codePage = Console.OutputEncoding.CodePage;
		if (codePage != 65001 && codePage != currentThread.CurrentUICulture.TextInfo.OEMCodePage && codePage != currentThread.CurrentUICulture.TextInfo.ANSICodePage)
		{
			currentThread.CurrentUICulture = new CultureInfo("en-US");
		}
	}

	private static CommandLineSwitches GatherAllSwitches(string commandLine)
	{
		ArrayList arrayList = QuotingUtilities.SplitUnquoted(commandLine);
		arrayList.RemoveAt(0);
		CommandLineSwitches commandLineSwitches = new CommandLineSwitches();
		GatherCommandLineSwitches(arrayList, commandLineSwitches);
		return GatherAutoResponseFileSwitches(commandLineSwitches);
	}

	private static void GatherCommandLineSwitches(ArrayList commandLineArgs, CommandLineSwitches commandLineSwitches)
	{
		foreach (string commandLineArg in commandLineArgs)
		{
			int doubleQuotesRemoved;
			string text2 = QuotingUtilities.Unquote(commandLineArg, out doubleQuotesRemoved);
			if (text2.Length <= 0)
			{
				continue;
			}
			if (text2.StartsWith("@", StringComparison.Ordinal))
			{
				GatherResponseFileSwitch(text2, commandLineSwitches);
				continue;
			}
			string switchName;
			string switchParameters;
			if (!text2.StartsWith("-", StringComparison.Ordinal) && !text2.StartsWith("/", StringComparison.Ordinal))
			{
				switchName = null;
				switchParameters = ":" + commandLineArg;
			}
			else
			{
				int num = text2.IndexOf(':');
				if (num == -1)
				{
					switchName = text2.Substring(1);
					switchParameters = string.Empty;
				}
				else
				{
					switchName = text2.Substring(1, num - 1);
					switchParameters = ExtractSwitchParameters(commandLineArg, text2, doubleQuotesRemoved, switchName, num);
				}
			}
			CommandLineSwitches.ParameterizedSwitch parameterizedSwitch;
			bool multipleParametersAllowed;
			string missingParametersErrorMessage;
			bool unquoteParameters;
			if (CommandLineSwitches.IsParameterlessSwitch(switchName, out var parameterlessSwitch, out var duplicateSwitchErrorMessage))
			{
				GatherParameterlessCommandLineSwitch(commandLineSwitches, parameterlessSwitch, switchParameters, duplicateSwitchErrorMessage, text2);
			}
			else if (CommandLineSwitches.IsParameterizedSwitch(switchName, out parameterizedSwitch, out duplicateSwitchErrorMessage, out multipleParametersAllowed, out missingParametersErrorMessage, out unquoteParameters))
			{
				GatherParameterizedCommandLineSwitch(commandLineSwitches, parameterizedSwitch, switchParameters, duplicateSwitchErrorMessage, multipleParametersAllowed, missingParametersErrorMessage, unquoteParameters, text2);
			}
			else
			{
				commandLineSwitches.SetUnknownSwitchError(text2);
			}
		}
	}

	internal static string ExtractSwitchParameters(string commandLineArg, string unquotedCommandLineArg, int doubleQuotesRemovedFromArg, string switchName, int switchParameterIndicator)
	{
		string text = null;
		int num = commandLineArg.IndexOf(':');
		int doubleQuotesRemoved;
		string text2 = QuotingUtilities.Unquote(commandLineArg.Substring(0, num), out doubleQuotesRemoved);
		ErrorUtilities.VerifyThrow(switchName == text2.Substring(1), "The switch name extracted from either the partially or completely unquoted arg should be the same.");
		ErrorUtilities.VerifyThrow(doubleQuotesRemovedFromArg >= doubleQuotesRemoved, "The name portion of the switch cannot contain more quoting than the arg itself.");
		if (doubleQuotesRemoved % 2 == 0)
		{
			text = commandLineArg.Substring(num);
		}
		else
		{
			int num2 = commandLineArg.IndexOf('"', num + 1);
			text = ((doubleQuotesRemovedFromArg - doubleQuotesRemoved > 1 || (num2 != -1 && num2 != commandLineArg.Length - 1)) ? (":\"" + commandLineArg.Substring(num + 1)) : unquotedCommandLineArg.Substring(switchParameterIndicator));
		}
		ErrorUtilities.VerifyThrow(text != null, "We must be able to extract the switch parameters.");
		return text;
	}

	private static void GatherResponseFileSwitch(string unquotedCommandLineArg, CommandLineSwitches commandLineSwitches)
	{
		try
		{
			string text = unquotedCommandLineArg.Substring(1);
			if (text.Length == 0)
			{
				commandLineSwitches.SetSwitchError("MissingResponseFileError", unquotedCommandLineArg);
				return;
			}
			if (!File.Exists(text))
			{
				commandLineSwitches.SetParameterError("ResponseFileNotFoundError", unquotedCommandLineArg);
				return;
			}
			text = Path.GetFullPath(text);
			bool flag = false;
			foreach (string includedResponseFile in includedResponseFiles)
			{
				if (string.Compare(text, includedResponseFile, StringComparison.OrdinalIgnoreCase) == 0)
				{
					commandLineSwitches.SetParameterError("RepeatedResponseFileError", unquotedCommandLineArg);
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return;
			}
			includedResponseFiles.Add(text);
			ArrayList arrayList;
			using (StreamReader streamReader = new StreamReader(text, Encoding.Default))
			{
				arrayList = new ArrayList();
				while (streamReader.Peek() != -1)
				{
					string text2 = streamReader.ReadLine()!.TrimStart(new char[0]);
					if (!text2.StartsWith("#", StringComparison.Ordinal))
					{
						arrayList.AddRange(QuotingUtilities.SplitUnquoted(Environment.ExpandEnvironmentVariables(text2)));
					}
				}
			}
			GatherCommandLineSwitches(arrayList, commandLineSwitches);
		}
		catch (NotSupportedException innerExceptionValue)
		{
			commandLineSwitches.SetParameterError("ReadResponseFileError", unquotedCommandLineArg, innerExceptionValue);
		}
		catch (SecurityException innerExceptionValue2)
		{
			commandLineSwitches.SetParameterError("ReadResponseFileError", unquotedCommandLineArg, innerExceptionValue2);
		}
		catch (UnauthorizedAccessException innerExceptionValue3)
		{
			commandLineSwitches.SetParameterError("ReadResponseFileError", unquotedCommandLineArg, innerExceptionValue3);
		}
		catch (IOException innerExceptionValue4)
		{
			commandLineSwitches.SetParameterError("ReadResponseFileError", unquotedCommandLineArg, innerExceptionValue4);
		}
	}

	private static void GatherParameterlessCommandLineSwitch(CommandLineSwitches commandLineSwitches, CommandLineSwitches.ParameterlessSwitch parameterlessSwitch, string switchParameters, string duplicateSwitchErrorMessage, string unquotedCommandLineArg)
	{
		if (switchParameters.Length == 0)
		{
			if (commandLineSwitches.IsParameterlessSwitchSet(parameterlessSwitch) && duplicateSwitchErrorMessage != null)
			{
				commandLineSwitches.SetSwitchError(duplicateSwitchErrorMessage, unquotedCommandLineArg);
			}
			else
			{
				commandLineSwitches.SetParameterlessSwitch(parameterlessSwitch, unquotedCommandLineArg);
			}
		}
		else
		{
			commandLineSwitches.SetUnexpectedParametersError(unquotedCommandLineArg);
		}
	}

	private static void GatherParameterizedCommandLineSwitch(CommandLineSwitches commandLineSwitches, CommandLineSwitches.ParameterizedSwitch parameterizedSwitch, string switchParameters, string duplicateSwitchErrorMessage, bool multipleParametersAllowed, string missingParametersErrorMessage, bool unquoteParameters, string unquotedCommandLineArg)
	{
		if (switchParameters.Length <= 1 && missingParametersErrorMessage != null)
		{
			commandLineSwitches.SetSwitchError(missingParametersErrorMessage, unquotedCommandLineArg);
			return;
		}
		if (commandLineSwitches.IsParameterizedSwitchSet(parameterizedSwitch) && duplicateSwitchErrorMessage != null)
		{
			commandLineSwitches.SetSwitchError(duplicateSwitchErrorMessage, unquotedCommandLineArg);
			return;
		}
		if (switchParameters.Length > 0)
		{
			switchParameters = switchParameters.Substring(1);
		}
		if (!commandLineSwitches.SetParameterizedSwitch(parameterizedSwitch, unquotedCommandLineArg, switchParameters, multipleParametersAllowed, unquoteParameters) && missingParametersErrorMessage != null)
		{
			commandLineSwitches.SetSwitchError(missingParametersErrorMessage, unquotedCommandLineArg);
		}
	}

	private static CommandLineSwitches GatherAutoResponseFileSwitches(CommandLineSwitches commandLineSwitches)
	{
		CommandLineSwitches commandLineSwitches2 = commandLineSwitches;
		if (!commandLineSwitches[CommandLineSwitches.ParameterlessSwitch.NoAutoResponse])
		{
			string text = Path.Combine(binPath, "MSBuild.rsp");
			if (File.Exists(text))
			{
				commandLineSwitches2 = new CommandLineSwitches();
				GatherResponseFileSwitch("@" + text, commandLineSwitches2);
				if (commandLineSwitches2[CommandLineSwitches.ParameterlessSwitch.NoAutoResponse])
				{
					commandLineSwitches2.SetSwitchError("CannotAutoDisableAutoResponseFile", commandLineSwitches2.GetParameterlessSwitchCommandLineArg(CommandLineSwitches.ParameterlessSwitch.NoAutoResponse));
				}
				if (commandLineSwitches2.HaveAnySwitchesBeenSet())
				{
					usingSwitchesFromAutoResponseFile = true;
				}
				commandLineSwitches2.Append(commandLineSwitches);
			}
		}
		return commandLineSwitches2;
	}

	private static bool ProcessCommandLineSwitches(CommandLineSwitches commandLineSwitches, ref string projectFile, ref string[] targets, ref BuildPropertyGroup propertyBag, ref ILogger[] loggers, ref bool needToValidateProject, ref string schemaFile)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between I4 and Unknown
		bool flag = false;
		if (!commandLineSwitches[CommandLineSwitches.ParameterlessSwitch.NoLogo])
		{
			DisplayCopyrightMessage();
		}
		if (commandLineSwitches[CommandLineSwitches.ParameterlessSwitch.Help])
		{
			ShowHelpMessage();
		}
		else
		{
			commandLineSwitches.ThrowErrors();
			if (commandLineSwitches[CommandLineSwitches.ParameterlessSwitch.Version])
			{
				ShowVersion();
			}
			else
			{
				projectFile = ProcessProjectSwitch(commandLineSwitches[CommandLineSwitches.ParameterizedSwitch.Project]);
				targets = ProcessTargetSwitch(commandLineSwitches[CommandLineSwitches.ParameterizedSwitch.Target]);
				propertyBag = ProcessPropertySwitch(commandLineSwitches[CommandLineSwitches.ParameterizedSwitch.Property]);
				loggers = ProcessLoggingSwitches(commandLineSwitches[CommandLineSwitches.ParameterizedSwitch.Logger], commandLineSwitches[CommandLineSwitches.ParameterizedSwitch.Verbosity], commandLineSwitches[CommandLineSwitches.ParameterlessSwitch.NoConsoleLogger], commandLineSwitches[CommandLineSwitches.ParameterizedSwitch.ConsoleLoggerParameters], out var verbosity);
				if (usingSwitchesFromAutoResponseFile && 4 == (int)verbosity)
				{
					Console.WriteLine(ResourceUtilities.FormatResourceString("PickedUpSwitchesFromAutoResponse", "MSBuild.rsp"));
				}
				needToValidateProject = commandLineSwitches.IsParameterizedSwitchSet(CommandLineSwitches.ParameterizedSwitch.Validate);
				schemaFile = ProcessValidateSwitch(commandLineSwitches[CommandLineSwitches.ParameterizedSwitch.Validate]);
				flag = true;
			}
		}
		ErrorUtilities.VerifyThrow(!flag || projectFile != null, "We should have a project file if we're going to build.");
		return flag;
	}

	private static string ProcessProjectSwitch(string[] parameters)
	{
		ErrorUtilities.VerifyThrow(parameters.Length <= 1, "It should not be possible to specify more than 1 project at a time.");
		string text = null;
		if (parameters.Length == 0)
		{
			string[] files = Directory.GetFiles(".", "*.*proj");
			string[] files2 = Directory.GetFiles(".", "*.sln");
			if (files.Length == 1 && files2.Length == 1)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files2[0]);
				string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(files[0]);
				InitializationException.VerifyThrow(string.Compare(fileNameWithoutExtension, fileNameWithoutExtension2, StringComparison.OrdinalIgnoreCase) == 0, "AmbiguousProjectError");
			}
			else if (files2.Length <= 1 && files.Length <= 1)
			{
				if (files.Length == 0 && files2.Length == 0)
				{
					InitializationException.VerifyThrow(condition: false, "MissingProjectError");
				}
			}
			else
			{
				InitializationException.VerifyThrow(condition: false, "AmbiguousProjectError");
			}
			return (files2.Length == 1) ? files2[0] : files[0];
		}
		InitializationException.VerifyThrow(File.Exists(parameters[0]), "ProjectNotFoundError", parameters[0]);
		return parameters[0];
	}

	private static string[] ProcessTargetSwitch(string[] parameters)
	{
		return parameters;
	}

	internal static BuildPropertyGroup ProcessPropertySwitch(string[] parameters)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		BuildPropertyGroup val = new BuildPropertyGroup();
		foreach (string text in parameters)
		{
			string[] array = text.Split(propertyValueSeparator, 2);
			CommandLineSwitchException.VerifyThrow(array[0].Length > 0 && array.Length == 2, "InvalidPropertyError", text);
			try
			{
				val.SetProperty(array[0], array[1]);
			}
			catch (ArgumentException e)
			{
				InitializationException.Throw("InvalidPropertyError", text, e, showStackTrace: false);
			}
			catch (InvalidOperationException ex)
			{
				InitializationException.Throw(ex.Message, text);
			}
		}
		return val;
	}

	private static ILogger[] ProcessLoggingSwitches(string[] loggerSwitchParameters, string[] verbositySwitchParameters, bool noConsoleLogger, string[] consoleLoggerParameters, out LoggerVerbosity verbosity)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I4, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		verbosity = (LoggerVerbosity)(int)ProcessVerbositySwitch(verbositySwitchParameters);
		ArrayList arrayList = ProcessLoggerSwitch(loggerSwitchParameters, verbosity);
		if (!noConsoleLogger)
		{
			ConsoleLogger val = new ConsoleLogger(verbosity);
			if (consoleLoggerParameters != null && consoleLoggerParameters.Length > 0)
			{
				val.set_Parameters(consoleLoggerParameters[^1]);
			}
			arrayList.Add(val);
		}
		return (ILogger[])arrayList.ToArray(typeof(ILogger));
	}

	private static LoggerVerbosity ProcessVerbositySwitch(string[] parameters)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		LoggerVerbosity result = (LoggerVerbosity)2;
		if (parameters.Length > 0)
		{
			try
			{
				result = (LoggerVerbosity)Enum.Parse(typeof(LoggerVerbosity), parameters[^1], ignoreCase: true);
				return result;
			}
			catch (ArgumentException)
			{
				if (string.Compare(parameters[^1], "q", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return (LoggerVerbosity)0;
				}
				if (string.Compare(parameters[^1], "m", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return (LoggerVerbosity)1;
				}
				if (string.Compare(parameters[^1], "n", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return (LoggerVerbosity)2;
				}
				if (string.Compare(parameters[^1], "d", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return (LoggerVerbosity)3;
				}
				if (string.Compare(parameters[^1], "diag", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return (LoggerVerbosity)4;
				}
				CommandLineSwitchException.Throw("InvalidVerbosityError", parameters[^1]);
				return result;
			}
		}
		return result;
	}

	private static ArrayList ProcessLoggerSwitch(string[] parameters, LoggerVerbosity verbosity)
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		foreach (string input in parameters)
		{
			string text = QuotingUtilities.Unquote(input);
			int emptySplits;
			ArrayList arrayList2 = QuotingUtilities.SplitUnquoted(input, 2, true, false, out emptySplits, ';');
			ErrorUtilities.VerifyThrow(arrayList2.Count >= 1 && arrayList2.Count <= 2, "SplitUnquoted() must return at least one string, and no more than two.");
			CommandLineSwitchException.VerifyThrow(((string)arrayList2[0]).Length > 0, "InvalidLoggerError", text);
			ArrayList arrayList3 = QuotingUtilities.SplitUnquoted((string)arrayList2[0], 2, true, false, out emptySplits, ',');
			ErrorUtilities.VerifyThrow(arrayList3.Count >= 1 && arrayList3.Count <= 2, "SplitUnquoted() must return at least one string, and no more than two.");
			string loggerClassName;
			string text2;
			if (arrayList3.Count == 2)
			{
				loggerClassName = QuotingUtilities.Unquote((string)arrayList3[0]);
				text2 = QuotingUtilities.Unquote((string)arrayList3[1]);
			}
			else
			{
				loggerClassName = string.Empty;
				text2 = QuotingUtilities.Unquote((string)arrayList3[0]);
			}
			CommandLineSwitchException.VerifyThrow(text2.Length > 0, "InvalidLoggerError", text);
			string assemblyName = null;
			string assemblyFile = null;
			if (File.Exists(text2))
			{
				assemblyFile = text2;
			}
			else
			{
				assemblyName = text2;
			}
			AssemblyLoadInfo loggerAssembly = new AssemblyLoadInfo(assemblyName, assemblyFile);
			ILogger val = CreateLogger(loggerClassName, loggerAssembly, text);
			try
			{
				val.set_Verbosity(verbosity);
				if (arrayList2.Count == 2)
				{
					val.set_Parameters(QuotingUtilities.Unquote((string)arrayList2[1]));
				}
			}
			catch (LoggerException)
			{
				throw;
			}
			catch (Exception e)
			{
				InitializationException.Throw("LoggerFatalError", text, e, showStackTrace: true);
			}
			arrayList.Add(val);
		}
		return arrayList;
	}

	private static ILogger CreateLogger(string loggerClassName, AssemblyLoadInfo loggerAssembly, string loggerSwitchParameters)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		ILogger result = null;
		try
		{
			LoadedType loadedType = new TypeLoader(loggerClassFilter).Load(loggerClassName, loggerAssembly);
			InitializationException.VerifyThrow(loadedType != null, "LoggerNotFoundError", loggerSwitchParameters);
			result = (ILogger)Activator.CreateInstance(loadedType.Type);
			return result;
		}
		catch (IOException e)
		{
			InitializationException.Throw("LoggerCreationError", loggerSwitchParameters, e, showStackTrace: false);
			return result;
		}
		catch (BadImageFormatException e2)
		{
			InitializationException.Throw("LoggerCreationError", loggerSwitchParameters, e2, showStackTrace: false);
			return result;
		}
		catch (SecurityException e3)
		{
			InitializationException.Throw("LoggerCreationError", loggerSwitchParameters, e3, showStackTrace: false);
			return result;
		}
		catch (ReflectionTypeLoadException e4)
		{
			InitializationException.Throw("LoggerCreationError", loggerSwitchParameters, e4, showStackTrace: false);
			return result;
		}
		catch (TargetInvocationException ex)
		{
			Exception innerException = ex.InnerException;
			if (innerException is LoggerException)
			{
				throw innerException;
			}
			InitializationException.Throw("LoggerFatalError", loggerSwitchParameters, innerException, showStackTrace: true);
			return result;
		}
		catch (MemberAccessException e5)
		{
			InitializationException.Throw("LoggerCreationError", loggerSwitchParameters, e5, showStackTrace: false);
			return result;
		}
	}

	private static bool IsLoggerClass(Type type, object unused)
	{
		if (type.IsClass && !type.IsAbstract)
		{
			return (object)type.GetInterface("ILogger") != null;
		}
		return false;
	}

	private static string ProcessValidateSwitch(string[] parameters)
	{
		string text = null;
		foreach (string text2 in parameters)
		{
			InitializationException.VerifyThrow(text == null, "MultipleSchemasError", text2);
			InitializationException.VerifyThrow(File.Exists(text2), "SchemaNotFoundError", text2);
			text = Path.Combine(Directory.GetCurrentDirectory(), text2);
		}
		return text;
	}

	private static void DisplayCopyrightMessage()
	{
		Console.WriteLine(ResourceUtilities.FormatResourceString("CopyrightMessage", Engine.get_Version().ToString(), Environment.Version.ToString()));
	}

	private static void ShowHelpMessage()
	{
		Console.WriteLine(AssemblyResources.GetString("HelpMessage"));
	}

	private static void ShowHelpPrompt()
	{
		Console.WriteLine(AssemblyResources.GetString("HelpPrompt"));
	}

	private static void ShowVersion()
	{
		Console.Write(Engine.get_Version().ToString());
	}
}
