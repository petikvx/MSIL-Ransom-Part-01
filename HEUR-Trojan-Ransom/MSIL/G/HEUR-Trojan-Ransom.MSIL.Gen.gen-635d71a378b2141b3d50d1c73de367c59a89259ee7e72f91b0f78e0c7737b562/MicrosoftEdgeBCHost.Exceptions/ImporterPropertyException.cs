using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ImporterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralMock()
	{
	}
}
