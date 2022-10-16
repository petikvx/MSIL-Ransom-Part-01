using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StubWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralGetter()
	{
	}
}
