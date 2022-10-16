using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamVal()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveUtils()
	{
	}
}
