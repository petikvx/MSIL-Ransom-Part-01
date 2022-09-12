using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;
using Coache.Login;

namespace Coache.AbmProveedor;

[PermissionRequired(new Functionalities[] { Functionalities.AdministrarProveedores })]
public class ProveedoresForm : Form
{
	private ProveedorManager _manager = new ProveedorManager();

	private IContainer components;

	private DataGridView proveedoresGrid;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn RazonSocial;

	private DataGridViewTextBoxColumn CUIT;

	private DataGridViewTextBoxColumn Email;

	private Button btnEliminar;

	private Button btnModificar;

	private Panel buttonsPanel;

	private Button btnAgregar;

	private Panel searchPanel;

	private Button btnLimpiar;

	private Button btnBuscar;

	private GroupBox groupBox;

	private Label label4;

	private Label label3;

	private Label label2;

	private TextBox txtEmail;

	private TextBox txtCUIT;

	private TextBox txtRazonSocial;

	private Label lblResults;

	private Label label5;

	public event EventHandler<UserSelectedEventArgs> OnUserSelected;

	public ProveedoresForm()
	{
		InitializeComponent();
	}

	public void SetSearchMode()
	{
		((Control)buttonsPanel).set_Visible(false);
	}

	private void ProveedoresForm_Load(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new BindingSource();
		BindingList<Proveedor> all = _manager.GetAll();
		all.Remove(new Proveedor
		{
			UserID = Session.User.UserID
		});
		proveedoresGrid.set_AutoGenerateColumns(false);
		proveedoresGrid.add_DataSourceChanged((EventHandler)proveedoresGrid_DataSourceChanged);
		proveedoresGrid.set_DataSource((object)all);
		((Control)proveedoresGrid).add_DoubleClick((EventHandler)proveedoresGrid_DoubleClick);
	}

	private void proveedoresGrid_DataSourceChanged(object sender, EventArgs e)
	{
		BindingList<Proveedor> bindingList = proveedoresGrid.get_DataSource() as BindingList<Proveedor>;
		((Control)lblResults).set_Text(bindingList.Count.ToString());
	}

	private void proveedoresGrid_DoubleClick(object sender, EventArgs e)
	{
		if (proveedoresGrid.get_SelectedRows() != null && ((BaseCollection)proveedoresGrid.get_SelectedRows()).get_Count() != 0)
		{
			Proveedor user = proveedoresGrid.get_SelectedRows().get_Item(0).get_DataBoundItem() as Proveedor;
			if (this.OnUserSelected != null)
			{
				this.OnUserSelected(this, new UserSelectedEventArgs
				{
					User = user
				});
			}
		}
	}

	private void btnEliminar_Click(object sender, EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (proveedoresGrid.get_SelectedRows() == null || ((BaseCollection)proveedoresGrid.get_SelectedRows()).get_Count() == 0)
		{
			return;
		}
		Proveedor proveedor = proveedoresGrid.get_SelectedRows().get_Item(0).get_DataBoundItem() as Proveedor;
		if ((int)MessageBox.Show($"Confirma que desea eliminar al proveedor {proveedor.RazonSocial.Trim()}?", "Eliminar proveedor", (MessageBoxButtons)1) == 1)
		{
			try
			{
				_manager.Delete(proveedor);
				(proveedoresGrid.get_DataSource() as BindingList<Proveedor>).Remove(proveedor);
				((Control)proveedoresGrid).Refresh();
				MessageBox.Show($"Proveedor {proveedor.RazonSocial.Trim()} eliminado");
			}
			catch
			{
				MessageBox.Show("Error al eliminar el proveedor");
			}
		}
	}

	private void btnModificar_Click(object sender, EventArgs e)
	{
		if (proveedoresGrid.get_SelectedRows() != null && ((BaseCollection)proveedoresGrid.get_SelectedRows()).get_Count() != 0)
		{
			Proveedor user = proveedoresGrid.get_SelectedRows().get_Item(0).get_DataBoundItem() as Proveedor;
			RegistroForm registroForm = new RegistroForm();
			registroForm.OnUserSaved += regForm_OnUserSaved;
			registroForm.SetUser(user);
			ViewsManager.LoadModal((Form)(object)registroForm);
		}
	}

