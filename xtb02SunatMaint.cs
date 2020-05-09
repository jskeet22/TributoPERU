using PX.Data;


namespace TributoPERU
{
    public class xtb02SunatMaint : PXGraph<xtb02SunatMaint>
    {
        public PXCancel<xtb02Sunat> Cancel;
        public PXSave<xtb02Sunat> Save;
        public PXSelect<xtb02Sunat> xtb02Sunats;
    }
}