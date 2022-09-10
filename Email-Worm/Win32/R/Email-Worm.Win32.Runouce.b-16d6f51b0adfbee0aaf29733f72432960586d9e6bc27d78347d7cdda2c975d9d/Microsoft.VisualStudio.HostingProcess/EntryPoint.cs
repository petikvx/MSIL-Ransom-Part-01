using System.Diagnostics;

namespace Microsoft.VisualStudio.HostingProcess;

public sealed class EntryPoint
{
	private EntryPoint()
	{
	}

	[DebuggerNonUserCode]
	public static void Main()
	{
		if (Synchronize.get_HostingProcessInitialized() != null)
		{
			Synchronize.get_HostingProcessInitialized().Set();
			if (Synchronize.get_StartRunningUsersAssembly() != null)
			{
				Synchronize.get_StartRunningUsersAssembly().WaitOne();
			}
		}
	}
}
