using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Main;

public class FormEncryptedFiles : Form
{
	private IContainer components;

	private DataGridView dataGridViewEncryptedFiles;

	private DataGridViewTextBoxColumn ColumnDeleted;

	private DataGridViewTextBoxColumn ColumnPath;

	public FormEncryptedFiles()
	{
		//Discarded unreachable code: IL_0001, IL_0006, IL_000c, IL_0011
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xF9*/;
	}

	private extern void FormEncryptedFiles_Load(object sender, EventArgs e);

	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_000c
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_000b: Expected O, but got I4
		_003F val;
		do
		{
			val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ < val);
		_003F val2 = /*Error near IL_0006: ldloc 0 (out-of-bounds)*/;
		((object[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (object)val2;
		_ = ((Array)disposing).LongLength;
		/*Error near IL_000b: Unknown opcode: 0xF9*/;
	}

	private extern void InitializeComponent();
}
