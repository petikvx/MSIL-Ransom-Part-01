using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PropertyOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralCreator()
	{
	}
}
