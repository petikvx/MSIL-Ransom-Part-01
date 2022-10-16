using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralImporter()
	{
	}
}
