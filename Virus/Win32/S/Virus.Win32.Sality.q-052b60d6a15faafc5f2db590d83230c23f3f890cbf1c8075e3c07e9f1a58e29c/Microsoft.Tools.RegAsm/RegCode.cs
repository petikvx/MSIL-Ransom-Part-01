using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Microsoft.Tools.RegAsm;

[ComVisible(false)]
internal static class RegCode
{
	private const string strDocStringPrefix = "";

	private const string strManagedTypeThreadingModel = "Both";

	private const string strClassesRootRegKey = "HKEY_CLASSES_ROOT";

	private const string strMsCorEEFileName = "mscoree.dll";

	private const int SuccessReturnCode = 0;

	private const int ErrorReturnCode = 100;

	private const int MAX_PATH = 260;

	internal static RegAsmOptions s_Options = null;

	internal static RegistrationServices s_RegistrationServices = new RegistrationServices();

	private static AssemblyResolver s_Resolver;

	internal static int Run(RegAsmOptions options)
	{
		s_Options = options;
		Output.SetSilent(options.m_bSilentMode);
		int result = 0;
		try
		{
			bool flag;
			if (flag = s_Options.m_strRegFileName != null)
			{
				s_Resolver = new AssemblyResolver(s_Options.m_strAsmPath);
			}
			Assembly assembly = null;
			try
			{
				assembly = ((!flag) ? Assembly.LoadFrom(s_Options.m_strAssemblyName) : Assembly.ReflectionOnlyLoadFrom(s_Options.m_strAssemblyName));
			}
			catch (BadImageFormatException innerException)
			{
				throw new ApplicationException(Resource.FormatString("Err_InvalidAssembly", s_Options.m_strAssemblyName), innerException);
			}
			catch (FileNotFoundException innerException2)
			{
				throw new ApplicationException(Resource.FormatString("Err_InputFileNotFound", s_Options.m_strAssemblyName), innerException2);
			}
			if (s_Options.m_strRegFileName != null)
			{
				if (string.Compare(s_Options.m_strAssemblyName, s_Options.m_strRegFileName, StringComparison.OrdinalIgnoreCase) == 0)
				{
					throw new ApplicationException(Resource.FormatString("Err_RegFileWouldOverwriteInput"));
				}
				if (s_Options.m_bSetCodeBase && assembly.GetName().GetPublicKey()!.Length == 0)
				{
					Output.WriteWarning(Resource.FormatString("Wrn_CodeBaseWithNoStrongName"));
				}
				if (GenerateRegFile(s_Options.m_strRegFileName, assembly))
				{
					Output.WriteInfo(Resource.FormatString("Msg_RegScriptGenerated", s_Options.m_strRegFileName));
					return result;
				}
				Output.WriteWarning(Resource.FormatString("Wrn_NoRegScriptGenerated"));
				return result;
			}
			if (s_Options.m_bRegister)
			{
				if (s_Options.m_bSetCodeBase && assembly.GetName().GetPublicKey()!.Length == 0)
				{
					Output.WriteWarning(Resource.FormatString("Wrn_CodeBaseWithNoStrongName"));
				}
				try
				{
					AssemblyRegistrationFlags assemblyRegistrationFlags = (s_Options.m_bSetCodeBase ? AssemblyRegistrationFlags.SetCodeBase : AssemblyRegistrationFlags.None);
					if (s_RegistrationServices.RegisterAssembly(assembly, assemblyRegistrationFlags))
					{
						Output.WriteInfo(Resource.FormatString("Msg_TypesRegistered"));
					}
					else if (!s_Options.m_bTypeLibSpecified)
					{
						Output.WriteWarning(Resource.FormatString("Wrn_NoTypesRegistered"));
					}
				}
				catch (UnauthorizedAccessException innerException3)
				{
					throw new ApplicationException(Resource.FormatString("Err_CannotWriteToRegistry"), innerException3);
				}
				if (s_Options.m_strTypeLibName != null)
				{
					RegisterMainTypeLib(assembly);
					return result;
				}
				return result;
			}
			if (s_RegistrationServices.UnregisterAssembly(assembly))
			{
				Output.WriteInfo(Resource.FormatString("Msg_TypesUnRegistered"));
			}
			else
			{
				Output.WriteWarning(Resource.FormatString("Wrn_NoTypesUnRegistered"));
			}
			if (s_Options.m_strTypeLibName != null)
			{
				if (IsAssemblyImportedFromCom(assembly))
				{
					Output.WriteWarning(Resource.FormatString("Wrn_ComTypelibNotUnregistered"));
					return result;
				}
				UnRegisterMainTypeLib();
				return result;
			}
			return result;
		}
		catch (TargetInvocationException ex)
		{
			Output.WriteError(Resource.FormatString("Err_ErrorInUserDefFunc") + ex.InnerException);
			return 100;
		}
		catch (ReflectionTypeLoadException ex2)
		{
			Output.WriteError(Resource.FormatString("Err_TypeLoadExceptions"));
			Exception[] loaderExceptions = ex2.LoaderExceptions;
			for (int i = 0; i < loaderExceptions.Length; i++)
			{
				try
				{
					Output.WriteError(Resource.FormatString("Msg_DisplayException", i, loaderExceptions[i]));
				}
				catch (Exception a)
				{
					Output.WriteError(Resource.FormatString("Msg_DisplayNestedException", i, a));
				}
			}
			return 100;
		}
		catch (Exception e)
		{
			Output.WriteError(e);
			return 100;
		}
	}

