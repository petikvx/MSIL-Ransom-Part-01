using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PolicyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceInfo()
	{
	}
}
