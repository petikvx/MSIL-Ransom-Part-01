using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class SafeHClusEnum : SafeClusterHandle
{
	[DllImport("clusapi.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static extern uint ClusterCloseEnum([In] IntPtr hEnum);

	protected override bool ReleaseHandle()
	{
		return ClusterCloseEnum(handle) == 0;
	}
}