	internal static ITypeLib DoExportAndRegister(Assembly asm, string strTypeLibName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		ITypeLibConverter val = (ITypeLibConverter)new TypeLibConverter();
		ExporterCallback exporterCallback = new ExporterCallback();
		ITypeLib typeLib = (ITypeLib)val.ConvertAssemblyToTypeLib(asm, strTypeLibName, s_Options.m_Flags, (ITypeLibExporterNotifySink)(object)exporterCallback);
		try
		{
			ICreateITypeLib createITypeLib = (ICreateITypeLib)typeLib;
			createITypeLib.SaveAllChanges();
		}
		catch (Exception e)
		{
			ThrowAppException(Resource.FormatString("Err_TypelibSaveFailed"), e);
		}
		try
		{
			RegisterTypeLib(typeLib, strTypeLibName, Path.GetDirectoryName(strTypeLibName));
			return typeLib;
		}
		catch (Exception e2)
		{
			ThrowAppException(Resource.FormatString("Err_TypelibRegisterFailed"), e2);
			return typeLib;
		}
	}

	private static bool GenerateRegFile(string strRegFileName, Assembly asm)
	{
		Type[] registrableTypesInAssembly = s_RegistrationServices.GetRegistrableTypesInAssembly(asm);
		int num = registrableTypesInAssembly.Length;
		IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(asm);
		int count = customAttributes.Count;
		bool flag = false;
		for (int i = 0; i < count; i++)
		{
			if ((object)customAttributes[i].Constructor.DeclaringType == typeof(PrimaryInteropAssemblyAttribute))
			{
				flag = true;
				break;
			}
		}
		if (num == 0 && !flag)
		{
			return false;
		}
		Stream stream = File.Create(strRegFileName);
		WriteUTFChars(stream, "REGEDIT4" + Environment.NewLine);
		string fullName = asm.FullName;
		string strAsmVersion = asm.GetName().Version!.ToString();
		string imageRuntimeVersion = asm.ImageRuntimeVersion;
		string text = null;
		if (s_Options.m_bSetCodeBase)
		{
			text = asm.CodeBase;
			if (text == null)
			{
				throw new ApplicationException(Resource.FormatString("Err_NoAsmCodeBase", s_Options.m_strAssemblyName));
			}
		}
		for (int j = 0; j < num; j++)
		{
			if (IsRegisteredAsValueType(registrableTypesInAssembly[j]))
			{
				AddValueTypeToRegFile(registrableTypesInAssembly[j], fullName, strAsmVersion, text, imageRuntimeVersion, stream);
			}
			else if (s_RegistrationServices.TypeRepresentsComType(registrableTypesInAssembly[j]))
			{
				AddComImportedTypeToRegFile(registrableTypesInAssembly[j], fullName, strAsmVersion, text, imageRuntimeVersion, stream);
			}
			else
			{
				AddManagedTypeToRegFile(registrableTypesInAssembly[j], fullName, strAsmVersion, text, imageRuntimeVersion, stream);
			}
		}
		for (int k = 0; k < count; k++)
		{
			if ((object)customAttributes[k].Constructor.DeclaringType == typeof(PrimaryInteropAssemblyAttribute))
			{
				AddPrimaryInteropAssemblyToRegFile(Marshal.GetTypeLibGuidForAssembly(asm).ToString().ToUpper(CultureInfo.InvariantCulture), fullName, text, customAttributes[k], stream);
			}
		}
		stream.Close();
		return true;
	}

