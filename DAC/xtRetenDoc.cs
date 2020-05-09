using System;
using PX.Data;

namespace LocalizacionPeruStandard
{
    [Serializable]
    public class xtRetenDoc : IBqlTable
    {
        #region Selected        
        [PXBool]
        [PXUIField(DisplayName = "Selected")]
        public virtual bool? Selected { get; set; }
        public abstract class selected : PX.Data.BQL.BqlBool.Field<selected> { } 
        #endregion

        #region BatNbr
        [PXDBString(10, InputMask = "", IsKey = true)]
        [PXUIField(DisplayName = "Batch")]
        public virtual string BatNbr { get; set; }
        public abstract class batNbr : PX.Data.BQL.BqlString.Field<batNbr> { }
        #endregion

        #region DocType
        [PXDBString(3, IsFixed = true, InputMask = "", IsKey = true)]
        [PXUIField(DisplayName = "Doc Type")]
        public virtual string DocType { get; set; }
        public abstract class docType : PX.Data.BQL.BqlString.Field<docType> { }
        #endregion

        #region RefNbr
        [PXDBString(10, InputMask = "", IsKey = true)]
        [PXUIField(DisplayName = "Referencia")]
        public virtual string RefNbr { get; set; }
        public abstract class refNbr : PX.Data.BQL.BqlString.Field<refNbr> { }
        #endregion

        #region CertNbr
        [PXDBString(15, InputMask = "")]
        [PXUIField(DisplayName = "Nro. Certificado")]
        public virtual string CertNbr { get; set; }
        public abstract class certNbr : PX.Data.BQL.BqlString.Field<certNbr> { }
        #endregion

        #region CuryId
        [PXDBString(4, IsFixed = true, InputMask = "")]
        [PXUIField(DisplayName = "Cury Id")]
        public virtual string CuryId { get; set; }
        public abstract class curyId : PX.Data.BQL.BqlString.Field<curyId> { }
        #endregion

        #region Status
        [PXDBString(1, IsFixed = true, InputMask = "")]
        [PXUIField(DisplayName = "Status")]
        public virtual string Status { get; set; }
        public abstract class status : PX.Data.BQL.BqlString.Field<status> { }
        #endregion

        #region CuryOrigDocAmt
        [PXDBDecimal()]
        [PXUIField(DisplayName = "CuryOrigDocAmt")]
        public virtual Decimal? CuryOrigDocAmt { get; set; }
        public abstract class curyOrigDocAmt : PX.Data.BQL.BqlDecimal.Field<curyOrigDocAmt> { }
        #endregion

        #region OrigDocAmt
        [PXDBDecimal()]
        [PXUIField(DisplayName = "Monto")]
        public virtual Decimal? OrigDocAmt { get; set; }
        public abstract class origDocAmt : PX.Data.BQL.BqlDecimal.Field<origDocAmt> { }
        #endregion

        #region Vendid
        [PXDBString(15, InputMask = "")]
        [PXUIField(DisplayName = "Vendid")]
        public virtual string Vendid { get; set; }
        public abstract class vendid : PX.Data.BQL.BqlString.Field<vendid> { }
        #endregion

        #region Porcentaje
        [PXDBDecimal()]
        [PXUIField(DisplayName = "Porcentaje")]
        public virtual Decimal? Porcentaje { get; set; }
        public abstract class porcentaje : PX.Data.BQL.BqlDecimal.Field<porcentaje> { }
        #endregion

        #region Tstamp
        [PXDBTimestamp()]
        [PXUIField(DisplayName = "Tstamp")]
        public virtual byte[] Tstamp { get; set; }
        public abstract class tstamp : PX.Data.BQL.BqlByteArray.Field<tstamp> { }
        #endregion
    }
}