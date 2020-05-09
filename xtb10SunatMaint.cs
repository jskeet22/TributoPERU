using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;


namespace TributoPERU
{
    public class xtb10SunatMaint : PXGraph<xtb10SunatMaint>
    {
        public PXCancel<xtb10Sunat> Cancel;
        public PXSave<xtb10Sunat> Save;
        public PXSelect<xtb10Sunat> Xtb10Sunats;
    }
}