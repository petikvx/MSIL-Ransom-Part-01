using System;
using System.Collections.Generic;
using System.EnterpriseServices;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

internal class ComAdminClassInfo
{
	private Guid clsid;

	private List<ComAdminInterfaceInfo> interfaces;

	private bool isPrivate;

	private string progid;

	private TransactionOption transactionOption;

	public Guid Clsid => clsid;

	public bool IsPrivate => isPrivate;

	public string Name => progid;

	public List<ComAdminInterfaceInfo> Interfaces => interfaces;

	public bool SupportsTransactionFlow
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			if ((int)transactionOption != 3 && (int)transactionOption != 2)
			{
				return false;
			}
			return true;
		}
	}

	public ComAdminClassInfo(ICatalogObject compObj, ICatalogCollection compColl)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		clsid = new Guid((string)compObj.Key());
		progid = (string)compObj.Name();
		isPrivate = (bool)compObj.GetValue(PropertyName.IsPrivateComponent);
		transactionOption = (TransactionOption)compObj.GetValue(PropertyName.TransactionOption);
		BuildInterfaces(compObj, compColl);
	}

	private void BuildInterfaces(ICatalogObject compObj, ICatalogCollection compColl)
	{
		interfaces = new List<ComAdminInterfaceInfo>();
		ICatalogCollection catalogCollection = (ICatalogCollection)compColl.GetCollection(CollectionName.InterfacesForComponent, compObj.Key());
		catalogCollection.Populate();
		for (int i = 0; i < catalogCollection.Count(); i++)
		{
			ICatalogObject catalogObject = (ICatalogObject)catalogCollection.Item(i);
			Guid iid = new Guid((string)catalogObject.Key());
			ComAdminInterfaceInfo item = new ComAdminInterfaceInfo(iid, (string)catalogObject.Name());
			interfaces.Add(item);
		}
	}

	public ComAdminInterfaceInfo FindInterface(string interfaceNameOrGuid)
	{
		ComAdminInterfaceInfo comAdminInterfaceInfo = null;
		interfaceNameOrGuid = interfaceNameOrGuid.ToLowerInvariant();
		foreach (ComAdminInterfaceInfo @interface in interfaces)
		{
			if (@interface.Iid.ToString("B").ToLowerInvariant() == interfaceNameOrGuid.ToLowerInvariant() || @interface.Name.ToLowerInvariant() == interfaceNameOrGuid)
			{
				if (comAdminInterfaceInfo != null)
				{
					throw Tool.CreateException(SR.GetString("AmbiguousInterfaceName", interfaceNameOrGuid), null);
				}
				comAdminInterfaceInfo = @interface;
			}
		}
		return comAdminInterfaceInfo;
	}
}
