using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MappingBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceCustomer()
	{
	}
}
