using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SerializerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerVal()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateVisitor()
	{
	}
}
