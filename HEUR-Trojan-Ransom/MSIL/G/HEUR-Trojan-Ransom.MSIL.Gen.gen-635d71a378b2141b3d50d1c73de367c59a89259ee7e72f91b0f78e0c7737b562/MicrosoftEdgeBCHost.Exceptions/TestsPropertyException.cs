using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestsPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralWriter()
	{
	}
}
