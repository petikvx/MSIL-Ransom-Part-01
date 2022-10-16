using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralComposer()
	{
	}
}
