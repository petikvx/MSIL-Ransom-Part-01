using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RulesAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceMethod()
	{
	}
}
