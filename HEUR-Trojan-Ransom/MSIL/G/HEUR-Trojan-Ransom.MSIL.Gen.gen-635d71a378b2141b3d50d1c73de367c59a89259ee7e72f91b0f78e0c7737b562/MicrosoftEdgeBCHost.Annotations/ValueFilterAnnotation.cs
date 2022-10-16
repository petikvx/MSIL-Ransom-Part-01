using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValueFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceAdapter()
	{
	}
}
