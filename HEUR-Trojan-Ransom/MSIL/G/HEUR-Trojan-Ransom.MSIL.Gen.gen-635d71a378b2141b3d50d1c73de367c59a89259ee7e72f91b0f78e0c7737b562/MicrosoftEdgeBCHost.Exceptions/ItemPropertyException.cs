using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralWriter()
	{
	}
}
