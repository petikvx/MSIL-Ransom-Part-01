using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using Coache.Common;
using Data;

namespace Coache.Business;

public class PagosManager
{
	public BindingList<Pago> GetAll(User user)
	{
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetPagosCliente", SqlDataAccessArgs.CreateWith("@ID_Cliente", user.UserID).Arguments);
		BindingList<Pago> bindingList = new BindingList<Pago>();
		if (dataTable != null && dataTable.Rows != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bindingList.Add(new Pago
				{
					Credito = double.Parse(row["Credito"].ToString()),
					Fecha = Convert.ToDateTime(row["Fecha"]),
					ID = int.Parse(row["ID"].ToString()),
					TipoPago = (TipoPago)int.Parse(row["ID_TipoPago"].ToString()),
					Banco = row["Banco"].ToString(),
					Tarjeta = row["Numero"].ToString()
				});
			}
			return bindingList;
		}
		return bindingList;
	}

	public List<TipoPago> GetTipoPagos()
	{
		return Enum.GetValues(typeof(TipoPago)).Cast<TipoPago>().ToList();
	}

	public void Add(Pago pago, User user)
	{
		SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertPago", SqlDataAccessArgs.CreateWith("@ID_Cliente", user.UserID).And("@Credito", pago.Credito).And("@Fecha", pago.Fecha)
			.And("@ID_TipoPago", (int)pago.TipoPago)
			.And("@Tarjeta", pago.Tarjeta)
			.And("@Banco", pago.Banco)
			.Arguments);
		}
	}
