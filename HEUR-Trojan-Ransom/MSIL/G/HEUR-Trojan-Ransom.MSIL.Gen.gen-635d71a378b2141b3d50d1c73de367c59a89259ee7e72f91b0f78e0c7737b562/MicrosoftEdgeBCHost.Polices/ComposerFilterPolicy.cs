using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComposerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotParams()
	{
	}
}
