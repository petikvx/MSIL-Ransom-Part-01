using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttrWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralInfo()
	{
	}
}
