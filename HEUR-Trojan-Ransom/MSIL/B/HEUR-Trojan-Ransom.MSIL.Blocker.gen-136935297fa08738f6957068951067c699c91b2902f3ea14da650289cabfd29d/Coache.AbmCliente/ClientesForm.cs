using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;
using Coache.Login;

namespace Coache.AbmCliente;

[PermissionRequired(new Functionalities[] { Functionalities.AdministrarClientes })]
public class ClientesForm : Form
{
	private ClienteManager _clienteManager = new ClienteManager();

	private bool _isSearchMode;

	private IContainer components;

	private Panel buttonsPanel;

	private Button btnEliminar;

	private Button btnModificar;

	private Button btnAgregar;

	private DataGridView dgvClientes;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn Apellido;

	private DataGridViewTextBoxColumn DNI;

	private DataGridViewTextBoxColumn Email;

	private Panel searchPanel;

	private GroupBox groupBox;

	private Button btnLimpiar;

	private Button btnBuscar;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private TextBox txtEmail;

	private TextBox txtDNI;

	private TextBox txtApellido;

	private TextBox txtNombre;

	private Label lblResults;

	private Label label5;

	public event EventHandler<UserSelectedEventArgs> OnUserSelected;

	public ClientesForm()
	{
		InitializeComponent();
	}

	public void SetSearchMode()
	{
		((Control)buttonsPanel).set_Visible(false);
		_isSearchMode = true;
	}

	private void ClientesForm_Load(object sender, EventArgs e)
	{
		BindingList<Cliente> all = _clienteManager.GetAll();
		if (_isSearchMode)
		{
			all.Remove(new Cliente
			{
				UserID = Session.User.UserID
			});
		}
		dgvClientes.set_AutoGenerateColumns(false);
		dgvClientes.add_DataSourceChanged((EventHandler)dgvClientes_DataSourceChanged);
		all.Remove(new Cliente
		{
			UserID = Session.User.UserID
		});
		dgvClientes.set_DataSource((object)all);
		((Control)dgvClientes).add_DoubleClick((EventHandler)dgvClientes_DoubleClick);
	}

	private void dgvClientes_DataSourceChanged(object sender, EventArgs e)
	{
		BindingList<Cliente> bindingList = dgvClientes.get_DataSource() as BindingList<Cliente>;
		((Control)lblResults).set_Text(bindingList.Count.ToString());
	}

	private void dgvClientes_DoubleClick(object sender, EventArgs e)
	{
		if (dgvClientes.get_SelectedRows() != null && ((BaseCollection)dgvClientes.get_SelectedRows()).get_Count() != 0)
		{
			Cliente user = dgvClientes.get_SelectedRows().get_Item(0).get_DataBoundItem() as Cliente;
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
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (dgvClientes.get_SelectedRows() == null || ((BaseCollection)dgvClientes.get_SelectedRows()).get_Count() == 0)
		{
			return;
		}
		Cliente cliente = dgvClientes.get_SelectedRows().get_Item(0).get_DataBoundItem() as Cliente;
		if ((int)MessageBox.Show($"Confirma que desea eliminar al cliente {cliente.Nombre.Trim()} {cliente.Apellido.Trim()}?", "Eliminar cliente", (MessageBoxButtons)1) == 1)
		{
			try
			{
				_clienteManager.Delete(cliente);
				(dgvClientes.get_DataSource() as BindingList<Cliente>).Remove(cliente);
				((Control)dgvClientes).Refresh();
				MessageBox.Show($"Cliente {cliente.Nombre.Trim()} {cliente.Apellido.Trim()} eliminado");
			}
			catch
			{
				MessageBox.Show("Error al eliminar el cliente");
			}
		}
	}

	private void btnModificar_Click(object sender, EventArgs e)
	{
		if (dgvClientes.get_SelectedRows() != null && ((BaseCollection)dgvClientes.get_SelectedRows()).get_Count() != 0)
		{
			Cliente user = dgvClientes.get_SelectedRows().get_Item(0).get_DataBoundItem() as Cliente;
			RegistroForm registroForm = new RegistroForm();
			registroForm.OnUserSaved += regForm_OnUserSaved;
			registroForm.SetUser(user);
			ViewsManager.LoadModal((Form)(object)registroForm);
		}
	}

	private void regForm_OnUserSaved(object sender, UserSavedEventArgs e)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		BindingList<Cliente> bindingList = dgvClientes.get_DataSource() as BindingList<Cliente>;
		Cliente item = e.User as Cliente;
		if (bindingList.Contains(item))
		{
			bindingList.Remove(item);
		}
		bindingList.Add(item);
		dgvClientes.set_DataSource((object)new BindingList<Cliente>(bindingList.OrderBy((Cliente x) => x.Apellido + x.Nombre).ToList()));
		((Control)dgvClientes).Refresh();
		MessageBox.Show("Se han guardado los datos del cliente " + e.Username);
	}

