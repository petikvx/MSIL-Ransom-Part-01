using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComposerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceInvocation()
	{
	}
}
