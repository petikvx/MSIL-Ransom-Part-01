using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FieldBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldBridge()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeVal()
	{
	}
}
