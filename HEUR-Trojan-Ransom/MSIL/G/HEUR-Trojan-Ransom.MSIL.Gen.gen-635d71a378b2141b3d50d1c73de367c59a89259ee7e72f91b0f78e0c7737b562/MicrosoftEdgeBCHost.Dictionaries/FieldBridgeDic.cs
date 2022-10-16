using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FieldBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceMethod()
	{
	}
}
