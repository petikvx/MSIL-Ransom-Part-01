using Gecko.Interop;

namespace Gecko.DOM.Svg;

public class SvgElement : GeckoElement
{
	private nsIDOMSVGElement _svgElement;

	public string ID
	{
		get
		{
			return nsString.Get(_svgElement.GetIdAttribute);
		}
		set
		{
			nsString.Set(_svgElement.SetIdAttribute, value);
		}
	}

	public SvgSvgElement OwnerSvgElement => _svgElement.GetOwnerSVGElementAttribute().Wrap(SvgSvgElement.CreateSvgSvgElementWrapper);

	public SvgElement ViewportElement => _svgElement.GetViewportElementAttribute().Wrap(CreateSvgElementWrapper);

	protected SvgElement(nsIDOMSVGElement svgElement)
		: base(svgElement)
	{
		_svgElement = svgElement;
	}

	public static SvgElement CreateSvgElementWrapper(nsIDOMSVGElement svgElement)
	{
		return (svgElement == null) ? null : new SvgElement(svgElement);
	}
}
