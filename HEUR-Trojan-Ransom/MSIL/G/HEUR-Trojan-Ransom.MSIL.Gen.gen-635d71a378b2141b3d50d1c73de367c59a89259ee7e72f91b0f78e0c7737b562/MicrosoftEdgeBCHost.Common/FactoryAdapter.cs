using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class FactoryAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceServer()
	{
	}
}
