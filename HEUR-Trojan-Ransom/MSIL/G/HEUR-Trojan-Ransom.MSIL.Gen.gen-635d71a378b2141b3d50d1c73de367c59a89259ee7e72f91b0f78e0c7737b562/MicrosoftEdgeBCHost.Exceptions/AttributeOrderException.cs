using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AttributeOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceSchema()
	{
	}
}
