using System;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public class ReportUsageAttribute1 : Attribute
{
	public ReportUsageAttribute1()
	{
	}

	public ReportUsageAttribute1(string featureName)
	{
	}
}
