using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FilterWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		SelectCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectCustomer()
	{
	}
}
