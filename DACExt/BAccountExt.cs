using PX.Data;
using TributoPERU;

namespace PX.Objects.CR
{
    // Acuminator disable once PX1011 InheritanceFromPXCacheExtension [Justification]
    public class BAccountExt : PXCacheExtension<BAccount>
	{
		#region UsrTDocIdent

 // Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
        [PXDBString(2)]
        [PXUIField(DisplayName = "Tpo.Doc.Ident")]

        [PXSelector(typeof(xtb02Sunat.tDocIdntCD),
        typeof(xtb02Sunat.tDocIdntCD),
        DescriptionField = typeof(xtb02Sunat.descr))]
		public virtual string UsrTDocIdent { get; set; }
		public abstract class usrTDocIdent : PX.Data.BQL.BqlString.Field<usrTDocIdent> { }
		#endregion

		#region UsrNoDoctIdent
				
        [PXDBString(20)]
        [PXUIField(DisplayName = "Nro.Documento")]

		public virtual string UsrNoDoctIdent { get; set; }
		public abstract class usrNoDoctIdent : PX.Data.BQL.BqlString.Field<usrNoDoctIdent> { }
		#endregion

		#region UsrRetencion
				        [PXDBBool]
        [PXUIField(DisplayName = "Sujeto a Retención del IGV")]

		public virtual bool? UsrRetencion { get; set; }
		public abstract class usrRetencion : PX.Data.BQL.BqlBool.Field<usrRetencion> { }
		#endregion

		#region UsrCtaBDetr
				
        [PXDBString(30)]
        [PXUIField(DisplayName = "Cta.Banc.Detracción")]

		public virtual string UsrCtaBDetr { get; set; }
		public abstract class usrCtaBDetr : PX.Data.BQL.BqlString.Field<usrCtaBDetr> { }
		#endregion

		#region UsragentPercep
		
        [PXDBBool]
        [PXUIField(DisplayName = "Agente de Percepcion")]

		public virtual bool? UsragentPercep { get; set; }
		public abstract class usragentPercep : PX.Data.BQL.BqlBool.Field<usragentPercep> { }
		#endregion
	}
}