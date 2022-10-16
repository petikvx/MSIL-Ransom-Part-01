using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExpressionClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionClass()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceSerializer()
	{
	}
}
