using PX.Data;

namespace PX.Objects.AP
{
    public class APTranExt : PXCacheExtension<PX.Objects.AP.APTran>
	{
		#region UsrTipoTransaccion

        // Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
        [PXDBString(5)]
		[PXDefault()]
		[PXUIField(DisplayName="Tipo Transaccion")]
		[PXStringList(
new string[]
{ "AFEC1", "AFEC2", "AFEC3" },
new string[]
{"Oper. Gravadas", "Oper. Grav/No Grav", "Oper. No Gravadas"})]
		public virtual string UsrTipoTransaccion { get; set; }
		public abstract class usrTipoTransaccion : PX.Data.BQL.BqlString.Field<usrTipoTransaccion> { }
		#endregion
	}
}