namespace TributoPERU
{
    using PX.Data;

    [System.SerializableAttribute()]
    public class xtb05Sunat : Copy, PX.Data.IBqlTable
    {
        #region AduCD
        public abstract class aduCD : PX.Data.IBqlField
        {
        }
        protected string _AduCD;
        [PXDBString(3, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Codigo", IsReadOnly = false)]
        public virtual string AduCD
        {
            get
            {
                return this._AduCD;
            }
            set
            {
                this._AduCD = value;
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
