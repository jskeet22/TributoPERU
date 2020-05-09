namespace TributoPERU
{
    using System;
    using PX.Data;

    [System.SerializableAttribute()]
    public class xtb25Sunat : Copy, PX.Data.IBqlTable
    {
        #region CodigoCD
        public abstract class codigoCD : PX.Data.IBqlField
        {
        }
        protected string _CodigoCD;
        [PXDBString(2, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Codigo")]
        public virtual string CodigoCD
        {
            get
            {
                return this._CodigoCD;
            }
            set
            {
                this._CodigoCD = value;
            }
        }
        #endregion
        #region Descr
        public abstract class descr : PX.Data.IBqlField
        {
        }
        protected string _Descr;
        [PXDBString(50, IsFixed = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Descripción")]
        public virtual string Descr
        {
            get
            {
                return this._Descr;
            }
            set
            {
                this._Descr = value;
            }
        }
        #endregion
    }
}
