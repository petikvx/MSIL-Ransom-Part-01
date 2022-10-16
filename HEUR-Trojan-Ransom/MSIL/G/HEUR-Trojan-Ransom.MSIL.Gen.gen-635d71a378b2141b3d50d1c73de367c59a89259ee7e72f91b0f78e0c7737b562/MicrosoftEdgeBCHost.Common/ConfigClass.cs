using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigClass()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceObserver()
	{
	}
}
