using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.ServiceModel.Channels;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal static class ComAdminWrapper
{
	private const string ListenerWSUName = "ServiceModelInitializer";

	internal const string Wcf30RegistryKey = "SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.0\\Setup\\Windows Communication Foundation";

	internal const string Runtime30InstallPathName = "RuntimeInstallPath";

	private const string fileName = "ServiceMonikerSupport.dll";

	private static readonly string ListenerApplicationName = SR.GetString("WebServiceAppName");

	private static Assembly ListenerAssembly = typeof(Message).Assembly;

	private static string ListenerComponentDescription = SR.GetString("ListenerCompDescription");

	private static bool FindApplication(string appidOrName, out ICatalogObject targetAppObj, out ICatalogCollection appColl)
	{
		targetAppObj = null;
		appColl = null;
		bool flag = false;
		ICatalog2 catalog = GetCatalog();
		string text = null;
		text = GetPartitionIdForApplication(catalog, appidOrName, notThrow: true);
		if (!string.IsNullOrEmpty(text))
		{
			SetCurrentPartition(catalog, text);
		}
		appColl = (ICatalogCollection)catalog.GetCollection(CollectionName.Applications);
		appColl.Populate();
		for (int i = 0; i < appColl.Count(); i++)
		{
			ICatalogObject catalogObject = (ICatalogObject)appColl.Item(i);
			string text2 = ((string)catalogObject.Key()).ToLowerInvariant();
			string text3 = ((string)catalogObject.Name()).ToLowerInvariant();
			appidOrName = appidOrName.ToLowerInvariant();
			if (!flag)
			{
				if (appidOrName == text2 || appidOrName == text3)
				{
					flag = true;
					targetAppObj = catalogObject;
				}
			}
			else if (appidOrName == text2 || appidOrName == text3)
			{
				throw Tool.CreateException(SR.GetString("AmbiguousApplicationName", appidOrName), null);
			}
		}
		return flag;
	}

	private static bool FindListener(Guid appid, out Guid clsid, out string progid)
	{
		clsid = Guid.Empty;
		progid = null;
		ICatalogObject targetAppObj = null;
		ICatalogCollection appColl = null;
		if (!FindApplication(appid.ToString("B"), out targetAppObj, out appColl))
		{
			throw Tool.CreateException(SR.GetString("ApplicationNotFound", appid.ToString("B")), null);
		}
		ICatalogCollection catalogCollection = (ICatalogCollection)appColl.GetCollection(CollectionName.Components, targetAppObj.Key());
		catalogCollection.Populate();
		int num = 0;
		ICatalogObject catalogObject;
		while (true)
		{
			if (num < catalogCollection.Count())
			{
				catalogObject = (ICatalogObject)catalogCollection.Item(num);
				if (IsListenerComponent(catalogObject))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		clsid = new Guid((string)catalogObject.Key());
		progid = (string)catalogObject.Name();
		return true;
	}

	private static bool SetComponentProperty(string appIdOrName, string compIdOrName, string property, object value)
	{
		ICatalogObject targetAppObj = null;
		ICatalogCollection appColl = null;
		if (!FindApplication(appIdOrName, out targetAppObj, out appColl))
		{
			throw Tool.CreateException(SR.GetString("ApplicationNotFound", appIdOrName), null);
		}
		ICatalogCollection catalogCollection = (ICatalogCollection)appColl.GetCollection(CollectionName.Components, targetAppObj.Key());
		catalogCollection.Populate();
		compIdOrName = compIdOrName.ToLowerInvariant();
		int num = 0;
		ICatalogObject catalogObject;
		while (true)
		{
			if (num < catalogCollection.Count())
			{
				catalogObject = (ICatalogObject)catalogCollection.Item(num);
				string text = ((string)catalogObject.Name()).ToLowerInvariant();
				string text2 = ((string)catalogObject.Key()).ToLowerInvariant();
				if (text == compIdOrName || text2 == compIdOrName)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		catalogObject.SetValue(property, value);
		catalogCollection.SaveChanges();
		return true;
	}

	public static ComAdminAppInfo GetAppInfo(string appidOrName)
	{
		ICatalogObject targetAppObj = null;
		ICatalogCollection appColl = null;
		if (!FindApplication(appidOrName, out targetAppObj, out appColl))
		{
			return null;
		}
		ComAdminAppInfo result = null;
		try
		{
			result = new ComAdminAppInfo(targetAppObj, appColl);
			return result;
		}
		catch (COMException ex)
		{
			ToolConsole.WriteWarning(SR.GetString("FailedToFetchApplicationInformationFromCatalog", appidOrName, ex.ErrorCode, ex.Message));
			return result;
		}
	}

	public static Guid[] GetApplicationIds()
	{
		ICatalog2 catalog = GetCatalog();
		List<Guid> list = new List<Guid>();
		ICatalogCollection catalogCollection = (ICatalogCollection)catalog.GetCollection(CollectionName.Partitions);
		catalogCollection.Populate();
		for (int i = 0; i < catalogCollection.Count(); i++)
		{
			ICatalogObject catalogObject = (ICatalogObject)catalogCollection.Item(i);
			ICatalogCollection catalogCollection2 = (ICatalogCollection)catalogCollection.GetCollection(CollectionName.Applications, catalogObject.Key());
			catalogCollection2.Populate();
			for (int j = 0; j < catalogCollection2.Count(); j++)
			{
				ICatalogObject catalogObject2 = (ICatalogObject)catalogCollection2.Item(j);
				list.Add(new Guid((string)catalogObject2.Key()));
			}
		}
		return list.ToArray();
	}

	private static ICatalog2 GetCatalog()
	{
		return (ICatalog2)new xCatalog();
	}

	public static string GetPartitionIdForApplication(Guid appId)
	{
		ICatalog2 catalog = GetCatalog();
		return GetPartitionIdForApplication(catalog, appId.ToString("B"), notThrow: true);
	}

	public static string GetGlobalPartitionID()
	{
		ICatalog2 catalog = GetCatalog();
		return catalog.GlobalPartitionID();
	}

	private static string GetPartitionIdForApplication(ICatalog2 catalog, string appId, bool notThrow)
	{
		string text = null;
		try
		{
			return catalog.GetPartitionID(appId);
		}
		catch (COMException ex)
		{
			if (!notThrow)
			{
				throw Tool.CreateException(SR.GetString("CouldNotGetPartition"), ex);
			}
			if (ex.ErrorCode == HR.COMADMIN_E_OBJECT_DOES_NOT_EXIST)
			{
				ToolConsole.WriteWarning(SR.GetString("ApplicationNotFound", appId));
			}
			else
			{
				ToolConsole.WriteWarning(SR.GetString("CouldnotGetPartitionForApplication", appId, ex.ErrorCode, ex.Message));
			}
			return null;
		}
	}

	public static bool GetApplicationBitness(ICatalog2 catalog, string partitionID, string applicationID)
	{
		ICatalogCollection catalogCollection = (ICatalogCollection)catalog.GetCollection(CollectionName.Partitions);
		ICatalogCollection catalogCollection2 = (ICatalogCollection)catalogCollection.GetCollection(CollectionName.Applications, partitionID);
		catalogCollection2.Populate();
		ICatalogCollection catalogCollection3 = (ICatalogCollection)catalogCollection2.GetCollection(CollectionName.Components, applicationID);
		try
		{
			catalogCollection3.Populate();
		}
		catch (Exception ex)
		{
			if (!(ex is NullReferenceException) && !(ex is SEHException))
			{
				throw Tool.CreateException(SR.GetString("FailedToDetermineTheBitnessOfApplication", applicationID), ex);
			}
			throw ex;
		}
		ICatalogObject component = (ICatalogObject)catalogCollection3.Item(0);
		return IsBitness64bit(component);
	}

	public static string GetAppropriateBitnessModuleModulePath(bool is64bit, RuntimeVersions runtimeVersion)
	{
		if (RuntimeVersions.V40 == runtimeVersion)
		{
			using (RegistryHandle registryHandle = RegistryHandle.GetCorrectBitnessHKLMSubkey(is64bit, "SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Client"))
			{
				string stringValue = registryHandle.GetStringValue("InstallPath");
				char[] trimChars = new char[1];
				return stringValue.TrimEnd(trimChars) + "\\ServiceMonikerSupport.dll";
			}
		}
		RegistryHandle regHandle = null;
		try
		{
			if (RegistryHandle.TryGetCorrectBitnessHKLMSubkey(is64bit, "SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.0\\Setup\\Windows Communication Foundation", out regHandle) != 0)
			{
				throw Tool.CreateException(SR.GetString("FailedToGetRegistryKey", "SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.0\\Setup\\Windows Communication Foundation", "3.0"), null);
			}
			string stringValue2 = regHandle.GetStringValue("RuntimeInstallPath");
			char[] trimChars2 = new char[1];
			return stringValue2.TrimEnd(trimChars2) + "\\ServiceMonikerSupport.dll";
		}
		finally
		{
			regHandle?.Dispose();
		}
	}

	public static void CreateTypeLib(string fileName, Guid clsid)
	{
		try
		{
			ICreateTypeLib createTypeLib = SafeNativeMethods.CreateTypeLib(fileName);
			createTypeLib.SetGuid(Guid.NewGuid());
			createTypeLib.SetName("ServiceModelInitializer");
			createTypeLib.SetDocString("ServiceModelInitializer");
			ICreateTypeInfo createTypeInfo = createTypeLib.CreateTypeInfo("ServiceModelInitializer", TYPEKIND.TKIND_COCLASS);
			createTypeInfo.SetGuid(clsid);
			createTypeInfo.SetDocString("ServiceModelInitializer");
			ICreateTypeInfo2 createTypeInfo2 = (ICreateTypeInfo2)createTypeInfo;
			createTypeInfo2.SetName("ServiceModelInitializerComponent");
			createTypeInfo2.SetTypeFlags(2);
			createTypeInfo.LayOut();
			createTypeLib.SaveAllChanges();
		}
		catch (Exception ex)
		{
			if (!(ex is NullReferenceException) && !(ex is SEHException))
			{
				throw Tool.CreateException(SR.GetString("FailedToCreateTypeLibrary"), ex);
			}
			throw ex;
		}
	}

	public static void CreateRegistryKey(bool is64bit, Guid clsid, string module)
	{
		using RegistryHandle registryHandle = RegistryHandle.GetBitnessHKCR(is64bit);
		using RegistryHandle registryHandle2 = registryHandle.CreateSubKey("clsid\\" + clsid.ToString("B"));
		registryHandle2.SetValue("", "ServiceModelInitializer");
		using (RegistryHandle registryHandle3 = registryHandle2.CreateSubKey("InprocServer32"))
		{
			registryHandle3.SetValue("", module);
			registryHandle3.SetValue("ThreadingModel", "Both");
		}
		using RegistryHandle registryHandle4 = registryHandle2.CreateSubKey("ProgID");
		registryHandle4.SetValue("", "ServiceModelInitializer");
	}

	public static bool IsApplicationWow(Guid appid)
	{
		if (IntPtr.Size == 8)
		{
			string text = appid.ToString("B");
			string text2 = null;
			ICatalog2 catalog = GetCatalog();
			text2 = GetPartitionIdForApplication(catalog, text, notThrow: false);
			return !GetApplicationBitness(catalog, text2, text);
		}
		return false;
	}

	public static void InstallListener(Guid appid, string path, RuntimeVersions runtimeVersion)
	{
		string text = appid.ToString("B");
		string text2 = null;
		ICatalog2 catalog = GetCatalog();
		text2 = GetPartitionIdForApplication(catalog, text, notThrow: false);
		bool applicationBitness = GetApplicationBitness(catalog, text2, text);
		Guid clsid = Guid.NewGuid();
		string text3 = clsid.ToString("B");
		string bstrTLB = Path.Combine(path, text + "." + text3 + ".tlb");
		try
		{
			AtomicFile.SafeDeleteFile(bstrTLB);
			string appropriateBitnessModuleModulePath = GetAppropriateBitnessModuleModulePath(applicationBitness, runtimeVersion);
			if (string.IsNullOrEmpty(appropriateBitnessModuleModulePath))
			{
				throw Tool.CreateException(SR.GetString("CannotFindServiceInitializerModuleInRegistry"), null);
			}
			CreateTypeLib(bstrTLB, clsid);
			CreateRegistryKey(applicationBitness, clsid, appropriateBitnessModuleModulePath);
			catalog.InstallComponent(text, appropriateBitnessModuleModulePath, bstrTLB, null);
			MarkComponentAsPrivate(catalog, text2, text, "ServiceModelInitializer");
			if (!SetComponentProperty(text, "ServiceModelInitializer", PropertyName.Description, ListenerComponentDescription))
			{
				ToolConsole.WriteWarning(SR.GetString("CannotSetComponentDescription", text3, appid.ToString("B")));
			}
			if (!SetComponentProperty(text, "ServiceModelInitializer", PropertyName.InitializesServerApplication, "1"))
			{
				ToolConsole.WriteWarning(SR.GetString("CannotSetComponentInitializerProperty", "ServiceModelInitializer", appid.ToString("B")));
			}
			if (!SetComponentProperty(text, "ServiceModelInitializer", PropertyName.ComponentAccessChecksEnabled, "0"))
			{
				ToolConsole.WriteWarning(SR.GetString("CannotDisableAccessChecksOnInitializer", "ServiceModelInitializer", appid.ToString("B")));
			}
		}
		catch (Exception ex)
		{
			if (!(ex is NullReferenceException) && !(ex is SEHException))
			{
				throw Tool.CreateException(SR.GetString("CouldNotInstallListener"), ex);
			}
			throw ex;
		}
		finally
		{
			AtomicFile.SafeDeleteFile(bstrTLB);
		}
	}

	private static void MarkComponentAsPrivate(ICatalog2 catalog, string partitionID, string applicationID, string progid)
	{
		ICatalogCollection catalogCollection = (ICatalogCollection)catalog.GetCollection(CollectionName.Partitions);
		ICatalogCollection catalogCollection2 = (ICatalogCollection)catalogCollection.GetCollection(CollectionName.Applications, partitionID);
		catalogCollection2.Populate();
		ICatalogCollection catalogCollection3 = (ICatalogCollection)catalogCollection2.GetCollection(CollectionName.Components, applicationID);
		try
		{
			catalogCollection3.Populate();
			int num = 0;
			ICatalogObject catalogObject;
			while (true)
			{
				if (num < catalogCollection3.Count())
				{
					catalogObject = (ICatalogObject)catalogCollection3.Item(num);
					if ((string)catalogObject.Name() == progid)
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			catalogObject.SetValue(PropertyName.IsPrivateComponent, true);
			catalogCollection3.SaveChanges();
		}
		catch (Exception ex)
		{
			if (ex is NullReferenceException || ex is SEHException)
			{
				throw ex;
			}
			ToolConsole.WriteWarning(SR.GetString("FailedToMarkListenerComponentAsPrivateForApplication", progid, applicationID));
		}
	}

	private static bool IsBitness64bit(ICatalogObject component)
	{
		int num = (int)component.GetValue(PropertyName.Bitness);
		if (num == 1)
		{
			return false;
		}
		return true;
	}

	internal static bool IsListenerComponent(ICatalogObject compObj)
	{
		string text = (string)compObj.Name();
		if (text.ToUpperInvariant() == "ServiceModelInitializer".ToUpperInvariant())
		{
			return true;
		}
		return false;
	}

	private static void RemoveClsidFromRegistry(bool is64bit, string clsid)
	{
		RegistryHandle bitnessHKCR = RegistryHandle.GetBitnessHKCR(is64bit);
		string text = "Clsid\\" + clsid;
		bitnessHKCR.DeleteKey(text + "\\InprocServer32");
		bitnessHKCR.DeleteKey(text + "\\ProgID");
		bitnessHKCR.DeleteKey(text);
	}

	private static bool RemoveComponent(ICatalog2 catalog, string partitionId, string applicationId, string progid)
	{
		int num = -1;
		ICatalogCollection catalogCollection = (ICatalogCollection)catalog.GetCollection(CollectionName.Partitions);
		catalogCollection.Populate();
		ICatalogCollection catalogCollection2 = (ICatalogCollection)catalogCollection.GetCollection(CollectionName.Applications, partitionId);
		catalogCollection2.Populate();
		ICatalogCollection catalogCollection3 = (ICatalogCollection)catalogCollection2.GetCollection(CollectionName.Components, applicationId);
		try
		{
			catalogCollection3.Populate();
			bool is64bit = false;
			string clsid = null;
			for (int i = 0; i < catalogCollection3.Count(); i++)
			{
				ICatalogObject catalogObject = (ICatalogObject)catalogCollection3.Item(i);
				if (((string)catalogObject.Name()).ToLowerInvariant() == progid.ToLowerInvariant())
				{
					clsid = ((string)catalogObject.Key()).ToLowerInvariant();
					is64bit = IsBitness64bit(catalogObject);
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			catalogCollection3.Remove(num);
			catalogCollection3.SaveChanges();
			RemoveClsidFromRegistry(is64bit, clsid);
		}
		catch (Exception ex)
		{
			if (ex is NullReferenceException || ex is SEHException)
			{
				throw ex;
			}
			ToolConsole.WriteWarning(SR.GetString("FailedToRemoveListenerComponentFromApplication", applicationId, progid));
		}
		return true;
	}

	public static bool RemoveListener(Guid appid)
	{
		string text = appid.ToString("B");
		string text2 = null;
		ICatalog2 catalog = GetCatalog();
		text2 = GetPartitionIdForApplication(catalog, text, notThrow: false);
		GetApplicationBitness(catalog, text2, text);
		if (FindListener(appid, out var _, out var progid))
		{
			return RemoveComponent(catalog, text2, text, progid);
		}
		return false;
	}

	public static bool ResolveApplicationId(string appidOrName, out Guid appId)
	{
		ICatalogObject targetAppObj = null;
		ICatalogCollection appColl = null;
		appId = Guid.Empty;
		if (!FindApplication(appidOrName, out targetAppObj, out appColl))
		{
			return false;
		}
		appId = new Guid((string)targetAppObj.Key());
		return true;
	}

	private static void SetCurrentPartition(ICatalog2 catalog, string partitionId)
	{
		try
		{
			catalog.CurrentPartition(partitionId);
		}
		catch (Exception ex)
		{
			if (!(ex is NullReferenceException) && !(ex is SEHException))
			{
				throw Tool.CreateException(SR.GetString("CouldNotSetPartition"), ex);
			}
			throw ex;
		}
	}

	public static void SetAppDir(string appidOrName, string path)
	{
		ICatalogObject targetAppObj = null;
		ICatalogCollection appColl = null;
		if (!FindApplication(appidOrName, out targetAppObj, out appColl))
		{
			throw Tool.CreateException(SR.GetString("ApplicationNotFound", appidOrName), null);
		}
		targetAppObj.SetValue(PropertyName.ApplicationDirectory, path);
		appColl.SaveChanges();
	}
}
