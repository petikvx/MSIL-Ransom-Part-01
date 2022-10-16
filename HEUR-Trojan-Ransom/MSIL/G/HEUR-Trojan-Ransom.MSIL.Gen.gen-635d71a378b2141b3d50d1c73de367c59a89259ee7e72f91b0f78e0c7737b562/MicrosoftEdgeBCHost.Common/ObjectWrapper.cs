using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ObjectWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeDecorator()
	{
	}
}
