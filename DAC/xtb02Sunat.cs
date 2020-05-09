﻿namespace TributoPERU
{
	using System;
	using PX.Data;
	
	[System.SerializableAttribute()]
	public class xtb02Sunat : Copy, PX.Data.IBqlTable
    {
		#region TDocIdntCD
		public abstract class tDocIdntCD : PX.Data.IBqlField
		{
		}
		protected string _TDocIdntCD;
		[PXDBString(2, IsFixed = true, IsKey = true)]
		[PXDefault()]
		[PXUIField(DisplayName = "TDoc.Idententidad")]
		public virtual string TDocIdntCD
		{
			get
			{
				return this._TDocIdntCD;
			}
			set
			{
				this._TDocIdntCD = value;
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
