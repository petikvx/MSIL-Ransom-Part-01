using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FactoryState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryState()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceMessage()
	{
	}
}
