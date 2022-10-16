using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExceptionWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralRequest()
	{
	}
}
