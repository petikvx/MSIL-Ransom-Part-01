using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcValException()
	{
		WriterPropertyProducer.ResolveStub();
		OrderTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderTests()
	{
	}
}
