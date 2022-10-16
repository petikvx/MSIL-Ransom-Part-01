using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DatabaseAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralValue()
	{
	}
}
