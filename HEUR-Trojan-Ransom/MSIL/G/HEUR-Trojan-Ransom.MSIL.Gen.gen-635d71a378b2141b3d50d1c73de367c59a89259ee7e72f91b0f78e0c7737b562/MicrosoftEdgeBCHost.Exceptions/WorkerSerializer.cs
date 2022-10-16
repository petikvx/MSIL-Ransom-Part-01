using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WorkerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralGetter()
	{
	}
}
