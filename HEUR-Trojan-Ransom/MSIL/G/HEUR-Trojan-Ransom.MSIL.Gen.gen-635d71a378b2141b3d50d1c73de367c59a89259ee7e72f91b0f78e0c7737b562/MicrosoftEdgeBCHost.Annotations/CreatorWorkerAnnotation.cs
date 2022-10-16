using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CreatorWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralSetter()
	{
	}
}
