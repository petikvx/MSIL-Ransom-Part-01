using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using e1t9ZoIMs7pU1MfVBaV;
using elRV9N3vPjJN4FNmtXC;

namespace eqZXCHiEbDhybQeTJQ;

internal class e0Cjra8fljlSSAO9M1
{
	private static Assembly e9IgDZCnQ;

	private static string[] eWNbTSexZ;

	internal static void e4ZIbpnTa()
	{
		try
		{
			try
			{
				ewMaxokmLrN2OGPYNHm(eMk993kPPLP8XnHQbjm(), new ResolveEventHandler(eKb3AYt8Z));
			}
			catch (Exception)
			{
			}
		}
		catch (Exception object_)
		{
			e46i81kxyWdXfSeYmUo(object_);
			throw;
		}
	}

	private static Assembly eKb3AYt8Z(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string[] array = default(string[]);
		string object_ = default(string);
		int num = default(int);
		try
		{
			if ((object)e9IgDZCnQ == null)
			{
				eqyIGiQJByWcvjR0kcD(array = eWNbTSexZ);
				try
				{
					e9IgDZCnQ = (Assembly)eYZN5BkzyQtImOYXFB0(eDuaTU3TDhsqeVkuTG8.eulODlten(628));
					ej6mF6krr3cW93rw8li();
					if (eujvLlkngiBBdMrOfly() || (object)e9IgDZCnQ != null)
					{
						eWNbTSexZ = (string[])eyYxitQ7XybAuIj8Qg9(e9IgDZCnQ);
					}
				}
				finally
				{
					eOq2ibQ93L1EPW3DdAa(array);
				}
			}
			object_ = (string)eNrTNVQkD98bR7l2WZ7(resolveEventArgs_0);
			num = 0;
			while (true)
			{
				if (num < eWNbTSexZ.Length)
				{
					if (e8LtOIQQxPRlIZegYrr(eWNbTSexZ[num], object_))
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			if (!eFyBxUQL2s3j2ktjFkr())
			{
				return null;
			}
			return e9IgDZCnQ;
		}
		catch (Exception object_2)
		{
			eN0uG6QjkyM0eTETVUX(object_2, object_, num, array, object_0, resolveEventArgs_0);
			throw;
		}
	}

	private static bool exwyp4bAY()
	{
		StackFrame[] array = default(StackFrame[]);
		int num = default(int);
		StackFrame stackFrame = default(StackFrame);
		bool flag = default(bool);
		try
		{
			try
			{
				array = (StackFrame[])eFtdhPQ5t96F5hes7aW(new StackTrace());
				num = 2;
				while (true)
				{
					if (num < array.Length)
					{
						stackFrame = array[num];
						if (ej7tP3QgnNvvVEn108e(e07ngsQZiaUvEfXYys3(eGRL2EQCP0UAXopvSqe(stackFrame))) == eFWmiFQ2OPtZorCX8FP())
						{
							break;
						}
						num++;
						continue;
					}
					flag = false;
					return flag;
				}
				flag = true;
				return flag;
			}
			catch
			{
				flag = true;
				return flag;
			}
		}
		catch (Exception object_)
		{
			e19J2ZQiqppYUkMZw6G(object_, array, num, stackFrame, flag);
			throw;
		}
	}

	public e0Cjra8fljlSSAO9M1()
	{
		ekp0jGQEjYRrsYHbqfK(this);
	}

	static e0Cjra8fljlSSAO9M1()
	{
		try
		{
			e9IgDZCnQ = null;
			eWNbTSexZ = new string[0];
		}
		catch (Exception object_)
		{
			e46i81kxyWdXfSeYmUo(object_);
			throw;
		}
	}

	internal static object eMk993kPPLP8XnHQbjm()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void ewMaxokmLrN2OGPYNHm(object object_0, object object_1)
	{
		((AppDomain)object_0).ResourceResolve += (ResolveEventHandler?)object_1;
	}

	internal static void e46i81kxyWdXfSeYmUo(object object_0)
	{
		eEJNauItTVW1j8pluTb.eulODlten((Exception)object_0);
	}

	internal static bool ej6mF6krr3cW93rw8li()
	{
		return true;
	}

	internal static bool eujvLlkngiBBdMrOfly()
	{
		return false;
	}

	internal static object eYZN5BkzyQtImOYXFB0(object object_0)
	{
		return Assembly.Load((string)object_0);
	}

	internal static object eyYxitQ7XybAuIj8Qg9(object object_0)
	{
		return ((Assembly)object_0).GetManifestResourceNames();
	}

	internal static void eOq2ibQ93L1EPW3DdAa(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static object eNrTNVQkD98bR7l2WZ7(object object_0)
	{
		return ((ResolveEventArgs)object_0).Name;
	}

	internal static bool e8LtOIQQxPRlIZegYrr(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static bool eFyBxUQL2s3j2ktjFkr()
	{
		return exwyp4bAY();
	}

	internal static void eqyIGiQJByWcvjR0kcD(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void eN0uG6QjkyM0eTETVUX(object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		eEJNauItTVW1j8pluTb.eKyrTQhVp((Exception)object_0, object_1, object_2, object_3, object_4, object_5);
	}

	internal static object eFtdhPQ5t96F5hes7aW(object object_0)
	{
		return ((StackTrace)object_0).GetFrames();
	}

	internal static object eGRL2EQCP0UAXopvSqe(object object_0)
	{
		return ((StackFrame)object_0).GetMethod();
	}

	internal static object e07ngsQZiaUvEfXYys3(object object_0)
	{
		return ((MemberInfo)object_0).Module;
	}

	internal static object ej7tP3QgnNvvVEn108e(object object_0)
	{
		return ((Module)object_0).Assembly;
	}

	internal static object eFWmiFQ2OPtZorCX8FP()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static void e19J2ZQiqppYUkMZw6G(object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		eEJNauItTVW1j8pluTb.elN6Gg9Qb((Exception)object_0, object_1, object_2, object_3, object_4);
	}

	internal static void ekp0jGQEjYRrsYHbqfK(object object_0)
	{
		object_0._002Ector();
	}
}
