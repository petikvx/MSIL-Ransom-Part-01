using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PoolValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralError()
	{
	}
}
