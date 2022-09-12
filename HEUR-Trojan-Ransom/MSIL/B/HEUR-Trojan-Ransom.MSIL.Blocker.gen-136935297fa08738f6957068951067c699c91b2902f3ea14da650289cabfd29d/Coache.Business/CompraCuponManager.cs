using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Coache.Common;
using Data;

namespace Coache.Business;

public class CompraCuponManager
{
	public const string ESTADO_CONSUMIDO = "Consumido";

	public const string ESTADO_DEVUELTO = "Devuelto";

	public const string ESTADO_COMPRADO = "Comprado";

	public BindingList<CompraCupon> GetAll(Cliente cliente, DateTime fechaDesde, DateTime fechaHasta)
	{
		DateTime dateTime = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day, 0, 0, 0);
		DateTime dateTime2 = new DateTime(fechaHasta.Year, fechaHasta.Month, fechaHasta.Day, 23, 59, 59);
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetComprasCliente", SqlDataAccessArgs.CreateWith("@ID_Cliente", cliente.UserID).And("@FechaDesde", dateTime).And("@FechaHasta", dateTime2)
			.Arguments);
			BindingList<CompraCupon> bindingList = new BindingList<CompraCupon>();
			if (dataTable != null && dataTable.Rows != null)
			{
				foreach (DataRow row in dataTable.Rows)
				{
					bindingList.Add(new CompraCupon
					{
						ID = int.Parse(row["ID"].ToString()),
						Precio = double.Parse(row["Precio"].ToString()),
						Fecha = Convert.ToDateTime(row["Fecha"]),
						FechaVencimiento = Convert.ToDateTime(row["FechaVencimiento"]),
						Descripcion = row["Descripcion"].ToString(),
						Codigo = row["Codigo"].ToString(),
						Estado = GetEstado(row["ID_Devolucion"], row["ID_Canje"])
					});
				}
				return bindingList;
			}
			return bindingList;
		}

		public BindingList<CompraCupon> GetParaFacturar(Proveedor proveedor, DateTime fechaDesde, DateTime fechaHasta)
		{
			DateTime dateTime = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day, 0, 0, 0);
			DateTime dateTime2 = new DateTime(fechaHasta.Year, fechaHasta.Month, fechaHasta.Day, 23, 59, 59);
			DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetComprasParaFacturar", SqlDataAccessArgs.CreateWith("@ID_Proveedor", proveedor.UserID).And("@FechaDesde", dateTime).And("@FechaHasta", dateTime2)
				.Arguments);
				BindingList<CompraCupon> bindingList = new BindingList<CompraCupon>();
				if (dataTable != null && dataTable.Rows != null)
				{
					foreach (DataRow row in dataTable.Rows)
					{
						bindingList.Add(new CompraCupon
						{
							ID = int.Parse(row["ID_Canje"].ToString()),
							Precio = double.Parse(row["Precio"].ToString()),
							Fecha = Convert.ToDateTime(row["Fecha"]),
							Descripcion = row["Descripcion"].ToString(),
							Codigo = row["Codigo"].ToString(),
							Cliente = row["Cliente"].ToString()
						});
					}
					return bindingList;
				}
				return bindingList;
			}

			public BindingList<CompraCupon> GetAll(Proveedor proveedor)
			{
				DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
				DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetComprasProveedor", SqlDataAccessArgs.CreateWith("@ID_Proveedor", proveedor.UserID).And("@FechaVencimiento", dateTime).Arguments);
				BindingList<CompraCupon> bindingList = new BindingList<CompraCupon>();
				if (dataTable != null && dataTable.Rows != null)
				{
					foreach (DataRow row in dataTable.Rows)
					{
						bindingList.Add(new CompraCupon
						{
							ID = int.Parse(row["ID"].ToString()),
							Precio = double.Parse(row["Precio"].ToString()),
							Fecha = Convert.ToDateTime(row["Fecha"]),
							Descripcion = row["Descripcion"].ToString(),
							Codigo = row["Codigo"].ToString(),
							Cliente = row["Cliente"].ToString()
						});
					}
					return bindingList;
				}
				return bindingList;
			}

			private string GetEstado(object idDevolucion, object idCanje)
			{
				if (idDevolucion != null && !(idDevolucion is DBNull))
				{
					return "Devuelto";
				}
				if (idCanje != null && !(idCanje is DBNull))
				{
					return "Consumido";
				}
				return "Comprado";
			}

			public void DevolverCompra(Cliente cliente, CompraCupon compraCupon, string motivo)
			{
				object obj = SqlDataAccess.ExecuteScalarQuery<object>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertDevolucionCompra", SqlDataAccessArgs.CreateWith("@ID_Cliente", cliente.UserID).And("@ID_CompraCupon", compraCupon.ID).And("@Fecha", DateTime.Now)
					.And("@Motivo", motivo)
					.Arguments);
					int result = 0;
					if (obj == null || !int.TryParse(obj.ToString(), out result) || result == 0)
					{
						throw new Exception("No se puede devolver una compra ya consumida");
					}
				}

				public void ConsumirCompra(CompraCupon compraCupon)
				{
					SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertCanjeCupon", SqlDataAccessArgs.CreateWith("@ID_CompraCupon", compraCupon.ID).And("@Fecha", DateTime.Now).Arguments);
				}
			}
