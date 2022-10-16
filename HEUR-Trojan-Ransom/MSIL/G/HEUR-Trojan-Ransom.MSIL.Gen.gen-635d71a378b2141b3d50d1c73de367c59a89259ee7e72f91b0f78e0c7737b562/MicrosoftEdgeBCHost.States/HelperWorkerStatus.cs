using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralUtils()
	{
	}
}
