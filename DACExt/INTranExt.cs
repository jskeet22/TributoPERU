using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.CM;
using PX.Objects.Common.Attributes;
using PX.Objects.Common.Bql;
using PX.Objects.Common;
using PX.Objects.CR;
using PX.Objects.CS;
using PX.Objects.CT;
using PX.Objects.GL;
using PX.Objects.IN;
using PX.Objects.PM;
using PX.Objects.PO;
using PX.Objects.SO;
using PX.Objects;
using System.Collections.Generic;
using System;
using TributoPERU;

namespace PX.Objects.IN
{
	public class INTranExt : PXCacheExtension<PX.Objects.IN.INTran>
	{
		#region UsrToperacSunat

// Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
		[PXDBString(3)]
		[PXDefault()]
		[PXUIField(DisplayName="T.Operac.Sunat")]
		[PXSelector(typeof(xtb06Sunat.tOperCD),
typeof(xtb06Sunat.tOperCD),
typeof(xtb06Sunat.descr),DescriptionField =typeof(xtb06Sunat.descr))]
		public virtual string UsrToperacSunat { get; set; }
		public abstract class usrToperacSunat : PX.Data.BQL.BqlString.Field<usrToperacSunat> { }
		#endregion
	}
}