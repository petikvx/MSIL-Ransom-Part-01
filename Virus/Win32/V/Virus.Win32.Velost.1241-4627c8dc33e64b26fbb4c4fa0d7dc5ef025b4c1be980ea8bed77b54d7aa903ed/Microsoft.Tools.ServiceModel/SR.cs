using System.Globalization;
using System.Resources;
using System.Threading;

namespace Microsoft.Tools.ServiceModel;

internal sealed class SR
{
	internal const string Logo = "Logo";

	internal const string HelpUsage1 = "HelpUsage1";

	internal const string HelpUsage2 = "HelpUsage2";

	internal const string HelpUsage3 = "HelpUsage3";

	internal const string HelpUsage4 = "HelpUsage4";

	internal const string HelpUsage5 = "HelpUsage5";

	internal const string HelpUsage6 = "HelpUsage6";

	internal const string HelpUsage7 = "HelpUsage7";

	internal const string HelpUsage8 = "HelpUsage8";

	internal const string HelpUsageApplication = "HelpUsageApplication";

	internal const string HelpUsageHosting = "HelpUsageHosting";

	internal const string HelpUsageInterface = "HelpUsageInterface";

	internal const string HelpUsageReferences = "HelpUsageReferences";

	internal const string HelpUsageNoLogo = "HelpUsageNoLogo";

	internal const string HelpUsageVerbose = "HelpUsageVerbose";

	internal const string HelpUsageWebDirectory = "HelpUsageWebDirectory";

	internal const string HelpUsageWebServer = "HelpUsageWebServer";

	internal const string HelpUsageXmlOption = "HelpUsageXmlOption";

	internal const string HelpUsageGuidOption = "HelpUsageGuidOption";

	internal const string HelpUsageMexOption = "HelpUsageMexOption";

	internal const string HelpUsageExamples = "HelpUsageExamples";

	internal const string MoreHelp = "MoreHelp";

	internal const string Error = "Error";

	internal const string Warning = "Warning";

	internal const string UnExpectedError = "UnExpectedError";

	internal const string ErrSwitchMissing = "ErrSwitchMissing";

	internal const string ErrUnexpectedDelimiter = "ErrUnexpectedDelimiter";

	internal const string ErrUnknownSwitch = "ErrUnknownSwitch";

	internal const string ErrSingleUseSwitch = "ErrSingleUseSwitch";

	internal const string ErrExpectedValue = "ErrExpectedValue";

	internal const string ErrUnexpectedValue = "ErrUnexpectedValue";

	internal const string FailedToOpenRegistryKey = "FailedToOpenRegistryKey";

	internal const string FailedToCreateSubKey = "FailedToCreateSubKey";

	internal const string FailedToSetValue = "FailedToSetValue";

	internal const string AutoExportingAssemblyToTyplibrary = "AutoExportingAssemblyToTyplibrary";

	internal const string UnableToDetermineHiveBitness = "UnableToDetermineHiveBitness";

	internal const string ModeArgumentMissing = "ModeArgumentMissing";

	internal const string MultipleModeArguments = "MultipleModeArguments";

	internal const string UnknownHostingSpecified = "UnknownHostingSpecified";

	internal const string ArgumentRequired = "ArgumentRequired";

	internal const string InvalidArgumentForHostingMode = "InvalidArgumentForHostingMode";

	internal const string ExclusiveOptionsSpecified = "ExclusiveOptionsSpecified";

	internal const string AllInterfacesAlreadySelected = "AllInterfacesAlreadySelected";

	internal const string InterfaceAlreadySelected = "InterfaceAlreadySelected";

	internal const string CannotSpecifyAllInterfaces = "CannotSpecifyAllInterfaces";

	internal const string MalformedInterfaceString = "MalformedInterfaceString";

	internal const string CannotSpecifyInterfaceForAllComponents = "CannotSpecifyInterfaceForAllComponents";

	internal const string IISNotInstalled = "IISNotInstalled";

	internal const string AmbiguousApplicationName = "AmbiguousApplicationName";

	internal const string AmbiguousComponentName = "AmbiguousComponentName";

	internal const string AmbiguousInterfaceName = "AmbiguousInterfaceName";

	internal const string ApplicationNotFound = "ApplicationNotFound";

	internal const string CouldNotGetPartition = "CouldNotGetPartition";

	internal const string CouldNotSetPartition = "CouldNotSetPartition";

	internal const string CouldNotInstallListener = "CouldNotInstallListener";

	internal const string ApplicationDirectoryDoesNotExist = "ApplicationDirectoryDoesNotExist";

