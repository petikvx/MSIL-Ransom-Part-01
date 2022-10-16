using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TaskWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceTemplate()
	{
	}
}
