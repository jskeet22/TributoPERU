namespace TributoPERU
{
    using System;
    using PX.Data;
    using PX.Objects.GL;


    [System.SerializableAttribute()]
    public class xLocEquivalAcct : Copy, PX.Data.IBqlTable
    {
        #region AcctCD
        public abstract class acctCD : PX.Data.IBqlField
        {
        }
        protected string _AcctCD;
        [PXDBString(10, IsUnicode = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Cuenta")]
        [PXSelector(typeof(Account.accountCD),
        typeof(Account.accountCD),
        typeof(Account.description))]
        public virtual string AcctCD
        {
            get
            {
                return this._AcctCD;
            }
            set
            {
                this._AcctCD = value;
            }
        }
        #endregion
        #region CRSubCD
        public abstract class cRSubCD : PX.Data.IBqlField
        {
        }
        protected string _CRSubCD;
        [PXDBString(24, IsUnicode = true, IsKey = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "SubCuenta", Visibility = PXUIVisibility.SelectorVisible)]
        [PXSelector(typeof(Sub.subCD),
                    typeof(Sub.subCD),
                    typeof(Sub.description))]
        public virtual string CRSubCD
        {
            get
            {
                return this._CRSubCD;
            }
            set
            {
                this._CRSubCD = value;
            }
        }
        #endregion
        #region DRAcct
        public abstract class dRAcct : PX.Data.IBqlField
        {
        }
        protected string _DRAcct;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Cuenta Equivalente")]
        [PXSelector(typeof(Account.accountCD),
                    typeof(Account.accountCD),
                    typeof(Account.description))]
        public virtual string DRAcct
        {
            get
            {
                return this._DRAcct;
            }
            set
            {
                this._DRAcct = value;
            }
        }
        #endregion
        #region CRAcct
        public abstract class cRAcct : PX.Data.IBqlField
        {
        }
        protected string _CRAcct;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Contra Cuenta Equivalente")]
        [PXSelector(typeof(Account.accountCD),
                    typeof(Account.accountCD),
                    typeof(Account.description))]
        public virtual string CRAcct
        {
            get
            {
                return this._CRAcct;
            }
            set
            {
                this._CRAcct = value;
            }
        }
        #endregion
        #region Active
        public abstract class active : PX.Data.IBqlField
        {
        }
        protected Boolean? _Active;       
		[PXDBBool()]
        [PXDefault(true)]
        [PXUIField(DisplayName = "Active", Visibility = PXUIVisibility.Visible)]
        public virtual Boolean? Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                this._Active = value;
            }
        }
        #endregion
        #region CreatedByID
        public abstract class createdByID : PX.Data.IBqlField
        {
        }
        protected Guid? _CreatedByID;
        [PXDBCreatedByID()]
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
        #region LastModifiedByID
        public abstract class lastModifiedByID : PX.Data.IBqlField
        {
        }
        protected Guid? _LastModifiedByID;
        [PXDBLastModifiedByID()]
        [PXUIField(DisplayName = "Modificado Por", Enabled = false)]
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
        #region CreatedDateTime
        public abstract class createdDateTime : PX.Data.IBqlField
        {
        }
        protected DateTime? _CreatedDateTime;
        [PXUIField(DisplayName = "F.Creacion", Enabled = false)]
        [PXDBCreatedDateTime()]
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
        #region LineNbr
        public abstract class lineNbr : PX.Data.IBqlField
        {
        }
        protected short? _LineNbr;
        [PXDBShort()]
        [PXDefault((short)0)]
        [PXUIField(DisplayName = "LineNbr", Visible = false)]
        public virtual short? LineNbr
        {
            get
            {
                return this._LineNbr;
            }
            set
            {
                this._LineNbr = value;
            }
        }
        #endregion
        #region Status
        public abstract class status : PX.Data.IBqlField
        {
        }
        protected string _Status;
        [PXDBString(1, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Status", Visible = false)]
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
        #region LastModifiedDateTime
        public abstract class lastModifiedDateTime : PX.Data.IBqlField
        {
        }
        protected DateTime? _LastModifiedDateTime;
        [PXUIField(DisplayName = "F.Modificación", Enabled = false)]
        [PXDBLastModifiedDateTime()]
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
        #region CuentaCD
        public abstract class cuentaCD : PX.Data.IBqlField
        {
        }
        protected string _CuentaCD;
        [PXDBString(9, IsUnicode = true)]

        [PXDefault(typeof(xLocEquivalAcct.cuentaCD))]
        [PXUIField(DisplayName = "Tipo Cuenta")]       
        [PXStringList(new string[]
        {
        TipoCuentas.C,
        TipoCuentas.CC
        },
        new string[]
        {
        "Cuentas",
        "SubCuenta"
          })]
        public virtual string CuentaCD
        {
            get
            {

                return this._CuentaCD;
            }
            set
            {

                this._CuentaCD = value;
            }
        }
        #endregion
    }
    public static class TipoCuentas
    {
        public const string C = "Cuentas";
        public const string CC = "SubCuenta";

    }
}
