using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SystemRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopRepository()
	{
	}
}
