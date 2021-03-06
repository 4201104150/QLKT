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

namespace FinalProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyNhieuDayTro")]
	public partial class DataQLNKTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCHUQUANLY(CHUQUANLY instance);
    partial void UpdateCHUQUANLY(CHUQUANLY instance);
    partial void DeleteCHUQUANLY(CHUQUANLY instance);
    partial void InsertKHUTRO(KHUTRO instance);
    partial void UpdateKHUTRO(KHUTRO instance);
    partial void DeleteKHUTRO(KHUTRO instance);
    partial void InsertNGUOIQUANLY(NGUOIQUANLY instance);
    partial void UpdateNGUOIQUANLY(NGUOIQUANLY instance);
    partial void DeleteNGUOIQUANLY(NGUOIQUANLY instance);
    partial void InsertNGUOITHUE(NGUOITHUE instance);
    partial void UpdateNGUOITHUE(NGUOITHUE instance);
    partial void DeleteNGUOITHUE(NGUOITHUE instance);
    partial void InsertPHONGTRO(PHONGTRO instance);
    partial void UpdatePHONGTRO(PHONGTRO instance);
    partial void DeletePHONGTRO(PHONGTRO instance);
    #endregion
		
		public DataQLNKTDataContext() : 
				base(global::FinalProject.Properties.Settings.Default.QuanLyNhieuDayTroConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLNKTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLNKTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLNKTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLNKTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CHUQUANLY> CHUQUANLies
		{
			get
			{
				return this.GetTable<CHUQUANLY>();
			}
		}
		
		public System.Data.Linq.Table<KHUTRO> KHUTROs
		{
			get
			{
				return this.GetTable<KHUTRO>();
			}
		}
		
		public System.Data.Linq.Table<NGUOIQUANLY> NGUOIQUANLies
		{
			get
			{
				return this.GetTable<NGUOIQUANLY>();
			}
		}
		
		public System.Data.Linq.Table<NGUOITHUE> NGUOITHUEs
		{
			get
			{
				return this.GetTable<NGUOITHUE>();
			}
		}
		
		public System.Data.Linq.Table<PHONGTRO> PHONGTROs
		{
			get
			{
				return this.GetTable<PHONGTRO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHUQUANLY")]
	public partial class CHUQUANLY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDCHUQUANLY;
		
		private string _PASSBOSS;
		
		private string _HOTEN;
		
		private System.DateTime _NGAYSINH;
		
		private string _CMND;
		
		private string _DIACHI;
		
		private string _SDT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCHUQUANLYChanging(string value);
    partial void OnIDCHUQUANLYChanged();
    partial void OnPASSBOSSChanging(string value);
    partial void OnPASSBOSSChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnNGAYSINHChanging(System.DateTime value);
    partial void OnNGAYSINHChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public CHUQUANLY()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCHUQUANLY", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDCHUQUANLY
		{
			get
			{
				return this._IDCHUQUANLY;
			}
			set
			{
				if ((this._IDCHUQUANLY != value))
				{
					this.OnIDCHUQUANLYChanging(value);
					this.SendPropertyChanging();
					this._IDCHUQUANLY = value;
					this.SendPropertyChanged("IDCHUQUANLY");
					this.OnIDCHUQUANLYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSBOSS", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string PASSBOSS
		{
			get
			{
				return this._PASSBOSS;
			}
			set
			{
				if ((this._PASSBOSS != value))
				{
					this.OnPASSBOSSChanging(value);
					this.SendPropertyChanging();
					this._PASSBOSS = value;
					this.SendPropertyChanged("PASSBOSS");
					this.OnPASSBOSSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="Date NOT NULL")]
		public System.DateTime NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="NVarChar(30)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHUTRO")]
	public partial class KHUTRO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDKHUTRO;
		
		private string _TENKHUTRO;
		
		private string _DIACHI;
		
		private EntitySet<NGUOIQUANLY> _NGUOIQUANLies;
		
		private EntitySet<PHONGTRO> _PHONGTROs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDKHUTROChanging(string value);
    partial void OnIDKHUTROChanged();
    partial void OnTENKHUTROChanging(string value);
    partial void OnTENKHUTROChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    #endregion
		
		public KHUTRO()
		{
			this._NGUOIQUANLies = new EntitySet<NGUOIQUANLY>(new Action<NGUOIQUANLY>(this.attach_NGUOIQUANLies), new Action<NGUOIQUANLY>(this.detach_NGUOIQUANLies));
			this._PHONGTROs = new EntitySet<PHONGTRO>(new Action<PHONGTRO>(this.attach_PHONGTROs), new Action<PHONGTRO>(this.detach_PHONGTROs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDKHUTRO", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDKHUTRO
		{
			get
			{
				return this._IDKHUTRO;
			}
			set
			{
				if ((this._IDKHUTRO != value))
				{
					this.OnIDKHUTROChanging(value);
					this.SendPropertyChanging();
					this._IDKHUTRO = value;
					this.SendPropertyChanged("IDKHUTRO");
					this.OnIDKHUTROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKHUTRO", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string TENKHUTRO
		{
			get
			{
				return this._TENKHUTRO;
			}
			set
			{
				if ((this._TENKHUTRO != value))
				{
					this.OnTENKHUTROChanging(value);
					this.SendPropertyChanging();
					this._TENKHUTRO = value;
					this.SendPropertyChanged("TENKHUTRO");
					this.OnTENKHUTROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHUTRO_NGUOIQUANLY", Storage="_NGUOIQUANLies", ThisKey="IDKHUTRO", OtherKey="IDKHUTRO")]
		public EntitySet<NGUOIQUANLY> NGUOIQUANLies
		{
			get
			{
				return this._NGUOIQUANLies;
			}
			set
			{
				this._NGUOIQUANLies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHUTRO_PHONGTRO", Storage="_PHONGTROs", ThisKey="IDKHUTRO", OtherKey="IDKHUTRO")]
		public EntitySet<PHONGTRO> PHONGTROs
		{
			get
			{
				return this._PHONGTROs;
			}
			set
			{
				this._PHONGTROs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_NGUOIQUANLies(NGUOIQUANLY entity)
		{
			this.SendPropertyChanging();
			entity.KHUTRO = this;
		}
		
		private void detach_NGUOIQUANLies(NGUOIQUANLY entity)
		{
			this.SendPropertyChanging();
			entity.KHUTRO = null;
		}
		
		private void attach_PHONGTROs(PHONGTRO entity)
		{
			this.SendPropertyChanging();
			entity.KHUTRO = this;
		}
		
		private void detach_PHONGTROs(PHONGTRO entity)
		{
			this.SendPropertyChanging();
			entity.KHUTRO = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NGUOIQUANLY")]
	public partial class NGUOIQUANLY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDNGUOIQUANLY;
		
		private string _PASSNGQL;
		
		private string _HOTEN;
		
		private System.DateTime _NGAYSINH;
		
		private string _CMND;
		
		private string _DIACHI;
		
		private string _SDT;
		
		private string _IDKHUTRO;
		
		private EntityRef<KHUTRO> _KHUTRO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDNGUOIQUANLYChanging(string value);
    partial void OnIDNGUOIQUANLYChanged();
    partial void OnPASSNGQLChanging(string value);
    partial void OnPASSNGQLChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnNGAYSINHChanging(System.DateTime value);
    partial void OnNGAYSINHChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnIDKHUTROChanging(string value);
    partial void OnIDKHUTROChanged();
    #endregion
		
		public NGUOIQUANLY()
		{
			this._KHUTRO = default(EntityRef<KHUTRO>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNGUOIQUANLY", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDNGUOIQUANLY
		{
			get
			{
				return this._IDNGUOIQUANLY;
			}
			set
			{
				if ((this._IDNGUOIQUANLY != value))
				{
					this.OnIDNGUOIQUANLYChanging(value);
					this.SendPropertyChanging();
					this._IDNGUOIQUANLY = value;
					this.SendPropertyChanged("IDNGUOIQUANLY");
					this.OnIDNGUOIQUANLYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSNGQL", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string PASSNGQL
		{
			get
			{
				return this._PASSNGQL;
			}
			set
			{
				if ((this._PASSNGQL != value))
				{
					this.OnPASSNGQLChanging(value);
					this.SendPropertyChanging();
					this._PASSNGQL = value;
					this.SendPropertyChanged("PASSNGQL");
					this.OnPASSNGQLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="Date NOT NULL")]
		public System.DateTime NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="NVarChar(30)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDKHUTRO", DbType="NVarChar(10)")]
		public string IDKHUTRO
		{
			get
			{
				return this._IDKHUTRO;
			}
			set
			{
				if ((this._IDKHUTRO != value))
				{
					if (this._KHUTRO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDKHUTROChanging(value);
					this.SendPropertyChanging();
					this._IDKHUTRO = value;
					this.SendPropertyChanged("IDKHUTRO");
					this.OnIDKHUTROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHUTRO_NGUOIQUANLY", Storage="_KHUTRO", ThisKey="IDKHUTRO", OtherKey="IDKHUTRO", IsForeignKey=true)]
		public KHUTRO KHUTRO
		{
			get
			{
				return this._KHUTRO.Entity;
			}
			set
			{
				KHUTRO previousValue = this._KHUTRO.Entity;
				if (((previousValue != value) 
							|| (this._KHUTRO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHUTRO.Entity = null;
						previousValue.NGUOIQUANLies.Remove(this);
					}
					this._KHUTRO.Entity = value;
					if ((value != null))
					{
						value.NGUOIQUANLies.Add(this);
						this._IDKHUTRO = value.IDKHUTRO;
					}
					else
					{
						this._IDKHUTRO = default(string);
					}
					this.SendPropertyChanged("KHUTRO");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NGUOITHUE")]
	public partial class NGUOITHUE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDNGUOITHUE;
		
		private string _HOTEN;
		
		private System.DateTime _NGAYSINH;
		
		private string _CMND;
		
		private string _DIACHI;
		
		private string _SDT;
		
		private string _IDPHONG;
		
		private EntityRef<PHONGTRO> _PHONGTRO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDNGUOITHUEChanging(string value);
    partial void OnIDNGUOITHUEChanged();
    partial void OnHOTENChanging(string value);
    partial void OnHOTENChanged();
    partial void OnNGAYSINHChanging(System.DateTime value);
    partial void OnNGAYSINHChanged();
    partial void OnCMNDChanging(string value);
    partial void OnCMNDChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnIDPHONGChanging(string value);
    partial void OnIDPHONGChanged();
    #endregion
		
		public NGUOITHUE()
		{
			this._PHONGTRO = default(EntityRef<PHONGTRO>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNGUOITHUE", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDNGUOITHUE
		{
			get
			{
				return this._IDNGUOITHUE;
			}
			set
			{
				if ((this._IDNGUOITHUE != value))
				{
					this.OnIDNGUOITHUEChanging(value);
					this.SendPropertyChanging();
					this._IDNGUOITHUE = value;
					this.SendPropertyChanged("IDNGUOITHUE");
					this.OnIDNGUOITHUEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOTEN", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string HOTEN
		{
			get
			{
				return this._HOTEN;
			}
			set
			{
				if ((this._HOTEN != value))
				{
					this.OnHOTENChanging(value);
					this.SendPropertyChanging();
					this._HOTEN = value;
					this.SendPropertyChanged("HOTEN");
					this.OnHOTENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="Date NOT NULL")]
		public System.DateTime NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CMND", DbType="NVarChar(30)")]
		public string CMND
		{
			get
			{
				return this._CMND;
			}
			set
			{
				if ((this._CMND != value))
				{
					this.OnCMNDChanging(value);
					this.SendPropertyChanging();
					this._CMND = value;
					this.SendPropertyChanged("CMND");
					this.OnCMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDPHONG", DbType="NVarChar(10)")]
		public string IDPHONG
		{
			get
			{
				return this._IDPHONG;
			}
			set
			{
				if ((this._IDPHONG != value))
				{
					if (this._PHONGTRO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDPHONGChanging(value);
					this.SendPropertyChanging();
					this._IDPHONG = value;
					this.SendPropertyChanged("IDPHONG");
					this.OnIDPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHONGTRO_NGUOITHUE", Storage="_PHONGTRO", ThisKey="IDPHONG", OtherKey="IDPHONGTRO", IsForeignKey=true)]
		public PHONGTRO PHONGTRO
		{
			get
			{
				return this._PHONGTRO.Entity;
			}
			set
			{
				PHONGTRO previousValue = this._PHONGTRO.Entity;
				if (((previousValue != value) 
							|| (this._PHONGTRO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHONGTRO.Entity = null;
						previousValue.NGUOITHUEs.Remove(this);
					}
					this._PHONGTRO.Entity = value;
					if ((value != null))
					{
						value.NGUOITHUEs.Add(this);
						this._IDPHONG = value.IDPHONGTRO;
					}
					else
					{
						this._IDPHONG = default(string);
					}
					this.SendPropertyChanged("PHONGTRO");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHONGTRO")]
	public partial class PHONGTRO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDPHONGTRO;
		
		private string _CHATLUONGPHONG;
		
		private System.Nullable<int> _GIATIEN;
		
		private int _DIENTICH;
		
		private System.Nullable<int> _TINHTRANGPHONG;
		
		private int _SONGUOITOIDA;
		
		private string _IDKHUTRO;
		
		private EntitySet<NGUOITHUE> _NGUOITHUEs;
		
		private EntityRef<KHUTRO> _KHUTRO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDPHONGTROChanging(string value);
    partial void OnIDPHONGTROChanged();
    partial void OnCHATLUONGPHONGChanging(string value);
    partial void OnCHATLUONGPHONGChanged();
    partial void OnGIATIENChanging(System.Nullable<int> value);
    partial void OnGIATIENChanged();
    partial void OnDIENTICHChanging(int value);
    partial void OnDIENTICHChanged();
    partial void OnTINHTRANGPHONGChanging(System.Nullable<int> value);
    partial void OnTINHTRANGPHONGChanged();
    partial void OnSONGUOITOIDAChanging(int value);
    partial void OnSONGUOITOIDAChanged();
    partial void OnIDKHUTROChanging(string value);
    partial void OnIDKHUTROChanged();
    #endregion
		
		public PHONGTRO()
		{
			this._NGUOITHUEs = new EntitySet<NGUOITHUE>(new Action<NGUOITHUE>(this.attach_NGUOITHUEs), new Action<NGUOITHUE>(this.detach_NGUOITHUEs));
			this._KHUTRO = default(EntityRef<KHUTRO>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDPHONGTRO", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDPHONGTRO
		{
			get
			{
				return this._IDPHONGTRO;
			}
			set
			{
				if ((this._IDPHONGTRO != value))
				{
					this.OnIDPHONGTROChanging(value);
					this.SendPropertyChanging();
					this._IDPHONGTRO = value;
					this.SendPropertyChanged("IDPHONGTRO");
					this.OnIDPHONGTROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CHATLUONGPHONG", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string CHATLUONGPHONG
		{
			get
			{
				return this._CHATLUONGPHONG;
			}
			set
			{
				if ((this._CHATLUONGPHONG != value))
				{
					this.OnCHATLUONGPHONGChanging(value);
					this.SendPropertyChanging();
					this._CHATLUONGPHONG = value;
					this.SendPropertyChanged("CHATLUONGPHONG");
					this.OnCHATLUONGPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIATIEN", DbType="Int")]
		public System.Nullable<int> GIATIEN
		{
			get
			{
				return this._GIATIEN;
			}
			set
			{
				if ((this._GIATIEN != value))
				{
					this.OnGIATIENChanging(value);
					this.SendPropertyChanging();
					this._GIATIEN = value;
					this.SendPropertyChanged("GIATIEN");
					this.OnGIATIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIENTICH", DbType="Int NOT NULL")]
		public int DIENTICH
		{
			get
			{
				return this._DIENTICH;
			}
			set
			{
				if ((this._DIENTICH != value))
				{
					this.OnDIENTICHChanging(value);
					this.SendPropertyChanging();
					this._DIENTICH = value;
					this.SendPropertyChanged("DIENTICH");
					this.OnDIENTICHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TINHTRANGPHONG", DbType="Int")]
		public System.Nullable<int> TINHTRANGPHONG
		{
			get
			{
				return this._TINHTRANGPHONG;
			}
			set
			{
				if ((this._TINHTRANGPHONG != value))
				{
					this.OnTINHTRANGPHONGChanging(value);
					this.SendPropertyChanging();
					this._TINHTRANGPHONG = value;
					this.SendPropertyChanged("TINHTRANGPHONG");
					this.OnTINHTRANGPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SONGUOITOIDA", DbType="Int NOT NULL")]
		public int SONGUOITOIDA
		{
			get
			{
				return this._SONGUOITOIDA;
			}
			set
			{
				if ((this._SONGUOITOIDA != value))
				{
					this.OnSONGUOITOIDAChanging(value);
					this.SendPropertyChanging();
					this._SONGUOITOIDA = value;
					this.SendPropertyChanged("SONGUOITOIDA");
					this.OnSONGUOITOIDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDKHUTRO", DbType="NVarChar(10)")]
		public string IDKHUTRO
		{
			get
			{
				return this._IDKHUTRO;
			}
			set
			{
				if ((this._IDKHUTRO != value))
				{
					if (this._KHUTRO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDKHUTROChanging(value);
					this.SendPropertyChanging();
					this._IDKHUTRO = value;
					this.SendPropertyChanged("IDKHUTRO");
					this.OnIDKHUTROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHONGTRO_NGUOITHUE", Storage="_NGUOITHUEs", ThisKey="IDPHONGTRO", OtherKey="IDPHONG")]
		public EntitySet<NGUOITHUE> NGUOITHUEs
		{
			get
			{
				return this._NGUOITHUEs;
			}
			set
			{
				this._NGUOITHUEs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHUTRO_PHONGTRO", Storage="_KHUTRO", ThisKey="IDKHUTRO", OtherKey="IDKHUTRO", IsForeignKey=true)]
		public KHUTRO KHUTRO
		{
			get
			{
				return this._KHUTRO.Entity;
			}
			set
			{
				KHUTRO previousValue = this._KHUTRO.Entity;
				if (((previousValue != value) 
							|| (this._KHUTRO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHUTRO.Entity = null;
						previousValue.PHONGTROs.Remove(this);
					}
					this._KHUTRO.Entity = value;
					if ((value != null))
					{
						value.PHONGTROs.Add(this);
						this._IDKHUTRO = value.IDKHUTRO;
					}
					else
					{
						this._IDKHUTRO = default(string);
					}
					this.SendPropertyChanged("KHUTRO");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_NGUOITHUEs(NGUOITHUE entity)
		{
			this.SendPropertyChanging();
			entity.PHONGTRO = this;
		}
		
		private void detach_NGUOITHUEs(NGUOITHUE entity)
		{
			this.SendPropertyChanging();
			entity.PHONGTRO = null;
		}
	}
}
#pragma warning restore 1591
