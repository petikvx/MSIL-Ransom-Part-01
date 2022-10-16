using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AlgoOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralFilter()
	{
	}
}
