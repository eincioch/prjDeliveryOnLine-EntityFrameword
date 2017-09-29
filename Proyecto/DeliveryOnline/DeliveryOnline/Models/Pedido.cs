///////////////////////////////////////////////////////////
//  Pedido.cs
//  Implementation of the Class Pedido
//  Generated by Enterprise Architect
//  Created on:      29-Set.-2017 12:43:21
//  Original author: Enrique
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DeliveryOnline.Models;
namespace DeliveryOnline.Models {
	public class Pedido {

		private DateTime dFechaHoraEntrega;
		private DateTime dFechaHoraRegistro;
		private int Id;
		private int nEstado;
		public DeliveryOnline.Models.DetallePedido m_DetallePedido;
		public DeliveryOnline.Models.Usuario m_Usuario;

		public Pedido(){

		}


		public int CodigoId{
			get{
				return Id;
			}
			set{
				Id = value;
			}
		}

		public int Estado{
			get{
				return nEstado;
			}
			set{
				nEstado = value;
			}
		}

		public DateTime FechaHoraEntrega{
			get{
				return dFechaHoraEntrega;
			}
			set{
				dFechaHoraEntrega = value;
			}
		}

		public DateTime FechaHoraRegistro{
			get{
				return dFechaHoraRegistro;
			}
			set{
				dFechaHoraRegistro = value;
			}
		}

	}//end Pedido

}//end namespace Models