///////////////////////////////////////////////////////////
//  DetalleCompra.cs
//  Implementation of the Class DetalleCompra
//  Generated by Enterprise Architect
//  Created on:      29-Set.-2017 12:43:21
//  Original author: Enrique Incio Ch.
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DeliveryOnline.Models;
namespace DeliveryOnline.Models {
	public class DetalleCompra {

		private Double nCantidad;
		private Double nPrecio;
		public DeliveryOnline.Models.Insumo m_Insumo;

		public DetalleCompra(){

		}


		public Double Cantidad{
			get{
				return nCantidad;
			}
			set{
				nCantidad = value;
			}
		}

		public Double Precio{
			get{
				return nPrecio;
			}
			set{
				nPrecio = value;
			}
		}

	}//end DetalleCompra

}//end namespace Models