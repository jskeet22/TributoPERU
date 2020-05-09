namespace TributoPERU
{
    using System;
    using PX.Data;

    [System.SerializableAttribute()]
    public class xtb09Sunat : Copy, PX.Data.IBqlTable
    {
        #region TOperDetCD
        public abstract class tOperDetCD : PX.Data.IBqlField
        {
        }
        protected string _TOperDetCD;
        [PXDBString(2, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Codigo", IsReadOnly = false)]

        public virtual string TOperDetCD
        {
            get
            {
                return this._TOperDetCD;
            }
            set
            {
                this._TOperDetCD = value;
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
    }
}
