using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParserWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ListSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListSpecification()
	{
	}
}
