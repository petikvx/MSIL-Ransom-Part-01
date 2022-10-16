using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DecoratorFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralWorker()
	{
	}
}
