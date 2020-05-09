namespace TributoPERU
{
	using System;
	using PX.Data;
	
	[System.SerializableAttribute()]
	public class xFEInvoiceC : PX.Data.IBqlTable
	{
		#region DocType
		public abstract class docType : PX.Data.IBqlField
		{
		}
		protected string _DocType;
		[PXDBString(3, IsFixed = true)]
		[PXDefault()]
		[PXUIField(DisplayName = "DocType")]
		public virtual string DocType
		{
			get
			{
				return this._DocType;
			}
			set
			{
				this._DocType = value;
			}
		}
		#endregion
		#region RefNbr
		public abstract class refNbr : PX.Data.IBqlField
		{
		}
		protected string _RefNbr;
		[PXDBString(15, IsUnicode = true)]
		[PXDefault()]
		[PXUIField(DisplayName = "RefNbr")]
		public virtual string RefNbr
		{
			get
			{
				return this._RefNbr;
			}
			set
			{
				this._RefNbr = value;
			}
		}
		#endregion
		#region ID
		public abstract class iD : PX.Data.IBqlField
		{
		}
		protected int? _ID;
		[PXDBIdentity()]
		[PXUIField(Enabled = false)]
		public virtual int? ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}
		#endregion
		#region origenid
		public abstract class Origenid : PX.Data.IBqlField
		{
		}
		protected string _origenid;
		[PXDBString(4, IsUnicode = true)]
		[PXUIField(DisplayName = "origenid")]
		public virtual string origenid
		{
			get
			{
				return this._origenid;
			}
			set
			{
				this._origenid = value;
			}
		}
        #endregion
        #region fecha
        public abstract class Fecha : PX.Data.IBqlField
        {
        }
        protected string _fecha;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "fecha")]
        public virtual string fecha
        {
            get
            {
                return this._fecha;
            }
            set
            {
                this._fecha = value;
            }
        }
        #endregion
        #region tipo
        public abstract class Tipo : PX.Data.IBqlField
		{
		}
		protected string _tipo;
		[PXDBString(2, IsUnicode = true)]
		[PXDefault("")]
		[PXUIField(DisplayName = "tipo")]
		public virtual string tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				this._tipo = value;
			}
		}
		#endregion
		#region nrocomprobante
		public abstract class Nrocomprobante : PX.Data.IBqlField
		{
		}
		protected string _nrocomprobante;
		[PXDBString(13, IsUnicode = true)]
		[PXDefault("")]
		[PXUIField(DisplayName = "nrocomprobante")]
		public virtual string nrocomprobante
		{
			get
			{
				return this._nrocomprobante;
			}
			set
			{
				this._nrocomprobante = value;
			}
		}
		#endregion
		#region comprobante
		public abstract class Comprobante : PX.Data.IBqlField
		{
		}
		protected string _comprobante;
		[PXDBString(-1, IsUnicode = true)]
		[PXDefault("")]
		[PXUIField(DisplayName = "comprobante")]
		public virtual string comprobante
		{
			get
			{
				return this._comprobante;
			}
			set
			{
				this._comprobante = value;
			}
		}
		#endregion
		#region nombrearchivo
		public abstract class Nombrearchivo : PX.Data.IBqlField
		{
		}
		protected string _nombrearchivo;
		[PXDBString(50, IsUnicode = true)]
		[PXDefault("")]
		[PXUIField(DisplayName = "nombrearchivo")]
		public virtual string nombrearchivo
		{
			get
			{
				return this._nombrearchivo;
			}
			set
			{
				this._nombrearchivo = value;
			}
		}
		#endregion
		#region hash
		public abstract class Hash : PX.Data.IBqlField
		{
		}
		protected string _hash;
		[PXDBString(50, IsUnicode = true)]
		[PXUIField(DisplayName = "hash")]
		public virtual string hash
		{
			get
			{
				return this._hash;
			}
			set
			{
				this._hash = value;
			}
		}
		#endregion
		#region codbarra
		public abstract class Codbarra : PX.Data.IBqlField
		{
		}
		protected byte[] _codbarra;
		[PXDBBinary()]
		[PXUIField(DisplayName = "codbarra")]
		public virtual byte[] codbarra
		{
			get
			{
				return this._codbarra;
			}
			set
			{
				this._codbarra = value;
			}
		}
		#endregion
		#region cadenacb
		public abstract class Cadenacb : PX.Data.IBqlField
		{
		}
		protected string _cadenacb;
		[PXDBString(1000, IsUnicode = true)]
		[PXUIField(DisplayName = "cadenacb")]
		public virtual string cadenacb
		{
			get
			{
				return this._cadenacb;
			}
			set
			{
				this._cadenacb = value;
			}
		}
		#endregion
		#region estado
		public abstract class Estado : PX.Data.IBqlField
		{
		}
		protected string _estado;
		[PXDBString(2, IsUnicode = true)]
		[PXUIField(DisplayName = "estado")]
		public virtual string estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				this._estado = value;
			}
		}
		#endregion
		#region enviado
		public abstract class Enviado : PX.Data.IBqlField
		{
		}
		protected int? _enviado;
		[PXDBInt()]
		[PXDefault(0)]
		[PXUIField(DisplayName = "enviado")]
		public virtual int? enviado
		{
			get
			{
				return this._enviado;
			}
			set
			{
				this._enviado = value;
			}
		}
		#endregion
		#region procesado
		public abstract class Procesado : PX.Data.IBqlField
		{
		}
		protected int? _procesado;
		[PXDBInt()]
		[PXDefault(0)]
		[PXUIField(DisplayName = "procesado")]
		public virtual int? procesado
		{
			get
			{
				return this._procesado;
			}
			set
			{
				this._procesado = value;
			}
		}
		#endregion
		#region observaciones
		public abstract class Observaciones : PX.Data.IBqlField
		{
		}
		protected string _observaciones;
		[PXDBString(-1)]
		[PXUIField(DisplayName = "observaciones")]
		public virtual string observaciones
		{
			get
			{
				return this._observaciones;
			}
			set
			{
				this._observaciones = value;
			}
		}
		#endregion
	}
}
