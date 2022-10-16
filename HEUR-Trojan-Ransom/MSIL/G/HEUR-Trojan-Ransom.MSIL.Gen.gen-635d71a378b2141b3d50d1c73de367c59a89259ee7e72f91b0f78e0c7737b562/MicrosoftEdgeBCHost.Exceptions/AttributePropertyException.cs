using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AttributePropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributePropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralSerializer()
	{
	}
}
