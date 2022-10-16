using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RegValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegValException()
	{
		WriterPropertyProducer.ResolveStub();
		QueryValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryValue()
	{
	}
}
