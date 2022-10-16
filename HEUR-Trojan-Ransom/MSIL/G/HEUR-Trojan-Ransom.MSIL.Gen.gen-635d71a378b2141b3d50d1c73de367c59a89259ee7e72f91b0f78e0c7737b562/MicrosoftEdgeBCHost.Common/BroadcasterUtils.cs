using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BroadcasterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceAttr()
	{
	}
}
