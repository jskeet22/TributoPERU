using PX.Data;


namespace TributoPERU
{
    public class xtb06SunatMaint : PXGraph<xtb06SunatMaint>
    {
        public PXCancel<xtb06Sunat> Cancel;
        public PXSave<xtb06Sunat> Save;
        public PXSelect<xtb06Sunat> Xtb06Sunats;
    }
}