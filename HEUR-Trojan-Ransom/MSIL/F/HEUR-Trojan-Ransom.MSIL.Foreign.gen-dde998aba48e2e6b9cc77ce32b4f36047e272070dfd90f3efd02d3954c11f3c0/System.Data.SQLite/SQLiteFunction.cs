using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public abstract class SQLiteFunction : IDisposable
{
	private sealed class AggregateData
	{
		internal int _count = 1;

		internal object _data;

		[NonSerialized]
		internal static GetString _0098;

		static AggregateData()
		{
			Strings.CreateGetStringDelegate(typeof(AggregateData));
			bool flag = false;
			Assembly assembly = global::_0005._001B();
			Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0098(107401131), _0098(107401094)), _0098(107401089), _0098(107401084)));
			if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0098(107401111)))
			{
				return;
			}
			throw new SecurityException(_0098(107401054));
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
	}

	internal SQLiteBase _base;

	private Dictionary<IntPtr, AggregateData> _contextDataList;

	private SQLiteConnectionFlags _flags;

	private SQLiteCallback _InvokeFunc;

	private SQLiteCallback _StepFunc;

	private SQLiteFinalCallback _FinalFunc;

	private SQLiteCollation _CompareFunc;

	private SQLiteCollation _CompareFunc16;

	internal IntPtr _context;

	private static IDictionary<SQLiteFunctionAttribute, object> _registeredFunctions;

	private bool disposed;

	[NonSerialized]
	internal static GetString _0090;

	public SQLiteConvert SQLiteConvert
	{
		get
		{
			CheckDisposed();
			return _base;
		}
	}

	protected SQLiteFunction()
	{
		_contextDataList = new Dictionary<IntPtr, AggregateData>();
	}

	protected SQLiteFunction(SQLiteDateFormats format, DateTimeKind kind, string formatString, bool utf16)
		: this()
	{
		if (utf16)
		{
			_base = new SQLite3_UTF16(format, kind, formatString, IntPtr.Zero, null, ownHandle: false);
		}
		else
		{
			_base = new SQLite3(format, kind, formatString, IntPtr.Zero, null, ownHandle: false);
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteFunction).Name);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposed)
		{
			return;
		}
		if (disposing)
		{
			foreach (KeyValuePair<IntPtr, AggregateData> contextData in _contextDataList)
			{
				if (contextData.Value._data is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
			_contextDataList.Clear();
			_contextDataList = null;
			_flags = SQLiteConnectionFlags.None;
			_InvokeFunc = null;
			_StepFunc = null;
			_FinalFunc = null;
			_CompareFunc = null;
			_base = null;
		}
		disposed = true;
	}

	~SQLiteFunction()
	{
		Dispose(disposing: false);
	}

	public virtual object Invoke(object[] args)
	{
		CheckDisposed();
		return null;
	}

	public virtual void Step(object[] args, int stepNumber, ref object contextData)
	{
		CheckDisposed();
	}

	public virtual object Final(object contextData)
	{
		CheckDisposed();
		return null;
	}

	public virtual int Compare(string param1, string param2)
	{
		CheckDisposed();
		return 0;
	}

	internal object[] ConvertParams(int nArgs, IntPtr argsptr)
	{
		object[] array = new object[nArgs];
		IntPtr[] array2 = new IntPtr[nArgs];
		Marshal.Copy(argsptr, array2, 0, nArgs);
		for (int i = 0; i < nArgs; i++)
		{
			switch (_base.GetParamValueType(array2[i]))
			{
			case TypeAffinity.Null:
				array[i] = DBNull.Value;
				break;
			case TypeAffinity.Int64:
				array[i] = _base.GetParamValueInt64(array2[i]);
				break;
			case TypeAffinity.Double:
				array[i] = _base.GetParamValueDouble(array2[i]);
				break;
			case TypeAffinity.Text:
				array[i] = _base.GetParamValueText(array2[i]);
				break;
			case TypeAffinity.Blob:
			{
				int num = (int)_base.GetParamValueBytes(array2[i], 0, null, 0, 0);
				byte[] array3 = new byte[num];
				_base.GetParamValueBytes(array2[i], 0, array3, 0, num);
				array[i] = array3;
				break;
			}
			case TypeAffinity.DateTime:
				array[i] = _base.ToDateTime(_base.GetParamValueText(array2[i]));
				break;
			}
		}
		return array;
	}

	private void SetReturnValue(IntPtr context, object returnValue)
	{
		if (returnValue == null || returnValue == DBNull.Value)
		{
			_base.ReturnNull(context);
			return;
		}
		Type type = returnValue.GetType();
		if ((object)type == typeof(DateTime))
		{
			_base.ReturnText(context, _base.ToString((DateTime)returnValue));
			return;
		}
		if (returnValue is Exception ex)
		{
			_base.ReturnError(context, ex.Message);
			return;
		}
		switch (SQLiteConvert.TypeToAffinity(type))
		{
		case TypeAffinity.Null:
			_base.ReturnNull(context);
			break;
		case TypeAffinity.Int64:
			_base.ReturnInt64(context, Convert.ToInt64(returnValue, CultureInfo.CurrentCulture));
			break;
		case TypeAffinity.Double:
			_base.ReturnDouble(context, Convert.ToDouble(returnValue, CultureInfo.CurrentCulture));
			break;
		case TypeAffinity.Text:
			_base.ReturnText(context, returnValue.ToString());
			break;
		case TypeAffinity.Blob:
			_base.ReturnBlob(context, (byte[])returnValue);
			break;
		}
	}

	internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr)
	{
		try
		{
			_context = context;
			SetReturnValue(context, Invoke(ConvertParams(nArgs, argsptr)));
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0090(107382759), ex));
				}
			}
			catch
			{
			}
		}
	}

	internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2)
	{
		try
		{
			return Compare(SQLiteConvert.UTF8ToString(ptr1, len1), SQLiteConvert.UTF8ToString(ptr2, len2));
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0090(107382702), ex));
				}
			}
			catch
			{
			}
		}
		if (_base != null && _base.IsOpen())
		{
			_base.Cancel();
		}
		return 0;
	}

	internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2)
	{
		try
		{
			return Compare(SQLite3_UTF16.UTF16ToString(ptr1, len1), SQLite3_UTF16.UTF16ToString(ptr2, len2));
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0090(107382637), ex));
				}
			}
			catch
			{
			}
		}
		if (_base != null && _base.IsOpen())
		{
			_base.Cancel();
		}
		return 0;
	}

	internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr)
	{
		try
		{
			AggregateData value = null;
			if (_base != null)
			{
				IntPtr key = _base.AggregateContext(context);
				if (_contextDataList != null && !_contextDataList.TryGetValue(key, out value))
				{
					value = new AggregateData();
					_contextDataList[key] = value;
				}
			}
			if (value == null)
			{
				value = new AggregateData();
			}
			try
			{
				_context = context;
				Step(ConvertParams(nArgs, argsptr), value._count, ref value._data);
			}
			finally
			{
				value._count++;
			}
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0090(107383080), ex));
				}
			}
			catch
			{
			}
		}
	}

	internal void FinalCallback(IntPtr context)
	{
		try
		{
			object obj = null;
			if (_base != null)
			{
				IntPtr key = _base.AggregateContext(context);
				if (_contextDataList != null && _contextDataList.TryGetValue(key, out var value))
				{
					obj = value._data;
					_contextDataList.Remove(key);
				}
			}
			try
			{
				_context = context;
				SetReturnValue(context, Final(obj));
			}
			finally
			{
				if (obj is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
		}
		catch (Exception ex)
		{
			try
			{
				if ((_flags & SQLiteConnectionFlags.LogCallbackException) == SQLiteConnectionFlags.LogCallbackException)
				{
					SQLiteLog.LogMessage(-2146233088, HelperMethods.StringFormat(CultureInfo.CurrentCulture, _0090(107383027), ex));
				}
			}
			catch
			{
			}
		}
	}

	static SQLiteFunction()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteFunction));
		_registeredFunctions = new Dictionary<SQLiteFunctionAttribute, object>();
		try
		{
			if (UnsafeNativeMethods.GetSettingValue(_0090(107382942), null) != null)
			{
				return;
			}
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			int num = assemblies.Length;
			AssemblyName name = Assembly.GetExecutingAssembly().GetName();
			for (int i = 0; i < num; i++)
			{
				bool flag = false;
				Type[] types;
				try
				{
					AssemblyName[] referencedAssemblies = assemblies[i].GetReferencedAssemblies();
					int num2 = referencedAssemblies.Length;
					for (int j = 0; j < num2; j++)
					{
						if (referencedAssemblies[j].Name == name.Name)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						continue;
					}
					types = assemblies[i].GetTypes();
					goto IL_00bb;
				}
				catch (ReflectionTypeLoadException ex)
				{
					types = ex.Types;
					goto IL_00bb;
				}
				IL_00bb:
				int num3 = types.Length;
				for (int k = 0; k < num3; k++)
				{
					if ((object)types[k] == null)
					{
						continue;
					}
					object[] customAttributes = types[k].GetCustomAttributes(typeof(SQLiteFunctionAttribute), inherit: false);
					int num4 = customAttributes.Length;
					for (int l = 0; l < num4; l++)
					{
						if (customAttributes[l] is SQLiteFunctionAttribute sQLiteFunctionAttribute)
						{
							sQLiteFunctionAttribute.InstanceType = types[k];
							ReplaceFunction(sQLiteFunctionAttribute, null);
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	public static void RegisterFunction(Type typ)
	{
		object[] customAttributes = typ.GetCustomAttributes(typeof(SQLiteFunctionAttribute), inherit: false);
		for (int i = 0; i < customAttributes.Length; i++)
		{
			if (customAttributes[i] is SQLiteFunctionAttribute sQLiteFunctionAttribute)
			{
				RegisterFunction(sQLiteFunctionAttribute.Name, sQLiteFunctionAttribute.Arguments, sQLiteFunctionAttribute.FuncType, typ, sQLiteFunctionAttribute.Callback1, sQLiteFunctionAttribute.Callback2);
			}
		}
	}

	public static void RegisterFunction(string name, int argumentCount, FunctionType functionType, Type instanceType, Delegate callback1, Delegate callback2)
	{
		SQLiteFunctionAttribute sQLiteFunctionAttribute = new SQLiteFunctionAttribute(name, argumentCount, functionType);
		sQLiteFunctionAttribute.InstanceType = instanceType;
		sQLiteFunctionAttribute.Callback1 = callback1;
		sQLiteFunctionAttribute.Callback2 = callback2;
		ReplaceFunction(sQLiteFunctionAttribute, null);
	}

	private static bool ReplaceFunction(SQLiteFunctionAttribute at, object newValue)
	{
		if (_registeredFunctions.TryGetValue(at, out var value))
		{
			if (value is IDisposable disposable)
			{
				disposable.Dispose();
				IDisposable disposable2 = null;
			}
			_registeredFunctions[at] = newValue;
			return true;
		}
		_registeredFunctions.Add(at, newValue);
		return false;
	}

	private static bool CreateFunction(SQLiteFunctionAttribute functionAttribute, out SQLiteFunction function)
	{
		if (functionAttribute == null)
		{
			function = null;
			return false;
		}
		if ((object)functionAttribute.Callback1 != null || (object)functionAttribute.Callback2 != null)
		{
			function = new SQLiteDelegateFunction(functionAttribute.Callback1, functionAttribute.Callback2);
			return true;
		}
		if ((object)functionAttribute.InstanceType != null)
		{
			function = (SQLiteFunction)Activator.CreateInstance(functionAttribute.InstanceType);
			return true;
		}
		function = null;
		return false;
	}

	internal static IDictionary<SQLiteFunctionAttribute, SQLiteFunction> BindFunctions(SQLiteBase sqlbase, SQLiteConnectionFlags flags)
	{
		IDictionary<SQLiteFunctionAttribute, SQLiteFunction> dictionary = new Dictionary<SQLiteFunctionAttribute, SQLiteFunction>();
		foreach (KeyValuePair<SQLiteFunctionAttribute, object> registeredFunction in _registeredFunctions)
		{
			SQLiteFunctionAttribute key = registeredFunction.Key;
			if (key != null)
			{
				if (CreateFunction(key, out var function))
				{
					BindFunction(sqlbase, key, function, flags);
					dictionary[key] = function;
				}
				else
				{
					dictionary[key] = null;
				}
			}
		}
		return dictionary;
	}

	internal static bool UnbindAllFunctions(SQLiteBase sqlbase, SQLiteConnectionFlags flags, bool registered)
	{
		if (sqlbase == null)
		{
			return false;
		}
		IDictionary<SQLiteFunctionAttribute, SQLiteFunction> functions = sqlbase.Functions;
		if (functions == null)
		{
			return false;
		}
		bool result = true;
		if (registered)
		{
			foreach (KeyValuePair<SQLiteFunctionAttribute, object> registeredFunction in _registeredFunctions)
			{
				SQLiteFunctionAttribute key = registeredFunction.Key;
				if (key != null && (!functions.TryGetValue(key, out var value) || value == null || !UnbindFunction(sqlbase, key, value, flags)))
				{
					result = false;
				}
			}
			return result;
		}
		functions = new Dictionary<SQLiteFunctionAttribute, SQLiteFunction>(functions);
		foreach (KeyValuePair<SQLiteFunctionAttribute, SQLiteFunction> item in functions)
		{
			SQLiteFunctionAttribute key2 = item.Key;
			if (key2 != null)
			{
				SQLiteFunction value2 = item.Value;
				if (value2 != null && UnbindFunction(sqlbase, key2, value2, flags))
				{
					sqlbase.Functions.Remove(key2);
				}
				else
				{
					result = false;
				}
			}
		}
		return result;
	}

	internal static void BindFunction(SQLiteBase sqliteBase, SQLiteFunctionAttribute functionAttribute, SQLiteFunction function, SQLiteConnectionFlags flags)
	{
		if (sqliteBase == null)
		{
			throw new ArgumentNullException(_0090(107382917));
		}
		if (functionAttribute == null)
		{
			throw new ArgumentNullException(_0090(107364749));
		}
		if (function == null)
		{
			throw new ArgumentNullException(_0090(107364724));
		}
		FunctionType funcType = functionAttribute.FuncType;
		function._base = sqliteBase;
		function._flags = flags;
		function._InvokeFunc = ((funcType == FunctionType.Scalar) ? new SQLiteCallback(function.ScalarCallback) : null);
		function._StepFunc = ((funcType == FunctionType.Aggregate) ? new SQLiteCallback(function.StepCallback) : null);
		function._FinalFunc = ((funcType == FunctionType.Aggregate) ? new SQLiteFinalCallback(function.FinalCallback) : null);
		function._CompareFunc = ((funcType == FunctionType.Collation) ? new SQLiteCollation(function.CompareCallback) : null);
		function._CompareFunc16 = ((funcType == FunctionType.Collation) ? new SQLiteCollation(function.CompareCallback16) : null);
		string name = functionAttribute.Name;
		if (funcType != FunctionType.Collation)
		{
			bool needCollSeq = function is SQLiteFunctionEx;
			sqliteBase.CreateFunction(name, functionAttribute.Arguments, needCollSeq, function._InvokeFunc, function._StepFunc, function._FinalFunc, @throw: true);
		}
		else
		{
			sqliteBase.CreateCollation(name, function._CompareFunc, function._CompareFunc16, @throw: true);
		}
	}

	internal static bool UnbindFunction(SQLiteBase sqliteBase, SQLiteFunctionAttribute functionAttribute, SQLiteFunction function, SQLiteConnectionFlags flags)
	{
		if (sqliteBase == null)
		{
			throw new ArgumentNullException(_0090(107382917));
		}
		if (functionAttribute == null)
		{
			throw new ArgumentNullException(_0090(107364749));
		}
		if (function == null)
		{
			throw new ArgumentNullException(_0090(107364724));
		}
		FunctionType funcType = functionAttribute.FuncType;
		string name = functionAttribute.Name;
		if (funcType != FunctionType.Collation)
		{
			bool needCollSeq = function is SQLiteFunctionEx;
			return sqliteBase.CreateFunction(name, functionAttribute.Arguments, needCollSeq, null, null, null, @throw: false) == SQLiteErrorCode.Ok;
		}
		return sqliteBase.CreateCollation(name, null, null, @throw: false) == SQLiteErrorCode.Ok;
	}
}
