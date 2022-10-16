using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class UtilsWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CompareCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareCustomer()
	{
	}
}