	private static void AddValueTypeToRegFile(Type type, string strAsmName, string strAsmVersion, string strAsmCodeBase, string strRuntimeVersion, Stream regFile)
	{
		string text = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		WriteUTFChars(regFile, Environment.NewLine);
		WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\Record\\" + text + "\\" + strAsmVersion + "]" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Class\"=\"" + type.FullName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Assembly\"=\"" + strAsmName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"RuntimeVersion\"=\"" + strRuntimeVersion + "\"" + Environment.NewLine);
		if (strAsmCodeBase != null)
		{
			WriteUTFChars(regFile, "\"CodeBase\"=\"" + strAsmCodeBase + "\"" + Environment.NewLine);
		}
	}

	private static void AddManagedTypeToRegFile(Type type, string strAsmName, string strAsmVersion, string strAsmCodeBase, string strRuntimeVersion, Stream regFile)
	{
		string text = "" + type.FullName;
		string text2 = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		string progIdForType = s_RegistrationServices.GetProgIdForType(type);
		if (progIdForType != string.Empty)
		{
			WriteUTFChars(regFile, Environment.NewLine);
			WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\" + progIdForType + "]" + Environment.NewLine);
			WriteUTFChars(regFile, "@=\"" + text + "\"" + Environment.NewLine);
			WriteUTFChars(regFile, Environment.NewLine);
			WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\" + progIdForType + "\\CLSID]" + Environment.NewLine);
			WriteUTFChars(regFile, "@=\"" + text2 + "\"" + Environment.NewLine);
		}
		WriteUTFChars(regFile, Environment.NewLine);
		WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\CLSID\\" + text2 + "]" + Environment.NewLine);
		WriteUTFChars(regFile, "@=\"" + text + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, Environment.NewLine);
		WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\CLSID\\" + text2 + "\\InprocServer32]" + Environment.NewLine);
		WriteUTFChars(regFile, "@=\"mscoree.dll\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"ThreadingModel\"=\"Both\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Class\"=\"" + type.FullName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Assembly\"=\"" + strAsmName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"RuntimeVersion\"=\"" + strRuntimeVersion + "\"" + Environment.NewLine);
		if (strAsmCodeBase != null)
		{
			WriteUTFChars(regFile, "\"CodeBase\"=\"" + strAsmCodeBase + "\"" + Environment.NewLine);
		}
		WriteUTFChars(regFile, Environment.NewLine);
		WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\CLSID\\" + text2 + "\\InprocServer32\\" + strAsmVersion + "]" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Class\"=\"" + type.FullName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Assembly\"=\"" + strAsmName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"RuntimeVersion\"=\"" + strRuntimeVersion + "\"" + Environment.NewLine);
		if (strAsmCodeBase != null)
		{
			WriteUTFChars(regFile, "\"CodeBase\"=\"" + strAsmCodeBase + "\"" + Environment.NewLine);
		}
		if (progIdForType != string.Empty)
		{
			WriteUTFChars(regFile, Environment.NewLine);
			WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\CLSID\\" + text2 + "\\ProgId]" + Environment.NewLine);
			WriteUTFChars(regFile, "@=\"" + progIdForType + "\"" + Environment.NewLine);
		}
		WriteUTFChars(regFile, Environment.NewLine);
		WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\CLSID\\" + text2 + "\\Implemented Categories\\{" + s_RegistrationServices.GetManagedCategoryGuid().ToString().ToUpper(CultureInfo.InvariantCulture) + "}]" + Environment.NewLine);
	}

	private static void AddComImportedTypeToRegFile(Type type, string strAsmName, string strAsmVersion, string strAsmCodeBase, string strRuntimeVersion, Stream regFile)
	{
		string text = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		WriteUTFChars(regFile, Environment.NewLine);
		WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\CLSID\\" + text + "\\InprocServer32]" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Class\"=\"" + type.FullName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Assembly\"=\"" + strAsmName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"RuntimeVersion\"=\"" + strRuntimeVersion + "\"" + Environment.NewLine);
		if (strAsmCodeBase != null)
		{
			WriteUTFChars(regFile, "\"CodeBase\"=\"" + strAsmCodeBase + "\"" + Environment.NewLine);
		}
		WriteUTFChars(regFile, Environment.NewLine);
		WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\CLSID\\" + text + "\\InprocServer32\\" + strAsmVersion + "]" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Class\"=\"" + type.FullName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"Assembly\"=\"" + strAsmName + "\"" + Environment.NewLine);
		WriteUTFChars(regFile, "\"RuntimeVersion\"=\"" + strRuntimeVersion + "\"" + Environment.NewLine);
		if (strAsmCodeBase != null)
		{
			WriteUTFChars(regFile, "\"CodeBase\"=\"" + strAsmCodeBase + "\"" + Environment.NewLine);
		}
	}

	private static void AddPrimaryInteropAssemblyToRegFile(string strAsmGuid, string strAsmName, string strAsmCodeBase, CustomAttributeData attr, Stream regFile)
	{
		string text = "{" + strAsmGuid + "}";
		int num = (int)attr.ConstructorArguments[0].Value;
		string text2 = string.Concat(str2: ((int)attr.ConstructorArguments[1].Value).ToString("x", CultureInfo.InvariantCulture), str0: num.ToString("x", CultureInfo.InvariantCulture), str1: ".");
		WriteUTFChars(regFile, Environment.NewLine);
		WriteUTFChars(regFile, "[HKEY_CLASSES_ROOT\\TypeLib\\" + text + "\\" + text2 + "]" + Environment.NewLine);
		WriteUTFChars(regFile, "\"PrimaryInteropAssemblyName\"=\"" + strAsmName + "\"" + Environment.NewLine);
		if (strAsmCodeBase != null)
		{
			WriteUTFChars(regFile, "\"PrimaryInteropAssemblyCodeBase\"=\"" + strAsmCodeBase + "\"" + Environment.NewLine);
		}
	}

	private static void WriteUTFChars(Stream s, string value)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(value);
		s.Write(bytes, 0, bytes.Length);
	}

	private static void RegisterMainTypeLib(Assembly asm)
	{
		ITypeLib TypeLib = null;
		if (s_Options.m_strAssemblyName == s_Options.m_strTypeLibName)
		{
			try
			{
				LoadTypeLibEx(s_Options.m_strTypeLibName, REGKIND.REGKIND_NONE, out TypeLib);
				if (TypeLib != null)
				{
					RegisterTypeLib(TypeLib, s_Options.m_strTypeLibName, Path.GetDirectoryName(s_Options.m_strTypeLibName));
					Output.WriteInfo(Resource.FormatString("Msg_EmbeddedTypelibReg", s_Options.m_strTypeLibName));
				}
			}
			catch (Exception)
			{
			}
		}
		if (TypeLib == null)
		{
			TypeLib = DoExportAndRegister(asm, s_Options.m_strTypeLibName);
			Output.WriteInfo(Resource.FormatString("Msg_AssemblyExportedAndReg", s_Options.m_strTypeLibName));
		}
	}

	private static void UnRegisterMainTypeLib()
	{
		ITypeLib TypeLib = null;
		IntPtr ppTLibAttr = (IntPtr)0;
		try
		{
			LoadTypeLibEx(s_Options.m_strTypeLibName, REGKIND.REGKIND_NONE, out TypeLib);
			TypeLib.GetLibAttr(out ppTLibAttr);
			TYPELIBATTR tYPELIBATTR = (TYPELIBATTR)Marshal.PtrToStructure(ppTLibAttr, typeof(TYPELIBATTR));
			UnRegisterTypeLib(ref tYPELIBATTR.guid, tYPELIBATTR.wMajorVerNum, tYPELIBATTR.wMinorVerNum, tYPELIBATTR.lcid, tYPELIBATTR.syskind);
		}
		catch (COMException ex)
		{
			if (ex.ErrorCode != -2147319780)
			{
				ThrowAppException(Resource.FormatString("Err_UnregistrationFailed"), ex);
			}
		}
		catch (Exception e)
		{
			ThrowAppException(Resource.FormatString("Err_UnregistrationFailed"), e);
		}
		finally
		{
			if (ppTLibAttr != (IntPtr)0)
			{
				TypeLib.ReleaseTLibAttr(ppTLibAttr);
			}
		}
		Output.WriteInfo(Resource.FormatString("Msg_TypelibUnregistered", s_Options.m_strTypeLibName));
	}

	private static bool IsAssemblyImportedFromCom(Assembly asm)
	{
		IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(asm);
		int num = 0;
		while (true)
		{
			if (num < customAttributes.Count)
			{
				if ((object)customAttributes[num].Constructor.DeclaringType == typeof(ImportedFromTypeLibAttribute))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool IsRegisteredAsValueType(Type type)
	{
		if (!type.IsValueType)
		{
			return false;
		}
		return true;
	}

	private static void ThrowAppException(string strPrefix, Exception e)
	{
		if (strPrefix == null)
		{
			strPrefix = "";
		}
		if (e.Message != null)
		{
			throw new ApplicationException(strPrefix + e.Message);
		}
		throw new ApplicationException(strPrefix + e.GetType().ToString());
	}

	[DllImport("oleaut32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	private static extern void LoadTypeLibEx(string strTypeLibName, REGKIND regKind, out ITypeLib TypeLib);

	[DllImport("oleaut32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	private static extern void RegisterTypeLib(ITypeLib TypeLib, string szFullPath, string szHelpDirs);

	[DllImport("oleaut32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
	private static extern void UnRegisterTypeLib(ref Guid libID, short wVerMajor, short wVerMinor, int lcid, SYSKIND syskind);
}
