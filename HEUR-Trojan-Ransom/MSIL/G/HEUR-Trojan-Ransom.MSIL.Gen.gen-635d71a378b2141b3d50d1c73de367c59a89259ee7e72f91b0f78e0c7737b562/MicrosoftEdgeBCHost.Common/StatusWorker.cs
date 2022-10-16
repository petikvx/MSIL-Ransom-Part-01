using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StatusWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateAccount()
	{
	}
}
