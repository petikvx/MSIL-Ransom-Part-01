using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClassProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassProperty()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceCustomer()
	{
	}
}
