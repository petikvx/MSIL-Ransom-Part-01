using System;
using System.Collections.Generic;
using System.Linq;

namespace Gecko.WebIDL;

public class WebIDLBase
{
	private readonly nsISupports _thisObject;

	private readonly nsIDOMWindow _globalWindow;

	public WebIDLBase(nsIDOMWindow globalWindow, nsISupports thisObject)
	{
		_globalWindow = globalWindow;
		_thisObject = thisObject;
	}

	public T GetProperty<T>(string propertyName)
	{
		using AutoJSContext autoJSContext = new AutoJSContext(_globalWindow);
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject(_thisObject);
		JsVal jsVal = SpiderMonkey.JS_GetProperty(autoJSContext.ContextPointer, jsObject, propertyName);
		if (jsVal.IsUndefined)
		{
			throw new GeckoException($"Property '{propertyName}' of type '{typeof(T).Name}' does not exist on object");
		}
		object o = jsVal.ToObject();
		return ConvertObject<T>(o);
	}

	public void SetProperty(string propertyName, object value)
	{
		using AutoJSContext autoJSContext = new AutoJSContext(_globalWindow);
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject(_thisObject);
		if (!SpiderMonkey.JS_SetProperty(autoJSContext.ContextPointer, jsObject, propertyName, ConvertTypes(new object[1] { value }, autoJSContext).First()))
		{
			throw new GeckoException($"Property '{propertyName}' of value '{value}' could not be set on object");
		}
	}

	public void CallVoidMethod(string methodName, params object[] paramObjects)
	{
		using AutoJSContext autoJSContext = new AutoJSContext(_globalWindow);
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject(_thisObject);
		List<JsVal> list = ConvertTypes(paramObjects, autoJSContext);
		SpiderMonkey.JS_CallFunctionName(autoJSContext.ContextPointer, jsObject, methodName, list.ToArray());
	}

	public T CallMethod<T>(string methodName, params object[] paramObjects)
	{
		using AutoJSContext autoJSContext = new AutoJSContext(_globalWindow);
		IntPtr jsObject = autoJSContext.ConvertCOMObjectToJSObject(_thisObject);
		List<JsVal> list = ConvertTypes(paramObjects, autoJSContext);
		object o = SpiderMonkey.JS_CallFunctionName(autoJSContext.ContextPointer, jsObject, methodName, list.ToArray()).ToObject();
		return ConvertObject<T>(o);
	}

	private static List<JsVal> ConvertTypes(object[] paramObjects, AutoJSContext context)
	{
		List<JsVal> list = new List<JsVal>();
		foreach (object obj in paramObjects)
		{
			JsVal jsval;
			if (obj is nsAString || obj is nsACString || obj is nsAUTF8String || obj is string)
			{
				SpiderMonkey.JS_ExecuteScript(context.ContextPointer, "\"" + obj.ToString() + "\"", out jsval);
			}
			else if (obj is nsISupports)
			{
				jsval = JsVal.FromPtr(context.ConvertCOMObjectToJSObject((nsISupports)obj));
			}
			else if (obj is bool)
			{
				SpiderMonkey.JS_ExecuteScript(context.ContextPointer, ((bool)obj) ? "true;" : "false;", out jsval);
			}
			else if (obj is double)
			{
				jsval = JsVal.FromDouble((double)obj);
			}
			else
			{
				SpiderMonkey.JS_ExecuteScript(context.ContextPointer, obj.ToString(), out jsval);
			}
			list.Add(jsval);
		}
		return list;
	}

	private T ConvertObject<T>(object o)
	{
		if (typeof(T).IsValueType)
		{
			return (T)Convert.ChangeType(o, typeof(T));
		}
		return (T)o;
	}
}
