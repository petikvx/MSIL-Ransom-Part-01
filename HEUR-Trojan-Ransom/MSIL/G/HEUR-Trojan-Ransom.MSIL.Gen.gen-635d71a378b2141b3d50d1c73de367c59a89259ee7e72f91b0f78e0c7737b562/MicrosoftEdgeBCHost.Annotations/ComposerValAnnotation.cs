using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComposerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfacePolicy()
	{
	}
}
