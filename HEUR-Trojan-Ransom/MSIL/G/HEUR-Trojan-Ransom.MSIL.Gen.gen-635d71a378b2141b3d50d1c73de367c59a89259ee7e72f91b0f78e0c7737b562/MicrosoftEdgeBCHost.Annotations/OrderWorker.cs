using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class OrderWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CreateProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateProcess()
	{
	}
}
