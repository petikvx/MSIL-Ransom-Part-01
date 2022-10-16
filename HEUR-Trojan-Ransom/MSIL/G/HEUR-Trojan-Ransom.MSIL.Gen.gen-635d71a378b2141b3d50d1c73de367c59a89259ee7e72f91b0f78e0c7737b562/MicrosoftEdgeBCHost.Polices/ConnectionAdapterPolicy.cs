using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConnectionAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralOrder()
	{
	}
}
