using System;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.RegAsm;

internal class RemoteRegAsm : MarshalByRefObject
{
	internal int Run(string strAssemblyName, string strTypeLibName, bool bRegister, bool bSetCodeBase, string strRegFileName, bool bNoLogo, bool bSilentMode, bool bVerboseMode, bool bTypeLibSpecified, bool bRegFileSpecified, TypeLibExporterFlags Flags, string strAsmPath)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		RegAsmOptions regAsmOptions = new RegAsmOptions();
		regAsmOptions.m_strAssemblyName = strAssemblyName;
		regAsmOptions.m_strTypeLibName = strTypeLibName;
		regAsmOptions.m_bRegister = bRegister;
		regAsmOptions.m_bSetCodeBase = bSetCodeBase;
		regAsmOptions.m_strRegFileName = strRegFileName;
		regAsmOptions.m_bNoLogo = bNoLogo;
		regAsmOptions.m_bSilentMode = bSilentMode;
		regAsmOptions.m_bVerboseMode = bVerboseMode;
		regAsmOptions.m_bTypeLibSpecified = bTypeLibSpecified;
		regAsmOptions.m_bRegFileSpecified = bRegFileSpecified;
		regAsmOptions.m_Flags = Flags;
		regAsmOptions.m_strAsmPath = strAsmPath;
		return RegCode.Run(regAsmOptions);
	}
}