	internal const string ShouldRestartApp = "ShouldRestartApp";

	internal const string InterfaceAdded = "InterfaceAdded";

	internal const string InterfaceRemoved = "InterfaceRemoved";

	internal const string WebDirectoryNotFound = "WebDirectoryNotFound";

	internal const string WebDirectoryPathNotFound = "WebDirectoryPathNotFound";

	internal const string DirectoryCreated = "DirectoryCreated";

	internal const string FileCreated = "FileCreated";

	internal const string FileUpdated = "FileUpdated";

	internal const string MexEndpointAdded = "MexEndpointAdded";

	internal const string InterfaceAlreadyExposed = "InterfaceAlreadyExposed";

	internal const string MexEndpointAlreadyExposed = "MexEndpointAlreadyExposed";

	internal const string InterfaceNotExposed = "InterfaceNotExposed";

	internal const string EndpointNotFoundInSvcFile = "EndpointNotFoundInSvcFile";

	internal const string BadlyFormattedSvcFile = "BadlyFormattedSvcFile";

	internal const string BadlyFormattedAppIDOrClsidInSvcFile = "BadlyFormattedAppIDOrClsidInSvcFile";

	internal const string NoneOfConfigsFoundMatchTheCriteriaSpecifiedNothingWillBeRemoved = "NoneOfConfigsFoundMatchTheCriteriaSpecifiedNothingWillBeRemoved";

	internal const string NoneOfTheComponentsSatisfiedTheAddCriteria = "NoneOfTheComponentsSatisfiedTheAddCriteria";

	internal const string NoComponentContainsInterface = "NoComponentContainsInterface";

	internal const string NoneOfTheComponentsSatisfiedTheRemoveCriteria = "NoneOfTheComponentsSatisfiedTheRemoveCriteria";

	internal const string CannotFindComponentInApplicationSkipping = "CannotFindComponentInApplicationSkipping";

	internal const string CannotFindInterfaceInCatalogForComponentSkipping = "CannotFindInterfaceInCatalogForComponentSkipping";

	internal const string NoneOfTheSpecifiedInterfacesForComponentWereFoundSkipping = "NoneOfTheSpecifiedInterfacesForComponentWereFoundSkipping";

	internal const string CannotExposePrivateComponentsSkipping = "CannotExposePrivateComponentsSkipping";

	internal const string FailedToFetchApplicationInformationFromCatalog = "FailedToFetchApplicationInformationFromCatalog";

	internal const string CouldnotGetPartitionForApplication = "CouldnotGetPartitionForApplication";

	internal const string CannotGetWebDirectoryPathOnWebDirOfWebServIgnoring = "CannotGetWebDirectoryPathOnWebDirOfWebServIgnoring";

	internal const string SvcFileParsingFailedWithError = "SvcFileParsingFailedWithError";

	internal const string FailedToLoadConfigForApplicationIgnoring = "FailedToLoadConfigForApplicationIgnoring";

	internal const string FailedToLoadConfigForWebDirectoryOnWebSite = "FailedToLoadConfigForWebDirectoryOnWebSite";

	internal const string CannotGetWebServersIgnoringWas = "CannotGetWebServersIgnoringWas";

	internal const string CannotGetWebDirectoryForServer = "CannotGetWebDirectoryForServer";

	internal const string CannotSetComponentDescription = "CannotSetComponentDescription";

	internal const string InterfaceHasNoMethods = "InterfaceHasNoMethods";

	internal const string FailedToMarkListenerComponentAsPrivateForApplication = "FailedToMarkListenerComponentAsPrivateForApplication";

	internal const string FailedToGetComponentCollectionForListenerApplication = "FailedToGetComponentCollectionForListenerApplication";

	internal const string FailedToRemoveListenerComponentFromApplication = "FailedToRemoveListenerComponentFromApplication";

	internal const string FailedToRemoveListenerApplication = "FailedToRemoveListenerApplication";

	internal const string CannotSetComponentInitializerProperty = "CannotSetComponentInitializerProperty";

	internal const string CannotDisableAccessChecksOnInitializer = "CannotDisableAccessChecksOnInitializer";

	internal const string FailedToAbortTransactionWithError = "FailedToAbortTransactionWithError";

	internal const string InvalidConfigFile = "InvalidConfigFile";

	internal const string ConfigFileSkipped = "ConfigFileSkipped";

	internal const string ClassInterfacesNotSupported = "ClassInterfacesNotSupported";

	internal const string FailedToGetRuntime = "FailedToGetRuntime";

	internal const string FailedToGetRegistryKey = "FailedToGetRegistryKey";

