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

namespace CarStore.DataLayer.DBML
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="carStoreDb")]
	public partial class DataFactoryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUserData(UserData instance);
    partial void UpdateUserData(UserData instance);
    partial void DeleteUserData(UserData instance);
    #endregion
		
		public DataFactoryDataContext() : 
				base(global::CarStore.DataLayer.Properties.Settings.Default.carStoreDbConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public DataFactoryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataFactoryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataFactoryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataFactoryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<UserData> UserDatas
		{
			get
			{
				return this.GetTable<UserData>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procDeleteProduct")]
		public int procDeleteProduct([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductId", DbType="UniqueIdentifier")] System.Nullable<System.Guid> productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), productId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procGetCategory")]
		public ISingleResult<procGetCategoryResult> procGetCategory()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<procGetCategoryResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procGetProductId")]
		public ISingleResult<procGetProductIdResult> procGetProductId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductId", DbType="UniqueIdentifier")] System.Nullable<System.Guid> productId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), productId);
			return ((ISingleResult<procGetProductIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procGetProducts")]
		public ISingleResult<procGetProductsResult> procGetProducts()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<procGetProductsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procGetUserDetails")]
		public ISingleResult<procGetUserDetailsResult> procGetUserDetails([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(50)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), email, password);
			return ((ISingleResult<procGetUserDetailsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procSortProduct")]
		public ISingleResult<procSortProductResult> procSortProduct([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SortCriteria", DbType="NVarChar(255)")] string sortCriteria)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sortCriteria);
			return ((ISingleResult<procSortProductResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procUpsertBasket")]
		public ISingleResult<procUpsertBasketResult> procUpsertBasket([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductId", DbType="UniqueIdentifier")] System.Nullable<System.Guid> productId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Quantity", DbType="Int")] System.Nullable<int> quantity, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Price", DbType="Decimal(10,2)")] System.Nullable<decimal> price)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId, productId, quantity, price);
			return ((ISingleResult<procUpsertBasketResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procUpsertProduct")]
		public ISingleResult<procUpsertProductResult> procUpsertProduct([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductId", DbType="UniqueIdentifier")] System.Nullable<System.Guid> productId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductName", DbType="NVarChar(20)")] string productName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CategoriesName", DbType="NVarChar(20)")] string categoriesName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Image", DbType="NVarChar(255)")] string image, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Price", DbType="Decimal(10,2)")] System.Nullable<decimal> price, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Rating", DbType="Int")] System.Nullable<int> rating, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HoverImage", DbType="NVarChar(255)")] string hoverImage, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IndicatorImage", DbType="NVarChar(255)")] string indicatorImage, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(MAX)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Short_Description", DbType="NVarChar(255)")] string short_Description)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), productId, productName, categoriesName, image, price, rating, hoverImage, indicatorImage, description, short_Description);
			return ((ISingleResult<procUpsertProductResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.procInsertUserData")]
		public ISingleResult<procInsertUserDataResult> procInsertUserData([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(20)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="NVarChar(30)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(255)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(10)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Department", DbType="NVarChar(20)")] string department, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hobbies", DbType="NVarChar(50)")] string hobbies)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, email, password, gender, department, hobbies);
			return ((ISingleResult<procInsertUserDataResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserData")]
	public partial class UserData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private string _Gender;
		
		private string _Hobbies;
		
		private string _Department;
		
		private System.Nullable<System.DateTime> _Created;
		
		private string _CreatedBy;
		
		private System.Nullable<System.DateTime> _LastUpdate;
		
		private string _LastUpdatedBy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnHobbiesChanging(string value);
    partial void OnHobbiesChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnCreatedChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnLastUpdateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastUpdateChanged();
    partial void OnLastUpdatedByChanging(string value);
    partial void OnLastUpdatedByChanged();
    #endregion
		
		public UserData()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hobbies", DbType="NVarChar(255)")]
		public string Hobbies
		{
			get
			{
				return this._Hobbies;
			}
			set
			{
				if ((this._Hobbies != value))
				{
					this.OnHobbiesChanging(value);
					this.SendPropertyChanging();
					this._Hobbies = value;
					this.SendPropertyChanged("Hobbies");
					this.OnHobbiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="NVarChar(30)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="Date")]
		public System.Nullable<System.DateTime> Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedBy", DbType="NVarChar(100)")]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpdate", DbType="Date")]
		public System.Nullable<System.DateTime> LastUpdate
		{
			get
			{
				return this._LastUpdate;
			}
			set
			{
				if ((this._LastUpdate != value))
				{
					this.OnLastUpdateChanging(value);
					this.SendPropertyChanging();
					this._LastUpdate = value;
					this.SendPropertyChanged("LastUpdate");
					this.OnLastUpdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastUpdatedBy", DbType="NVarChar(100)")]
		public string LastUpdatedBy
		{
			get
			{
				return this._LastUpdatedBy;
			}
			set
			{
				if ((this._LastUpdatedBy != value))
				{
					this.OnLastUpdatedByChanging(value);
					this.SendPropertyChanging();
					this._LastUpdatedBy = value;
					this.SendPropertyChanged("LastUpdatedBy");
					this.OnLastUpdatedByChanged();
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
	
	public partial class procGetCategoryResult
	{
		
		private int _Id;
		
		private string _categoriesName;
		
		private string _ClothingItem;
		
		private string _VehicleBracelets;
		
		private string _VehicleRings;
		
		private string _Shoes;
		
		private string _Lingeries;
		
		public procGetCategoryResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoriesName", DbType="NVarChar(255)")]
		public string categoriesName
		{
			get
			{
				return this._categoriesName;
			}
			set
			{
				if ((this._categoriesName != value))
				{
					this._categoriesName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClothingItem", DbType="NVarChar(255)")]
		public string ClothingItem
		{
			get
			{
				return this._ClothingItem;
			}
			set
			{
				if ((this._ClothingItem != value))
				{
					this._ClothingItem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleBracelets", DbType="NVarChar(255)")]
		public string VehicleBracelets
		{
			get
			{
				return this._VehicleBracelets;
			}
			set
			{
				if ((this._VehicleBracelets != value))
				{
					this._VehicleBracelets = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VehicleRings", DbType="NVarChar(255)")]
		public string VehicleRings
		{
			get
			{
				return this._VehicleRings;
			}
			set
			{
				if ((this._VehicleRings != value))
				{
					this._VehicleRings = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Shoes", DbType="NVarChar(255)")]
		public string Shoes
		{
			get
			{
				return this._Shoes;
			}
			set
			{
				if ((this._Shoes != value))
				{
					this._Shoes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lingeries", DbType="NVarChar(255)")]
		public string Lingeries
		{
			get
			{
				return this._Lingeries;
			}
			set
			{
				if ((this._Lingeries != value))
				{
					this._Lingeries = value;
				}
			}
		}
	}
	
	public partial class procGetProductIdResult
	{
		
		private System.Guid _ProductId;
		
		private string _ProductName;
		
		private string _Categories;
		
		private string _Image;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<decimal> _Rating;
		
		private string _HoverImage;
		
		private string _IndicatorImage;
		
		private string _Description;
		
		private string _Short_Description;
		
		public procGetProductIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this._ProductId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(255)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this._ProductName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categories", DbType="NVarChar(255)")]
		public string Categories
		{
			get
			{
				return this._Categories;
			}
			set
			{
				if ((this._Categories != value))
				{
					this._Categories = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(255)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this._Image = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Decimal(10,1)")]
		public System.Nullable<decimal> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this._Rating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoverImage", DbType="NVarChar(255)")]
		public string HoverImage
		{
			get
			{
				return this._HoverImage;
			}
			set
			{
				if ((this._HoverImage != value))
				{
					this._HoverImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndicatorImage", DbType="NVarChar(255)")]
		public string IndicatorImage
		{
			get
			{
				return this._IndicatorImage;
			}
			set
			{
				if ((this._IndicatorImage != value))
				{
					this._IndicatorImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Short_Description", DbType="NVarChar(MAX)")]
		public string Short_Description
		{
			get
			{
				return this._Short_Description;
			}
			set
			{
				if ((this._Short_Description != value))
				{
					this._Short_Description = value;
				}
			}
		}
	}
	
	public partial class procGetProductsResult
	{
		
		private System.Guid _ProductId;
		
		private string _ProductName;
		
		private string _Categories;
		
		private string _Image;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<decimal> _Rating;
		
		private string _HoverImage;
		
		private string _IndicatorImage;
		
		private string _Description;
		
		private string _Short_Description;
		
		public procGetProductsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this._ProductId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(255)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this._ProductName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categories", DbType="NVarChar(255)")]
		public string Categories
		{
			get
			{
				return this._Categories;
			}
			set
			{
				if ((this._Categories != value))
				{
					this._Categories = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(255)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this._Image = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Decimal(10,1)")]
		public System.Nullable<decimal> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this._Rating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoverImage", DbType="NVarChar(255)")]
		public string HoverImage
		{
			get
			{
				return this._HoverImage;
			}
			set
			{
				if ((this._HoverImage != value))
				{
					this._HoverImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndicatorImage", DbType="NVarChar(255)")]
		public string IndicatorImage
		{
			get
			{
				return this._IndicatorImage;
			}
			set
			{
				if ((this._IndicatorImage != value))
				{
					this._IndicatorImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Short_Description", DbType="NVarChar(MAX)")]
		public string Short_Description
		{
			get
			{
				return this._Short_Description;
			}
			set
			{
				if ((this._Short_Description != value))
				{
					this._Short_Description = value;
				}
			}
		}
	}
	
	public partial class procGetUserDetailsResult
	{
		
		private int _Id;
		
		private string _Name;
		
		private string _Email;
		
		private string _Password;
		
		private string _Gender;
		
		private string _Hobbies;
		
		public procGetUserDetailsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(10)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hobbies", DbType="NVarChar(255)")]
		public string Hobbies
		{
			get
			{
				return this._Hobbies;
			}
			set
			{
				if ((this._Hobbies != value))
				{
					this._Hobbies = value;
				}
			}
		}
	}
	
	public partial class procSortProductResult
	{
		
		private System.Guid _ProductId;
		
		private string _ProductName;
		
		private string _Categories;
		
		private string _Image;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<decimal> _Rating;
		
		private string _HoverImage;
		
		private string _IndicatorImage;
		
		private string _Description;
		
		private string _Short_Description;
		
		public procSortProductResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this._ProductId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(255)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this._ProductName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categories", DbType="NVarChar(255)")]
		public string Categories
		{
			get
			{
				return this._Categories;
			}
			set
			{
				if ((this._Categories != value))
				{
					this._Categories = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(255)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this._Image = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Decimal(10,1)")]
		public System.Nullable<decimal> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this._Rating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoverImage", DbType="NVarChar(255)")]
		public string HoverImage
		{
			get
			{
				return this._HoverImage;
			}
			set
			{
				if ((this._HoverImage != value))
				{
					this._HoverImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndicatorImage", DbType="NVarChar(255)")]
		public string IndicatorImage
		{
			get
			{
				return this._IndicatorImage;
			}
			set
			{
				if ((this._IndicatorImage != value))
				{
					this._IndicatorImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Short_Description", DbType="NVarChar(MAX)")]
		public string Short_Description
		{
			get
			{
				return this._Short_Description;
			}
			set
			{
				if ((this._Short_Description != value))
				{
					this._Short_Description = value;
				}
			}
		}
	}
	
	public partial class procUpsertBasketResult
	{
		
		private System.Nullable<bool> _IsValid;
		
		private string _Message;
		
		public procUpsertBasketResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsValid", DbType="Bit")]
		public System.Nullable<bool> IsValid
		{
			get
			{
				return this._IsValid;
			}
			set
			{
				if ((this._IsValid != value))
				{
					this._IsValid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="NVarChar(50)")]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this._Message = value;
				}
			}
		}
	}
	
	public partial class procUpsertProductResult
	{
		
		private System.Nullable<bool> _IsValid;
		
		private string _Message;
		
		public procUpsertProductResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsValid", DbType="Bit")]
		public System.Nullable<bool> IsValid
		{
			get
			{
				return this._IsValid;
			}
			set
			{
				if ((this._IsValid != value))
				{
					this._IsValid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="NVarChar(50)")]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this._Message = value;
				}
			}
		}
	}
	
	public partial class procInsertUserDataResult
	{
		
		private System.Nullable<bool> _IsValid;
		
		public procInsertUserDataResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsValid", DbType="Bit")]
		public System.Nullable<bool> IsValid
		{
			get
			{
				return this._IsValid;
			}
			set
			{
				if ((this._IsValid != value))
				{
					this._IsValid = value;
				}
			}
		}
	}
}
#pragma warning restore 1591