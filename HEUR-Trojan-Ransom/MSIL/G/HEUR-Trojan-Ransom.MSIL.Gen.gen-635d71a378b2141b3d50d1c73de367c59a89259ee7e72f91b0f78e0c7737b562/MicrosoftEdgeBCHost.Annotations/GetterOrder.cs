using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GetterOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CollectProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectProc()
	{
	}
}
