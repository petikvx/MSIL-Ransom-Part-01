using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MethodOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfacePrinter()
	{
	}
}
