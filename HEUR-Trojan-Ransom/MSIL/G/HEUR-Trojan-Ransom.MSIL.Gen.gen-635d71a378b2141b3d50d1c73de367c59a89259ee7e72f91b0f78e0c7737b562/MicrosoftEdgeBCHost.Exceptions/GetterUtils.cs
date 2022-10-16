using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GetterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceResolver()
	{
	}
}
