using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ErrorWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceIndexer()
	{
	}
}
