using System.Collections.Generic;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class InterfaceDefination<T>
{
	private T iinterface;

	private List<string> methods;

	public bool AllMethods
	{
		get
		{
			if (methods == null)
			{
				return true;
			}
			return false;
		}
	}

	public T Interface => iinterface;

	public IList<string> Methods => methods;

	public InterfaceDefination(T iinterface, List<string> methods)
	{
		this.iinterface = iinterface;
		this.methods = methods;
	}
}
