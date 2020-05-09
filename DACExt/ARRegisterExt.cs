using PX.Data;
using TributoPERU;

namespace PX.Objects.AR
{
    public class ARRegisterExt : PXCacheExtension<PX.Objects.AR.ARRegister>
    {
        #region UsrMotivos

        [PXDBString(5)]
        [PXUIField(DisplayName = "Motivos")]
        [PXSelector(typeof(Search<XTFEMotivos.motivoId,
            Where<Current<ARInvoice.docType>, Equal<XTFEMotivos.tipo>>>),
                        typeof(XTFEMotivos.motivoId),
                        DescriptionField = typeof(XTFEMotivos.descr), ValidateValue = false)]

        public virtual string UsrMotivos { get; set; }
        public abstract class usrMotivos : PX.Data.BQL.BqlString.Field<usrMotivos> { }
        #endregion

        #region UsrAfeDetra

        [PXDBBool]
        [PXUIField(DisplayName = "Afecto Detracción")]

        public virtual bool? UsrAfeDetra { get; set; }
        public abstract class usrAfeDetra : PX.Data.BQL.BqlBool.Field<usrAfeDetra> { }
        #endregion

        #region UsrTDocSunat

        [PXDBString(4)]
        [PXUIField(DisplayName = "Tpo.Doc.Sunat")]
        [PXSelector(typeof(Search<xtb04Sunat.codigo,
            Where<xtb04Sunat.tDocumAR,
                Equal<Current<ARInvoice.docType>>>>),
            typeof(xtb04Sunat.codigo),
            DescriptionField = typeof(xtb04Sunat.descripcion), ValidateValue = false)]
        public virtual string UsrTDocSunat { get; set; }
        public abstract class usrTDocSunat : PX.Data.BQL.BqlString.Field<usrTDocSunat> { }
        #endregion

        #region UsrFactRelaciona

        // Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]		     
        [PXDBString(20)]
        [PXUIField(DisplayName = "Fact.Relacionada")]
        [PXSelector(typeof(Search<FactRela.factRelacionado,
     Where<FactRela.acctcd, Equal<Current<ARRegister.customerID>>>,
     OrderBy<Asc<FactRela.factRelacionado>>>),
     typeof(FactRela.factRelacionado),
     typeof(FactRela.fecha),
     typeof(FactRela.codCliente),
     DescriptionField = typeof(FactRela.referencia))]
        public virtual string UsrFactRelaciona { get; set; }
        public abstract class usrFactRelaciona : PX.Data.BQL.BqlString.Field<usrFactRelaciona> { }
        #endregion
        // Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
        [PXDBString(3)]
        [PXUIField(DisplayName = "Tip.Operac")]
        [PXSelector(typeof(xtb06Sunat.tOperCD),
typeof(xtb06Sunat.tOperCD),
typeof(xtb06Sunat.descr), DescriptionField = typeof(xtb06Sunat.descr))]
        public virtual string UsrToperacSunat { get; set; }
        public abstract class usrToperacSunat : PX.Data.BQL.BqlString.Field<usrToperacSunat> { }
    }
}