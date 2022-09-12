using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic.CompilerServices;
using SAPBusinessObjects.WPF.Viewer;

namespace k9F;

[DesignerGenerated]
public class Nq6 : Window, IComponentConnector
{
	private bool _contentLoaded;

	internal CrystalReportsViewer h;

	public Nq6()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((FrameworkElement)this).add_Loaded(new RoutedEventHandler(Lf4));
		Xx8();
	}

	private void Px7(object sender, RoutedEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		new TableLogOnInfos();
		TableLogOnInfo val = new TableLogOnInfo();
		ConnectionInfo connectionInfo = new ConnectionInfo();
		Tables val2 = (Tables)NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Database", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Tables", new object[0], (string[])null, (Type[])null, (bool[])null);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((SCRCollection)val2).GetEnumerator();
			while (enumerator.MoveNext())
			{
				Table val3 = (Table)enumerator.Current;
				val = val3.get_LogOnInfo();
				val.set_ConnectionInfo(connectionInfo);
				val3.ApplyLogOnInfo(val);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void Lf4(object sender, RoutedEventArgs e)
	{
	}

	internal static byte[] Pn5(int[] x8M, int Mn9)
	{
		checked
		{
			byte[] array = new byte[Mn9 + 1];
			int num = x8M.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)x8M[i];
			}
			return array;
		}
	}

	[SpecialName]
	internal virtual CrystalReportsViewer Ym4()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7D(CrystalReportsViewer Rs6)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		RoutedEventHandler val = new RoutedEventHandler(Px7);
		CrystalReportsViewer val2 = h;
		if (val2 != null)
		{
			((FrameworkElement)val2).remove_Loaded(val);
		}
		CrystalReportsViewer val3 = (h = Rs6);
		val2 = h;
		if (val2 != null)
		{
			((FrameworkElement)val2).add_Loaded(val);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void Xx8()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/PatientRecordManagementSystem;component/reportviewer.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void d0B(int p0F, object m3P)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (p0F == 1)
		{
			g7D((CrystalReportsViewer)m3P);
			((FrameworkElement)Ym4()).add_Loaded(new RoutedEventHandler(Px7));
		}
		else
		{
			_contentLoaded = true;
		}
	}
}
