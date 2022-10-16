using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SetterValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterceptor()
	{
	}
}
