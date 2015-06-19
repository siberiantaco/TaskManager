﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager.Models
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
    using System.ComponentModel.DataAnnotations;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TaskMan")]
	public partial class TaskManDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTask(Task instance);
    partial void UpdateTask(Task instance);
    partial void DeleteTask(Task instance);
    #endregion
		
		public TaskManDbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TaskManConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TaskManDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaskManDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaskManDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaskManDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Task> Tasks
		{
			get
			{
				return this.GetTable<Task>();
			}
		}
	}

    [MetadataType(typeof(ITask))]
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tasks")]
	public partial class Task : ITask, INotifyPropertyChanging, INotifyPropertyChanged
	{
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
        
		private string _Name;
		
		private string _Description;
		
		private string _Executives;

		private System.DateTime _RegDate;
		
		private int _Status;
		
		private int _Laboriousness;
		
		private System.TimeSpan _TaskTime;
		
		private System.DateTime _EndDate;
		
		private System.Nullable<int> _Parent;
		
		private EntitySet<Task> _Tasks;
		
		private EntityRef<Task> _Task1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnExecutivesChanging(string value);
    partial void OnExecutivesChanged();
    partial void OnRegDateChanging(System.DateTime value);
    partial void OnRegDateChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    partial void OnLaboriousnessChanging(int value);
    partial void OnLaboriousnessChanged();
    partial void OnTaskTimeChanging(System.TimeSpan value);
    partial void OnTaskTimeChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    partial void OnParentChanging(System.Nullable<int> value);
    partial void OnParentChanged();
    #endregion
		
		public Task()
		{
			this._Tasks = new EntitySet<Task>(new Action<Task>(this.attach_Tasks), new Action<Task>(this.detach_Tasks));
			this._Task1 = default(EntityRef<Task>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]

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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
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
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Executives", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Executives
		{
			get
			{
				return this._Executives;
			}
			set
			{
				if ((this._Executives != value))
				{
					this.OnExecutivesChanging(value);
					this.SendPropertyChanging();
					this._Executives = value;
					this.SendPropertyChanged("Executives");
					this.OnExecutivesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegDate", DbType="Date NOT NULL")]
		public System.DateTime RegDate
		{
			get
			{
				return this._RegDate;
			}
			set
			{
				if ((this._RegDate != value))
				{
					this.OnRegDateChanging(value);
					this.SendPropertyChanging();
					this._RegDate = value;
					this.SendPropertyChanged("RegDate");
					this.OnRegDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int NOT NULL")]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Laboriousness", DbType="Int NOT NULL")]
		public int Laboriousness
		{
			get
			{
				return this._Laboriousness;
			}
			set
			{
				if ((this._Laboriousness != value))
				{
					this.OnLaboriousnessChanging(value);
					this.SendPropertyChanging();
					this._Laboriousness = value;
					this.SendPropertyChanged("Laboriousness");
					this.OnLaboriousnessChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskTime", DbType="Time NOT NULL")]
		public System.TimeSpan TaskTime
		{
			get
			{
				return this._TaskTime;
			}
			set
			{
				if ((this._TaskTime != value))
				{
					this.OnTaskTimeChanging(value);
					this.SendPropertyChanging();
					this._TaskTime = value;
					this.SendPropertyChanged("TaskTime");
					this.OnTaskTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="Date NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parent", DbType="Int")]
		public System.Nullable<int> Parent
		{
			get
			{
				return this._Parent;
			}
			set
			{
				if ((this._Parent != value))
				{
					if (this._Task1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnParentChanging(value);
					this.SendPropertyChanging();
					this._Parent = value;
					this.SendPropertyChanged("Parent");
					this.OnParentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Task_Task", Storage="_Tasks", ThisKey="Id", OtherKey="Parent")]
		public EntitySet<Task> Tasks
		{
			get
			{
				return this._Tasks;
			}
			set
			{
				this._Tasks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Task_Task", Storage="_Task1", ThisKey="Parent", OtherKey="Id", IsForeignKey=true)]
		public Task Task1
		{
			get
			{
				return this._Task1.Entity;
			}
			set
			{
				Task previousValue = this._Task1.Entity;
				if (((previousValue != value) 
							|| (this._Task1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Task1.Entity = null;
						previousValue.Tasks.Remove(this);
					}
					this._Task1.Entity = value;
					if ((value != null))
					{
						value.Tasks.Add(this);
						this._Parent = value.Id;
					}
					else
					{
						this._Parent = default(Nullable<int>);
					}
					this.SendPropertyChanged("Task1");
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
		
		private void attach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.Task1 = this;
		}
		
		private void detach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.Task1 = null;
		}
	}
}
#pragma warning restore 1591
