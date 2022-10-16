using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RulesContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesContext()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyInterfaceClient()
	{
	}
}
