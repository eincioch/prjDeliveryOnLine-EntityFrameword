///////////////////////////////////////////////////////////
//  Venta.cs
//  Implementation of the Class Venta
//  Generated by Enterprise Architect
//  Created on:      29-Set.-2017 12:43:22
//  Original author: Enrique
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DeliveryOnline.Models;
namespace DeliveryOnline.Models {
	public class Venta {

		private string cCorrelativo;
		private string cSerie;
		private DateTime dFechaPago;
		private DateTime dFechaRegistro;
		private int Id;
		public DeliveryOnline.Models.DocuVentaCorrelativo m_DocuVentaCorrelativo;
		public DeliveryOnline.Models.Pedido m_Pedido;
		public DeliveryOnline.Models.DetalleVenta m_DetalleVenta;
		public DeliveryOnline.Models.Usuario m_Usuario;

		public Venta(){

		}

		~Venta(){

		}

		public int CodigoId{
			get{
				return Id;
			}
			set{
				Id = value;
			}
		}

		public string Correlativo{
			get{
				return cCorrelativo;
			}
			set{
				cCorrelativo = value;
			}
		}

		public DateTime FechaPago{
			get{
				return dFechaPago;
			}
			set{
				dFechaPago = value;
			}
		}

		public DateTime FechaRegistro{
			get{
				return dFechaRegistro;
			}
			set{
				dFechaRegistro = value;
			}
		}

		public string Serie{
			get{
				return cSerie;
			}
			set{
				cSerie = value;
			}
		}

	}//end Venta

}//end namespace Models