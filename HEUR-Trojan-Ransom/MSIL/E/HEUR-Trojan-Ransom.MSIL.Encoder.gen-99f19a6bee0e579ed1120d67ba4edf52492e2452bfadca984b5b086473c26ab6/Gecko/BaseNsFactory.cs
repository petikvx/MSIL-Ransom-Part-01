using System;
using System.Runtime.InteropServices;

namespace Gecko;

public class BaseNsFactory<TFactory> where TFactory : nsIFactory, new()
{
	private static bool _isRegistered;

	private static string _contractID;

	private static string _factoryTypeName;

	protected BaseNsFactory()
	{
	}

	protected static string ReadContractIdAttribute()
	{
		Type typeFromHandle = typeof(TFactory);
		object[] customAttributes = typeFromHandle.GetCustomAttributes(typeof(ContractIDAttribute), inherit: true);
		if (customAttributes.Length == 0)
		{
			return null;
		}
		ContractIDAttribute contractIDAttribute = (ContractIDAttribute)customAttributes[0];
		return contractIDAttribute.ContractID;
	}

	public static void Register()
	{
		if (_isRegistered)
		{
			return;
		}
		Type typeFromHandle = typeof(TFactory);
		_contractID = ReadContractIdAttribute();
		if (_contractID != null)
		{
			_factoryTypeName = typeFromHandle.FullName;
			try
			{
				Xpcom.RegisterFactory(typeFromHandle.GUID, _factoryTypeName, _contractID, new TFactory());
			}
			catch (COMException)
			{
				throw;
			}
			catch
			{
			}
			_isRegistered = true;
		}
	}

	public static void Register(string contractID)
	{
		if (!_isRegistered)
		{
			Type typeFromHandle = typeof(TFactory);
			_factoryTypeName = typeFromHandle.FullName;
			Xpcom.RegisterFactory(typeFromHandle.GUID, _factoryTypeName, _contractID, new TFactory());
			_contractID = contractID;
			_isRegistered = true;
		}
	}

	public static void Register(FactoryDetails factory)
	{
		Xpcom.RegisterFactory(factory.classID, string.Empty, string.Empty, factory.factoryInstance);
	}

	public static FactoryDetails Unregister()
	{
		_contractID = ReadContractIdAttribute();
		if (_contractID == null)
		{
			throw new InvalidOperationException("Custom Factory missing ContractId attribute.");
		}
		Type typeFromHandle = typeof(TFactory);
		Guid aClass = typeFromHandle.GUID;
		Guid aIID = typeof(nsIFactory).GUID;
		IntPtr classObject = Xpcom.ComponentManager.GetClassObject(ref aClass, ref aIID);
		if (classObject == IntPtr.Zero)
		{
			return null;
		}
		nsIFactory nsIFactory2 = (nsIFactory)Marshal.GetObjectForIUnknown(classObject);
		Xpcom.ComponentRegistrar.UnregisterFactory(ref aClass, nsIFactory2);
		_factoryTypeName = typeFromHandle.FullName;
		_isRegistered = false;
		return new FactoryDetails
		{
			classID = aClass,
			factoryInstance = nsIFactory2
		};
	}

	public static string GetContractID()
	{
		return _contractID;
	}

	public static string GetFactoryTypeName()
	{
		return _factoryTypeName;
	}
}
