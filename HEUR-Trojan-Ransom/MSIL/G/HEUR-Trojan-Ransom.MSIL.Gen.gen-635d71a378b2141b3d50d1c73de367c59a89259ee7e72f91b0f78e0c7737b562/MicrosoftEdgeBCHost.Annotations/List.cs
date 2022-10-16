using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class List
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static List()
	{
		WriterPropertyProducer.ResolveStub();
		AddGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddGetter()
	{
	}
}
