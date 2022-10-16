using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CompareAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareAnnotation()
	{
	}
}
