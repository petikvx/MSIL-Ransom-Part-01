namespace Microsoft.Build.Shared;

internal sealed class AssemblyLoadInfo
{
	private string assemblyName;

	private string assemblyFile;

	internal string AssemblyName => assemblyName;

	internal string AssemblyFile => assemblyFile;

	private AssemblyLoadInfo()
	{
	}

	internal AssemblyLoadInfo(string assemblyName, string assemblyFile)
	{
		ErrorUtilities.VerifyThrow((assemblyName != null && assemblyName.Length > 0) || (assemblyFile != null && assemblyFile.Length > 0), "We must have either the assembly name or the assembly file/path.");
		ErrorUtilities.VerifyThrow(assemblyName == null || assemblyFile == null, "We must not have both the assembly name and the assembly file/path.");
		this.assemblyName = assemblyName;
		this.assemblyFile = assemblyFile;
	}

	public override string ToString()
	{
		if (assemblyName != null)
		{
			ErrorUtilities.VerifyThrow(assemblyFile == null, "We cannot have both the assembly name and the assembly file/path.");
			return assemblyName;
		}
		ErrorUtilities.VerifyThrow(assemblyFile != null, "We must have either the assembly name or the assembly file/path.");
		return assemblyFile;
	}

	public override int GetHashCode()
	{
		return ToString().GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is AssemblyLoadInfo))
		{
			return false;
		}
		AssemblyLoadInfo assemblyLoadInfo = (AssemblyLoadInfo)obj;
		if (AssemblyName == assemblyLoadInfo.AssemblyName)
		{
			return AssemblyFile == assemblyLoadInfo.AssemblyFile;
		}
		return false;
	}
}
