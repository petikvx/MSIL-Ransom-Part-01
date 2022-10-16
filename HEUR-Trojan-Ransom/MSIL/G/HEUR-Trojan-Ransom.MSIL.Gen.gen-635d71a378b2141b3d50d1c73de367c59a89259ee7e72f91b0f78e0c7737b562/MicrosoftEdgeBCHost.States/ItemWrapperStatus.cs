using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ItemWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateDic()
	{
	}
}
