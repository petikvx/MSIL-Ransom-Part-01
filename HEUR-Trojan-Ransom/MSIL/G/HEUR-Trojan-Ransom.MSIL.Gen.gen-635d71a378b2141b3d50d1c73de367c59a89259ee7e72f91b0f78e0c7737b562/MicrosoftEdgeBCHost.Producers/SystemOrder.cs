using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SystemOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemOrder()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyStruct()
	{
	}
}
