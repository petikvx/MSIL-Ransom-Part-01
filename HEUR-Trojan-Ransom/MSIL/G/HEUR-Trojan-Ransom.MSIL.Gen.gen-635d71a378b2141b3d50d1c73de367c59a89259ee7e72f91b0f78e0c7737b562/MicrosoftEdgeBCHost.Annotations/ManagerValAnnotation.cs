using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ManagerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralIssuer()
	{
	}
}
