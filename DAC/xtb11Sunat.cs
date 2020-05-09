namespace TributoPERU
{
    using System;
    using PX.Data;

    [System.SerializableAttribute()]
    public class xtb11Sunat : Copy, PX.Data.IBqlTable
    {
        #region CunidCD
        public abstract class cunidCD : PX.Data.IBqlField
        {
        }
        protected string _CunidCD;
        [PXDBString(5, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Código")]
        public virtual string CunidCD
        {
            get

            {
                return this._CunidCD;
            }
            set

            {
                this._CunidCD = value;
            }
        }
        #endregion
        #region Descr
        public abstract class descr : PX.Data.IBqlField
        {
        }
        protected string _Descr;
        [PXDBString(60, IsFixed = true)]
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
