using System;
using System.Collections.Generic;

namespace ELiiZIZsmnkXtAYV3eOEAphwNQfX;

public class ObjectDB
{
	public object ob;

	public List<object> obMass;

	public static ObjectDB Serialization(params object[] oEn3szVbOHHRVnjokeZ8Lsm0yUxd5bm)
	{
		ObjectDB objectDB = new ObjectDB();
		objectDB.obMass = new List<object>();
		try
		{
			object[] array = oEn3szVbOHHRVnjokeZ8Lsm0yUxd5bm;
			foreach (object item in array)
			{
				objectDB.obMass.Add(item);
			}
		}
		catch
		{
		}
		oEn3szVbOHHRVnjokeZ8Lsm0yUxd5bm = null;
		return objectDB;
	}

	public static bool Equals(List<object> obMass, params object[] outOB)
	{
		try
		{
			int num = 0;
			while (true)
			{
				if (num < outOB.Length)
				{
					if (!Equals(obMass[num], outOB[num]))
					{
						break;
					}
					num++;
					continue;
				}
				obMass = null;
				outOB = null;
				return true;
			}
			obMass = null;
			outOB = null;
			return false;
		}
		catch
		{
		}
		obMass = null;
		outOB = null;
		return false;
	}

	public new static bool Equals(object intOB, object outOB)
	{
		bool result = false;
		try
		{
			result = intOB.Equals(outOB);
		}
		catch
		{
		}
		intOB = null;
		outOB = null;
		return result;
	}

	public static bool Equals(List<object> obMass, params TypeCode[] typeCode)
	{
		try
		{
			int num = 0;
			while (true)
			{
				if (num < typeCode.Length)
				{
					if (!Equals(obMass[num], typeCode[num]))
					{
						break;
					}
					num++;
					continue;
				}
				obMass = null;
				typeCode = null;
				return true;
			}
			obMass = null;
			typeCode = null;
			return false;
		}
		catch
		{
		}
		obMass = null;
		typeCode = null;
		return false;
	}

	public static bool Equals(object intOB, TypeCode typeCode)
	{
		bool result = false;
		try
		{
			result = Type.GetTypeCode(intOB.GetType()) == typeCode;
		}
		catch
		{
		}
		intOB = null;
		return result;
	}
}
