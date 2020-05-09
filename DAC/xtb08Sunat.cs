namespace TributoPERU
{
    using System;
    using PX.Data;
    using PX.Objects.TX;

    [System.SerializableAttribute()]
    public class xtb08Sunat : Copy, PX.Data.IBqlTable
    {
        #region TGdsSvcsCD
        public abstract class tGdsSvcsCD : PX.Data.IBqlField
        {
        }
        protected string _TGdsSvcsCD;
        [PXDBString(5, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Codigo")]
        public virtual string TGdsSvcsCD
        {
            get
            {
                return this._TGdsSvcsCD;
            }
            set
            {
                this._TGdsSvcsCD = value;
            }
        }
        #endregion
        #region TaxCD
        public abstract class taxCD : PX.Data.IBqlField
        {
        }
        protected string _TaxCD;
        [PXDBString(30, IsUnicode = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Impuesto")]
        [PXSelector(
            typeof(Tax.taxID),
            typeof(Tax.taxID),
            typeof(Tax.descr))]
        public virtual string TaxCD
        {
            get
            {
                return this._TaxCD;
            }
            set
            {
                this._TaxCD = value;
            }
        }
        #endregion
        #region Descr
        public abstract class descr : PX.Data.IBqlField
        {
        }
        protected string _Descr;
        [PXDBString(30, IsUnicode = true)]
        [PXDefault("")]
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
