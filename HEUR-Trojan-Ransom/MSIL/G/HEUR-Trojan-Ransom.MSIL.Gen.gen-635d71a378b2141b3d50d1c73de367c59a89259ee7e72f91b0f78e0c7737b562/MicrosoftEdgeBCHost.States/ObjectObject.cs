using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObjectObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectObject()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralOrder()
	{
	}
}
