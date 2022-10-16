using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SerializerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostAnnotation()
	{
	}
}
