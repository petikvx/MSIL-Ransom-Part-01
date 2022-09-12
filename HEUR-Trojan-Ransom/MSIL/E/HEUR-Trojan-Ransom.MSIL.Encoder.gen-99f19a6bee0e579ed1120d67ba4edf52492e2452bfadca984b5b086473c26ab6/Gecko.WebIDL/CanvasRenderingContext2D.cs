namespace Gecko.WebIDL;

public class CanvasRenderingContext2D : WebIDLBase
{
	public nsIDOMHTMLCanvasElement Canvas => GetProperty<nsIDOMHTMLCanvasElement>("canvas");

	public double GlobalAlpha
	{
		get
		{
			return GetProperty<double>("globalAlpha");
		}
		set
		{
			SetProperty("globalAlpha", value);
		}
	}

	public string GlobalCompositeOperation
	{
		get
		{
			return GetProperty<string>("globalCompositeOperation");
		}
		set
		{
			SetProperty("globalCompositeOperation", value);
		}
	}

	public WebIDLUnion<string, nsISupports, nsISupports> StrokeStyle
	{
		get
		{
			return GetProperty<WebIDLUnion<string, nsISupports, nsISupports>>("strokeStyle");
		}
		set
		{
			SetProperty("strokeStyle", value);
		}
	}

	public WebIDLUnion<string, nsISupports, nsISupports> FillStyle
	{
		get
		{
			return GetProperty<WebIDLUnion<string, nsISupports, nsISupports>>("fillStyle");
		}
		set
		{
			SetProperty("fillStyle", value);
		}
	}

	public double ShadowOffsetX
	{
		get
		{
			return GetProperty<double>("shadowOffsetX");
		}
		set
		{
			SetProperty("shadowOffsetX", value);
		}
	}

	public double ShadowOffsetY
	{
		get
		{
			return GetProperty<double>("shadowOffsetY");
		}
		set
		{
			SetProperty("shadowOffsetY", value);
		}
	}

	public double ShadowBlur
	{
		get
		{
			return GetProperty<double>("shadowBlur");
		}
		set
		{
			SetProperty("shadowBlur", value);
		}
	}

	public string ShadowColor
	{
		get
		{
			return GetProperty<string>("shadowColor");
		}
		set
		{
			SetProperty("shadowColor", value);
		}
	}

	public string Filter
	{
		get
		{
			return GetProperty<string>("filter");
		}
		set
		{
			SetProperty("filter", value);
		}
	}

	public object MozCurrentTransform
	{
		get
		{
			return GetProperty<object>("mozCurrentTransform");
		}
		set
		{
			SetProperty("mozCurrentTransform", value);
		}
	}

	public object MozCurrentTransformInverse
	{
		get
		{
			return GetProperty<object>("mozCurrentTransformInverse");
		}
		set
		{
			SetProperty("mozCurrentTransformInverse", value);
		}
	}

	public string MozFillRule
	{
		get
		{
			return GetProperty<string>("mozFillRule");
		}
		set
		{
			SetProperty("mozFillRule", value);
		}
	}

	public object MozDash
	{
		get
		{
			return GetProperty<object>("mozDash");
		}
		set
		{
			SetProperty("mozDash", value);
		}
	}

	public double MozDashOffset
	{
		get
		{
			return GetProperty<double>("mozDashOffset");
		}
		set
		{
			SetProperty("mozDashOffset", value);
		}
	}

	public string MozTextStyle
	{
		get
		{
			return GetProperty<string>("mozTextStyle");
		}
		set
		{
			SetProperty("mozTextStyle", value);
		}
	}

	public bool MozImageSmoothingEnabled
	{
		get
		{
			return GetProperty<bool>("mozImageSmoothingEnabled");
		}
		set
		{
			SetProperty("mozImageSmoothingEnabled", value);
		}
	}

