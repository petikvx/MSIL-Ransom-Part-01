using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInitializer()
	{
	}
}
