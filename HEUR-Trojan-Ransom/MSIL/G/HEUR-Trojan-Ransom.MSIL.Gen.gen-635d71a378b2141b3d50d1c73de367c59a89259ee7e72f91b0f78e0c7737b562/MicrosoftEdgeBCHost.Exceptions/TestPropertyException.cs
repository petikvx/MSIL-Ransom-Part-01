using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralPrinter()
	{
	}
}
