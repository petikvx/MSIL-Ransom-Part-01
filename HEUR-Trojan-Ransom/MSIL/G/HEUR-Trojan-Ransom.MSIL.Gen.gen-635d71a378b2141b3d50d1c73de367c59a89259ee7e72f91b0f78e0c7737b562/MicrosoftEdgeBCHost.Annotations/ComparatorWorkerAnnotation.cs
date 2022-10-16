using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComparatorWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralPrototype()
	{
	}
}
