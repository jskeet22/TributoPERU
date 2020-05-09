using PX.Data;
namespace TributoPERU
{
    public class Copy
    {
        #region Erpmatica
        [PXString(50)]
        [PXUIField(DisplayName = "Erpmatica", Visible = false)]
        public virtual string Erpmatica { get; set; }
        public abstract class erpmatica { }
        #endregion

        #region Texto
        [PXString(50)]
        [PXUIField(DisplayName = "Texto", Visible = false)]
        public virtual string Texto { get; set; }
        public abstract class texto { }
        #endregion
    }

}