using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IteratorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorClass()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceStruct()
	{
	}
}
