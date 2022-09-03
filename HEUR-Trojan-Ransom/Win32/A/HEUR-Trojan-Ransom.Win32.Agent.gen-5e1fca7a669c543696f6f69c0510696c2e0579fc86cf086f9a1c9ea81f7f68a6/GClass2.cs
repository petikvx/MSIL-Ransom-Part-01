using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;

public sealed class GClass2 : UITypeEditor
{
	internal sealed class Class5
	{
		private string string_0;

		private int int_0;

		private string string_1;

		public Class5(string string_2, int int_1, string string_3)
		{
			string_0 = string_2;
			int_0 = int_1;
			string_1 = string_3;
		}

		public int method_0()
		{
			return int_0;
		}

		public string method_1()
		{
			return string_1;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	private CheckedListBox checkedListBox_0;

	private ToolTip toolTip_0;

	private bool bool_0;

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		if (context != null && context.Instance != null && provider != null)
		{
			iwindowsFormsEditorService_0 = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (iwindowsFormsEditorService_0 != null)
			{
				checkedListBox_0 = new CheckedListBox();
				((ListBox)checkedListBox_0).set_BorderStyle((BorderStyle)1);
				checkedListBox_0.set_CheckOnClick(true);
				((Control)checkedListBox_0).add_MouseDown(new MouseEventHandler(checkedListBox_0_MouseDown));
				((Control)checkedListBox_0).add_MouseMove(new MouseEventHandler(checkedListBox_0_MouseMove));
				toolTip_0 = new ToolTip();
				toolTip_0.set_ShowAlways(true);
				string[] names = Enum.GetNames(context.PropertyDescriptor.PropertyType);
				foreach (string text in names)
				{
					object obj = Enum.Parse(context.PropertyDescriptor.PropertyType, text);
					int num = (int)Convert.ChangeType(obj, typeof(int));
					FieldInfo field = context.PropertyDescriptor.PropertyType.GetField(text);
					DescriptionAttribute[] array = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
					string string_ = ((array.Length > 0) ? array[0].Description : string.Empty);
					int num2 = (int)Convert.ChangeType(value, typeof(int));
					Class5 @class = new Class5(obj.ToString(), num, string_);
					bool flag = (num2 & num) == num;
					checkedListBox_0.get_Items().Add((object)@class, flag);
				}
				iwindowsFormsEditorService_0.DropDownControl((Control)(object)checkedListBox_0);
				int num3 = 0;
				foreach (Class5 checkedItem in checkedListBox_0.get_CheckedItems())
				{
					num3 |= checkedItem.method_0();
				}
				return Enum.ToObject(context.PropertyDescriptor.PropertyType, num3);
			}
		}
		return value;
	}

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		return (UITypeEditorEditStyle)3;
	}

	private void checkedListBox_0_MouseDown(object sender, MouseEventArgs e)
	{
		if (!bool_0 && ((Control)checkedListBox_0).get_ClientRectangle().Contains(((Control)checkedListBox_0).PointToClient(new Point(e.get_X(), e.get_Y()))))
		{
			((Control)checkedListBox_0).add_LostFocus((EventHandler)checkedListBox_0_LostFocus);
			bool_0 = true;
		}
	}

	private void checkedListBox_0_MouseMove(object sender, MouseEventArgs e)
	{
		int num = ((ListBox)checkedListBox_0).IndexFromPoint(e.get_X(), e.get_Y());
		if (num >= 0)
		{
			toolTip_0.SetToolTip((Control)(object)checkedListBox_0, ((Class5)((ObjectCollection)checkedListBox_0.get_Items()).get_Item(num)).method_1());
		}
	}

	private void checkedListBox_0_LostFocus(object sender, EventArgs e)
	{
		if (iwindowsFormsEditorService_0 != null)
		{
			iwindowsFormsEditorService_0.CloseDropDown();
		}
	}
}
