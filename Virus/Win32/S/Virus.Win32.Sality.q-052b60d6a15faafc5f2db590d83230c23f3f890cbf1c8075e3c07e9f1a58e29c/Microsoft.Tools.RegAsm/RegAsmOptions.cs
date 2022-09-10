using System.Runtime.InteropServices;

namespace Microsoft.Tools.RegAsm;

internal sealed class RegAsmOptions
{
	internal string m_strAssemblyName;

	internal string m_strTypeLibName;

	internal bool m_bRegister = true;

	internal bool m_bSetCodeBase;

	internal string m_strRegFileName;

	internal bool m_bNoLogo;

	internal bool m_bSilentMode;

	internal bool m_bVerboseMode;

	internal bool m_bTypeLibSpecified;

	internal bool m_bRegFileSpecified;

	internal TypeLibExporterFlags m_Flags;

	internal string m_strAsmPath;
}