	internal const string FailedToGetWow64Directory = "FailedToGetWow64Directory";

	internal const string MexOnlyComponentHasNoExposedInterface = "MexOnlyComponentHasNoExposedInterface";

	internal const string ErrorDuringAdd = "ErrorDuringAdd";

	internal const string ErrorDuringRemove = "ErrorDuringRemove";

	internal const string MustBeAnAdministrator = "MustBeAnAdministrator";

	internal const string LibraryApplicationsNotSupported = "LibraryApplicationsNotSupported";

	internal const string SystemApplicationsNotSupported = "SystemApplicationsNotSupported";

	internal const string ProcessRecyclingNotSupported = "ProcessRecyclingNotSupported";

	internal const string ProcessPoolingNotSupported = "ProcessPoolingNotSupported";

	internal const string TypeResolutionForInterfaceFailed = "TypeResolutionForInterfaceFailed";

	internal const string ParameterOfMethodInInterfaceHasANonCompliantType = "ParameterOfMethodInInterfaceHasANonCompliantType";

	internal const string InvalidWebServiceReturnValue = "InvalidWebServiceReturnValue";

	internal const string HasMarshalAsAttributeOfType = "HasMarshalAsAttributeOfType";

	internal const string CannotBeExportedByDataContractExporter = "CannotBeExportedByDataContractExporter";

	internal const string IsInternalInterfaceAndCannotBeExposedOverWebService = "IsInternalInterfaceAndCannotBeExposedOverWebService";

	internal const string FailedToDetermineTheBitnessOfApplication = "FailedToDetermineTheBitnessOfApplication";

	internal const string FailedToCommitChangesToCatalog = "FailedToCommitChangesToCatalog";

	internal const string CannotFindServiceInitializerModuleInRegistry = "CannotFindServiceInitializerModuleInRegistry";

	internal const string FailedToCreateTypeLibrary = "FailedToCreateTypeLibrary";

	internal const string CannotFindAppInfo = "CannotFindAppInfo";

	internal const string CannotFindClassInfo = "CannotFindClassInfo";

	internal const string CannotFindInterfaceInfo = "CannotFindInterfaceInfo";

	internal const string BadMethodParameter = "BadMethodParameter";

	internal const string NoMethodsSpecifiedInArgument = "NoMethodsSpecifiedInArgument";

	internal const string MethodNotFoundOnInterface = "MethodNotFoundOnInterface";

	internal const string WindowsFunctionalityMissing = "WindowsFunctionalityMissing";

	internal const string InvalidMethod = "InvalidMethod";

	internal const string InvalidInterface = "InvalidInterface";

	internal const string AppIDsDontMatch = "AppIDsDontMatch";

	internal const string InvalidRuntime = "InvalidRuntime";

	internal const string OperationAbortedDuetoClrVersion = "OperationAbortedDuetoClrVersion";

	internal const string InstallInGAC = "InstallInGAC";

	internal const string InvalidArg = "InvalidArg";

	internal const string EnumeratingComponentsForApplication = "EnumeratingComponentsForApplication";

	internal const string EnumeratingInterfacesForComponent = "EnumeratingInterfacesForComponent";

	internal const string EnumeratingEndpointsForInterfaces = "EnumeratingEndpointsForInterfaces";

	internal const string BindingConfigurationName = "BindingConfigurationName";

	internal const string Address = "Address";

	internal const string BindingType = "BindingType";

	internal const string MexEndpointExposed = "MexEndpointExposed";

	internal const string WasHosting = "WasHosting";

	internal const string ComplusHosting = "ComplusHosting";

	internal const string ConfigFileName = "ConfigFileName";

	internal const string WebServiceAppName = "WebServiceAppName";

	internal const string ListenerCompDescription = "ListenerCompDescription";

	private static SR loader;

	private ResourceManager resources;

	private static CultureInfo Culture => null;

	public static ResourceManager Resources => GetLoader().resources;

	internal SR()
	{
		resources = new ResourceManager("Resources", GetType().Assembly);
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			SR value = new SR();
			Interlocked.CompareExchange(ref loader, value, null);
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string @string = sR.resources.GetString(name, Culture);
		if (args != null && args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] is string text && text.Length > 1024)
				{
					args[i] = text.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}
		return @string;
	}

	public static string GetString(string name)
	{
		return GetLoader()?.resources.GetString(name, Culture);
	}

	public static string GetString(string name, out bool usedFallback)
	{
		usedFallback = false;
		return GetString(name);
	}

	public static object GetObject(string name)
	{
		return GetLoader()?.resources.GetObject(name, Culture);
	}
}
