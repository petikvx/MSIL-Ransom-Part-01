using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContextUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralClass()
	{
	}
}
