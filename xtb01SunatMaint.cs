using PX.Data;
namespace TributoPERU
{
    public class xtb01SunatMaint : PXGraph<xtb01SunatMaint>
    {
        public PXCancel<xtb01Sunat> Cancel;
        public PXSave<xtb01Sunat> Save;
        public PXSelect<xtb01Sunat> xtb01Sunats;
    }
}