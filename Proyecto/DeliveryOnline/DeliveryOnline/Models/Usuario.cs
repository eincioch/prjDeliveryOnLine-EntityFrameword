///////////////////////////////////////////////////////////
//  Usuario.cs
//  Implementation of the Class Usuario
//  Generated by Enterprise Architect
//  Created on:      29-Set.-2017 12:43:22
//  Original author: Enrique Incio Ch
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DeliveryOnline.Models;
namespace DeliveryOnline.Models {
	public class Usuario {

		private string cApellidos;
		private string cDireccion;
		private string cEmail;
		private string cFonoCelular;
		private string cNombre;
		private string cPassword;
		private string cUsuario;
		private int Id = 0;
		public DeliveryOnline.Models.TipoCliente m_TipoCliente;
		public DeliveryOnline.Models.TiendaUsuario m_TiendaUsuario;


		public string Usuario{
			get{
				return cUsuario;
			}
			set{
                cUsuario = value;
			}
		}

		public string Apellidos{
			get{
				return cApellidos;
			}
			set{
				cApellidos = value;
			}
		}

		public int CodigoId{
			get{
				return Id;
			}
			set{
				Id = value;
			}
		}

		public string Direccion{
			get{
				return cDireccion;
			}
			set{
				cDireccion = value;
			}
		}

		public string Direcci�n{
			get{
				return cDirecci�n;
			}
			set{
				cDirecci�n = value;
			}
		}

		public string Email{
			get{
				return cEmail;
			}
			set{
				cEmail = value;
			}
		}

		public string FonoCelular{
			get{
				return cFonoCelular;
			}
			set{
				cFonoCelular = value;
			}
		}

		public string Nombre{
			get{
				return cNombre;
			}
			set{
				cNombre = value;
			}
		}

		public string Password{
			get{
				return cpassword;
			}
			set{
				cpassword = value;
			}
		}

	}//end Usuario

}//end namespace Models