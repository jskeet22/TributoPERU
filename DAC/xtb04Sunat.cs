namespace TributoPERU
{
    using PX.Data;
    using PX.Objects.CS;
    using PX.Objects.TX;

    [System.SerializableAttribute()]
    public class xtb04Sunat : Copy, PX.Data.IBqlTable
    {
        #region Codigo
        public abstract class codigo : PX.Data.IBqlField
        {
        }
        protected string _Codigo;
        [PXDBString(2, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Codigo")]
        public virtual string Codigo
        {
            get
            {
                return this._Codigo;
            }
            set
            {
                this._Codigo = value;
            }
        }
        #endregion
        #region Descripcion
        public abstract class descripcion : PX.Data.IBqlField
        {
        }
        protected string _Descripcion;
        [PXDBString(60, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Descripción")]
        public virtual string Descripcion
        {
            get
            {
                return this._Descripcion;
            }
            set
            {
                this._Descripcion = value;
            }
        }
        #endregion
        #region Impuesto
        public abstract class impuesto : PX.Data.IBqlField
        {
        }
        protected string _Impuesto;
        [PXDBString(30, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Impuesto")]
        [PXSelector(typeof(Tax.taxID),
                    typeof(Tax.taxID),
                    typeof(Tax.descr))]
        public virtual string Impuesto
        {
            get
            {
                return this._Impuesto;
            }
            set
            {
                this._Impuesto = value;
            }
        }
        #endregion
        #region TDocumAP
        public abstract class tDocumAP : PX.Data.IBqlField
        {
        }
        protected string _TDocumAP;
        [PXDBString(15, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "TDocumAP")]
        [PXStringList(new string[]
            {
            TipoDocumento.AP,
            TipoDocumento.AP1,
            TipoDocumento.AP2,
            TipoDocumento.AP3,
            TipoDocumento.AP4,
            TipoDocumento.AP5,
            },
            new string[]
            {
             "Ninguno",
             "Factura",
             "Ajuste Credito",
             "Ajuste Debito",
             "Variacion del Precio",
             "Anticipo"
            })]
        public virtual string TDocumAP
        {
            get
            {
                return this._TDocumAP;
            }
            set
            {
                this._TDocumAP = value;
            }
        }
        #endregion
        #region TDocumAR
        public abstract class tDocumAR : PX.Data.IBqlField
        {
        }
        protected string _TDocumAR;
        [PXDBString(15, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "TDocumAR")]
        [PXStringList(new string[]
                {
                TipoDocumento.AR,
                 TipoDocumento.AR1,
                 TipoDocumento.AR2,
                 TipoDocumento.AR3,
                },
                new string[]
                {
                   "Factura",
                   "Nota Crédito",
                   "Nota Cargo",
                   "Vta Efectivo"
                })]
        public virtual string TDocumAR
        {
            get
            {
                return this._TDocumAR;
            }
            set
            {
                this._TDocumAR = value;
            }
        }
        #endregion
        #region RCompras
        public abstract class rCompras : PX.Data.IBqlField
        {
        }
        protected bool? _RCompras;
        [PXDBBool()]
        [PXUIField(DisplayName = "RCompras")]
        public virtual bool? RCompras
        {
            get
            {
                return this._RCompras;
            }
            set
            {
                this._RCompras = value;
            }
        }
        #endregion
        #region RVentas
        public abstract class rVentas : PX.Data.IBqlField
        {
        }
        protected bool? _RVentas;
        [PXDBBool()]
        [PXUIField(DisplayName = "RVentas")]
        public virtual bool? RVentas
        {
            get
            {
                return this._RVentas;
            }
            set
            {
                this._RVentas = value;
            }
        }
        #endregion
        #region DocType
        public abstract class docType : PX.Data.IBqlField
        {
        }
        protected string _DocType;
        [PXDBString(3, IsFixed = true)]
        [PXUIField(DisplayName = "DocType")]
        public virtual string DocType
        {
            get
            {
                return this._DocType;
            }
            set
            {
                this._DocType = value;
            }
        }
        #endregion
        #region LongSerie
        public abstract class longSerie : PX.Data.IBqlField
        {
        }
        protected string _LongSerie;
        [PXDBString(20, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Long Serie")]
        public virtual string LongSerie
        {
            get
            {
                return this._LongSerie;
            }
            set
            {
                this._LongSerie = value;
            }
        }
        #endregion
        #region LongNroDoc
        public abstract class longNroDoc : PX.Data.IBqlField
        {
        }
        protected string _LongNroDoc;
        [PXDBString(30, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Long NroDoc")]
        public virtual string LongNroDoc
        {
            get
            {
                return this._LongNroDoc;
            }
            set
            {
                this._LongNroDoc = value;
            }
        }
        #endregion
        #region NroSecuencia
        public abstract class nroSecuencia : PX.Data.IBqlField
        {
        }
        protected string _NroSecuencia;
        [PXDBString(10, IsUnicode = true)]
        [PXUIField(DisplayName = "Nro Secuencia")]
        [PXSelector(typeof(Numbering.numberingID),
                    typeof(Numbering.numberingID),
                    typeof(Numbering.descr))]
        public virtual string NroSecuencia
        {
            get
            {
                return this._NroSecuencia;
            }
            set
            {
                this._NroSecuencia = value;
            }
        }
        #endregion
    }
    public static class TipoDocumento
    {
        public const string AP = "NN";
        // public class ap : Constant<String>
        public class ap : PX.Data.BQL.BqlString.Constant<ap>

        {
            public ap()
            : base(AP)
            {
            }
        }
        public const string AP1 = "INV";
        //public class ap1 :PX.Data.BQL.BqlString.Constant<String>
        public class ap1 : PX.Data.BQL.BqlString.Constant<ap1>

        {
            public ap1()
            : base(AP1)
            {
            }
        }
        public const string AP2 = "ACR";
        //public class ap2 : Constant<String>
        public class ap2 : PX.Data.BQL.BqlString.Constant<ap2>
        {
            public ap2()
            : base(AP2)
            {
            }
        }
        public const string AP3 = "ADR";
        //public class ap3 : Constant<String>
        public class ap3 : PX.Data.BQL.BqlString.Constant<ap3>
        {
            public ap3()
            : base(AP3)
            {
            }
        }
        public const string AP4 = "PV";
        //public class ap4 : Constant<String>
        public class ap4 : PX.Data.BQL.BqlString.Constant<ap4>
        {
            public ap4()
            : base(AP4)
            {
            }
        }
        public const string AP5 = "PP";
        //public class ap5 : Constant<String>
        public class ap5 : PX.Data.BQL.BqlString.Constant<ap5>
        {
            public ap5()
            : base(AP5)
            {
            }
        }
        public const string AR = "INV";
        //public class ar : Constant<String>
        public class ar : PX.Data.BQL.BqlString.Constant<ar>
        {
            public ar()
            : base(AR)
            {
            }
        }
        public const string AR1 = "CRM";
        // public class ar1 : Constant<String>
        public class ar1 : PX.Data.BQL.BqlString.Constant<ar1>
        {
            public ar1()
            : base(AR1)
            {
            }
        }
        public const string AR2 = "DRM";
        //public class ar2 : Constant<String>
        public class ar2 : PX.Data.BQL.BqlString.Constant<ar2>
        {
            public ar2()
            : base(AR2)
            {
            }
        }
        public const string AR3 = "CSL";
        //public class ar3 : Constant<String>
        public class ar3 : PX.Data.BQL.BqlString.Constant<ar3>
        {
            public ar3()
            : base(AR3)
            {
            }
        }
    }
}