using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValueOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceCustomer()
	{
	}
}
