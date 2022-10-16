using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StatusRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CreatePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreatePublisher()
	{
	}
}