	private void regForm_OnUserSaved(object sender, UserSavedEventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Se han guardado los datos del proveedor " + e.Username);
		BindingList<Proveedor> bindingList = proveedoresGrid.get_DataSource() as BindingList<Proveedor>;
		Proveedor item = e.User as Proveedor;
		if (bindingList.Contains(item))
		{
			bindingList.Remove(item);
		}
		bindingList.Add(item);
		proveedoresGrid.set_DataSource((object)new BindingList<Proveedor>(bindingList.OrderBy((Proveedor x) => x.RazonSocial).ToList()));
		((Control)proveedoresGrid).Refresh();
	}

	private void btnAgregar_Click(object sender, EventArgs e)
	{
		RegistroForm registroForm = new RegistroForm();
		registroForm.OnUserSaved += regForm_OnUserSaved;
		registroForm.Profile = Profile.Proveedor;
		ViewsManager.LoadModal((Form)(object)registroForm);
	}

	private void btnLimpiar_Click(object sender, EventArgs e)
	{
		((Control)txtRazonSocial).set_Text(string.Empty);
		((Control)txtCUIT).set_Text(string.Empty);
		((Control)txtEmail).set_Text(string.Empty);
		proveedoresGrid.set_DataSource((object)_manager.GetAll());
		((Control)proveedoresGrid).Refresh();
	}

