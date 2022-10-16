using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PropertyWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralClient()
	{
	}
}
