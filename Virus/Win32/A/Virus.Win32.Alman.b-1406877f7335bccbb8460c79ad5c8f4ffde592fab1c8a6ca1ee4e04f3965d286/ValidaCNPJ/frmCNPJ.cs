using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ValidaCNPJ;

public class frmCNPJ : Form
{
	private IContainer components;

	private TextBox txtCNPJ;

	private Label lblValida;

	private Button btnValida;

	protected override extern void Dispose(bool disposing);

	private extern void InitializeComponent();

	public extern frmCNPJ();

	private extern void btnValida_Click(object sender, EventArgs e);
}