	private void btnBuscar_Click(object sender, EventArgs e)
	{
		BindingList<Proveedor> bindingList = _manager.GetAll();
		if (!string.IsNullOrEmpty(((Control)txtRazonSocial).get_Text()))
		{
			bindingList = new BindingList<Proveedor>(bindingList.Where((Proveedor x) => x.RazonSocial.ToLowerInvariant().Contains(((Control)txtRazonSocial).get_Text().ToLowerInvariant())).ToList());
		}
		if (!string.IsNullOrEmpty(((Control)txtEmail).get_Text()))
		{
			bindingList = new BindingList<Proveedor>(bindingList.Where((Proveedor x) => x.DetalleEntidad.Email.ToLowerInvariant().Contains(((Control)txtEmail).get_Text().ToLowerInvariant())).ToList());
		}
		if (!string.IsNullOrEmpty(((Control)txtCUIT).get_Text()))
		{
			bindingList = new BindingList<Proveedor>(bindingList.Where((Proveedor x) => x.CUIT.ToLowerInvariant().Equals(((Control)txtCUIT).get_Text().ToLowerInvariant())).ToList());
		}
		bindingList.Remove(new Proveedor
		{
			UserID = Session.User.UserID
		});
		proveedoresGrid.set_DataSource((object)bindingList);
		((Control)proveedoresGrid).Refresh();
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
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected O, but got Unknown
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected O, but got Unknown
		proveedoresGrid = new DataGridView();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		RazonSocial = new DataGridViewTextBoxColumn();
		CUIT = new DataGridViewTextBoxColumn();
		Email = new DataGridViewTextBoxColumn();
		btnEliminar = new Button();
		btnModificar = new Button();
		buttonsPanel = new Panel();
		btnAgregar = new Button();
		searchPanel = new Panel();
		btnLimpiar = new Button();
		btnBuscar = new Button();
		groupBox = new GroupBox();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		txtEmail = new TextBox();
		txtCUIT = new TextBox();
		txtRazonSocial = new TextBox();
		lblResults = new Label();
		label5 = new Label();
		((ISupportInitialize)proveedoresGrid).BeginInit();
		((Control)buttonsPanel).SuspendLayout();
		((Control)searchPanel).SuspendLayout();
		((Control)groupBox).SuspendLayout();
		((Control)this).SuspendLayout();
		proveedoresGrid.set_AllowUserToAddRows(false);
		proveedoresGrid.set_AllowUserToDeleteRows(false);
		proveedoresGrid.set_AllowUserToOrderColumns(true);
		proveedoresGrid.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		proveedoresGrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		proveedoresGrid.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn1,
			(DataGridViewColumn)RazonSocial,
			(DataGridViewColumn)CUIT,
			(DataGridViewColumn)Email
		});
		((Control)proveedoresGrid).set_Dock((DockStyle)5);
		((Control)proveedoresGrid).set_Location(new Point(0, 156));
		proveedoresGrid.set_MultiSelect(false);
		((Control)proveedoresGrid).set_Name("proveedoresGrid");
		proveedoresGrid.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)proveedoresGrid).set_Size(new Size(952, 396));
		((Control)proveedoresGrid).set_TabIndex(6);
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_DataPropertyName("UserID");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_FillWeight(20.30457f);
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_HeaderText("ID");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_Name("dataGridViewTextBoxColumn1");
		((DataGridViewBand)dataGridViewTextBoxColumn1).set_ReadOnly(true);
		((DataGridViewColumn)RazonSocial).set_DataPropertyName("RazonSocial");
		((DataGridViewColumn)RazonSocial).set_FillWeight(179.6954f);
		((DataGridViewColumn)RazonSocial).set_HeaderText("Razón Social");
		((DataGridViewColumn)RazonSocial).set_Name("RazonSocial");
		((DataGridViewBand)RazonSocial).set_ReadOnly(true);
		((DataGridViewColumn)CUIT).set_DataPropertyName("CUIT");
		((DataGridViewColumn)CUIT).set_HeaderText("CUIT");
		((DataGridViewColumn)CUIT).set_Name("CUIT");
		((DataGridViewBand)CUIT).set_ReadOnly(true);
		((DataGridViewColumn)Email).set_DataPropertyName("DetalleEntidad");
		((DataGridViewColumn)Email).set_HeaderText("Email");
		((DataGridViewColumn)Email).set_Name("Email");
		((DataGridViewBand)Email).set_ReadOnly(true);
		((Control)btnEliminar).set_Location(new Point(174, 10));
		((Control)btnEliminar).set_Name("btnEliminar");
		((Control)btnEliminar).set_Size(new Size(75, 23));
		((Control)btnEliminar).set_TabIndex(2);
		((Control)btnEliminar).set_Text("Eliminar");
		((ButtonBase)btnEliminar).set_UseVisualStyleBackColor(true);
		((Control)btnEliminar).add_Click((EventHandler)btnEliminar_Click);
		((Control)btnModificar).set_Location(new Point(93, 11));
		((Control)btnModificar).set_Name("btnModificar");
		((Control)btnModificar).set_Size(new Size(75, 23));
		((Control)btnModificar).set_TabIndex(1);
		((Control)btnModificar).set_Text("Modificar");
		((ButtonBase)btnModificar).set_UseVisualStyleBackColor(true);
		((Control)btnModificar).add_Click((EventHandler)btnModificar_Click);
		((Control)buttonsPanel).set_BackColor(SystemColors.ControlDark);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)lblResults);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)btnEliminar);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)label5);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)btnModificar);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)btnAgregar);
		((Control)buttonsPanel).set_Dock((DockStyle)1);
		((Control)buttonsPanel).set_Location(new Point(0, 0));
		((Control)buttonsPanel).set_Name("buttonsPanel");
		((Control)buttonsPanel).set_Size(new Size(952, 39));
		((Control)buttonsPanel).set_TabIndex(5);
		((Control)btnAgregar).set_Location(new Point(12, 10));
		((Control)btnAgregar).set_Name("btnAgregar");
		((Control)btnAgregar).set_Size(new Size(75, 23));
		((Control)btnAgregar).set_TabIndex(0);
		((Control)btnAgregar).set_Text("Nuevo");
		((ButtonBase)btnAgregar).set_UseVisualStyleBackColor(true);
		((Control)btnAgregar).add_Click((EventHandler)btnAgregar_Click);
		((Control)searchPanel).get_Controls().Add((Control)(object)btnLimpiar);
		((Control)searchPanel).get_Controls().Add((Control)(object)btnBuscar);
		((Control)searchPanel).get_Controls().Add((Control)(object)groupBox);
		((Control)searchPanel).set_Dock((DockStyle)1);
		((Control)searchPanel).set_Location(new Point(0, 39));
		((Control)searchPanel).set_Name("searchPanel");
		((Control)searchPanel).set_Size(new Size(952, 117));
		((Control)searchPanel).set_TabIndex(7);
		((Control)btnLimpiar).set_Location(new Point(12, 88));
		((Control)btnLimpiar).set_Name("btnLimpiar");
		((Control)btnLimpiar).set_Size(new Size(75, 23));
		((Control)btnLimpiar).set_TabIndex(1);
		((Control)btnLimpiar).set_Text("Limpiar");
		((ButtonBase)btnLimpiar).set_UseVisualStyleBackColor(true);
		((Control)btnLimpiar).add_Click((EventHandler)btnLimpiar_Click);
		((Control)btnBuscar).set_Anchor((AnchorStyles)9);
		((Control)btnBuscar).set_Location(new Point(865, 88));
		((Control)btnBuscar).set_Name("btnBuscar");
		((Control)btnBuscar).set_Size(new Size(75, 23));
		((Control)btnBuscar).set_TabIndex(0);
		((Control)btnBuscar).set_Text("Filtrar");
		((ButtonBase)btnBuscar).set_UseVisualStyleBackColor(true);
		((Control)btnBuscar).add_Click((EventHandler)btnBuscar_Click);
		((Control)groupBox).set_Anchor((AnchorStyles)13);
		((Control)groupBox).get_Controls().Add((Control)(object)label4);
		((Control)groupBox).get_Controls().Add((Control)(object)label3);
		((Control)groupBox).get_Controls().Add((Control)(object)label2);
		((Control)groupBox).get_Controls().Add((Control)(object)txtEmail);
		((Control)groupBox).get_Controls().Add((Control)(object)txtCUIT);
		((Control)groupBox).get_Controls().Add((Control)(object)txtRazonSocial);
		((Control)groupBox).set_Location(new Point(12, 6));
		((Control)groupBox).set_Name("groupBox");
		((Control)groupBox).set_Size(new Size(928, 76));
		((Control)groupBox).set_TabIndex(2);
		groupBox.set_TabStop(false);
		((Control)groupBox).set_Text("Filtro");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(44, 48));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(32, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("CUIT");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(18, 22));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(70, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Razón Social");
		((Control)label2).set_Anchor((AnchorStyles)9);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(687, 22));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(32, 13));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Email");
		((Control)txtEmail).set_Anchor((AnchorStyles)9);
		((Control)txtEmail).set_Location(new Point(725, 19));
		((Control)txtEmail).set_Name("txtEmail");
		((Control)txtEmail).set_Size(new Size(197, 20));
		((Control)txtEmail).set_TabIndex(3);
		((Control)txtCUIT).set_Location(new Point(94, 45));
		((Control)txtCUIT).set_Name("txtCUIT");
		((Control)txtCUIT).set_Size(new Size(197, 20));
		((Control)txtCUIT).set_TabIndex(1);
		((Control)txtRazonSocial).set_Location(new Point(94, 19));
		((Control)txtRazonSocial).set_Name("txtRazonSocial");
		((Control)txtRazonSocial).set_Size(new Size(197, 20));
		((Control)txtRazonSocial).set_TabIndex(0);
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(855, 16));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(9);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(875, 16));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(952, 552));
		((Control)this).get_Controls().Add((Control)(object)proveedoresGrid);
		((Control)this).get_Controls().Add((Control)(object)searchPanel);
		((Control)this).get_Controls().Add((Control)(object)buttonsPanel);
		((Control)this).set_Name("ProveedoresForm");
		((Control)this).set_Text("Proveedores");
		((Form)this).add_Load((EventHandler)ProveedoresForm_Load);
		((ISupportInitialize)proveedoresGrid).EndInit();
		((Control)buttonsPanel).ResumeLayout(false);
		((Control)buttonsPanel).PerformLayout();
		((Control)searchPanel).ResumeLayout(false);
		((Control)groupBox).ResumeLayout(false);
		((Control)groupBox).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
