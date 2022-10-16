using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ItemUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceResolver()
	{
	}
}
