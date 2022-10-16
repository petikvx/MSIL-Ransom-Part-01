using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StructClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructClass()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfacePolicy()
	{
	}
}
