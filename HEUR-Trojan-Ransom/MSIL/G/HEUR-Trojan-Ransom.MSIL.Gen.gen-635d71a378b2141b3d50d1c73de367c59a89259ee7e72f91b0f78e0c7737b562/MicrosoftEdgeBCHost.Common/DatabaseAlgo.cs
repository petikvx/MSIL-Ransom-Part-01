using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DatabaseAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralInitializer()
	{
	}
}
