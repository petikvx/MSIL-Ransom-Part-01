using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrototypeFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceTests()
	{
	}
}
