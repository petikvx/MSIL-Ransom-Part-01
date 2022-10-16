using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StateWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralDecorator()
	{
	}
}
