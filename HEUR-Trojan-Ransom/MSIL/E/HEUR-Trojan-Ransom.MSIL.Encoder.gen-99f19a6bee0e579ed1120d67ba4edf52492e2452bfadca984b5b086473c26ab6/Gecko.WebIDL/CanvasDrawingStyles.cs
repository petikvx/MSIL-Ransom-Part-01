namespace Gecko.WebIDL;

public class CanvasDrawingStyles : WebIDLBase
{
	public double LineWidth
	{
		get
		{
			return GetProperty<double>("lineWidth");
		}
		set
		{
			SetProperty("lineWidth", value);
		}
	}

	public string LineCap
	{
		get
		{
			return GetProperty<string>("lineCap");
		}
		set
		{
			SetProperty("lineCap", value);
		}
	}

	public string LineJoin
	{
		get
		{
			return GetProperty<string>("lineJoin");
		}
		set
		{
			SetProperty("lineJoin", value);
		}
	}

	public double MiterLimit
	{
		get
		{
			return GetProperty<double>("miterLimit");
		}
		set
		{
			SetProperty("miterLimit", value);
		}
	}

	public double LineDashOffset
	{
		get
		{
			return GetProperty<double>("lineDashOffset");
		}
		set
		{
			SetProperty("lineDashOffset", value);
		}
	}

	public string Font
	{
		get
		{
			return GetProperty<string>("font");
		}
		set
		{
			SetProperty("font", value);
		}
	}

	public string TextAlign
	{
		get
		{
			return GetProperty<string>("textAlign");
		}
		set
		{
			SetProperty("textAlign", value);
		}
	}

	public string TextBaseline
	{
		get
		{
			return GetProperty<string>("textBaseline");
		}
		set
		{
			SetProperty("textBaseline", value);
		}
	}

	public CanvasDrawingStyles(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetLineDash(double[] segments)
	{
		CallVoidMethod("setLineDash", segments);
	}

	public double[] GetLineDash()
	{
		return CallMethod<double[]>("getLineDash", new object[0]);
	}
}
