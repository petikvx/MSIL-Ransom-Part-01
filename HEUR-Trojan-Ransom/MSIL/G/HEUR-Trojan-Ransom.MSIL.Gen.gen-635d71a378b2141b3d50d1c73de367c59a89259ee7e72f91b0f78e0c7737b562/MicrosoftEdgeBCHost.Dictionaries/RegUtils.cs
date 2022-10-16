using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegUtils()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfacePrototype()
	{
	}
}
