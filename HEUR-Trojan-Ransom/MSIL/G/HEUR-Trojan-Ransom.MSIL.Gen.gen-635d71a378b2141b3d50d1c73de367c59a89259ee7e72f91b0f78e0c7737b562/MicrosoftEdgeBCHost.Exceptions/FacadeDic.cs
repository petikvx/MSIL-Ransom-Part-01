using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FacadeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeDic()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralSpecification()
	{
	}
}
