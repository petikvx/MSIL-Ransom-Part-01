using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComposerReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerReponse()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralObject()
	{
	}
}
