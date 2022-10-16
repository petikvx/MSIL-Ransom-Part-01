using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContainerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralContainer()
	{
	}
}
