using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Coache.AbmProveedor;
using Coache.Business;
using Coache.Common;
using Coache.Core;
using Coache.Login;

namespace Coache.FacturarProveedor;

[PermissionRequired(new Functionalities[] { Functionalities.Facturar })]
public class FacturaProveedorForm : Form
{
	private Proveedor _proveedor;

	private ProveedoresForm _proveedoresForm;

	private IContainer components;

	private GroupBox groupBox;

	private DateTimePicker dtpHasta;

	private DateTimePicker dtpDesde;

	private Label label4;

	private Label label3;

	private Button btnFiltrar;

	private DataGridView dataGridView;

	private Button btnGenerarFactura;

	private Panel searchPanel;

	private Panel panel1;

	private Button btnBuscarProveedor;

	private TextBox txtProveedor;

	private Label label1;

	private DataGridViewTextBoxColumn Fecha;

	private DataGridViewTextBoxColumn Descripcion;

	private DataGridViewTextBoxColumn Codigo;

	private DataGridViewTextBoxColumn Precio;

	private Label lblResults;

	private Label label5;

	public FacturaProveedorForm()
	{
		InitializeComponent();
		dataGridView.set_AutoGenerateColumns(false);
		dtpDesde.set_Value(DateTime.Now.Subtract(TimeSpan.FromDays(180.0)));
		dtpHasta.set_Value(DateTime.Now);
	}

	private void btnBuscarProveedor_Click(object sender, EventArgs e)
	{
		if (_proveedoresForm == null)
		{
			_proveedoresForm = new ProveedoresForm();
			_proveedoresForm.SetSearchMode();
			_proveedoresForm.OnUserSelected += _proveedoresForm_OnUserSelected;
		}
		ViewsManager.LoadModal((Form)(object)_proveedoresForm);
	}

	private void _proveedoresForm_OnUserSelected(object sender, UserSelectedEventArgs e)
	{
		_proveedor = e.User as Proveedor;
		((Control)_proveedoresForm).Hide();
		((Control)txtProveedor).set_Text(_proveedor.UserName);
	}

