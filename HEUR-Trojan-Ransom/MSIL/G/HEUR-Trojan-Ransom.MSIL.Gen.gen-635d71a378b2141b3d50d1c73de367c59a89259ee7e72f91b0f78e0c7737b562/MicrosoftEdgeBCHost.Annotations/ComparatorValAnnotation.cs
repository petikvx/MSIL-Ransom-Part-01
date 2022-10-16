using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComparatorValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceToken()
	{
	}
}
