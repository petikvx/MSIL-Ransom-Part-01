using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GetterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralError()
	{
	}
}
