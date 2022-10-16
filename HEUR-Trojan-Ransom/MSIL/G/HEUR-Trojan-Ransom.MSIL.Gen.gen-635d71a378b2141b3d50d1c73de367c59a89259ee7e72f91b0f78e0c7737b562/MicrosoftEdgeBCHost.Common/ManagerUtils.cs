using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ManagerUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceVal()
	{
	}
}
