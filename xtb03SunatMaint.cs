using PX.Data;


namespace TributoPERU
{
    public class xtb03SunatMaint : PXGraph<xtb03SunatMaint>
    {
        public PXCancel<xtb03Sunat> Cancel;
        public PXSave<xtb03Sunat> Save;
        public PXSelect<xtb03Sunat> xtb03Sunats;
    }
}