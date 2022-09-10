using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel.Channels;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal static class ComPlusTypeValidator
{
	private static Guid IID_Object = new Guid("{65074F7F-63C0-304E-AF0A-D51741CB4A8D}");

	private static Guid IID_IDisposable = new Guid("{805D7A98-D4AF-3F0F-967F-E5CF45312D2C}");

	private static Guid IID_IManagedObject = new Guid("{C3FCC19E-A970-11D2-8B5A-00A0C9B7C9C4}");

	private static Guid IID_IProcessInitializer = new Guid("{1113F52D-DC7F-4943-AED6-88D04027E32A}");

	private static Guid IID_IRemoteDispatch = new Guid("{6619A740-8154-43BE-A186-0319578E02DB}");

	private static Guid IID_IServicedComponentInfo = new Guid("{8165B19E-8D3A-4D0B-80C8-97DE310DB583}");

	private static Guid IID_IComponentRegistrar = new Guid("{A817E7A2-43FA-11D0-9E44-00AA00B6770A}");

	internal static bool DerivesFromServicedComponent(Guid iid, Guid clsid)
	{
		Type type = typeof(Message).Assembly.GetType("System.ServiceModel.ComIntegration.TypeCacheManager");
		object target = type.InvokeMember("Provider", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty, null, null, null, CultureInfo.InvariantCulture);
		object[] args = new object[3] { iid, false, true };
		Assembly assembly = null;
		try
		{
			assembly = type.InvokeMember("ResolveAssemblyFromIID", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, target, args, CultureInfo.InvariantCulture) as Assembly;
		}
		catch (TargetInvocationException ex)
		{
			if (ex.GetBaseException() is FileNotFoundException)
			{
				throw;
			}
			Console.WriteLine(string.Concat(iid, ", ", clsid));
			return false;
		}
		bool result = false;
		Type[] types = assembly.GetTypes();
		foreach (Type type2 in types)
		{
			if (!(type2.GUID == clsid))
			{
				continue;
			}
			Type baseType = type2.BaseType;
			while (null != baseType)
			{
				if (!(typeof(ServicedComponent) == baseType))
				{
					baseType = baseType.BaseType;
					continue;
				}
				result = true;
				break;
			}
		}
		return result;
	}

	internal static bool VerifyInterface(ComAdminInterfaceInfo interfaceInfo, bool allowReferences, Guid clsid)
	{
		return VerifyInterface(interfaceInfo, allowReferences, clsid, produceError: false);
	}

	internal static bool VerifyInterface(ComAdminInterfaceInfo interfaceInfo, bool allowReferences, Guid clsid, bool produceError)
	{
		if (IsInternalInterface(interfaceInfo.Iid))
		{
			if (produceError)
			{
				ToolConsole.WriteError(SR.GetString("IsInternalInterfaceAndCannotBeExposedOverWebService", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name), "");
			}
			else
			{
				ToolConsole.WriteWarning(SR.GetString("IsInternalInterfaceAndCannotBeExposedOverWebService", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name));
			}
			return false;
		}
		Type type = typeof(Message).Assembly.GetType("System.ServiceModel.ComIntegration.TypeCacheManager");
		object target = type.InvokeMember("Provider", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty, null, null, null, CultureInfo.InvariantCulture);
		object[] args = new object[1] { interfaceInfo.Iid };
		Type type2 = null;
		try
		{
			type2 = type.InvokeMember("VerifyType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, target, args, CultureInfo.InvariantCulture) as Type;
		}
		catch (TargetInvocationException ex)
		{
			if (ex.GetBaseException() is FileNotFoundException)
			{
				throw CreateDescriptiveException((FileNotFoundException)ex.GetBaseException());
			}
			string text = SR.GetString("TypeResolutionForInterfaceFailed", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, ex.InnerException!.Message);
			if (DerivesFromServicedComponent(interfaceInfo.Iid, clsid))
			{
				text = text + " " + SR.GetString("ClassInterfacesNotSupported");
			}
			if (produceError)
			{
				ToolConsole.WriteError(text, "");
			}
			else
			{
				ToolConsole.WriteNonVerboseWarning(text);
			}
			return false;
		}
		MethodInfo[] methods = type2.GetMethods();
		if (methods.Length == 0)
		{
			if (produceError)
			{
				ToolConsole.WriteError(SR.GetString("InterfaceHasNoMethods", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name), "");
			}
			else
			{
				ToolConsole.WriteNonVerboseWarning(SR.GetString("InterfaceHasNoMethods", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name));
			}
			return false;
		}
		MethodInfo[] array = methods;
		int num = 0;
		MethodInfo methodInfo;
		string typeMismatchDetails;
		while (true)
		{
			if (num < array.Length)
			{
				methodInfo = array[num];
				ParameterInfo[] parameters = methodInfo.GetParameters();
				foreach (ParameterInfo parameterInfo in parameters)
				{
					Type type3 = parameterInfo.ParameterType;
					if (type3.IsByRef)
					{
						type3 = type3.GetElementType();
					}
					if (!IsValidParameter(type3, parameterInfo, allowReferences, out typeMismatchDetails))
					{
						if (produceError)
						{
							ToolConsole.WriteError(SR.GetString("ParameterOfMethodInInterfaceHasANonCompliantType", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, methodInfo.Name, parameterInfo.Name, typeMismatchDetails), "");
						}
						else
						{
							ToolConsole.WriteNonVerboseWarning(SR.GetString("ParameterOfMethodInInterfaceHasANonCompliantType", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, methodInfo.Name, parameterInfo.Name, typeMismatchDetails));
						}
						return false;
					}
				}
				if (!IsValidParameter(methodInfo.ReturnType, methodInfo.ReturnTypeCustomAttributes, allowReferences, out typeMismatchDetails))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		if (produceError)
		{
			ToolConsole.WriteError(SR.GetString("InvalidWebServiceReturnValue", methodInfo.ReturnType.Name, methodInfo.Name, Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, typeMismatchDetails), "");
		}
		else
		{
			ToolConsole.WriteNonVerboseWarning(SR.GetString("InvalidWebServiceReturnValue", methodInfo.ReturnType.Name, methodInfo.Name, Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, typeMismatchDetails));
		}
		return false;
	}

	public static List<string> FetchAllMethodsForInterface(ComAdminInterfaceInfo interfaceInfo)
	{
		return FetchAllMethodsForInterface(interfaceInfo, produceWarning: true);
	}

	public static List<string> FetchAllMethodsForInterface(ComAdminInterfaceInfo interfaceInfo, bool produceWarning)
	{
		Type type = typeof(Message).Assembly.GetType("System.ServiceModel.ComIntegration.TypeCacheManager");
		object target = type.InvokeMember("Provider", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty, null, null, null, CultureInfo.InvariantCulture);
		object[] args = new object[1] { interfaceInfo.Iid };
		Type type2 = null;
		try
		{
			type2 = type.InvokeMember("VerifyType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, target, args, CultureInfo.InvariantCulture) as Type;
		}
		catch (TargetInvocationException ex)
		{
			if (ex.GetBaseException() is FileNotFoundException)
			{
				throw CreateDescriptiveException((FileNotFoundException)ex.GetBaseException());
			}
			if (produceWarning)
			{
				ToolConsole.WriteWarning(SR.GetString("TypeResolutionForInterfaceFailed", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, ex.InnerException!.Message));
			}
			return null;
		}
		MethodInfo[] methods = type2.GetMethods();
		if (methods.Length == 0)
		{
			return null;
		}
		List<string> list = new List<string>();
		MethodInfo[] array = methods;
		foreach (MethodBase methodBase in array)
		{
			list.Add(methodBase.Name);
		}
		return list;
	}

	private static Exception CreateDescriptiveException(FileNotFoundException oldException)
	{
		return new Exception(oldException.Message + " " + SR.GetString("InstallInGAC", oldException.FileName));
	}

	public static bool VerifyInterfaceMethods(ComAdminInterfaceInfo interfaceInfo, IList<string> methodNames, bool allowReferences, bool produceError)
	{
		if (IsInternalInterface(interfaceInfo.Iid))
		{
			if (produceError)
			{
				ToolConsole.WriteError(SR.GetString("IsInternalInterfaceAndCannotBeExposedOverWebService", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name), "");
			}
			else
			{
				ToolConsole.WriteWarning(SR.GetString("IsInternalInterfaceAndCannotBeExposedOverWebService", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name));
			}
			return false;
		}
		Type type = typeof(Message).Assembly.GetType("System.ServiceModel.ComIntegration.TypeCacheManager");
		object target = type.InvokeMember("Provider", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty, null, null, null, CultureInfo.InvariantCulture);
		object[] args = new object[1] { interfaceInfo.Iid };
		Type type2 = null;
		try
		{
			type2 = type.InvokeMember("VerifyType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, target, args, CultureInfo.InvariantCulture) as Type;
		}
		catch (TargetInvocationException ex)
		{
			if (ex.GetBaseException() is FileNotFoundException)
			{
				throw CreateDescriptiveException((FileNotFoundException)ex.GetBaseException());
			}
			if (produceError)
			{
				ToolConsole.WriteError(SR.GetString("TypeResolutionForInterfaceFailed", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, ex.InnerException!.Message), "");
			}
			else
			{
				ToolConsole.WriteWarning(SR.GetString("TypeResolutionForInterfaceFailed", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, ex.InnerException!.Message));
			}
			return false;
		}
		MethodInfo[] methods = type2.GetMethods();
		if (methods.Length == 0)
		{
			if (produceError)
			{
				ToolConsole.WriteError(SR.GetString("InterfaceHasNoMethods", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name), "");
			}
			else
			{
				ToolConsole.WriteWarning(SR.GetString("InterfaceHasNoMethods", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name));
			}
			return false;
		}
		bool flag = false;
		foreach (string methodName in methodNames)
		{
			flag = false;
			MethodInfo[] array = methods;
			foreach (MethodInfo methodInfo in array)
			{
				if (!(methodName == methodInfo.Name))
				{
					continue;
				}
				flag = true;
				ParameterInfo[] parameters = methodInfo.GetParameters();
				string typeMismatchDetails;
				foreach (ParameterInfo parameterInfo in parameters)
				{
					Type type3 = parameterInfo.ParameterType;
					if (type3.IsByRef)
					{
						type3 = type3.GetElementType();
					}
					if (!IsValidParameter(type3, parameterInfo, allowReferences, out typeMismatchDetails))
					{
						if (produceError)
						{
							ToolConsole.WriteError(SR.GetString("ParameterOfMethodInInterfaceHasANonCompliantType", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, methodInfo.Name, parameterInfo.Name, typeMismatchDetails), "");
						}
						else
						{
							ToolConsole.WriteWarning(SR.GetString("ParameterOfMethodInInterfaceHasANonCompliantType", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, methodInfo.Name, parameterInfo.Name, typeMismatchDetails));
						}
						return false;
					}
				}
				if (!IsValidParameter(methodInfo.ReturnType, methodInfo.ReturnTypeCustomAttributes, allowReferences, out typeMismatchDetails))
				{
					if (produceError)
					{
						ToolConsole.WriteError(SR.GetString("InvalidWebServiceReturnValue", methodInfo.ReturnType.Name, methodInfo.Name, Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, typeMismatchDetails), "");
					}
					else
					{
						ToolConsole.WriteWarning(SR.GetString("InvalidWebServiceReturnValue", methodInfo.ReturnType.Name, methodInfo.Name, Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, typeMismatchDetails));
					}
					return false;
				}
			}
			if (!flag)
			{
				throw Tool.CreateException(SR.GetString("MethodNotFoundOnInterface", Tool.Options.ShowGuids ? interfaceInfo.Iid.ToString("B") : interfaceInfo.Name, methodName), null);
			}
		}
		return true;
	}

	public static bool IsInternalInterface(Guid iid)
	{
		if (!(iid == IID_Object) && !(iid == IID_IDisposable) && !(iid == IID_IManagedObject) && !(iid == IID_IProcessInitializer) && !(iid == IID_IRemoteDispatch) && !(iid == IID_IServicedComponentInfo) && !(iid == IID_IComponentRegistrar) && !iid.ToString("D").ToLowerInvariant().EndsWith("c000-000000000046", StringComparison.Ordinal))
		{
			return false;
		}
		return true;
	}

	public static bool IsValidParameter(Type type, ICustomAttributeProvider attributeProvider, bool allowReferences, out string typeMismatchDetails)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		typeMismatchDetails = type.ToString() + " ";
		object[] customAttributes = attributeProvider.GetCustomAttributes(typeof(MarshalAsAttribute), inherit: true);
		object[] array = customAttributes;
		int num = 0;
		UnmanagedType value;
		while (true)
		{
			if (num < array.Length)
			{
				MarshalAsAttribute marshalAsAttribute = (MarshalAsAttribute)array[num];
				value = marshalAsAttribute.Value;
				if (value == UnmanagedType.IDispatch || value == UnmanagedType.Interface || value == UnmanagedType.IUnknown)
				{
					break;
				}
				num++;
				continue;
			}
			XsdDataContractExporter val = new XsdDataContractExporter();
			if (!val.CanExport(type))
			{
				typeMismatchDetails += SR.GetString("CannotBeExportedByDataContractExporter");
				return false;
			}
			return true;
		}
		if (!allowReferences)
		{
			typeMismatchDetails += SR.GetString("HasMarshalAsAttributeOfType", value);
		}
		return allowReferences;
	}
}
