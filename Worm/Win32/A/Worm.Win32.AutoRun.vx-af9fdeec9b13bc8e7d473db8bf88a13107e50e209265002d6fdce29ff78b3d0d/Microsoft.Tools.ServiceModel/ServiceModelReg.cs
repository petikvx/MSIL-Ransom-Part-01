using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.ServiceModel.Install;
using System.ServiceModel.Install.Configuration;
using System.Text;
using System.Threading;

namespace Microsoft.Tools.ServiceModel;

internal class ServiceModelReg
{
	private const string MutexName = "ServiceModelReg_f685339e-b522-4d07-8921-1d75962f1905";

	private static Mutex SingleInstance;

	private static bool passedLocalSecurityChecks;

	private string[] protocols = new string[4] { "net.tcp", "net.pipe", "net.msmq", "msmq.formatname" };

	private CommandArguments commandArguments;

	static ServiceModelReg()
	{
		passedLocalSecurityChecks = InitializeSecurity();
	}

	private static bool InitializeSecurity()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		bool flag = false;
		try
		{
			AppDomain domain = Thread.GetDomain();
			domain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
			((PermissionSet)new NamedPermissionSet("FullTrust")).Demand();
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, null);
			foreach (IdentityReference item in WindowsIdentity.GetCurrent().Groups!)
			{
				if (securityIdentifier.Value.Equals(item.Value, StringComparison.Ordinal))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				LogError(SR.GetString("AccessDeniedLocalAdmin"));
				return flag;
			}
			return flag;
		}
		catch (SecurityException)
		{
			LogError(SR.GetString("AccessDeniedFullTrust"));
			return flag;
		}
	}

	private Queue<ActionItem> BuildActionQueue()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between I4 and Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Invalid comparison between I4 and Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Invalid comparison between I4 and Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Invalid comparison between I4 and Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Invalid comparison between I4 and Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Invalid comparison between I4 and Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Invalid comparison between I4 and Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Invalid comparison between I4 and Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Invalid comparison between I4 and Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Invalid comparison between I4 and Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		Queue<ActionItem> queue = new Queue<ActionItem>();
		if (commandArguments.ApplyToConfig)
		{
			if (InstallHelper.Is64BitMachine() && !string.IsNullOrEmpty(InstallHelper.get_Wow64MachineConfigFileName()))
			{
				if (File.Exists(InstallHelper.get_Wow64MachineConfigFileName()))
				{
					queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)ConfigurationHandlersInstallComponent.CreateWow64ConfigurationHandlersInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
				}
				else
				{
					EventLogger.LogWarning(SR.GetString("Wow64NotInstalled", SR.GetString("CommunicationSectionNameWow64")), 2 == (int)commandArguments.OutputLevel);
				}
			}
			queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)ConfigurationHandlersInstallComponent.CreateNativeConfigurationHandlersInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
			if (InstallHelper.Is64BitMachine() && !string.IsNullOrEmpty(InstallHelper.get_Wow64WebConfigFileName()))
			{
				if (File.Exists(InstallHelper.get_Wow64WebConfigFileName()))
				{
					queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)BuildProviderInstallComponent.CreateWow64BuildProviderInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
					queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)CompilationAssemblyInstallComponent.CreateWow64CompilationAssemblyInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
					queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)HttpHandlersInstallComponent.CreateWow64HttpHandlersInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
					queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)HttpModulesInstallComponent.CreateWow64HttpModulesInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
				}
				else
				{
					EventLogger.LogWarning(SR.GetString("Wow64NotInstalled", SR.GetString("BuildProviderNameWow64")), 2 == (int)commandArguments.OutputLevel);
					EventLogger.LogWarning(SR.GetString("Wow64NotInstalled", SR.GetString("CompilationAssemblyNameWow64")), 2 == (int)commandArguments.OutputLevel);
					EventLogger.LogWarning(SR.GetString("Wow64NotInstalled", SR.GetString("HttpHandlersComponentNameWow64")), 2 == (int)commandArguments.OutputLevel);
					EventLogger.LogWarning(SR.GetString("Wow64NotInstalled", SR.GetString("HttpModulesComponentNameWow64")), 2 == (int)commandArguments.OutputLevel);
				}
			}
			queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)BuildProviderInstallComponent.CreateNativeBuildProviderInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
			queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)CompilationAssemblyInstallComponent.CreateNativeCompilationAssemblyInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
			queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)HttpHandlersInstallComponent.CreateNativeHttpHandlersInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
			queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)HttpModulesInstallComponent.CreateNativeHttpModulesInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
			if (IisHelper.get_ShouldInstallWas())
			{
				BuildActionQueueIis7(queue);
			}
			else if (commandArguments.ApplyToConfig && 1 != (int)commandArguments.InstallAction && OSEnvironmentHelper.get_IsVistaOrGreater())
			{
				string[] array = protocols;
				foreach (string text in array)
				{
					if (InstallHelper.Is64BitMachine() && !string.IsNullOrEmpty(InstallHelper.get_Wow64WebConfigFileName()) && File.Exists(InstallHelper.get_Wow64WebConfigFileName()))
					{
						queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)ProtocolsInstallComponent.CreateWow64ProtocolsInstallComponent(text), (InstallAction)2, commandArguments.OutputLevel));
						queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)TransportConfigurationTypeInstallComponent.CreateWow64TransportConfigurationTypeInstallComponent(text), (InstallAction)2, commandArguments.OutputLevel));
					}
					queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)ProtocolsInstallComponent.CreateNativeProtocolsInstallComponent(text), (InstallAction)2, commandArguments.OutputLevel));
					queue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)TransportConfigurationTypeInstallComponent.CreateNativeTransportConfigurationTypeInstallComponent(text), (InstallAction)2, commandArguments.OutputLevel));
				}
			}
		}
		if (commandArguments.ApplyToScriptMaps)
		{
			if (!IisHelper.get_ShouldInstallWas())
			{
				if (IisHelper.get_ShouldInstallIis() && IisHelper.get_ShouldEnableIISAdmin())
				{
					queue.Enqueue(new ActionItem((ServiceModelInstallComponent)new WebHostScriptMappingsInstallComponent(commandArguments.ScriptMapPath, commandArguments.Recursive, commandArguments.UpdateScriptMaps), commandArguments.InstallAction, commandArguments.OutputLevel));
				}
				else if (!IisHelper.get_ShouldInstallIis())
				{
					EventLogger.LogWarning(SR.GetString("IisNotInstalled", SR.GetString("WebHostScriptMappingsName")), 2 == (int)commandArguments.OutputLevel);
				}
				else
				{
					EventLogger.LogWarning(SR.GetString("IISAdminNotEnabled", SR.GetString("WebHostScriptMappingsName")), 2 == (int)commandArguments.OutputLevel);
				}
			}
			else
			{
				EventLogger.LogWarning(SR.GetString("ServiceModelRegScriptMapsNotSupported"), 2 == (int)commandArguments.OutputLevel);
			}
		}
		if (commandArguments.RunInstallScript)
		{
			queue.Enqueue(new ActionItem((ServiceModelInstallComponent)new WmiInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
			queue.Enqueue(new ActionItem((ServiceModelInstallComponent)new InfoCardServiceInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
			queue.Enqueue(new ActionItem(ListenerServiceInstallComponent.CreateTcpPortSharingServiceInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
			if (OSEnvironmentHelper.get_IsVistaOrGreater())
			{
				InstallAction? val = null;
				if (IisHelper.get_ShouldInstallWas())
				{
					val = commandArguments.InstallAction;
				}
				else if (1 != (int)commandArguments.InstallAction)
				{
					val = (InstallAction)2;
				}
				if (val.HasValue)
				{
					queue.Enqueue(new ActionItem(ListenerServiceInstallComponent.CreateTcpActivationServiceInstallComponent(), val.Value, commandArguments.OutputLevel));
					queue.Enqueue(new ActionItem(ListenerServiceInstallComponent.CreateNamedPipeActivationServiceInstallComponent(), val.Value, commandArguments.OutputLevel));
					queue.Enqueue(new ActionItem(ListenerServiceInstallComponent.CreateMsmqActivationServiceInstallComponent(), val.Value, commandArguments.OutputLevel));
				}
			}
			queue.Enqueue(new ActionItem((ServiceModelInstallComponent)new HttpNamespaceReservationInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
		}
		return queue;
	}

	private void BuildActionQueueIis7(Queue<ActionItem> actionQueue)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between I4 and Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between I4 and Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between I4 and Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Invalid comparison between I4 and Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Invalid comparison between I4 and Unknown
		string[] array = protocols;
		foreach (string text in array)
		{
			if (InstallHelper.Is64BitMachine() && !string.IsNullOrEmpty(InstallHelper.get_Wow64WebConfigFileName()))
			{
				if (File.Exists(InstallHelper.get_Wow64WebConfigFileName()))
				{
					actionQueue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)ProtocolsInstallComponent.CreateWow64ProtocolsInstallComponent(text), commandArguments.InstallAction, commandArguments.OutputLevel));
					actionQueue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)TransportConfigurationTypeInstallComponent.CreateWow64TransportConfigurationTypeInstallComponent(text), commandArguments.InstallAction, commandArguments.OutputLevel));
				}
				else
				{
					EventLogger.LogWarning(SR.GetString("Wow64NotInstalled", SR.GetString("ProtocolsNameWow64", new object[1] { text })), 2 == (int)commandArguments.OutputLevel);
					EventLogger.LogWarning(SR.GetString("Wow64NotInstalled", SR.GetString("TransportConfigurationNameWow64", new object[1] { text })), 2 == (int)commandArguments.OutputLevel);
				}
			}
			if (IisHelper.get_ShouldInstallApplicationHost())
			{
				actionQueue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)ListenerAdaptersInstallComponent.CreateNativeListenerAdaptersInstallComponent(text), commandArguments.InstallAction, commandArguments.OutputLevel));
			}
			else
			{
				EventLogger.LogWarning(SR.GetString("ApplicationHostConfigNotInstalled", SR.GetString("ListenerAdaptersName", new object[1] { text })), 2 == (int)commandArguments.OutputLevel);
			}
			actionQueue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)ProtocolsInstallComponent.CreateNativeProtocolsInstallComponent(text), commandArguments.InstallAction, commandArguments.OutputLevel));
			actionQueue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)TransportConfigurationTypeInstallComponent.CreateNativeTransportConfigurationTypeInstallComponent(text), commandArguments.InstallAction, commandArguments.OutputLevel));
		}
		if (IisHelper.get_ShouldInstallIis())
		{
			if (IisHelper.get_ShouldInstallApplicationHost())
			{
				actionQueue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)WasHttpModulesInstallComponent.CreateNativeWasHttpModulesInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
				actionQueue.Enqueue(new ActionItem((ServiceModelInstallComponent)(object)WasHttpHandlersInstallComponent.CreateNativeWasHttpHandlersInstallComponent(), commandArguments.InstallAction, commandArguments.OutputLevel));
				return;
			}
			EventLogger.LogWarning(SR.GetString("ApplicationHostConfigNotInstalled", SR.GetString("HttpModulesComponentNameWAS")), 2 == (int)commandArguments.OutputLevel);
			EventLogger.LogWarning(SR.GetString("ApplicationHostConfigNotInstalled", SR.GetString("HttpHandlersComponentNameWAS")), 2 == (int)commandArguments.OutputLevel);
		}
	}

	private void DisplayLogo()
	{
		Console.WriteLine(SR.GetString("HelpLogo", CommonResStrings.WcfTrademarkForCmdLine, "3.0.4506.648", CommonResStrings.CopyrightForCmdLine));
	}

	private static void LogException(Exception e)
	{
		if (passedLocalSecurityChecks)
		{
			InstallHelperLogException(e);
			return;
		}
		Console.WriteLine();
		Console.WriteLine(string.Format(CultureInfo.CurrentUICulture, SR.GetString("Error", e.Message)));
	}

	private static void LogError(string message)
	{
		if (passedLocalSecurityChecks)
		{
			InstallHelperLogError(message);
			return;
		}
		Console.WriteLine();
		Console.WriteLine(string.Format(CultureInfo.CurrentUICulture, message));
	}

	private static void InstallHelperLogException(Exception e)
	{
		EventLogger.LogException(e);
	}

	private static void InstallHelperLogError(string message)
	{
		EventLogger.LogError(message);
	}

	private static int Main(string[] args)
	{
		Environment.ExitCode = 575;
		ValidateUICulture();
		if (!passedLocalSecurityChecks)
		{
			Environment.ExitCode = 5;
		}
		else
		{
			Environment.ExitCode = TryRun(args);
		}
		return Environment.ExitCode;
	}

	private static int TryRun(string[] args)
	{
		try
		{
			using (SingleInstance = new Mutex(initiallyOwned: false, "ServiceModelReg_f685339e-b522-4d07-8921-1d75962f1905"))
			{
				if (SingleInstance.WaitOne(1, exitContext: true))
				{
					Environment.ExitCode = 574;
					ServiceModelReg serviceModelReg = new ServiceModelReg();
					Environment.ExitCode = serviceModelReg.Run(args);
				}
				else
				{
					Console.WriteLine(SR.GetString("ServiceModelRegMultipleInstanceError"));
				}
			}
		}
		catch (SecurityException)
		{
			Environment.ExitCode = 5;
		}
		catch (Exception ex2)
		{
			LogException(ex2);
			if (ex2 is Win32Exception)
			{
				Win32Exception ex3 = (Win32Exception)ex2;
				Environment.ExitCode = ex3.NativeErrorCode;
			}
			else if (ex2.InnerException != null && ex2.InnerException is Win32Exception)
			{
				Win32Exception ex4 = (Win32Exception)ex2.InnerException;
				Environment.ExitCode = ex4.NativeErrorCode;
			}
			else
			{
				Environment.ExitCode = 574;
			}
		}
		EventLogger.TerminateMsiStyleLogging();
		return Environment.ExitCode;
	}

	private int Run(string[] args)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between I4 and Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between I4 and Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between I4 and Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between I4 and Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Invalid comparison between I4 and Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between I4 and Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Invalid comparison between Unknown and I4
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Invalid comparison between I4 and Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Invalid comparison between I4 and Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Invalid comparison between I4 and Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Invalid comparison between I4 and Unknown
		try
		{
			commandArguments = new CommandArguments(args);
		}
		catch (ApplicationException e)
		{
			DisplayLogo();
			LogException(e);
			Console.WriteLine();
			CommandArguments.DisplayUsage();
			return 575;
		}
		if (commandArguments.RunInstallScript)
		{
			EventLogger.InitializeMsiStyleLogging();
		}
		if (commandArguments.DisplayLogo || commandArguments.DisplayHelp)
		{
			DisplayLogo();
		}
		if (commandArguments.DisplayHelp)
		{
			CommandArguments.DisplayUsage();
			return 0;
		}
		Queue<ActionItem> queue = BuildActionQueue();
		if (queue.Count == 0)
		{
			throw new ApplicationException(SR.GetString("ServiceModelRegNoValidOptionsError"));
		}
		if (1 == (int)commandArguments.InstallAction || 2 == (int)commandArguments.InstallAction || 3 == (int)commandArguments.InstallAction)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder = stringBuilder.Append(SR.GetString("EventLogMessageStart"));
			foreach (ActionItem item in queue)
			{
				stringBuilder = stringBuilder.Append(item.Component.GetActionString(item.Action) + "\n");
			}
			EventLogger.LogInformation(stringBuilder.ToString(), 2 == (int)commandArguments.OutputLevel);
		}
		bool? confirmUninstall = null;
		if (2 == (int)commandArguments.InstallAction || 3 == (int)commandArguments.InstallAction)
		{
			if (commandArguments.RequireConfirmation)
			{
				while (!confirmUninstall.HasValue)
				{
					Console.WriteLine();
					Console.WriteLine(SR.GetString("RequestConfirmation"));
					foreach (ActionItem item2 in queue)
					{
						Console.WriteLine("\t" + item2.Component.get_DisplayName());
					}
					Console.Write(SR.GetString("AreYouSure"));
					string text = Console.ReadLine()!.Trim();
					if (text.Equals(SR.GetString("Yes"), StringComparison.OrdinalIgnoreCase))
					{
						confirmUninstall = true;
					}
					else if (text.Equals(SR.GetString("No"), StringComparison.OrdinalIgnoreCase))
					{
						confirmUninstall = false;
					}
				}
			}
			else
			{
				confirmUninstall = true;
			}
		}
		bool flag = commandArguments.RunInstallScript && (int)commandArguments.InstallAction == 2;
		Exception ex = null;
		while (0 < queue.Count)
		{
			ActionItem actionItem = queue.Dequeue();
			try
			{
				PerformAction(actionItem, confirmUninstall);
			}
			catch (Exception ex2)
			{
				if (IsFatal(ex2))
				{
					throw;
				}
				if (!flag)
				{
					throw;
				}
				LogException(ex2);
				ex = ex2;
			}
		}
		if (ex != null)
		{
			throw ex;
		}
		if (1 == (int)commandArguments.InstallAction || 2 == (int)commandArguments.InstallAction || 3 == (int)commandArguments.InstallAction)
		{
			EventLogger.LogInformation(SR.GetString("EventLogMessageSuccess"), 2 == (int)commandArguments.OutputLevel);
		}
		return 0;
	}

	private static bool IsFatal(Exception exception)
	{
		while (true)
		{
			if (exception != null)
			{
				if ((exception is OutOfMemoryException && !(exception is InsufficientMemoryException)) || exception is ThreadAbortException || exception is AccessViolationException || exception is SEHException)
				{
					break;
				}
				if (exception is TypeInitializationException || exception is TargetInvocationException)
				{
					exception = exception.InnerException;
					continue;
				}
			}
			return false;
		}
		return true;
	}

	private void PerformAction(ActionItem actionItem, bool? confirmUninstall)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I4, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected I4, but got Unknown
		InstallAction action = actionItem.Action;
		switch (action - 1)
		{
		case 0:
			if ((int)actionItem.OutputLevel != 0)
			{
				EventLogger.LogToConsole(SR.GetString("InstallMessage", actionItem.Component.get_DisplayName()));
			}
			EventLogger.WriteMsiStyleLogEntry(SR.GetString("InstallMessage", actionItem.Component.get_DisplayName()));
			actionItem.Component.Install(actionItem.OutputLevel);
			break;
		case 1:
			if (confirmUninstall.HasValue && confirmUninstall.Value)
			{
				if ((int)actionItem.OutputLevel != 0)
				{
					EventLogger.LogToConsole(SR.GetString("UninstallMessage", actionItem.Component.get_DisplayName()));
				}
				EventLogger.WriteMsiStyleLogEntry(SR.GetString("UninstallMessage", actionItem.Component.get_DisplayName()));
				actionItem.Component.Uninstall(actionItem.OutputLevel);
			}
			break;
		case 2:
			if (confirmUninstall.HasValue && confirmUninstall.Value)
			{
				actionItem.Component.Reinstall(actionItem.OutputLevel);
			}
			break;
		case 3:
			Console.WriteLine();
			Console.WriteLine(SR.GetString("ServiceModelRegInstalledVersions", actionItem.Component.get_DisplayName()));
			if (actionItem.Component.get_IsInstalled())
			{
				string[] installedVersions = actionItem.Component.get_InstalledVersions();
				if (installedVersions != null && installedVersions.Length != 0)
				{
					string[] array = installedVersions;
					foreach (string format in array)
					{
						Console.WriteLine("\t" + string.Format(CultureInfo.CurrentUICulture, format));
					}
				}
				else
				{
					Console.WriteLine("\t" + SR.GetString("ServiceModelRegNone"));
				}
			}
			else
			{
				Console.WriteLine("\t" + SR.GetString("ServiceModelRegNone"));
			}
			break;
		case 4:
		{
			WebHostScriptMappingsInstallComponent val3 = (WebHostScriptMappingsInstallComponent)actionItem.Component;
			string[] installedPaths = val3.get_InstalledPaths();
			Console.WriteLine();
			Console.WriteLine(SR.GetString("ServiceModelRegInstalledScriptMaps"));
			if (installedPaths != null && installedPaths.Length != 0)
			{
				string[] array2 = installedPaths;
				foreach (string format2 in array2)
				{
					Console.WriteLine(string.Format(CultureInfo.CurrentUICulture, format2));
				}
			}
			else
			{
				Console.WriteLine("\t" + SR.GetString("ServiceModelRegNone"));
			}
			break;
		}
		case 5:
		{
			InstallationState val = actionItem.Component.VerifyInstall();
			string @string = SR.GetString("InstallationStateUnknown");
			InstallationState val2 = val;
			switch ((int)val2)
			{
			case 0:
				@string = SR.GetString("InstallationStateUnknown");
				break;
			case 1:
				@string = SR.GetString("InstallationStateNotInstalled");
				break;
			case 2:
				@string = SR.GetString("InstallationStateInstalledDefaults");
				break;
			case 3:
				@string = SR.GetString("InstallationStateInstalledCustom");
				break;
			}
			Console.WriteLine(actionItem.Component.get_DisplayName() + "\t:\t" + @string);
			break;
		}
		}
	}

	private static void ValidateUICulture()
	{
		Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		if (Console.OutputEncoding.CodePage != Encoding.UTF8.CodePage && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.OEMCodePage)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
		}
	}
}
