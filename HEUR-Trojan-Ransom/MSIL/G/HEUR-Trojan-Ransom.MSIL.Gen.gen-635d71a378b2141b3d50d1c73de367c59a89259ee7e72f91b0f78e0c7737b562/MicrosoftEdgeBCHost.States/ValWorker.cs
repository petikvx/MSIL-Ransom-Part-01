using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWorker()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutProcess()
	{
	}
}
