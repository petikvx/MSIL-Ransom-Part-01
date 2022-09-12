using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gecko.Utils;

public class SaveImageElement
{
	private static string CopyImageElementToDataImageString(GeckoHtmlElement element, string imageFormat, float xOffset, float yOffset, float width, float height)
	{
		if (width == 0f)
		{
			throw new ArgumentException("width");
		}
		if (height == 0f)
		{
			throw new ArgumentException("height");
		}
		string result;
		using (AutoJSContext autoJSContext = new AutoJSContext())
		{
			autoJSContext.EvaluateScript(string.Format("(function(element, canvas, ctx)\r\n\t\t\t\t\t\t{{\r\n\t\t\t\t\t\t\tcanvas = element.ownerDocument.createElement('canvas');\r\n\t\t\t\t\t\t\tcanvas.width = {2};\r\n\t\t\t\t\t\t\tcanvas.height = {3};\r\n\t\t\t\t\t\t\tctx = canvas.getContext('2d');\r\n\t\t\t\t\t\t\tctx.drawImage(element, -{0}, -{1});\r\n\t\t\t\t\t\t\treturn canvas.toDataURL('{4}');\r\n\t\t\t\t\t\t}}\r\n\t\t\t\t\t\t)(this)", xOffset, yOffset, width, height, imageFormat), (nsISupports)(nsIDOMElement)element.DomObject, out result);
		}
		return result;
	}

	public static byte[] ConvertGeckoImageElementToPng(IGeckoWebBrowser browser, GeckoHtmlElement element, float xOffset, float yOffset, float width, float height)
	{
		string text = CopyImageElementToDataImageString(element, "image/png", xOffset, yOffset, width, height);
		if (text == null || !text.StartsWith("data:image/png;base64,"))
		{
			throw new InvalidOperationException();
		}
		return Convert.FromBase64String(text.Substring("data:image/png;base64,".Length));
	}

	public bool CopyGeckoImageElementToPng(IGeckoWebBrowser browser, GeckoHtmlElement element, float xOffset, float yOffset, float width, float height)
	{
		string text = CopyImageElementToDataImageString(element, "image/png", xOffset, yOffset, width, height);
		if (text == null || !text.StartsWith("data:image/png;base64,"))
		{
			return false;
		}
		byte[] buffer = Convert.FromBase64String(text.Substring("data:image/png;base64,".Length));
		Clipboard.SetImage(Image.FromStream((Stream)new MemoryStream(buffer)));
		return Clipboard.ContainsImage();
	}
}
