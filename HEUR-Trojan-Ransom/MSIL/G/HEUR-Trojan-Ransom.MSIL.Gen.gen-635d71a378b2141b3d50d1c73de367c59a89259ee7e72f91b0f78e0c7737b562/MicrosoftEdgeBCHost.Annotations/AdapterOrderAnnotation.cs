using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AdapterOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralCreator()
	{
	}
}
