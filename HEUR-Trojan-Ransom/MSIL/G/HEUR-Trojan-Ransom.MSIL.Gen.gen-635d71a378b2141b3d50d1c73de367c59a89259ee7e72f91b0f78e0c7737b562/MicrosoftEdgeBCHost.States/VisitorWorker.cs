using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class VisitorWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorWorker()
	{
		WriterPropertyProducer.ResolveStub();
		FillAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillAccount()
	{
	}
}
