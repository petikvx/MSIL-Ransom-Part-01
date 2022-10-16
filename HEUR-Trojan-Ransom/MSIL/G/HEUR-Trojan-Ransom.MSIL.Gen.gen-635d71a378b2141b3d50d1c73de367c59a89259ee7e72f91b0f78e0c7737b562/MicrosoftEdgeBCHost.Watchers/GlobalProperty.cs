using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GlobalProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceCustomer()
	{
	}
}
