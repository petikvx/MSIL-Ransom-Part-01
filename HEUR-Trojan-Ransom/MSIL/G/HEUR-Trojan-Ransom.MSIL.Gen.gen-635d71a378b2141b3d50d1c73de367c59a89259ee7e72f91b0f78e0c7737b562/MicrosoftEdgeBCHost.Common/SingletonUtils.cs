using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SingletonUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonUtils()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfacePrototype()
	{
	}
}
