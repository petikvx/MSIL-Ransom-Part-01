using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContextContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextContext()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceRules()
	{
	}
}
