///////////////////////////////////////////////////////////
//  TiposMenu.cs
//  Implementation of the Class TiposMenu
//  Generated by Enterprise Architect
//  Created on:      30-Set.-2017 12:37:44
//  Original author: Enrique
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DeliveryOnline.Models {

    [Table("TiposMenu", Schema = "Producto")]
    public class TiposMenu {

		private string cDescripcion;
		private int Id;

		public TiposMenu(){

		}

		~TiposMenu(){

		}

        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoId{
			get{
				return Id;
			}
			set{
				Id = value;
			}
		}

        [Required]
        [Column("Descripcion", TypeName = "varchar", Order = 2)]
        [MaxLength(250), MinLength(10)]
        [DisplayName("Descripción")]
        public string Descripcion{
			get{
				return cDescripcion;
			}
			set{
				cDescripcion = value;
			}
		}

	}//end TiposMenu

}//end namespace Models