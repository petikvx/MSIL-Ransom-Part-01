using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Data.SQLite;

public abstract class SQLiteFunction : IDisposable
{
	private class AggregateData
	{
		internal int _count = 1;

		internal object _data;
	}

	internal SQLiteBase _base;

	private Dictionary<long, AggregateData> _contextDataList;

	private SQLiteCallback _InvokeFunc;

	private SQLiteCallback _StepFunc;

	private SQLiteFinalCallback _FinalFunc;

	private SQLiteCollation _CompareFunc;

	private SQLiteCollation _CompareFunc16;

	internal IntPtr _context;

	private static List<SQLiteFunctionAttribute> _registeredFunctions;

	public SQLiteConvert SQLiteConvert => _base;

	protected SQLiteFunction()
	{
		_contextDataList = new Dictionary<long, AggregateData>();
	}

	public virtual object Invoke(object[] args)
	{
		return null;
	}

	public virtual void Step(object[] args, int stepNumber, ref object contextData)
	{
	}

	public virtual object Final(object contextData)
	{
		return null;
	}

	public virtual int Compare(string param1, string param2)
	{
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
			case TypeAffinity.Null:
				array[i] = DBNull.Value;
				break;
			case TypeAffinity.DateTime:
				array[i] = _base.ToDateTime(_base.GetParamValueText(array2[i]));
				break;
			}
		}
		return array;
	}

	private void SetReturnValue(IntPtr context, object returnValue)
	{
		if (returnValue != null && returnValue != DBNull.Value)
		{
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
			case TypeAffinity.Null:
				_base.ReturnNull(context);
				break;
			}
		}
		else
		{
			_base.ReturnNull(context);
		}
	}

	internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr)
	{
		_context = context;
		SetReturnValue(context, Invoke(ConvertParams(nArgs, argsptr)));
	}

	internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2)
	{
		return Compare(SQLiteConvert.UTF8ToString(ptr1, len1), SQLiteConvert.UTF8ToString(ptr2, len2));
	}

	internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2)
	{
		return Compare(SQLite3_UTF16.UTF16ToString(ptr1, len1), SQLite3_UTF16.UTF16ToString(ptr2, len2));
	}

	internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr)
	{
		long key = (long)_base.AggregateContext(context);
		if (!_contextDataList.TryGetValue(key, out var value))
		{
			value = new AggregateData();
			_contextDataList[key] = value;
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

	internal void FinalCallback(IntPtr context)
	{
		long key = (long)_base.AggregateContext(context);
		object obj = null;
		if (_contextDataList.ContainsKey(key))
		{
			obj = _contextDataList[key]._data;
			_contextDataList.Remove(key);
		}
		_context = context;
		SetReturnValue(context, Final(obj));
		if (obj is IDisposable disposable)
		{
			disposable.Dispose();
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposing)
		{
			return;
		}
		foreach (KeyValuePair<long, AggregateData> contextData in _contextDataList)
		{
			if (contextData.Value._data is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
		_contextDataList.Clear();
		_InvokeFunc = null;
		_StepFunc = null;
		_FinalFunc = null;
		_CompareFunc = null;
		_base = null;
		_contextDataList = null;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	static SQLiteFunction()
	{
		_registeredFunctions = new List<SQLiteFunctionAttribute>();
		try
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			int num = assemblies.Length;
			AssemblyName name = Assembly.GetCallingAssembly().GetName();
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
					goto IL_011c;
				}
				catch (ReflectionTypeLoadException ex)
				{
					types = ex.Types;
					goto IL_011c;
				}
				IL_011c:
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
							sQLiteFunctionAttribute._instanceType = types[k];
							_registeredFunctions.Add(sQLiteFunctionAttribute);
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
		int num = customAttributes.Length;
		for (int i = 0; i < num; i++)
		{
			if (customAttributes[i] is SQLiteFunctionAttribute sQLiteFunctionAttribute)
			{
				sQLiteFunctionAttribute._instanceType = typ;
				_registeredFunctions.Add(sQLiteFunctionAttribute);
			}
		}
	}

	internal static SQLiteFunction[] BindFunctions(SQLiteBase sqlbase)
	{
		List<SQLiteFunction> list = new List<SQLiteFunction>();
		foreach (SQLiteFunctionAttribute registeredFunction in _registeredFunctions)
		{
			SQLiteFunction sQLiteFunction = (SQLiteFunction)Activator.CreateInstance(registeredFunction._instanceType);
			sQLiteFunction._base = sqlbase;
			sQLiteFunction._InvokeFunc = ((registeredFunction.FuncType == FunctionType.Scalar) ? new SQLiteCallback(sQLiteFunction.ScalarCallback) : null);
			sQLiteFunction._StepFunc = ((registeredFunction.FuncType == FunctionType.Aggregate) ? new SQLiteCallback(sQLiteFunction.StepCallback) : null);
			sQLiteFunction._FinalFunc = ((registeredFunction.FuncType == FunctionType.Aggregate) ? new SQLiteFinalCallback(sQLiteFunction.FinalCallback) : null);
			sQLiteFunction._CompareFunc = ((registeredFunction.FuncType == FunctionType.Collation) ? new SQLiteCollation(sQLiteFunction.CompareCallback) : null);
			sQLiteFunction._CompareFunc16 = ((registeredFunction.FuncType == FunctionType.Collation) ? new SQLiteCollation(sQLiteFunction.CompareCallback16) : null);
			if (registeredFunction.FuncType != FunctionType.Collation)
			{
				sqlbase.CreateFunction(registeredFunction.Name, registeredFunction.Arguments, sQLiteFunction is SQLiteFunctionEx, sQLiteFunction._InvokeFunc, sQLiteFunction._StepFunc, sQLiteFunction._FinalFunc);
			}
			else
			{
				sqlbase.CreateCollation(registeredFunction.Name, sQLiteFunction._CompareFunc, sQLiteFunction._CompareFunc16);
			}
			list.Add(sQLiteFunction);
		}
		SQLiteFunction[] array = new SQLiteFunction[list.Count];
		list.CopyTo(array, 0);
		return array;
	}
}
