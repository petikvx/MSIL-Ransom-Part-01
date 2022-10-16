using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DefinitionPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralContext()
	{
	}
}
