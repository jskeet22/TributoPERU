using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.Common.Extensions;
using PX.Objects.CR;
using PX.Objects.CS;
using PX.Objects.DR;
using PX.Objects.EP;
using PX.Objects.GL;
using PX.Objects.IN;
using PX.Objects.TX;
using PX.Objects;
using PX.TM;
using System.Collections.Generic;
using System;
using TributoPERU;

namespace PX.Objects.IN
{
	public class InventoryItemExt : PXCacheExtension<PX.Objects.IN.InventoryItem>
	{
		#region UsrUMSunat
		
 [PXDBString(5)]
		[PXDefault()]
        [PXUIField(DisplayName = "U/M Sunat")]
        [PXSelector(typeof(xtb11Sunat.cunidCD),
typeof(xtb11Sunat.cunidCD),
typeof(xtb11Sunat.descr),DescriptionField = typeof(xtb11Sunat.descr))]

		public virtual string UsrUMSunat { get; set; }
		public abstract class usrUMSunat : PX.Data.BQL.BqlString.Field<usrUMSunat> { }
		#endregion

		#region UsrTipoExistencia

// Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
		[PXDBString(4)]
		[PXDefault()]
        [PXUIField(DisplayName = "Tipo Existencia")]
        [PXSelector(typeof(xtb10Sunat.tExistCD),
typeof(xtb10Sunat.tExistCD),
typeof(xtb10Sunat.descr),DescriptionField = typeof(xtb10Sunat.descr))]
		public virtual string UsrTipoExistencia { get; set; }
		public abstract class usrTipoExistencia : PX.Data.BQL.BqlString.Field<usrTipoExistencia> { }
		#endregion
	}
}