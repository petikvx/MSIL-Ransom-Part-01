using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TemplateWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceReader()
	{
	}
}
