﻿namespace TributoPERU
{
	using System;
	using PX.Data;
	
	[System.SerializableAttribute()]
	public class xtb06Sunat : Copy, PX.Data.IBqlTable
	{
        #region TOperCD
        public abstract class tOperCD : PX.Data.IBqlField
        {
        }
        protected string _TOperCD;
        [PXDBString(3, IsFixed = true, IsKey = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Tipo Operación", IsReadOnly = false)]
        public virtual string TOperCD
        {
            get
            {
                return this._TOperCD;
            }
            set
            {
                this._TOperCD = value;
            }
        }
        #endregion
        #region Descr
        public abstract class descr : PX.Data.IBqlField
        {
        }
        protected string _Descr;
        [PXDBString(50, IsUnicode = true)]
        [PXDefault("")]
        [PXUIField(DisplayName = "Descripción")]
        public virtual string Descr
        {
            get
            {
                return this._Descr;
            }
            set
            {
                this._Descr = value;
            }
        }
        #endregion
    }
}
