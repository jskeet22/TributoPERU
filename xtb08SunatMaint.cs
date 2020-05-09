using System.Collections;
using PX.Data;


namespace TributoPERU
{
    public class xtb08SunatMaint : PXGraph<xtb08SunatMaint>
    {
        public PXCancel<xtb08Sunat> Cancel;
        public PXSave<xtb08Sunat> Save;

        public PXSelect<xtb08Sunat> Xtb08Sunats;
    }
}