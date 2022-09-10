using System;

namespace Microsoft.Build.Shared;

internal sealed class LoadedType
{
	private Type type;

	private AssemblyLoadInfo assembly;

	internal Type Type => type;

	internal AssemblyLoadInfo Assembly => assembly;

	private LoadedType()
	{
	}

	internal LoadedType(Type type, AssemblyLoadInfo assembly)
	{
		ErrorUtilities.VerifyThrow((object)type != null, "We must have the type.");
		ErrorUtilities.VerifyThrow(assembly != null, "We must have the assembly the type was loaded from.");
		this.type = type;
		this.assembly = assembly;
	}
}
