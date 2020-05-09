using System;
using PX.Data;
using PX.Objects.CM;

namespace LocalizacionPeruStandard
{
    [Serializable]
    public class xtRetenTran : IBqlTable
    {
        #region BatNbr
        [PXDBString(10, InputMask = "")]
        [PXUIField(DisplayName = "Bat Nbr")]
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
        [PXUIField(DisplayName = "Ref Nbr")]
        public virtual string RefNbr { get; set; }
        public abstract class refNbr : PX.Data.BQL.BqlString.Field<refNbr> { }
        #endregion

        #region CuryId
        [PXDBString(5, IsUnicode = true)]
        [PXSelector(typeof(Currency.curyID), CacheGlobal = true)]
        [PXUIField(DisplayName = "Currency ID")]
        public virtual string CuryId { get; set; }
        public abstract class curyId : PX.Data.BQL.BqlString.Field<curyId> { }
        #endregion

        #region GlBatNbr
        [PXDBString(10, InputMask = "")]
        [PXUIField(DisplayName = "Gl Bat Nbr")]
        public virtual string GlBatNbr { get; set; }
        public abstract class glBatNbr : PX.Data.BQL.BqlString.Field<glBatNbr> { }
        #endregion

        #region ApDocType
        [PXDBString(10, InputMask = "")]
        [PXUIField(DisplayName = "Ap Doc Type")]
        public virtual string ApDocType { get; set; }
        public abstract class apDocType : PX.Data.BQL.BqlString.Field<apDocType> { }
        #endregion

        #region ApRefNbr
        [PXDBString(10, InputMask = "", IsKey = true)]
        [PXUIField(DisplayName = "Ap Ref Nbr")]
        public virtual string ApRefNbr { get; set; }
        public abstract class apRefNbr : PX.Data.BQL.BqlString.Field<apRefNbr> { }
        #endregion

        #region CuryTranAmt
        [PXDBDecimal()]
        [PXUIField(DisplayName = "Cury Tran Amt")]
        public virtual Decimal? CuryTranAmt { get; set; }
        public abstract class curyTranAmt : PX.Data.BQL.BqlDecimal.Field<curyTranAmt> { }
        #endregion

        #region TranAmt
        [PXDBDecimal()]
        [PXUIField(DisplayName = "Tran Amt")]
        public virtual Decimal? TranAmt { get; set; }
        public abstract class tranAmt : PX.Data.BQL.BqlDecimal.Field<tranAmt> { }
        #endregion

        #region Tstamp
        [PXDBTimestamp()]
        [PXUIField(DisplayName = "Tstamp")]
        public virtual byte[] Tstamp { get; set; }
        public abstract class tstamp : PX.Data.BQL.BqlByteArray.Field<tstamp> { }
        #endregion
    }
}