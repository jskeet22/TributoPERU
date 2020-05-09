using PX.Data;
using System;
namespace TributoPERU
{
    [System.SerializableAttribute()]
    public class xAcDetrac : PX.Data.IBqlTable
    {
        #region DocType
        public abstract class docType : PX.Data.IBqlField
        {
        }
        protected string _DocType;
        [PXDBString(3)]
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
        [PXDBString(15)]
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
        #region IsExported
        public abstract class isExported : PX.Data.IBqlField
        {
        }
        protected bool? _IsExported;
        [PXDBBool()]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = " ", Enabled = false)]
        public virtual bool? IsExported
        {
            get
            {
                return this._IsExported;
            }
            set
            {
                this._IsExported = value;
            }
        }
        #endregion
        #region BatchAutoNbr
        public abstract class batchAutoNbr : PX.Data.IBqlField
        {
        }
        protected string _BatchAutoNbr;
        [PXDBString(6)]
        [PXUIField(DisplayName = "BatchAutoNbr")]
        public virtual string BatchAutoNbr
        {
            get
            {
                return this._BatchAutoNbr;
            }
            set
            {
                this._BatchAutoNbr = value;
            }
        }
        #endregion
        #region DepositDate
        public abstract class depositDate : PX.Data.IBqlField
        {
        }
        protected DateTime? _DepositDate;
        [PXDBDate()]
        [PXDefault(TypeCode.DateTime, "01/01/1900")]
        [PXUIField(DisplayName = "Fecha Depósito")]
        public virtual DateTime? DepositDate
        {
            get
            {
                return this._DepositDate;
            }
            set
            {
                this._DepositDate = value;
            }
        }
        #endregion
        #region DepositNbr
        public abstract class depositNbr : PX.Data.IBqlField
        {
        }
        protected string _DepositNbr;
        [PXDBString(30)]
        [PXDefault("")]
        [PXUIField(DisplayName = "No. Depósito")]
        public virtual string DepositNbr
        {
            get
            {
                return this._DepositNbr;
            }
            set
            {
                this._DepositNbr = value;
            }
        }
        #endregion
        #region DateApply
        public abstract class dateApply : PX.Data.IBqlField
        {
        }
        protected DateTime? _DateApply;
        [PXDBDate()]
        [PXDefault(TypeCode.DateTime, "01/01/1900")]
        [PXUIField(DisplayName = "Fecha Pago")]
        public virtual DateTime? DateApply
        {
            get
            {
                return this._DateApply;
            }
            set
            {
                this._DateApply = value;
            }
        }
        #endregion
        #region DocAmt
        public abstract class docAmt : PX.Data.IBqlField
        {
        }
        protected decimal? _DocAmt;
        [PXDBDecimal(2)]
        [PXDefault(TypeCode.Decimal, "0.0")]
        [PXUIField(DisplayName = "Monto Detrac.")]
        public virtual decimal? DocAmt
        {
            get
            {
                return this._DocAmt;
            }
            set
            {
                this._DocAmt = value;
            }
        }
        #endregion
        #region PARefNbr
        public abstract class pARefNbr : PX.Data.IBqlField
        {
        }
        protected string _PARefNbr;
        [PXDBString(30, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Referencia Pago")]
        public virtual string PARefNbr
        {
            get
            {
                return this._PARefNbr;
            }
            set
            {
                this._PARefNbr = value;
            }
        }
        #endregion
        #region Status
        public abstract class status : PX.Data.IBqlField
        {
        }
        protected string _Status;
        [PXDBString(2)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Estado")]
        public virtual string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this._Status = value;
            }
        }
        #endregion
        #region TranDate
        public abstract class tranDate : PX.Data.IBqlField
        {
        }
        protected DateTime? _TranDate;
        [PXDBDate()]
        [PXDefault(typeof(AccessInfo.businessDate))]
        [PXUIField(DisplayName = "Fecha Transac.")]
        public virtual DateTime? TranDate
        {
            get
            {
                return this._TranDate;
            }
            set
            {
                this._TranDate = value;
            }
        }
        #endregion
        #region CreatedByID
        public abstract class createdByID : PX.Data.IBqlField
        {
        }
        protected Guid? _CreatedByID;
        [PXDBCreatedByID()]
        [PXUIField(DisplayName = "CreatedByID")]
        public virtual Guid? CreatedByID
        {
            get
            {
                return this._CreatedByID;
            }
            set
            {
                this._CreatedByID = value;
            }
        }
        #endregion
        #region CreatedDateTime
        public abstract class createdDateTime : PX.Data.IBqlField
        {
        }
        protected DateTime? _CreatedDateTime;
        [PXDBCreatedDateTime()]
        [PXUIField(DisplayName = "Created Date Time")]
        public virtual DateTime? CreatedDateTime
        {
            get
            {
                return this._CreatedDateTime;
            }
            set
            {
                this._CreatedDateTime = value;
            }
        }
        #endregion
        #region LastModifiedByID
        public abstract class lastModifiedByID : PX.Data.IBqlField
        {
        }
        protected Guid? _LastModifiedByID;
        [PXDBLastModifiedByID()]
        public virtual Guid? LastModifiedByID
        {
            get
            {
                return this._LastModifiedByID;
            }
            set
            {
                this._LastModifiedByID = value;
            }
        }
        #endregion
        #region LastModifiedDateTime
        public abstract class lastModifiedDateTime : PX.Data.IBqlField
        {
        }
        protected DateTime? _LastModifiedDateTime;
        [PXDBLastModifiedDateTime()]
        [PXUIField(DisplayName = "Last Modified Date Time")]
        public virtual DateTime? LastModifiedDateTime
        {
            get
            {
                return this._LastModifiedDateTime;
            }
            set
            {
                this._LastModifiedDateTime = value;
            }
        }
        #endregion
    }
}
