using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClientValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceCustomer()
	{
	}
}
