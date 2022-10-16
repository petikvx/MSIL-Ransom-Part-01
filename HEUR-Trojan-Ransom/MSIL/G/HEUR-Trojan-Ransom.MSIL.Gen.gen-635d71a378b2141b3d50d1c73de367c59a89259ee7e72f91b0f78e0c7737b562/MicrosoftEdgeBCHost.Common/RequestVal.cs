using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RequestVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestVal()
	{
		WriterPropertyProducer.ResolveStub();
		StartContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartContainer()
	{
	}
}
