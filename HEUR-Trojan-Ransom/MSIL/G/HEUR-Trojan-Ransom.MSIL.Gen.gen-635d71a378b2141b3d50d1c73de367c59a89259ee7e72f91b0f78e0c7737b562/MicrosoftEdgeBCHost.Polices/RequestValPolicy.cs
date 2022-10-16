using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RequestValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterPolicy()
	{
	}
}
