using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MiniGameEngine;

public class Input
{
	[AccessedThroughProperty("Listener")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GameContainer gameContainer_0;

	[AccessedThroughProperty("Window")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Form form_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_0;

	private object[] object_0;

	private virtual Form Window
	{
		[CompilerGenerated]
		get
		{
			return form_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			KeyEventHandler val = new KeyEventHandler(method_2);
			KeyEventHandler val2 = new KeyEventHandler(method_3);
			KeyPressEventHandler val3 = new KeyPressEventHandler(method_4);
			MouseEventHandler val4 = new MouseEventHandler(method_5);
			MouseEventHandler val5 = new MouseEventHandler(method_6);
			MouseEventHandler val6 = new MouseEventHandler(method_7);
			MouseEventHandler val7 = new MouseEventHandler(method_8);
			MouseEventHandler val8 = new MouseEventHandler(method_9);
			EventHandler eventHandler = method_10;
			Form val9 = form_0;
			if (val9 != null)
			{
				((Control)val9).remove_KeyDown(val);
				((Control)val9).remove_KeyUp(val2);
				((Control)val9).remove_KeyPress(val3);
				((Control)val9).remove_MouseDown(val4);
				((Control)val9).remove_MouseUp(val5);
				((Control)val9).remove_MouseClick(val6);
				((Control)val9).remove_MouseDoubleClick(val7);
				((Control)val9).remove_MouseMove(val8);
				((Control)val9).remove_SizeChanged(eventHandler);
			}
			form_0 = value;
			val9 = form_0;
			if (val9 != null)
			{
				((Control)val9).add_KeyDown(val);
				((Control)val9).add_KeyUp(val2);
				((Control)val9).add_KeyPress(val3);
				((Control)val9).add_MouseDown(val4);
				((Control)val9).add_MouseUp(val5);
				((Control)val9).add_MouseClick(val6);
				((Control)val9).add_MouseDoubleClick(val7);
				((Control)val9).add_MouseMove(val8);
				((Control)val9).add_SizeChanged(eventHandler);
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private virtual GameContainer vmethod_0()
	{
		return gameContainer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[CompilerGenerated]
	private virtual void vmethod_1(GameContainer WithEventsValue)
	{
		gameContainer_0 = WithEventsValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(bool AutoPropertyValue)
	{
		bool_0 = AutoPropertyValue;
	}

	public Input(ref GameContainer Listener, bool Attached = true)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		object_0 = new object[3];
		vmethod_1(Listener);
		Window = Listener.Window;
		method_1(Attached);
	}

	public void Attach()
	{
		method_1(AutoPropertyValue: true);
	}

	public void Detach()
	{
		method_1(AutoPropertyValue: false);
	}

	private void method_2(object sender, KeyEventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (method_0())
		{
			object_0[0] = DateTime.Now.Ticks;
			object_0[1] = e.get_KeyCode();
			vmethod_0().currentScene.KeyDown(e.get_KeyCode());
		}
	}

	private void method_3(object sender, KeyEventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (method_0())
		{
			if ((DateTime.Now - new DateTime(Conversions.ToLong(object_0[0]))).Milliseconds < 150 && Operators.ConditionalCompareObjectEqual(object_0[1], (object)e.get_KeyCode(), false))
			{
				object_0[0] = DateTime.Now.Ticks;
				object_0[1] = null;
				vmethod_0().currentScene.KeyPress(e.get_KeyCode());
			}
			vmethod_0().currentScene.KeyUp(e.get_KeyCode());
		}
	}

	private void method_4(object sender, KeyPressEventArgs e)
	{
	}

	private void method_5(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (method_0())
		{
			vmethod_0().currentScene.MouseDown(e.get_Button());
		}
	}

	private void method_6(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (method_0())
		{
			vmethod_0().currentScene.MouseUp(e.get_Button());
		}
	}

	private void method_7(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (method_0())
		{
			vmethod_0().currentScene.MouseClick(e.get_Button());
		}
	}

	private void method_8(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (method_0())
		{
			vmethod_0().currentScene.MouseDoubleClick(e.get_Button());
		}
	}

	private void method_9(object sender, MouseEventArgs e)
	{
		if (method_0())
		{
			vmethod_0().currentScene.MouseMove(e.get_Location());
		}
	}

	private void method_10(object object_1, object object_2)
	{
		if (method_0())
		{
			vmethod_0().currentScene.WindowSizeChange();
		}
	}
}
