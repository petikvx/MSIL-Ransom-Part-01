using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContextPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralPrototype()
	{
	}
}
