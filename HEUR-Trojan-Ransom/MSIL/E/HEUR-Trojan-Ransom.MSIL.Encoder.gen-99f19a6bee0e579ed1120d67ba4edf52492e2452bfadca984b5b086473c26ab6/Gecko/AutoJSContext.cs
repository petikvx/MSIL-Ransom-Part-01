using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Gecko.Interop;

namespace Gecko;

public class AutoJSContext : IDisposable
{
	private readonly IntPtr _cx;

	private readonly nsIDOMWindow _window;

	private JSAutoCompartment _defaultCompartment;

	private Stack<JSAutoCompartment> _compartmentStack = new Stack<JSAutoCompartment>();

	private nsIXPCComponents _nsIXPCComponents;

	private IntPtr _globalJSObject;

	private static Dictionary<IntPtr, IntPtr> _contextToGlobalDictionary = new Dictionary<IntPtr, IntPtr>();

	private static IntPtr _safeContext;

	public IntPtr ContextPointer => _cx;

	public static IntPtr SafeJSContext
	{
		get
		{
			if (_safeContext == IntPtr.Zero)
			{
				ComPtr<nsIXPConnect> xPConnect = Xpcom.XPConnect;
				int slotOfComMethod = xPConnect.GetSlotOfComMethod(new Func<IntPtr>(xPConnect.Instance.GetSafeJSContext));
				Xpcom.GetSafeJSContextDelegate comMethod = xPConnect.GetComMethod<Xpcom.GetSafeJSContextDelegate>(Xpcom.IsLinux ? 12 : slotOfComMethod);
				_safeContext = comMethod(xPConnect.Instance);
			}
			return _safeContext;
		}
	}

	public AutoJSContext(GeckoWindow window)
		: this(window.DomWindow)
	{
	}

	public AutoJSContext(nsISupports window)
		: this((nsIDOMWindow)window)
	{
	}

	public AutoJSContext(nsIDOMWindow window)
	{
		IntPtr safeJSContext = SafeJSContext;
		nsIGlobalObject nsIGlobalObject2 = (nsIGlobalObject)window;
		using ComPtr<nsIGlobalObject> comPtr = new ComPtr<nsIGlobalObject>(nsIGlobalObject2, releaseRCW: false);
		int slotOfComMethod = comPtr.GetSlotOfComMethod(new Func<IntPtr>(nsIGlobalObject2.GetGlobalJSObject));
		GetGlobalJSObject comMethod = comPtr.GetComMethod<GetGlobalJSObject>(Xpcom.IsLinux ? 3 : slotOfComMethod);
		_globalJSObject = comMethod(nsIGlobalObject2);
		if (_globalJSObject == IntPtr.Zero)
		{
			throw new ArgumentException("Window does not have a global JSObject. Purhaps the window doesn't have an initalized document?");
		}
		_contextToGlobalDictionary[safeJSContext] = _globalJSObject;
		_defaultCompartment = new JSAutoCompartment(SafeJSContext, _globalJSObject);
		_cx = safeJSContext;
		_window = window;
	}

	[Obsolete("This constructor only works if a AutoJSContext(window) has previously been use for the same context.")]
	public AutoJSContext(IntPtr context)
	{
		if (context == IntPtr.Zero)
		{
			context = SafeJSContext;
		}
		_globalJSObject = GetGlobalFromContext(context);
		if (_globalJSObject == IntPtr.Zero)
		{
			throw new InvalidOperationException("JSContext don't store their default compartment object on the cx.");
		}
		_defaultCompartment = new JSAutoCompartment(context, _globalJSObject);
		_cx = context;
	}

	[Obsolete("This constructor only works if a AutoJSContext(window) has previously been use for the SafeJSContext")]
	public AutoJSContext()
		: this(SafeJSContext)
	{
	}

	public bool EvaluateScript(string jsScript, out string result)
	{
		JsVal jsval = default(JsVal);
		bool flag = SpiderMonkey.JS_EvaluateScript(ContextPointer, jsScript, (uint)jsScript.Length, "script", 1u, ref jsval);
		result = (flag ? ConvertValueToString(jsval) : null);
		return flag;
	}

	public JsVal EvaluateScript(string javascript, nsIDOMWindow window)
	{
		return EvaluateScript(javascript, (nsISupports)window, (nsISupports)window);
	}

	public JsVal EvaluateScript(string javascript, nsISupports window, nsISupports scope)
	{
		string msg = string.Empty;
		JsVal exceptionJsVal = default(JsVal);
		IntPtr intPtr = ConvertCOMObjectToJSObject(window);
		using (new JSAutoCompartment(ContextPointer, intPtr))
		{
			SpiderMonkey.JSErrorReportCallback callback = SpiderMonkey.JS_SetErrorReporter(SpiderMonkey.JS_GetRuntime(ContextPointer), delegate(IntPtr cx, string message, IntPtr report)
			{
				IntPtr intPtr2 = SpiderMonkey.JS_GetPendingException(ContextPointer);
				if (intPtr2 != IntPtr.Zero)
				{
					exceptionJsVal = JsVal.FromPtr(intPtr2);
				}
				msg = message;
			});
			try
			{
				JsVal jsval = default(JsVal);
				bool flag;
				if (window != scope)
				{
					JsVal value = JsVal.FromPtr(ConvertCOMObjectToJSObject(scope));
					if (!SpiderMonkey.JS_SetProperty(ContextPointer, intPtr, "__RequestedScope", value))
					{
						throw new GeckoException("Failed to set __RequestedScope Property.");
					}
					javascript = InsertReturnStatement(javascript);
					string text = "(function() { " + javascript + " }).call(this.__RequestedScope)";
					flag = SpiderMonkey.JS_EvaluateScript(ContextPointer, text, (uint)text.Length, "script", 1u, ref jsval);
				}
				else
				{
					flag = SpiderMonkey.JS_EvaluateScript(ContextPointer, javascript, (uint)javascript.Length, "script", 1u, ref jsval);
				}
				if (!flag)
				{
					msg += GetStackTrace(intPtr, exceptionJsVal);
					throw new GeckoJavaScriptException($"JSError : {msg}");
				}
				return jsval;
			}
			finally
			{
				SpiderMonkey.JS_SetErrorReporter(SpiderMonkey.JS_GetRuntime(ContextPointer), callback);
			}
		}
	}

