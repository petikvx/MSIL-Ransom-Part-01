using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BaseUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceGlobal()
	{
	}
}
