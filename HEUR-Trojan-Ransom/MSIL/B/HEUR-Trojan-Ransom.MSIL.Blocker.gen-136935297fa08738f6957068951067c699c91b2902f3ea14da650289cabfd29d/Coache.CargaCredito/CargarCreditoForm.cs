using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.CargaCredito;

[PermissionRequired(new Functionalities[] { Functionalities.CargarCredito })]
public class CargarCreditoForm : Form
{
	private PagosManager _manager = new PagosManager();

	private IContainer components;

	private DataGridView dataGridView;

	private Button btnAgregar;

	private Panel panel1;

	private DataGridViewTextBoxColumn ID;

	private DataGridViewTextBoxColumn Fecha;

	private DataGridViewTextBoxColumn Credito;

	private DataGridViewTextBoxColumn TipoPago;

	private DataGridViewTextBoxColumn Banco;

	private DataGridViewTextBoxColumn Tarjeta;

	private Label lblResults;

	private Label label5;

	public CargarCreditoForm()
	{
		InitializeComponent();
	}

	private void CargarCreditoForm_Load(object sender, EventArgs e)
	{
		BindingList<Pago> all = _manager.GetAll(Session.User);
		dataGridView.add_DataSourceChanged((EventHandler)dataGridView_DataSourceChanged);
		dataGridView.set_DataSource((object)all);
		((Control)dataGridView).Refresh();
	}

	private void dataGridView_DataSourceChanged(object sender, EventArgs e)
	{
		IList list = dataGridView.get_DataSource() as IList;
		((Control)lblResults).set_Text(list.Count.ToString());
	}

	private void btnAgregar_Click(object sender, EventArgs e)
	{
		NuevoPago nuevoPago = new NuevoPago();
		nuevoPago.OnPagoAdded += frm_OnPagoAdded;
		ViewsManager.LoadModal((Form)(object)nuevoPago);
	}

	private void frm_OnPagoAdded(object sender, PagoAddedEventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		_manager.Add(e.Pago, Session.User);
		((BindingList<Pago>)dataGridView.get_DataSource()).Add(e.Pago);
		((Control)dataGridView).Refresh();
		MessageBox.Show("El pago ha sido acreditado");
		((Form)(NuevoPago)sender).Close();
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		dataGridView = new DataGridView();
		ID = new DataGridViewTextBoxColumn();
		Fecha = new DataGridViewTextBoxColumn();
		Credito = new DataGridViewTextBoxColumn();
		TipoPago = new DataGridViewTextBoxColumn();
		Banco = new DataGridViewTextBoxColumn();
		Tarjeta = new DataGridViewTextBoxColumn();
		btnAgregar = new Button();
		panel1 = new Panel();
		lblResults = new Label();
		label5 = new Label();
		((ISupportInitialize)dataGridView).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		dataGridView.set_AllowUserToAddRows(false);
		dataGridView.set_AllowUserToDeleteRows(false);
		dataGridView.set_AllowUserToOrderColumns(true);
		dataGridView.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)ID,
			(DataGridViewColumn)Fecha,
			(DataGridViewColumn)Credito,
			(DataGridViewColumn)TipoPago,
			(DataGridViewColumn)Banco,
			(DataGridViewColumn)Tarjeta
		});
		((Control)dataGridView).set_Dock((DockStyle)5);
		((Control)dataGridView).set_Location(new Point(0, 39));
		dataGridView.set_MultiSelect(false);
		((Control)dataGridView).set_Name("dataGridView");
		dataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dataGridView).set_Size(new Size(878, 362));
		((Control)dataGridView).set_TabIndex(2);
		((DataGridViewColumn)ID).set_DataPropertyName("ID");
		((DataGridViewColumn)ID).set_FillWeight(20.30457f);
		((DataGridViewColumn)ID).set_HeaderText("ID");
		((DataGridViewColumn)ID).set_Name("ID");
		((DataGridViewBand)ID).set_ReadOnly(true);
		((DataGridViewColumn)Fecha).set_DataPropertyName("Fecha");
		((DataGridViewColumn)Fecha).set_FillWeight(179.6954f);
		((DataGridViewColumn)Fecha).set_HeaderText("Fecha");
		((DataGridViewColumn)Fecha).set_Name("Fecha");
		((DataGridViewBand)Fecha).set_ReadOnly(true);
		((DataGridViewColumn)Credito).set_DataPropertyName("Credito");
		((DataGridViewColumn)Credito).set_HeaderText("Crédito");
		((DataGridViewColumn)Credito).set_Name("Credito");
		((DataGridViewBand)Credito).set_ReadOnly(true);
		((DataGridViewColumn)TipoPago).set_DataPropertyName("TipoPago");
		((DataGridViewColumn)TipoPago).set_HeaderText("Tipo de Pago");
		((DataGridViewColumn)TipoPago).set_Name("TipoPago");
		((DataGridViewBand)TipoPago).set_ReadOnly(true);
		((DataGridViewColumn)Banco).set_DataPropertyName("Banco");
		((DataGridViewColumn)Banco).set_HeaderText("Banco");
		((DataGridViewColumn)Banco).set_Name("Banco");
		((DataGridViewBand)Banco).set_ReadOnly(true);
		((DataGridViewColumn)Tarjeta).set_DataPropertyName("Tarjeta");
		((DataGridViewColumn)Tarjeta).set_HeaderText("Tarjeta");
		((DataGridViewColumn)Tarjeta).set_Name("Tarjeta");
		((DataGridViewBand)Tarjeta).set_ReadOnly(true);
		((Control)btnAgregar).set_Location(new Point(12, 10));
		((Control)btnAgregar).set_Name("btnAgregar");
		((Control)btnAgregar).set_Size(new Size(75, 23));
		((Control)btnAgregar).set_TabIndex(0);
		((Control)btnAgregar).set_Text("Nuevo Pago");
		((ButtonBase)btnAgregar).set_UseVisualStyleBackColor(true);
		((Control)btnAgregar).add_Click((EventHandler)btnAgregar_Click);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)lblResults);
		((Control)panel1).get_Controls().Add((Control)(object)btnAgregar);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(878, 39));
		((Control)panel1).set_TabIndex(3);
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(781, 20));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(15);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(801, 20));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(14);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(878, 401));
		((Control)this).get_Controls().Add((Control)(object)dataGridView);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("CargarCreditoForm");
		((Control)this).set_Text("Cargar Crédito");
		((Form)this).add_Load((EventHandler)CargarCreditoForm_Load);
		((ISupportInitialize)dataGridView).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
