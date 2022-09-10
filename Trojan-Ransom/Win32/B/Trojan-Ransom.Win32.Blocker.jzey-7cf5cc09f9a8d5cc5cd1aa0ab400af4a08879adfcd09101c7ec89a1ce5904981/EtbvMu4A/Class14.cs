using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace EtbvMu4A;

internal class Class14
{
	internal static SplitterPanel tRXZ9LGF(SplitContainer splitContainer_0, int int_0)
	{
		return (SplitterPanel)((int_0 ^ 0x4BB) switch
		{
			1 => splitContainer_0.get_Panel2(), 
			_ => splitContainer_0.get_Panel1(), 
		});
	}

	internal static void CyZ0W8Qm(ImageList imageList_0, Color color_0, int int_0)
	{
		switch (int_0 ^ 0xAA96)
		{
		}
		imageList_0.set_TransparentColor(color_0);
	}

	internal static object zHaJUXiM(ResourceManager resourceManager_0, string string_0, int int_0)
	{
		return (int_0 ^ 0xFA7F) switch
		{
			_ => resourceManager_0.GetObject(string_0), 
		};
	}

	internal static void smethod_0(ToolStripItem toolStripItem_0, Image image_0, int int_0)
	{
		switch (int_0 ^ 0x3C7B)
		{
		}
		toolStripItem_0.set_Image(image_0);
	}

	internal static ToolStripItemCollection kTpoegMv(ToolStripDropDownItem toolStripDropDownItem_0, int int_0)
	{
		return (ToolStripItemCollection)((int_0 ^ 0xA03D) switch
		{
			_ => toolStripDropDownItem_0.get_DropDownItems(), 
		});
	}

	internal static void VHvX5O9W(ToolStripItemCollection toolStripItemCollection_0, ToolStripItem[] toolStripItem_0, int int_0)
	{
		switch (int_0 ^ 0xD7B0)
		{
		}
		toolStripItemCollection_0.AddRange(toolStripItem_0);
	}

	internal static void smethod_1(DataGridView dataGridView_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x211C)
		{
		default:
			dataGridView_0.set_AllowUserToAddRows(bool_0);
			break;
		case 1:
			dataGridView_0.set_MultiSelect(bool_0);
			break;
		}
	}

	internal static void zaRSd6dB(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0xFB1)
		{
		}
		dataGridView_0.set_ColumnHeadersHeightSizeMode(dataGridViewColumnHeadersHeightSizeMode_0);
	}

	internal static ToolStripItemCollection smethod_2(ToolStrip toolStrip_0, int int_0)
	{
		return (ToolStripItemCollection)((int_0 ^ 0x9E3A) switch
		{
			_ => toolStrip_0.get_Items(), 
		});
	}

	internal static void UENcrkGk(FileDialog fileDialog_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xE77A)
		{
		default:
			fileDialog_0.set_Title(string_0);
			break;
		case 1:
			fileDialog_0.set_Filter(string_0);
			break;
		case 2:
			fileDialog_0.set_DefaultExt(string_0);
			break;
		case 3:
			fileDialog_0.set_FileName(string_0);
			break;
		}
	}

	internal static void smethod_3(ImageList imageList_0, ImageListStreamer imageListStreamer_0, int int_0)
	{
		switch (int_0 ^ 0xB934)
		{
		}
		imageList_0.set_ImageStream(imageListStreamer_0);
	}

	internal static void PTP4pThP(ToolStripItem toolStripItem_0, ToolStripItemDisplayStyle toolStripItemDisplayStyle_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0xD8)
		{
		}
		toolStripItem_0.set_DisplayStyle(toolStripItemDisplayStyle_0);
	}

	internal static void tTTm86dG(DataGridViewColumn dataGridViewColumn_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x8031)
		{
		}
		dataGridViewColumn_0.set_Width(int_0);
	}

	internal static void SD87ZQ4e(StatusBarPanel statusBarPanel_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xEB9E)
		{
		default:
			statusBarPanel_0.set_Text(string_0);
			break;
		case 1:
			statusBarPanel_0.set_Name(string_0);
			break;
		}
	}

	internal static void txKCDNxD(Form form_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xD99A)
		{
		}
		form_0.set_AutoScroll(bool_0);
	}

	internal static void e8dPC3T1(SplitContainer splitContainer_0, DockStyle dockStyle_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0xD20A)
		{
		}
		splitContainer_0.set_Dock(dockStyle_0);
	}

	internal static void nYJxrkc1(SplitContainer splitContainer_0, Orientation orientation_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0x829F)
		{
		}
		splitContainer_0.set_Orientation(orientation_0);
	}

	internal static void nLxrimxY(DataGridViewColumnCollection dataGridViewColumnCollection_0, DataGridViewColumn[] dataGridViewColumn_0, int int_0)
	{
		switch (int_0 ^ 0x5B8E)
		{
		}
		dataGridViewColumnCollection_0.AddRange(dataGridViewColumn_0);
	}

	internal static void OAAR8FbG(SplitContainer splitContainer_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0xDA73)
		{
		}
		splitContainer_0.set_SplitterDistance(int_0);
	}

	internal static void mf8ZTo4P(ToolStripItem toolStripItem_0, EventHandler eventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xB153)
		{
		default:
			toolStripItem_0.remove_Click(eventHandler_0);
			break;
		case 1:
			toolStripItem_0.add_Click(eventHandler_0);
			break;
		}
	}
}
