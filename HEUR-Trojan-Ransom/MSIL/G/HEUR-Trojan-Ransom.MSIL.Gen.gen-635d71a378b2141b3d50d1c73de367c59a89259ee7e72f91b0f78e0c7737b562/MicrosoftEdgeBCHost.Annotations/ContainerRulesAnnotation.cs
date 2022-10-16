using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContainerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		NewReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewReponse()
	{
	}
}
