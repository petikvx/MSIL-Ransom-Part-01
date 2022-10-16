using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FieldUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldUtils()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfacePrototype()
	{
	}
}
