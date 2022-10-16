using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReaderWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceTag()
	{
	}
}
