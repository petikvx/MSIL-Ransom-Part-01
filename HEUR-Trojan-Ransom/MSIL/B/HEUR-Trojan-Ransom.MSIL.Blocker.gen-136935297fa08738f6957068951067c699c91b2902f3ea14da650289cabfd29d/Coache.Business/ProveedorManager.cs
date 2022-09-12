using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Coache.Common;
using Data;

namespace Coache.Business;

public class ProveedorManager
{
	private UsersManager _usersManager = new UsersManager();

	public BindingList<Proveedor> GetAll()
	{
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetProveedores");
		BindingList<Proveedor> bindingList = new BindingList<Proveedor>();
		if (dataTable != null && dataTable.Rows != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bindingList.Add(new Proveedor
				{
					UserID = int.Parse(row["ID"].ToString()),
					UserName = row["UserName"].ToString(),
					RoleID = int.Parse(row["ID_Rol"].ToString()),
					RazonSocial = row["RazonSocial"].ToString(),
					CUIT = row["CUIT"].ToString(),
					NombreContacto = row["Contacto"].ToString(),
					Rubro = new Rubro
					{
						ID = int.Parse(row["ID_Rubro"].ToString())
					},
					DetalleEntidad = new DetalleEntidad
					{
						Email = row["Email"].ToString(),
						Direccion = row["Direccion"].ToString(),
						Telefono = long.Parse(row["Telefono"].ToString()),
						CP = row["CP"].ToString(),
						Ciudad = new City
						{
							ID = int.Parse(row["ID_Ciudad"].ToString())
						}
					}
				});
			}
			return bindingList;
		}
		return bindingList;
	}

	public void GuardarProveedor(Proveedor proveedor, string password)
	{
		UsersManager usersManager = new UsersManager();
		DetalleEntidadManager detalleEntidadManager = new DetalleEntidadManager();
		if (proveedor.UserID == 0)
		{
			SqlTransaction val = SqlDataAccess.OpenTransaction(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString());
			try
			{
				SessionData.Set("Transaction", val);
				proveedor.UserID = usersManager.CreateProfileAccount(proveedor, Proveedor.Profile, password);
				detalleEntidadManager.AddDetalleEntidad(proveedor);
				SqlDataAccess.ExecuteNonQuery("GRUPO_N.InsertProveedor", SqlDataAccessArgs.CreateWith("@RazonSocial", proveedor.RazonSocial).And("@ID", proveedor.UserID).And("@ID_Rubro", proveedor.Rubro.ID)
					.And("@CUIT", proveedor.CUIT)
					.And("@Contacto", proveedor.NombreContacto)
					.Arguments, val);
					SessionData.Remove("Transaction");
					SqlDataAccess.Commit(val);
					return;
				}
				catch
				{
					SqlDataAccess.Rollback(val);
					proveedor.UserID = 0;
					throw;
				}
			}
			detalleEntidadManager.UpdateDetalleEntidad(proveedor);
			SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.UpdateProveedor", SqlDataAccessArgs.CreateWith("@RazonSocial", proveedor.RazonSocial).And("@ID", proveedor.UserID).And("@ID_Rubro", proveedor.Rubro.ID)
				.And("@CUIT", proveedor.CUIT)
				.And("@Contacto", proveedor.NombreContacto)
				.Arguments);
			}

			public void Delete(Proveedor proveedor)
			{
				_usersManager.DeleteAccount(proveedor);
			}
		}
