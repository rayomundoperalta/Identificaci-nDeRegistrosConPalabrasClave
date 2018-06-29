﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentificaciónDeRegistrosConPalabrasClave
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="InteligenciaMercado")]
	public partial class GrecopaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public GrecopaDataContext() : 
				base(global::IdentificaciónDeRegistrosConPalabrasClave.Properties.Settings.Default.InteligenciaMercadoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GrecopaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GrecopaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GrecopaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GrecopaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Contratos2017Limpio> Contratos2017Limpios
		{
			get
			{
				return this.GetTable<Contratos2017Limpio>();
			}
		}
		
		public System.Data.Linq.Table<Contratos2018Limpio> Contratos2018Limpios
		{
			get
			{
				return this.GetTable<Contratos2018Limpio>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contratos2017Limpio")]
	public partial class Contratos2017Limpio
	{
		
		private string _Column_0;
		
		private string _GOBIERNO;
		
		private string _SIGLAS;
		
		private string _DEPENDENCIA;
		
		private string _CLAVEUC;
		
		private string _NOMBRE_DE_LA_UC;
		
		private string _RESPONSABLE;
		
		private string _CODIGO_EXPEDIENTE;
		
		private string _TITULO_EXPEDIENTE;
		
		private string _PLANTILLA_EXPEDIENTE;
		
		private string _NUMERO_PROCEDIMIENTO;
		
		private string _EXP_F_FALLO;
		
		private string _PROC_F_PUBLICACION;
		
		private string _FECHA_APERTURA_PROPOSICIONES;
		
		private string _CARACTER;
		
		private string _TIPO_CONTRATACION;
		
		private string _TIPO_PROCEDIMIENTO;
		
		private string _FORMA_PROCEDIMIENTO;
		
		private string _CODIGO_CONTRATO;
		
		private string _TITULO_CONTRATO;
		
		private string _FECHA_INICIO;
		
		private string _FECHA_FIN;
		
		private string _IMPORTE_CONTRATO;
		
		private string _MONEDA;
		
		private string _ESTATUS_CONTRATO;
		
		private string _ARCHIVADO;
		
		private string _CONVENIO_MODIFICATORIO;
		
		private string _RAMO;
		
		private string _CLAVE_PROGRAMA;
		
		private string _APORTACION_FEDERAL;
		
		private string _FECHA_CELEBRACION;
		
		private string _CONTRATO_MARCO;
		
		private string _IDENTIFICADOR_CM;
		
		private string _COMPRA_CONSOLIDADA;
		
		private string _PLURIANUAL;
		
		private string _CLAVE_CARTERA_SHCP;
		
		private string _ESTRATIFICACION_MUC;
		
		private string _FOLIO_RUPC;
		
		private string _PROVEEDOR_CONTRATISTA;
		
		private string _ESTRATIFICACION_MPC;
		
		private string _SIGLAS_PAIS;
		
		private string _ESTATUS_EMPRESA;
		
		private string _CUENTA_ADMINISTRADA_POR;
		
		private string _C_EXTERNO;
		
		private string _ORGANISMO;
		
		private string _ANUNCIO;
		
		public Contratos2017Limpio()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Column 0]", Storage="_Column_0", DbType="VarChar(50)")]
		public string Column_0
		{
			get
			{
				return this._Column_0;
			}
			set
			{
				if ((this._Column_0 != value))
				{
					this._Column_0 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GOBIERNO", DbType="VarChar(500)")]
		public string GOBIERNO
		{
			get
			{
				return this._GOBIERNO;
			}
			set
			{
				if ((this._GOBIERNO != value))
				{
					this._GOBIERNO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SIGLAS", DbType="VarChar(500)")]
		public string SIGLAS
		{
			get
			{
				return this._SIGLAS;
			}
			set
			{
				if ((this._SIGLAS != value))
				{
					this._SIGLAS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DEPENDENCIA", DbType="VarChar(500)")]
		public string DEPENDENCIA
		{
			get
			{
				return this._DEPENDENCIA;
			}
			set
			{
				if ((this._DEPENDENCIA != value))
				{
					this._DEPENDENCIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLAVEUC", DbType="VarChar(500)")]
		public string CLAVEUC
		{
			get
			{
				return this._CLAVEUC;
			}
			set
			{
				if ((this._CLAVEUC != value))
				{
					this._CLAVEUC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE_DE_LA_UC", DbType="VarChar(500)")]
		public string NOMBRE_DE_LA_UC
		{
			get
			{
				return this._NOMBRE_DE_LA_UC;
			}
			set
			{
				if ((this._NOMBRE_DE_LA_UC != value))
				{
					this._NOMBRE_DE_LA_UC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RESPONSABLE", DbType="VarChar(500)")]
		public string RESPONSABLE
		{
			get
			{
				return this._RESPONSABLE;
			}
			set
			{
				if ((this._RESPONSABLE != value))
				{
					this._RESPONSABLE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_EXPEDIENTE", DbType="VarChar(500)")]
		public string CODIGO_EXPEDIENTE
		{
			get
			{
				return this._CODIGO_EXPEDIENTE;
			}
			set
			{
				if ((this._CODIGO_EXPEDIENTE != value))
				{
					this._CODIGO_EXPEDIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITULO_EXPEDIENTE", DbType="VarChar(500)")]
		public string TITULO_EXPEDIENTE
		{
			get
			{
				return this._TITULO_EXPEDIENTE;
			}
			set
			{
				if ((this._TITULO_EXPEDIENTE != value))
				{
					this._TITULO_EXPEDIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PLANTILLA_EXPEDIENTE", DbType="VarChar(500)")]
		public string PLANTILLA_EXPEDIENTE
		{
			get
			{
				return this._PLANTILLA_EXPEDIENTE;
			}
			set
			{
				if ((this._PLANTILLA_EXPEDIENTE != value))
				{
					this._PLANTILLA_EXPEDIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMERO_PROCEDIMIENTO", DbType="VarChar(500)")]
		public string NUMERO_PROCEDIMIENTO
		{
			get
			{
				return this._NUMERO_PROCEDIMIENTO;
			}
			set
			{
				if ((this._NUMERO_PROCEDIMIENTO != value))
				{
					this._NUMERO_PROCEDIMIENTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EXP_F_FALLO", DbType="VarChar(500)")]
		public string EXP_F_FALLO
		{
			get
			{
				return this._EXP_F_FALLO;
			}
			set
			{
				if ((this._EXP_F_FALLO != value))
				{
					this._EXP_F_FALLO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROC_F_PUBLICACION", DbType="VarChar(500)")]
		public string PROC_F_PUBLICACION
		{
			get
			{
				return this._PROC_F_PUBLICACION;
			}
			set
			{
				if ((this._PROC_F_PUBLICACION != value))
				{
					this._PROC_F_PUBLICACION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_APERTURA_PROPOSICIONES", DbType="VarChar(500)")]
		public string FECHA_APERTURA_PROPOSICIONES
		{
			get
			{
				return this._FECHA_APERTURA_PROPOSICIONES;
			}
			set
			{
				if ((this._FECHA_APERTURA_PROPOSICIONES != value))
				{
					this._FECHA_APERTURA_PROPOSICIONES = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CARACTER", DbType="VarChar(500)")]
		public string CARACTER
		{
			get
			{
				return this._CARACTER;
			}
			set
			{
				if ((this._CARACTER != value))
				{
					this._CARACTER = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIPO_CONTRATACION", DbType="VarChar(500)")]
		public string TIPO_CONTRATACION
		{
			get
			{
				return this._TIPO_CONTRATACION;
			}
			set
			{
				if ((this._TIPO_CONTRATACION != value))
				{
					this._TIPO_CONTRATACION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIPO_PROCEDIMIENTO", DbType="VarChar(500)")]
		public string TIPO_PROCEDIMIENTO
		{
			get
			{
				return this._TIPO_PROCEDIMIENTO;
			}
			set
			{
				if ((this._TIPO_PROCEDIMIENTO != value))
				{
					this._TIPO_PROCEDIMIENTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FORMA_PROCEDIMIENTO", DbType="VarChar(500)")]
		public string FORMA_PROCEDIMIENTO
		{
			get
			{
				return this._FORMA_PROCEDIMIENTO;
			}
			set
			{
				if ((this._FORMA_PROCEDIMIENTO != value))
				{
					this._FORMA_PROCEDIMIENTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_CONTRATO", DbType="VarChar(500)")]
		public string CODIGO_CONTRATO
		{
			get
			{
				return this._CODIGO_CONTRATO;
			}
			set
			{
				if ((this._CODIGO_CONTRATO != value))
				{
					this._CODIGO_CONTRATO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITULO_CONTRATO", DbType="VarChar(500)")]
		public string TITULO_CONTRATO
		{
			get
			{
				return this._TITULO_CONTRATO;
			}
			set
			{
				if ((this._TITULO_CONTRATO != value))
				{
					this._TITULO_CONTRATO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_INICIO", DbType="VarChar(500)")]
		public string FECHA_INICIO
		{
			get
			{
				return this._FECHA_INICIO;
			}
			set
			{
				if ((this._FECHA_INICIO != value))
				{
					this._FECHA_INICIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_FIN", DbType="VarChar(500)")]
		public string FECHA_FIN
		{
			get
			{
				return this._FECHA_FIN;
			}
			set
			{
				if ((this._FECHA_FIN != value))
				{
					this._FECHA_FIN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMPORTE_CONTRATO", DbType="VarChar(500)")]
		public string IMPORTE_CONTRATO
		{
			get
			{
				return this._IMPORTE_CONTRATO;
			}
			set
			{
				if ((this._IMPORTE_CONTRATO != value))
				{
					this._IMPORTE_CONTRATO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MONEDA", DbType="VarChar(500)")]
		public string MONEDA
		{
			get
			{
				return this._MONEDA;
			}
			set
			{
				if ((this._MONEDA != value))
				{
					this._MONEDA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTATUS_CONTRATO", DbType="VarChar(500)")]
		public string ESTATUS_CONTRATO
		{
			get
			{
				return this._ESTATUS_CONTRATO;
			}
			set
			{
				if ((this._ESTATUS_CONTRATO != value))
				{
					this._ESTATUS_CONTRATO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ARCHIVADO", DbType="VarChar(500)")]
		public string ARCHIVADO
		{
			get
			{
				return this._ARCHIVADO;
			}
			set
			{
				if ((this._ARCHIVADO != value))
				{
					this._ARCHIVADO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONVENIO_MODIFICATORIO", DbType="VarChar(500)")]
		public string CONVENIO_MODIFICATORIO
		{
			get
			{
				return this._CONVENIO_MODIFICATORIO;
			}
			set
			{
				if ((this._CONVENIO_MODIFICATORIO != value))
				{
					this._CONVENIO_MODIFICATORIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAMO", DbType="VarChar(500)")]
		public string RAMO
		{
			get
			{
				return this._RAMO;
			}
			set
			{
				if ((this._RAMO != value))
				{
					this._RAMO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLAVE_PROGRAMA", DbType="VarChar(500)")]
		public string CLAVE_PROGRAMA
		{
			get
			{
				return this._CLAVE_PROGRAMA;
			}
			set
			{
				if ((this._CLAVE_PROGRAMA != value))
				{
					this._CLAVE_PROGRAMA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APORTACION_FEDERAL", DbType="VarChar(500)")]
		public string APORTACION_FEDERAL
		{
			get
			{
				return this._APORTACION_FEDERAL;
			}
			set
			{
				if ((this._APORTACION_FEDERAL != value))
				{
					this._APORTACION_FEDERAL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_CELEBRACION", DbType="VarChar(500)")]
		public string FECHA_CELEBRACION
		{
			get
			{
				return this._FECHA_CELEBRACION;
			}
			set
			{
				if ((this._FECHA_CELEBRACION != value))
				{
					this._FECHA_CELEBRACION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTRATO_MARCO", DbType="VarChar(500)")]
		public string CONTRATO_MARCO
		{
			get
			{
				return this._CONTRATO_MARCO;
			}
			set
			{
				if ((this._CONTRATO_MARCO != value))
				{
					this._CONTRATO_MARCO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDENTIFICADOR_CM", DbType="VarChar(500)")]
		public string IDENTIFICADOR_CM
		{
			get
			{
				return this._IDENTIFICADOR_CM;
			}
			set
			{
				if ((this._IDENTIFICADOR_CM != value))
				{
					this._IDENTIFICADOR_CM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMPRA_CONSOLIDADA", DbType="VarChar(500)")]
		public string COMPRA_CONSOLIDADA
		{
			get
			{
				return this._COMPRA_CONSOLIDADA;
			}
			set
			{
				if ((this._COMPRA_CONSOLIDADA != value))
				{
					this._COMPRA_CONSOLIDADA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PLURIANUAL", DbType="VarChar(500)")]
		public string PLURIANUAL
		{
			get
			{
				return this._PLURIANUAL;
			}
			set
			{
				if ((this._PLURIANUAL != value))
				{
					this._PLURIANUAL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLAVE_CARTERA_SHCP", DbType="VarChar(500)")]
		public string CLAVE_CARTERA_SHCP
		{
			get
			{
				return this._CLAVE_CARTERA_SHCP;
			}
			set
			{
				if ((this._CLAVE_CARTERA_SHCP != value))
				{
					this._CLAVE_CARTERA_SHCP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTRATIFICACION_MUC", DbType="VarChar(500)")]
		public string ESTRATIFICACION_MUC
		{
			get
			{
				return this._ESTRATIFICACION_MUC;
			}
			set
			{
				if ((this._ESTRATIFICACION_MUC != value))
				{
					this._ESTRATIFICACION_MUC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FOLIO_RUPC", DbType="VarChar(500)")]
		public string FOLIO_RUPC
		{
			get
			{
				return this._FOLIO_RUPC;
			}
			set
			{
				if ((this._FOLIO_RUPC != value))
				{
					this._FOLIO_RUPC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROVEEDOR_CONTRATISTA", DbType="VarChar(500)")]
		public string PROVEEDOR_CONTRATISTA
		{
			get
			{
				return this._PROVEEDOR_CONTRATISTA;
			}
			set
			{
				if ((this._PROVEEDOR_CONTRATISTA != value))
				{
					this._PROVEEDOR_CONTRATISTA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTRATIFICACION_MPC", DbType="VarChar(500)")]
		public string ESTRATIFICACION_MPC
		{
			get
			{
				return this._ESTRATIFICACION_MPC;
			}
			set
			{
				if ((this._ESTRATIFICACION_MPC != value))
				{
					this._ESTRATIFICACION_MPC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SIGLAS_PAIS", DbType="VarChar(500)")]
		public string SIGLAS_PAIS
		{
			get
			{
				return this._SIGLAS_PAIS;
			}
			set
			{
				if ((this._SIGLAS_PAIS != value))
				{
					this._SIGLAS_PAIS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTATUS_EMPRESA", DbType="VarChar(500)")]
		public string ESTATUS_EMPRESA
		{
			get
			{
				return this._ESTATUS_EMPRESA;
			}
			set
			{
				if ((this._ESTATUS_EMPRESA != value))
				{
					this._ESTATUS_EMPRESA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUENTA_ADMINISTRADA_POR", DbType="VarChar(500)")]
		public string CUENTA_ADMINISTRADA_POR
		{
			get
			{
				return this._CUENTA_ADMINISTRADA_POR;
			}
			set
			{
				if ((this._CUENTA_ADMINISTRADA_POR != value))
				{
					this._CUENTA_ADMINISTRADA_POR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_EXTERNO", DbType="VarChar(500)")]
		public string C_EXTERNO
		{
			get
			{
				return this._C_EXTERNO;
			}
			set
			{
				if ((this._C_EXTERNO != value))
				{
					this._C_EXTERNO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ORGANISMO", DbType="VarChar(500)")]
		public string ORGANISMO
		{
			get
			{
				return this._ORGANISMO;
			}
			set
			{
				if ((this._ORGANISMO != value))
				{
					this._ORGANISMO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ANUNCIO", DbType="VarChar(500)")]
		public string ANUNCIO
		{
			get
			{
				return this._ANUNCIO;
			}
			set
			{
				if ((this._ANUNCIO != value))
				{
					this._ANUNCIO = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contratos2018Limpio")]
	public partial class Contratos2018Limpio
	{
		
		private string _Column_0;
		
		private string _GOBIERNO;
		
		private string _SIGLAS;
		
		private string _DEPENDENCIA;
		
		private string _CLAVEUC;
		
		private string _NOMBRE_DE_LA_UC;
		
		private string _RESPONSABLE;
		
		private string _CODIGO_EXPEDIENTE;
		
		private string _TITULO_EXPEDIENTE;
		
		private string _PLANTILLA_EXPEDIENTE;
		
		private string _NUMERO_PROCEDIMIENTO;
		
		private string _EXP_F_FALLO;
		
		private string _PROC_F_PUBLICACION;
		
		private string _FECHA_APERTURA_PROPOSICIONES;
		
		private string _CARACTER;
		
		private string _TIPO_CONTRATACION;
		
		private string _TIPO_PROCEDIMIENTO;
		
		private string _FORMA_PROCEDIMIENTO;
		
		private string _CODIGO_CONTRATO;
		
		private string _TITULO_CONTRATO;
		
		private string _FECHA_INICIO;
		
		private string _FECHA_FIN;
		
		private string _IMPORTE_CONTRATO;
		
		private string _MONEDA;
		
		private string _ESTATUS_CONTRATO;
		
		private string _ARCHIVADO;
		
		private string _CONVENIO_MODIFICATORIO;
		
		private string _RAMO;
		
		private string _CLAVE_PROGRAMA;
		
		private string _APORTACION_FEDERAL;
		
		private string _FECHA_CELEBRACION;
		
		private string _CONTRATO_MARCO;
		
		private string _IDENTIFICADOR_CM;
		
		private string _COMPRA_CONSOLIDADA;
		
		private string _PLURIANUAL;
		
		private string _CLAVE_CARTERA_SHCP;
		
		private string _ESTRATIFICACION_MUC;
		
		private string _FOLIO_RUPC;
		
		private string _PROVEEDOR_CONTRATISTA;
		
		private string _ESTRATIFICACION_MPC;
		
		private string _SIGLAS_PAIS;
		
		private string _ESTATUS_EMPRESA;
		
		private string _CUENTA_ADMINISTRADA_POR;
		
		private string _C_EXTERNO;
		
		private string _ORGANISMO;
		
		private string _ANUNCIO;
		
		public Contratos2018Limpio()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Column 0]", Storage="_Column_0", DbType="VarChar(50)")]
		public string Column_0
		{
			get
			{
				return this._Column_0;
			}
			set
			{
				if ((this._Column_0 != value))
				{
					this._Column_0 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GOBIERNO", DbType="VarChar(500)")]
		public string GOBIERNO
		{
			get
			{
				return this._GOBIERNO;
			}
			set
			{
				if ((this._GOBIERNO != value))
				{
					this._GOBIERNO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SIGLAS", DbType="VarChar(500)")]
		public string SIGLAS
		{
			get
			{
				return this._SIGLAS;
			}
			set
			{
				if ((this._SIGLAS != value))
				{
					this._SIGLAS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DEPENDENCIA", DbType="VarChar(500)")]
		public string DEPENDENCIA
		{
			get
			{
				return this._DEPENDENCIA;
			}
			set
			{
				if ((this._DEPENDENCIA != value))
				{
					this._DEPENDENCIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLAVEUC", DbType="VarChar(500)")]
		public string CLAVEUC
		{
			get
			{
				return this._CLAVEUC;
			}
			set
			{
				if ((this._CLAVEUC != value))
				{
					this._CLAVEUC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE_DE_LA_UC", DbType="VarChar(500)")]
		public string NOMBRE_DE_LA_UC
		{
			get
			{
				return this._NOMBRE_DE_LA_UC;
			}
			set
			{
				if ((this._NOMBRE_DE_LA_UC != value))
				{
					this._NOMBRE_DE_LA_UC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RESPONSABLE", DbType="VarChar(500)")]
		public string RESPONSABLE
		{
			get
			{
				return this._RESPONSABLE;
			}
			set
			{
				if ((this._RESPONSABLE != value))
				{
					this._RESPONSABLE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_EXPEDIENTE", DbType="VarChar(500)")]
		public string CODIGO_EXPEDIENTE
		{
			get
			{
				return this._CODIGO_EXPEDIENTE;
			}
			set
			{
				if ((this._CODIGO_EXPEDIENTE != value))
				{
					this._CODIGO_EXPEDIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITULO_EXPEDIENTE", DbType="VarChar(500)")]
		public string TITULO_EXPEDIENTE
		{
			get
			{
				return this._TITULO_EXPEDIENTE;
			}
			set
			{
				if ((this._TITULO_EXPEDIENTE != value))
				{
					this._TITULO_EXPEDIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PLANTILLA_EXPEDIENTE", DbType="VarChar(500)")]
		public string PLANTILLA_EXPEDIENTE
		{
			get
			{
				return this._PLANTILLA_EXPEDIENTE;
			}
			set
			{
				if ((this._PLANTILLA_EXPEDIENTE != value))
				{
					this._PLANTILLA_EXPEDIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMERO_PROCEDIMIENTO", DbType="VarChar(500)")]
		public string NUMERO_PROCEDIMIENTO
		{
			get
			{
				return this._NUMERO_PROCEDIMIENTO;
			}
			set
			{
				if ((this._NUMERO_PROCEDIMIENTO != value))
				{
					this._NUMERO_PROCEDIMIENTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EXP_F_FALLO", DbType="VarChar(500)")]
		public string EXP_F_FALLO
		{
			get
			{
				return this._EXP_F_FALLO;
			}
			set
			{
				if ((this._EXP_F_FALLO != value))
				{
					this._EXP_F_FALLO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROC_F_PUBLICACION", DbType="VarChar(500)")]
		public string PROC_F_PUBLICACION
		{
			get
			{
				return this._PROC_F_PUBLICACION;
			}
			set
			{
				if ((this._PROC_F_PUBLICACION != value))
				{
					this._PROC_F_PUBLICACION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_APERTURA_PROPOSICIONES", DbType="VarChar(500)")]
		public string FECHA_APERTURA_PROPOSICIONES
		{
			get
			{
				return this._FECHA_APERTURA_PROPOSICIONES;
			}
			set
			{
				if ((this._FECHA_APERTURA_PROPOSICIONES != value))
				{
					this._FECHA_APERTURA_PROPOSICIONES = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CARACTER", DbType="VarChar(500)")]
		public string CARACTER
		{
			get
			{
				return this._CARACTER;
			}
			set
			{
				if ((this._CARACTER != value))
				{
					this._CARACTER = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIPO_CONTRATACION", DbType="VarChar(500)")]
		public string TIPO_CONTRATACION
		{
			get
			{
				return this._TIPO_CONTRATACION;
			}
			set
			{
				if ((this._TIPO_CONTRATACION != value))
				{
					this._TIPO_CONTRATACION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TIPO_PROCEDIMIENTO", DbType="VarChar(500)")]
		public string TIPO_PROCEDIMIENTO
		{
			get
			{
				return this._TIPO_PROCEDIMIENTO;
			}
			set
			{
				if ((this._TIPO_PROCEDIMIENTO != value))
				{
					this._TIPO_PROCEDIMIENTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FORMA_PROCEDIMIENTO", DbType="VarChar(500)")]
		public string FORMA_PROCEDIMIENTO
		{
			get
			{
				return this._FORMA_PROCEDIMIENTO;
			}
			set
			{
				if ((this._FORMA_PROCEDIMIENTO != value))
				{
					this._FORMA_PROCEDIMIENTO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_CONTRATO", DbType="VarChar(500)")]
		public string CODIGO_CONTRATO
		{
			get
			{
				return this._CODIGO_CONTRATO;
			}
			set
			{
				if ((this._CODIGO_CONTRATO != value))
				{
					this._CODIGO_CONTRATO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITULO_CONTRATO", DbType="VarChar(500)")]
		public string TITULO_CONTRATO
		{
			get
			{
				return this._TITULO_CONTRATO;
			}
			set
			{
				if ((this._TITULO_CONTRATO != value))
				{
					this._TITULO_CONTRATO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_INICIO", DbType="VarChar(500)")]
		public string FECHA_INICIO
		{
			get
			{
				return this._FECHA_INICIO;
			}
			set
			{
				if ((this._FECHA_INICIO != value))
				{
					this._FECHA_INICIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_FIN", DbType="VarChar(500)")]
		public string FECHA_FIN
		{
			get
			{
				return this._FECHA_FIN;
			}
			set
			{
				if ((this._FECHA_FIN != value))
				{
					this._FECHA_FIN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMPORTE_CONTRATO", DbType="VarChar(500)")]
		public string IMPORTE_CONTRATO
		{
			get
			{
				return this._IMPORTE_CONTRATO;
			}
			set
			{
				if ((this._IMPORTE_CONTRATO != value))
				{
					this._IMPORTE_CONTRATO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MONEDA", DbType="VarChar(500)")]
		public string MONEDA
		{
			get
			{
				return this._MONEDA;
			}
			set
			{
				if ((this._MONEDA != value))
				{
					this._MONEDA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTATUS_CONTRATO", DbType="VarChar(500)")]
		public string ESTATUS_CONTRATO
		{
			get
			{
				return this._ESTATUS_CONTRATO;
			}
			set
			{
				if ((this._ESTATUS_CONTRATO != value))
				{
					this._ESTATUS_CONTRATO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ARCHIVADO", DbType="VarChar(500)")]
		public string ARCHIVADO
		{
			get
			{
				return this._ARCHIVADO;
			}
			set
			{
				if ((this._ARCHIVADO != value))
				{
					this._ARCHIVADO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONVENIO_MODIFICATORIO", DbType="VarChar(500)")]
		public string CONVENIO_MODIFICATORIO
		{
			get
			{
				return this._CONVENIO_MODIFICATORIO;
			}
			set
			{
				if ((this._CONVENIO_MODIFICATORIO != value))
				{
					this._CONVENIO_MODIFICATORIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAMO", DbType="VarChar(500)")]
		public string RAMO
		{
			get
			{
				return this._RAMO;
			}
			set
			{
				if ((this._RAMO != value))
				{
					this._RAMO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLAVE_PROGRAMA", DbType="VarChar(500)")]
		public string CLAVE_PROGRAMA
		{
			get
			{
				return this._CLAVE_PROGRAMA;
			}
			set
			{
				if ((this._CLAVE_PROGRAMA != value))
				{
					this._CLAVE_PROGRAMA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APORTACION_FEDERAL", DbType="VarChar(500)")]
		public string APORTACION_FEDERAL
		{
			get
			{
				return this._APORTACION_FEDERAL;
			}
			set
			{
				if ((this._APORTACION_FEDERAL != value))
				{
					this._APORTACION_FEDERAL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_CELEBRACION", DbType="VarChar(500)")]
		public string FECHA_CELEBRACION
		{
			get
			{
				return this._FECHA_CELEBRACION;
			}
			set
			{
				if ((this._FECHA_CELEBRACION != value))
				{
					this._FECHA_CELEBRACION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTRATO_MARCO", DbType="VarChar(500)")]
		public string CONTRATO_MARCO
		{
			get
			{
				return this._CONTRATO_MARCO;
			}
			set
			{
				if ((this._CONTRATO_MARCO != value))
				{
					this._CONTRATO_MARCO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDENTIFICADOR_CM", DbType="VarChar(500)")]
		public string IDENTIFICADOR_CM
		{
			get
			{
				return this._IDENTIFICADOR_CM;
			}
			set
			{
				if ((this._IDENTIFICADOR_CM != value))
				{
					this._IDENTIFICADOR_CM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMPRA_CONSOLIDADA", DbType="VarChar(500)")]
		public string COMPRA_CONSOLIDADA
		{
			get
			{
				return this._COMPRA_CONSOLIDADA;
			}
			set
			{
				if ((this._COMPRA_CONSOLIDADA != value))
				{
					this._COMPRA_CONSOLIDADA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PLURIANUAL", DbType="VarChar(500)")]
		public string PLURIANUAL
		{
			get
			{
				return this._PLURIANUAL;
			}
			set
			{
				if ((this._PLURIANUAL != value))
				{
					this._PLURIANUAL = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLAVE_CARTERA_SHCP", DbType="VarChar(500)")]
		public string CLAVE_CARTERA_SHCP
		{
			get
			{
				return this._CLAVE_CARTERA_SHCP;
			}
			set
			{
				if ((this._CLAVE_CARTERA_SHCP != value))
				{
					this._CLAVE_CARTERA_SHCP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTRATIFICACION_MUC", DbType="VarChar(500)")]
		public string ESTRATIFICACION_MUC
		{
			get
			{
				return this._ESTRATIFICACION_MUC;
			}
			set
			{
				if ((this._ESTRATIFICACION_MUC != value))
				{
					this._ESTRATIFICACION_MUC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FOLIO_RUPC", DbType="VarChar(500)")]
		public string FOLIO_RUPC
		{
			get
			{
				return this._FOLIO_RUPC;
			}
			set
			{
				if ((this._FOLIO_RUPC != value))
				{
					this._FOLIO_RUPC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PROVEEDOR_CONTRATISTA", DbType="VarChar(500)")]
		public string PROVEEDOR_CONTRATISTA
		{
			get
			{
				return this._PROVEEDOR_CONTRATISTA;
			}
			set
			{
				if ((this._PROVEEDOR_CONTRATISTA != value))
				{
					this._PROVEEDOR_CONTRATISTA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTRATIFICACION_MPC", DbType="VarChar(500)")]
		public string ESTRATIFICACION_MPC
		{
			get
			{
				return this._ESTRATIFICACION_MPC;
			}
			set
			{
				if ((this._ESTRATIFICACION_MPC != value))
				{
					this._ESTRATIFICACION_MPC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SIGLAS_PAIS", DbType="VarChar(500)")]
		public string SIGLAS_PAIS
		{
			get
			{
				return this._SIGLAS_PAIS;
			}
			set
			{
				if ((this._SIGLAS_PAIS != value))
				{
					this._SIGLAS_PAIS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTATUS_EMPRESA", DbType="VarChar(500)")]
		public string ESTATUS_EMPRESA
		{
			get
			{
				return this._ESTATUS_EMPRESA;
			}
			set
			{
				if ((this._ESTATUS_EMPRESA != value))
				{
					this._ESTATUS_EMPRESA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUENTA_ADMINISTRADA_POR", DbType="VarChar(500)")]
		public string CUENTA_ADMINISTRADA_POR
		{
			get
			{
				return this._CUENTA_ADMINISTRADA_POR;
			}
			set
			{
				if ((this._CUENTA_ADMINISTRADA_POR != value))
				{
					this._CUENTA_ADMINISTRADA_POR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_EXTERNO", DbType="VarChar(500)")]
		public string C_EXTERNO
		{
			get
			{
				return this._C_EXTERNO;
			}
			set
			{
				if ((this._C_EXTERNO != value))
				{
					this._C_EXTERNO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ORGANISMO", DbType="VarChar(500)")]
		public string ORGANISMO
		{
			get
			{
				return this._ORGANISMO;
			}
			set
			{
				if ((this._ORGANISMO != value))
				{
					this._ORGANISMO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ANUNCIO", DbType="VarChar(500)")]
		public string ANUNCIO
		{
			get
			{
				return this._ANUNCIO;
			}
			set
			{
				if ((this._ANUNCIO != value))
				{
					this._ANUNCIO = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
