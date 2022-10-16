using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObjectAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceWorker()
	{
	}
}
