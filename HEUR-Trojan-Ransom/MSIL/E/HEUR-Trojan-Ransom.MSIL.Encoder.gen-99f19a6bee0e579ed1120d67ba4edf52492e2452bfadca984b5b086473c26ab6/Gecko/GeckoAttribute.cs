namespace Gecko;

public class GeckoAttribute : GeckoNode
{
	internal nsIDOMAttr DomAttr;

	public string Name => nsString.Get(DomAttr.GetNameAttribute);

	public new GeckoNode OwnerDocument => GeckoNode.Create((nsIDOMHTMLElement)DomAttr.GetOwnerDocumentAttribute());

	public bool Specified => DomAttr.GetSpecifiedAttribute();

	public string Value
	{
		get
		{
			return nsString.Get(DomAttr.GetValueAttribute);
		}
		set
		{
			nsString.Set(DomAttr.SetValueAttribute, value);
		}
	}

	internal GeckoAttribute(nsIDOMAttr attr)
		: base(attr)
	{
		DomAttr = attr;
	}

	internal static GeckoAttribute CreateAttributeWrapper(nsIDOMAttr attr)
	{
		return (attr == null) ? null : new GeckoAttribute(attr);
	}
}
