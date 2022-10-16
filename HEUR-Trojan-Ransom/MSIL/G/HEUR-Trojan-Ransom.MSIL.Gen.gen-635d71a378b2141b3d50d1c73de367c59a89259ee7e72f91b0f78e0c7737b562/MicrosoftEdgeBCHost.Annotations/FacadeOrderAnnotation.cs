using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FacadeOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralReponse()
	{
	}
}
