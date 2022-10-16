using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComposerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfacePrinter()
	{
	}
}
