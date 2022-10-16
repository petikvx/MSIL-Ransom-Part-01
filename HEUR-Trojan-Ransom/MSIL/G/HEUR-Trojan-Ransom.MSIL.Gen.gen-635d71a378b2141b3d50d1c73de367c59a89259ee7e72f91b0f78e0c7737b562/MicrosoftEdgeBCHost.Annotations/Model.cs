using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Model
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Model()
	{
		WriterPropertyProducer.ResolveStub();
		ViewGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewGetter()
	{
	}
}
