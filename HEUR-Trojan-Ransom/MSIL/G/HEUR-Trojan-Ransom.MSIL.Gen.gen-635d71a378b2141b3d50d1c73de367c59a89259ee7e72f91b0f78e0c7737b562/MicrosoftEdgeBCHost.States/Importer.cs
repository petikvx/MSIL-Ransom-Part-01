using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class Importer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Importer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteIdentifier()
	{
	}
}
