using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AnnotationPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceDatabase()
	{
	}
}
