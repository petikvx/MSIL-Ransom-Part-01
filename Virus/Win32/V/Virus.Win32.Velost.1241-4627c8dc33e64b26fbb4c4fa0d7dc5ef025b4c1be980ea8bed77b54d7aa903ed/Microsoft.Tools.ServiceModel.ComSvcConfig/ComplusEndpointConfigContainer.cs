using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Transactions;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class ComplusEndpointConfigContainer : EndpointConfigContainer
{
	private const string defaultBindingType = "netNamedPipeBinding";

	private const string defaultTransactionBindingType = "netNamedPipeBinding";

	private const string defaultMexBindingType = "mexNamedPipeBinding";

	private const string defaultBindingName = "comNonTransactionalBinding";

	private const string defaultTransactionalBindingName = "comTransactionalBinding";

	private ComAdminAppInfo appInfo;

	private bool closed;

	private string appDir;

	private bool mustGenerateAppDir;

	private AtomicFile manifestFile;

	private AtomicFile configFile;

	private bool listenerComponentExists;

	private bool hasServices;

	private TransactionScope scope;

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

	internal bool ListenerComponentExists => listenerComponentExists;

	public override string DefaultBindingType => "netNamedPipeBinding";

	public override string DefaultBindingName => "comNonTransactionalBinding";

	public override string DefaultTransactionalBindingType => "netNamedPipeBinding";

	public override string DefaultTransactionalBindingName => "comTransactionalBinding";

	public override string DefaultMexBindingType => "mexNamedPipeBinding";

	public override string DefaultMexBindingName => null;

	private ComplusEndpointConfigContainer(ComAdminAppInfo appInfo)
	{
		this.appInfo = appInfo;
		scope = null;
		if (appInfo.ApplicationDirectory != null && appInfo.ApplicationDirectory.Length > 0)
		{
			appDir = appInfo.ApplicationDirectory;
			mustGenerateAppDir = false;
			if (!Directory.Exists(appDir))
			{
				throw Tool.CreateException(SR.GetString("ApplicationDirectoryDoesNotExist", appDir), null);
			}
		}
		else
		{
			appDir = GeneratedAppDirectoryName();
			if (!Directory.Exists(appDir))
			{
				mustGenerateAppDir = true;
			}
		}
		configFile = new AtomicFile(Path.Combine(appDir, "application.config"));
		manifestFile = new AtomicFile(Path.Combine(appDir, "application.manifest"));
		listenerComponentExists = appInfo.ListenerExists;
		hasServices = listenerComponentExists;
	}

	public override void AbortChanges()
	{
		closed = true;
		manifestFile.Abort();
		configFile.Abort();
		if (mustGenerateAppDir && Directory.Exists(appDir))
		{
			Directory.Delete(appDir);
		}
		if (scope == null)
		{
			return;
		}
		try
		{
			Transaction.Current!.Rollback();
			scope.Complete();
			scope.Dispose();
		}
		catch (Exception ex)
		{
			if (ex is NullReferenceException || ex is SEHException)
			{
				throw;
			}
			ToolConsole.WriteWarning(SR.GetString("FailedToAbortTransactionWithError", ex.Message));
		}
	}

	public override void Add(IList<EndpointConfig> endpointConfigs)
	{
		ThrowIfClosed();
		Configuration configuration = GetConfiguration(readOnly: false);
		bool flag = false;
		foreach (EndpointConfig endpointConfig in endpointConfigs)
		{
			if (BaseAddEndpointConfig(configuration, endpointConfig))
			{
				flag = true;
				if (endpointConfig.Iid == typeof(IMetadataExchange).GUID)
				{
					ToolConsole.WriteLine(SR.GetString("MexEndpointAdded"));
				}
				else if (!Tool.Options.ShowGuids)
				{
					ToolConsole.WriteLine(SR.GetString("InterfaceAdded", endpointConfig.ComponentProgID, endpointConfig.InterfaceName));
				}
				else
				{
					ToolConsole.WriteLine(SR.GetString("InterfaceAdded", endpointConfig.Clsid, endpointConfig.Iid));
				}
			}
			else if (endpointConfig.Iid == typeof(IMetadataExchange).GUID)
			{
				if (!Tool.Options.ShowGuids)
				{
					ToolConsole.WriteWarning(SR.GetString("MexEndpointAlreadyExposed", endpointConfig.ComponentProgID));
				}
				else
				{
					ToolConsole.WriteWarning(SR.GetString("MexEndpointAlreadyExposed", endpointConfig.Clsid));
				}
			}
			else if (!Tool.Options.ShowGuids)
			{
				ToolConsole.WriteWarning(SR.GetString("InterfaceAlreadyExposed", endpointConfig.ComponentProgID, endpointConfig.InterfaceName));
			}
			else
			{
				ToolConsole.WriteWarning(SR.GetString("InterfaceAlreadyExposed", endpointConfig.Clsid, endpointConfig.Iid));
			}
		}
		if (flag)
		{
			WasModified = true;
			configuration.Save();
		}
		hasServices = true;
	}

	private void EnsureNetProfileNamedPipeBindingElementBinding(Configuration config)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		if (!((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).ContainsKey((object)DefaultBindingName))
		{
			NetNamedPipeBindingElement val = new NetNamedPipeBindingElement(DefaultBindingName);
			((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).Add(val);
		}
		if (!((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).ContainsKey((object)DefaultTransactionalBindingName))
		{
			NetNamedPipeBindingElement val2 = new NetNamedPipeBindingElement(DefaultTransactionalBindingName);
			val2.set_TransactionFlow(true);
			((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).Add(val2);
		}
	}

	protected override void AddBinding(Configuration config)
	{
		EnsureNetProfileNamedPipeBindingElementBinding(config);
	}

	private void EnsureBindingRemoved(Configuration config)
	{
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		if (((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).ContainsKey((object)DefaultBindingName))
		{
			NetNamedPipeBindingElement val = ((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).get_Item((object)DefaultBindingName);
			((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).Remove(val);
		}
		if (((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).ContainsKey((object)DefaultTransactionalBindingName))
		{
			NetNamedPipeBindingElement val2 = ((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).get_Item((object)DefaultTransactionalBindingName);
			((ServiceModelConfigurationElementCollection<NetNamedPipeBindingElement>)(object)((StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement>)(object)sectionGroup.get_Bindings().get_NetNamedPipeBinding()).get_Bindings()).Remove(val2);
		}
	}

	protected override void RemoveBinding(Configuration config)
	{
		EnsureBindingRemoved(config);
	}

	public override void CommitChanges()
	{
		manifestFile.Commit();
		configFile.Commit();
		if (scope == null)
		{
			return;
		}
		try
		{
			scope.Complete();
			scope.Dispose();
		}
		catch (Exception ex)
		{
			if (ex is NullReferenceException || ex is SEHException)
			{
				throw;
			}
			Tool.CreateException(SR.GetString("FailedToCommitChangesToCatalog"), ex);
		}
	}

	public override void PrepareChanges()
	{
		closed = true;
		bool flag = configFile.HasBeenModified() && WasModified;
		TransactionOptions transactionOptions = default(TransactionOptions);
		transactionOptions.Timeout = TimeSpan.FromMinutes(5.0);
		transactionOptions.IsolationLevel = IsolationLevel.Serializable;
		scope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, EnterpriseServicesInteropOption.Full);
		if (flag)
		{
			if (mustGenerateAppDir)
			{
				Directory.CreateDirectory(appDir);
				ToolConsole.WriteLine(SR.GetString("DirectoryCreated", appDir));
			}
			ComAdminWrapper.SetAppDir(appInfo.ID.ToString("B"), appDir);
		}
		configFile.Prepare();
		if (flag)
		{
			ToolConsole.WriteLine(SR.GetString(configFile.OriginalFileExists ? "FileUpdated" : "FileCreated", configFile.OriginalFileName));
		}
		if (flag && !manifestFile.CurrentExists() && hasServices)
		{
			manifestFile.GetCurrentFileName(readOnly: false);
			CreateManifestFile(manifestFile.GetCurrentFileName(readOnly: false));
			ToolConsole.WriteLine(SR.GetString("FileCreated", manifestFile.OriginalFileName));
		}
		manifestFile.Prepare();
		if (flag)
		{
			if (hasServices && !listenerComponentExists)
			{
				ComAdminWrapper.InstallListener(appInfo.ID, appDir, appInfo.RuntimeVersion);
			}
			else if (!hasServices && listenerComponentExists)
			{
				ComAdminWrapper.RemoveListener(appInfo.ID);
			}
			if (appInfo.IsServerActivated)
			{
				ToolConsole.WriteWarning(SR.GetString("ShouldRestartApp", appInfo.Name));
			}
		}
	}

	private void CreateManifestFile(string fileName)
	{
		using StreamWriter streamWriter = File.CreateText(fileName);
		streamWriter.WriteLine("<assembly manifestVersion=\"1.0\" xmlns=\"urn:schemas-microsoft-com:asm.v1\"><assemblyIdentity name=\"" + appInfo.ID.ToString("B") + "\" version=\"1.0.0.0\" type=\"win32\"/></assembly>");
	}

	private string GetPartitionId(Guid appId)
	{
		string text = null;
		text = ComAdminWrapper.GetPartitionIdForApplication(appId);
		if (!string.IsNullOrEmpty(text) && text != ComAdminWrapper.GetGlobalPartitionID())
		{
			text = new Guid(text).ToString();
			return text + "/";
		}
		return "";
	}

	public override string DefaultEndpointAddress(Guid appId, Guid clsid, Guid iid)
	{
		ComAdminAppInfo comAdminAppInfo = ComAdminWrapper.GetAppInfo(appId.ToString("B"));
		if (comAdminAppInfo == null)
		{
			throw Tool.CreateException(SR.GetString("CannotFindAppInfo", appId.ToString("B")), null);
		}
		ComAdminClassInfo comAdminClassInfo = comAdminAppInfo.FindClass(clsid.ToString("B"));
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

	public override string DefaultMexAddress(Guid appId, Guid clsid)
	{
		return EndpointConfig.MexEndpointSuffix;
	}

	public override string BaseServiceAddress(Guid appId, Guid clsid, Guid iid)
	{
		ComAdminAppInfo comAdminAppInfo = ComAdminWrapper.GetAppInfo(appId.ToString("B"));
		if (comAdminAppInfo == null)
		{
			throw Tool.CreateException(SR.GetString("CannotFindAppInfo", appId.ToString("B")), null);
		}
		ComAdminClassInfo comAdminClassInfo = comAdminAppInfo.FindClass(clsid.ToString("B"));
		if (comAdminClassInfo == null)
		{
			throw Tool.CreateException(SR.GetString("CannotFindClassInfo", clsid.ToString("B")), null);
		}
		string text = Uri.EscapeUriString("net.pipe://localhost/" + comAdminAppInfo.Name + "/" + GetPartitionId(appId) + comAdminClassInfo.Name);
		if (Uri.IsWellFormedUriString(text, UriKind.Absolute))
		{
			return text;
		}
		return "net.pipe://localhost/" + appId.ToString() + "/" + clsid;
	}

	private string GeneratedAppDirectoryName()
	{
		string text = ((!ComAdminWrapper.IsApplicationWow(appInfo.ID)) ? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) : Environment.GetEnvironmentVariable("ProgramFiles(x86)"));
		return text + "\\ComPlus Applications\\" + appInfo.ID.ToString("B") + "\\";
	}

	public static List<ComplusEndpointConfigContainer> Get()
	{
		List<ComplusEndpointConfigContainer> list = new List<ComplusEndpointConfigContainer>();
		Guid[] applicationIds = ComAdminWrapper.GetApplicationIds();
		Guid[] array = applicationIds;
		foreach (Guid guid in array)
		{
			ComplusEndpointConfigContainer complusEndpointConfigContainer = Get(guid.ToString("B"));
			if (complusEndpointConfigContainer != null)
			{
				list.Add(complusEndpointConfigContainer);
			}
		}
		return list;
	}

	public static ComplusEndpointConfigContainer Get(string appIdOrName)
	{
		return Get(appIdOrName, rethrow: false);
	}

	public static ComplusEndpointConfigContainer Get(string appIdOrName, bool rethrow)
	{
		ComAdminAppInfo comAdminAppInfo = ComAdminWrapper.GetAppInfo(appIdOrName);
		if (comAdminAppInfo == null)
		{
			return null;
		}
		try
		{
			return new ComplusEndpointConfigContainer(comAdminAppInfo);
		}
		catch (Exception ex)
		{
			if (ex is NullReferenceException || ex is SEHException)
			{
				throw;
			}
			if (rethrow)
			{
				throw;
			}
			ToolConsole.WriteWarning(SR.GetString("FailedToLoadConfigForApplicationIgnoring", comAdminAppInfo.Name, ex.Message));
		}
		return null;
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

	public override List<string> GetBaseAddresses(EndpointConfig config)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		List<string> list = new List<string>();
		Configuration configuration = GetConfiguration(readOnly: true);
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(configuration);
		ServiceElementCollection services = sectionGroup.get_Services().get_Services();
		ServiceElement val = null;
		foreach (ServiceElement item in (ConfigurationElementCollection)services)
		{
			ServiceElement val2 = item;
			if (config.MatchServiceType(val2.get_Name()))
			{
				val = val2;
				break;
			}
		}
		if (val == null)
		{
			return list;
		}
		foreach (BaseAddressElement item2 in (ConfigurationElementCollection)val.get_Host().get_BaseAddresses())
		{
			BaseAddressElement val3 = item2;
			list.Add(val3.get_BaseAddress());
		}
		return list;
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
				item.Appid = appInfo.ID;
				item.Container = this;
				list.Add(item);
			}
		}
		return list;
	}

	public override List<EndpointConfig> GetEndpointConfigs(Guid appid)
	{
		ThrowIfClosed();
		if (appid == appInfo.ID)
		{
			return GetEndpointConfigs();
		}
		return new List<EndpointConfig>();
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
		hasServices = ((ConfigurationElementCollection)ServiceModelSectionGroup.GetSectionGroup(configuration).get_Services().get_Services()).get_Count() > 0;
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
}
