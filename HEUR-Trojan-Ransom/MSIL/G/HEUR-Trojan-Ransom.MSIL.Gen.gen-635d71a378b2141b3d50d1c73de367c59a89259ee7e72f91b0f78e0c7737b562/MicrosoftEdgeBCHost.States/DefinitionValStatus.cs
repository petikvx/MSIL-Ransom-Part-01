using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DefinitionValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralParser()
	{
	}
}
