using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Coache.Common;
using Data;

namespace Coache.Business;

public class CuponManager
{
	public BindingList<Cupon> GetAll(Proveedor proveedor)
	{
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetCuponesProveedor", SqlDataAccessArgs.CreateWith("@ID_Proveedor", proveedor.UserID).Arguments);
		BindingList<Cupon> bindingList = new BindingList<Cupon>();
		if (dataTable != null && dataTable.Rows != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bindingList.Add(new Cupon
				{
					ID = int.Parse(row["ID"].ToString()),
					Precio = double.Parse(row["Precio"].ToString()),
					PrecioOriginal = double.Parse(row["PrecioOriginal"].ToString()),
					FechaPublicacion = Convert.ToDateTime(row["FechaPublicacion"]),
					FechaVencimientoConsumo = Convert.ToDateTime(row["FechaVencimiento"]),
					FechaVencimientoOferta = Convert.ToDateTime(row["FechaVigencia"]),
					Cantidad = int.Parse(row["Stock"].ToString()),
					CantidadPorUsuario = int.Parse(row["CantidadPorUsuario"].ToString()),
					Descripcion = row["Descripcion"].ToString(),
					Codigo = row["Codigo"].ToString(),
					Proveedor = proveedor,
					Ciudades = GetCiudades(int.Parse(row["ID"].ToString())),
					Publicado = Convert.ToBoolean(row["Publicado"])
				});
			}
			return bindingList;
		}
		return bindingList;
	}

	public BindingList<Cupon> GetAll(Cliente cliente)
	{
		DateTime dateTime = Convert.ToDateTime(ConfigurationManager.get_AppSettings()["FechaSistema"]);
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetCuponesCliente", SqlDataAccessArgs.CreateWith("@ID_Cliente", cliente.UserID).And("@Fecha_Publicacion", new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59)).Arguments);
		BindingList<Cupon> bindingList = new BindingList<Cupon>();
		if (dataTable != null && dataTable.Rows != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				if (int.Parse(row["Stock"].ToString()) != 0)
				{
					bindingList.Add(new Cupon
					{
						ID = int.Parse(row["ID"].ToString()),
						Precio = double.Parse(row["Precio"].ToString()),
						PrecioOriginal = double.Parse(row["PrecioOriginal"].ToString()),
						FechaPublicacion = Convert.ToDateTime(row["FechaPublicacion"]),
						FechaVencimientoConsumo = Convert.ToDateTime(row["FechaVencimiento"]),
						FechaVencimientoOferta = Convert.ToDateTime(row["FechaVigencia"]),
						Cantidad = int.Parse(row["Stock"].ToString()),
						CantidadPorUsuario = int.Parse(row["CantidadPorUsuario"].ToString()),
						Descripcion = row["Descripcion"].ToString(),
						Codigo = row["Codigo"].ToString()
					});
				}
			}
			return bindingList;
		}
		return bindingList;
	}

	public BindingList<Cupon> GetAllToPublish()
	{
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetCuponesParaPublicar", SqlDataAccessArgs.CreateWith("@Fecha_Publicacion", Convert.ToDateTime(ConfigurationManager.get_AppSettings()["FechaSistema"])).Arguments);
		BindingList<Cupon> bindingList = new BindingList<Cupon>();
		if (dataTable != null && dataTable.Rows != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bindingList.Add(new Cupon
				{
					ID = int.Parse(row["ID"].ToString()),
					FechaVencimientoOferta = Convert.ToDateTime(row["FechaVigencia"]),
					Descripcion = row["Descripcion"].ToString(),
					Codigo = row["Codigo"].ToString(),
					Proveedor = new Proveedor
					{
						UserID = int.Parse(row["ID_Proveedor"].ToString()),
						RazonSocial = row["RazonSocial"].ToString()
					}
				});
			}
			return bindingList;
		}
		return bindingList;
	}

	public int Add(Cupon cupon)
	{
		int num = SqlDataAccess.ExecuteScalarQuery<int>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertCupon", SqlDataAccessArgs.CreateWith("@Precio", cupon.Precio).And("@PrecioOriginal", cupon.PrecioOriginal).And("@FechaPublicacion", cupon.FechaPublicacion)
			.And("@FechaVigencia", cupon.FechaVencimientoOferta)
			.And("@FechaVencimiento", cupon.FechaVencimientoConsumo)
			.And("@Stock", cupon.Cantidad)
			.And("@Descripcion", cupon.Descripcion)
			.And("@ID_Proveedor", cupon.Proveedor.UserID)
			.And("@CantidadPorUsuario", cupon.CantidadPorUsuario)
			.And("@Publicado", 0)
			.And("@Codigo", cupon.Codigo)
			.Arguments);
			foreach (City ciudade in cupon.Ciudades)
			{
				SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertCuponCiudad", SqlDataAccessArgs.CreateWith("@ID_Cupon", num).And("@ID_Ciudad", ciudade.ID).Arguments);
			}
			return num;
		}

		public void Publish(Cupon cupon)
		{
			SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.PublicarCupon", SqlDataAccessArgs.CreateWith("@ID", cupon.ID).Arguments);
		}

		public static string GetCodigo()
		{
			string empty = string.Empty;
			do
			{
				char[] array = new char[10];
				Random random = new Random();
				for (int i = 0; i < 10; i++)
				{
					array[i] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[random.Next(0, "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Length)];
				}
				empty = new string(array);
			}
			while (CodigoExists(empty));
			return empty;
		}

		public int ComprarCupon(Cupon cupon, Cliente cliente)
		{
			return int.Parse((SqlDataAccess.ExecuteScalarQuery<object>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.ComprarCuponCliente", SqlDataAccessArgs.CreateWith("@ID_Cupon", cupon.ID).And("@ID_Cliente", cliente.UserID).And("@Fecha", DateTime.Now)
				.Arguments) ?? throw new Exception("Ha superado la cantidad de cupones permitidos por persona")).ToString());
			}

			private static bool CodigoExists(string codigo)
			{
				return SqlDataAccess.ExecuteScalarQuery<object>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetCodigoCuponExists", SqlDataAccessArgs.CreateWith("@Codigo", codigo).Arguments) != null;
			}

			private List<City> GetCiudades(int id)
			{
				List<City> list = new List<City>();
				DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetCiudadesCupon", SqlDataAccessArgs.CreateWith("@ID_Cupon", id).Arguments);
				if (dataTable != null && dataTable.Rows != null)
				{
					foreach (DataRow row in dataTable.Rows)
					{
						list.Add(new City
						{
							ID = int.Parse(row["ID"].ToString()),
							Name = row["Descripcion"].ToString()
						});
					}
					return list;
				}
				return list;
			}
		}
