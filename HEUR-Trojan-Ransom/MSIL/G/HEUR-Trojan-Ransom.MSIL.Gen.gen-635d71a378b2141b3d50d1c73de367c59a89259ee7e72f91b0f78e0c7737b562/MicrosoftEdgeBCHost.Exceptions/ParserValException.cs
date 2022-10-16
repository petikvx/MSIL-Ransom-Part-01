using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParserValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserValException()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveDescriptor()
	{
	}
}
