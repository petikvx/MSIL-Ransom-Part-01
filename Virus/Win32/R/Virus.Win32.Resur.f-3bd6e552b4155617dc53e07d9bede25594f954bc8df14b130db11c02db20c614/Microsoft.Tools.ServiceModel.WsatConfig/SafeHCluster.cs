using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class SafeHCluster : SafeClusterHandle
{
	[DllImport("clusapi.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool CloseCluster([In] IntPtr hCluster);

	protected override bool ReleaseHandle()
	{
		return CloseCluster(handle);
	}
}
