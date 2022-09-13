using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.ComChannel;
using Microsoft.VisualStudio.Tools.Applications.Contract;

namespace Microsoft.VisualStudio.Tools.Applications.ExternalProcess;

public sealed class Application
{
	private enum ExecutionType
	{
		ExternalExecution,
		AltF11,
		NDD
	}

	private static class Arguments
	{
		public static string ProcessUri = "/processUri";

		public static string ProcReadyEvent = "/procReadyEvent";

		public static string AddInPath = "/addInPath";

		public static string HostCommand = "/hostCommand";

		public static string HostCommandArguments = "/hostCommandArguments";

		public static string HostDebugUri = "/hostDebugUri";
	}

	private string processUriName;

	private Uri processUri;

	private string procReadyEvent;

	private string addInPath;

	private string hostCommand;

	private string hostCommandArguments;

	private string hostDebugUri;

	private AddInProcessInternal addInProcessInternal;

	private ExecutionType Scenario
	{
		get
		{
			if (processUriName != null && processUriName.Length > 0)
			{
				return ExecutionType.ExternalExecution;
			}
			if (hostCommand != null && hostCommand.Length > 0)
			{
				return ExecutionType.NDD;
			}
			return ExecutionType.AltF11;
		}
	}

	[STAThread]
	public static void Main(string[] args)
	{
		Application application = new Application();
		application.Run(args);
	}

	private Application()
	{
		processUriName = "";
		procReadyEvent = "";
		addInPath = "";
		hostCommand = "";
		hostCommandArguments = "";
		hostDebugUri = "";
	}

