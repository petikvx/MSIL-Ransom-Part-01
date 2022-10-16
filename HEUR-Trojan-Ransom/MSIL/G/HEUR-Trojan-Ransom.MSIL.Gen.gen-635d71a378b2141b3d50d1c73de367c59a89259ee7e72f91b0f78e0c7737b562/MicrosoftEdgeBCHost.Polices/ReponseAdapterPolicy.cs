using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralInitializer()
	{
	}
}
