using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InvocationObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationObject()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralTemplate()
	{
	}
}
