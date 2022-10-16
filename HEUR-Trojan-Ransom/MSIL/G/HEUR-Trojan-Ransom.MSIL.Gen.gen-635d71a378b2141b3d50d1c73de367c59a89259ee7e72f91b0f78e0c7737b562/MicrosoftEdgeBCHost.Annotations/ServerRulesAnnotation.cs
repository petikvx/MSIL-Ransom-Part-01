using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResetOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetOrder()
	{
	}
}