	private void Run(string[] args)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		try
		{
			ProcessArguments(args);
			InitializeRemotingChannel();
			switch (Scenario)
			{
			default:
				throw new Exception();
			case ExecutionType.ExternalExecution:
			{
				EventWaitHandle eventWaitHandle2 = new EventWaitHandle(initialState: false, EventResetMode.ManualReset, procReadyEvent);
				addInProcessInternal = CreateAddInProcessInternal();
				string pathAndQuery = processUri.PathAndQuery;
				pathAndQuery = pathAndQuery.Substring(1);
				RemotingServices.Marshal((MarshalByRefObject)(object)addInProcessInternal, pathAndQuery);
				eventWaitHandle2.Set();
				break;
			}
			case ExecutionType.AltF11:
			{
				addInProcessInternal = CreateAddInProcessInternal();
				IExternalDebugListenerContract val2 = (IExternalDebugListenerContract)Activator.GetObject(typeof(IExternalDebugListenerContract), hostDebugUri);
				val2.OnDebugStarting(addInPath, (IRemoteAddInProcessInternalContract)(object)addInProcessInternal, Process.GetCurrentProcess().Id);
				break;
			}
			case ExecutionType.NDD:
			{
				string text = CreateHostReadyEventName();
				hostDebugUri = CreateHostUri();
				string fullHostParameters = GetFullHostParameters(text, hostDebugUri);
				EventWaitHandle eventWaitHandle = new EventWaitHandle(initialState: false, EventResetMode.ManualReset, text);
				Process.Start(hostCommand, fullHostParameters);
				eventWaitHandle.WaitOne();
				IExternalDebugListenerContract val = (IExternalDebugListenerContract)Activator.GetObject(typeof(IExternalDebugListenerContract), hostDebugUri);
				addInProcessInternal = CreateAddInProcessInternal();
				val.OnDebugStarting(addInPath, (IRemoteAddInProcessInternalContract)(object)addInProcessInternal, Process.GetCurrentProcess().Id);
				break;
			}
			}
			Application.Run();
		}
		catch
		{
			if (Scenario != 0)
			{
				PrintError();
			}
		}
	}

	private void InitializeRemotingChannel()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (processUri == null)
		{
			processUri = new Uri(CreateHostUri());
		}
		string host = processUri.Host;
		BinaryServerFormatterSinkProvider val = new BinaryServerFormatterSinkProvider();
		val.set_TypeFilterLevel(TypeFilterLevel.Full);
		IDictionary dictionary = new Hashtable();
		dictionary["name"] = host;
		dictionary["portName"] = host;
		BinaryClientFormatterSinkProvider val2 = new BinaryClientFormatterSinkProvider();
		ComChannel val3 = new ComChannel(dictionary, (IClientChannelSinkProvider)(object)val2, (IServerChannelSinkProvider)(object)val);
		ChannelServices.RegisterChannel((IChannel)(object)val3, false);
	}

	private string CreateHostReadyEventName()
	{
		return "vstaHostReadyEvent" + Guid.NewGuid();
	}

	private string CreateHostUri()
	{
		string text = "com://vstadebug";
		text += Guid.NewGuid();
		return text + "/" + Guid.NewGuid();
	}

	private string GetFullHostParameters(string hostReadyEventName, string hostUri)
	{
		string text = hostCommandArguments;
		text = text + " /vstaHostDebugReady:" + hostReadyEventName;
		return text + " /vstaHostDebugUri:" + hostUri;
	}

	private AddInProcessInternal CreateAddInProcessInternal()
	{
		object? obj = Activator.CreateInstance(typeof(AddInProcessInternal), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[1] { Thread.CurrentThread }, CultureInfo.InvariantCulture);
		return (AddInProcessInternal)((obj is AddInProcessInternal) ? obj : null);
	}

	private void ProcessArguments(string[] args)
	{
		if (args.Length == 0)
		{
			throw new ArgumentException();
		}
		foreach (string arg in args)
		{
			if (hostCommandArguments != "")
			{
				break;
			}
			ProcessArgument(arg);
		}
		VerifyArgumentSet();
	}

	private void ProcessArgument(string arg)
	{
		string argumentName = GetArgumentName(arg);
		if (EqualArg(argumentName, Arguments.ProcessUri))
		{
			string argumentValue = GetArgumentValue(arg);
			if (!(argumentValue == "") && !(processUri != null))
			{
				processUriName = argumentValue;
				processUri = new Uri(processUriName);
				return;
			}
			throw new ArgumentException();
		}
		if (EqualArg(argumentName, Arguments.ProcReadyEvent))
		{
			string argumentValue2 = GetArgumentValue(arg);
			if (!(argumentValue2 == "") && !(procReadyEvent != ""))
			{
				procReadyEvent = argumentValue2;
				return;
			}
			throw new ArgumentException();
		}
		if (EqualArg(argumentName, Arguments.AddInPath))
		{
			string argumentValue3 = GetArgumentValue(arg);
			if (!(argumentValue3 == "") && !(addInPath != ""))
			{
				addInPath = argumentValue3;
				return;
			}
			throw new ArgumentException();
		}
		if (EqualArg(argumentName, Arguments.HostCommand))
		{
			string argumentValue4 = GetArgumentValue(arg);
			if (!(argumentValue4 == "") && !(hostCommand != ""))
			{
				hostCommand = argumentValue4;
				return;
			}
			throw new ArgumentException();
		}
		if (EqualArg(argumentName, Arguments.HostDebugUri))
		{
			string argumentValue5 = GetArgumentValue(arg);
			if (!(argumentValue5 == "") && !(hostDebugUri != ""))
			{
				hostDebugUri = argumentValue5;
				return;
			}
			throw new ArgumentException();
		}
		if (EqualArg(argumentName, Arguments.HostCommandArguments))
		{
			if (hostCommandArguments != "")
			{
				throw new ArgumentException();
			}
			hostCommandArguments = GetHostCommandArgumentsWithQuotes();
			return;
		}
		throw new Exception();
	}

	private void VerifyArgumentSet()
	{
		switch (Scenario)
		{
		default:
			throw new Exception();
		case ExecutionType.ExternalExecution:
			try
			{
				VerifyArgumentNotEmpty(processUriName);
				VerifyArgumentNotEmpty(procReadyEvent);
				VerifyArgumentEmpty(addInPath);
				VerifyArgumentEmpty(hostCommand);
				VerifyArgumentEmpty(hostCommandArguments);
				VerifyArgumentEmpty(hostDebugUri);
				break;
			}
			catch
			{
				throw;
			}
		case ExecutionType.AltF11:
			try
			{
				VerifyArgumentEmpty(processUriName);
				VerifyArgumentEmpty(procReadyEvent);
				VerifyArgumentEmpty(hostCommand);
				VerifyArgumentEmpty(hostCommandArguments);
				VerifyArgumentNotEmpty(hostDebugUri);
				break;
			}
			catch
			{
				throw;
			}
		case ExecutionType.NDD:
			try
			{
				VerifyArgumentEmpty(processUriName);
				VerifyArgumentEmpty(procReadyEvent);
				VerifyArgumentNotEmpty(hostCommand);
				VerifyArgumentEmpty(hostDebugUri);
				break;
			}
			catch
			{
				throw;
			}
		}
	}

	private void VerifyArgumentEmpty(string arg)
	{
		if (arg != null && arg != "")
		{
			throw new Exception();
		}
	}

	private void VerifyArgumentNotEmpty(string arg)
	{
		if (arg == null || arg == "")
		{
			throw new Exception();
		}
	}

	private static void PrintError()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		string @string = StringResources.GetString("ErrorCaption");
		string string2 = StringResources.GetString("ErrorString");
		MessageBox.Show(string2, @string);
	}

	private string GetArgumentName(string arg)
	{
		return arg[..arg.IndexOf(":")];
	}

	private string GetArgumentValue(string arg)
	{
		int num = arg.IndexOf(":");
		return arg.Substring(num + 1);
	}

	private bool EqualArg(string str1, string str2)
	{
		return string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase) == 0;
	}

	private string GetHostCommandArgumentsWithQuotes()
	{
		string commandLine = Environment.CommandLine;
		int num = commandLine.IndexOf(Arguments.HostCommandArguments);
		if (num == -1)
		{
			throw new Exception();
		}
		int num2 = commandLine.IndexOf(":", num);
		if (num2 == -1)
		{
			throw new Exception();
		}
		return commandLine.Substring(num2 + 1);
	}
}
