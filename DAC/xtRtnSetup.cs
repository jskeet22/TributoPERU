namespace TributoPERU
{
    using PX.Data;
    using PX.Objects.GL;
    using System;

    [System.SerializableAttribute()]
    public class xtRtnSetup : Copy, PX.Data.IBqlTable
    {
        #region Acct
        public abstract class acct : PX.Data.IBqlField
        {
        }
        protected string _Acct;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Cuenta")]
        [PXSelector(typeof(Account.accountCD),
                    typeof(Account.accountCD),
                    typeof(Account.description),
        DescriptionField = typeof(Account.description))]
        public virtual string Acct
        {
            get
            {
                return this._Acct;
            }
            set
            {
                this._Acct = value;
            }
        }
        #endregion
        #region SubAcct
        public abstract class subAcct : PX.Data.BQL.BqlInt.Field<subAcct> { }
        protected Int32? _SubAcct;
        [PXDefault("")]
        [PXUIField(DisplayName = "SubCuenta")]
        [SubAccount]
        public virtual Int32? SubAcct
        {
            get
            {
                return this._SubAcct;
            }
            set
            {
                this._SubAcct = value;
            }
        }
        #endregion
        #region LastInvcNbr
        public abstract class lastInvcNbr : PX.Data.IBqlField
        {
        }
        protected string _LastInvcNbr;
        [PXDBString(15, IsUnicode = true)]
        [PXDefault("00000000")]
        [PXUIField(DisplayName = "Ultimo # de Certificado")]
        public virtual string LastInvcNbr
        {
            get
            {
                return this._LastInvcNbr;
            }
            set
            {
                this._LastInvcNbr = value;
            }
        }
        #endregion
        #region LastRefNbr
        public abstract class lastRefNbr : PX.Data.IBqlField
        {
        }
        protected string _LastRefNbr;
        [PXDBString(15, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Ultimo # Doc. Ajuste")]
        public virtual string LastRefNbr
        {
            get
            {
                return this._LastRefNbr;
            }
            set
            {
                this._LastRefNbr = value;
            }
        }
        #endregion
        #region LimitAmt
        public abstract class limitAmt : PX.Data.IBqlField
        {
        }
        protected double? _LimitAmt;
        [PXDBDouble(2)]
        [PXDefault(0.0)]
        [PXUIField(DisplayName = "Monto minimo")]
        public virtual double? LimitAmt
        {
            get
            {
                return this._LimitAmt;
            }
            set
            {
                this._LimitAmt = value;
            }
        }
        #endregion
        #region Percentage
        public abstract class percentage : PX.Data.IBqlField
        {
        }
        protected double? _Percentage;
        [PXDBDouble(2)]
        [PXDefault(0.0)]
        [PXUIField(DisplayName = "Percentage")]
        public virtual double? Percentage
        {
            get
            {
                return this._Percentage;
            }
            set
            {
                this._Percentage = value;
            }
        }
        #endregion
        #region CtrlNbr
        public abstract class ctrlNbr : PX.Data.IBqlField
        {
        }
        protected string _CtrlNbr;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "CtrlNbr")]
        public virtual string CtrlNbr
        {
            get
            {
                return this._CtrlNbr;
            }
            set
            {
                this._CtrlNbr = value;
            }
        }
        #endregion
        #region SntSerieDel
        public abstract class sntSerieDel : PX.Data.IBqlField
        {
        }
        protected string _SntSerieDel;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault("0000")]
        [PXUIField(DisplayName = "Serie # de Certificado")]
        public virtual string SntSerieDel
        {
            get
            {
                return this._SntSerieDel;
            }
            set
            {
                this._SntSerieDel = value;
            }
        }
        #endregion
        #region SntSerieAl
        public abstract class sntSerieAl : PX.Data.IBqlField
        {
        }
        protected string _SntSerieAl;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Serie Al")]
        public virtual string SntSerieAl
        {
            get
            {
                return this._SntSerieAl;
            }
            set
            {
                this._SntSerieAl = value;
            }
        }
        #endregion
        #region SntNroAutoriz
        public abstract class sntNroAutoriz : PX.Data.IBqlField
        {
        }
        protected string _SntNroAutoriz;
        [PXDBString(15, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Autorizacion Sunat")]
        public virtual string SntNroAutoriz
        {
            get
            {
                return this._SntNroAutoriz;
            }
            set
            {
                this._SntNroAutoriz = value;
            }
        }
        #endregion
        #region SntFecAutoriz
        public abstract class sntFecAutoriz : PX.Data.IBqlField
        {
        }
        protected DateTime? _SntFecAutoriz;
        [PXDBDate()]
        [PXDefault(TypeCode.DateTime, "01/01/1900")]
        [PXUIField(DisplayName = "Fecha de Autorizacion")]
        public virtual DateTime? SntFecAutoriz
        {
            get
            {
                return this._SntFecAutoriz;
            }
            set
            {
                this._SntFecAutoriz = value;
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
