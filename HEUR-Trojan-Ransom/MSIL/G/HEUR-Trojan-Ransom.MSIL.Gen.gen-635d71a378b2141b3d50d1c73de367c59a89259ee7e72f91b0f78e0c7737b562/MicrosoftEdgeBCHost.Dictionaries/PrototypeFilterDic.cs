using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrototypeFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralEvent()
	{
	}
}
