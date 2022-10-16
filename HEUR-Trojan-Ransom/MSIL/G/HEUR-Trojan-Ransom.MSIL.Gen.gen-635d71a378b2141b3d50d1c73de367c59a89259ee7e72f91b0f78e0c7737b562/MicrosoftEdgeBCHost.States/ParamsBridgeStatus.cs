using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamsBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateModel()
	{
	}
}
