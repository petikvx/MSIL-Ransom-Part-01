using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WrapperOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralCallback()
	{
	}
}
