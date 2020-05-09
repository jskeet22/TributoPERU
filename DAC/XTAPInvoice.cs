namespace TributoPERU
{
    using PX.Data;
    using PX.Objects.AP;
    using PX.Objects.TX;
    [PXTable(IsOptional = true)]
    public class XTAPInvoice : PXCacheExtension<APInvoice>
    {
        #region TDocSunat
        public abstract class tDocSunat : PX.Data.IBqlField
        {
        }
        protected string _TDocSunat;
        [PXDBString(4, IsUnicode = true)]
        [PXUIField(DisplayName = "Tpo.Doc.Sunat")]
        [PXDefault()]
        //[PXSelector(typeof(Search<xtb04Sunat.codigo,
        //Where<xtb04Sunat.tDocumAP, Equal<Current<APRegister.docType>>>>),
        //typeof(xtb04Sunat.codigo),
        //DescriptionField = typeof(xtb04Sunat.descripcion))]

        [PXSelector(typeof(Search<xtb04Sunat.codigo,
            Where<Current<APInvoice.docType>, Equal<xtb04Sunat.tDocumAP>>,
            OrderBy<Asc<xtb04Sunat.codigo>>>),
            typeof(xtb04Sunat.codigo),
            DescriptionField = typeof(xtb04Sunat.descripcion), ValidateValue = false)]
        public virtual string TDocSunat
        {
            get
            {
                return _TDocSunat;
            }
            set
            {
                _TDocSunat = value;
            }
        }
        #endregion
        #region DependAdu
        public abstract class dependAdu : PX.Data.IBqlField
        {
        }
        protected string _DependAdu;
        [PXDBString(5, IsUnicode = true)]
        [PXUIField(DisplayName = "Depend Adu")]
        [PXSelector(typeof(xtb05Sunat.aduCD),
typeof(xtb05Sunat.aduCD),
typeof(xtb05Sunat.descr),
DescriptionField = typeof(xtb05Sunat.descr))]
        public virtual string DependAdu
        {
            get
            {
                return this._DependAdu;
            }
            set
            {
                this._DependAdu = value;
            }
        }
        #endregion
        #region TBienServ
        public abstract class tBienServ : PX.Data.IBqlField
        {
        }
        protected string _TBienServ;
        [PXDBString(6, IsUnicode = true)]
        [PXUIField(DisplayName = "TBien Serv")]
        [PXSelector(typeof(
                        Search2<xtb08Sunat.tGdsSvcsCD,
                        LeftJoin<TaxRev, On<TaxRev.taxID,
                        Equal<xtb08Sunat.taxCD>>>>),
                        typeof(xtb08Sunat.tGdsSvcsCD),
                        typeof(xtb08Sunat.descr),
                        typeof(xtb08Sunat.taxCD),
                        typeof(TaxRev.taxRate),
                        DescriptionField = typeof(xtb08Sunat.descr))]
        public virtual string TBienServ
        {
            get
            {
                return this._TBienServ;
            }
            set
            {
                this._TBienServ = value;
            }
        }
        #endregion
        #region TOperacion
        public abstract class tOperacion : PX.Data.IBqlField
        {
        }
        protected string _TOperacion;
        [PXDBString(4, IsUnicode = true)]
        [PXUIField(DisplayName = "TOperacion")]
        [PXSelector(typeof(xtb09Sunat.tOperDetCD),
    typeof(xtb09Sunat.tOperDetCD),
    typeof(xtb09Sunat.descr),
    DescriptionField = typeof(xtb09Sunat.descr))]
        public virtual string TOperacion
        {
            get
            {
                return this._TOperacion;
            }
            set
            {
                this._TOperacion = value;
            }
        }
        #endregion
        #region TipoRenta
        public abstract class tipoRenta : PX.Data.IBqlField
        {
        }
        protected string _TipoRenta;
        [PXDBString(6, IsUnicode = true)]
        [PXUIField(DisplayName = "Tipo Renta")]
        [PXSelector(typeof(xtb31Sunat.codigoCD),
    typeof(xtb31Sunat.codigoCD),
    typeof(xtb31Sunat.descr),
    DescriptionField = typeof(xtb31Sunat.descr))]
        public virtual string TipoRenta
        {
            get
            {
                return this._TipoRenta;
            }
            set
            {
                this._TipoRenta = value;
            }
        }
        #endregion
        #region ClasBienServ
        public abstract class clasBienServ : PX.Data.IBqlField
        {
        }
        protected string _ClasBienServ;
        [PXDBString(4, IsUnicode = true)]
        [PXUIField(DisplayName = "Clas Bien Serv")]
        [PXSelector(typeof(xtb30Sunat.codigo),
        typeof(xtb30Sunat.codigo),
        typeof(xtb30Sunat.descr),
        DescriptionField = typeof(xtb30Sunat.descr))]

        public virtual string ClasBienServ
        {
            get
            {
                return this._ClasBienServ;
            }
            set
            {
                this._ClasBienServ = value;
            }
        }
        #endregion
        #region Detraccion
        public abstract class detraccion : PX.Data.IBqlField
        {
        }
        protected bool? _Detraccion;
        [PXDBBool()]
        // [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Detracción")]//Visibility = PXUIVisibility.Visible, Visible = false
        public virtual bool? Detraccion
        {
            get
            {
                return this._Detraccion;
            }
            set
            {
                this._Detraccion = value;
            }
        }
        #endregion
        #region AutoDetraccion
        public abstract class autodetraccion : PX.Data.IBqlField
        {
        }
        protected bool? _AutoDetraccion;
        [PXDBBool()]
        // [PXDefault(PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Auto-Detracción")]//, Visibility = PXUIVisibility.Visible, Visible = false
        public virtual bool? AutoDetraccion
        {
            get
            {
                return this._AutoDetraccion;
            }
            set
            {
                this._AutoDetraccion = value;
            }
        }
        #endregion
        #region Serie
        public abstract class serie : PX.Data.IBqlField
        {
        }
        protected string _Serie;
        [PXDBString(20, IsUnicode = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Serie")]
        public virtual string Serie
        {
            get
            {
                return this._Serie;
            }
            set
            {
                this._Serie = value;
            }
        }
        #endregion
        #region NroDocumento
        public abstract class nroDocumento : PX.Data.IBqlField
        {
        }
        protected string _NroDocumento;
        [PXDBString(30, IsUnicode = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Nro.Doc")]
        public virtual string NroDocumento
        {
            get
            {
                return this._NroDocumento;
            }
            set
            {
                this._NroDocumento = value;
            }
        }
        #endregion
    }
}
