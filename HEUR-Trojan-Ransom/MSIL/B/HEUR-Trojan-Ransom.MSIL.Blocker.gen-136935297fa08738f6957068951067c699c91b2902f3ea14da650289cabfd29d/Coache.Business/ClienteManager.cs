using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Coache.Common;
using Data;

namespace Coache.Business;

public class ClienteManager
{
	private UsersManager _usersManager = new UsersManager();

	public BindingList<Cliente> GetAll()
	{
		if (SessionData.Contains("Clients"))
		{
			return SessionData.Get<BindingList<Cliente>>("Clients");
		}
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetClientes");
		BindingList<Cliente> bindingList = new BindingList<Cliente>();
		if (dataTable != null && dataTable.Rows != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bindingList.Add(new Cliente
				{
					Apellido = row["Apellido"].ToString(),
					Nombre = row["Nombre"].ToString(),
					UserID = int.Parse(row["ID"].ToString()),
					UserName = row["UserName"].ToString(),
					RoleID = int.Parse(row["ID_Rol"].ToString()),
					FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]),
					DNI = long.Parse(row["DNI"].ToString()),
					Ciudades = GetCiudades(int.Parse(row["ID"].ToString())),
					DetalleEntidad = new DetalleEntidad
					{
						Email = row["Email"].ToString(),
						Direccion = row["Direccion"].ToString(),
						CP = row["CP"].ToString(),
						Telefono = long.Parse(row["Telefono"].ToString()),
						Ciudad = new City
						{
							ID = int.Parse(row["ID_Ciudad"].ToString())
						}
					}
				});
			}
		}
		SessionData.Set("Clients", bindingList);
		return bindingList;
	}

	public void GuardarCliente(Cliente cliente, string password)
	{
		UsersManager usersManager = new UsersManager();
		DetalleEntidadManager detalleEntidadManager = new DetalleEntidadManager();
		if (cliente.UserID == 0)
		{
			SqlTransaction val = SqlDataAccess.OpenTransaction(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString());
			try
			{
				SessionData.Set("Transaction", val);
				cliente.UserID = usersManager.CreateProfileAccount(cliente, Cliente.Profile, password);
				detalleEntidadManager.AddDetalleEntidad(cliente);
				SqlDataAccess.ExecuteNonQuery("GRUPO_N.InsertCliente", SqlDataAccessArgs.CreateWith("@DNI", cliente.DNI).And("@ID", cliente.UserID).And("@Nombre", cliente.Nombre)
					.And("@Apellido", cliente.Apellido)
					.And("@FechaNacimiento", cliente.FechaNacimiento)
					.Arguments, val);
					SessionData.Remove("Transaction");
					SqlDataAccess.Commit(val);
				}
				catch
				{
					SqlDataAccess.Rollback(val);
					cliente.UserID = 0;
					throw;
				}
			}
			else
			{
				detalleEntidadManager.UpdateDetalleEntidad(cliente);
				SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.UpdateCliente", SqlDataAccessArgs.CreateWith("@DNI", cliente.DNI).And("@ID", cliente.UserID).And("@Nombre", cliente.Nombre)
					.And("@Apellido", cliente.Apellido)
					.And("@FechaNacimiento", cliente.FechaNacimiento)
					.Arguments);
				}
				AddCiudades(cliente);
				SessionData.Remove("Clients");
			}

			private void AddCiudades(Cliente cliente)
			{
				SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.DeleteCiudadesCliente", SqlDataAccessArgs.CreateWith("@ID_Cliente", cliente.UserID).Arguments);
				foreach (City ciudade in cliente.Ciudades)
				{
					SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertCiudadCliente", SqlDataAccessArgs.CreateWith("@ID_Cliente", cliente.UserID).And("@ID_Ciudad", ciudade.ID).Arguments);
				}
			}

			private List<City> GetCiudades(int id)
			{
				List<City> list = new List<City>();
				DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetCiudadesCliente", SqlDataAccessArgs.CreateWith("@ID_Cliente", id).Arguments);
				if (dataTable != null && dataTable.Rows != null)
				{
					foreach (DataRow row in dataTable.Rows)
					{
						list.Add(new City
						{
							ID = int.Parse(row["ID_Ciudad"].ToString())
						});
					}
					return list;
				}
				return list;
			}

			public void Delete(Cliente cliente)
			{
				_usersManager.DeleteAccount(cliente);
				SessionData.Remove("Clients");
			}
		}
