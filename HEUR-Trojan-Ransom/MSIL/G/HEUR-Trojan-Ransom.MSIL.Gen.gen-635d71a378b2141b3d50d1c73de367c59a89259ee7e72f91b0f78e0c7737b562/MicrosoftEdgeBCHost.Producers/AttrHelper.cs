using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttrHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrHelper()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralHelper()
	{
	}
}
