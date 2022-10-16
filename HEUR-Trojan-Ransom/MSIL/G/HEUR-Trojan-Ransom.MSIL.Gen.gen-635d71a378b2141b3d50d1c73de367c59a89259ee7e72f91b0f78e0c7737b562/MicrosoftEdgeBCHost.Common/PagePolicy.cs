using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PagePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PagePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceCreator()
	{
	}
}
