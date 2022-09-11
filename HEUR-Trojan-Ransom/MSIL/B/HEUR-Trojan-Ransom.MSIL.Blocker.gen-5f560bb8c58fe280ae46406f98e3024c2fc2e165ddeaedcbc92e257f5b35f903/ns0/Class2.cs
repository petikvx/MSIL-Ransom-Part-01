using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal sealed class Class2 : ContextMenuStrip
{
	public delegate void Delegate1(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0);

	public delegate void Delegate2(ToolStripItemTextRenderEventArgs toolStripItemTextRenderEventArgs_0);

	public delegate void Delegate3(ToolStripRenderEventArgs toolStripRenderEventArgs_0);

	public delegate void Delegate4(ToolStripRenderEventArgs toolStripRenderEventArgs_0);

	[CompilerGenerated]
	private Delegate1 delegate1_0;

	[CompilerGenerated]
	private Delegate2 delegate2_0;

	[CompilerGenerated]
	private Delegate3 delegate3_0;

	[CompilerGenerated]
	private Delegate4 delegate4_0;

	public event Delegate1 Event_0
	{
		[CompilerGenerated]
		add
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event Delegate2 Event_1
	{
		[CompilerGenerated]
		add
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event Delegate3 Event_2
	{
		[CompilerGenerated]
		add
		{
			Delegate3 @delegate = delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value2 = (Delegate3)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate3_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate3 @delegate = delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value2 = (Delegate3)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate3_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event Delegate4 Event_3
	{
		[CompilerGenerated]
		add
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public Class2()
	{
		Class3 @class = new Class3();
		@class.Event_2 += method_2;
		@class.Event_3 += method_3;
		@class.Event_1 += method_1;
		@class.Event_0 += method_0;
		((ToolStrip)this).set_Renderer((ToolStripRenderer)(object)@class);
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((ToolStripDropDown)this).OnHandleCreated(eventArgs_0);
		Class5.SetWindowTheme(((Control)this).get_Handle(), null, string.Empty);
	}

	private void method_0(object sender, ToolStripItemRenderEventArgs e)
	{
		delegate1_0?.Invoke(e);
	}

	private void method_1(object sender, ToolStripItemTextRenderEventArgs e)
	{
		delegate2_0?.Invoke(e);
	}

	private void method_2(object sender, ToolStripRenderEventArgs e)
	{
		delegate3_0?.Invoke(e);
	}

	private void method_3(object sender, ToolStripRenderEventArgs e)
	{
		delegate4_0?.Invoke(e);
	}
}
