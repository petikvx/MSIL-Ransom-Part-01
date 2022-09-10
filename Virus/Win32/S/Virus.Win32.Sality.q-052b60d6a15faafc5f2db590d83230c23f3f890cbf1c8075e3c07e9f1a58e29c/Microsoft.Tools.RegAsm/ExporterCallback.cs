using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.RegAsm;

internal class ExporterCallback : ITypeLibExporterNotifySink
{
	public void ReportEvent(ExporterEventKind EventKind, int EventCode, string EventMsg)
	{
		if (EventKind == ExporterEventKind.NOTIF_TYPECONVERTED)
		{
			if (RegCode.s_Options.m_bVerboseMode)
			{
				Output.WriteInfo(EventMsg);
			}
		}
		else
		{
			Output.WriteInfo(EventMsg);
		}
	}

	public object ResolveRef(Assembly asm)
	{
		string directoryName = Path.GetDirectoryName(asm.Location);
		string name = asm.GetName().Name;
		string text = Path.Combine(directoryName, name) + ".tlb";
		if (RegCode.s_Options.m_bVerboseMode)
		{
			Output.WriteInfo(Resource.FormatString("Msg_AutoExpAndRegAssembly", name, text));
		}
		return RegCode.DoExportAndRegister(asm, text);
	}
}
