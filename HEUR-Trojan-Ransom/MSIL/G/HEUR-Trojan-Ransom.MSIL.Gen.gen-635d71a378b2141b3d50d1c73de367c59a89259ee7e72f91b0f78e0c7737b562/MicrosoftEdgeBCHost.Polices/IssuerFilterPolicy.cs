using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class IssuerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CancelTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelTemplate()
	{
	}
}
