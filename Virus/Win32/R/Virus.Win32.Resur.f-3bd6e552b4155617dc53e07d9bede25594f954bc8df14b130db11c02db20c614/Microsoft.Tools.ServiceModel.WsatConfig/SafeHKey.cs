using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class SafeHKey : SafeClusterHandle
{
	[DllImport("clusapi.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static extern int ClusterRegCloseKey([In] IntPtr hEnum);

	protected override bool ReleaseHandle()
	{
		return ClusterRegCloseKey(handle) == 0L;
	}
}
