using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class UtilsUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsUtils()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceRef()
	{
	}
}
