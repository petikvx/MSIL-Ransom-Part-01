using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DatabaseHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralReponse()
	{
	}
}
