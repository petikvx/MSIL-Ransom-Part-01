using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class SafeHResource : SafeClusterHandle
{
	[DllImport("clusapi.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static extern bool CloseClusterResource([In] IntPtr hResource);

	protected override bool ReleaseHandle()
	{
		return CloseClusterResource(handle);
	}
}
