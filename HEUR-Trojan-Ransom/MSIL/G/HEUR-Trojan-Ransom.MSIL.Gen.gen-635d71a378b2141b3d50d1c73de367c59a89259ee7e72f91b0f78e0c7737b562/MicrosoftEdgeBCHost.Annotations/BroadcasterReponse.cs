using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BroadcasterReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralManager()
	{
	}
}
