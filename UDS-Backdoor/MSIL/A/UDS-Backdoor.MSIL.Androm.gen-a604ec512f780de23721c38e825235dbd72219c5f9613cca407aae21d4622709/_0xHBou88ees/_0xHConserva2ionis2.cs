using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.VisualStudio.PlatformUI;
using _0xHArche6poria;
using _0xHHor1e1hoe1;
using _0xHM8ndrill;

namespace _0xHBou88ees;

public class _0xHConserva2ionis2 : _0xHHandc6ap, ICloseableDialog, IComponentConnector
{
	[SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal TextBlock _0xHOlei3e;

	[SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal ProgressBar _0xHUp3il3;

	[SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal Button _0xHA2ropuls2s;

	private bool _0xHDi7paragement;

	bool? ICloseableDialog.DialogResult => ((Window)this).get_DialogResult();

	public _0xHConserva2ionis2(_0xH4rboretum viewModel)
	{
		_0xHExplicati5e();
		((Window)this).set_WindowStartupLocation((WindowStartupLocation)2);
		((FrameworkElement)this).set_DataContext((object)viewModel);
	}

	public void _0xHTr1ag1ng(bool _0xHSte3osaurus)
	{
		((Window)this).set_DialogResult((bool?)_0xHSte3osaurus);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void _0xHExplicati5e()
	{
		if (!_0xHDi7paragement)
		{
			_0xHDi7paragement = true;
			Uri uri = new Uri("/Microsoft.VisualStudio.WindowsAzure.Common.2.9;component/controls/cancellableprogressdialog.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Delegate _0xHRallie8(Type _0xHMuco3a, string _0xHPicc5t5)
	{
		return Delegate.CreateDelegate(_0xHMuco3a, this, _0xHPicc5t5);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[DebuggerNonUserCode]
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void _0xHOptativ3ly(int _0xHExtru8ion8, object _0xHTender2z2ng)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		switch (_0xHExtru8ion8)
		{
		default:
			_0xHDi7paragement = true;
			break;
		case 1:
			_0xHOlei3e = (TextBlock)_0xHTender2z2ng;
			break;
		case 2:
			_0xHUp3il3 = (ProgressBar)_0xHTender2z2ng;
			break;
		case 3:
			_0xHA2ropuls2s = (Button)_0xHTender2z2ng;
			break;
		}
	}

	private bool? _0xHW8nn8bee()
	{
		return ((DialogWindow)this).ShowModal();
	}

	bool? ICloseableDialog.ShowModal()
	{
		//ILSpy generated this explicit interface implementation from .override directive in _0xHW8nn8bee
		return this._0xHW8nn8bee();
	}
}