	private void btnFiltrar_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (_proveedor == null)
		{
			MessageBox.Show("Debe seleccionar un proveedor para poder ver los consumos");
			return;
		}
		if (dtpDesde.get_Value() > dtpHasta.get_Value())
		{
			MessageBox.Show("La fecha desde debe ser menor o igual que la fecha hasta");
			return;
		}
		CompraCuponManager compraCuponManager = new CompraCuponManager();
		dataGridView.set_DataSource((object)compraCuponManager.GetParaFacturar(_proveedor, dtpDesde.get_Value(), dtpHasta.get_Value()));
		((Control)dataGridView).Refresh();
	}

	private void btnGenerarFactura_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		if (_proveedor == null)
		{
			MessageBox.Show("Debe seleccionar un proveedor para poder generar una factura");
			return;
		}
		if (dtpDesde.get_Value() > dtpHasta.get_Value())
		{
			MessageBox.Show("La fecha desde debe ser menor o igual que la fecha hasta");
			return;
		}
		BindingList<CompraCupon> bindingList = (BindingList<CompraCupon>)dataGridView.get_DataSource();
		if (bindingList != null && bindingList.Count != 0)
		{
			double num = bindingList.Sum((CompraCupon x) => x.Precio);
			if ((int)MessageBox.Show($"Confirma emitir la factura para el proveedor '{_proveedor.UserName}' por ${num}?") == 1)
			{
				int num2 = new FacturaManager().GenerarFactura(_proveedor, bindingList, DateTime.Now);
				MessageBox.Show(string.Format("Se ha generado la factura Nro. {1} para el proveedor '{0}' por ${2}", _proveedor.UserName, num2, num));
				dataGridView.set_DataSource((object)null);
				((Control)dataGridView).Refresh();
			}
		}
		else
		{
			MessageBox.Show("No hay cupones consumidos para poder generar una factura");
		}
	}

	private void FacturaProveedorForm_Load(object sender, EventArgs e)
	{
		dataGridView.add_DataSourceChanged((EventHandler)dataGridView_DataSourceChanged);
	}

	private void dataGridView_DataSourceChanged(object sender, EventArgs e)
	{
		IList list = dataGridView.get_DataSource() as IList;
		((Control)lblResults).set_Text(list.Count.ToString());
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected O, but got Unknown
		groupBox = new GroupBox();
		btnBuscarProveedor = new Button();
		btnFiltrar = new Button();
		txtProveedor = new TextBox();
		label1 = new Label();
		dtpHasta = new DateTimePicker();
		dtpDesde = new DateTimePicker();
		label4 = new Label();
		label3 = new Label();
		dataGridView = new DataGridView();
		Fecha = new DataGridViewTextBoxColumn();
		Descripcion = new DataGridViewTextBoxColumn();
		Codigo = new DataGridViewTextBoxColumn();
		Precio = new DataGridViewTextBoxColumn();
		btnGenerarFactura = new Button();
		searchPanel = new Panel();
		panel1 = new Panel();
		lblResults = new Label();
		label5 = new Label();
		((Control)groupBox).SuspendLayout();
		((ISupportInitialize)dataGridView).BeginInit();
		((Control)searchPanel).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox).set_Anchor((AnchorStyles)13);
		((Control)groupBox).get_Controls().Add((Control)(object)btnBuscarProveedor);
		((Control)groupBox).get_Controls().Add((Control)(object)btnFiltrar);
		((Control)groupBox).get_Controls().Add((Control)(object)txtProveedor);
		((Control)groupBox).get_Controls().Add((Control)(object)label1);
		((Control)groupBox).get_Controls().Add((Control)(object)dtpHasta);
		((Control)groupBox).get_Controls().Add((Control)(object)dtpDesde);
		((Control)groupBox).get_Controls().Add((Control)(object)label4);
		((Control)groupBox).get_Controls().Add((Control)(object)label3);
		((Control)groupBox).set_Location(new Point(12, 6));
		((Control)groupBox).set_Name("groupBox");
		((Control)groupBox).set_Size(new Size(939, 103));
		((Control)groupBox).set_TabIndex(2);
		groupBox.set_TabStop(false);
		((Control)groupBox).set_Text("Filtro");
		((Control)btnBuscarProveedor).set_Location(new Point(200, 18));
		((Control)btnBuscarProveedor).set_Name("btnBuscarProveedor");
		((Control)btnBuscarProveedor).set_Size(new Size(75, 23));
		((Control)btnBuscarProveedor).set_TabIndex(12);
		((Control)btnBuscarProveedor).set_Text("Buscar");
		((ButtonBase)btnBuscarProveedor).set_UseVisualStyleBackColor(true);
		((Control)btnBuscarProveedor).add_Click((EventHandler)btnBuscarProveedor_Click);
		((Control)btnFiltrar).set_Location(new Point(200, 68));
		((Control)btnFiltrar).set_Name("btnFiltrar");
		((Control)btnFiltrar).set_Size(new Size(75, 23));
		((Control)btnFiltrar).set_TabIndex(0);
		((Control)btnFiltrar).set_Text("Filtrar");
		((ButtonBase)btnFiltrar).set_UseVisualStyleBackColor(true);
		((Control)btnFiltrar).add_Click((EventHandler)btnFiltrar_Click);
		((Control)txtProveedor).set_Location(new Point(93, 19));
		((Control)txtProveedor).set_Name("txtProveedor");
		((TextBoxBase)txtProveedor).set_ReadOnly(true);
		((Control)txtProveedor).set_Size(new Size(100, 20));
		((Control)txtProveedor).set_TabIndex(11);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(31, 22));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(56, 13));
		((Control)label1).set_TabIndex(10);
		((Control)label1).set_Text("Proveedor");
		dtpHasta.set_Format((DateTimePickerFormat)2);
		((Control)dtpHasta).set_Location(new Point(93, 70));
		((Control)dtpHasta).set_Name("dtpHasta");
		((Control)dtpHasta).set_Size(new Size(100, 20));
		((Control)dtpHasta).set_TabIndex(9);
		dtpDesde.set_Format((DateTimePickerFormat)2);
		((Control)dtpDesde).set_Location(new Point(93, 44));
		((Control)dtpDesde).set_Name("dtpDesde");
		((Control)dtpDesde).set_Size(new Size(100, 20));
		((Control)dtpDesde).set_TabIndex(8);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(19, 73));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(68, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("Fecha Hasta");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(16, 47));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(71, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Fecha Desde");
		dataGridView.set_AllowUserToAddRows(false);
		dataGridView.set_AllowUserToDeleteRows(false);
		dataGridView.set_AllowUserToOrderColumns(true);
		dataGridView.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Fecha,
			(DataGridViewColumn)Descripcion,
			(DataGridViewColumn)Codigo,
			(DataGridViewColumn)Precio
		});
		((Control)dataGridView).set_Dock((DockStyle)5);
		((Control)dataGridView).set_Location(new Point(0, 154));
		dataGridView.set_MultiSelect(false);
		((Control)dataGridView).set_Name("dataGridView");
		dataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dataGridView).set_Size(new Size(963, 347));
		((Control)dataGridView).set_TabIndex(9);
		((DataGridViewColumn)Fecha).set_DataPropertyName("Fecha");
		((DataGridViewColumn)Fecha).set_HeaderText("Fecha");
		((DataGridViewColumn)Fecha).set_Name("Fecha");
		((DataGridViewBand)Fecha).set_ReadOnly(true);
		((DataGridViewColumn)Descripcion).set_DataPropertyName("Descripcion");
		((DataGridViewColumn)Descripcion).set_HeaderText("Descripción");
		((DataGridViewColumn)Descripcion).set_Name("Descripcion");
		((DataGridViewBand)Descripcion).set_ReadOnly(true);
		((DataGridViewColumn)Codigo).set_DataPropertyName("Codigo");
		((DataGridViewColumn)Codigo).set_HeaderText("Código");
		((DataGridViewColumn)Codigo).set_Name("Codigo");
		((DataGridViewBand)Codigo).set_ReadOnly(true);
		((DataGridViewColumn)Precio).set_DataPropertyName("Precio");
		((DataGridViewColumn)Precio).set_HeaderText("Precio");
		((DataGridViewColumn)Precio).set_Name("Precio");
		((DataGridViewBand)Precio).set_ReadOnly(true);
		((Control)btnGenerarFactura).set_Location(new Point(12, 10));
		((Control)btnGenerarFactura).set_Name("btnGenerarFactura");
		((Control)btnGenerarFactura).set_Size(new Size(106, 23));
		((Control)btnGenerarFactura).set_TabIndex(0);
		((Control)btnGenerarFactura).set_Text("Generar Factura");
		((ButtonBase)btnGenerarFactura).set_UseVisualStyleBackColor(true);
		((Control)btnGenerarFactura).add_Click((EventHandler)btnGenerarFactura_Click);
		((Control)searchPanel).get_Controls().Add((Control)(object)groupBox);
		((Control)searchPanel).set_Dock((DockStyle)1);
		((Control)searchPanel).set_Location(new Point(0, 39));
		((Control)searchPanel).set_Name("searchPanel");
		((Control)searchPanel).set_Size(new Size(963, 115));
		((Control)searchPanel).set_TabIndex(11);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)lblResults);
		((Control)panel1).get_Controls().Add((Control)(object)btnGenerarFactura);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(963, 39));
		((Control)panel1).set_TabIndex(10);
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(866, 15));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(21);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(886, 15));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(20);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(963, 501));
		((Control)this).get_Controls().Add((Control)(object)dataGridView);
		((Control)this).get_Controls().Add((Control)(object)searchPanel);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("FacturaProveedorForm");
		((Control)this).set_Text("Facturas");
		((Form)this).add_Load((EventHandler)FacturaProveedorForm_Load);
		((Control)groupBox).ResumeLayout(false);
		((Control)groupBox).PerformLayout();
		((ISupportInitialize)dataGridView).EndInit();
		((Control)searchPanel).ResumeLayout(false);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
