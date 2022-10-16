using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CustomerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerRules()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateListener()
	{
	}
}
