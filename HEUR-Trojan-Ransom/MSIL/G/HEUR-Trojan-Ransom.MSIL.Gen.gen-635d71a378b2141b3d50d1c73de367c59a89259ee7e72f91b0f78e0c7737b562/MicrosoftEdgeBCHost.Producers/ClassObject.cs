using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassObject()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralOrder()
	{
	}
}
