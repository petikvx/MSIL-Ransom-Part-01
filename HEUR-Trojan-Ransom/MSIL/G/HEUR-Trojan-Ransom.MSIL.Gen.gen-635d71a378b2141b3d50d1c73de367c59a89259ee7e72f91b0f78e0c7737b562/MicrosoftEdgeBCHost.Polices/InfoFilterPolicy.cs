using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InfoFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyStatus()
	{
	}
}
