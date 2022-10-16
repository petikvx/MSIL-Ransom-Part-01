using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValUtils()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceMap()
	{
	}
}
