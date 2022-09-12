namespace Gecko.Certificates;

public sealed class CertTree : TreeView
{
	private nsICertTree _certTree;

	internal CertTree(nsICertTree certTree)
		: base(certTree)
	{
		_certTree = certTree;
	}

	public void LoadCerts(uint type)
	{
		_certTree.LoadCerts(type);
	}

	public Certificate GetCert(uint index)
	{
		return Certificate.Create(_certTree.GetCert(index));
	}

	public CertTreeItem GetTreeItem(uint index)
	{
		return new CertTreeItem(_certTree.GetTreeItem(index));
	}

	public bool IsHostPortOverride(uint index)
	{
		return _certTree.IsHostPortOverride(index);
	}

	public void DeleteEntryObject(uint index)
	{
		_certTree.DeleteEntryObject(index);
	}
}
