using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

public sealed class GClass0 : Component
{
	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private MouseEventHandler mouseEventHandler_2;

	private MouseEventHandler mouseEventHandler_3;

	private MouseEventHandler mouseEventHandler_4;

	private EventHandler<GEventArgs0> eventHandler_0;

	private EventHandler<GEventArgs0> eventHandler_1;

	private KeyPressEventHandler keyPressEventHandler_0;

	private KeyEventHandler keyEventHandler_0;

	private KeyEventHandler keyEventHandler_1;

	protected override bool CanRaiseEvents => true;

	private void method_0(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_0;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	private void method_1(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_0;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	public void method_2(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (mouseEventHandler_0 == null)
		{
			GClass1.smethod_10(new MouseEventHandler(method_4));
		}
		method_0(mouseEventHandler_5);
	}

	public void method_3(MouseEventHandler mouseEventHandler_5)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		method_1(mouseEventHandler_5);
		if (mouseEventHandler_0 == null)
		{
			GClass1.smethod_11(new MouseEventHandler(method_4));
		}
	}

	private void method_4(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_0 != null)
		{
			mouseEventHandler_0.Invoke((object)this, e);
		}
	}

	private void method_5(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_1;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_1, value, val2);
		}
		while (val != val2);
	}

	private void method_6(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_1;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_1, value, val2);
		}
		while (val != val2);
	}

	public void method_7(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (mouseEventHandler_1 == null)
		{
			GClass1.smethod_18(new MouseEventHandler(method_9));
		}
		method_5(mouseEventHandler_5);
	}

	public void method_8(MouseEventHandler mouseEventHandler_5)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		method_6(mouseEventHandler_5);
		if (mouseEventHandler_1 == null)
		{
			GClass1.smethod_19(new MouseEventHandler(method_9));
		}
	}

	private void method_9(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_1 != null)
		{
			mouseEventHandler_1.Invoke((object)this, e);
		}
	}

	private void method_10(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_2;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_2, value, val2);
		}
		while (val != val2);
	}

	private void method_11(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_2;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_2, value, val2);
		}
		while (val != val2);
	}

	public void method_12(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (mouseEventHandler_2 == null)
		{
			GClass1.smethod_26(new MouseEventHandler(method_14));
		}
		method_10(mouseEventHandler_5);
	}

	public void method_13(MouseEventHandler mouseEventHandler_5)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		method_11(mouseEventHandler_5);
		if (mouseEventHandler_2 == null)
		{
			GClass1.smethod_27(new MouseEventHandler(method_14));
		}
	}

	private void method_14(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_2 != null)
		{
			mouseEventHandler_2.Invoke((object)this, e);
		}
	}

	private void method_15(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_3;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_3, value, val2);
		}
		while (val != val2);
	}

	private void method_16(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_3;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_3, value, val2);
		}
		while (val != val2);
	}

	public void method_17(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (mouseEventHandler_3 == null)
		{
			GClass1.smethod_30(new MouseEventHandler(method_19));
		}
		method_15(mouseEventHandler_5);
	}

	public void method_18(MouseEventHandler mouseEventHandler_5)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		method_16(mouseEventHandler_5);
		if (mouseEventHandler_3 == null)
		{
			GClass1.smethod_31(new MouseEventHandler(method_19));
		}
	}

	private void method_19(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_3 != null)
		{
			mouseEventHandler_3.Invoke((object)this, e);
		}
	}

	private void method_20(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_4;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_4, value, val2);
		}
		while (val != val2);
	}

	private void method_21(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_4;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_5);
			val = Interlocked.CompareExchange(ref mouseEventHandler_4, value, val2);
		}
		while (val != val2);
	}

	public void method_22(MouseEventHandler mouseEventHandler_5)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (mouseEventHandler_4 == null)
		{
			GClass1.smethod_38(new MouseEventHandler(method_24));
		}
		method_20(mouseEventHandler_5);
	}

	public void method_23(MouseEventHandler mouseEventHandler_5)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		method_21(mouseEventHandler_5);
		if (mouseEventHandler_4 == null)
		{
			GClass1.smethod_39(new MouseEventHandler(method_24));
		}
	}

	private void method_24(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_4 != null)
		{
			mouseEventHandler_4.Invoke((object)this, e);
		}
	}

	private void method_25(EventHandler<GEventArgs0> eventHandler_2)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_0;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void method_26(EventHandler<GEventArgs0> eventHandler_2)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_0;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_27(EventHandler<GEventArgs0> eventHandler_2)
	{
		if (eventHandler_0 == null)
		{
			GClass1.smethod_14(method_29);
		}
		method_25(eventHandler_2);
	}

	public void method_28(EventHandler<GEventArgs0> eventHandler_2)
	{
		method_26(eventHandler_2);
		if (eventHandler_0 == null)
		{
			GClass1.smethod_15(method_29);
		}
	}

	private void method_29(object sender, GEventArgs0 e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	private void method_30(EventHandler<GEventArgs0> eventHandler_2)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_1;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private void method_31(EventHandler<GEventArgs0> eventHandler_2)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_1;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_32(EventHandler<GEventArgs0> eventHandler_2)
	{
		if (eventHandler_1 == null)
		{
			GClass1.smethod_22(method_34);
		}
		method_30(eventHandler_2);
	}

	public void method_33(EventHandler<GEventArgs0> eventHandler_2)
	{
		method_31(eventHandler_2);
		if (eventHandler_1 == null)
		{
			GClass1.smethod_23(method_34);
		}
	}

	private void method_34(object sender, GEventArgs0 e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
		}
	}

	private void method_35(KeyPressEventHandler keyPressEventHandler_1)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		KeyPressEventHandler val = keyPressEventHandler_0;
		KeyPressEventHandler val2;
		do
		{
			val2 = val;
			KeyPressEventHandler value = (KeyPressEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)keyPressEventHandler_1);
			val = Interlocked.CompareExchange(ref keyPressEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	private void method_36(KeyPressEventHandler keyPressEventHandler_1)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		KeyPressEventHandler val = keyPressEventHandler_0;
		KeyPressEventHandler val2;
		do
		{
			val2 = val;
			KeyPressEventHandler value = (KeyPressEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)keyPressEventHandler_1);
			val = Interlocked.CompareExchange(ref keyPressEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	public void method_37(KeyPressEventHandler keyPressEventHandler_1)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (keyPressEventHandler_0 == null)
		{
			GClass1.smethod_44(new KeyPressEventHandler(method_39));
		}
		method_35(keyPressEventHandler_1);
	}

	public void method_38(KeyPressEventHandler keyPressEventHandler_1)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		method_36(keyPressEventHandler_1);
		if (keyPressEventHandler_0 == null)
		{
			GClass1.smethod_45(new KeyPressEventHandler(method_39));
		}
	}

	private void method_39(object sender, KeyPressEventArgs e)
	{
		if (keyPressEventHandler_0 != null)
		{
			keyPressEventHandler_0.Invoke((object)this, e);
		}
	}

	private void method_40(KeyEventHandler keyEventHandler_2)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		KeyEventHandler val = keyEventHandler_0;
		KeyEventHandler val2;
		do
		{
			val2 = val;
			KeyEventHandler value = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)keyEventHandler_2);
			val = Interlocked.CompareExchange(ref keyEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	private void method_41(KeyEventHandler keyEventHandler_2)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		KeyEventHandler val = keyEventHandler_0;
		KeyEventHandler val2;
		do
		{
			val2 = val;
			KeyEventHandler value = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)keyEventHandler_2);
			val = Interlocked.CompareExchange(ref keyEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	public void method_42(KeyEventHandler keyEventHandler_2)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (keyEventHandler_0 == null)
		{
			GClass1.smethod_48(new KeyEventHandler(method_44));
		}
		method_40(keyEventHandler_2);
	}

	public void method_43(KeyEventHandler keyEventHandler_2)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		method_41(keyEventHandler_2);
		if (keyEventHandler_0 == null)
		{
			GClass1.smethod_49(new KeyEventHandler(method_44));
		}
	}

	private void method_44(object sender, KeyEventArgs e)
	{
		if (keyEventHandler_0 != null)
		{
			keyEventHandler_0.Invoke((object)this, e);
		}
	}

	private void method_45(KeyEventHandler keyEventHandler_2)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		KeyEventHandler val = keyEventHandler_1;
		KeyEventHandler val2;
		do
		{
			val2 = val;
			KeyEventHandler value = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)keyEventHandler_2);
			val = Interlocked.CompareExchange(ref keyEventHandler_1, value, val2);
		}
		while (val != val2);
	}

	private void method_46(KeyEventHandler keyEventHandler_2)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		KeyEventHandler val = keyEventHandler_1;
		KeyEventHandler val2;
		do
		{
			val2 = val;
			KeyEventHandler value = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)keyEventHandler_2);
			val = Interlocked.CompareExchange(ref keyEventHandler_1, value, val2);
		}
		while (val != val2);
	}

	public void method_47(KeyEventHandler keyEventHandler_2)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (keyEventHandler_1 == null)
		{
			GClass1.smethod_52(new KeyEventHandler(method_49));
		}
		method_45(keyEventHandler_2);
	}

	public void method_48(KeyEventHandler keyEventHandler_2)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		method_46(keyEventHandler_2);
		if (keyEventHandler_1 == null)
		{
			GClass1.smethod_53(new KeyEventHandler(method_49));
		}
	}

	private void method_49(object sender, KeyEventArgs e)
	{
		keyEventHandler_1.Invoke((object)this, e);
	}
}
