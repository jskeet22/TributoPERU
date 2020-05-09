using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;
using PX.Objects;
using System.Collections.Generic;
using System;
using TributoPERU;

namespace PX.Objects.IN
{
	public class INUnitExt : PXCacheExtension<PX.Objects.IN.INUnit>
	{
		#region UsrUnidSunat

[PXDBString(3)]
		[PXUIField(DisplayName="Unidad Sunat")]
		[PXSelector(typeof(xtb11Sunat.cunidCD),
typeof(xtb11Sunat.cunidCD),
typeof(xtb11Sunat.descr), DescriptionField = typeof(xtb11Sunat.descr))]
		public virtual string UsrUnidSunat { get; set; }
		public abstract class usrUnidSunat : PX.Data.BQL.BqlString.Field<usrUnidSunat> { }
		#endregion
	}
}