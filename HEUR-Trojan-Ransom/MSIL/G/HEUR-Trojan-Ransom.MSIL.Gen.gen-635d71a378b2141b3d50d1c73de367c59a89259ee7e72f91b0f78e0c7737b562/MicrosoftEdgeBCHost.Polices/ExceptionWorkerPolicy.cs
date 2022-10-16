using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExceptionWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceIndexer()
	{
	}
}
