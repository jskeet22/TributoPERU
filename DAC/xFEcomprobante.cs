using System;
using PX.Data;

namespace TributoPERU
{
	[Serializable]
	public class xFEcomprobante : IBqlTable
	{
		#region DocType
		[PXDBString(3, IsKey = true, IsFixed = true, InputMask = "")]
		[PXUIField(DisplayName = "Doc Type")]
		public virtual string DocType { get; set; }
		public abstract class docType : IBqlField { }
		#endregion

		#region RefNbr
		[PXDBString(15, IsKey = true, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Ref Nbr")]
		public virtual string RefNbr { get; set; }
		public abstract class refNbr : IBqlField { }
		#endregion

		#region Id
		[PXDBIdentity(IsKey = true)]
		[PXUIField(DisplayName = "Id")]
		public virtual int? Id { get; set; }
		public abstract class id : IBqlField { }
		#endregion

		#region Emisorid
		[PXDBInt()]
		[PXUIField(DisplayName = "Emisorid")]
		public virtual int? Emisorid { get; set; }
		public abstract class emisorid : IBqlField { }
		#endregion

		#region Origenid
		[PXDBString(4, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Origenid")]
		public virtual string Origenid { get; set; }
		public abstract class origenid : IBqlField { }
		#endregion

		#region Fecha
		[PXDBString(10, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Fecha")]
		public virtual string Fecha { get; set; }
		public abstract class fecha : IBqlField { }
		#endregion

		#region Tipo
		[PXDBString(2, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Tipo")]
		public virtual string Tipo { get; set; }
		public abstract class tipo : IBqlField { }
		#endregion

		#region Nrocomprobante
		[PXDBString(13, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Nrocomprobante")]
		public virtual string Nrocomprobante { get; set; }
		public abstract class nrocomprobante : IBqlField { }
		#endregion

		#region Comprobante
		[PXDBString(IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Comprobante")]
		public virtual string Comprobante { get; set; }
		public abstract class comprobante : IBqlField { }
		#endregion

		#region Nombrearchivo
		[PXDBString(50, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Nombrearchivo")]
		public virtual string Nombrearchivo { get; set; }
		public abstract class nombrearchivo : IBqlField { }
		#endregion

		#region Hash
		[PXDBString(50, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Hash")]
		public virtual string Hash { get; set; }
		public abstract class hash : IBqlField { }
		#endregion

		#region Estado
		[PXDBString(2, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Estado")]
		public virtual string Estado { get; set; }
		public abstract class estado : IBqlField { }
		#endregion

		#region Procesado
		[PXDBInt()]
		[PXUIField(DisplayName = "Procesado")]
		public virtual int? Procesado { get; set; }
		public abstract class procesado : IBqlField { }
		#endregion

		#region Enviado
		[PXDBInt()]
		[PXUIField(DisplayName = "Enviado")]
		public virtual int? Enviado { get; set; }
		public abstract class enviado : IBqlField { }
		#endregion

		#region Observaciones
		[PXDBString(InputMask = "")]
		[PXUIField(DisplayName = "Observaciones")]
		public virtual string Observaciones { get; set; }
		public abstract class observaciones : IBqlField { }
		#endregion

		#region Cadenacb
		[PXDBString(1000, IsUnicode = true, InputMask = "")]
		[PXUIField(DisplayName = "Cadenacb")]
		public virtual string Cadenacb { get; set; }
		public abstract class cadenacb : IBqlField { }
		#endregion
	}
}