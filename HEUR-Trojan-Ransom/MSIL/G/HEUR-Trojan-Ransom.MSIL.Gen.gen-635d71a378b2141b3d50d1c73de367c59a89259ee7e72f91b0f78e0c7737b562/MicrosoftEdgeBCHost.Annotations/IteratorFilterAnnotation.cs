using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IteratorFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceTag()
	{
	}
}
