using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComposerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CancelHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelHelper()
	{
	}
}
