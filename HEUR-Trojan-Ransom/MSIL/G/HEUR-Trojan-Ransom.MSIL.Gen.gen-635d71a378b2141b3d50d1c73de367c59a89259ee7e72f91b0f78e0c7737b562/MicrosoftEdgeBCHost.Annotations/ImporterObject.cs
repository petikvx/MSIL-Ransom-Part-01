using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ImporterObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterObject()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralComposer()
	{
	}
}