	private void btnAgregar_Click(object sender, EventArgs e)
	{
		RegistroForm registroForm = new RegistroForm();
		registroForm.OnUserSaved += regForm_OnUserSaved;
		registroForm.Profile = Profile.Cliente;
		ViewsManager.LoadModal((Form)(object)registroForm);
	}

	private void btnLimpiar_Click(object sender, EventArgs e)
	{
		((Control)txtApellido).set_Text(string.Empty);
		((Control)txtNombre).set_Text(string.Empty);
		((Control)txtEmail).set_Text(string.Empty);
		((Control)txtDNI).set_Text(string.Empty);
		dgvClientes.set_DataSource((object)_clienteManager.GetAll());
		((Control)dgvClientes).Refresh();
	}

	private void btnBuscar_Click(object sender, EventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		long dni = 0L;
		if (!string.IsNullOrEmpty(((Control)txtDNI).get_Text()) && !long.TryParse(((Control)txtDNI).get_Text(), out dni))
		{
			MessageBox.Show("El DNI debe ser numérico");
			return;
		}
		BindingList<Cliente> bindingList = _clienteManager.GetAll();
		if (!string.IsNullOrEmpty(((Control)txtApellido).get_Text()))
		{
			bindingList = new BindingList<Cliente>(bindingList.Where((Cliente x) => x.Apellido.ToLowerInvariant().Contains(((Control)txtApellido).get_Text().ToLowerInvariant())).ToList());
		}
		if (!string.IsNullOrEmpty(((Control)txtNombre).get_Text()))
		{
			bindingList = new BindingList<Cliente>(bindingList.Where((Cliente x) => x.Nombre.ToLowerInvariant().Contains(((Control)txtNombre).get_Text().ToLowerInvariant())).ToList());
		}
		if (!string.IsNullOrEmpty(((Control)txtEmail).get_Text()))
		{
			bindingList = new BindingList<Cliente>(bindingList.Where((Cliente x) => x.DetalleEntidad.Email.ToLowerInvariant().Contains(((Control)txtEmail).get_Text().ToLowerInvariant())).ToList());
		}
		if (!string.IsNullOrEmpty(((Control)txtDNI).get_Text()))
		{
			bindingList = new BindingList<Cliente>(bindingList.Where((Cliente x) => x.DNI == dni).ToList());
		}
		bindingList.Remove(new Cliente
		{
			UserID = Session.User.UserID
		});
		dgvClientes.set_DataSource((object)new BindingList<Cliente>(bindingList.OrderBy((Cliente x) => x.Apellido + x.Nombre).ToList()));
		((Control)dgvClientes).Refresh();
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
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Expected O, but got Unknown
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Expected O, but got Unknown
		buttonsPanel = new Panel();
		btnEliminar = new Button();
		btnModificar = new Button();
		btnAgregar = new Button();
		dgvClientes = new DataGridView();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		Apellido = new DataGridViewTextBoxColumn();
		DNI = new DataGridViewTextBoxColumn();
		Email = new DataGridViewTextBoxColumn();
		searchPanel = new Panel();
		groupBox = new GroupBox();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		txtEmail = new TextBox();
		txtDNI = new TextBox();
		txtApellido = new TextBox();
		txtNombre = new TextBox();
		btnLimpiar = new Button();
		btnBuscar = new Button();
		label5 = new Label();
		lblResults = new Label();
		((Control)buttonsPanel).SuspendLayout();
		((ISupportInitialize)dgvClientes).BeginInit();
		((Control)searchPanel).SuspendLayout();
		((Control)groupBox).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)buttonsPanel).set_BackColor(SystemColors.ControlDark);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)lblResults);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)label5);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)btnEliminar);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)btnModificar);
		((Control)buttonsPanel).get_Controls().Add((Control)(object)btnAgregar);
		((Control)buttonsPanel).set_Dock((DockStyle)1);
		((Control)buttonsPanel).set_Location(new Point(0, 0));
		((Control)buttonsPanel).set_Name("buttonsPanel");
		((Control)buttonsPanel).set_Size(new Size(588, 39));
		((Control)buttonsPanel).set_TabIndex(3);
		((Control)btnEliminar).set_Location(new Point(174, 10));
		((Control)btnEliminar).set_Name("btnEliminar");
		((Control)btnEliminar).set_Size(new Size(75, 23));
		((Control)btnEliminar).set_TabIndex(2);
		((Control)btnEliminar).set_Text("Eliminar");
		((ButtonBase)btnEliminar).set_UseVisualStyleBackColor(true);
		((Control)btnEliminar).add_Click((EventHandler)btnEliminar_Click);
		((Control)btnModificar).set_Location(new Point(93, 10));
		((Control)btnModificar).set_Name("btnModificar");
		((Control)btnModificar).set_Size(new Size(75, 23));
		((Control)btnModificar).set_TabIndex(1);
		((Control)btnModificar).set_Text("Modificar");
		((ButtonBase)btnModificar).set_UseVisualStyleBackColor(true);
		((Control)btnModificar).add_Click((EventHandler)btnModificar_Click);
		((Control)btnAgregar).set_Location(new Point(12, 10));
		((Control)btnAgregar).set_Name("btnAgregar");
		((Control)btnAgregar).set_Size(new Size(75, 23));
		((Control)btnAgregar).set_TabIndex(0);
		((Control)btnAgregar).set_Text("Nuevo");
		((ButtonBase)btnAgregar).set_UseVisualStyleBackColor(true);
		((Control)btnAgregar).add_Click((EventHandler)btnAgregar_Click);
		dgvClientes.set_AllowUserToAddRows(false);
		dgvClientes.set_AllowUserToDeleteRows(false);
		dgvClientes.set_AllowUserToOrderColumns(true);
		dgvClientes.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dgvClientes.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dgvClientes.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn1,
			(DataGridViewColumn)dataGridViewTextBoxColumn2,
			(DataGridViewColumn)Apellido,
			(DataGridViewColumn)DNI,
			(DataGridViewColumn)Email
		});
		((Control)dgvClientes).set_Dock((DockStyle)5);
		((Control)dgvClientes).set_Location(new Point(0, 156));
		dgvClientes.set_MultiSelect(false);
		((Control)dgvClientes).set_Name("dgvClientes");
		dgvClientes.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dgvClientes).set_Size(new Size(588, 314));
		((Control)dgvClientes).set_TabIndex(4);
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_DataPropertyName("UserID");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_FillWeight(20.30457f);
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_HeaderText("ID");
		((DataGridViewColumn)dataGridViewTextBoxColumn1).set_Name("dataGridViewTextBoxColumn1");
		((DataGridViewBand)dataGridViewTextBoxColumn1).set_ReadOnly(true);
		((DataGridViewColumn)dataGridViewTextBoxColumn2).set_DataPropertyName("Nombre");
		((DataGridViewColumn)dataGridViewTextBoxColumn2).set_FillWeight(179.6954f);
		((DataGridViewColumn)dataGridViewTextBoxColumn2).set_HeaderText("Nombre");
		((DataGridViewColumn)dataGridViewTextBoxColumn2).set_Name("dataGridViewTextBoxColumn2");
		((DataGridViewBand)dataGridViewTextBoxColumn2).set_ReadOnly(true);
		((DataGridViewColumn)Apellido).set_DataPropertyName("Apellido");
		((DataGridViewColumn)Apellido).set_HeaderText("Apellido");
		((DataGridViewColumn)Apellido).set_Name("Apellido");
		((DataGridViewBand)Apellido).set_ReadOnly(true);
		((DataGridViewColumn)DNI).set_DataPropertyName("DNI");
		((DataGridViewColumn)DNI).set_HeaderText("DNI");
		((DataGridViewColumn)DNI).set_Name("DNI");
		((DataGridViewBand)DNI).set_ReadOnly(true);
		((DataGridViewColumn)Email).set_DataPropertyName("DetalleEntidad");
		((DataGridViewColumn)Email).set_HeaderText("Email");
		((DataGridViewColumn)Email).set_Name("Email");
		((DataGridViewBand)Email).set_ReadOnly(true);
		((Control)searchPanel).get_Controls().Add((Control)(object)groupBox);
		((Control)searchPanel).get_Controls().Add((Control)(object)btnLimpiar);
		((Control)searchPanel).get_Controls().Add((Control)(object)btnBuscar);
		((Control)searchPanel).set_Dock((DockStyle)1);
		((Control)searchPanel).set_Location(new Point(0, 39));
		((Control)searchPanel).set_Name("searchPanel");
		((Control)searchPanel).set_Size(new Size(588, 117));
		((Control)searchPanel).set_TabIndex(5);
		((Control)groupBox).set_Anchor((AnchorStyles)13);
		((Control)groupBox).get_Controls().Add((Control)(object)label4);
		((Control)groupBox).get_Controls().Add((Control)(object)label3);
		((Control)groupBox).get_Controls().Add((Control)(object)label2);
		((Control)groupBox).get_Controls().Add((Control)(object)label1);
		((Control)groupBox).get_Controls().Add((Control)(object)txtEmail);
		((Control)groupBox).get_Controls().Add((Control)(object)txtDNI);
		((Control)groupBox).get_Controls().Add((Control)(object)txtApellido);
		((Control)groupBox).get_Controls().Add((Control)(object)txtNombre);
		((Control)groupBox).set_Location(new Point(12, 6));
		((Control)groupBox).set_Name("groupBox");
		((Control)groupBox).set_Size(new Size(564, 76));
		((Control)groupBox).set_TabIndex(2);
		groupBox.set_TabStop(false);
		((Control)groupBox).set_Text("Filtro");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(44, 48));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(44, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("Apellido");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(44, 22));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(44, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Nombre");
		((Control)label2).set_Anchor((AnchorStyles)9);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(323, 48));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(32, 13));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Email");
		((Control)label1).set_Anchor((AnchorStyles)9);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(329, 22));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(26, 13));
		((Control)label1).set_TabIndex(4);
		((Control)label1).set_Text("DNI");
		((Control)txtEmail).set_Anchor((AnchorStyles)9);
		((Control)txtEmail).set_Location(new Point(361, 45));
		((Control)txtEmail).set_Name("txtEmail");
		((Control)txtEmail).set_Size(new Size(197, 20));
		((Control)txtEmail).set_TabIndex(3);
		((Control)txtDNI).set_Anchor((AnchorStyles)9);
		((Control)txtDNI).set_Location(new Point(361, 19));
		((Control)txtDNI).set_Name("txtDNI");
		((Control)txtDNI).set_Size(new Size(197, 20));
		((Control)txtDNI).set_TabIndex(2);
		((Control)txtApellido).set_Location(new Point(94, 45));
		((Control)txtApellido).set_Name("txtApellido");
		((Control)txtApellido).set_Size(new Size(197, 20));
		((Control)txtApellido).set_TabIndex(1);
		((Control)txtNombre).set_Location(new Point(94, 19));
		((Control)txtNombre).set_Name("txtNombre");
		((Control)txtNombre).set_Size(new Size(197, 20));
		((Control)txtNombre).set_TabIndex(0);
		((Control)btnLimpiar).set_Location(new Point(12, 88));
		((Control)btnLimpiar).set_Name("btnLimpiar");
		((Control)btnLimpiar).set_Size(new Size(75, 23));
		((Control)btnLimpiar).set_TabIndex(1);
		((Control)btnLimpiar).set_Text("Limpiar");
		((ButtonBase)btnLimpiar).set_UseVisualStyleBackColor(true);
		((Control)btnLimpiar).add_Click((EventHandler)btnLimpiar_Click);
		((Control)btnBuscar).set_Anchor((AnchorStyles)9);
		((Control)btnBuscar).set_Location(new Point(501, 88));
		((Control)btnBuscar).set_Name("btnBuscar");
		((Control)btnBuscar).set_Size(new Size(75, 23));
		((Control)btnBuscar).set_TabIndex(0);
		((Control)btnBuscar).set_Text("Filtrar");
		((ButtonBase)btnBuscar).set_UseVisualStyleBackColor(true);
		((Control)btnBuscar).add_Click((EventHandler)btnBuscar_Click);
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(520, 20));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(3);
		((Control)label5).set_Text("resultados");
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(500, 20));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(4);
		((Control)lblResults).set_Text("0");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(588, 470));
		((Control)this).get_Controls().Add((Control)(object)dgvClientes);
		((Control)this).get_Controls().Add((Control)(object)searchPanel);
		((Control)this).get_Controls().Add((Control)(object)buttonsPanel);
		((Control)this).set_Name("ClientesForm");
		((Control)this).set_Text("Clientes");
		((Form)this).add_Load((EventHandler)ClientesForm_Load);
		((Control)buttonsPanel).ResumeLayout(false);
		((Control)buttonsPanel).PerformLayout();
		((ISupportInitialize)dgvClientes).EndInit();
		((Control)searchPanel).ResumeLayout(false);
		((Control)groupBox).ResumeLayout(false);
		((Control)groupBox).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
