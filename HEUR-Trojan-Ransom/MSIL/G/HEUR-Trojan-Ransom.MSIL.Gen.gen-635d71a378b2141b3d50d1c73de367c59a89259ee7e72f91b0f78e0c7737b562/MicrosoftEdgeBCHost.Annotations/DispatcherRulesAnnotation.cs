using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DispatcherRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PushContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushContainer()
	{
	}
}
