using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TagProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceDic()
	{
	}
}
