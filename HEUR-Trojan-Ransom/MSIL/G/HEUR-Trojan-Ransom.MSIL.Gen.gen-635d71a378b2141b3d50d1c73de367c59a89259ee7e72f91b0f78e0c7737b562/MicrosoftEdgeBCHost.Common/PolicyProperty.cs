using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PolicyProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceCustomer()
	{
	}
}
