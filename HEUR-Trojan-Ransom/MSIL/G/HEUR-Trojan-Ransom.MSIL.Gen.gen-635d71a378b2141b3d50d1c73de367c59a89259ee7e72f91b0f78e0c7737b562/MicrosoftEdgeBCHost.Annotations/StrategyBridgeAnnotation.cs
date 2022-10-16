using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StrategyBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutRole()
	{
	}
}
