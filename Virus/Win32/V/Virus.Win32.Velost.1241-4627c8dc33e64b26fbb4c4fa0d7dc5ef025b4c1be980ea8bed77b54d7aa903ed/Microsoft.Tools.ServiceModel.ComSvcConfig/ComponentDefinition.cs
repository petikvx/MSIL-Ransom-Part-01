using System.Collections.Generic;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class ComponentDefinition<T>
{
	private bool allInterfaces;

	private T component;

	private List<InterfaceDefination<T>> interfaces;

	public bool AllInterfaces => allInterfaces;

	public T Component => component;

	public IList<InterfaceDefination<T>> Interfaces => interfaces;

	public ComponentDefinition(T component)
	{
		allInterfaces = false;
		this.component = component;
		interfaces = null;
	}

	public void AddInterface(T itf, List<string> methods)
	{
		if (AllInterfaces)
		{
			throw Tool.CreateArgumentException("contract", component.ToString() + "," + itf.ToString(), SR.GetString("AllInterfacesAlreadySelected", component.ToString()), null);
		}
		if (interfaces == null)
		{
			interfaces = new List<InterfaceDefination<T>>();
		}
		InterfaceDefination<T> item = new InterfaceDefination<T>(itf, methods);
		interfaces.Add(item);
	}

	public void SetAllInterfaces()
	{
		if (interfaces != null || allInterfaces)
		{
			throw Tool.CreateArgumentException("contract", component.ToString() + ",*", SR.GetString("CannotSpecifyAllInterfaces"), null);
		}
		allInterfaces = true;
	}
}
