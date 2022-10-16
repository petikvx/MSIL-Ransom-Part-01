using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProccesorWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectList()
	{
	}
}
