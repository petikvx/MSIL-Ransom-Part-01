#define DEBUG
using System;
using System.Diagnostics;
using Gecko.Interop;

namespace Gecko;

internal sealed class ChromeContext : IDisposable
{
	private bool _isInitialized;

	private ComPtr<nsIWebNavigation> webNav;

	private ComPtr<nsIDOMXULElement> command;

	public bool IsDisposed { get; private set; }

	public ChromeContext()
	{
		using ComPtr<nsIAppShellService> comPtr = Xpcom.GetService2<nsIAppShellService>("@mozilla.org/appshell/appShellService;1");
		webNav = comPtr.Instance.CreateWindowlessBrowser(aIsChrome: true).AsComPtr();
		webNav.Instance.LoadURI("chrome://global/content/alerts/alert.xul", 0u, null, null, null);
	}

	~ChromeContext()
	{
		Dispose(fDisposing: false);
	}

	public void Dispose()
	{
		Dispose(fDisposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool fDisposing)
	{
		Debug.WriteLineIf(!fDisposing, string.Concat("****** Missing Dispose() call for ", GetType(), ". *******"));
		if (fDisposing && !IsDisposed)
		{
			if (webNav != null)
			{
				webNav.Dispose();
			}
			if (command != null)
			{
				command.Dispose();
			}
			_isInitialized = false;
		}
		webNav = null;
		command = null;
		IsDisposed = true;
	}

	private void Init()
	{
		if (!_isInitialized)
		{
			_isInitialized = true;
			GeckoDomDocument geckoDomDocument = webNav.Instance.GetDocumentAttribute().Wrap(GeckoDomDocument.CreateDomDocumentWraper);
			GeckoElement documentElement = geckoDomDocument.DocumentElement;
			while (documentElement.FirstChild != null)
			{
				documentElement.RemoveChild(documentElement.FirstChild);
			}
			string text = "\r\nfunction drawWindow(window, x, y, w, h, canvas, ctx)\r\n{\r\n\ttry {\r\n\t\tcanvas = window.document.createElement('canvas');\r\n\t\tcanvas.width = w;\r\n\t\tcanvas.height = h;\r\n\t\tctx = canvas.getContext('2d');\r\n\t\tctx.drawWindow(window, x, y, w, h, 'rgb(255,255,255)', " + 26u + ");\r\n\t\treturn canvas.toDataURL('image/png');\r\n\t} catch(e) {\r\n\t\treturn e + ''\r\n\t}\r\n}\r\n";
			GeckoElement geckoElement = geckoDomDocument.CreateElement("button");
			geckoElement.SetAttribute("oncommand", text + "this.setUserData('drawResult', drawWindow(this.getUserData('window'), this.getUserData('x'), this.getUserData('y'), this.getUserData('w'), this.getUserData('h')), null)");
			documentElement.AppendChild(geckoElement);
			command = Xpcom.QueryInterface<nsIDOMXULElement>(geckoElement.DOMElement).AsComPtr();
		}
	}

	internal byte[] DrawWindow(nsIDOMWindow window, uint x, uint y, uint w, uint h)
	{
		Xpcom.AssertCorrectThread();
		Init();
		SetValue("x", x);
		SetValue("y", y);
		SetValue("w", w);
		SetValue("h", h);
		using (ComPtr<nsIWritableVariant> comPtr = Xpcom.CreateInstance2<nsIWritableVariant>("@mozilla.org/variant;1"))
		{
			comPtr.Instance.SetAsISupports((nsISupports)window);
			using nsAString key = new nsAString("window");
			object obj = command.Instance.SetUserData(key, comPtr.Instance);
			Xpcom.FreeComObject(ref obj);
			command.Instance.DoCommand();
			obj = command.Instance.SetUserData(key, null);
			Xpcom.FreeComObject(ref obj);
		}
		string text = null;
		using (nsAString key2 = new nsAString("drawResult"))
		{
			using ComPtr<nsIVariant> comPtr2 = command.Instance.SetUserData(key2, null).AsComPtr();
			if (comPtr2 != null)
			{
				text = comPtr2.Instance.GetAsWString();
			}
		}
		if (text == null)
		{
			throw new InvalidOperationException();
		}
		if (!text.StartsWith("data:image/png;base64,"))
		{
			throw new InvalidOperationException(text);
		}
		return Convert.FromBase64String(text.Substring("data:image/png;base64,".Length));
	}

	private void SetValue(string name, uint value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using ComPtr<nsIWritableVariant> comPtr = Xpcom.CreateInstance2<nsIWritableVariant>("@mozilla.org/variant;1");
		comPtr.Instance.SetAsUint32(value);
		using nsAString key = new nsAString(name);
		object obj = command.Instance.SetUserData(key, comPtr.Instance);
		Xpcom.FreeComObject(ref obj);
	}

	private void SetValue(string name, nsISupports value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using ComPtr<nsIWritableVariant> comPtr = Xpcom.CreateInstance2<nsIWritableVariant>("@mozilla.org/variant;1");
		comPtr.Instance.SetAsISupports(value);
		using nsAString key = new nsAString(name);
		object obj = command.Instance.SetUserData(key, comPtr.Instance);
		Xpcom.FreeComObject(ref obj);
	}

	private void ClearValue(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using nsAString key = new nsAString(name);
		object obj = command.Instance.SetUserData(key, null);
		Xpcom.FreeComObject(ref obj);
	}
}
