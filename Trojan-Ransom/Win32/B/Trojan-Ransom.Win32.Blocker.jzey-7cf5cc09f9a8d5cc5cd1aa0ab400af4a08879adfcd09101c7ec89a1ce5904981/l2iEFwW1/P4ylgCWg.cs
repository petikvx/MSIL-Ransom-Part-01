using System.IO;
using System.Windows.Forms;

namespace l2iEFwW1;

internal class P4ylgCWg
{
	internal static bool smethod_0(string string_0, int int_0)
	{
		return (int_0 ^ 0x843D) switch
		{
			_ => File.Exists(string_0), 
		};
	}

	internal static DataGridViewRowCollection u2dqNayc(DataGridView dataGridView_0, int int_0)
	{
		return (DataGridViewRowCollection)((int_0 ^ 0xC512) switch
		{
			_ => dataGridView_0.get_Rows(), 
		});
	}

	internal static DataGridViewRow e7DGAcD8(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0, int int_1)
	{
		return (DataGridViewRow)((int_1 ^ 0x2A54) switch
		{
			_ => dataGridViewRowCollection_0.get_Item(int_0), 
		});
	}

	internal static DataGridViewCellCollection PJdX2FWt(DataGridViewRow dataGridViewRow_0, int int_0)
	{
		return (DataGridViewCellCollection)((int_0 ^ 0xE896) switch
		{
			_ => dataGridViewRow_0.get_Cells(), 
		});
	}

	internal static DataGridViewCell smethod_1(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0, int int_1)
	{
		return (DataGridViewCell)((int_1 ^ 0xEBB1) switch
		{
			_ => dataGridViewCellCollection_0.get_Item(int_0), 
		});
	}

	internal static void PSxjHVmY(DataGridViewCell dataGridViewCell_0, object object_0, int int_0)
	{
		switch (int_0 ^ 0xE027)
		{
		}
		dataGridViewCell_0.set_Value(object_0);
	}

	internal static DataGridViewColumnCollection smethod_2(DataGridView dataGridView_0, int int_0)
	{
		return (DataGridViewColumnCollection)((int_0 ^ 0xBD2C) switch
		{
			_ => dataGridView_0.get_Columns(), 
		});
	}

	internal static DataGridViewColumn smethod_3(DataGridViewColumnCollection dataGridViewColumnCollection_0, int int_0, int int_1)
	{
		return (DataGridViewColumn)((int_1 ^ 0xF7F5) switch
		{
			_ => dataGridViewColumnCollection_0.get_Item(int_0), 
		});
	}

	internal static void smethod_4(DataGridViewColumn dataGridViewColumn_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x62EF)
		{
		}
		dataGridViewColumn_0.set_ReadOnly(bool_0);
	}

	internal static int CVRHEjrU(DataGridViewColumnCollection dataGridViewColumnCollection_0, string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0xA987) switch
		{
			_ => dataGridViewColumnCollection_0.Add(string_0, string_1), 
		};
	}

	internal static void nfVtfiey(DataGridViewColumnCollection dataGridViewColumnCollection_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x2760)
		{
		}
		dataGridViewColumnCollection_0.RemoveAt(int_0);
	}

	internal static DialogResult PHc303fO(Form form_0, IWin32Window iwin32Window_0, int int_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)((int_0 ^ 0x9F46) switch
		{
			_ => form_0.ShowDialog(iwin32Window_0), 
		});
	}

	internal static DataGridViewSelectedCellCollection sHdXwxpO(DataGridView dataGridView_0, int int_0)
	{
		return (DataGridViewSelectedCellCollection)((int_0 ^ 0x5BFB) switch
		{
			_ => dataGridView_0.get_SelectedCells(), 
		});
	}

	internal static int Hf0jDrfN(BaseCollection baseCollection_0, int int_0)
	{
		return (int_0 ^ 0xDEF4) switch
		{
			_ => baseCollection_0.get_Count(), 
		};
	}

	internal static DataGridViewCell P83d5WAN(DataGridViewSelectedCellCollection dataGridViewSelectedCellCollection_0, int int_0, int int_1)
	{
		return (DataGridViewCell)((int_1 ^ 0xFAEA) switch
		{
			_ => dataGridViewSelectedCellCollection_0.get_Item(int_0), 
		});
	}

	internal static int vQ0Q1Oay(DataGridViewCell dataGridViewCell_0, int int_0)
	{
		return (int_0 ^ 0x7DB4) switch
		{
			1 => dataGridViewCell_0.get_ColumnIndex(), 
			_ => dataGridViewCell_0.get_RowIndex(), 
		};
	}

	internal static DialogResult G2fW6tnP(Form form_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)((int_0 ^ 0x2072) switch
		{
			_ => form_0.ShowDialog(), 
		});
	}

	internal static DataGridViewSelectedRowCollection P7MZiVUn(DataGridView dataGridView_0, int int_0)
	{
		return (DataGridViewSelectedRowCollection)((int_0 ^ 0xC5EF) switch
		{
			_ => dataGridView_0.get_SelectedRows(), 
		});
	}

	internal static DataGridViewRow spdSZ2Jw(DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection_0, int int_0, int int_1)
	{
		return (DataGridViewRow)((int_1 ^ 0xA385) switch
		{
			_ => dataGridViewSelectedRowCollection_0.get_Item(int_0), 
		});
	}

	internal static object smethod_5(DataGridViewCell dataGridViewCell_0, int int_0)
	{
		return (int_0 ^ 0x729E) switch
		{
			_ => dataGridViewCell_0.get_Value(), 
		};
	}
}
