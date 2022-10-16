using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class BridgeWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InsertCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertCustomer()
	{
	}
}
