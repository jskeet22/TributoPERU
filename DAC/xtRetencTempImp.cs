namespace TributoPERU
{
    using System;
    using PX.Data;

    [System.SerializableAttribute()]
    public class xtRetencTempImp : Copy, PX.Data.IBqlTable
    {
        #region BatCD
        public abstract class batCD : PX.Data.IBqlField
        {
        }
        protected string _BatCD;
        [PXDBString(10, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Batch")]
        public virtual string BatCD
        {
            get
            {
                return this._BatCD;
            }
            set
            {
                this._BatCD = value;
            }
        }
        #endregion
        #region RefCD
        public abstract class refCD : PX.Data.IBqlField
        {
        }
        protected string _RefCD;
        [PXDBString(10, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Referencia")]
        public virtual string RefCD
        {
            get
            {
                return this._RefCD;
            }
            set
            {
                this._RefCD = value;
            }
        }
        #endregion
        #region CertNbr
        public abstract class certNbr : PX.Data.IBqlField
        {
        }
        protected string _CertNbr;
        [PXDBString(15, IsFixed = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Nro. Certificado")]
        public virtual string CertNbr
        {
            get
            {
                return this._CertNbr;
            }
            set
            {
                this._CertNbr = value;
            }
        }
        #endregion
        #region name
        public abstract class Name : PX.Data.IBqlField
        {
        }
        protected string _name;
        [PXDBString(60, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Nombre")]
        public virtual string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        #endregion
        #region NumProc
        public abstract class numProc : PX.Data.IBqlField
        {
        }
        protected string _NumProc;
        [PXDBString(10, IsFixed = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Nro.Proceso")]
        public virtual string NumProc
        {
            get
            {
                return this._NumProc;
            }
            set
            {
                this._NumProc = value;
            }
        }
        #endregion
        #region printed
        public abstract class Printed : PX.Data.IBqlField
        {
        }
        protected bool? _printed;
        [PXDBBool()]
        [PXUIField(DisplayName = "Impreso")]
        public virtual bool? printed
        {
            get
            {
                return this._printed;
            }
            set
            {
                this._printed = value;
            }
        }
        #endregion
        #region seleccion
        public abstract class Seleccion : PX.Data.IBqlField
        {
        }
        protected bool? _seleccion;
        [PXDBBool()]
        [PXUIField(DisplayName = "selec")]
        public virtual bool? seleccion
        {
            get
            {
                return this._seleccion;
            }
            set
            {
                this._seleccion = value;
            }
        }
        #endregion
        #region TaxAmt
        public abstract class taxAmt : PX.Data.IBqlField
        {
        }
        protected double? _TaxAmt;
        [PXDBDouble(2)]
        [PXDefault(0.0)]
        [PXUIField(DisplayName = "Monto")]
        public virtual double? TaxAmt
        {
            get
            {
                return this._TaxAmt;
            }
            set
            {
                this._TaxAmt = value;
            }
        }
        #endregion
        #region VendId
        public abstract class vendId : PX.Data.IBqlField
        {
        }
        protected string _VendId;
        [PXDBString(15, IsFixed = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "VendId")]
        public virtual string VendId
        {
            get
            {
                return this._VendId;
            }
            set
            {
                this._VendId = value;
            }
        }
        #endregion
        #region tstamp
        public abstract class Tstamp : PX.Data.IBqlField
        {
        }
        protected byte[] _tstamp;
        [PXDBTimestamp()]
        public virtual byte[] tstamp
        {
            get
            {
                return this._tstamp;
            }
            set
            {
                this._tstamp = value;
            }
        }
        #endregion
    }
}
