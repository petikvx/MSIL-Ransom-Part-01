using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DecoratorValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralObject()
	{
	}
}
