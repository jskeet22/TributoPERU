using PX.Data.BQL;
using PX.Data.EP;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.AP;
using PX.Objects.AR;
using PX.Objects.CA;
using PX.Objects.CM;
using PX.Objects.Common;
using PX.Objects.CR;
using PX.Objects.CS;
using PX.Objects.CT;
using PX.Objects.EP.DAC;
using PX.Objects.EP;
using PX.Objects.GL;
using PX.Objects.IN;
using PX.Objects.PM;
using PX.Objects.TX;
using PX.Objects;
using PX.SM;
using System.Collections.Generic;
using System;
using TributoPERU;

namespace PX.Objects.EP
{
	public class EPExpenseClaimDetailsExt : PXCacheExtension<PX.Objects.EP.EPExpenseClaimDetails>
	{
		#region UsrTDocSunat
				        [PXDBString(3)]
        [PXUIField(DisplayName = "Tpo.Doc")]


        [PXSelector(typeof(xtb04Sunat.codigo),
typeof(xtb04Sunat.codigo),
typeof(xtb04Sunat.descripcion),
DescriptionField = typeof(xtb04Sunat.descripcion))]

		public virtual string UsrTDocSunat { get; set; }
		public abstract class usrTDocSunat : PX.Data.BQL.BqlString.Field<usrTDocSunat> { }
		#endregion

		#region UsrClasBienServ

        // Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
        [PXDBString(3)]
        [PXDefault()]
        [PXUIField(DisplayName = "Clase Bien/Servic")]

        [PXSelector(typeof(xtb30Sunat.codigo),
                typeof(xtb30Sunat.codigo),
                typeof(xtb30Sunat.descr),
                DescriptionField = typeof(xtb30Sunat.descr))]
		public virtual string UsrClasBienServ { get; set; }
		public abstract class usrClasBienServ : PX.Data.BQL.BqlString.Field<usrClasBienServ> { }
		#endregion

		#region UsrRuc
				        [PXDBString(11)]
        [PXUIField(DisplayName = "Ruc")]

		public virtual string UsrRuc { get; set; }
		public abstract class usrRuc : PX.Data.BQL.BqlString.Field<usrRuc> { }
		#endregion

		#region UsrRazonsocial
				        [PXDBString(160)]
        [PXUIField(DisplayName = "Razón Social")]

		public virtual string UsrRazonsocial { get; set; }
		public abstract class usrRazonsocial : PX.Data.BQL.BqlString.Field<usrRazonsocial> { }
		#endregion

		#region UsrSerie
				        [PXDBString(20)]
        [PXUIField(DisplayName = "Serie")]

		public virtual string UsrSerie { get; set; }
		public abstract class usrSerie : PX.Data.BQL.BqlString.Field<usrSerie> { }
		#endregion
	}

			[PXNonInstantiatedExtension]
	public class EP_EPExpenseClaimDetails_ExistingColumn : PXCacheExtension<PX.Objects.EP.EPExpenseClaimDetails>
	{
			#region Status	
				[PXMergeAttributes(Method = MergeMethod.Append)]


        [PXCustomizeBaseAttribute(typeof(PXUIFieldAttribute), "Enabled", true)]
			public string Status { get; set; }
			#endregion

			#region ExpenseRefNbr	
						        [PXCustomizeBaseAttribute(typeof(PXUIFieldAttribute), "DisplayName", "No. Documento")]

			public string ExpenseRefNbr { get; set; }
			#endregion
	}
}