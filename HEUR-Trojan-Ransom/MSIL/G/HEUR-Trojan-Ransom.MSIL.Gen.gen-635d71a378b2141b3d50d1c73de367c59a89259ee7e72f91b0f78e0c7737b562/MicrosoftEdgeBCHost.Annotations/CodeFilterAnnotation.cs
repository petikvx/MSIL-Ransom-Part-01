using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CodeFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceVal()
	{
	}
}
