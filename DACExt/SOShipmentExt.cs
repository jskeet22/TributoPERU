using PX.Data;
using TributoPERU;

namespace PX.Objects.SO
{
    // Acuminator disable once PX1011 InheritanceFromPXCacheExtension [Justification]
    public class SOShipmentExt : PXCacheExtension<PX.Objects.SO.SOShipment>
    {
        #region UsrTDocSunat
        // Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
        [PXDBString(4)]
        [PXUIField(DisplayName = "Tpo.Doc.Sunat")]
        [PXSelector(typeof(xtb04Sunat.codigo),
            DescriptionField = typeof(xtb04Sunat.descripcion), ValidateValue = false)]
        public virtual string UsrTDocSunat { get; set; }
        public abstract class usrTDocSunat : PX.Data.BQL.BqlString.Field<usrTDocSunat> { }
        #endregion

        #region UsrMotivos
        [PXDBString(5)]
        [PXUIField(DisplayName = "Motivos")]
        [PXSelector(typeof(XTFEMotivos.motivoId), typeof(XTFEMotivos.tipo),
                        DescriptionField = typeof(XTFEMotivos.descr))]
        public virtual string UsrMotivos { get; set; }
        public abstract class usrMotivos : PX.Data.BQL.BqlString.Field<usrMotivos> { }
        #endregion
        // Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
        [PXDBString(3)]
        [PXUIField(DisplayName = "Tip.Operac")]
        [PXSelector(typeof(xtb06Sunat.tOperCD),
typeof(xtb06Sunat.tOperCD),
typeof(xtb06Sunat.descr), DescriptionField = typeof(xtb06Sunat.descr), ValidateValue =false)]
        public virtual string UsrToperacSunat { get; set; }
        public abstract class usrToperacSunat : PX.Data.BQL.BqlString.Field<usrToperacSunat> { }
    }
}