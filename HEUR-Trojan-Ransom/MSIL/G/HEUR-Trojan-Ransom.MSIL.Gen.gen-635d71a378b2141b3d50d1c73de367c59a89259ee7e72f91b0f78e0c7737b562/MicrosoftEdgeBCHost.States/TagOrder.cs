using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TagOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagOrder()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterceptor()
	{
	}
}
