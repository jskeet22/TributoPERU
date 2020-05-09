using PX.Data;
namespace TributoPERU
{
    public class xLocEquivalAcctEntry : PXGraph<xLocEquivalAcctEntry>
    {
        //public PXSelect<xLocEquivalHeader> xLocEquivalHeaders;
        //public PXSelect<xLocEquivalAcct,
        //   Where<xLocEquivalAcct.cuentaCD, Equal<Current<xLocEquivalHeader.cuentaCD>>>> xLocEquivalAccts;

        //public virtual void xLocEquivalHeader_RowSelected(PXCache sender, PXRowSelectedEventArgs e)
        //{
        //    //xLocEquivalHeader CuentaCD = (xLocEquivalHeader)e.Row;
        //    //xLocEquivalHeader row = (xLocEquivalHeader)e.Row;
        //    //if (row == null) return;

        //    //PXUIFieldAttribute.SetVisible<xLocEquivalAcct.cRSubCD>(
        //    //          xLocEquivalAccts.Cache, null, row.CuentaCD != TipoCuentas.C);

        //}
        //protected void xLocEquivalAcct_RowDeleting(PXCache sender, PXRowDeletingEventArgs e)
        //{
        //    //xLocEquivalAcct line = (xLocEquivalAcct)e.Row;
        //    //if (sender.GetStatus(line) != PXEntryStatus.InsertedDeleted)
        //    //{
        //    //    // Asking for confirmation on an attempt to delete a
        //    //    // shipment line other than the gift card line este es para eliminar
        //    //    if (xLocEquivalAccts.Ask("Confirmacion para Eliminar",
        //    //    "Estas Seguro?",
        //    //    MessageButtons.YesNo) != WebDialogResult.Yes)
        //    //    {
        //    //        e.Cancel = true;
        //    //    }
        //    //}

        //}
    }
}