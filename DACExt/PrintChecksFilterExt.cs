using PX.Common;
using PX.Data;
using PX.Objects.AP.MigrationMode;
using PX.Objects.AP;
using PX.Objects.CA;
using PX.Objects.CM;
using PX.Objects.Common;
using PX.Objects.CS;
using PX.Objects.GL;
using PX.Objects;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Web;
using System;
using TributoPERU;

namespace PX.Objects.AP
{
	public class PrintChecksFilterExt : PXCacheExtension<PX.Objects.AP.PrintChecksFilter>
	{
		#region UsrTMedioPago

        // Acuminator disable once PX1030 PXDefaultIncorrectUse [Justification]
        [PXString(10)]
        [PXDefault]//(PersistingCheck = PXPersistingCheck.Null)]
        //[PXDefault(typeof(Select<xtb01Sunat, Where<xtb01Sunat.codigo, Equal<Current<xtb01Sunat.codigo>>>>), SourceField = typeof(xtb01Sunat.descripcion), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "T.Medio.Pago")]
        [PXSelector(typeof(xtb01Sunat.codigo),
typeof(xtb01Sunat.codigo),
typeof(xtb01Sunat.descripcion),
DescriptionField = typeof(xtb01Sunat.descripcion))]
		public virtual string UsrTMedioPago { get; set; }
		public abstract class usrTMedioPago : PX.Data.BQL.BqlString.Field<usrTMedioPago> { }
		#endregion
	}
}