using PX.Data;

namespace PX.Objects.PO
{
    // Acuminator disable once PX1011 InheritanceFromPXCacheExtension [Justification]
    public class POReceiptExt : PXCacheExtension<PX.Objects.PO.POReceipt>
	{
		#region UsrSerie
		[PXDBString(10)]
		[PXUIField(DisplayName="Serie")]

		public virtual string UsrSerie { get; set; }
		public abstract class usrSerie : PX.Data.BQL.BqlString.Field<usrSerie> { }
		#endregion

		#region UsrNroDoc
		[PXDBString(25)]
		[PXUIField(DisplayName="Nro.Doc")]

		public virtual string UsrNroDoc { get; set; }
		public abstract class usrNroDoc : PX.Data.BQL.BqlString.Field<usrNroDoc> { }
		#endregion
	}
}