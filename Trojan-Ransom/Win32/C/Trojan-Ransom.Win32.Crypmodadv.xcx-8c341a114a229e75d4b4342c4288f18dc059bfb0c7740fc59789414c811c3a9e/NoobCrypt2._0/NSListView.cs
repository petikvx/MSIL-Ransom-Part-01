using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSListView : Control
{
	public class NSListViewItem
	{
		protected Guid UniqueId;

		public string Text
		{
			[DebuggerNonUserCode]
			get;
			[DebuggerNonUserCode]
			set;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public List<NSListViewSubItem> SubItems
		{
			[DebuggerNonUserCode]
			get;
			[DebuggerNonUserCode]
			set;
		}

		public NSListViewItem()
		{
			List<NSListViewSubItem> list2 = (SubItems = new List<NSListViewSubItem>());
			UniqueId = Guid.NewGuid();
		}

		public override string ToString()
		{
			return Text;
		}

		public override bool Equals(object obj)
		{
			if (obj is NSListViewItem)
			{
				return ((NSListViewItem)obj).UniqueId == UniqueId;
			}
			return false;
		}
	}

	public class NSListViewSubItem
	{
		public string Text
		{
			[DebuggerNonUserCode]
			get;
			[DebuggerNonUserCode]
			set;
		}

		[DebuggerNonUserCode]
		public NSListViewSubItem()
		{
		}

		public override string ToString()
		{
			return Text;
		}
	}

	public class NSListViewColumnHeader
	{
		public string Text
		{
			[DebuggerNonUserCode]
			get;
			[DebuggerNonUserCode]
			set;
		}

		public int Width
		{
			[DebuggerNonUserCode]
			get;
			[DebuggerNonUserCode]
			set;
		}

		public NSListViewColumnHeader()
		{
			Width = 60;
		}

		public override string ToString()
		{
			return Text;
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private List<NSListViewItem> _Items;

	private List<NSListViewItem> _SelectedItems;

	private List<NSListViewColumnHeader> _Columns;

	private bool _MultiSelect;

	private int ItemHeight;

	private NSVScrollBar VS;

	private int[] ColumnOffsets;

	private Pen P1;

	private Pen P2;

	private Pen P3;

	private SolidBrush B1;

	private SolidBrush B2;

	private SolidBrush B3;

	private SolidBrush B4;

	private LinearGradientBrush GB1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public NSListViewItem[] Items
	{
		get
		{
			return _Items.ToArray();
		}
		set
		{
			_Items = new List<NSListViewItem>(value);
			InvalidateScroll();
		}
	}

	public NSListViewItem[] SelectedItems => _SelectedItems.ToArray();

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public NSListViewColumnHeader[] Columns
	{
		get
		{
			return _Columns.ToArray();
		}
		set
		{
			_Columns = new List<NSListViewColumnHeader>(value);
			InvalidateColumns();
		}
	}

	public bool MultiSelect
	{
		get
		{
			return _MultiSelect;
		}
		set
		{
			_MultiSelect = value;
			if (_SelectedItems.Count > 1)
			{
				_SelectedItems.RemoveRange(1, checked(_SelectedItems.Count - 1));
			}
			((Control)this).Invalidate();
		}
	}

	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			ItemHeight = checked((int)Math.Round(Graphics.FromHwnd(((Control)this).get_Handle()).MeasureString("@", Font).Height) + 6);
			if (VS != null)
			{
				VS.SmallChange = ItemHeight;
				VS.LargeChange = ItemHeight;
			}
			((Control)this).set_Font(value);
			InvalidateLayout();
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	public void AddItem(string text, params string[] subItems)
	{
		List<NSListViewSubItem> list = new List<NSListViewSubItem>();
		foreach (string text2 in subItems)
		{
			NSListViewSubItem nSListViewSubItem = new NSListViewSubItem();
			nSListViewSubItem.Text = text2;
			list.Add(nSListViewSubItem);
		}
		NSListViewItem nSListViewItem = new NSListViewItem();
		nSListViewItem.Text = text;
		nSListViewItem.SubItems = list;
		_Items.Add(nSListViewItem);
		InvalidateScroll();
	}

	public void RemoveItemAt(int index)
	{
		_Items.RemoveAt(index);
		InvalidateScroll();
	}

	public void RemoveItem(NSListViewItem item)
	{
		_Items.Remove(item);
		InvalidateScroll();
	}

	public void RemoveItems(NSListViewItem[] items)
	{
		foreach (NSListViewItem item in items)
		{
			_Items.Remove(item);
		}
		InvalidateScroll();
	}

	public NSListView()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		__ENCAddToList(this);
		_Items = new List<NSListViewItem>();
		_SelectedItems = new List<NSListViewItem>();
		_Columns = new List<NSListViewColumnHeader>();
		_MultiSelect = true;
		ItemHeight = 24;
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, true);
		P1 = new Pen(Color.FromArgb(55, 55, 55));
		P2 = new Pen(Color.FromArgb(35, 35, 35));
		P3 = new Pen(Color.FromArgb(65, 65, 65));
		B1 = new SolidBrush(Color.FromArgb(62, 62, 62));
		B2 = new SolidBrush(Color.FromArgb(65, 65, 65));
		B3 = new SolidBrush(Color.FromArgb(47, 47, 47));
		B4 = new SolidBrush(Color.FromArgb(50, 50, 50));
		VS = new NSVScrollBar();
		VS.SmallChange = ItemHeight;
		VS.LargeChange = ItemHeight;
		VS.Scroll += HandleScroll;
		((Control)VS).add_MouseDown(new MouseEventHandler(VS_MouseDown));
		((Control)this).get_Controls().Add((Control)(object)VS);
		InvalidateLayout();
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		InvalidateLayout();
		((Control)this).OnSizeChanged(e);
	}

	private void HandleScroll(object sender)
	{
		((Control)this).Invalidate();
	}

	private void InvalidateScroll()
	{
		VS.Maximum = checked(_Items.Count * ItemHeight);
		((Control)this).Invalidate();
	}

	private void InvalidateLayout()
	{
		NSVScrollBar vS = VS;
		checked
		{
			Point location = new Point(((Control)this).get_Width() - ((Control)VS).get_Width() - 1, 1);
			((Control)vS).set_Location(location);
			NSVScrollBar vS2 = VS;
			Size size = new Size(18, ((Control)this).get_Height() - 2);
			((Control)vS2).set_Size(size);
			((Control)this).Invalidate();
		}
	}

	private void InvalidateColumns()
	{
		int num = 3;
		checked
		{
			ColumnOffsets = new int[_Columns.Count - 1 + 1];
			int num2 = _Columns.Count - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				ColumnOffsets[num3] = num;
				num += Columns[num3].Width;
				num3++;
			}
			((Control)this).Invalidate();
		}
	}

	private void VS_MouseDown(object sender, MouseEventArgs e)
	{
		((Control)this).Focus();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		((Control)this).Focus();
		if ((int)e.get_Button() == 1048576)
		{
			int num = checked((int)Math.Round(VS.Percent * (double)(VS.Maximum - (((Control)this).get_Height() - ItemHeight * 2))));
			int num2 = checked(e.get_Y() + num - ItemHeight) / ItemHeight;
			if (num2 > checked(_Items.Count - 1))
			{
				num2 = -1;
			}
			if (num2 != -1)
			{
				if (((int)Control.get_ModifierKeys() == 131072 && _MultiSelect) ? true : false)
				{
					if (_SelectedItems.Contains(_Items[num2]))
					{
						_SelectedItems.Remove(_Items[num2]);
					}
					else
					{
						_SelectedItems.Add(_Items[num2]);
					}
				}
				else
				{
					_SelectedItems.Clear();
					_SelectedItems.Add(_Items[num2]);
				}
			}
			((Control)this).Invalidate();
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		checked
		{
			ThemeModule.G.DrawRectangle(P1, 1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			int num = (int)Math.Round(VS.Percent * (double)(VS.Maximum - (((Control)this).get_Height() - ItemHeight * 2)));
			int num2 = ((num != 0) ? unchecked(num / ItemHeight) : 0);
			int num3 = Math.Min(num2 + unchecked(((Control)this).get_Height() / ItemHeight), _Items.Count - 1);
			int num4 = num3;
			int num5 = num2;
			Rectangle rectangle;
			while (true)
			{
				int num6 = num5;
				int num7 = num4;
				if (num6 > num7)
				{
					break;
				}
				NSListViewItem nSListViewItem = Items[num5];
				rectangle = new Rectangle(0, ItemHeight + num5 * ItemHeight + 1 - num, ((Control)this).get_Width(), ItemHeight - 1);
				float height = ThemeModule.G.MeasureString(nSListViewItem.Text, Font).Height;
				int num8 = rectangle.Y + (int)Math.Round((double)ItemHeight / 2.0 - (double)(height / 2f));
				unchecked
				{
					if (_SelectedItems.Contains(nSListViewItem))
					{
						if (num5 % 2 == 0)
						{
							ThemeModule.G.FillRectangle((Brush)(object)B1, rectangle);
						}
						else
						{
							ThemeModule.G.FillRectangle((Brush)(object)B2, rectangle);
						}
					}
					else if (num5 % 2 == 0)
					{
						ThemeModule.G.FillRectangle((Brush)(object)B3, rectangle);
					}
					else
					{
						ThemeModule.G.FillRectangle((Brush)(object)B4, rectangle);
					}
					ThemeModule.G.DrawLine(P2, 0, rectangle.Bottom, ((Control)this).get_Width(), rectangle.Bottom);
					if (Columns.Length > 0)
					{
						rectangle.Width = Columns[0].Width;
						ThemeModule.G.SetClip(rectangle);
					}
				}
				ThemeModule.G.DrawString(nSListViewItem.Text, Font, Brushes.get_Black(), 10f, (float)(num8 + 1));
				ThemeModule.G.DrawString(nSListViewItem.Text, Font, Brushes.get_White(), 9f, (float)num8);
				if (nSListViewItem.SubItems != null)
				{
					int num9 = Math.Min(nSListViewItem.SubItems.Count, _Columns.Count) - 1;
					int num10 = 0;
					while (true)
					{
						int num11 = num10;
						num7 = num9;
						if (num11 > num7)
						{
							break;
						}
						int num13 = (rectangle.X = ColumnOffsets[num10 + 1] + 4);
						rectangle.Width = Columns[num10].Width;
						ThemeModule.G.SetClip(rectangle);
						ThemeModule.G.DrawString(nSListViewItem.SubItems[num10].Text, Font, Brushes.get_Black(), (float)(num13 + 1), (float)(num8 + 1));
						ThemeModule.G.DrawString(nSListViewItem.SubItems[num10].Text, Font, Brushes.get_White(), (float)num13, (float)num8);
						num10++;
					}
				}
				ThemeModule.G.ResetClip();
				num5++;
			}
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ItemHeight);
			GB1 = new LinearGradientBrush(rectangle, Color.FromArgb(60, 60, 60), Color.FromArgb(55, 55, 55), 90f);
			ThemeModule.G.FillRectangle((Brush)(object)GB1, rectangle);
			ThemeModule.G.DrawRectangle(P3, 1, 1, ((Control)this).get_Width() - 22, ItemHeight - 2);
			int num14 = Math.Min(VS.Maximum + ItemHeight - num, ((Control)this).get_Height());
			int num15 = _Columns.Count - 1;
			int num16 = 0;
			while (true)
			{
				int num17 = num16;
				int num7 = num15;
				if (num17 > num7)
				{
					break;
				}
				NSListViewColumnHeader nSListViewColumnHeader = Columns[num16];
				float height = ThemeModule.G.MeasureString(nSListViewColumnHeader.Text, Font).Height;
				int num8 = (int)Math.Round((double)ItemHeight / 2.0 - (double)(height / 2f));
				int num13 = ColumnOffsets[num16];
				ThemeModule.G.DrawString(nSListViewColumnHeader.Text, Font, Brushes.get_Black(), (float)(num13 + 1), (float)(num8 + 1));
				ThemeModule.G.DrawString(nSListViewColumnHeader.Text, Font, Brushes.get_White(), (float)num13, (float)num8);
				ThemeModule.G.DrawLine(P2, num13 - 3, 0, num13 - 3, num14);
				ThemeModule.G.DrawLine(P3, num13 - 2, 0, num13 - 2, ItemHeight);
				num16++;
			}
			ThemeModule.G.DrawRectangle(P2, 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			ThemeModule.G.DrawLine(P2, 0, ItemHeight, ((Control)this).get_Width(), ItemHeight);
			ThemeModule.G.DrawLine(P2, ((Control)VS).get_Location().X - 1, 0, ((Control)VS).get_Location().X - 1, ((Control)this).get_Height());
		}
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		checked
		{
			int num = -(unchecked(checked(e.get_Delta() * SystemInformation.get_MouseWheelScrollLines()) / 120) * unchecked(ItemHeight / 2));
			int value = Math.Max(Math.Min(VS.Value + num, VS.Maximum), VS.Minimum);
			VS.Value = value;
			((Control)this).OnMouseWheel(e);
		}
	}
}
