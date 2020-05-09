namespace TributoPERU
{
    using System;
    using PX.Data;

    [System.SerializableAttribute()]
    public class xtb10Sunat : Copy,PX.Data.IBqlTable
    {
        #region TExistCD
        public abstract class tExistCD : PX.Data.IBqlField
        {
        }
        protected string _TExistCD;
        [PXDBString(2, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Codigo")]
        public virtual string TExistCD
        {
            get
            {
                return this._TExistCD;
            }
            set
            {
                this._TExistCD = value;
            }
        }
        #endregion
        #region Descr
        public abstract class descr : PX.Data.IBqlField
        {
        }
        protected string _Descr;
        [PXDBString(60, IsUnicode = true)]
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
        #region Equiv
        public abstract class equiv : PX.Data.IBqlField
        {
        }
        protected string _Equiv;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Equiv", Visible = false)]
        public virtual string Equiv
        {
            get
            {
                return this._Equiv;
            }
            set
            {
                this._Equiv = value;
            }
        }
        #endregion
    }
}
