using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceVisitor()
	{
	}
}
