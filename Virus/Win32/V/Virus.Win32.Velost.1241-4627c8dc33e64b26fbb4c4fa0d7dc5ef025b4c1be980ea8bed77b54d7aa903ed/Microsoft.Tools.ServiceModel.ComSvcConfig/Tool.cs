using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ServiceModel.Description;
using System.Threading;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

public static class Tool
{
	private static Options options;

	internal static Options Options => options;

	internal static Exception CreateArgumentException(string command, string arg, string message, Exception innerException)
	{
		return new ArgumentException(SR.GetString("InvalidArg", command, arg, message), innerException);
	}

	internal static Exception CreateException(string message, Exception innerException)
	{
		return new ApplicationException(message, innerException);
	}

	private static void DisplayHelp(Mode mode)
	{
		if (options.Mode == Mode.NotSpecified)
		{
			DisplayUsage();
		}
		else if (options.Mode == Mode.Install)
		{
			ToolConsole.WriteLine(SR.GetString("HelpUsage4", "install", "i"));
			ToolConsole.WriteLine(SR.GetString("HelpUsageExamples"));
			ToolConsole.WriteLine("  ComSvcConfig.exe /install /application:TestApp /contract:* /hosting:complus");
			ToolConsole.WriteLine("  ComSvcConfig.exe /install /application:TestApp /contract:TestComponent,ITest /hosting:was /webDirectory:testdir /mex");
			ToolConsole.WriteLine("  ComSvcConfig.exe /install /application:TestApp /contract:TestComponent,ITest.{Method1} /hosting:was /webDirectory:testdir /mex");
			ToolConsole.WriteLine("  ComSvcConfig.exe /install /application:TestApp /contract:TestComponent,ITest.{Method2,Method3} /hosting:was /webDirectory:testdir /mex");
		}
		else if (options.Mode == Mode.Uninstall)
		{
			ToolConsole.WriteLine(SR.GetString("HelpUsage5", "uninstall", "u"));
			ToolConsole.WriteLine(SR.GetString("HelpUsageExamples"));
			ToolConsole.WriteLine("  ComSvcConfig.exe /uninstall /application:OnlineStore /contract:* /hosting:complus");
			ToolConsole.WriteLine("  ComSvcConfig.exe /uninstall /application:OnlineStore /contract:* /hosting:was /mex");
			ToolConsole.WriteLine("  ComSvcConfig.exe /uninstall /application:OnlineStore /contract:TestComponent,ITest.{Method1} /hosting:was /mex");
			ToolConsole.WriteLine("  ComSvcConfig.exe /uninstall /application:OnlineStore /contract:TestComponent,ITest.{Method2,Method3} /hosting:was /mex");
		}
		else if (options.Mode == Mode.List)
		{
			ToolConsole.WriteLine(SR.GetString("HelpUsage6", "list", "l"));
			ToolConsole.WriteLine(SR.GetString("HelpUsageExamples"));
			ToolConsole.WriteLine("  ComSvcConfig.exe /list");
			ToolConsole.WriteLine("  ComSvcConfig.exe /list /hosting:complus");
			ToolConsole.WriteLine("  ComSvcConfig.exe /list /hosting:was");
		}
	}

	private static void DisplayLogo()
	{
		Console.WriteLine(SR.GetString("Logo", CommonResStrings.WcfTrademarkForCmdLine, "4.0.30319.1", CommonResStrings.CopyrightForCmdLine));
	}

	private static void DisplayUsage()
	{
		ToolConsole.WriteLine(SR.GetString("HelpUsage1"));
		ToolConsole.WriteLine(SR.GetString("HelpUsage2", "ComSvcConfig.exe"));
		ToolConsole.WriteLine(SR.GetString("HelpUsage3"));
		ToolConsole.WriteLine(SR.GetString("HelpUsage4", "install", "i"));
		ToolConsole.WriteLine(SR.GetString("HelpUsage5", "uninstall", "u"));
		ToolConsole.WriteLine(SR.GetString("HelpUsage6", "list", "l"));
		ToolConsole.WriteLine(SR.GetString("HelpUsage7"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageApplication", "application", "a"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageInterface", "contract", "c", "{", "}"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageReferences", "allowreferences", "r"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageHosting", "hosting", "h"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageWebServer", "webSite", "w"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageWebDirectory", "webDirectory", "d"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageMexOption", "mex", "x"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageGuidOption", "id", "k"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageNoLogo", "nologo", "n"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageVerbose", "verbose", "v"));
		ToolConsole.WriteLine(SR.GetString("HelpUsage8", "help"));
		ToolConsole.WriteLine(SR.GetString("HelpUsageExamples"));
		ToolConsole.WriteLine("  ComSvcConfig.exe /install /application:TestApp /contract:* /hosting:complus");
		ToolConsole.WriteLine("  ComSvcConfig.exe /install /application:TestApp /contract:TestComponent,ITest /hosting:was /webDirectory:testdir /mex");
		ToolConsole.WriteLine("  ComSvcConfig.exe /list");
		ToolConsole.WriteLine("  ComSvcConfig.exe /list /hosting:complus");
		ToolConsole.WriteLine("  ComSvcConfig.exe /list /hosting:was");
		ToolConsole.WriteLine("  ComSvcConfig.exe /uninstall /application:OnlineStore /contract:* /hosting:complus");
		ToolConsole.WriteLine("  ComSvcConfig.exe /uninstall /application:OnlineStore /contract:* /hosting:was");
		ToolConsole.WriteLine("");
	}

