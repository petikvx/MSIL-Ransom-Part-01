using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SetterWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralFilter()
	{
	}
}
