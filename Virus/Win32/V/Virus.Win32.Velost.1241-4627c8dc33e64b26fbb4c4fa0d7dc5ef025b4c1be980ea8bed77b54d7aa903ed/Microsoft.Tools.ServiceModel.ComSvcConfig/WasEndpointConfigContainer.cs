using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Web.Configuration;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class WasEndpointConfigContainer : EndpointConfigContainer
{
	private const string defaultBindingType = "wsHttpBinding";

	private const string defaultTransactionBindingType = "wsHttpBinding";

	private const string defaultMexBindingType = "mexHttpBinding";

	private const string defaultBindingName = "comNonTransactionalBinding";

	private const string defaultTransactionalBindingName = "comTransactionalBinding";

	private bool closed;

	private AtomicFile configFile;

	private SvcFileManager svcFileManager;

	private string webDirectoryName;

	private string webDirectoryPath;

	private string webServerName;

	private RuntimeVersions runtimeVersion;

	private bool modified;

	public override bool WasModified
	{
		get
		{
			return modified;
		}
		set
		{
			modified = value;
		}
	}

	internal AtomicFile ConfigFile => configFile;

	public override string DefaultBindingType => "wsHttpBinding";

	public override string DefaultBindingName => "comNonTransactionalBinding";

	public override string DefaultTransactionalBindingType => "wsHttpBinding";

	public override string DefaultTransactionalBindingName => "comTransactionalBinding";

	public override string DefaultMexBindingType => "mexHttpBinding";

	public override string DefaultMexBindingName => null;

	public static string DefaultWebServer => WasAdminWrapper.DefaultWebServer;

	private WasEndpointConfigContainer(string webServerName, string webDirectoryName, string webDirectoryPath, RuntimeVersions runtimeVersion)
	{
		if (string.IsNullOrEmpty(webDirectoryPath) || !Directory.Exists(webDirectoryPath))
		{
			throw Tool.CreateException(SR.GetString("WebDirectoryPathNotFound", webDirectoryName, webDirectoryPath), null);
		}
		this.webDirectoryName = webDirectoryName;
		this.webDirectoryPath = webDirectoryPath;
		this.webServerName = webServerName;
		closed = false;
		configFile = new AtomicFile(this.webDirectoryPath + "\\web.config");
		svcFileManager = new SvcFileManager(this.webDirectoryPath);
		this.runtimeVersion = runtimeVersion;
	}

	public override void AbortChanges()
	{
		closed = true;
		configFile.Abort();
		svcFileManager.Abort();
	}

	public override void Add(IList<EndpointConfig> endpointConfigs)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		ThrowIfClosed();
		Configuration configuration = GetConfiguration(readOnly: false);
		bool flag = false;
		foreach (EndpointConfig endpointConfig in endpointConfigs)
		{
			if (svcFileManager.ResolveClsid(endpointConfig.Clsid, out var appid) && endpointConfig.Appid != appid)
			{
				ToolConsole.WriteError(SR.GetString("AppIDsDontMatch"), "");
				return;
			}
		}
		SystemWebSectionGroup val = (SystemWebSectionGroup)configuration.GetSectionGroup("system.web");
		CompilationSection compilation = val.get_Compilation();
		if (string.IsNullOrEmpty(compilation.get_TargetFramework()) && RuntimeVersions.V40 == runtimeVersion)
		{
			flag = true;
			compilation.set_TargetFramework(".NETFramework, Version=v4.0");
		}
		foreach (EndpointConfig endpointConfig2 in endpointConfigs)
		{
			if (BaseAddEndpointConfig(configuration, endpointConfig2))
			{
				svcFileManager.Add(endpointConfig2.Appid, endpointConfig2.Clsid);
				flag = true;
				if (endpointConfig2.Iid == typeof(IMetadataExchange).GUID)
				{
					ToolConsole.WriteLine(SR.GetString("MexEndpointAdded"));
				}
				else if (!Tool.Options.ShowGuids)
				{
					ToolConsole.WriteLine(SR.GetString("InterfaceAdded", endpointConfig2.ComponentProgID, endpointConfig2.InterfaceName));
				}
				else
				{
					ToolConsole.WriteLine(SR.GetString("InterfaceAdded", endpointConfig2.Clsid, endpointConfig2.Iid));
				}
			}
			else if (endpointConfig2.Iid == typeof(IMetadataExchange).GUID)
			{
				if (!Tool.Options.ShowGuids)
				{
					ToolConsole.WriteWarning(SR.GetString("MexEndpointAlreadyExposed", endpointConfig2.ComponentProgID));
				}
				else
				{
					ToolConsole.WriteWarning(SR.GetString("MexEndpointAlreadyExposed", endpointConfig2.Clsid));
				}
			}
			else if (!Tool.Options.ShowGuids)
			{
				ToolConsole.WriteWarning(SR.GetString("InterfaceAlreadyExposed", endpointConfig2.ComponentProgID, endpointConfig2.InterfaceName));
			}
			else
			{
				ToolConsole.WriteWarning(SR.GetString("InterfaceAlreadyExposed", endpointConfig2.Clsid, endpointConfig2.Iid));
			}
		}
		if (flag)
		{
			WasModified = true;
			configuration.Save();
		}
	}

	private void EnsureWSProfileBindingAdded(Configuration config)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		if (!((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).ContainsKey((object)DefaultBindingName))
		{
			WSHttpBindingElement val = new WSHttpBindingElement(DefaultBindingName);
			((WSHttpBindingBaseElement)val).get_ReliableSession().set_Enabled(true);
			((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).Add(val);
		}
		if (!((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).ContainsKey((object)DefaultTransactionalBindingName))
		{
			WSHttpBindingElement val2 = new WSHttpBindingElement(DefaultTransactionalBindingName);
			((WSHttpBindingBaseElement)val2).get_ReliableSession().set_Enabled(true);
			((WSHttpBindingBaseElement)val2).set_TransactionFlow(true);
			((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).Add(val2);
		}
	}

	protected override void AddBinding(Configuration config)
	{
		EnsureWSProfileBindingAdded(config);
	}

	private void EnsureBindingRemoved(Configuration config)
	{
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		if (((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).ContainsKey((object)DefaultBindingName))
		{
			WSHttpBindingElement val = ((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).get_Item((object)DefaultBindingName);
			((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).Remove(val);
		}
		if (((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).ContainsKey((object)DefaultTransactionalBindingName))
		{
			WSHttpBindingElement val2 = ((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).get_Item((object)DefaultTransactionalBindingName);
			((ServiceModelConfigurationElementCollection<WSHttpBindingElement>)(object)((StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement>)(object)sectionGroup.get_Bindings().get_WSHttpBinding()).get_Bindings()).Remove(val2);
		}
	}

	protected override void RemoveBinding(Configuration config)
	{
		EnsureBindingRemoved(config);
	}

	public override void CommitChanges()
	{
		configFile.Commit();
		svcFileManager.Commit();
	}

	public override string DefaultEndpointAddress(Guid appId, Guid clsid, Guid iid)
	{
		ComAdminAppInfo appInfo = ComAdminWrapper.GetAppInfo(appId.ToString("B"));
		if (appInfo == null)
		{
			throw Tool.CreateException(SR.GetString("CannotFindAppInfo", appId.ToString("B")), null);
		}
		ComAdminClassInfo comAdminClassInfo = appInfo.FindClass(clsid.ToString("B"));
		if (comAdminClassInfo == null)
		{
			throw Tool.CreateException(SR.GetString("CannotFindClassInfo", clsid.ToString("B")), null);
		}
		ComAdminInterfaceInfo comAdminInterfaceInfo = comAdminClassInfo.FindInterface(iid.ToString("B"));
		if (comAdminInterfaceInfo == null)
		{
			throw Tool.CreateException(SR.GetString("CannotFindInterfaceInfo", iid.ToString("B")), null);
		}
		string text = Uri.EscapeUriString(comAdminInterfaceInfo.Name);
		if (Uri.IsWellFormedUriString(text, UriKind.RelativeOrAbsolute))
		{
			return text;
		}
		return iid.ToString().ToUpperInvariant();
	}

	public override List<string> GetBaseAddresses(EndpointConfig config)
	{
		return new List<string>();
	}

	public override string BaseServiceAddress(Guid appId, Guid clsid, Guid iid)
	{
		return string.Empty;
	}

	public override string DefaultMexAddress(Guid appId, Guid clsid)
	{
		return EndpointConfig.MexEndpointSuffix;
	}

	public override Configuration GetConfiguration(bool readOnly)
	{
		string currentFileName = configFile.GetCurrentFileName(readOnly);
		if (string.IsNullOrEmpty(currentFileName))
		{
			return null;
		}
		return GetConfigurationFromFile(currentFileName);
	}

	public override List<EndpointConfig> GetEndpointConfigs()
	{
		ThrowIfClosed();
		Configuration configuration = GetConfiguration(readOnly: true);
		if (configuration == null)
		{
			return new List<EndpointConfig>();
		}
		Dictionary<string, List<EndpointConfig>> dictionary = BaseGetEndpointsFromConfiguration(configuration);
		List<EndpointConfig> list = new List<EndpointConfig>();
		foreach (List<EndpointConfig> value in dictionary.Values)
		{
			foreach (EndpointConfig item in value)
			{
				if (svcFileManager.ResolveClsid(item.Clsid, out var appid))
				{
					item.Appid = appid;
					list.Add(item);
					continue;
				}
				string applicationName = item.ApplicationName;
				string componentProgID = item.ComponentProgID;
				string interfaceName = item.InterfaceName;
				if (!Tool.Options.ShowGuids && !string.IsNullOrEmpty(applicationName) && !string.IsNullOrEmpty(componentProgID) && !string.IsNullOrEmpty(interfaceName))
				{
					ToolConsole.WriteWarning(SR.GetString("EndpointNotFoundInSvcFile", applicationName, componentProgID, interfaceName, item.BindingName, item.Address));
				}
				else
				{
					ToolConsole.WriteWarning(SR.GetString("EndpointNotFoundInSvcFile", item.Appid.ToString("B"), item.Clsid.ToString("B"), item.Iid.ToString("B"), item.BindingName, item.Address));
				}
			}
		}
		return list;
	}

	private int NumEndpointsForClsid(Configuration config, Guid clsid, Guid appId)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		ServiceElementCollection services = sectionGroup.get_Services().get_Services();
		foreach (ServiceElement item in (ConfigurationElementCollection)services)
		{
			ServiceElement val = item;
			string[] array = val.get_Name().Split(new char[1] { ',' });
			if (array.Length == 2)
			{
				Guid guid;
				Guid guid2;
				try
				{
					guid = new Guid(array[0]);
					guid2 = new Guid(array[1]);
				}
				catch (FormatException)
				{
					continue;
				}
				if (guid2 == clsid && guid == appId)
				{
					return ((ConfigurationElementCollection)val.get_Endpoints()).get_Count();
				}
			}
		}
		return 0;
	}

	public override void PrepareChanges()
	{
		closed = true;
		bool flag = configFile.HasBeenModified() && WasModified;
		configFile.Prepare();
		if (flag)
		{
			ToolConsole.WriteLine(SR.GetString(configFile.OriginalFileExists ? "FileUpdated" : "FileCreated", configFile.OriginalFileName));
		}
		svcFileManager.Prepare();
	}

	public override void Remove(IList<EndpointConfig> endpointConfigs)
	{
		ThrowIfClosed();
		Configuration configuration = GetConfiguration(readOnly: false);
		bool flag = false;
		foreach (EndpointConfig endpointConfig in endpointConfigs)
		{
			if (BaseRemoveEndpointConfig(configuration, endpointConfig))
			{
				flag = true;
				if (NumEndpointsForClsid(configuration, endpointConfig.Clsid, endpointConfig.Appid) == 0)
				{
					svcFileManager.Remove(endpointConfig.Appid, endpointConfig.Clsid);
				}
				if (!Tool.Options.ShowGuids)
				{
					ToolConsole.WriteLine(SR.GetString("InterfaceRemoved", endpointConfig.ComponentProgID, endpointConfig.InterfaceName));
				}
				else
				{
					ToolConsole.WriteLine(SR.GetString("InterfaceRemoved", endpointConfig.Clsid, endpointConfig.Iid));
				}
			}
			else if (!endpointConfig.IsMexEndpoint)
			{
				if (!Tool.Options.ShowGuids)
				{
					ToolConsole.WriteWarning(SR.GetString("InterfaceNotExposed", endpointConfig.ComponentProgID, endpointConfig.InterfaceName));
				}
				else
				{
					ToolConsole.WriteWarning(SR.GetString("InterfaceNotExposed", endpointConfig.Clsid, endpointConfig.Iid));
				}
			}
		}
		if (flag)
		{
			WasModified = true;
			configuration.Save();
		}
	}

	private void ThrowIfClosed()
	{
		if (closed)
		{
			throw new InvalidOperationException();
		}
	}

	public static List<WasEndpointConfigContainer> Get(string applicationIdOrName)
	{
		List<WasEndpointConfigContainer> list = new List<WasEndpointConfigContainer>();
		string[] webServerNames = WasAdminWrapper.GetWebServerNames();
		if (webServerNames != null)
		{
			string[] array = webServerNames;
			foreach (string webServer in array)
			{
				List<WasEndpointConfigContainer> collection = Get(webServer, applicationIdOrName);
				list.AddRange(collection);
			}
		}
		return list;
	}

	public static List<WasEndpointConfigContainer> Get(string webServer, string applicationIdOrName)
	{
		List<WasEndpointConfigContainer> list = new List<WasEndpointConfigContainer>();
		string[] webDirectoryNames = WasAdminWrapper.GetWebDirectoryNames(webServer);
		if (webDirectoryNames != null)
		{
			string[] array = webDirectoryNames;
			foreach (string webDirectory in array)
			{
				WasEndpointConfigContainer wasEndpointConfigContainer = Get(webServer, webDirectory, applicationIdOrName);
				if (wasEndpointConfigContainer != null)
				{
					list.Add(wasEndpointConfigContainer);
				}
			}
		}
		return list;
	}

	public static WasEndpointConfigContainer Get(string webServer, string webDirectory, string applicationIdOrName)
	{
		string text = null;
		RuntimeVersions runtimeVersions = RuntimeVersions.V40;
		if (!string.IsNullOrEmpty(applicationIdOrName))
		{
			ComAdminAppInfo appInfo = ComAdminWrapper.GetAppInfo(applicationIdOrName);
			runtimeVersions = appInfo.RuntimeVersion;
		}
		if (WasAdminWrapper.GetWebDirectoryPath(webServer, webDirectory, out text))
		{
			try
			{
				return new WasEndpointConfigContainer(webServer, webDirectory, text, runtimeVersions);
			}
			catch (Exception ex)
			{
				if (ex is NullReferenceException || ex is SEHException)
				{
					throw ex;
				}
				ToolConsole.WriteWarning(SR.GetString("FailedToLoadConfigForWebDirectoryOnWebSite", webDirectory, webServer));
			}
			return null;
		}
		return null;
	}
}