	public CanvasRenderingContext2D(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Save()
	{
		CallVoidMethod("save");
	}

	public void Restore()
	{
		CallVoidMethod("restore");
	}

	public void Scale(double x, double y)
	{
		CallVoidMethod("scale", x, y);
	}

	public void Rotate(double angle)
	{
		CallVoidMethod("rotate", angle);
	}

	public void Translate(double x, double y)
	{
		CallVoidMethod("translate", x, y);
	}

	public void Transform(double a, double b, double c, double d, double e, double f)
	{
		CallVoidMethod("transform", a, b, c, d, e, f);
	}

	public void SetTransform(double a, double b, double c, double d, double e, double f)
	{
		CallVoidMethod("setTransform", a, b, c, d, e, f);
	}

	public void ResetTransform()
	{
		CallVoidMethod("resetTransform");
	}

	public nsISupports CreateLinearGradient(double x0, double y0, double x1, double y1)
	{
		return CallMethod<nsISupports>("createLinearGradient", new object[4] { x0, y0, x1, y1 });
	}

	public nsISupports CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1)
	{
		return CallMethod<nsISupports>("createRadialGradient", new object[6] { x0, y0, r0, x1, y1, r1 });
	}

	public nsISupports CreatePattern(WebIDLUnion<nsIDOMHTMLImageElement, nsIDOMHTMLCanvasElement, nsISupports, nsISupports> image, string repetition)
	{
		return CallMethod<nsISupports>("createPattern", new object[2] { image, repetition });
	}

	public void ClearRect(double x, double y, double w, double h)
	{
		CallVoidMethod("clearRect", x, y, w, h);
	}

	public void FillRect(double x, double y, double w, double h)
	{
		CallVoidMethod("fillRect", x, y, w, h);
	}

	public void StrokeRect(double x, double y, double w, double h)
	{
		CallVoidMethod("strokeRect", x, y, w, h);
	}

	public void BeginPath()
	{
		CallVoidMethod("beginPath");
	}

	public void Fill()
	{
		CallVoidMethod("fill");
	}

	public void Fill(CanvasWindingRule winding)
	{
		CallVoidMethod("fill", winding);
	}

	public void Fill(nsISupports path)
	{
		CallVoidMethod("fill", path);
	}

	public void Fill(nsISupports path, CanvasWindingRule winding)
	{
		CallVoidMethod("fill", path, winding);
	}

	public void Stroke()
	{
		CallVoidMethod("stroke");
	}

	public void Stroke(nsISupports path)
	{
		CallVoidMethod("stroke", path);
	}

	public void DrawFocusIfNeeded(nsIDOMElement element)
	{
		CallVoidMethod("drawFocusIfNeeded", element);
	}

	public bool DrawCustomFocusRing(nsIDOMElement element)
	{
		return CallMethod<bool>("drawCustomFocusRing", new object[1] { element });
	}

	public void Clip()
	{
		CallVoidMethod("clip");
	}

	public void Clip(CanvasWindingRule winding)
	{
		CallVoidMethod("clip", winding);
	}

	public void Clip(nsISupports path)
	{
		CallVoidMethod("clip", path);
	}

	public void Clip(nsISupports path, CanvasWindingRule winding)
	{
		CallVoidMethod("clip", path, winding);
	}

	public bool IsPointInPath(double x, double y)
	{
		return CallMethod<bool>("isPointInPath", new object[2] { x, y });
	}

	public bool IsPointInPath(double x, double y, CanvasWindingRule winding)
	{
		return CallMethod<bool>("isPointInPath", new object[3] { x, y, winding });
	}

	public bool IsPointInPath(nsISupports path, double x, double y)
	{
		return CallMethod<bool>("isPointInPath", new object[3] { path, x, y });
	}

	public bool IsPointInPath(nsISupports path, double x, double y, CanvasWindingRule winding)
	{
		return CallMethod<bool>("isPointInPath", new object[4] { path, x, y, winding });
	}

	public bool IsPointInStroke(double x, double y)
	{
		return CallMethod<bool>("isPointInStroke", new object[2] { x, y });
	}