	private static void DoInstall()
	{
		ValidateAddParams();
		ComAdminAppInfo appInfo = ComAdminWrapper.GetAppInfo(options.Application);
		if (appInfo == null)
		{
			throw CreateArgumentException("application", options.Application, SR.GetString("ApplicationNotFound", options.Application), null);
		}
		ValidateApplication(appInfo, options.Hosting);
		Guid iD = appInfo.ID;
		EndpointConfigContainer endpointConfigContainer = null;
		if (options.Hosting == Hosting.Complus)
		{
			endpointConfigContainer = ComplusEndpointConfigContainer.Get(options.Application, rethrow: true);
			if (endpointConfigContainer == null)
			{
				throw CreateArgumentException("application", options.Application, SR.GetString("ApplicationNotFound", options.Application), null);
			}
		}
		else if (options.Hosting == Hosting.Was)
		{
			string text = null;
			text = ((options.WebServer == null) ? WasEndpointConfigContainer.DefaultWebServer : options.WebServer);
			endpointConfigContainer = WasEndpointConfigContainer.Get(text, options.WebDirectory, options.Application);
			if (endpointConfigContainer == null)
			{
				throw CreateArgumentException("webDirectory", options.WebDirectory, SR.GetString("WebDirectoryNotFound", options.WebDirectory), null);
			}
		}
		IList<ComponentDefinition<Guid>> outComps = null;
		if (options.AllComponents)
		{
			GetAllComponentsForAdd(appInfo, options.Mex, out outComps);
		}
		else
		{
			GetComponentsFromInputForAdd(appInfo, options.Components, options.Mex, endpointConfigContainer.HasEndpointsForApplication(iD), out outComps);
		}
		if (outComps.Count == 0)
		{
			if (string.Empty != options.MexOnlyComponent)
			{
				throw CreateException(SR.GetString("MexOnlyComponentHasNoExposedInterface", options.MexOnlyComponent), null);
			}
			throw CreateException(SR.GetString("NoneOfTheComponentsSatisfiedTheAddCriteria"), null);
		}
		List<EndpointConfig> list = new List<EndpointConfig>();
		foreach (ComponentDefinition<Guid> item in outComps)
		{
			ComAdminClassInfo comAdminClassInfo = appInfo.FindClass(item.Component.ToString("B"));
			string text2 = null;
			string text3 = null;
			if (!comAdminClassInfo.SupportsTransactionFlow)
			{
				text2 = endpointConfigContainer.DefaultBindingType;
				text3 = endpointConfigContainer.DefaultBindingName;
			}
			else
			{
				text2 = endpointConfigContainer.DefaultTransactionalBindingType;
				text3 = endpointConfigContainer.DefaultTransactionalBindingName;
			}
			foreach (InterfaceDefination<Guid> interface2 in item.Interfaces)
			{
				Guid @interface = interface2.Interface;
				EndpointConfig endpointConfig = null;
				if (@interface != typeof(IMetadataExchange).GUID)
				{
					string uriString = endpointConfigContainer.DefaultEndpointAddress(iD, item.Component, @interface);
					endpointConfig = new EndpointConfig(iD, item.Component, @interface, text2, text3, new Uri(uriString, UriKind.RelativeOrAbsolute), isMexEndpoint: false, (List<string>)interface2.Methods);
				}
				else
				{
					endpointConfig = new EndpointConfig(iD, item.Component, typeof(IMetadataExchange).GUID, endpointConfigContainer.DefaultMexBindingType, endpointConfigContainer.DefaultMexBindingName, new Uri(endpointConfigContainer.DefaultMexAddress(iD, item.Component), UriKind.RelativeOrAbsolute), isMexEndpoint: true, null);
				}
				list.Add(endpointConfig);
			}
		}
		try
		{
			endpointConfigContainer.Add(list);
			endpointConfigContainer.PrepareChanges();
		}
		catch (Exception ex)
		{
			if (!(ex is NullReferenceException) && !(ex is SEHException))
			{
				endpointConfigContainer.AbortChanges();
				throw CreateException(SR.GetString("ErrorDuringAdd", options.Application), ex);
			}
			throw;
		}
		endpointConfigContainer.CommitChanges();
	}

