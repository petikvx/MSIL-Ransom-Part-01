using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class GetterReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralIdentifier()
	{
	}
}
