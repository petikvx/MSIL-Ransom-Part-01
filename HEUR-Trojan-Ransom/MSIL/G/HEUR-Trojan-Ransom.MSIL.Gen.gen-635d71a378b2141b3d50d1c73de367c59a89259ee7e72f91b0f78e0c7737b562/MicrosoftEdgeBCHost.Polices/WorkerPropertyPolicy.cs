using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WorkerPropertyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerPropertyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralInterceptor()
	{
	}
}
