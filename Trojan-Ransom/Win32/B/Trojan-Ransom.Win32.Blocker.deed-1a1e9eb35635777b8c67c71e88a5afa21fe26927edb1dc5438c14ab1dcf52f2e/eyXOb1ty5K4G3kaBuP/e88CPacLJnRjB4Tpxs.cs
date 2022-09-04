using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using e1t9ZoIMs7pU1MfVBaV;
using elRV9N3vPjJN4FNmtXC;

namespace eyXOb1ty5K4G3kaBuP;

internal sealed class e88CPacLJnRjB4Tpxs : IDisposable
{
	private readonly Type exwyp4bAY;

	private readonly object e9IgDZCnQ;

	public e88CPacLJnRjB4Tpxs()
	{
		e0LBq5QmhogyemeLJnV(this);
		Assembly assembly = default(Assembly);
		try
		{
			try
			{
				assembly = (Assembly)ejom1JQxAxplpIViLYU(eDuaTU3TDhsqeVkuTG8.eulODlten(874));
				exwyp4bAY = e9evC2Qzno2CYgYbjJw(assembly, eDuaTU3TDhsqeVkuTG8.eulODlten(1034));
			}
			catch (FileNotFoundException)
			{
				assembly = (Assembly)ejom1JQxAxplpIViLYU(eDuaTU3TDhsqeVkuTG8.eulODlten(1116));
				exwyp4bAY = e9evC2Qzno2CYgYbjJw(assembly, eDuaTU3TDhsqeVkuTG8.eulODlten(1136));
			}
			e9IgDZCnQ = eIOWkxL7U3oSGNsJAcj(exwyp4bAY);
		}
		catch (Exception object_)
		{
			e104WtL9fZXQRSU7FCQ(object_, assembly, this);
			throw;
		}
	}

	public ICryptoTransform e4ZIbpnTa(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		object[] object_3 = default(object[]);
		MethodInfo method = default(MethodInfo);
		try
		{
			object object_ = eVeFGrLk6jbIxP4h9D5(exwyp4bAY.GetProperty(eDuaTU3TDhsqeVkuTG8.eulODlten(1228)));
			object object_2 = e9IgDZCnQ;
			object_3 = new object[1] { byte_0 };
			eI6V76LQwCm9G0rxLxR(object_, object_2, object_3);
			object object_4 = eVeFGrLk6jbIxP4h9D5(exwyp4bAY.GetProperty(eDuaTU3TDhsqeVkuTG8.eulODlten(1238)));
			object object_5 = e9IgDZCnQ;
			object_3 = new object[1] { byte_1 };
			eI6V76LQwCm9G0rxLxR(object_4, object_5, object_3);
			et4MyQQnxbIv8BPSY42();
			if (!epAIexQPkje1iBQ0I38())
			{
				method = exwyp4bAY.GetMethod(bool_0 ? eDuaTU3TDhsqeVkuTG8.eulODlten(1280) : eDuaTU3TDhsqeVkuTG8.eulODlten(1246), new Type[0]);
			}
			return (ICryptoTransform)eI6V76LQwCm9G0rxLxR(method, e9IgDZCnQ, new object[0]);
		}
		catch (Exception object_6)
		{
			e7H8BoLLF0VU1IQMqe1(object_6, method, object_3, this, byte_0, byte_1, bool_0);
			throw;
		}
	}

	public void eKb3AYt8Z()
	{
		try
		{
			eI6V76LQwCm9G0rxLxR(exwyp4bAY.GetMethod(eDuaTU3TDhsqeVkuTG8.eulODlten(1314)), e9IgDZCnQ, new object[0]);
		}
		catch (Exception object_)
		{
			eXcq2nLJdZBQveuFd5Z(object_, this);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			eKb3AYt8Z();
		}
		catch (Exception object_)
		{
			eXcq2nLJdZBQveuFd5Z(object_, this);
			throw;
		}
	}

	internal static void e0LBq5QmhogyemeLJnV(object object_0)
	{
		object_0._002Ector();
	}

	internal static object ejom1JQxAxplpIViLYU(object object_0)
	{
		return Assembly.Load((string)object_0);
	}

	internal static Type e9evC2Qzno2CYgYbjJw(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetType((string)object_1);
	}

	internal static object eIOWkxL7U3oSGNsJAcj(Type type_0)
	{
		return Activator.CreateInstance(type_0);
	}

	internal static void e104WtL9fZXQRSU7FCQ(object object_0, object object_1, object object_2)
	{
		eEJNauItTVW1j8pluTb.e9jslfSvk((Exception)object_0, object_1, object_2);
	}

	internal static bool et4MyQQnxbIv8BPSY42()
	{
		return true;
	}

	internal static bool epAIexQPkje1iBQ0I38()
	{
		return false;
	}

	internal static object eVeFGrLk6jbIxP4h9D5(object object_0)
	{
		return ((PropertyInfo)object_0).GetSetMethod();
	}

	internal static object eI6V76LQwCm9G0rxLxR(object object_0, object object_1, object object_2)
	{
		return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
	}

	internal static void e7H8BoLLF0VU1IQMqe1(object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		eEJNauItTVW1j8pluTb.euXHswL8F((Exception)object_0, object_1, object_2, object_3, object_4, object_5, object_6);
	}

	internal static void eXcq2nLJdZBQveuFd5Z(object object_0, object object_1)
	{
		eEJNauItTVW1j8pluTb.ecs0D1Zdd((Exception)object_0, object_1);
	}
}
