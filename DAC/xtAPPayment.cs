namespace TributoPERU
{
    using PX.Data;
    using PX.Objects.AP;

    [PXTable(typeof(APPayment.docType), typeof(APPayment.refNbr), IsOptional = true)]
    public class xtAPPayment : PXCacheExtension<APPayment>
    {
        #region TMedioPago
        public abstract class tMedioPago : PX.Data.IBqlField
        {
        }
        protected string _TMedioPago;
        [PXDBString(10, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "T.Medio.Pago", Visibility = PXUIVisibility.SelectorVisible)]  
        public virtual string TMedioPago
        {
            get
            {
                return this._TMedioPago;
            }
            set
            {
                this._TMedioPago = value;
            }
        }
        #endregion
    }
}
