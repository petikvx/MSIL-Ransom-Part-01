using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CallbackFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackFilter()
	{
		WriterPropertyProducer.ResolveStub();
		StopMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopMock()
	{
	}
}
