using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Xml;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal abstract class EndpointConfigContainer
{
	private const string comServiceBehavior = "ComServiceMexBehavior";

	public abstract string DefaultBindingType { get; }

	public abstract string DefaultBindingName { get; }

	public abstract string DefaultTransactionalBindingType { get; }

	public abstract string DefaultTransactionalBindingName { get; }

	public abstract string DefaultMexBindingType { get; }

	public abstract string DefaultMexBindingName { get; }

	public abstract bool WasModified { get; set; }

	public abstract List<EndpointConfig> GetEndpointConfigs();

	public virtual bool HasEndpointsForApplication(Guid appid)
	{
		List<EndpointConfig> endpointConfigs = GetEndpointConfigs(appid);
		return endpointConfigs.Count > 0;
	}

	public virtual List<EndpointConfig> GetEndpointConfigs(Guid appid)
	{
		List<EndpointConfig> list = new List<EndpointConfig>();
		foreach (EndpointConfig endpointConfig in GetEndpointConfigs())
		{
			if (endpointConfig.Appid == appid)
			{
				list.Add(endpointConfig);
			}
		}
		return list;
	}

	public abstract void Add(IList<EndpointConfig> endpointConfigs);

	public abstract void PrepareChanges();

	public abstract void AbortChanges();

	public abstract void CommitChanges();

	public abstract string DefaultEndpointAddress(Guid appId, Guid clsid, Guid iid);

	public abstract string DefaultMexAddress(Guid appId, Guid clsid);

	public abstract Configuration GetConfiguration(bool readOnly);

	public abstract string BaseServiceAddress(Guid appId, Guid clsid, Guid iid);

	public abstract List<string> GetBaseAddresses(EndpointConfig config);

	public abstract void Remove(IList<EndpointConfig> endpointConfigs);

	protected abstract void RemoveBinding(Configuration config);

	protected abstract void AddBinding(Configuration config);

	protected bool BaseAddEndpointConfig(Configuration config, EndpointConfig endpointConfig)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		ServiceElementCollection services = sectionGroup.get_Services().get_Services();
		ServiceElement val = null;
		foreach (ServiceElement item in (ConfigurationElementCollection)services)
		{
			ServiceElement val2 = item;
			if (endpointConfig.MatchServiceType(val2.get_Name()))
			{
				val = val2;
				break;
			}
		}
		if (val == null)
		{
			val = new ServiceElement(endpointConfig.ServiceType);
			string text = BaseServiceAddress(endpointConfig.Appid, endpointConfig.Clsid, endpointConfig.Iid);
			if (!string.IsNullOrEmpty(text))
			{
				BaseAddressElement val3 = new BaseAddressElement();
				val3.set_BaseAddress(text);
				((ServiceModelConfigurationElementCollection<BaseAddressElement>)(object)val.get_Host().get_BaseAddresses()).Add(val3);
			}
			((ServiceModelConfigurationElementCollection<ServiceElement>)(object)sectionGroup.get_Services().get_Services()).Add(val);
		}
		if (endpointConfig.IsMexEndpoint)
		{
			EnsureComMetaDataExchangeBehaviorAdded(config);
			val.set_BehaviorConfiguration("ComServiceMexBehavior");
		}
		bool result = false;
		if (!endpointConfig.IsMexEndpoint)
		{
			result = AddComContractToConfig(config, endpointConfig.InterfaceName, endpointConfig.Iid.ToString("B"), endpointConfig.Methods);
		}
		foreach (ServiceEndpointElement item2 in (ConfigurationElementCollection)val.get_Endpoints())
		{
			ServiceEndpointElement val4 = item2;
			bool flag = true;
			if (this is ComplusEndpointConfigContainer)
			{
				flag = ((ComplusEndpointConfigContainer)this).ListenerComponentExists;
			}
			if (endpointConfig.MatchContract(val4.get_Contract()))
			{
				if (flag)
				{
					return result;
				}
				((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val.get_Endpoints()).Remove(val4);
			}
		}
		ServiceEndpointElement val5 = new ServiceEndpointElement(endpointConfig.Address, endpointConfig.ContractType);
		val5.set_Binding(endpointConfig.BindingType);
		val5.set_BindingConfiguration(endpointConfig.BindingName);
		((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val.get_Endpoints()).Add(val5);
		AddBinding(config);
		return true;
	}

	protected bool RemoveComContractMethods(Configuration config, string interfaceID, IList<string> methods)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		Guid guid = new Guid(interfaceID);
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		ComContractElementCollection comContracts = sectionGroup.get_ComContracts().get_ComContracts();
		foreach (ComContractElement item in (ConfigurationElementCollection)comContracts)
		{
			ComContractElement val = item;
			try
			{
				Guid guid2 = new Guid(val.get_Contract());
				if (!(guid2 == guid))
				{
					continue;
				}
				foreach (string method in methods)
				{
					foreach (ComMethodElement item2 in (ConfigurationElementCollection)val.get_ExposedMethods())
					{
						ComMethodElement val2 = item2;
						if (val2.get_ExposedMethod() == method)
						{
							((ServiceModelConfigurationElementCollection<ComMethodElement>)(object)val.get_ExposedMethods()).Remove(val2);
							break;
						}
					}
				}
				if (((ConfigurationElementCollection)val.get_ExposedMethods()).get_Count() == 0)
				{
					((ServiceModelConfigurationElementCollection<ComContractElement>)(object)sectionGroup.get_ComContracts().get_ComContracts()).Remove(val);
					return true;
				}
			}
			catch (FormatException)
			{
			}
		}
		return false;
	}

	protected bool RemoveComContractIfNotUsedByAnyService(Configuration config, string interfaceID)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		ServiceElementCollection services = sectionGroup.get_Services().get_Services();
		Guid guid = new Guid(interfaceID);
		foreach (ServiceElement item in (ConfigurationElementCollection)services)
		{
			ServiceElement val = item;
			foreach (ServiceEndpointElement item2 in (ConfigurationElementCollection)val.get_Endpoints())
			{
				ServiceEndpointElement val2 = item2;
				try
				{
					if (!IsMetaDataEndpoint(val2))
					{
						Guid guid2 = new Guid(val2.get_Contract());
						if (guid == guid2)
						{
							return false;
						}
					}
				}
				catch (FormatException)
				{
				}
			}
		}
		ComContractElementCollection comContracts = sectionGroup.get_ComContracts().get_ComContracts();
		foreach (ComContractElement item3 in (ConfigurationElementCollection)comContracts)
		{
			ComContractElement val3 = item3;
			try
			{
				Guid guid3 = new Guid(val3.get_Contract());
				if (guid3 == guid)
				{
					((ServiceModelConfigurationElementCollection<ComContractElement>)(object)comContracts).Remove(val3);
					return true;
				}
			}
			catch (FormatException)
			{
			}
		}
		return false;
	}

	protected bool AddComContractToConfig(Configuration config, string name, string contractType, IList<string> methods)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		Guid guid = new Guid(contractType);
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		ComContractElementCollection comContracts = sectionGroup.get_ComContracts().get_ComContracts();
		foreach (ComContractElement item in (ConfigurationElementCollection)comContracts)
		{
			ComContractElement val = item;
			try
			{
				Guid guid2 = new Guid(val.get_Contract());
				if (!(guid == guid2))
				{
					continue;
				}
				bool flag = false;
				bool flag2 = false;
				foreach (string method in methods)
				{
					flag2 = false;
					foreach (ComMethodElement item2 in (ConfigurationElementCollection)val.get_ExposedMethods())
					{
						ComMethodElement val2 = item2;
						if (val2.get_ExposedMethod() == method)
						{
							flag2 = true;
						}
					}
					if (!flag2)
					{
						((ServiceModelConfigurationElementCollection<ComMethodElement>)(object)val.get_ExposedMethods()).Add(new ComMethodElement(method));
						flag = true;
					}
				}
				if (((ConfigurationElementCollection)val.get_PersistableTypes()).get_Count() == 0 && Tool.Options.AllowReferences && flag)
				{
					((ConfigurationElementCollection)val.get_PersistableTypes()).set_EmitClear(true);
				}
				return flag;
			}
			catch (FormatException)
			{
			}
		}
		ComContractElement val3 = new ComContractElement(guid.ToString("B").ToUpperInvariant());
		val3.set_Name(name);
		val3.set_Namespace(EndpointConfig.TempURI + guid.ToString().ToUpperInvariant());
		foreach (string method2 in methods)
		{
			((ServiceModelConfigurationElementCollection<ComMethodElement>)(object)val3.get_ExposedMethods()).Add(new ComMethodElement(method2));
		}
		if (((ConfigurationElementCollection)val3.get_PersistableTypes()).get_Count() == 0 && Tool.Options.AllowReferences)
		{
			((ConfigurationElementCollection)val3.get_PersistableTypes()).set_EmitClear(true);
		}
		val3.set_RequiresSession(true);
		((ServiceModelConfigurationElementCollection<ComContractElement>)(object)comContracts).Add(val3);
		return true;
	}

	protected bool IsMetaDataEndpoint(ServiceEndpointElement ee)
	{
		if (ee.get_Contract() == "IMetadataExchange")
		{
			return true;
		}
		return false;
	}

	protected Dictionary<string, List<EndpointConfig>> BaseGetEndpointsFromConfiguration(Configuration config)
	{
		//IL_001c: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		Dictionary<string, List<EndpointConfig>> dictionary = new Dictionary<string, List<EndpointConfig>>();
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		ServiceElementCollection services;
		try
		{
			services = sectionGroup.get_Services().get_Services();
		}
		catch (ConfigurationErrorsException val)
		{
			ConfigurationErrorsException val2 = val;
			ToolConsole.WriteWarning(((Exception)(object)val2).Message);
			ToolConsole.WriteWarning(SR.GetString("ConfigFileSkipped", ((ConfigurationException)val2).get_Filename()));
			return dictionary;
		}
		foreach (ServiceElement item in (ConfigurationElementCollection)services)
		{
			ServiceElement val3 = item;
			string name = val3.get_Name();
			Guid empty = Guid.Empty;
			string[] array = name.Split(new char[1] { ',' });
			if (array.Length != 2)
			{
				continue;
			}
			try
			{
				new Guid(array[0]);
				empty = new Guid(array[1]);
			}
			catch (FormatException)
			{
				continue;
			}
			List<EndpointConfig> list = null;
			list = (dictionary.ContainsKey(name) ? dictionary[name] : (dictionary[name] = new List<EndpointConfig>()));
			foreach (ServiceEndpointElement item2 in (ConfigurationElementCollection)val3.get_Endpoints())
			{
				ServiceEndpointElement val4 = item2;
				EndpointConfig endpointConfig = null;
				if (!IsMetaDataEndpoint(val4))
				{
					Guid iid;
					try
					{
						iid = new Guid(val4.get_Contract());
					}
					catch (FormatException)
					{
						continue;
					}
					endpointConfig = new EndpointConfig(Guid.Empty, empty, iid, val4.get_Binding(), val4.get_BindingConfiguration(), val4.get_Address(), isMexEndpoint: false, new List<string>());
				}
				else
				{
					endpointConfig = new EndpointConfig(Guid.Empty, empty, typeof(IMetadataExchange).GUID, val4.get_Binding(), val4.get_BindingConfiguration(), val4.get_Address(), isMexEndpoint: true, new List<string>());
				}
				list.Add(endpointConfig);
			}
		}
		return dictionary;
	}

	protected bool RemoveAllServicesForContract(Configuration config, string interfaceID)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		ServiceElementCollection services = sectionGroup.get_Services().get_Services();
		bool result = false;
		ServiceElementCollection val = new ServiceElementCollection();
		foreach (ServiceElement item in (ConfigurationElementCollection)services)
		{
			ServiceElement val2 = item;
			ServiceEndpointElementCollection val3 = new ServiceEndpointElementCollection();
			foreach (ServiceEndpointElement item2 in (ConfigurationElementCollection)val2.get_Endpoints())
			{
				ServiceEndpointElement val4 = item2;
				if (interfaceID.ToUpperInvariant() == val4.get_Contract().ToUpperInvariant())
				{
					result = true;
					((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val3).Add(val4);
				}
			}
			foreach (ServiceEndpointElement item3 in (ConfigurationElementCollection)val3)
			{
				ServiceEndpointElement val5 = item3;
				((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val2.get_Endpoints()).Remove(val5);
				if (((ConfigurationElementCollection)val2.get_Endpoints()).get_Count() == 1 && ((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val2.get_Endpoints()).get_Item(0).get_Contract() == "IMetadataExchange")
				{
					((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val2.get_Endpoints()).Remove(((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val2.get_Endpoints()).get_Item(0));
				}
				if (((ConfigurationElementCollection)val2.get_Endpoints()).get_Count() == 0)
				{
					((ServiceModelConfigurationElementCollection<ServiceElement>)(object)val).Add(val2);
				}
			}
		}
		foreach (ServiceElement item4 in (ConfigurationElementCollection)val)
		{
			ServiceElement val6 = item4;
			((ServiceModelConfigurationElementCollection<ServiceElement>)(object)sectionGroup.get_Services().get_Services()).Remove(val6);
		}
		if (((ConfigurationElementCollection)services).get_Count() == 0)
		{
			EnsureComMetaDataExchangeBehaviorRemoved(config);
			RemoveBinding(config);
		}
		return result;
	}

	protected bool RemoveEndpointFromServiceOnly(Configuration config, EndpointConfig endpointConfig)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		ServiceElementCollection services = sectionGroup.get_Services().get_Services();
		ServiceElement val = null;
		foreach (ServiceElement item in (ConfigurationElementCollection)services)
		{
			ServiceElement val2 = item;
			if (endpointConfig.MatchServiceType(val2.get_Name()))
			{
				val = val2;
				break;
			}
		}
		if (val == null)
		{
			return false;
		}
		foreach (ServiceEndpointElement item2 in (ConfigurationElementCollection)val.get_Endpoints())
		{
			ServiceEndpointElement val3 = item2;
			if (!endpointConfig.MatchContract(val3.get_Contract()) || !(val3.get_Address() == endpointConfig.Address))
			{
				continue;
			}
			((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val.get_Endpoints()).Remove(val3);
			if (!endpointConfig.IsMexEndpoint)
			{
				RemoveComContractIfNotUsedByAnyService(config, val3.get_Contract());
			}
			if (((ConfigurationElementCollection)val.get_Endpoints()).get_Count() == 1 && ((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val.get_Endpoints()).get_Item(0).get_Contract() == "IMetadataExchange")
			{
				((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val.get_Endpoints()).Remove(((ServiceModelConfigurationElementCollection<ServiceEndpointElement>)(object)val.get_Endpoints()).get_Item(0));
			}
			if (((ConfigurationElementCollection)val.get_Endpoints()).get_Count() == 0)
			{
				((ServiceModelConfigurationElementCollection<ServiceElement>)(object)services).Remove(val);
				if (((ConfigurationElementCollection)services).get_Count() == 0)
				{
					EnsureComMetaDataExchangeBehaviorRemoved(config);
					RemoveBinding(config);
				}
			}
			return true;
		}
		return false;
	}

	protected bool BaseRemoveEndpointConfig(Configuration config, EndpointConfig endpointConfig)
	{
		if (endpointConfig.Methods != null && !endpointConfig.IsMexEndpoint)
		{
			if (RemoveComContractMethods(config, endpointConfig.Iid.ToString("B"), endpointConfig.Methods))
			{
				RemoveAllServicesForContract(config, endpointConfig.Iid.ToString("B"));
			}
			return true;
		}
		return RemoveEndpointFromServiceOnly(config, endpointConfig);
	}

	protected Configuration GetConfigurationFromFile(string fileName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ExeConfigurationFileMap val = new ExeConfigurationFileMap();
		Configuration val2 = ConfigurationManager.OpenMachineConfiguration();
		((ConfigurationFileMap)val).set_MachineConfigFilename(val2.get_FilePath());
		val.set_ExeConfigFilename(fileName);
		if (!IsValidRuntime(fileName))
		{
			string imageRuntimeVersion = Assembly.GetExecutingAssembly().ImageRuntimeVersion;
			ToolConsole.WriteError(SR.GetString("InvalidRuntime", imageRuntimeVersion), "");
			throw Tool.CreateException(SR.GetString("OperationAbortedDuetoClrVersion"), null);
		}
		return ConfigurationManager.OpenMappedExeConfiguration(val, (ConfigurationUserLevel)0);
	}

	protected void EnsureComMetaDataExchangeBehaviorAdded(Configuration config)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		if (!((ServiceModelConfigurationElementCollection<ServiceBehaviorElement>)(object)sectionGroup.get_Behaviors().get_ServiceBehaviors()).ContainsKey((object)"ComServiceMexBehavior"))
		{
			ServiceBehaviorElement val = new ServiceBehaviorElement("ComServiceMexBehavior");
			((ServiceModelConfigurationElementCollection<ServiceBehaviorElement>)(object)sectionGroup.get_Behaviors().get_ServiceBehaviors()).Add(val);
			ServiceMetadataPublishingElement val2 = new ServiceMetadataPublishingElement();
			if (Tool.Options.Hosting != Hosting.Complus && Tool.Options.Hosting != 0)
			{
				val2.set_HttpGetEnabled(true);
			}
			else
			{
				val2.set_HttpGetEnabled(false);
			}
			((ServiceModelExtensionCollectionElement<BehaviorExtensionElement>)(object)val).Add((BehaviorExtensionElement)(object)val2);
			ServiceDebugElement val3 = new ServiceDebugElement();
			val3.set_IncludeExceptionDetailInFaults(false);
			((ServiceModelExtensionCollectionElement<BehaviorExtensionElement>)(object)val).Add((BehaviorExtensionElement)(object)val3);
		}
	}

	protected void EnsureComMetaDataExchangeBehaviorRemoved(Configuration config)
	{
		ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(config);
		if (((ServiceModelConfigurationElementCollection<ServiceBehaviorElement>)(object)sectionGroup.get_Behaviors().get_ServiceBehaviors()).ContainsKey((object)"ComServiceMexBehavior"))
		{
			ServiceBehaviorElement val = ((ServiceModelConfigurationElementCollection<ServiceBehaviorElement>)(object)sectionGroup.get_Behaviors().get_ServiceBehaviors()).get_Item((object)"ComServiceMexBehavior");
			((ServiceModelConfigurationElementCollection<ServiceBehaviorElement>)(object)sectionGroup.get_Behaviors().get_ServiceBehaviors()).Remove(val);
		}
	}

	internal static bool IsValidVersion(string version)
	{
		if (string.IsNullOrEmpty(version))
		{
			return false;
		}
		return version == Assembly.GetExecutingAssembly().ImageRuntimeVersion;
	}

	public static bool IsValidRuntime(string fileName)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			return true;
		}
		if (!File.Exists(fileName))
		{
			return true;
		}
		XmlNode xmlNode = null;
		XmlNodeList xmlNodeList = null;
		XmlNode xmlNode2 = null;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(fileName);
		xmlNode = xmlDocument.DocumentElement!.SelectSingleNode("startup");
		bool result = true;
		if (xmlNode != null)
		{
			xmlNodeList = xmlNode.SelectNodes("supportedRuntime");
			if (xmlNodeList != null)
			{
				result = ((xmlNodeList.Count == 0) ? true : false);
				foreach (XmlNode item in xmlNodeList)
				{
					if (IsValidVersion(item.Attributes!.GetNamedItem("version")!.Value))
					{
						result = true;
					}
				}
			}
			xmlNode2 = xmlNode.SelectSingleNode("requiredRuntime");
			if (xmlNode2 != null)
			{
				string value = xmlNode2.Attributes!.GetNamedItem("version")!.Value;
				if (!IsValidVersion(value))
				{
					result = false;
				}
			}
		}
		return result;
	}
}
