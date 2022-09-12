using Gecko.Interop;

namespace Gecko.Certificates;

public sealed class CertTreeItem
{
	private ComPtr<nsICertTreeItem> _certTreeItem;

	public Certificate Certificate => Certificate.Create(_certTreeItem.Instance.GetCertAttribute());

	public string HostPort => nsString.Get(_certTreeItem.Instance.GetHostPortAttribute);

	internal CertTreeItem(nsICertTreeItem certTreeItem)
	{
		_certTreeItem = new ComPtr<nsICertTreeItem>(certTreeItem);
	}
}
