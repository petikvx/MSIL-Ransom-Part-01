using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObserverWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PrintService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintService()
	{
	}
}
