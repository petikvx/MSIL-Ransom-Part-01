using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class OrderWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ListCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListCustomer()
	{
	}
}