	public bool IsPointInStroke(nsISupports path, double x, double y)
	{
		return CallMethod<bool>("isPointInStroke", new object[3] { path, x, y });
	}

	public void FillText(string text, double x, double y)
	{
		CallVoidMethod("fillText", text, x, y);
	}

	public void FillText(string text, double x, double y, double maxWidth)
	{
		CallVoidMethod("fillText", text, x, y, maxWidth);
	}

	public void StrokeText(string text, double x, double y)
	{
		CallVoidMethod("strokeText", text, x, y);
	}

	public void StrokeText(string text, double x, double y, double maxWidth)
	{
		CallVoidMethod("strokeText", text, x, y, maxWidth);
	}

	public nsISupports MeasureText(string text)
	{
		return CallMethod<nsISupports>("measureText", new object[1] { text });
	}

	public void DrawImage(WebIDLUnion<nsIDOMHTMLImageElement, nsIDOMHTMLCanvasElement, nsISupports, nsISupports> image, double dx, double dy)
	{
		CallVoidMethod("drawImage", image, dx, dy);
	}

	public void DrawImage(WebIDLUnion<nsIDOMHTMLImageElement, nsIDOMHTMLCanvasElement, nsISupports, nsISupports> image, double dx, double dy, double dw, double dh)
	{
		CallVoidMethod("drawImage", image, dx, dy, dw, dh);
	}

	public void DrawImage(WebIDLUnion<nsIDOMHTMLImageElement, nsIDOMHTMLCanvasElement, nsISupports, nsISupports> image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh)
	{
		CallVoidMethod("drawImage", image, sx, sy, sw, sh, dx, dy, dw, dh);
	}

	public void AddHitRegion()
	{
		CallVoidMethod("addHitRegion");
	}

	public void AddHitRegion(object options)
	{
		CallVoidMethod("addHitRegion", options);
	}

	public void RemoveHitRegion(string id)
	{
		CallVoidMethod("removeHitRegion", id);
	}

	public void ClearHitRegions()
	{
		CallVoidMethod("clearHitRegions");
	}

	public nsISupports CreateImageData(double sw, double sh)
	{
		return CallMethod<nsISupports>("createImageData", new object[2] { sw, sh });
	}

	public nsISupports CreateImageData(nsISupports imagedata)
	{
		return CallMethod<nsISupports>("createImageData", new object[1] { imagedata });
	}

	public nsISupports GetImageData(double sx, double sy, double sw, double sh)
	{
		return CallMethod<nsISupports>("getImageData", new object[4] { sx, sy, sw, sh });
	}

	public void PutImageData(nsISupports imagedata, double dx, double dy)
	{
		CallVoidMethod("putImageData", imagedata, dx, dy);
	}

	public void PutImageData(nsISupports imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight)
	{
		CallVoidMethod("putImageData", imagedata, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight);
	}

	public void DrawWindow(nsIDOMWindow window, double x, double y, double w, double h, string bgColor)
	{
		CallVoidMethod("drawWindow", window, x, y, w, h, bgColor);
	}

	public void DrawWindow(nsIDOMWindow window, double x, double y, double w, double h, string bgColor, uint flags)
	{
		CallVoidMethod("drawWindow", window, x, y, w, h, bgColor, flags);
	}

	public void AsyncDrawXULElement(nsISupports elem, double x, double y, double w, double h, string bgColor)
	{
		CallVoidMethod("asyncDrawXULElement", elem, x, y, w, h, bgColor);
	}

	public void AsyncDrawXULElement(nsISupports elem, double x, double y, double w, double h, string bgColor, uint flags)
	{
		CallVoidMethod("asyncDrawXULElement", elem, x, y, w, h, bgColor, flags);
	}

	public void DrawWidgetAsOnScreen(nsIDOMWindow window)
	{
		CallVoidMethod("drawWidgetAsOnScreen", window);
	}

	public void Demote()
	{
		CallVoidMethod("demote");
	}
}
