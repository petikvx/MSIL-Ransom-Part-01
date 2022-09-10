using System;
using System.Collections.Generic;
using System.ServiceModel.Description;
using Microsoft.Tools.ServiceModel.SvcUtil;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class Options
{
	private bool allComponents;

	private string application;

	private bool help;

	private Hosting hosting;

	private IList<ComponentDefinition<string>> components;

	private Mode mode;

	private bool noLogo;

	private bool verbose;

	private string webDirectory;

	private string webServer;

	private bool showGuids;

	private bool allowReferences;

	private bool mex;

	private string mexOnlyComponent = string.Empty;

	private static CommandSwitch[] switches = new CommandSwitch[15]
	{
		new CommandSwitch("application", "a", SwitchType.SingletonValue),
		new CommandSwitch("help", "?", SwitchType.Flag),
		new CommandSwitch("hosting", "h", SwitchType.SingletonValue),
		new CommandSwitch("contract", "c", SwitchType.SingletonValue),
		new CommandSwitch("mode", "m", SwitchType.SingletonValue),
		new CommandSwitch("nologo", "n", SwitchType.Flag),
		new CommandSwitch("verbose", "v", SwitchType.Flag),
		new CommandSwitch("webDirectory", "d", SwitchType.SingletonValue),
		new CommandSwitch("webSite", "w", SwitchType.SingletonValue),
		new CommandSwitch("id", "k", SwitchType.Flag),
		new CommandSwitch("mex", "x", SwitchType.Flag),
		new CommandSwitch("install", "i", SwitchType.Flag),
		new CommandSwitch("uninstall", "u", SwitchType.Flag),
		new CommandSwitch("list", "l", SwitchType.Flag),
		new CommandSwitch("allowreferences", "r", SwitchType.Flag)
	};

	internal bool AllComponents => allComponents;

	internal string Application => application;

	internal IList<ComponentDefinition<string>> Components => components;

	internal bool Help => help;

	internal Hosting Hosting => hosting;

	internal Mode Mode => mode;

	internal bool NoLogo => noLogo;

	internal bool Verbose => verbose;

	internal string WebDirectory => webDirectory;

	internal string WebServer => webServer;

	internal bool ShowGuids => showGuids;

	internal bool AllowReferences => allowReferences;

	internal bool Mex => mex;

	internal string MexOnlyComponent => mexOnlyComponent;

	private Options(Mode mode, ArgumentDictionary arguments)
	{
		if (arguments == null)
		{
			help = true;
			return;
		}
		this.mode = mode;
		if (arguments.ContainsArgument("application"))
		{
			application = arguments.GetArgument("application");
		}
		help = arguments.ContainsArgument("help");
		hosting = Hosting.NotSpecified;
		if (arguments.ContainsArgument("hosting"))
		{
			string argument = arguments.GetArgument("hosting");
			if (string.Equals(argument, Enum.GetName(typeof(Hosting), Hosting.Complus), StringComparison.OrdinalIgnoreCase))
			{
				hosting = Hosting.Complus;
			}
			else
			{
				if (!string.Equals(argument, Enum.GetName(typeof(Hosting), Hosting.Was), StringComparison.OrdinalIgnoreCase))
				{
					throw Tool.CreateException(SR.GetString("UnknownHostingSpecified", argument), null);
				}
				if (!WasAdminWrapper.IsIISInstalled())
				{
					throw Tool.CreateException(SR.GetString("IISNotInstalled", argument), null);
				}
				hosting = Hosting.Was;
			}
		}
		mex = arguments.ContainsArgument("mex");
		components = null;
		allComponents = false;
		if (arguments.ContainsArgument("contract"))
		{
			IList<string> arguments2 = arguments.GetArguments("contract");
			ParseInterfaces(arguments2);
		}
		noLogo = arguments.ContainsArgument("nologo");
		if (noLogo && arguments.Count == 1)
		{
			help = true;
		}
		verbose = arguments.ContainsArgument("verbose");
		if (arguments.ContainsArgument("webDirectory"))
		{
			webDirectory = arguments.GetArgument("webDirectory");
		}
		if (arguments.ContainsArgument("webSite"))
		{
			webServer = arguments.GetArgument("webSite");
		}
		showGuids = arguments.ContainsArgument("id");
		allowReferences = arguments.ContainsArgument("allowreferences");
	}

	internal static Options ParseArguments(string[] args)
	{
		Mode mode = Mode.NotSpecified;
		Options options = null;
		if (args.Length > 0)
		{
			ArgumentDictionary argumentDictionary = CommandParser.ParseCommand(args, switches);
			if (argumentDictionary.ContainsArgument("install"))
			{
				mode = Mode.Install;
			}
			if (argumentDictionary.ContainsArgument("uninstall"))
			{
				if (mode != 0)
				{
					throw Tool.CreateException(SR.GetString("MultipleModeArguments"), null);
				}
				mode = Mode.Uninstall;
			}
			if (argumentDictionary.ContainsArgument("list"))
			{
				if (mode != 0)
				{
					throw Tool.CreateException(SR.GetString("MultipleModeArguments"), null);
				}
				mode = Mode.List;
			}
			options = new Options(mode, argumentDictionary);
			if (!options.Help && mode == Mode.NotSpecified)
			{
				throw Tool.CreateException(SR.GetString("ModeArgumentMissing"), null);
			}
			return options;
		}
		return new Options(mode, null);
	}

	private void ParseInterfaces(IList<string> argValues)
	{
		components = null;
		allComponents = false;
		if (argValues.Count == 1 && argValues[0] == "*")
		{
			allComponents = true;
			return;
		}
		Dictionary<string, ComponentDefinition<string>> dictionary = new Dictionary<string, ComponentDefinition<string>>();
		foreach (string argValue in argValues)
		{
			string text = null;
			string text2 = null;
			ComponentDefinition<string> value = null;
			if (argValue.Contains(","))
			{
				string[] array = argValue.Split(new char[1] { ',' }, 2);
				text = array[0];
				text2 = array[1];
			}
			else
			{
				if (!mex)
				{
					throw Tool.CreateArgumentException("contract", argValue, SR.GetString("MalformedInterfaceString"), null);
				}
				if (mex)
				{
					text = argValue;
					text2 = typeof(IMetadataExchange).GUID.ToString("B");
					if (string.Empty == mexOnlyComponent)
					{
						mexOnlyComponent = argValue;
					}
				}
			}
			if (!text.Equals("*"))
			{
				if (!dictionary.TryGetValue(text, out value))
				{
					value = new ComponentDefinition<string>(text);
					dictionary.Add(text, value);
				}
				if (text2.Equals("*"))
				{
					value.SetAllInterfaces();
					continue;
				}
				string[] array2 = text2.Split(new char[1] { '.' }, 2);
				if (array2.Length == 1)
				{
					value.AddInterface(text2, null);
					continue;
				}
				text2 = array2[0];
				string text3 = array2[1];
				if (text3 == "*")
				{
					value.AddInterface(text2, null);
					continue;
				}
				if (text3[0] == '{' || text3[text3.Length - 1] == '}')
				{
					text3 = text3.Substring(1, text3.Length - 2);
					string[] array3 = text3.Split(new char[1] { ',' });
					if (array3.Length != 0)
					{
						List<string> list = new List<string>();
						string[] array4 = array3;
						foreach (string item in array4)
						{
							list.Add(item);
						}
						value.AddInterface(text2, list);
						continue;
					}
					throw Tool.CreateException(SR.GetString("NoMethodsSpecifiedInArgument", argValue), null);
				}
				throw Tool.CreateException(SR.GetString("BadMethodParameter", argValue), null);
			}
			throw Tool.CreateArgumentException("contract", argValue, SR.GetString("CannotSpecifyInterfaceForAllComponents"), null);
		}
		components = new List<ComponentDefinition<string>>(dictionary.Count);
		foreach (ComponentDefinition<string> value2 in dictionary.Values)
		{
			components.Add(value2);
		}
	}
}
