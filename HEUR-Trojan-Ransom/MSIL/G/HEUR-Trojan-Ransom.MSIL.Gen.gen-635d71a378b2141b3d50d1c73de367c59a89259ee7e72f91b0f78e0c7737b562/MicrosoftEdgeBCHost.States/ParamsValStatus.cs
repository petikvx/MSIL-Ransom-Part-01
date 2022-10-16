using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamsValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralRef()
	{
	}
}
