using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InfoValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageSchema()
	{
	}
}
