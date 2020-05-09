namespace TributoPERU
{
    using System;
    using PX.Data;
    using PX.Objects.CA;

    [System.SerializableAttribute()]
    public class xtb01Sunat : Copy, PX.Data.IBqlTable
    {
        #region Codigo
        public abstract class codigo : PX.Data.IBqlField
        {
        }
        protected string _Codigo;
        [PXDBString(3, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Codigo")]
        public virtual string Codigo
        {
            get
            {
                return this._Codigo;
            }
            set
            {
                this._Codigo = value;
            }
        }
        #endregion
        #region Descripcion
        public abstract class descripcion : PX.Data.IBqlField
        {
        }
        protected string _Descripcion;
        [PXDBString(50, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Descripción")]
        public virtual string Descripcion
        {
            get
            {
                return this._Descripcion;
            }
            set
            {
                this._Descripcion = value;
            }
        }
        #endregion
        #region Metodpago
        public abstract class metodpago : PX.Data.IBqlField
        {
        }
        protected string _Metodpago;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Metodpago")]
        [PXSelector(typeof(PaymentMethod.paymentMethodID),
        typeof(PaymentMethod.paymentMethodID))]
        public virtual string Metodpago
        {
            get
            {
                return this._Metodpago;
            }
            set
            {
                this._Metodpago = value;
            }
        }
        #endregion
    }
}
