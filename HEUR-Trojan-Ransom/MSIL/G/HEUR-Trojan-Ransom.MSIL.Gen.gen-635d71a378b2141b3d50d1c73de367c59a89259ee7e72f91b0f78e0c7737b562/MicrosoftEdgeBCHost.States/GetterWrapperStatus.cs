using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class GetterWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DisableDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableDic()
	{
	}
}
