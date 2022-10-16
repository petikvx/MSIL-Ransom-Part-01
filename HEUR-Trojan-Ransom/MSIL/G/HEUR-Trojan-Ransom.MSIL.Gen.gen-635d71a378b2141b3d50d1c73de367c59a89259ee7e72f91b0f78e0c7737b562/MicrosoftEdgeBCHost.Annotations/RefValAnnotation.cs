using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RefValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralFactory()
	{
	}
}
