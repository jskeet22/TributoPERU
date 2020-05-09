using PX.Data;
using System;

namespace TributoPERU
{
    [Serializable]
    public class FactRela : IBqlTable
    {
        #region DocType
        [PXDBString(3, IsFixed = true, InputMask = "")]
        [PXUIField(DisplayName = "Doc Type")]
        public virtual string DocType { get; set; }
        public abstract class docType : IBqlField { }
        #endregion
        #region FactRelacionado
        [PXDBString(40, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "Fact Relacionado")]
        public virtual string FactRelacionado { get; set; }
        public abstract class factRelacionado : IBqlField { }
        #endregion
        #region Acctcd
        [PXDBString(30, IsUnicode = true, InputMask = "")]
        [PXUIField(DisplayName = "C\u00F3digo.Interno")]
        public virtual string Acctcd { get; set; }
        public abstract class acctcd : IBqlField { }
        #endregion
        #region Fecha
        [PXDBDate()]
        [PXUIField(DisplayName = "Fecha Fact")]
        public virtual DateTime? Fecha { get; set; }
        public abstract class fecha : PX.Data.BQL.BqlDateTime.Field<fecha> { }
        #endregion

        #region Referencia
        [PXDBString(40, IsUnicode = true, InputMask = "", IsKey = true)]
        [PXUIField(DisplayName = "Nro.Referencia")]
        public virtual string Referencia { get; set; }
        public abstract class referencia : PX.Data.BQL.BqlString.Field<referencia> { }
        #endregion
        #region CodCliente
        [PXDBString(30, IsUnicode = true, InputMask = "", IsKey = true)]
        [PXUIField(DisplayName = "Cod.Cliente")]
        public virtual string CodCliente { get; set; }
        public abstract class codCliente : PX.Data.BQL.BqlString.Field<codCliente> { }
        #endregion
    }
}