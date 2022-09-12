using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Coache.Common;
using Data;

namespace Coache.Business;

public class GiftCardManager
{
	public BindingList<GiftCard> GetAll(Cliente clienteOrigen)
	{
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetGiftCardCliente", SqlDataAccessArgs.CreateWith("@ID_Cliente", clienteOrigen.UserID).Arguments);
		BindingList<GiftCard> bindingList = new BindingList<GiftCard>();
		if (dataTable != null && dataTable.Rows != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				bindingList.Add(new GiftCard
				{
					Credito = double.Parse(row["Credito"].ToString()),
					Fecha = Convert.ToDateTime(row["Fecha"]),
					ClienteOrigen = new Cliente
					{
						UserName = row["ClienteOrigen"].ToString()
					},
					ClienteDestino = new Cliente
					{
						UserName = row["ClienteDestino"].ToString()
					}
				});
			}
			return bindingList;
		}
		return bindingList;
	}

	public int Add(GiftCard giftCard)
	{
		return SqlDataAccess.ExecuteScalarQuery<int>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertGiftCard", SqlDataAccessArgs.CreateWith("@ID_ClienteOrigen", giftCard.ClienteOrigen.UserID).And("@ID_ClienteDestino", giftCard.ClienteDestino.UserID).And("@Credito", giftCard.Credito)
			.And("@Fecha", giftCard.Fecha)
			.Arguments);
		}

		public List<double> GetMontos()
		{
			return new List<double> { 20.0, 50.0, 100.0 };
		}
	}
