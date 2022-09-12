using System.Runtime.InteropServices;

namespace ac.Exporters;

internal static class ReponseFieldExporter
{
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(int insertLASTAt, int previousconnection);
}
