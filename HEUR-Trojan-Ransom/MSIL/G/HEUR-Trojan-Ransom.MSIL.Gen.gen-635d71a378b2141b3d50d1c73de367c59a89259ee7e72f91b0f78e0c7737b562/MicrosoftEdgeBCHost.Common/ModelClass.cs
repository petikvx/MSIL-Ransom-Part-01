using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ModelClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelClass()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceStruct()
	{
	}
}
