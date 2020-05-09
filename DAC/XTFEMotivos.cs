
using PX.Data;
using System;
namespace TributoPERU
{
    [Serializable]
    public class XTFEMotivos : Copy, IBqlTable
    {
        #region MotivoId
        [PXDBString(5, IsKey = true, IsFixed = true)]
        [PXDefault]
        [PXUIField(DisplayName = "Codigo")]
        public virtual string MotivoId { get; set; }
        public abstract class motivoId : IBqlField { }
        #endregion
        #region Descr
        [PXDBString(60, IsUnicode = true)]
        [PXUIField(DisplayName = "Descripción")]
        public virtual string Descr { get; set; }
        public abstract class descr : IBqlField { }
        #endregion
        #region Tipo
        [PXDBString(3, IsUnicode = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Tipo")]
        [PXStringList(new string[]
                {
                TipoDocumento.AR,
                 TipoDocumento.AR1,
                 TipoDocumento.AR2,
                 TipoDocumento.AR3,
                },
                new string[]
                {
                   "Factura",
                   "Nota Crédito",
                   "Nota Cargo",
                   "Vta Efectivo"
                })]
        public virtual string Tipo { get; set; }
        public abstract class tipo : IBqlField { }
        #endregion

    }

}