	private static List<EndpointConfigContainer> GetContainersForQueryOrRemove(Hosting hosting, string application, string webServer, string webDirectory)
	{
		List<EndpointConfigContainer> list = new List<EndpointConfigContainer>();
		if (hosting == Hosting.Complus || hosting == Hosting.NotSpecified)
		{
			if (!string.IsNullOrEmpty(application))
			{
				EndpointConfigContainer endpointConfigContainer = ComplusEndpointConfigContainer.Get(application);
				if (endpointConfigContainer == null)
				{
					throw CreateArgumentException("application", options.Application, SR.GetString("ApplicationNotFound", options.Application), null);
				}
				list.Add(endpointConfigContainer);
			}
			else
			{
				List<ComplusEndpointConfigContainer> list2 = ComplusEndpointConfigContainer.Get();
				if (list2 != null)
				{
					foreach (ComplusEndpointConfigContainer item in list2)
					{
						list.Add(item);
					}
				}
			}
		}
		if (hosting == Hosting.Was || hosting == Hosting.NotSpecified)
		{
			if (!string.IsNullOrEmpty(webDirectory))
			{
				if (string.IsNullOrEmpty(webServer))
				{
					webServer = WasEndpointConfigContainer.DefaultWebServer;
				}
				EndpointConfigContainer endpointConfigContainer2 = WasEndpointConfigContainer.Get(webServer, webDirectory, application);
				if (endpointConfigContainer2 == null)
				{
					throw CreateArgumentException("webDirectory", options.WebDirectory, SR.GetString("WebDirectoryNotFound", options.WebDirectory), null);
				}
				if (string.IsNullOrEmpty(application))
				{
					list.Add(endpointConfigContainer2);
				}
				else if (endpointConfigContainer2.HasEndpointsForApplication(new Guid(application)))
				{
					list.Add(endpointConfigContainer2);
				}
			}
			else
			{
				List<WasEndpointConfigContainer> list3 = null;
				list3 = (string.IsNullOrEmpty(webServer) ? WasEndpointConfigContainer.Get(application) : WasEndpointConfigContainer.Get(webServer, application));
				if (list3 != null)
				{
					foreach (WasEndpointConfigContainer item2 in list3)
					{
						if (string.IsNullOrEmpty(application))
						{
							list.Add(item2);
						}
						else if (item2.HasEndpointsForApplication(new Guid(application)))
						{
							list.Add(item2);
						}
					}
					return list;
				}
			}
		}
		return list;
	}

	private static void DisplayEndpointConfig(EndpointConfig config)
	{
		List<string> list = null;
		if (config.Container != null)
		{
			list = config.Container.GetBaseAddresses(config);
		}
		if (list != null && list.Count != 0)
		{
			foreach (string item in list)
			{
				string text = item + "/" + config.Address;
				if (config.IsMexEndpoint)
				{
					ToolConsole.WriteQueryLine("          " + SR.GetString("MexEndpointExposed", text));
				}
				else
				{
					ToolConsole.WriteQueryLine("             " + SR.GetString("BindingType", config.BindingType));
					ToolConsole.WriteQueryLine("             " + SR.GetString("BindingConfigurationName", config.BindingName));
					ToolConsole.WriteQueryLine("             " + SR.GetString("Address", text));
				}
			}
			return;
		}
		if (config.IsMexEndpoint)
		{
			ToolConsole.WriteQueryLine("          " + SR.GetString("MexEndpointExposed", config.Address));
			return;
		}
		ToolConsole.WriteQueryLine("             " + SR.GetString("BindingType", config.BindingType));
		ToolConsole.WriteQueryLine("             " + SR.GetString("BindingConfigurationName", config.BindingName));
		ToolConsole.WriteQueryLine("             " + SR.GetString("Address", config.Address));
	}

