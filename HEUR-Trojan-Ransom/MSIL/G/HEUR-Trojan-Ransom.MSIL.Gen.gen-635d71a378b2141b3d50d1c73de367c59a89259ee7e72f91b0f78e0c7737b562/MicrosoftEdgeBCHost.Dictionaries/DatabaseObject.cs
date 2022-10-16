using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DatabaseObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseObject()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralCandidate()
	{
	}
}
