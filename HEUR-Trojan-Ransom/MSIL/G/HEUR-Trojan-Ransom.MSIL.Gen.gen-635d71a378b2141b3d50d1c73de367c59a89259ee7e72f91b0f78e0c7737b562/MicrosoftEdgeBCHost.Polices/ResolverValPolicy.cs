using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ResolverValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceCustomer()
	{
	}
}