	private static void DoList()
	{
		ValidateQueryParams();
		string text = null;
		if (options.Application != null)
		{
			if (!ComAdminWrapper.ResolveApplicationId(options.Application, out var appId))
			{
				throw CreateArgumentException("application", options.Application, SR.GetString("ApplicationNotFound", options.Application), null);
			}
			text = appId.ToString("B");
		}
		List<EndpointConfig> list = new List<EndpointConfig>();
		List<EndpointConfigContainer> containersForQueryOrRemove = GetContainersForQueryOrRemove(options.Hosting, text, options.WebServer, options.WebDirectory);
		if (containersForQueryOrRemove != null)
		{
			foreach (EndpointConfigContainer item in containersForQueryOrRemove)
			{
				try
				{
					List<EndpointConfig> list2 = null;
					list2 = (string.IsNullOrEmpty(text) ? item.GetEndpointConfigs() : item.GetEndpointConfigs(new Guid(text)));
					list.AddRange(list2);
				}
				catch (Exception)
				{
					if (item is WasEndpointConfigContainer)
					{
						ToolConsole.WriteWarning(SR.GetString("InvalidConfigFile", ((WasEndpointConfigContainer)item).ConfigFile.OriginalFileName));
					}
					if (item is ComplusEndpointConfigContainer)
					{
						ToolConsole.WriteWarning(SR.GetString("InvalidConfigFile", ((ComplusEndpointConfigContainer)item).ConfigFile.OriginalFileName));
					}
				}
			}
		}
		Dictionary<Guid, Dictionary<Guid, Dictionary<Guid, List<EndpointConfig>>>> dictionary = new Dictionary<Guid, Dictionary<Guid, Dictionary<Guid, List<EndpointConfig>>>>();
		foreach (EndpointConfig item2 in list)
		{
			Dictionary<Guid, Dictionary<Guid, List<EndpointConfig>>> value = null;
			Dictionary<Guid, List<EndpointConfig>> value2 = null;
			List<EndpointConfig> value3 = null;
			if (!dictionary.TryGetValue(item2.Appid, out value))
			{
				value = new Dictionary<Guid, Dictionary<Guid, List<EndpointConfig>>>();
				dictionary[item2.Appid] = value;
			}
			if (!value.TryGetValue(item2.Clsid, out value2))
			{
				value2 = new Dictionary<Guid, List<EndpointConfig>>();
				value[item2.Clsid] = value2;
			}
			if (!value2.TryGetValue(item2.Iid, out value3))
			{
				value3 = new List<EndpointConfig>();
				value2[item2.Iid] = value3;
			}
			value3.Add(item2);
		}
		IEnumerator<KeyValuePair<Guid, Dictionary<Guid, Dictionary<Guid, List<EndpointConfig>>>>> enumerator3 = dictionary.GetEnumerator();
		while (enumerator3.MoveNext())
		{
			IEnumerator<KeyValuePair<Guid, Dictionary<Guid, List<EndpointConfig>>>> enumerator4 = enumerator3.Current.Value.GetEnumerator();
			ComAdminAppInfo appInfo = ComAdminWrapper.GetAppInfo(enumerator3.Current.Key.ToString("B"));
			if (appInfo == null)
			{
				continue;
			}
			ToolConsole.WriteQueryLine(SR.GetString("EnumeratingComponentsForApplication", options.ShowGuids ? appInfo.ID.ToString("B") : appInfo.Name));
			foreach (EndpointConfigContainer item3 in containersForQueryOrRemove)
			{
				if (item3.HasEndpointsForApplication(enumerator3.Current.Key))
				{
					if (item3 is WasEndpointConfigContainer)
					{
						ToolConsole.WriteQueryLine("     " + SR.GetString("WasHosting"));
						ToolConsole.WriteQueryLine("     " + SR.GetString("ConfigFileName", ((WasEndpointConfigContainer)item3).ConfigFile.OriginalFileName));
					}
					else
					{
						ToolConsole.WriteQueryLine("     " + SR.GetString("ComplusHosting"));
						ToolConsole.WriteQueryLine("     " + SR.GetString("ConfigFileName", ((ComplusEndpointConfigContainer)item3).ConfigFile.OriginalFileName));
					}
				}
			}
			while (enumerator4.MoveNext())
			{
				IEnumerator<KeyValuePair<Guid, List<EndpointConfig>>> enumerator6 = enumerator4.Current.Value.GetEnumerator();
				ComAdminClassInfo comAdminClassInfo = appInfo.FindClass(enumerator4.Current.Key.ToString("B"));
				if (comAdminClassInfo == null)
				{
					continue;
				}
				ToolConsole.WriteQueryLine("     " + SR.GetString("EnumeratingInterfacesForComponent", options.ShowGuids ? comAdminClassInfo.Clsid.ToString("B") : comAdminClassInfo.Name));
				while (enumerator6.MoveNext())
				{
					ComAdminInterfaceInfo comAdminInterfaceInfo = comAdminClassInfo.FindInterface(enumerator6.Current.Key.ToString("B"));
					if (comAdminInterfaceInfo == null)
					{
						foreach (EndpointConfig item4 in enumerator6.Current.Value)
						{
							if (item4.IsMexEndpoint)
							{
								DisplayEndpointConfig(item4);
							}
						}
						continue;
					}
					ToolConsole.WriteQueryLine("          " + SR.GetString("EnumeratingEndpointsForInterfaces", options.ShowGuids ? comAdminInterfaceInfo.Iid.ToString("B") : comAdminInterfaceInfo.Name));
					foreach (EndpointConfig item5 in enumerator6.Current.Value)
					{
						DisplayEndpointConfig(item5);
					}
				}
			}
		}
	}

