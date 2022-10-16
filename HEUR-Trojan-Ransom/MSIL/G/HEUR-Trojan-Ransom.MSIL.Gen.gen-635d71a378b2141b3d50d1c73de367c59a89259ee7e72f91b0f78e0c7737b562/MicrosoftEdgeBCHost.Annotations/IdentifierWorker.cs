using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IdentifierWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWorker()
	{
		WriterPropertyProducer.ResolveStub();
		SelectCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectCallback()
	{
	}
}
