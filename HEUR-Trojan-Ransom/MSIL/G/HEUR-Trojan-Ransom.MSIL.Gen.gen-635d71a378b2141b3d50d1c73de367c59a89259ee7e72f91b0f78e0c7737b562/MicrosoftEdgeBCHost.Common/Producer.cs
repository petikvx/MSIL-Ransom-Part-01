using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class Producer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Producer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetGetter()
	{
	}
}
