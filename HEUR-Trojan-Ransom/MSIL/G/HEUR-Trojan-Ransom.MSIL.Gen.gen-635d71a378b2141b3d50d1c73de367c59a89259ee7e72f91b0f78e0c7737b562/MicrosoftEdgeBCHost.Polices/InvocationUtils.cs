using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InvocationUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceGlobal()
	{
	}
}
