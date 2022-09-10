using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class ComAdminAppInfo
{
	private string appdir;

	private Guid appid;

	private string appname;

	private bool serverActivated;

	private bool systemApplication;

	private bool processPooled;

	private bool automaticRecycling;

	private bool listenerExists;

	private List<ComAdminClassInfo> classes;

	private RuntimeVersions runtimeVersion;

	private static Guid CLSID_CLRMetaHost = new Guid("{9280188d-0e8e-4867-b30c-7fa83884e8de}");

	private static Guid CLSID_ServiceInitializer = new Guid("{59856830-3ECB-4D29-9CFE-DDD0F74B96A2}");

	private static List<Version> CLRVersions = new List<Version>(2)
	{
		new Version("2.0"),
		new Version("4.0")
	};

	public string ApplicationDirectory => appdir;

	public Guid ID => appid;

	public string Name => appname;

	public List<ComAdminClassInfo> Classes => classes;

	public bool IsServerActivated => serverActivated;

	public bool IsSystemApplication => systemApplication;

	public bool IsProcessPooled => processPooled;

	public bool IsAutomaticRecycling => automaticRecycling;

	public bool ListenerExists => listenerExists;

	public RuntimeVersions RuntimeVersion => runtimeVersion;

	public ComAdminAppInfo(ICatalogObject appObj, ICatalogCollection appColl)
	{
		appid = new Guid((string)appObj.Key());
		appname = (string)appObj.Name();
		appdir = (string)appObj.GetValue(PropertyName.ApplicationDirectory);
		serverActivated = (int)appObj.GetValue(PropertyName.Activation) == 1;
		systemApplication = (bool)appObj.GetValue(PropertyName.IsSystem);
		processPooled = (int)appObj.GetValue(PropertyName.ConcurrentApps) > 1;
		automaticRecycling = (int)appObj.GetValue(PropertyName.RecycleActivationLimit) > 0 || (int)appObj.GetValue(PropertyName.RecycleCallLimit) > 0 || (int)appObj.GetValue(PropertyName.RecycleLifetimeLimit) > 0 || (int)appObj.GetValue(PropertyName.RecycleMemoryLimit) > 0;
		BuildClasses(appObj, appColl);
	}

	private bool TryGetVersionFromString(StringBuilder versionStr, out Version version)
	{
		bool result = false;
		version = null;
		string version2;
		if (versionStr[0] != 'v' && versionStr[0] != 'V')
		{
			version2 = versionStr.ToString();
		}
		else
		{
			int num = versionStr.Length - 1;
			version2 = versionStr.ToString(1, num);
		}
		try
		{
			version = new Version(version2);
			result = true;
			return result;
		}
		catch (ArgumentException)
		{
			return result;
		}
		catch (FormatException)
		{
			return result;
		}
		catch (OverflowException)
		{
			return result;
		}
	}

	private bool IsCLRVersionInstalled(Version clrVersion)
	{
		bool flag = false;
		if (SafeNativeMethods.CLRCreateInstance(CLSID_CLRMetaHost, typeof(IClrMetaHost).GUID, out var pMetaHost) == 0)
		{
			IClrMetaHost clrMetaHost = (IClrMetaHost)pMetaHost;
			IEnumUnknown enumUnknown = clrMetaHost.EnumerateInstalledRuntimes();
			object[] array = new object[1];
			int fetchedElementCount;
			while (enumUnknown.Next(1, array, out fetchedElementCount) == 0 && !flag)
			{
				int bufferLength = 256;
				StringBuilder stringBuilder = new StringBuilder(256);
				IClrRuntimeInfo clrRuntimeInfo = (IClrRuntimeInfo)array[0];
				clrRuntimeInfo.GetVersionString(stringBuilder, ref bufferLength);
				if (TryGetVersionFromString(stringBuilder, out var version) && clrVersion.Major == version.Major && clrVersion.Minor == version.Minor)
				{
					flag = true;
				}
			}
		}
		return flag;
	}

	private bool ValidateCLRVersion(Version clrVersion)
	{
		foreach (Version cLRVersion in CLRVersions)
		{
			if (clrVersion.Major == cLRVersion.Major && clrVersion.Minor == cLRVersion.Minor)
			{
				return true;
			}
		}
		return false;
	}

	private void BuildClasses(ICatalogObject appObj, ICatalogCollection appColl)
	{
		int cchBuffer = 256;
		StringBuilder stringBuilder = new StringBuilder(256);
		bool flag = false;
		bool flag2 = true;
		int dwLength = 0;
		Version version = null;
		classes = new List<ComAdminClassInfo>();
		ICatalogCollection catalogCollection = (ICatalogCollection)appColl.GetCollection(CollectionName.Components, appObj.Key());
		catalogCollection.Populate();
		for (int i = 0; i < catalogCollection.Count(); i++)
		{
			ICatalogObject compObj = (ICatalogObject)catalogCollection.Item(i);
			ComAdminClassInfo comAdminClassInfo = new ComAdminClassInfo(compObj, catalogCollection);
			if (!flag && 0 == SafeNativeMethods.GetRequestedRuntimeVersionForCLSID(comAdminClassInfo.Clsid, stringBuilder, cchBuffer, ref dwLength, 0) && TryGetVersionFromString(stringBuilder, out version))
			{
				if (IsCLRVersionInstalled(version))
				{
					flag = true;
				}
				else if (ValidateCLRVersion(version))
				{
					flag = true;
					flag2 = false;
				}
			}
			if (ComAdminWrapper.IsListenerComponent(compObj))
			{
				listenerExists = true;
			}
			else
			{
				classes.Add(comAdminClassInfo);
			}
		}
		if (flag && flag2)
		{
			if (version.Major == 4 && version.Minor == 0)
			{
				runtimeVersion = RuntimeVersions.V40;
				return;
			}
			if (version.Major != 2 || version.Minor != 0)
			{
				throw Tool.CreateException(SR.GetString("FailedToGetRuntime", version.ToString()), null);
			}
			runtimeVersion = RuntimeVersions.V20;
		}
		else
		{
			if (!flag2)
			{
				throw Tool.CreateException(SR.GetString("FailedToGetRuntime", version.ToString()), null);
			}
			runtimeVersion = RuntimeVersions.V40;
		}
	}

	public ComAdminClassInfo FindClass(string classNameOrGuid)
	{
		ComAdminClassInfo comAdminClassInfo = null;
		classNameOrGuid = classNameOrGuid.ToLowerInvariant();
		foreach (ComAdminClassInfo @class in classes)
		{
			if (@class.Clsid.ToString("B").ToLowerInvariant() == classNameOrGuid || @class.Name.ToLowerInvariant() == classNameOrGuid)
			{
				if (comAdminClassInfo != null)
				{
					throw Tool.CreateException(SR.GetString("AmbiguousComponentName", classNameOrGuid), null);
				}
				comAdminClassInfo = @class;
			}
		}
		return comAdminClassInfo;
	}
}
