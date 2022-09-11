using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

public abstract class NavMenu : Control
{
	public delegate void ItemSelectedEventHandler(object sender, NavMenuItemSelectedEventArgs e);

	private TabControl tabControl_0;

	private NavMenuItemCollection navMenuItemCollection_0;

	private NavMenuBaseItem navMenuBaseItem_0;

	[CompilerGenerated]
	private ItemSelectedEventHandler itemSelectedEventHandler_0;

	internal ImageList imageList_0;

	internal ImageList imageList_1;

	internal NavMenuBaseItem navMenuBaseItem_1;

	public ImageList ImageList
	{
		get
		{
			return imageList_0;
		}
		set
		{
			if (imageList_0 != null)
			{
				imageList_0.remove_RecreateHandle((EventHandler)method_2);
				((Component)(object)imageList_0).Disposed -= method_1;
			}
			ImageList val = (imageList_0 = value);
			if (value != null)
			{
				value.add_RecreateHandle((EventHandler)method_2);
				((Component)(object)value).Disposed += method_1;
			}
			((Control)this).PerformLayout();
		}
	}

	public NavMenuItemCollection Items => navMenuItemCollection_0;

	public ImageList SubImageList
	{
		get
		{
			return imageList_1;
		}
		set
		{
			if (imageList_1 != null)
			{
				imageList_1.remove_RecreateHandle((EventHandler)method_2);
				((Component)(object)imageList_1).Disposed -= method_5;
			}
			ImageList val = (imageList_1 = value);
			if (value != null)
			{
				value.add_RecreateHandle((EventHandler)method_2);
				((Component)(object)value).Disposed += method_5;
			}
			((Control)this).PerformLayout();
		}
	}

	public TabControl TabControl
	{
		get
		{
			return tabControl_0;
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			if (tabControl_0 != null)
			{
				tabControl_0.remove_Selected(new TabControlEventHandler(method_7));
				((Component)(object)tabControl_0).Disposed -= method_6;
			}
			tabControl_0 = value;
			if (value != null)
			{
				value.add_Selected(new TabControlEventHandler(method_7));
				((Component)(object)value).Disposed += method_6;
			}
		}
	}

	public event ItemSelectedEventHandler ItemSelected
	{
		[CompilerGenerated]
		add
		{
			ItemSelectedEventHandler itemSelectedEventHandler = itemSelectedEventHandler_0;
			ItemSelectedEventHandler itemSelectedEventHandler2;
			do
			{
				itemSelectedEventHandler2 = itemSelectedEventHandler;
				ItemSelectedEventHandler value2 = (ItemSelectedEventHandler)Delegate.Combine(itemSelectedEventHandler2, value);
				itemSelectedEventHandler = Interlocked.CompareExchange(ref itemSelectedEventHandler_0, value2, itemSelectedEventHandler2);
			}
			while ((object)itemSelectedEventHandler != itemSelectedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ItemSelectedEventHandler itemSelectedEventHandler = itemSelectedEventHandler_0;
			ItemSelectedEventHandler itemSelectedEventHandler2;
			do
			{
				itemSelectedEventHandler2 = itemSelectedEventHandler;
				ItemSelectedEventHandler value2 = (ItemSelectedEventHandler)Delegate.Remove(itemSelectedEventHandler2, value);
				itemSelectedEventHandler = Interlocked.CompareExchange(ref itemSelectedEventHandler_0, value2, itemSelectedEventHandler2);
			}
			while ((object)itemSelectedEventHandler != itemSelectedEventHandler2);
		}
	}

	public NavMenu()
	{
		((Control)this).SetStyle((ControlStyles)139270, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		navMenuItemCollection_0 = new NavMenuItemCollection(this);
	}

	private NavMenuBaseItem method_0(TabPage tabPage_0)
	{
		IEnumerator enumerator = null;
		IEnumerator enumerator2 = null;
		if (tabPage_0 != null)
		{
			try
			{
				enumerator = Items.vmethod_1();
				while (enumerator.MoveNext())
				{
					NavMenuItem navMenuItem = (NavMenuItem)enumerator.Current;
					if (navMenuItem.TabPage != tabPage_0)
					{
						try
						{
							enumerator2 = navMenuItem.SubItems.vmethod_1();
							while (enumerator2.MoveNext())
							{
								NavMenuSubItem navMenuSubItem = (NavMenuSubItem)enumerator2.Current;
								if (navMenuSubItem.TabPage == tabPage_0)
								{
									return navMenuSubItem;
								}
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						continue;
					}
					return navMenuItem;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return null;
		}
		return null;
	}

	internal abstract NavMenuItem vmethod_0(Point point_0);

	private void method_1(object sender, EventArgs e)
	{
		ImageList = null;
	}

	private void method_2(object sender, EventArgs e)
	{
		((Control)this).PerformLayout();
	}

	internal void method_3(NavMenuBaseItem navMenuBaseItem_2)
	{
		if (navMenuBaseItem_2 != navMenuBaseItem_0)
		{
			if (navMenuBaseItem_2 != null)
			{
				navMenuBaseItem_2.Boolean_2 = true;
			}
			if (navMenuBaseItem_0 != null)
			{
				navMenuBaseItem_0.Boolean_2 = false;
			}
			navMenuBaseItem_0 = navMenuBaseItem_2;
			((Control)this).Invalidate();
		}
	}

	protected override void vmethod_1(EventArgs eventArgs_0)
	{
		((Control)this).OnHandleCreated(eventArgs_0);
		if (TabControl != null && TabControl.get_TabCount() > 0)
		{
			method_4(method_0(TabControl.get_SelectedTab()), bool_0: false);
		}
		((Control)this).PerformLayout();
	}

	public static void smethod_0(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ byte_1[i % byte_1.Length]);
		}
	}

	internal void method_4(NavMenuBaseItem navMenuBaseItem_2, bool bool_0)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
		SubImageList = null;
	}

	private void method_6(object sender, EventArgs e)
	{
		TabControl = null;
	}

	private void method_7(object sender, TabControlEventArgs e)
	{
		method_4(method_0(e.get_TabPage()), bool_0: false);
	}
}
