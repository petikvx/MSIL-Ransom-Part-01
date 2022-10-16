using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CustomerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralProcess()
	{
	}
}