	private static void DoUninstall()
	{
		ValidateRemoveParams();
		ComAdminAppInfo appInfo = ComAdminWrapper.GetAppInfo(options.Application);
		if (appInfo == null)
		{
			throw CreateArgumentException("application", options.Application, SR.GetString("ApplicationNotFound", options.Application), null);
		}
		Guid iD = appInfo.ID;
		string application = iD.ToString("B");
		IList<ComponentDefinition<Guid>> outComps = null;
		if (options.AllComponents)
		{
			GetAllComponentsForRemove(appInfo, out outComps);
		}
		else
		{
			GetComponentsFromInputForRemove(appInfo, options.Components, out outComps);
		}
		List<EndpointConfigContainer> containersForQueryOrRemove = GetContainersForQueryOrRemove(options.Hosting, application, options.WebServer, options.WebDirectory);
		if (outComps.Count == 0)
		{
			ToolConsole.WriteWarning(SR.GetString("NoneOfTheComponentsSatisfiedTheRemoveCriteria"));
		}
		try
		{
			bool flag = false;
			foreach (EndpointConfigContainer item in containersForQueryOrRemove)
			{
				List<EndpointConfig> list = new List<EndpointConfig>();
				List<EndpointConfig> endpointConfigs = item.GetEndpointConfigs(iD);
				foreach (EndpointConfig item2 in endpointConfigs)
				{
					if (ShouldDelete(item2, outComps))
					{
						list.Add(item2);
					}
				}
				if (list.Count != 0)
				{
					item.Remove(list);
					flag = true;
				}
			}
			if (!flag)
			{
				ToolConsole.WriteWarning(SR.GetString("NoneOfConfigsFoundMatchTheCriteriaSpecifiedNothingWillBeRemoved"));
			}
			foreach (EndpointConfigContainer item3 in containersForQueryOrRemove)
			{
				item3.PrepareChanges();
			}
		}
		catch (Exception ex)
		{
			if (!(ex is NullReferenceException) && !(ex is SEHException))
			{
				foreach (EndpointConfigContainer item4 in containersForQueryOrRemove)
				{
					item4.AbortChanges();
				}
				throw CreateException(SR.GetString("ErrorDuringRemove"), ex);
			}
			throw;
		}
		foreach (EndpointConfigContainer item5 in containersForQueryOrRemove)
		{
			item5.CommitChanges();
		}
	}

	private static bool ShouldDelete(EndpointConfig endpointConfig, IList<ComponentDefinition<Guid>> guidComponents)
	{
		foreach (ComponentDefinition<Guid> guidComponent in guidComponents)
		{
			if (!(guidComponent.Component == endpointConfig.Clsid))
			{
				continue;
			}
			foreach (InterfaceDefination<Guid> @interface in guidComponent.Interfaces)
			{
				if (@interface.Interface == endpointConfig.Iid)
				{
					endpointConfig.Methods = @interface.Methods;
					return true;
				}
			}
		}
		return false;
	}

