using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralAnnotation()
	{
	}
}
