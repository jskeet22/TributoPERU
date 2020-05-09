﻿namespace TributoPERU
{
	using System;
	using PX.Data;
	
	[System.SerializableAttribute()]
	public class xtb03Sunat : Copy, PX.Data.IBqlTable
	{
		#region Codigo
		public abstract class codigo : PX.Data.IBqlField
		{
		}
		protected string _Codigo;
		[PXDBString(3, IsFixed = true, IsKey = true)]
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
		[PXDBString(50, IsUnicode = true)]
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
        
    }
}