	public JsVal EvaluateScript(string javaScript)
	{
		return EvaluateScript(javaScript, _window);
	}

	public bool EvaluateScript(string jsScript, nsISupports thisObject, out string result)
	{
		result = null;
		try
		{
			result = ConvertValueToString(EvaluateScript(jsScript, (nsISupports)_window, thisObject));
		}
		catch (GeckoJavaScriptException)
		{
			return false;
		}
		return true;
	}

	internal static IntPtr GetGlobalFromContext(IntPtr context)
	{
		IntPtr zero = IntPtr.Zero;
		if (zero == IntPtr.Zero && _contextToGlobalDictionary.ContainsKey(context))
		{
			return _contextToGlobalDictionary[context];
		}
		return zero;
	}

	private string InsertReturnStatement(string js)
	{
		js = js.TrimEnd(' ', ';');
		if (js.Count((char x) => x == ';') == 0 && !js.Contains("return"))
		{
			return "return " + js + ";";
		}
		int num = Math.Max(js.LastIndexOf(';'), js.LastIndexOf('}'));
		string text = js.Substring(num + 1);
		if (text.Contains("return"))
		{
			return js;
		}
		return js.Substring(0, num + 1) + " return " + js.Substring(num + 1) + ";";
	}

	internal string ConvertValueToString(JsVal value)
	{
		if (value.IsString)
		{
			nsIVariant nsIVariant2 = Xpcom.XPConnect.Instance.JSValToVariant(ContextPointer, ref value);
			return nsString.Get(nsIVariant2.GetAsAString);
		}
		IntPtr jsString = SpiderMonkey.ToStringSlow(ContextPointer, value);
		IntPtr intPtr = SpiderMonkey.JS_EncodeStringToUTF8(ContextPointer, jsString);
		if (intPtr != IntPtr.Zero)
		{
			try
			{
				int num = SpiderMonkey.JS_GetStringEncodingLength(ContextPointer, jsString);
				byte[] array = new byte[num];
				Marshal.Copy(intPtr, array, 0, num);
				return Encoding.UTF8.GetString(array, 0, num);
			}
			finally
			{
				SpiderMonkey.JS_Free(ContextPointer, intPtr);
			}
		}
		return null;
	}

	internal IntPtr ConvertCOMObjectToJSObject(nsISupports obj)
	{
		Guid aIID = typeof(nsISupports).GUID;
		IntPtr globalFromContext = GetGlobalFromContext(ContextPointer);
		if (obj is nsIXPConnectWrappedJS)
		{
			throw new GeckoException("Can't call WrapNative on Wrapped JSObject.");
		}
		return Xpcom.XPConnect.Instance.WrapNative(ContextPointer, globalFromContext, obj, ref aIID);
	}

	internal nsIXPCComponents GetComponentsObject()
	{
		if (_nsIXPCComponents == null)
		{
			JsVal jsval = default(JsVal);
			SpiderMonkey.JS_ExecuteScript(ContextPointer, "this.myfunc = function(p1) { return Components; };", out jsval);
			jsval = SpiderMonkey.JS_CallFunctionName(ContextPointer, _globalJSObject, "myfunc", new JsVal[1] { jsval });
			_nsIXPCComponents = Xpcom.QueryInterface<nsIXPCComponents>(jsval.ToObject());
			if (_nsIXPCComponents == null)
			{
				throw new GeckoException($"Components object does not implement nsIXPCComponents. {jsval}");
			}
		}
		return _nsIXPCComponents;
	}

	private string GetStackTrace(IntPtr globalObject, JsVal exceptionJsVal)
	{
		if (!exceptionJsVal.IsObject)
		{
			return string.Empty;
		}
		if (!SpiderMonkey.JS_SetProperty(ContextPointer, globalObject, "__RequestedScope", exceptionJsVal))
		{
			throw new GeckoException("Failed to set __RequestedScope Property.");
		}
		JsVal jsval = default(JsVal);
		return (!SpiderMonkey.JS_EvaluateScript(ContextPointer, "(function() { return this.stack }).call(this.__RequestedScope)", (uint)"(function() { return this.stack }).call(this.__RequestedScope)".Length, "script", 1u, ref jsval)) ? string.Empty : $" StackTrace: {jsval}";
	}

	public void Dispose()
	{
		if (_defaultCompartment != null)
		{
			_defaultCompartment.Dispose();
		}
		_defaultCompartment = null;
		GC.SuppressFinalize(this);
	}
}
