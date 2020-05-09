using PX.Data;
namespace TributoPERU
{
    public class xtRtnSetupMaint : PXGraph<xtRtnSetupMaint>
    {
        public PXSelect<xtRtnSetup> xtRtnSetups;
        public PXCancel<xtRtnSetup> Cancel;
        public PXSave<xtRtnSetup> Save;
    }
}