	private static void EnsureUserIsAdministrator()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
		{
			throw CreateException(SR.GetString("MustBeAnAdministrator"), null);
		}
	}

	private static void GetAllComponentsForAdd(ComAdminAppInfo appInfo, bool mex, out IList<ComponentDefinition<Guid>> outComps)
	{
		outComps = new List<ComponentDefinition<Guid>>();
		foreach (ComAdminClassInfo @class in appInfo.Classes)
		{
			if (!ValidateClass(@class))
			{
				continue;
			}
			ComponentDefinition<Guid> componentDefinition = new ComponentDefinition<Guid>(@class.Clsid);
			foreach (ComAdminInterfaceInfo @interface in @class.Interfaces)
			{
				if (ComPlusTypeValidator.VerifyInterface(@interface, options.AllowReferences, @class.Clsid))
				{
					componentDefinition.AddInterface(@interface.Iid, ComPlusTypeValidator.FetchAllMethodsForInterface(@interface));
				}
			}
			if (mex && componentDefinition.Interfaces != null)
			{
				componentDefinition.AddInterface(typeof(IMetadataExchange).GUID, null);
			}
			if (componentDefinition.Interfaces != null)
			{
				outComps.Add(componentDefinition);
				continue;
			}
			ToolConsole.WriteWarning(SR.GetString("NoneOfTheSpecifiedInterfacesForComponentWereFoundSkipping", Options.ShowGuids ? @class.Clsid.ToString("B") : @class.Name));
		}
	}

	private static void GetAllComponentsForRemove(ComAdminAppInfo appInfo, out IList<ComponentDefinition<Guid>> outComps)
	{
		outComps = new List<ComponentDefinition<Guid>>();
		foreach (ComAdminClassInfo @class in appInfo.Classes)
		{
			ComponentDefinition<Guid> componentDefinition = new ComponentDefinition<Guid>(@class.Clsid);
			foreach (ComAdminInterfaceInfo @interface in @class.Interfaces)
			{
				componentDefinition.AddInterface(@interface.Iid, null);
			}
			componentDefinition.AddInterface(typeof(IMetadataExchange).GUID, null);
			outComps.Add(componentDefinition);
		}
	}

	private static void GetComponentsFromInputForAdd(ComAdminAppInfo appInfo, IList<ComponentDefinition<string>> inComps, bool mex, bool priorEndpointsExist, out IList<ComponentDefinition<Guid>> outComps)
	{
		string text = string.Empty;
		outComps = new List<ComponentDefinition<Guid>>();
		foreach (ComponentDefinition<string> inComp in inComps)
		{
			ComponentDefinition<Guid> componentDefinition = null;
			ComAdminClassInfo comAdminClassInfo = appInfo.FindClass(inComp.Component);
			if (comAdminClassInfo == null)
			{
				ToolConsole.WriteWarning(SR.GetString("CannotFindComponentInApplicationSkipping", inComp.Component, Options.ShowGuids ? appInfo.ID.ToString("B") : appInfo.Name));
			}
			else
			{
				if (!ValidateClass(comAdminClassInfo))
				{
					continue;
				}
				foreach (ComponentDefinition<Guid> outComp in outComps)
				{
					if (outComp.Component == comAdminClassInfo.Clsid)
					{
						componentDefinition = outComp;
					}
				}
				if (componentDefinition == null)
				{
					componentDefinition = new ComponentDefinition<Guid>(comAdminClassInfo.Clsid);
				}
				if (inComp.AllInterfaces)
				{
					foreach (ComAdminInterfaceInfo interface2 in comAdminClassInfo.Interfaces)
					{
						if (ComPlusTypeValidator.VerifyInterface(interface2, options.AllowReferences, comAdminClassInfo.Clsid))
						{
							componentDefinition.AddInterface(interface2.Iid, ComPlusTypeValidator.FetchAllMethodsForInterface(interface2));
						}
					}
					if (componentDefinition.Interfaces != null && mex)
					{
						componentDefinition.AddInterface(typeof(IMetadataExchange).GUID, null);
					}
				}
				else
				{
					foreach (InterfaceDefination<string> interface3 in inComp.Interfaces)
					{
						string @interface = interface3.Interface;
						if (@interface == typeof(IMetadataExchange).GUID.ToString("B"))
						{
							if (!mex)
							{
								componentDefinition.AddInterface(typeof(IMetadataExchange).GUID, null);
							}
							continue;
						}
						ComAdminInterfaceInfo comAdminInterfaceInfo = comAdminClassInfo.FindInterface(@interface);
						if (comAdminInterfaceInfo == null)
						{
							ToolConsole.WriteWarning(SR.GetString("CannotFindInterfaceInCatalogForComponentSkipping", @interface, inComp.Component));
							text = @interface;
						}
						else if (interface3.AllMethods)
						{
							if (!ComPlusTypeValidator.VerifyInterface(comAdminInterfaceInfo, options.AllowReferences, comAdminClassInfo.Clsid, produceError: true))
							{
								throw CreateException(SR.GetString("InvalidInterface"), null);
							}
							componentDefinition.AddInterface(comAdminInterfaceInfo.Iid, ComPlusTypeValidator.FetchAllMethodsForInterface(comAdminInterfaceInfo));
						}
						else
						{
							if (!ComPlusTypeValidator.VerifyInterfaceMethods(comAdminInterfaceInfo, interface3.Methods, options.AllowReferences, produceError: true))
							{
								throw CreateException(SR.GetString("InvalidMethod"), null);
							}
							componentDefinition.AddInterface(comAdminInterfaceInfo.Iid, (List<string>)interface3.Methods);
						}
					}
					if ((componentDefinition.Interfaces != null || priorEndpointsExist) && mex)
					{
						componentDefinition.AddInterface(typeof(IMetadataExchange).GUID, null);
					}
				}
				if (componentDefinition.Interfaces != null)
				{
					outComps.Add(componentDefinition);
					continue;
				}
				ToolConsole.WriteWarning(SR.GetString("NoneOfTheSpecifiedInterfacesForComponentWereFoundSkipping", inComp.Component));
			}
		}
		if (outComps.Count == 0 && !string.IsNullOrEmpty(text))
		{
			throw CreateException(SR.GetString("NoComponentContainsInterface", text), null);
		}
	}

	private static void GetComponentsFromInputForRemove(ComAdminAppInfo appInfo, IList<ComponentDefinition<string>> inComps, out IList<ComponentDefinition<Guid>> outComps)
	{
		outComps = new List<ComponentDefinition<Guid>>();
		foreach (ComponentDefinition<string> inComp in inComps)
		{
			ComponentDefinition<Guid> componentDefinition = null;
			ComAdminClassInfo comAdminClassInfo = appInfo.FindClass(inComp.Component);
			if (comAdminClassInfo == null)
			{
				ToolConsole.WriteWarning(SR.GetString("CannotFindComponentInApplicationSkipping", inComp.Component, Options.ShowGuids ? appInfo.ID.ToString("B") : appInfo.Name));
				continue;
			}
			foreach (ComponentDefinition<Guid> outComp in outComps)
			{
				if (outComp.Component == comAdminClassInfo.Clsid)
				{
					componentDefinition = outComp;
				}
			}
			if (componentDefinition == null)
			{
				componentDefinition = new ComponentDefinition<Guid>(comAdminClassInfo.Clsid);
			}
			if (inComp.AllInterfaces)
			{
				foreach (ComAdminInterfaceInfo interface2 in comAdminClassInfo.Interfaces)
				{
					componentDefinition.AddInterface(interface2.Iid, ComPlusTypeValidator.FetchAllMethodsForInterface(interface2, produceWarning: false));
				}
				componentDefinition.AddInterface(typeof(IMetadataExchange).GUID, null);
			}
			else
			{
				foreach (InterfaceDefination<string> interface3 in inComp.Interfaces)
				{
					string @interface = interface3.Interface;
					if (@interface == typeof(IMetadataExchange).GUID.ToString("B"))
					{
						componentDefinition.AddInterface(typeof(IMetadataExchange).GUID, null);
						continue;
					}
					ComAdminInterfaceInfo comAdminInterfaceInfo = comAdminClassInfo.FindInterface(@interface);
					if (comAdminInterfaceInfo == null)
					{
						ToolConsole.WriteWarning(SR.GetString("CannotFindInterfaceInCatalogForComponentSkipping", @interface, inComp.Component));
					}
					else if (interface3.AllMethods)
					{
						componentDefinition.AddInterface(comAdminInterfaceInfo.Iid, ComPlusTypeValidator.FetchAllMethodsForInterface(comAdminInterfaceInfo));
					}
					else
					{
						componentDefinition.AddInterface(comAdminInterfaceInfo.Iid, (List<string>)interface3.Methods);
					}
				}
			}
			if (componentDefinition.Interfaces != null)
			{
				outComps.Add(componentDefinition);
				continue;
			}
			ToolConsole.WriteWarning(SR.GetString("NoneOfTheSpecifiedInterfacesForComponentWereFoundSkipping", inComp.Component));
		}
	}

	public static bool CheckForCorrectOle32()
	{
		Guid guid = new Guid("0000032E-0000-0000-C000-000000000046");
		IPSFactoryBuffer iPSFactoryBuffer = SafeNativeMethods.DllGetClassObject(guid, typeof(IPSFactoryBuffer).GUID) as IPSFactoryBuffer;
		try
		{
			iPSFactoryBuffer.CreateProxy(IntPtr.Zero, guid, out var _, out var _);
		}
		catch (ArgumentException)
		{
			return true;
		}
		catch (COMException)
		{
			return false;
		}
		return false;
	}

	public static int Main(string[] args)
	{
		Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture.GetConsoleFallbackUICulture();
		if (Console.OutputEncoding.CodePage != 65001 && Console.OutputEncoding.CodePage != Thread.CurrentThread.CurrentUICulture.TextInfo.OEMCodePage)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		}
		object obj = new CServiceConfig();
		if (!(obj is IServiceSysTxnConfig))
		{
			ToolConsole.WriteError(SR.GetString("WindowsFunctionalityMissing"), "");
			return 1;
		}
		if (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor == 1 && !CheckForCorrectOle32())
		{
			ToolConsole.WriteError(SR.GetString("WindowsFunctionalityMissing"), "");
			return 1;
		}
		try
		{
			EnsureUserIsAdministrator();
			options = Options.ParseArguments(args);
			ToolConsole.Verbose = options.Verbose;
			Run();
		}
		catch (ArgumentException e)
		{
			ToolConsole.WriteError(e);
			Console.WriteLine(SR.GetString("MoreHelp", "?"));
			return 1;
		}
		catch (ApplicationException e2)
		{
			ToolConsole.WriteError(e2);
			return 1;
		}
		catch (Exception ex)
		{
			if (ex is NullReferenceException || ex is SEHException)
			{
				throw;
			}
			ToolConsole.WriteDetailedException(ex, SR.GetString("UnExpectedError"));
			return 1;
		}
		return 0;
	}

	private static void Run()
	{
		if (!options.NoLogo)
		{
			DisplayLogo();
		}
		if (options.Help)
		{
			ToolConsole.Verbose = false;
			DisplayHelp(options.Mode);
			return;
		}
		switch (options.Mode)
		{
		case Mode.NotSpecified:
			throw CreateArgumentException("mode", "", SR.GetString("ArgumentRequired", "mode"), null);
		case Mode.Install:
			DoInstall();
			break;
		case Mode.Uninstall:
			DoUninstall();
			break;
		case Mode.List:
			DoList();
			break;
		}
	}

	private static void ValidateAddParams()
	{
		if (options.Application == null)
		{
			throw CreateArgumentException("application", null, SR.GetString("ArgumentRequired", "application"), null);
		}
		if (!options.AllComponents && (options.Components == null || options.Components.Count == 0))
		{
			throw CreateArgumentException("contract", null, SR.GetString("ArgumentRequired", "contract"), null);
		}
		switch (options.Hosting)
		{
		case Hosting.NotSpecified:
			throw CreateArgumentException("hosting", null, SR.GetString("ArgumentRequired", "hosting"), null);
		case Hosting.Complus:
			if (options.WebDirectory != null)
			{
				throw CreateArgumentException("webDirectory", options.WebDirectory, SR.GetString("InvalidArgumentForHostingMode", "webDirectory"), null);
			}
			if (options.WebServer != null)
			{
				throw CreateArgumentException("webSite", options.WebServer, SR.GetString("InvalidArgumentForHostingMode", "webSite"), null);
			}
			break;
		case Hosting.Was:
			if (options.WebDirectory == null)
			{
				throw CreateArgumentException("webDirectory", null, SR.GetString("ArgumentRequired", "webDirectory"), null);
			}
			break;
		}
	}

	private static void ValidateRemoveParams()
	{
		if (options.Application == null)
		{
			throw CreateArgumentException("application", null, SR.GetString("ArgumentRequired", "application"), null);
		}
		if (!options.AllComponents && (options.Components == null || options.Components.Count == 0))
		{
			throw CreateArgumentException("contract", null, SR.GetString("ArgumentRequired", "contract"), null);
		}
		switch (options.Hosting)
		{
		case Hosting.NotSpecified:
			if (options.WebDirectory != null)
			{
				throw CreateArgumentException("webDirectory", options.WebDirectory, SR.GetString("InvalidArgumentForHostingMode", "webDirectory"), null);
			}
			break;
		case Hosting.Complus:
			if (options.WebDirectory != null)
			{
				throw CreateArgumentException("webDirectory", options.WebDirectory, SR.GetString("InvalidArgumentForHostingMode", "webDirectory"), null);
			}
			if (options.WebServer != null)
			{
				throw CreateArgumentException("webSite", options.WebServer, SR.GetString("InvalidArgumentForHostingMode", "webSite"), null);
			}
			break;
		case Hosting.Was:
			break;
		}
	}

	private static void ValidateQueryParams()
	{
		if (!options.AllComponents && (options.Components == null || options.Components.Count <= 0))
		{
			switch (options.Hosting)
			{
			case Hosting.NotSpecified:
				if (options.WebDirectory != null)
				{
					throw CreateArgumentException("webDirectory", options.WebDirectory, SR.GetString("InvalidArgumentForHostingMode", "webDirectory"), null);
				}
				break;
			case Hosting.Complus:
				if (options.WebDirectory != null)
				{
					throw CreateArgumentException("webDirectory", options.WebDirectory, SR.GetString("InvalidArgumentForHostingMode", "webDirectory"), null);
				}
				if (options.WebServer != null)
				{
					throw CreateArgumentException("webSite", options.WebServer, SR.GetString("InvalidArgumentForHostingMode", "webSite"), null);
				}
				break;
			case Hosting.Was:
				break;
			}
			return;
		}
		throw CreateArgumentException("contract", null, SR.GetString("ExclusiveOptionsSpecified", "contract", "mode:query"), null);
	}

	private static void ValidateApplication(ComAdminAppInfo appInfo, Hosting hosting)
	{
		if (appInfo.IsSystemApplication)
		{
			throw CreateArgumentException("application", appInfo.Name, SR.GetString("SystemApplicationsNotSupported"), null);
		}
		if (hosting == Hosting.Complus)
		{
			if (!appInfo.IsServerActivated)
			{
				throw CreateArgumentException("application", appInfo.Name, SR.GetString("LibraryApplicationsNotSupported"), null);
			}
			if (appInfo.IsAutomaticRecycling)
			{
				throw CreateArgumentException("application", appInfo.Name, SR.GetString("ProcessRecyclingNotSupported"), null);
			}
			if (appInfo.IsProcessPooled)
			{
				throw CreateArgumentException("application", appInfo.Name, SR.GetString("ProcessPoolingNotSupported"), null);
			}
		}
	}

	private static bool ValidateClass(ComAdminClassInfo classInfo)
	{
		if (classInfo.IsPrivate)
		{
			ToolConsole.WriteWarning(SR.GetString("CannotExposePrivateComponentsSkipping", Options.ShowGuids ? classInfo.Clsid.ToString("B") : classInfo.Name));
			return false;
		}
		return true;
	}
}
