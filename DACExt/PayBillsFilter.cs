using PX.Data;
using PX.Objects.AP;
using PX.Objects.CA;
using PX.Objects.CM;
using PX.Objects.Common.Extensions;
using PX.Objects.CR;
using PX.Objects.CS;
using PX.Objects.GL;
using PX.Objects;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System;
using TributoPERU;

namespace PX.Objects.AP
{
	public class PayBillsFilterExt : PXCacheExtension<PX.Objects.AP.PayBillsFilter>
	{
			#region UsrCustomField
			[PXString]
        [PXDefault]
        [PXUIField(DisplayName= "T.Medio.Pago")]
        [PXSelector(typeof(xtb01Sunat.codigo),
typeof(xtb01Sunat.codigo),
typeof(xtb01Sunat.descripcion),
DescriptionField = typeof(xtb01Sunat.descripcion))]
        //[PXSelector(
        //    typeof(Search<xtb01Sunat.codigo,
        //    Where<xtb01Sunat.metodpago, Equal<Current<PaymentMethod.paymentMethodID>>>>),
        //    typeof(xtb01Sunat.codigo),
        //    DescriptionField = typeof(xtb01Sunat.descripcion))]
        public virtual string UsrTMedioPago { get; set; }
			public abstract class usrTMedioPago : IBqlField { }
			#endregion
	}
}